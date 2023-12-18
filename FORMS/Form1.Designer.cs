
namespace Kurichev_Lab3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GoAddForm = new System.Windows.Forms.PictureBox();
            this.GoModifyForm = new System.Windows.Forms.PictureBox();
            this.GoRemoveForm = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.таблицаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.BoxCategoryFilter = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BoxFilter = new System.Windows.Forms.CheckBox();
            this.BoxFilterName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GoAddForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoModifyForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoRemoveForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GoAddForm
            // 
            this.GoAddForm.BackColor = System.Drawing.Color.Transparent;
            this.GoAddForm.Location = new System.Drawing.Point(-3, 258);
            this.GoAddForm.Name = "GoAddForm";
            this.GoAddForm.Size = new System.Drawing.Size(358, 74);
            this.GoAddForm.TabIndex = 2;
            this.GoAddForm.TabStop = false;
            this.GoAddForm.Click += new System.EventHandler(this.GoAddForm_Click_1);
            // 
            // GoModifyForm
            // 
            this.GoModifyForm.BackColor = System.Drawing.Color.Transparent;
            this.GoModifyForm.Location = new System.Drawing.Point(-3, 338);
            this.GoModifyForm.Name = "GoModifyForm";
            this.GoModifyForm.Size = new System.Drawing.Size(358, 69);
            this.GoModifyForm.TabIndex = 3;
            this.GoModifyForm.TabStop = false;
            this.GoModifyForm.Click += new System.EventHandler(this.GoModifyForm_Click);
            // 
            // GoRemoveForm
            // 
            this.GoRemoveForm.BackColor = System.Drawing.Color.Transparent;
            this.GoRemoveForm.Location = new System.Drawing.Point(-3, 422);
            this.GoRemoveForm.Name = "GoRemoveForm";
            this.GoRemoveForm.Size = new System.Drawing.Size(358, 65);
            this.GoRemoveForm.TabIndex = 4;
            this.GoRemoveForm.TabStop = false;
            this.GoRemoveForm.Click += new System.EventHandler(this.GoRemoveForm_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(436, 118);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(760, 313);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 6;
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицаToolStripMenuItem1,
            this.добавитьToolStripMenuItem1,
            this.редактироватьToolStripMenuItem1,
            this.удалитьToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 92);
            // 
            // таблицаToolStripMenuItem1
            // 
            this.таблицаToolStripMenuItem1.Name = "таблицаToolStripMenuItem1";
            this.таблицаToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.таблицаToolStripMenuItem1.Text = "Таблица";
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            this.добавитьToolStripMenuItem1.Click += new System.EventHandler(this.добавитьToolStripMenuItem1_Click);
            // 
            // редактироватьToolStripMenuItem1
            // 
            this.редактироватьToolStripMenuItem1.Name = "редактироватьToolStripMenuItem1";
            this.редактироватьToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.редактироватьToolStripMenuItem1.Text = "Редактировать";
            this.редактироватьToolStripMenuItem1.Click += new System.EventHandler(this.редактироватьToolStripMenuItem1_Click);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.удалитьToolStripMenuItem1_Click);
            // 
            // BoxCategoryFilter
            // 
            this.BoxCategoryFilter.FormattingEnabled = true;
            this.BoxCategoryFilter.Location = new System.Drawing.Point(436, 579);
            this.BoxCategoryFilter.Name = "BoxCategoryFilter";
            this.BoxCategoryFilter.Size = new System.Drawing.Size(591, 21);
            this.BoxCategoryFilter.TabIndex = 7;
            this.BoxCategoryFilter.SelectedIndexChanged += new System.EventHandler(this.BoxCategoryFilter_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Uni Sans Heavy Caps", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1046, 579);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "Категории";
            // 
            // BoxFilter
            // 
            this.BoxFilter.AutoSize = true;
            this.BoxFilter.Font = new System.Drawing.Font("Uni Sans Heavy Caps", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BoxFilter.Location = new System.Drawing.Point(436, 545);
            this.BoxFilter.Name = "BoxFilter";
            this.BoxFilter.Size = new System.Drawing.Size(161, 28);
            this.BoxFilter.TabIndex = 32;
            this.BoxFilter.Text = "Фильтрация";
            this.BoxFilter.UseVisualStyleBackColor = true;
            this.BoxFilter.CheckedChanged += new System.EventHandler(this.BoxFilter_CheckedChanged);
            // 
            // BoxFilterName
            // 
            this.BoxFilterName.Location = new System.Drawing.Point(436, 519);
            this.BoxFilterName.Name = "BoxFilterName";
            this.BoxFilterName.Size = new System.Drawing.Size(582, 20);
            this.BoxFilterName.TabIndex = 33;
            this.BoxFilterName.TextChanged += new System.EventHandler(this.BoxFilterName_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(436, 467);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 20);
            this.textBox1.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(689, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Минимальная Цена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kurichev_Lab3.Properties.Resources.Main_00000;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BoxFilterName);
            this.Controls.Add(this.BoxFilter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BoxCategoryFilter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GoRemoveForm);
            this.Controls.Add(this.GoModifyForm);
            this.Controls.Add(this.GoAddForm);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Ломать - не строить";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GoAddForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoModifyForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoRemoveForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GoAddForm;
        private System.Windows.Forms.PictureBox GoModifyForm;
        private System.Windows.Forms.PictureBox GoRemoveForm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблицаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.ComboBox BoxCategoryFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox BoxFilter;
        private System.Windows.Forms.TextBox BoxFilterName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

