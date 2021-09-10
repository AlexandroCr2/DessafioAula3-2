using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DessafioAula3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
       
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        

            dataGridView1.Rows.Add("Pedro", "10", "1", "10");
            dataGridView1.Rows.Add("Joao", "12", "2", "9");
            dataGridView1.Rows.Add("Maria ", "9", "2", "10");
            dataGridView1.Rows.Add("Carlos", "8", "3", "8");
            dataGridView1.Rows.Add("Roberto", "6", "2", "9");


        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
