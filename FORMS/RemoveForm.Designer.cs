
namespace Kurichev_Lab3
{
    partial class RemoveForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveForm));
            this.GoMainForm = new System.Windows.Forms.PictureBox();
            this.GoAddForm = new System.Windows.Forms.PictureBox();
            this.GoModifyForm = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxTable = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.BoxCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCategoryRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GoMainForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoAddForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoModifyForm)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GoMainForm
            // 
            this.GoMainForm.BackColor = System.Drawing.Color.Transparent;
            this.GoMainForm.Location = new System.Drawing.Point(-4, 181);
            this.GoMainForm.Name = "GoMainForm";
            this.GoMainForm.Size = new System.Drawing.Size(362, 69);
            this.GoMainForm.TabIndex = 0;
            this.GoMainForm.TabStop = false;
            this.GoMainForm.Click += new System.EventHandler(this.GoMainForm_Click);
            // 
            // GoAddForm
            // 
            this.GoAddForm.BackColor = System.Drawing.Color.Transparent;
            this.GoAddForm.Location = new System.Drawing.Point(-22, 266);
            this.GoAddForm.Name = "GoAddForm";
            this.GoAddForm.Size = new System.Drawing.Size(380, 62);
            this.GoAddForm.TabIndex = 1;
            this.GoAddForm.TabStop = false;
            this.GoAddForm.Click += new System.EventHandler(this.GoAddForm_Click);
            // 
            // GoModifyForm
            // 
            this.GoModifyForm.BackColor = System.Drawing.Color.Transparent;
            this.GoModifyForm.Location = new System.Drawing.Point(-4, 345);
            this.GoModifyForm.Name = "GoModifyForm";
            this.GoModifyForm.Size = new System.Drawing.Size(362, 64);
            this.GoModifyForm.TabIndex = 2;
            this.GoModifyForm.TabStop = false;
            this.GoModifyForm.Click += new System.EventHandler(this.GoModifyForm_Click);
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
            // comboBoxTable
            // 
            this.comboBoxTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTable.FormattingEnabled = true;
            this.comboBoxTable.Location = new System.Drawing.Point(443, 152);
            this.comboBoxTable.Name = "comboBoxTable";
            this.comboBoxTable.Size = new System.Drawing.Size(482, 21);
            this.comboBoxTable.TabIndex = 31;
            this.comboBoxTable.SelectedIndexChanged += new System.EventHandler(this.comboBoxTable_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Uni Sans Heavy Caps", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(943, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "выбор строки";
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Uni Sans Heavy Caps", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemove.Location = new System.Drawing.Point(443, 189);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(749, 61);
            this.buttonRemove.TabIndex = 29;
            this.buttonRemove.Text = "Удалить строку";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // BoxCategory
            // 
            this.BoxCategory.FormattingEnabled = true;
            this.BoxCategory.Location = new System.Drawing.Point(443, 303);
            this.BoxCategory.Name = "BoxCategory";
            this.BoxCategory.Size = new System.Drawing.Size(482, 21);
            this.BoxCategory.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Uni Sans Heavy Caps", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(931, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "выбор категории";
            // 
            // buttonCategoryRemove
            // 
            this.buttonCategoryRemove.Font = new System.Drawing.Font("Uni Sans Heavy Caps", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCategoryRemove.Location = new System.Drawing.Point(443, 345);
            this.buttonCategoryRemove.Name = "buttonCategoryRemove";
            this.buttonCategoryRemove.Size = new System.Drawing.Size(749, 61);
            this.buttonCategoryRemove.TabIndex = 29;
            this.buttonCategoryRemove.Text = "Удалить категорию";
            this.buttonCategoryRemove.UseVisualStyleBackColor = true;
            this.buttonCategoryRemove.Click += new System.EventHandler(this.buttonCategoryRemove_Click);
            // 
            // RemoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kurichev_Lab3.Properties.Resources.Remove_00000;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.BoxCategory);
            this.Controls.Add(this.comboBoxTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonCategoryRemove);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.GoModifyForm);
            this.Controls.Add(this.GoAddForm);
            this.Controls.Add(this.GoMainForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RemoveForm";
            this.Text = "Ломать - не строить";
            this.Load += new System.EventHandler(this.RemoveForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GoMainForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoAddForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoModifyForm)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GoMainForm;
        private System.Windows.Forms.PictureBox GoAddForm;
        private System.Windows.Forms.PictureBox GoModifyForm;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxTable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.ComboBox BoxCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCategoryRemove;
    }
}