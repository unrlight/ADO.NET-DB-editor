
namespace Kurichev_Lab3
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.GoMainForm = new System.Windows.Forms.PictureBox();
            this.GoModifyForm = new System.Windows.Forms.PictureBox();
            this.GoRemoveForm = new System.Windows.Forms.PictureBox();
            this.BoxCategory = new System.Windows.Forms.TextBox();
            this.BoxName = new System.Windows.Forms.TextBox();
            this.BoxPrice = new System.Windows.Forms.TextBox();
            this.BoxRating = new System.Windows.Forms.TextBox();
            this.BoxAvaliablity = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelErrorOutput = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BoxID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddCategory2 = new System.Windows.Forms.ComboBox();
            this.AddIDcategory = new System.Windows.Forms.TextBox();
            this.AddCategoryName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GoMainForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoModifyForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoRemoveForm)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GoMainForm
            // 
            this.GoMainForm.BackColor = System.Drawing.Color.Transparent;
            this.GoMainForm.Location = new System.Drawing.Point(-5, 180);
            this.GoMainForm.Name = "GoMainForm";
            this.GoMainForm.Size = new System.Drawing.Size(360, 71);
            this.GoMainForm.TabIndex = 0;
            this.GoMainForm.TabStop = false;
            this.GoMainForm.Click += new System.EventHandler(this.GoMainForm_Click);
            // 
            // GoModifyForm
            // 
            this.GoModifyForm.BackColor = System.Drawing.Color.Transparent;
            this.GoModifyForm.Location = new System.Drawing.Point(-5, 341);
            this.GoModifyForm.Name = "GoModifyForm";
            this.GoModifyForm.Size = new System.Drawing.Size(360, 66);
            this.GoModifyForm.TabIndex = 1;
            this.GoModifyForm.TabStop = false;
            this.GoModifyForm.Click += new System.EventHandler(this.GoModifyForm_Click);
            // 
            // GoRemoveForm
            // 
            this.GoRemoveForm.BackColor = System.Drawing.Color.Transparent;
            this.GoRemoveForm.Location = new System.Drawing.Point(-5, 422);
            this.GoRemoveForm.Name = "GoRemoveForm";
            this.GoRemoveForm.Size = new System.Drawing.Size(360, 66);
            this.GoRemoveForm.TabIndex = 2;
            this.GoRemoveForm.TabStop = false;
            this.GoRemoveForm.Click += new System.EventHandler(this.GoRemoveForm_Click);
            // 
            // BoxCategory
            // 
            this.BoxCategory.Location = new System.Drawing.Point(1247, 0);
            this.BoxCategory.Name = "BoxCategory";
            this.BoxCategory.Size = new System.Drawing.Size(17, 20);
            this.BoxCategory.TabIndex = 3;
            this.BoxCategory.TextChanged += new System.EventHandler(this.BoxCategory_TextChanged);
            // 
            // BoxName
            // 
            this.BoxName.Location = new System.Drawing.Point(439, 195);
            this.BoxName.Name = "BoxName";
            this.BoxName.Size = new System.Drawing.Size(482, 20);
            this.BoxName.TabIndex = 4;
            this.BoxName.TextChanged += new System.EventHandler(this.BoxName_TextChanged);
            // 
            // BoxPrice
            // 
            this.BoxPrice.Location = new System.Drawing.Point(439, 231);
            this.BoxPrice.Name = "BoxPrice";
            this.BoxPrice.Size = new System.Drawing.Size(314, 20);
            this.BoxPrice.TabIndex = 5;
            this.BoxPrice.TextChanged += new System.EventHandler(this.BoxPrice_TextChanged);
            // 
            // BoxRating
            // 
            this.BoxRating.Location = new System.Drawing.Point(439, 268);
            this.BoxRating.Name = "BoxRating";
            this.BoxRating.Size = new System.Drawing.Size(112, 20);
            this.BoxRating.TabIndex = 6;
            this.BoxRating.TextChanged += new System.EventHandler(this.BoxRating_TextChanged);
            // 
            // BoxAvaliablity
            // 
            this.BoxAvaliablity.AutoSize = true;
            this.BoxAvaliablity.Font = new System.Drawing.Font("Uni Sans Heavy Caps", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BoxAvaliablity.Location = new System.Drawing.Point(439, 308);
            this.BoxAvaliablity.Name = "BoxAvaliablity";
            this.BoxAvaliablity.Size = new System.Drawing.Size(122, 28);
            this.BoxAvaliablity.TabIndex = 7;
            this.BoxAvaliablity.Text = "Наличие";
            this.BoxAvaliablity.UseVisualStyleBackColor = true;
            this.BoxAvaliablity.CheckedChanged += new System.EventHandler(this.BoxAvaliablity_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Uni Sans Heavy Caps", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(938, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "категория товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Uni Sans Heavy Caps", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(939, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "наименование товара";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Uni Sans Heavy Caps", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(778, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "цена товара";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Uni Sans Heavy Caps", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(575, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Рейтинг товара";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Uni Sans Heavy Caps", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(439, 354);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(742, 34);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "добавить товар";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Uni Sans Thin Caps", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(1220, 3);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(44, 21);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelErrorOutput
            // 
            this.labelErrorOutput.AutoSize = true;
            this.labelErrorOutput.BackColor = System.Drawing.Color.Red;
            this.labelErrorOutput.Font = new System.Drawing.Font("Uni Sans Heavy Caps", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelErrorOutput.Location = new System.Drawing.Point(489, 582);
            this.labelErrorOutput.Name = "labelErrorOutput";
            this.labelErrorOutput.Size = new System.Drawing.Size(623, 24);
            this.labelErrorOutput.TabIndex = 14;
            this.labelErrorOutput.Text = "ошибка при вводе данных! Запись не будет произведена";
            this.labelErrorOutput.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.vToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицаToolStripMenuItem,
            this.добавитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // таблицаToolStripMenuItem
            // 
            this.таблицаToolStripMenuItem.Name = "таблицаToolStripMenuItem";
            this.таблицаToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.таблицаToolStripMenuItem.Text = "Таблица";
            this.таблицаToolStripMenuItem.Click += new System.EventHandler(this.таблицаToolStripMenuItem_Click_1);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // vToolStripMenuItem
            // 
            this.vToolStripMenuItem.Name = "vToolStripMenuItem";
            this.vToolStripMenuItem.Size = new System.Drawing.Size(25, 20);
            this.vToolStripMenuItem.Text = "v";
            // 
            // BoxID
            // 
            this.BoxID.Location = new System.Drawing.Point(439, 115);
            this.BoxID.Name = "BoxID";
            this.BoxID.Size = new System.Drawing.Size(482, 20);
            this.BoxID.TabIndex = 16;
            this.BoxID.TextChanged += new System.EventHandler(this.BoxID_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Uni Sans Heavy Caps", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(925, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID категории";
            // 
            // AddCategory2
            // 
            this.AddCategory2.FormattingEnabled = true;
            this.AddCategory2.Location = new System.Drawing.Point(439, 155);
            this.AddCategory2.Name = "AddCategory2";
            this.AddCategory2.Size = new System.Drawing.Size(481, 21);
            this.AddCategory2.TabIndex = 17;
            this.AddCategory2.SelectedIndexChanged += new System.EventHandler(this.AddCategory2_SelectedIndexChanged);
            // 
            // AddIDcategory
            // 
            this.AddIDcategory.Location = new System.Drawing.Point(438, 430);
            this.AddIDcategory.Name = "AddIDcategory";
            this.AddIDcategory.Size = new System.Drawing.Size(481, 20);
            this.AddIDcategory.TabIndex = 18;
            this.AddIDcategory.TextChanged += new System.EventHandler(this.AddIDcategory_TextChanged);
            // 
            // AddCategoryName
            // 
            this.AddCategoryName.Location = new System.Drawing.Point(439, 468);
            this.AddCategoryName.Name = "AddCategoryName";
            this.AddCategoryName.Size = new System.Drawing.Size(481, 20);
            this.AddCategoryName.TabIndex = 19;
            this.AddCategoryName.TextChanged += new System.EventHandler(this.AddCategoryName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Uni Sans Heavy Caps", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(926, 463);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "категория";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Uni Sans Heavy Caps", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(439, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(742, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "добавить категорию";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Uni Sans Heavy Caps", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(938, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "ID товара";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kurichev_Lab3.Properties.Resources.Add_00000;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.AddCategoryName);
            this.Controls.Add(this.AddIDcategory);
            this.Controls.Add(this.AddCategory2);
            this.Controls.Add(this.BoxID);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.labelErrorOutput);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoxAvaliablity);
            this.Controls.Add(this.BoxRating);
            this.Controls.Add(this.BoxPrice);
            this.Controls.Add(this.BoxName);
            this.Controls.Add(this.BoxCategory);
            this.Controls.Add(this.GoRemoveForm);
            this.Controls.Add(this.GoModifyForm);
            this.Controls.Add(this.GoMainForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddForm";
            this.Text = "Ломать - не строить";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GoMainForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoModifyForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoRemoveForm)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GoMainForm;
        private System.Windows.Forms.PictureBox GoModifyForm;
        private System.Windows.Forms.PictureBox GoRemoveForm;
        private System.Windows.Forms.TextBox BoxCategory;
        private System.Windows.Forms.TextBox BoxName;
        private System.Windows.Forms.TextBox BoxPrice;
        private System.Windows.Forms.TextBox BoxRating;
        private System.Windows.Forms.CheckBox BoxAvaliablity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelErrorOutput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vToolStripMenuItem;
        private System.Windows.Forms.TextBox BoxID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox AddCategory2;
        private System.Windows.Forms.TextBox AddIDcategory;
        private System.Windows.Forms.TextBox AddCategoryName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
    }
}