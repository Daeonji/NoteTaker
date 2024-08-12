using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTaker
{
    public partial class NoteTaker : Form
    {
        DataTable notes = new DataTable();
        bool editing = false;  
        public NoteTaker()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");

            prevNotes.DataSource = notes;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void prevNotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadBttn_Click(object sender, EventArgs e)
        {
            titleBox.Text = notes.Rows[prevNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteBox.Text = notes.Rows[prevNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }

        private void delBttn_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows[prevNotes.CurrentCell.RowIndex].Delete();
            }
            catch
            {
                Console.WriteLine("Not a valid note");
            }
        }

        private void newBttn_Click(object sender, EventArgs e)
        {
            titleBox.Text = "";
            noteBox.Text = "";
        }

        private void saveBttn_Click(object sender, EventArgs e)
        {
            if(editing)
            {
                notes.Rows[prevNotes.CurrentCell.RowIndex]["Title"] = titleBox.Text;
                notes.Rows[prevNotes.CurrentCell.RowIndex]["Note"] = noteBox.Text;
            }
            else
            {
                notes.Rows.Add(titleBox.Text, noteBox.Text);
            }
            titleBox.Text = "";
            noteBox.Text = "";
            editing = false;

        }
        private void prevNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            titleBox.Text = notes.Rows[prevNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteBox.Text = notes.Rows[prevNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }
    }
}
