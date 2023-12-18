using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kurichev_Lab3
{
    public partial class AddForm : Form
    {
        private int AddCategoryID;
        private string AddCategoryNameS;
        private int AddID;
        private string AddCategory;
        private string AddName;
        private int AddPrice;
        private double AddRating;
        private bool AddAvaliability;
        private string DataLocationPath = @"C:\Users\unrea\source\repos\Kurichev_Lab3\shopdata.txt";
        //private bool ErrorState = false;
        public Kurichev_Lab3.CLASSES.DataBase _DB = new Kurichev_Lab3.CLASSES.DataBase();

        public AddForm()
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

        private void GoModifyForm_Click(object sender, EventArgs e)
        {
            ModifyForm fobj = new ModifyForm(0);
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

        private void ClearBox()
        {
            BoxCategory.Text = "";
            BoxName.Text = "";
            BoxPrice.Text = "";
            BoxRating.Text = "";
            BoxID.Text = "";
            BoxAvaliablity.Checked = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CheckInput();
            string Data = File.ReadAllText(DataLocationPath);
            if (labelErrorOutput.Visible == false)
            {
              _DB.AddQuery(AddID, AddName, Convert.ToInt32(AddCategory), AddPrice, AddRating, AddAvaliability);
              ClearBox();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearBox();
        }

        private void BoxCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void BoxName_TextChanged(object sender, EventArgs e)
        {
            AddName = BoxName.Text;
            labelErrorOutput.Visible = false;
        }

        private void BoxPrice_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(BoxPrice.Text, @"^\d+$"))
             {
                AddPrice = Convert.ToInt32(BoxPrice.Text);
                labelErrorOutput.Visible = false;
             }
        }

        private void BoxRating_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(BoxRating.Text, @"^\d+$"))
            {
                AddRating = Convert.ToDouble(BoxRating.Text);
                labelErrorOutput.Visible = false;
            }
        }

        private void BoxAvaliablity_CheckedChanged(object sender, EventArgs e)
        {
            AddAvaliability = BoxAvaliablity.Checked;
        }


        private void таблицаToolStripMenuItem_Click_1(object sender, EventArgs e)
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
            RemoveForm fobj = new RemoveForm(0);
            fobj.StartPosition = FormStartPosition.Manual;
            fobj.Location = this.Location;
            fobj.Size = this.Size;
            fobj.Show();
            this.Hide();
        }

        private void BoxID_TextChanged(object sender, EventArgs e)
        {
            if (BoxID.Text != "")
            {
                AddID = Convert.ToInt32(BoxID.Text);
                labelErrorOutput.Visible = false;
            }
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            AddCategory2.DataSource = _DB.AllData.Tables["Categorys"];
            AddCategory2.DisplayMember = "CategoryName";
        }

        private void AddCategory2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((AddCategory2.Text.Trim()) != null && (AddCategory2.Text.Trim()) != "System.Data.DataRowView")
            {
                AddCategory = _DB.GetCategoryIDbyName(AddCategory2.Text.Trim()).Rows[0][0].ToString();
                labelErrorOutput.Visible = false;
            }
        }

        private void AddIDcategory_TextChanged(object sender, EventArgs e)
        {
            AddCategoryID = Convert.ToInt32(AddIDcategory.Text);
        }

        private void AddCategoryName_TextChanged(object sender, EventArgs e)
        {
            AddCategoryNameS = AddCategoryName.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AddCategoryNameS!="" && AddCategoryNameS!=null)
                _DB.AddCategoryQuery(AddCategoryNameS, AddCategoryID);

            AddCategory2.DataSource = _DB.AllData.Tables["Categorys"];
            AddCategory2.DisplayMember = "CategoryName";
        }
    }
}
