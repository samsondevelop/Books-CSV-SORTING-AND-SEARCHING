using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Books_List_App
{
    public partial class Form1 : Form
    {
        List<Book> books = new List<Book>();

        public Form1()
        {
            InitializeComponent();
        }
        HashSet<DataGridViewRow> Rows = new HashSet<DataGridViewRow>();
        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\\Downloads";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Title = "Open The CSV books file";
            openFileDialog.Filter = "csv files (*.csv)|*.csv|txt files (*.txt)|*.txt"; // only allow csv files or text files

            openFileDialog.ShowDialog(); // showing file dialog
            this.TopMost = true; // bringing form back to the top (I noticed that when you usually use file dialog the form gets minimized)
            if (openFileDialog.FileName == String.Empty)
            {
                MessageBox.Show("You must open a csv file!");
                Environment.Exit(0);
            }
            string[] arrReadAllLines = File.ReadAllLines(openFileDialog.FileName);
            for(int i = 0; i < arrReadAllLines.Length; i++)
            {
                string[] items = arrReadAllLines[i].Split(',');// convert to list because you can add to lists after theyre defined
                
                Book book = new Book(items[0], items[1], items[2], items[3], Double.Parse(items[4]), items[5], (items[6]));
                books.Add(book);
                datagridBooks.Rows.Add(book.toarr()); // only takes arrays so I convert it
            }
            for (int i = 0; i < datagridBooks.Rows.Count; i++) // adding the rows to a List that I can use for sorting later
            {
                try
                {
                    if (datagridBooks.Rows[i].Cells[0].Value.ToString() != "0") // validating that the row has data
                    {
                        Rows.Add(datagridBooks.Rows[i]);
                    }
                }
                catch (Exception) { }
                    
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        int cellnum = 999;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // whenever the selection index is changed the rating is called
        {
            cellnum = comboBox1.SelectedIndex; // setting celnum for search, means I only need the search code once
            if(comboBox1.SelectedIndex == 2)
            {
                List<DataGridViewRow> sortedRows = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in datagridBooks.Rows)
                {
                    try
                    {
                        if (row.Cells[0].Value.ToString() != "0") // validating that the row has data
                            sortedRows.Add(row);
                    }
                    catch(Exception) { }
                }
                bool sorted = false;
                DataGridViewRow dgvrTemp = new DataGridViewRow();
                int iStorage = 0;
                int iLowest = 999;
                int rounds = 0;
                int count = 0;
                while (!sorted)
                {
                    sorted = true;
                    count = 0;
                    for (int i = 0; i < sortedRows.Count; i++) // selection sort
                    {  
                        if (i >= rounds)
                        {
                            try // sometimes has errors so I added a catch statement
                            {
                                
                                if (int.TryParse(sortedRows[i].Cells[6].Value.ToString(), out iStorage)) // filtering out the "none" ratings
                                {
                                    count++;
                                    if (iStorage < iLowest)
                                    {
                                        iLowest = iStorage;
                                        dgvrTemp = sortedRows[i];
                                        sorted = false;
                                        
                                    }
                                }
                            }
                            catch(Exception)
                            {}
                        }

                    }
                    sortedRows.Remove(dgvrTemp); // remove row
                    if(count > 0)
                    {
                        sortedRows.Insert(rounds, dgvrTemp);
                    }
                    else
                    {
                        sortedRows.Insert(rounds-1, dgvrTemp); // checking if theres more than 1 valid number, if theres not it moves 1 back
                        // to make sure its in the right order
                    }
                     // then add it back in its spot
                    iLowest = 999;
                    rounds++;
                }
                datagridBooks.Rows.Clear();
                for (int i = 0; i < sortedRows.Count; i++)
                {
                    datagridBooks.Rows.Add(sortedRows[i]); // validation not needed here         
                }
            }
        }
        HashSet<DataGridViewRow> Filter = new HashSet<DataGridViewRow>();
        
        private void textBox1_TextChanged(object sender, EventArgs e) // whenever the textbox text is changed the filters are called
        {
            if(comboBox1.SelectedIndex != 2) // making sure its not rating selected
            {
                foreach (DataGridViewRow row in Rows)
                {
                    if (row.Cells[cellnum].Value.ToString().ToLower().Contains(textBox1.Text.ToLower()))
                    {
                        Filter.Add(row);
                    }
                }
                datagridBooks.Rows.Clear();
                foreach (DataGridViewRow row in Filter)
                {
                    datagridBooks.Rows.Add(row);
                }
                Filter.Clear();
            }
            
        }
    }
}
