using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurichev_Lab3
{
    public partial class RemoveForm : Form
    {
        private string DataLocationPath = @"C:\Users\unrea\source\repos\Kurichev_Lab3\shopdata.txt";
        private int SelectedRow;
        public Kurichev_Lab3.CLASSES.DataBase _DB = new Kurichev_Lab3.CLASSES.DataBase();

        public RemoveForm(int _selectedrow)
        {
            InitializeComponent();
            SelectedRow = _selectedrow;
        }
        public RemoveForm() : this(0)
        {
            InitializeComponent();
        }


        private void GoMainForm_Click(object sender, EventArgs e)
        {
            Form1 fobj = new Form1();
            fobj.StartPosition = FormStartPosition.Manual;
            fobj.Location = this.Location;
            fobj.Size = this.Size;
            fobj.Show();
            this.Hide();
        }

        private void GoAddForm_Click(object sender, EventArgs e)
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
            ModifyForm fobj = new ModifyForm(0);
            fobj.StartPosition = FormStartPosition.Manual;
            fobj.Location = this.Location;
            fobj.Size = this.Size;
            fobj.Show();
            this.Hide();
        }

        private void таблицаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fobj = new Form1();
            fobj.StartPosition = FormStartPosition.Manual;
            fobj.Location = this.Location;
            fobj.Size = this.Size;
            fobj.Show();
            this.Hide();
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
            ModifyForm fobj = new ModifyForm(0);
            fobj.StartPosition = FormStartPosition.Manual;
            fobj.Location = this.Location;
            fobj.Size = this.Size;
            fobj.Show();
            this.Hide();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxTable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (comboBoxTable.SelectedIndex != -1)
            {
                DataTable tempdt = _DB.GetStore();
                _DB.DeleteRow(Convert.ToInt32(tempdt.Rows[comboBoxTable.SelectedIndex][0]));
                // Обновляем комбобокс

                comboBoxTable.Sorted = false;
                DataTable tempdb = _DB.GetStore();
                tempdb.Columns.Add("AllStore", typeof(string), $"{"ID".Trim()} + ', ' + {"Name".Trim()} + ', ' " +
                                $"+ {"CategoryName".Trim()} + ', ' + {"Price".Trim()} + ', ' + {"Rating".Trim()} + ', ' + {"Avel".Trim()}");
                comboBoxTable.DataSource = tempdb;
                comboBoxTable.DisplayMember = "AllStore";

                comboBoxTable.Sorted = false;
            }
            //comboBoxTable.SelectedIndex = -1;
        }

        private void RemoveForm_Load(object sender, EventArgs e)
        {
            comboBoxTable.Sorted = false;
            DataTable tempdb = _DB.GetStore();
            tempdb.Columns.Add("AllStore", typeof(string), $"{"ID".Trim()} + ', ' + {"Name".Trim()} + ', ' " +
                            $"+ {"CategoryName".Trim()} + ', ' + {"Price".Trim()} + ', ' + {"Rating".Trim()} + ', ' + {"Avel".Trim()}");
            comboBoxTable.DataSource = tempdb;
            comboBoxTable.DisplayMember = "AllStore";
            comboBoxTable.Sorted = false;

            if ((SelectedRow == 1 || SelectedRow > 1 || SelectedRow == 0) && comboBoxTable.Text != "")
                comboBoxTable.SelectedIndex = SelectedRow;
            else
                comboBoxTable.SelectedIndex = -1;


            BoxCategory.DataSource = _DB.AllData.Tables["Categorys"];
            BoxCategory.DisplayMember = "CategoryName";
        }

        private void buttonCategoryRemove_Click(object sender, EventArgs e)
        {
            _DB.DeleteRowCategory(BoxCategory.Text.ToString().Trim());
        }
    }
}
