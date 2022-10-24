using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mySQL_Practice_2
{
    public partial class Form1 : Form
    {

        BindingSource albumBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void loadButtonClicked(object sender, EventArgs e)
        {
            AlbumDAO albumDAO = new AlbumDAO();





            // connect the list to the grid view control

            albumBindingSource.DataSource = albumDAO.getAllAlbums();

            dataGridView1.DataSource = albumBindingSource;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchButtonClicked(object sender, EventArgs e)
        {
            AlbumDAO albumDAO = new AlbumDAO();





            // connect the list to the grid view control

            albumBindingSource.DataSource = albumDAO.searchTitles(textBox1.Text);

            dataGridView1.DataSource = albumBindingSource;
        }
    }
}
