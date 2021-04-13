namespace CS_LAB_02
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
            this.BT_ClearROM_3Form = new System.Windows.Forms.Button();
            this.BT_ClearRAM_3Form = new System.Windows.Forms.Button();
            this.BT_ClearGPU_3Form = new System.Windows.Forms.Button();
            this.BT_ClearCPU_3Form = new System.Windows.Forms.Button();
            this.BT_ClearTypePC_3Form = new System.Windows.Forms.Button();
            this.CheckBox_DateOff = new System.Windows.Forms.CheckBox();
            this.UpDown_RAM3Form = new System.Windows.Forms.DomainUpDown();
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
            this.BT_ClerAll_3Form = new System.Windows.Forms.Button();
            this.SaveFindForm = new System.Windows.Forms.Button();
            this.saveFileDialog_Form3 = new System.Windows.Forms.SaveFileDialog();
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
            this.TabControl.Location = new System.Drawing.Point(16, 15);
            this.TabControl.Margin = new System.Windows.Forms.Padding(4);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1035, 251);
            this.TabControl.TabIndex = 0;
            // 
            // SimpleTab
            // 
            this.SimpleTab.Controls.Add(this.BT_ClearROM_3Form);
            this.SimpleTab.Controls.Add(this.BT_ClearRAM_3Form);
            this.SimpleTab.Controls.Add(this.BT_ClearGPU_3Form);
            this.SimpleTab.Controls.Add(this.BT_ClearCPU_3Form);
            this.SimpleTab.Controls.Add(this.BT_ClearTypePC_3Form);
            this.SimpleTab.Controls.Add(this.CheckBox_DateOff);
            this.SimpleTab.Controls.Add(this.UpDown_RAM3Form);
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
            this.SimpleTab.Location = new System.Drawing.Point(4, 25);
            this.SimpleTab.Margin = new System.Windows.Forms.Padding(4);
            this.SimpleTab.Name = "SimpleTab";
            this.SimpleTab.Padding = new System.Windows.Forms.Padding(4);
            this.SimpleTab.Size = new System.Drawing.Size(1027, 222);
            this.SimpleTab.TabIndex = 0;
            this.SimpleTab.Text = "Обычный";
            this.SimpleTab.UseVisualStyleBackColor = true;
            // 
            // BT_ClearROM_3Form
            // 
            this.BT_ClearROM_3Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_ClearROM_3Form.Location = new System.Drawing.Point(565, 155);
            this.BT_ClearROM_3Form.Margin = new System.Windows.Forms.Padding(4);
            this.BT_ClearROM_3Form.Name = "BT_ClearROM_3Form";
            this.BT_ClearROM_3Form.Size = new System.Drawing.Size(200, 57);
            this.BT_ClearROM_3Form.TabIndex = 26;
            this.BT_ClearROM_3Form.Text = "Очистить поле";
            this.BT_ClearROM_3Form.UseVisualStyleBackColor = true;
            this.BT_ClearROM_3Form.Click += new System.EventHandler(this.BT_ClearROM_3Form_Click);
            // 
            // BT_ClearRAM_3Form
            // 
            this.BT_ClearRAM_3Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_ClearRAM_3Form.Location = new System.Drawing.Point(473, 155);
            this.BT_ClearRAM_3Form.Margin = new System.Windows.Forms.Padding(4);
            this.BT_ClearRAM_3Form.Name = "BT_ClearRAM_3Form";
            this.BT_ClearRAM_3Form.Size = new System.Drawing.Size(85, 57);
            this.BT_ClearRAM_3Form.TabIndex = 25;
            this.BT_ClearRAM_3Form.Text = "Очистить поле";
            this.BT_ClearRAM_3Form.UseVisualStyleBackColor = true;
            this.BT_ClearRAM_3Form.Click += new System.EventHandler(this.BT_ClearRAM_3Form_Click);
            // 
            // BT_ClearGPU_3Form
            // 
            this.BT_ClearGPU_3Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_ClearGPU_3Form.Location = new System.Drawing.Point(269, 155);
            this.BT_ClearGPU_3Form.Margin = new System.Windows.Forms.Padding(4);
            this.BT_ClearGPU_3Form.Name = "BT_ClearGPU_3Form";
            this.BT_ClearGPU_3Form.Size = new System.Drawing.Size(199, 57);
            this.BT_ClearGPU_3Form.TabIndex = 24;
            this.BT_ClearGPU_3Form.Text = "Очистить поле";
            this.BT_ClearGPU_3Form.UseVisualStyleBackColor = true;
            this.BT_ClearGPU_3Form.Click += new System.EventHandler(this.BT_ClearGPU_3Form_Click);
            // 
            // BT_ClearCPU_3Form
            // 
            this.BT_ClearCPU_3Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_ClearCPU_3Form.Location = new System.Drawing.Point(143, 155);
            this.BT_ClearCPU_3Form.Margin = new System.Windows.Forms.Padding(4);
            this.BT_ClearCPU_3Form.Name = "BT_ClearCPU_3Form";
            this.BT_ClearCPU_3Form.Size = new System.Drawing.Size(121, 57);
            this.BT_ClearCPU_3Form.TabIndex = 23;
            this.BT_ClearCPU_3Form.Text = "Очистить поле";
            this.BT_ClearCPU_3Form.UseVisualStyleBackColor = true;
            this.BT_ClearCPU_3Form.Click += new System.EventHandler(this.BT_ClearCPU_3Form_Click);
            // 
            // BT_ClearTypePC_3Form
            // 
            this.BT_ClearTypePC_3Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_ClearTypePC_3Form.Location = new System.Drawing.Point(11, 155);
            this.BT_ClearTypePC_3Form.Margin = new System.Windows.Forms.Padding(4);
            this.BT_ClearTypePC_3Form.Name = "BT_ClearTypePC_3Form";
            this.BT_ClearTypePC_3Form.Size = new System.Drawing.Size(121, 57);
            this.BT_ClearTypePC_3Form.TabIndex = 22;
            this.BT_ClearTypePC_3Form.Text = "Очистить поле";
            this.BT_ClearTypePC_3Form.UseVisualStyleBackColor = true;
            this.BT_ClearTypePC_3Form.Click += new System.EventHandler(this.BT_ClearTypePC_3Form_Click);
            // 
            // CheckBox_DateOff
            // 
            this.CheckBox_DateOff.AutoSize = true;
            this.CheckBox_DateOff.Checked = true;
            this.CheckBox_DateOff.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_DateOff.Location = new System.Drawing.Point(773, 59);
            this.CheckBox_DateOff.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBox_DateOff.Name = "CheckBox_DateOff";
            this.CheckBox_DateOff.Size = new System.Drawing.Size(109, 21);
            this.CheckBox_DateOff.TabIndex = 21;
            this.CheckBox_DateOff.Text = "Любая дата";
            this.CheckBox_DateOff.UseVisualStyleBackColor = true;
            this.CheckBox_DateOff.CheckedChanged += new System.EventHandler(this.CheckBox_DateOff_CheckedChanged);
            // 
            // UpDown_RAM3Form
            // 
            this.UpDown_RAM3Form.Items.Add("2");
            this.UpDown_RAM3Form.Items.Add("4");
            this.UpDown_RAM3Form.Items.Add("6");
            this.UpDown_RAM3Form.Items.Add("8");
            this.UpDown_RAM3Form.Items.Add("10");
            this.UpDown_RAM3Form.Items.Add("12");
            this.UpDown_RAM3Form.Items.Add("14");
            this.UpDown_RAM3Form.Items.Add("16");
            this.UpDown_RAM3Form.Location = new System.Drawing.Point(473, 25);
            this.UpDown_RAM3Form.Margin = new System.Windows.Forms.Padding(4);
            this.UpDown_RAM3Form.Name = "UpDown_RAM3Form";
            this.UpDown_RAM3Form.ReadOnly = true;
            this.UpDown_RAM3Form.Size = new System.Drawing.Size(85, 22);
            this.UpDown_RAM3Form.TabIndex = 20;
            // 
            // LB_DataBuy3Form
            // 
            this.LB_DataBuy3Form.AutoSize = true;
            this.LB_DataBuy3Form.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LB_DataBuy3Form.Location = new System.Drawing.Point(771, 7);
            this.LB_DataBuy3Form.Name = "LB_DataBuy3Form";
            this.LB_DataBuy3Form.Size = new System.Drawing.Size(103, 17);
            this.LB_DataBuy3Form.TabIndex = 18;
            this.LB_DataBuy3Form.Text = "Дата покупки:";
            // 
            // dateTimePicker1_3Form
            // 
            this.dateTimePicker1_3Form.Enabled = false;
            this.dateTimePicker1_3Form.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1_3Form.Location = new System.Drawing.Point(773, 27);
            this.dateTimePicker1_3Form.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1_3Form.Name = "dateTimePicker1_3Form";
            this.dateTimePicker1_3Form.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1_3Form.TabIndex = 19;
            // 
            // GroupLB_ROM3Form
            // 
            this.GroupLB_ROM3Form.Controls.Add(this.CheckBox_ROM2_3Form);
            this.GroupLB_ROM3Form.Controls.Add(this.CheckBox_ROM1_3Form);
            this.GroupLB_ROM3Form.Controls.Add(this.CheckBox_ROM3_3Form);
            this.GroupLB_ROM3Form.Controls.Add(this.CheckBox_ROM4_3Form);
            this.GroupLB_ROM3Form.Location = new System.Drawing.Point(565, 7);
            this.GroupLB_ROM3Form.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupLB_ROM3Form.Name = "GroupLB_ROM3Form";
            this.GroupLB_ROM3Form.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupLB_ROM3Form.Size = new System.Drawing.Size(200, 135);
            this.GroupLB_ROM3Form.TabIndex = 12;
            this.GroupLB_ROM3Form.TabStop = false;
            this.GroupLB_ROM3Form.Text = "ROM:";
            // 
            // CheckBox_ROM2_3Form
            // 
            this.CheckBox_ROM2_3Form.AutoSize = true;
            this.CheckBox_ROM2_3Form.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CheckBox_ROM2_3Form.Location = new System.Drawing.Point(5, 52);
            this.CheckBox_ROM2_3Form.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckBox_ROM2_3Form.Name = "CheckBox_ROM2_3Form";
            this.CheckBox_ROM2_3Form.Size = new System.Drawing.Size(78, 21);
            this.CheckBox_ROM2_3Form.TabIndex = 13;
            this.CheckBox_ROM2_3Form.Text = "500 GB";
            this.CheckBox_ROM2_3Form.UseVisualStyleBackColor = true;
            // 
            // CheckBox_ROM1_3Form
            // 
            this.CheckBox_ROM1_3Form.AutoSize = true;
            this.CheckBox_ROM1_3Form.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CheckBox_ROM1_3Form.Location = new System.Drawing.Point(5, 25);
            this.CheckBox_ROM1_3Form.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckBox_ROM1_3Form.Name = "CheckBox_ROM1_3Form";
            this.CheckBox_ROM1_3Form.Size = new System.Drawing.Size(78, 21);
            this.CheckBox_ROM1_3Form.TabIndex = 12;
            this.CheckBox_ROM1_3Form.Text = "250 GB";
            this.CheckBox_ROM1_3Form.UseVisualStyleBackColor = true;
            // 
            // CheckBox_ROM3_3Form
            // 
            this.CheckBox_ROM3_3Form.AutoSize = true;
            this.CheckBox_ROM3_3Form.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CheckBox_ROM3_3Form.Location = new System.Drawing.Point(5, 80);
            this.CheckBox_ROM3_3Form.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckBox_ROM3_3Form.Name = "CheckBox_ROM3_3Form";
            this.CheckBox_ROM3_3Form.Size = new System.Drawing.Size(60, 21);
            this.CheckBox_ROM3_3Form.TabIndex = 14;
            this.CheckBox_ROM3_3Form.Text = "1 TB";
            this.CheckBox_ROM3_3Form.UseVisualStyleBackColor = true;
            // 
            // CheckBox_ROM4_3Form
            // 
            this.CheckBox_ROM4_3Form.AutoSize = true;
            this.CheckBox_ROM4_3Form.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CheckBox_ROM4_3Form.Location = new System.Drawing.Point(5, 108);
            this.CheckBox_ROM4_3Form.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckBox_ROM4_3Form.Name = "CheckBox_ROM4_3Form";
            this.CheckBox_ROM4_3Form.Size = new System.Drawing.Size(60, 21);
            this.CheckBox_ROM4_3Form.TabIndex = 15;
            this.CheckBox_ROM4_3Form.Text = "2 TB";
            this.CheckBox_ROM4_3Form.UseVisualStyleBackColor = true;
            // 
            // LB_RAM4Form
            // 
            this.LB_RAM4Form.AutoSize = true;
            this.LB_RAM4Form.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LB_RAM4Form.Location = new System.Drawing.Point(469, 7);
            this.LB_RAM4Form.Name = "LB_RAM4Form";
            this.LB_RAM4Form.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LB_RAM4Form.Size = new System.Drawing.Size(42, 17);
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
            this.UpDown_GPU3Form.Location = new System.Drawing.Point(269, 26);
            this.UpDown_GPU3Form.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpDown_GPU3Form.Name = "UpDown_GPU3Form";
            this.UpDown_GPU3Form.ReadOnly = true;
            this.UpDown_GPU3Form.Size = new System.Drawing.Size(199, 22);
            this.UpDown_GPU3Form.TabIndex = 8;
            // 
            // LB_GPU3Form
            // 
            this.LB_GPU3Form.AutoSize = true;
            this.LB_GPU3Form.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LB_GPU3Form.Location = new System.Drawing.Point(269, 4);
            this.LB_GPU3Form.Name = "LB_GPU3Form";
            this.LB_GPU3Form.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LB_GPU3Form.Size = new System.Drawing.Size(91, 17);
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
            this.ComboBox_CPU3Form.Location = new System.Drawing.Point(141, 25);
            this.ComboBox_CPU3Form.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBox_CPU3Form.Name = "ComboBox_CPU3Form";
            this.ComboBox_CPU3Form.Size = new System.Drawing.Size(121, 24);
            this.ComboBox_CPU3Form.TabIndex = 6;
            // 
            // LB_CPU3Form
            // 
            this.LB_CPU3Form.AutoSize = true;
            this.LB_CPU3Form.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LB_CPU3Form.Location = new System.Drawing.Point(139, 4);
            this.LB_CPU3Form.Name = "LB_CPU3Form";
            this.LB_CPU3Form.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LB_CPU3Form.Size = new System.Drawing.Size(84, 17);
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
            this.ComboBox_TypePC3Form.Location = new System.Drawing.Point(9, 25);
            this.ComboBox_TypePC3Form.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBox_TypePC3Form.Name = "ComboBox_TypePC3Form";
            this.ComboBox_TypePC3Form.Size = new System.Drawing.Size(121, 24);
            this.ComboBox_TypePC3Form.TabIndex = 4;
            // 
            // LB_typePc3Form
            // 
            this.LB_typePc3Form.AutoSize = true;
            this.LB_typePc3Form.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LB_typePc3Form.Location = new System.Drawing.Point(7, 4);
            this.LB_typePc3Form.Name = "LB_typePc3Form";
            this.LB_typePc3Form.Size = new System.Drawing.Size(121, 17);
            this.LB_typePc3Form.TabIndex = 3;
            this.LB_typePc3Form.Text = "Тип компьютера:";
            // 
            // RegTab
            // 
            this.RegTab.Controls.Add(this.numericUpDown1);
            this.RegTab.Location = new System.Drawing.Point(4, 25);
            this.RegTab.Margin = new System.Windows.Forms.Padding(4);
            this.RegTab.Name = "RegTab";
            this.RegTab.Padding = new System.Windows.Forms.Padding(4);
            this.RegTab.Size = new System.Drawing.Size(1027, 222);
            this.RegTab.TabIndex = 1;
            this.RegTab.Text = "Регулярный";
            this.RegTab.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(301, 108);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(160, 22);
            this.numericUpDown1.TabIndex = 0;
            // 
            // BT_Find3Form
            // 
            this.BT_Find3Form.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BT_Find3Form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_Find3Form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Find3Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_Find3Form.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BT_Find3Form.Location = new System.Drawing.Point(21, 494);
            this.BT_Find3Form.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_Find3Form.Name = "BT_Find3Form";
            this.BT_Find3Form.Size = new System.Drawing.Size(189, 47);
            this.BT_Find3Form.TabIndex = 21;
            this.BT_Find3Form.Text = " Поиск";
            this.BT_Find3Form.UseVisualStyleBackColor = false;
            this.BT_Find3Form.Click += new System.EventHandler(this.BT_Find3Form_Click);
            // 
            // TB_Result
            // 
            this.TB_Result.Location = new System.Drawing.Point(21, 274);
            this.TB_Result.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Result.Multiline = true;
            this.TB_Result.Name = "TB_Result";
            this.TB_Result.ReadOnly = true;
            this.TB_Result.Size = new System.Drawing.Size(1023, 212);
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
            this.CloseForm3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseForm3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseForm3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CloseForm3.Location = new System.Drawing.Point(408, 494);
            this.CloseForm3.Margin = new System.Windows.Forms.Padding(0);
            this.CloseForm3.Name = "CloseForm3";
            this.CloseForm3.Size = new System.Drawing.Size(51, 47);
            this.CloseForm3.TabIndex = 23;
            this.CloseForm3.Text = "X";
            this.CloseForm3.UseVisualStyleBackColor = false;
            this.CloseForm3.Click += new System.EventHandler(this.CloseForm3_Click);
            // 
            // BT_ClerAll_3Form
            // 
            this.BT_ClerAll_3Form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_ClerAll_3Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_ClerAll_3Form.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BT_ClerAll_3Form.Location = new System.Drawing.Point(216, 494);
            this.BT_ClerAll_3Form.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_ClerAll_3Form.Name = "BT_ClerAll_3Form";
            this.BT_ClerAll_3Form.Size = new System.Drawing.Size(189, 47);
            this.BT_ClerAll_3Form.TabIndex = 24;
            this.BT_ClerAll_3Form.Text = "Очистить всё";
            this.BT_ClerAll_3Form.UseVisualStyleBackColor = true;
            this.BT_ClerAll_3Form.Click += new System.EventHandler(this.BT_ClerAll_3Form_Click);
            // 
            // SaveFindForm
            // 
            this.SaveFindForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveFindForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveFindForm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SaveFindForm.Location = new System.Drawing.Point(462, 494);
            this.SaveFindForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveFindForm.Name = "SaveFindForm";
            this.SaveFindForm.Size = new System.Drawing.Size(189, 47);
            this.SaveFindForm.TabIndex = 25;
            this.SaveFindForm.Text = "Сохранить как..";
            this.SaveFindForm.UseVisualStyleBackColor = true;
            this.SaveFindForm.Click += new System.EventHandler(this.SaveFindForm_Click);
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.SaveFindForm);
            this.Controls.Add(this.BT_ClerAll_3Form);
            this.Controls.Add(this.CloseForm3);
            this.Controls.Add(this.TB_Result);
            this.Controls.Add(this.BT_Find3Form);
            this.Controls.Add(this.TabControl);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.DomainUpDown UpDown_RAM3Form;
        private System.Windows.Forms.Button CloseForm3;
        private System.Windows.Forms.CheckBox CheckBox_DateOff;
        private System.Windows.Forms.Button BT_ClerAll_3Form;
        private System.Windows.Forms.Button BT_ClearROM_3Form;
        private System.Windows.Forms.Button BT_ClearRAM_3Form;
        private System.Windows.Forms.Button BT_ClearGPU_3Form;
        private System.Windows.Forms.Button BT_ClearCPU_3Form;
        private System.Windows.Forms.Button BT_ClearTypePC_3Form;
        private System.Windows.Forms.Button SaveFindForm;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_Form3;
    }
}