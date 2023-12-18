using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurichev_Lab3
{
    public partial class ModifyForm : Form
    {
        DataTable temp;
        private int AddID;
        private string AddCategory;
        private string AddName;
        private int AddPrice;
        private double AddRating;
        private bool AddAvaliability;
        private string DataLocationPath = @"C:\Users\unrea\source\repos\Kurichev_Lab3\shopdata.txt";
        //private bool ErrorState = false;
        private int SelectedRow = 0;
        public Kurichev_Lab3.CLASSES.DataBase _DB = new Kurichev_Lab3.CLASSES.DataBase();


        public ModifyForm(int _selectedrow)
        {
            InitializeComponent();
            SelectedRow = _selectedrow;
        }
        public ModifyForm() : this(0)
        {
            InitializeComponent();
        }
        private void CheckInput() // Метод для проверки текстбоксов
        {
            if (BoxName.Text != " " && BoxName.Text != "" && BoxName.Text != null && !BoxName.Text.Contains(";") &&
                BoxPrice.Text != " " && BoxPrice.Text != "" && BoxPrice.Text != null && !BoxPrice.Text.Contains(";") && Regex.IsMatch(BoxPrice.Text, @"^\d+$") &&
                BoxRating.Text != " " && BoxRating.Text != "" && BoxRating.Text != null && !BoxRating.Text.Contains(";") && Regex.IsMatch(BoxRating.Text, @"^\d+$")
                )

                labelErrorOutput.Visible = false;
            else
                labelErrorOutput.Visible = true;
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

        private void GoRemoveForm_Click(object sender, EventArgs e)
        {
            RemoveForm fobj = new RemoveForm(0);
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

        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveForm fobj = new RemoveForm(0);
            fobj.StartPosition = FormStartPosition.Manual;
            fobj.Location = this.Location;
            fobj.Size = this.Size;
            fobj.Show();
            this.Hide();
        }

        private void ModifyForm_Load(object sender, EventArgs e)
        {
            comboBoxTable.Sorted = false;
            DataTable tempdb = _DB.GetStore();
            tempdb.Columns.Add("AllStore", typeof(string), $"{"ID".Trim()} + ', ' + {"Name".Trim()} + ', ' " +
                            $"+ {"CategoryName".Trim()} + ', ' + {"Price".Trim()} + ', ' + {"Rating".Trim()} + ', ' + {"Avel".Trim()}");
            comboBoxTable.DataSource = tempdb;
            comboBoxTable.DisplayMember = "AllStore";

            if ((SelectedRow == 1 || SelectedRow > 1 || SelectedRow == 0)&& comboBoxTable.Text!="")
                comboBoxTable.SelectedIndex = SelectedRow;
            else
                comboBoxTable.SelectedIndex = -1;

            BoxCategory2.DataSource = _DB.AllData.Tables["Categorys"];
            BoxCategory2.DisplayMember = "CategoryName";
        }

        private void BoxCategory_TextChanged(object sender, EventArgs e)
        {
            ;
        }

        private void BoxName_TextChanged(object sender, EventArgs e)
        {
            AddName = BoxName.Text;
            labelErrorOutput.Visible = false;
        }

        private void BoxPrice_TextChanged(object sender, EventArgs e)
        {
            if(Regex.IsMatch(BoxPrice.Text, @"^\d+$"))
                AddPrice = Convert.ToInt32(BoxPrice.Text);

            labelErrorOutput.Visible = false;
        }

        private void BoxRating_TextChanged(object sender, EventArgs e)
        {
            if(Regex.IsMatch(BoxRating.Text, @"^\d+$"))
                AddRating = Convert.ToDouble(BoxRating.Text);

            labelErrorOutput.Visible = false;
        }

        private void BoxAvaliablity_CheckedChanged(object sender, EventArgs e)
        {
            AddAvaliability = BoxAvaliablity.Checked;
            labelErrorOutput.Visible = false;
        }

        private void ClearBox()
        {
            // Очищаем поля
            BoxCategory.Text = "";
            BoxName.Text = "";
            BoxPrice.Text = "";
            BoxRating.Text = "";
            BoxID.Text = "";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            CheckInput();
            if (labelErrorOutput.Visible == false)
            {

                _DB.EditQuery(AddID, AddName, Convert.ToInt32(AddCategory), AddPrice, AddRating, AddAvaliability);

                // Обновляем комбобокс
                comboBoxTable.Sorted = false;
                DataTable tempdb = _DB.GetStore();
                tempdb.Columns.Add("AllStore", typeof(string), $"{"ID".Trim()} + ', ' + {"Name".Trim()} + ', ' " +
                                $"+ {"CategoryName".Trim()} + ', ' + {"Price".Trim()} + ', ' + {"Rating".Trim()} + ', ' + {"Avel".Trim()}");
                comboBoxTable.DataSource = tempdb;
                comboBoxTable.DisplayMember = "AllStore";

                ClearBox();
            }

        }

        private void comboBoxTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tempdt = _DB.GetStore();
            BoxID.Text = tempdt.Rows[comboBoxTable.SelectedIndex][0].ToString();
            BoxName.Text = tempdt.Rows[comboBoxTable.SelectedIndex][1].ToString();
            BoxCategory2.Text = tempdt.Rows[comboBoxTable.SelectedIndex][2].ToString();
            BoxPrice.Text = tempdt.Rows[comboBoxTable.SelectedIndex][3].ToString();
            BoxRating.Text = tempdt.Rows[comboBoxTable.SelectedIndex][4].ToString();
            if (tempdt.Rows[comboBoxTable.SelectedIndex][5].ToString().Trim()=="1")
            {
                BoxAvaliablity.Checked = true;
            } 
            else
                BoxAvaliablity.Checked = false;
        }

        private void BoxCategory2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((BoxCategory2.Text.Trim()) != null && (BoxCategory2.Text.Trim()) != "System.Data.DataRowView")
            {
                AddCategory = _DB.GetCategoryIDbyName(BoxCategory2.Text.Trim()).Rows[0][0].ToString();
                labelErrorOutput.Visible = false;
            }
        }

        private void BoxID_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(BoxRating.Text, @"^\d+$") && BoxID.Text!="")
                AddID = Convert.ToInt32(BoxID.Text);

            labelErrorOutput.Visible = false;
        }
    }
}
