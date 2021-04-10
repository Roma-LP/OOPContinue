﻿namespace CS_LAB_02
{
    partial class FindForm
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.SimpleTab = new System.Windows.Forms.TabPage();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.LB_DataBuy3Form = new System.Windows.Forms.Label();
            this.dateTimePicker1_3Form = new System.Windows.Forms.DateTimePicker();
            this.GroupLB_ROM3Form = new System.Windows.Forms.GroupBox();
            this.CheckBox_ROM2_3Form = new System.Windows.Forms.CheckBox();
            this.CheckBox_ROM1_3Form = new System.Windows.Forms.CheckBox();
            this.CheckBox_ROM3_3Form = new System.Windows.Forms.CheckBox();
            this.CheckBox_ROM4_3Form = new System.Windows.Forms.CheckBox();
            this.LB_RAM4Form = new System.Windows.Forms.Label();
            this.UpDown_GPU3Form = new System.Windows.Forms.DomainUpDown();
            this.LB_GPU3Form = new System.Windows.Forms.Label();
            this.ComboBox_CPU3Form = new System.Windows.Forms.ComboBox();
            this.LB_CPU3Form = new System.Windows.Forms.Label();
            this.ComboBox_TypePC3Form = new System.Windows.Forms.ComboBox();
            this.LB_typePc3Form = new System.Windows.Forms.Label();
            this.RegTab = new System.Windows.Forms.TabPage();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.BT_Find3Form = new System.Windows.Forms.Button();
            this.TB_Result = new System.Windows.Forms.TextBox();
            this.CloseForm3 = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.SimpleTab.SuspendLayout();
            this.GroupLB_ROM3Form.SuspendLayout();
            this.RegTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.SimpleTab);
            this.TabControl.Controls.Add(this.RegTab);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(776, 204);
            this.TabControl.TabIndex = 0;
            // 
            // SimpleTab
            // 
            this.SimpleTab.Controls.Add(this.domainUpDown1);
            this.SimpleTab.Controls.Add(this.LB_DataBuy3Form);
            this.SimpleTab.Controls.Add(this.dateTimePicker1_3Form);
            this.SimpleTab.Controls.Add(this.GroupLB_ROM3Form);
            this.SimpleTab.Controls.Add(this.LB_RAM4Form);
            this.SimpleTab.Controls.Add(this.UpDown_GPU3Form);
            this.SimpleTab.Controls.Add(this.LB_GPU3Form);
            this.SimpleTab.Controls.Add(this.ComboBox_CPU3Form);
            this.SimpleTab.Controls.Add(this.LB_CPU3Form);
            this.SimpleTab.Controls.Add(this.ComboBox_TypePC3Form);
            this.SimpleTab.Controls.Add(this.LB_typePc3Form);
            this.SimpleTab.Location = new System.Drawing.Point(4, 22);
            this.SimpleTab.Name = "SimpleTab";
            this.SimpleTab.Padding = new System.Windows.Forms.Padding(3);
            this.SimpleTab.Size = new System.Drawing.Size(768, 178);
            this.SimpleTab.TabIndex = 0;
            this.SimpleTab.Text = "Обычный";
            this.SimpleTab.UseVisualStyleBackColor = true;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("2");
            this.domainUpDown1.Items.Add("4");
            this.domainUpDown1.Items.Add("6");
            this.domainUpDown1.Items.Add("8");
            this.domainUpDown1.Items.Add("10");
            this.domainUpDown1.Items.Add("12");
            this.domainUpDown1.Items.Add("14");
            this.domainUpDown1.Items.Add("16");
            this.domainUpDown1.Location = new System.Drawing.Point(355, 20);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.ReadOnly = true;
            this.domainUpDown1.Size = new System.Drawing.Size(64, 20);
            this.domainUpDown1.TabIndex = 20;
            // 
            // LB_DataBuy3Form
            // 
            this.LB_DataBuy3Form.AutoSize = true;
            this.LB_DataBuy3Form.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LB_DataBuy3Form.Location = new System.Drawing.Point(578, 6);
            this.LB_DataBuy3Form.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_DataBuy3Form.Name = "LB_DataBuy3Form";
            this.LB_DataBuy3Form.Size = new System.Drawing.Size(80, 13);
            this.LB_DataBuy3Form.TabIndex = 18;
            this.LB_DataBuy3Form.Text = "Дата покупки:";
            // 
            // dateTimePicker1_3Form
            // 
            this.dateTimePicker1_3Form.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1_3Form.Location = new System.Drawing.Point(580, 22);
            this.dateTimePicker1_3Form.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1_3Form.Name = "dateTimePicker1_3Form";
            this.dateTimePicker1_3Form.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1_3Form.TabIndex = 19;
            // 
            // GroupLB_ROM3Form
            // 
            this.GroupLB_ROM3Form.Controls.Add(this.CheckBox_ROM2_3Form);
            this.GroupLB_ROM3Form.Controls.Add(this.CheckBox_ROM1_3Form);
            this.GroupLB_ROM3Form.Controls.Add(this.CheckBox_ROM3_3Form);
            this.GroupLB_ROM3Form.Controls.Add(this.CheckBox_ROM4_3Form);
            this.GroupLB_ROM3Form.Location = new System.Drawing.Point(424, 6);
            this.GroupLB_ROM3Form.Margin = new System.Windows.Forms.Padding(2);
            this.GroupLB_ROM3Form.Name = "GroupLB_ROM3Form";
            this.GroupLB_ROM3Form.Padding = new System.Windows.Forms.Padding(2);
            this.GroupLB_ROM3Form.Size = new System.Drawing.Size(150, 110);
            this.GroupLB_ROM3Form.TabIndex = 12;
            this.GroupLB_ROM3Form.TabStop = false;
            this.GroupLB_ROM3Form.Text = "ПЗУ:";
            // 
            // CheckBox_ROM2_3Form
            // 
            this.CheckBox_ROM2_3Form.AutoSize = true;
            this.CheckBox_ROM2_3Form.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CheckBox_ROM2_3Form.Location = new System.Drawing.Point(4, 42);
            this.CheckBox_ROM2_3Form.Margin = new System.Windows.Forms.Padding(2);
            this.CheckBox_ROM2_3Form.Name = "CheckBox_ROM2_3Form";
            this.CheckBox_ROM2_3Form.Size = new System.Drawing.Size(62, 17);
            this.CheckBox_ROM2_3Form.TabIndex = 13;
            this.CheckBox_ROM2_3Form.Text = "500 GB";
            this.CheckBox_ROM2_3Form.UseVisualStyleBackColor = true;
            // 
            // CheckBox_ROM1_3Form
            // 
            this.CheckBox_ROM1_3Form.AutoSize = true;
            this.CheckBox_ROM1_3Form.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CheckBox_ROM1_3Form.Location = new System.Drawing.Point(4, 20);
            this.CheckBox_ROM1_3Form.Margin = new System.Windows.Forms.Padding(2);
            this.CheckBox_ROM1_3Form.Name = "CheckBox_ROM1_3Form";
            this.CheckBox_ROM1_3Form.Size = new System.Drawing.Size(62, 17);
            this.CheckBox_ROM1_3Form.TabIndex = 12;
            this.CheckBox_ROM1_3Form.Text = "250 GB";
            this.CheckBox_ROM1_3Form.UseVisualStyleBackColor = true;
            // 
            // CheckBox_ROM3_3Form
            // 
            this.CheckBox_ROM3_3Form.AutoSize = true;
            this.CheckBox_ROM3_3Form.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CheckBox_ROM3_3Form.Location = new System.Drawing.Point(4, 65);
            this.CheckBox_ROM3_3Form.Margin = new System.Windows.Forms.Padding(2);
            this.CheckBox_ROM3_3Form.Name = "CheckBox_ROM3_3Form";
            this.CheckBox_ROM3_3Form.Size = new System.Drawing.Size(49, 17);
            this.CheckBox_ROM3_3Form.TabIndex = 14;
            this.CheckBox_ROM3_3Form.Text = "1 TB";
            this.CheckBox_ROM3_3Form.UseVisualStyleBackColor = true;
            // 
            // CheckBox_ROM4_3Form
            // 
            this.CheckBox_ROM4_3Form.AutoSize = true;
            this.CheckBox_ROM4_3Form.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CheckBox_ROM4_3Form.Location = new System.Drawing.Point(4, 88);
            this.CheckBox_ROM4_3Form.Margin = new System.Windows.Forms.Padding(2);
            this.CheckBox_ROM4_3Form.Name = "CheckBox_ROM4_3Form";
            this.CheckBox_ROM4_3Form.Size = new System.Drawing.Size(49, 17);
            this.CheckBox_ROM4_3Form.TabIndex = 15;
            this.CheckBox_ROM4_3Form.Text = "2 TB";
            this.CheckBox_ROM4_3Form.UseVisualStyleBackColor = true;
            // 
            // LB_RAM4Form
            // 
            this.LB_RAM4Form.AutoSize = true;
            this.LB_RAM4Form.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LB_RAM4Form.Location = new System.Drawing.Point(352, 6);
            this.LB_RAM4Form.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_RAM4Form.Name = "LB_RAM4Form";
            this.LB_RAM4Form.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LB_RAM4Form.Size = new System.Drawing.Size(34, 13);
            this.LB_RAM4Form.TabIndex = 10;
            this.LB_RAM4Form.Text = "RAM:";
            // 
            // UpDown_GPU3Form
            // 
            this.UpDown_GPU3Form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpDown_GPU3Form.Items.Add("Nvidia GTX 1660");
            this.UpDown_GPU3Form.Items.Add("Nvidia GTX 1660 Super");
            this.UpDown_GPU3Form.Items.Add("Nvidia GTX 1660 TI");
            this.UpDown_GPU3Form.Items.Add("AMD Radeon RX 6800");
            this.UpDown_GPU3Form.Items.Add("AMD Radeon RX 6800X");
            this.UpDown_GPU3Form.Location = new System.Drawing.Point(202, 21);
            this.UpDown_GPU3Form.Margin = new System.Windows.Forms.Padding(2);
            this.UpDown_GPU3Form.Name = "UpDown_GPU3Form";
            this.UpDown_GPU3Form.ReadOnly = true;
            this.UpDown_GPU3Form.Size = new System.Drawing.Size(149, 20);
            this.UpDown_GPU3Form.TabIndex = 8;
            // 
            // LB_GPU3Form
            // 
            this.LB_GPU3Form.AutoSize = true;
            this.LB_GPU3Form.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LB_GPU3Form.Location = new System.Drawing.Point(202, 3);
            this.LB_GPU3Form.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_GPU3Form.Name = "LB_GPU3Form";
            this.LB_GPU3Form.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LB_GPU3Form.Size = new System.Drawing.Size(70, 13);
            this.LB_GPU3Form.TabIndex = 7;
            this.LB_GPU3Form.Text = "Видеокарта:";
            // 
            // ComboBox_CPU3Form
            // 
            this.ComboBox_CPU3Form.DisplayMember = "(нет)";
            this.ComboBox_CPU3Form.FormattingEnabled = true;
            this.ComboBox_CPU3Form.Items.AddRange(new object[] {
            "AMD",
            "Intel"});
            this.ComboBox_CPU3Form.Location = new System.Drawing.Point(106, 20);
            this.ComboBox_CPU3Form.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBox_CPU3Form.Name = "ComboBox_CPU3Form";
            this.ComboBox_CPU3Form.Size = new System.Drawing.Size(92, 21);
            this.ComboBox_CPU3Form.TabIndex = 6;
            // 
            // LB_CPU3Form
            // 
            this.LB_CPU3Form.AutoSize = true;
            this.LB_CPU3Form.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LB_CPU3Form.Location = new System.Drawing.Point(104, 3);
            this.LB_CPU3Form.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_CPU3Form.Name = "LB_CPU3Form";
            this.LB_CPU3Form.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LB_CPU3Form.Size = new System.Drawing.Size(66, 13);
            this.LB_CPU3Form.TabIndex = 5;
            this.LB_CPU3Form.Text = "Процессор:";
            // 
            // ComboBox_TypePC3Form
            // 
            this.ComboBox_TypePC3Form.DisplayMember = "(нет)";
            this.ComboBox_TypePC3Form.FormattingEnabled = true;
            this.ComboBox_TypePC3Form.Items.AddRange(new object[] {
            "Ноутбук",
            "Сервер",
            "Рабочая станция"});
            this.ComboBox_TypePC3Form.Location = new System.Drawing.Point(7, 20);
            this.ComboBox_TypePC3Form.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBox_TypePC3Form.Name = "ComboBox_TypePC3Form";
            this.ComboBox_TypePC3Form.Size = new System.Drawing.Size(92, 21);
            this.ComboBox_TypePC3Form.TabIndex = 4;
            // 
            // LB_typePc3Form
            // 
            this.LB_typePc3Form.AutoSize = true;
            this.LB_typePc3Form.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LB_typePc3Form.Location = new System.Drawing.Point(5, 3);
            this.LB_typePc3Form.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_typePc3Form.Name = "LB_typePc3Form";
            this.LB_typePc3Form.Size = new System.Drawing.Size(95, 13);
            this.LB_typePc3Form.TabIndex = 3;
            this.LB_typePc3Form.Text = "Тип компьютера:";
            // 
            // RegTab
            // 
            this.RegTab.Controls.Add(this.numericUpDown1);
            this.RegTab.Location = new System.Drawing.Point(4, 22);
            this.RegTab.Name = "RegTab";
            this.RegTab.Padding = new System.Windows.Forms.Padding(3);
            this.RegTab.Size = new System.Drawing.Size(768, 178);
            this.RegTab.TabIndex = 1;
            this.RegTab.Text = "Регулярный";
            this.RegTab.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(226, 88);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            // 
            // BT_Find3Form
            // 
            this.BT_Find3Form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_Find3Form.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BT_Find3Form.Location = new System.Drawing.Point(16, 401);
            this.BT_Find3Form.Margin = new System.Windows.Forms.Padding(2);
            this.BT_Find3Form.Name = "BT_Find3Form";
            this.BT_Find3Form.Size = new System.Drawing.Size(142, 38);
            this.BT_Find3Form.TabIndex = 21;
            this.BT_Find3Form.Text = " Поиск";
            this.BT_Find3Form.UseVisualStyleBackColor = true;
            this.BT_Find3Form.Click += new System.EventHandler(this.BT_Find3Form_Click);
            // 
            // TB_Result
            // 
            this.TB_Result.Location = new System.Drawing.Point(16, 223);
            this.TB_Result.Multiline = true;
            this.TB_Result.Name = "TB_Result";
            this.TB_Result.ReadOnly = true;
            this.TB_Result.Size = new System.Drawing.Size(768, 173);
            this.TB_Result.TabIndex = 22;
            // 
            // CloseForm3
            // 
            this.CloseForm3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseForm3.AutoEllipsis = true;
            this.CloseForm3.BackColor = System.Drawing.Color.Red;
            this.CloseForm3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseForm3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseForm3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseForm3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CloseForm3.Location = new System.Drawing.Point(160, 401);
            this.CloseForm3.Margin = new System.Windows.Forms.Padding(0);
            this.CloseForm3.Name = "CloseForm3";
            this.CloseForm3.Size = new System.Drawing.Size(38, 38);
            this.CloseForm3.TabIndex = 23;
            this.CloseForm3.Text = "X";
            this.CloseForm3.UseVisualStyleBackColor = false;
            this.CloseForm3.Click += new System.EventHandler(this.CloseForm3_Click);
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseForm3);
            this.Controls.Add(this.TB_Result);
            this.Controls.Add(this.BT_Find3Form);
            this.Controls.Add(this.TabControl);
            this.Name = "FindForm";
            this.Text = "FindForm";
            this.TabControl.ResumeLayout(false);
            this.SimpleTab.ResumeLayout(false);
            this.SimpleTab.PerformLayout();
            this.GroupLB_ROM3Form.ResumeLayout(false);
            this.GroupLB_ROM3Form.PerformLayout();
            this.RegTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage SimpleTab;
        private System.Windows.Forms.TabPage RegTab;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox ComboBox_CPU3Form;
        private System.Windows.Forms.Label LB_CPU3Form;
        private System.Windows.Forms.ComboBox ComboBox_TypePC3Form;
        private System.Windows.Forms.Label LB_typePc3Form;
        private System.Windows.Forms.Label LB_GPU3Form;
        private System.Windows.Forms.DomainUpDown UpDown_GPU3Form;
        private System.Windows.Forms.Label LB_RAM4Form;
        private System.Windows.Forms.GroupBox GroupLB_ROM3Form;
        private System.Windows.Forms.CheckBox CheckBox_ROM2_3Form;
        private System.Windows.Forms.CheckBox CheckBox_ROM1_3Form;
        private System.Windows.Forms.CheckBox CheckBox_ROM3_3Form;
        private System.Windows.Forms.CheckBox CheckBox_ROM4_3Form;
        private System.Windows.Forms.Label LB_DataBuy3Form;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_3Form;
        private System.Windows.Forms.Button BT_Find3Form;
        private System.Windows.Forms.TextBox TB_Result;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Button CloseForm3;
    }
}