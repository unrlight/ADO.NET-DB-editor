using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurichev_Lab3
{

    public partial class Form1 : Form
    {
        public int SelectedRow;
        public bool Filter;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
        }

        private void GoAddForm_Click_1(object sender, EventArgs e)
        {
            AddForm fobj = new AddForm();
            fobj.StartPosition = FormStartPosition.Manual;
            fobj.Location = this.Location;
            fobj.Size = this.Size;
            fobj.Show();
            this.Hide();
        }

        private void GoModifyForm_Click(object sender, EventArgs e)
        {
            ModifyForm fobj = new ModifyForm(SelectedRow);
            fobj.StartPosition = FormStartPosition.Manual;
            fobj.Location = this.Location;
            fobj.Size = this.Size;
            fobj.Show();
            this.Hide();
        }

        private void GoRemoveForm_Click(object sender, EventArgs e)
        {
            RemoveForm fobj = new RemoveForm(SelectedRow);
            fobj.StartPosition = FormStartPosition.Manual;
            fobj.Location = this.Location;
            fobj.Size = this.Size;
            fobj.Show();
            this.Hide();
        }

        public TxtToList GridData = new TxtToList();
        public Kurichev_Lab3.CLASSES.DataBase _DB = new Kurichev_Lab3.CLASSES.DataBase();
        private void FillTable()
        {
            DataTable StoreData;
            if (Filter)
            {
                int tempID = Convert.ToInt32(_DB.GetCategoryIDbyName(BoxCategoryFilter.Text.Trim()).Rows[0][0]);
                StoreData = _DB.GetFilterCategorys(tempID);
                dataGridView1.DataSource = StoreData;
            }
            else
                StoreData = _DB.GetStore();
                dataGridView1.DataSource = StoreData;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = GridData.itemList;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.BackgroundColor = Color.FromArgb(255, 236, 236);
            dataGridView1.GridColor = Color.Black;

            foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 236, 236);
                    row.Height = 90;
                }

            foreach (DataGridViewColumn c in dataGridView1.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 20F, GraphicsUnit.Pixel);
                c.Width = 140;
            }

            FillTable();

            BoxCategoryFilter.DataSource = _DB.AllData.Tables["Categorys"];
            BoxCategoryFilter.DisplayMember = "CategoryName";
        }

        private void таблицаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddForm fobj = new AddForm();
            fobj.StartPosition = FormStartPosition.Manual;
            fobj.Location = this.Location;
            fobj.Size = this.Size;
            fobj.Show();
            this.Hide();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyForm fobj = new ModifyForm(SelectedRow);
            fobj.StartPosition = FormStartPosition.Manual;
            fobj.Location = this.Location;
            fobj.Size = this.Size;
            fobj.Show();
            this.Hide();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveForm fobj = new RemoveForm(SelectedRow);
            fobj.StartPosition = FormStartPosition.Manual;
            fobj.Location = this.Location;
            fobj.Size = this.Size;
            fobj.Show();
            this.Hide();
        }

        private void добавитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddForm fobj = new AddForm();
            fobj.StartPosition = FormStartPosition.Manual;
            fobj.Location = this.Location;
            fobj.Size = this.Size;
            fobj.Show();
            this.Hide();
        }

        private void редактироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ModifyForm fobj = new ModifyForm(SelectedRow);
            fobj.StartPosition = FormStartPosition.Manual;
            fobj.Location = this.Location;
            fobj.Size = this.Size;
            fobj.Show();
            this.Hide();
        }

        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RemoveForm fobj = new RemoveForm(SelectedRow);
            fobj.StartPosition = FormStartPosition.Manual;
            fobj.Location = this.Location;
            fobj.Size = this.Size;
            fobj.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = dataGridView1.CurrentCell.RowIndex;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = dataGridView1.CurrentCell.RowIndex;
        }

        private void BoxCategoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillTable();
        }

        private void BoxFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (BoxFilter.CheckState == CheckState.Checked)
            {
                Filter = true;
                FillTable();
            }
            else
                Filter = false;
                FillTable();
        }

        private void BoxFilterName_TextChanged(object sender, EventArgs e)
        {
            string tempname = BoxFilterName.Text;
            var StoreData = _DB.GetFilterName(tempname);
            dataGridView1.DataSource = StoreData;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = _DB.GetMinPrice().Rows[0][0].ToString();
        }
    }
}
