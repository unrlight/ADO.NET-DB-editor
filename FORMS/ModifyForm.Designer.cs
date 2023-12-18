
namespace Kurichev_Lab3
{
    partial class ModifyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyForm));
            this.GoMainForm = new System.Windows.Forms.PictureBox();
            this.GoAddForm = new System.Windows.Forms.PictureBox();
            this.GoRemoveForm = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelErrorOutput = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxAvaliablity = new System.Windows.Forms.CheckBox();
            this.BoxRating = new System.Windows.Forms.TextBox();
            this.BoxPrice = new System.Windows.Forms.TextBox();
            this.BoxName = new System.Windows.Forms.TextBox();
            this.BoxCategory = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTable = new System.Windows.Forms.ComboBox();
            this.BoxID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BoxCategory2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GoMainForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoAddForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoRemoveForm)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GoMainForm
            // 
            this.GoMainForm.BackColor = System.Drawing.Color.Transparent;
            this.GoMainForm.Location = new System.Drawing.Point(-4, 180);
            this.GoMainForm.Name = "GoMainForm";
            this.GoMainForm.Size = new System.Drawing.Size(362, 72);
            this.GoMainForm.TabIndex = 0;
            this.GoMainForm.TabStop = false;
            this.GoMainForm.Click += new System.EventHandler(this.GoMainForm_Click);
            // 
            // GoAddForm
            // 
            this.GoAddForm.BackColor = System.Drawing.Color.Transparent;
            this.GoAddForm.Location = new System.Drawing.Point(-4, 258);
            this.GoAddForm.Name = "GoAddForm";
            this.GoAddForm.Size = new System.Drawing.Size(362, 73);
            this.GoAddForm.TabIndex = 1;
            this.GoAddForm.TabStop = false;
            this.GoAddForm.Click += new System.EventHandler(this.GoAddForm_Click);
            // 
            // GoRemoveForm
            // 
            this.GoRemoveForm.BackColor = System.Drawing.Color.Transparent;
            this.GoRemoveForm.Location = new System.Drawing.Point(-4, 419);
            this.GoRemoveForm.Name = "GoRemoveForm";
            this.GoRemoveForm.Size = new System.Drawing.Size(362, 69);
            this.GoRemoveForm.TabIndex = 2;
            this.GoRemoveForm.TabStop = false;
            this.GoRemoveForm.Click += new System.EventHandler(this.GoRemoveForm_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 7;
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
            this.таблицаToolStripMenuItem.Click += new System.EventHandler(this.таблицаToolStripMenuItem_Click);
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
            // labelErrorOutput
            // 
            this.labelErrorOutput.AutoSize = true;
            this.labelErrorOutput.BackColor = System.Drawing.Color.Red;
            this.labelErrorOutput.Font = new System.Drawing.Font("Uni Sans Heavy Caps", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelErrorOutput.Location = new System.Drawing.Point(432, 489);
            this.labelErrorOutput.Name = "labelErrorOutput";
            this.labelErrorOutput.Size = new System.Drawing.Size(623, 24);
            this.labelErrorOutput.TabIndex = 26;
            this.labelErrorOutput.Text = "ошибка при вводе данных! Запись не будет произведена";
            this.labelErrorOutput.Visible = false;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Uni Sans Heavy Caps", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(963, 539);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(224, 61);
            this.buttonSave.TabIndex = 24;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Uni Sans Heavy Caps", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(572, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Рейтинг товара";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Uni Sans Heavy Caps", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(775, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "цена товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Uni Sans Heavy Caps", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(936, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "наименование товара";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Uni Sans Heavy Caps", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(936, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "категория товара";
            // 
            // BoxAvaliablity
            // 
            this.BoxAvaliablity.AutoSize = true;
            this.BoxAvaliablity.Font = new System.Drawing.Font("Uni Sans Heavy Caps", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BoxAvaliablity.Location = new System.Drawing.Point(436, 406);
            this.BoxAvaliablity.Name = "BoxAvaliablity";
            this.BoxAvaliablity.Size = new System.Drawing.Size(122, 28);
            this.BoxAvaliablity.TabIndex = 19;
            this.BoxAvaliablity.Text = "Наличие";
            this.BoxAvaliablity.UseVisualStyleBackColor = true;
            this.BoxAvaliablity.CheckedChanged += new System.EventHandler(this.BoxAvaliablity_CheckedChanged);
            // 
            // BoxRating
            // 
            this.BoxRating.Location = new System.Drawing.Point(436, 357);
            this.BoxRating.Name = "BoxRating";
            this.BoxRating.Size = new System.Drawing.Size(112, 20);
            this.BoxRating.TabIndex = 18;
            this.BoxRating.TextChanged += new System.EventHandler(this.BoxRating_TextChanged);
            // 
            // BoxPrice
            // 
            this.BoxPrice.Location = new System.Drawing.Point(436, 311);
            this.BoxPrice.Name = "BoxPrice";
            this.BoxPrice.Size = new System.Drawing.Size(314, 20);
            this.BoxPrice.TabIndex = 17;
            this.BoxPrice.TextChanged += new System.EventHandler(this.BoxPrice_TextChanged);
            // 
            // BoxName
            // 
            this.BoxName.Location = new System.Drawing.Point(436, 267);
            this.BoxName.Name = "BoxName";
            this.BoxName.Size = new System.Drawing.Size(482, 20);
            this.BoxName.TabIndex = 16;
            this.BoxName.TextChanged += new System.EventHandler(this.BoxName_TextChanged);
            // 
            // BoxCategory
            // 
            this.BoxCategory.Location = new System.Drawing.Point(1242, 0);
            this.BoxCategory.Name = "BoxCategory";
            this.BoxCategory.Size = new System.Drawing.Size(10, 20);
            this.BoxCategory.TabIndex = 15;
            this.BoxCategory.Visible = false;
            this.BoxCategory.TextChanged += new System.EventHandler(this.BoxCategory_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Uni Sans Heavy Caps", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(936, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 24);
            this.label5.TabIndex = 27;
            this.label5.Text = "выбор строки";
            // 
            // comboBoxTable
            // 
            this.comboBoxTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTable.FormattingEnabled = true;
            this.comboBoxTable.Location = new System.Drawing.Point(436, 129);
            this.comboBoxTable.Name = "comboBoxTable";
            this.comboBoxTable.Size = new System.Drawing.Size(482, 21);
            this.comboBoxTable.TabIndex = 28;
            this.comboBoxTable.SelectedIndexChanged += new System.EventHandler(this.comboBoxTable_SelectedIndexChanged);
            // 
            // BoxID
            // 
            this.BoxID.Location = new System.Drawing.Point(436, 175);
            this.BoxID.Name = "BoxID";
            this.BoxID.Size = new System.Drawing.Size(482, 20);
            this.BoxID.TabIndex = 29;
            this.BoxID.TextChanged += new System.EventHandler(this.BoxID_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Uni Sans Heavy Caps", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(936, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "ID товара";
            // 
            // BoxCategory2
            // 
            this.BoxCategory2.FormattingEnabled = true;
            this.BoxCategory2.Location = new System.Drawing.Point(436, 220);
            this.BoxCategory2.Name = "BoxCategory2";
            this.BoxCategory2.Size = new System.Drawing.Size(482, 21);
            this.BoxCategory2.TabIndex = 30;
            this.BoxCategory2.SelectedIndexChanged += new System.EventHandler(this.BoxCategory2_SelectedIndexChanged);
            // 
            // ModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kurichev_Lab3.Properties.Resources.Modify_00000;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.BoxCategory2);
            this.Controls.Add(this.BoxID);
            this.Controls.Add(this.comboBoxTable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelErrorOutput);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoxAvaliablity);
            this.Controls.Add(this.BoxRating);
            this.Controls.Add(this.BoxPrice);
            this.Controls.Add(this.BoxName);
            this.Controls.Add(this.BoxCategory);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.GoRemoveForm);
            this.Controls.Add(this.GoAddForm);
            this.Controls.Add(this.GoMainForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifyForm";
            this.Text = "Ломать - не строить";
            this.Load += new System.EventHandler(this.ModifyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GoMainForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoAddForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoRemoveForm)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GoMainForm;
        private System.Windows.Forms.PictureBox GoAddForm;
        private System.Windows.Forms.PictureBox GoRemoveForm;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.Label labelErrorOutput;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox BoxAvaliablity;
        private System.Windows.Forms.TextBox BoxRating;
        private System.Windows.Forms.TextBox BoxPrice;
        private System.Windows.Forms.TextBox BoxName;
        private System.Windows.Forms.TextBox BoxCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxTable;
        private System.Windows.Forms.TextBox BoxID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox BoxCategory2;
    }
}