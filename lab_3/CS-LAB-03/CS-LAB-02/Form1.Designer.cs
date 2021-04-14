
namespace CS_LAB_02
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.errorProvider_TypePC = new System.Windows.Forms.ErrorProvider(this.components);
            this.LB_typePc = new System.Windows.Forms.Label();
            this.ComboBox_TypePC = new System.Windows.Forms.ComboBox();
            this.RadBut_CPU1 = new System.Windows.Forms.RadioButton();
            this.RadBut_CPU2 = new System.Windows.Forms.RadioButton();
            this.LB_GPU = new System.Windows.Forms.Label();
            this.UpDown_GPU = new System.Windows.Forms.DomainUpDown();
            this.LB_SizeRAM = new System.Windows.Forms.Label();
            this.TrackBarRAM = new System.Windows.Forms.TrackBar();
            this.LB_SizeTotalRAM = new System.Windows.Forms.Label();
            this.CheckBox_ROM1 = new System.Windows.Forms.CheckBox();
            this.CheckBox_ROM2 = new System.Windows.Forms.CheckBox();
            this.CheckBox_ROM3 = new System.Windows.Forms.CheckBox();
            this.CheckBox_ROM4 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LB_DataBuy = new System.Windows.Forms.Label();
            this.BT_Save = new System.Windows.Forms.Button();
            this.BT_Load = new System.Windows.Forms.Button();
            this.errorProvider_GPU = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_CPU = new System.Windows.Forms.ErrorProvider(this.components);
            this.GroupLB_CPU = new System.Windows.Forms.GroupBox();
            this.GroupLB_ROM = new System.Windows.Forms.GroupBox();
            this.errorProvider_ROM = new System.Windows.Forms.ErrorProvider(this.components);
            this.DataBase = new System.Windows.Forms.DataGridView();
            this.Column1_TypePC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2_CPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3_GPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4_RAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5_ROM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6_DataBuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BT_Add = new System.Windows.Forms.Button();
            this.OutData = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BT_Find = new System.Windows.Forms.Button();
            this.CloseForm1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.проектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типКомпьютераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.процессорToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видеокртаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оЗУToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пЗУToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.датаПокупкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BT_About = new System.Windows.Forms.Button();
            this.saveFileDialog_Form1 = new System.Windows.Forms.SaveFileDialog();
            this.BT_DeleteRows = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_TypePC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_GPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_CPU)).BeginInit();
            this.GroupLB_CPU.SuspendLayout();
            this.GroupLB_ROM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_ROM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBase)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider_TypePC
            // 
            this.errorProvider_TypePC.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider_TypePC.ContainerControl = this;
            // 
            // LB_typePc
            // 
            resources.ApplyResources(this.LB_typePc, "LB_typePc");
            this.LB_typePc.Name = "LB_typePc";
            // 
            // ComboBox_TypePC
            // 
            this.ComboBox_TypePC.DisplayMember = "(нет)";
            this.ComboBox_TypePC.FormattingEnabled = true;
            this.ComboBox_TypePC.Items.AddRange(new object[] {
            resources.GetString("ComboBox_TypePC.Items"),
            resources.GetString("ComboBox_TypePC.Items1"),
            resources.GetString("ComboBox_TypePC.Items2")});
            resources.ApplyResources(this.ComboBox_TypePC, "ComboBox_TypePC");
            this.ComboBox_TypePC.Name = "ComboBox_TypePC";
            // 
            // RadBut_CPU1
            // 
            resources.ApplyResources(this.RadBut_CPU1, "RadBut_CPU1");
            this.RadBut_CPU1.Checked = true;
            this.RadBut_CPU1.Name = "RadBut_CPU1";
            this.RadBut_CPU1.TabStop = true;
            this.RadBut_CPU1.UseVisualStyleBackColor = true;
            // 
            // RadBut_CPU2
            // 
            resources.ApplyResources(this.RadBut_CPU2, "RadBut_CPU2");
            this.RadBut_CPU2.Name = "RadBut_CPU2";
            this.RadBut_CPU2.TabStop = true;
            this.RadBut_CPU2.UseVisualStyleBackColor = true;
            // 
            // LB_GPU
            // 
            resources.ApplyResources(this.LB_GPU, "LB_GPU");
            this.LB_GPU.Name = "LB_GPU";
            // 
            // UpDown_GPU
            // 
            this.UpDown_GPU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpDown_GPU.Items.Add(resources.GetString("UpDown_GPU.Items"));
            this.UpDown_GPU.Items.Add(resources.GetString("UpDown_GPU.Items1"));
            this.UpDown_GPU.Items.Add(resources.GetString("UpDown_GPU.Items2"));
            this.UpDown_GPU.Items.Add(resources.GetString("UpDown_GPU.Items3"));
            this.UpDown_GPU.Items.Add(resources.GetString("UpDown_GPU.Items4"));
            resources.ApplyResources(this.UpDown_GPU, "UpDown_GPU");
            this.UpDown_GPU.Name = "UpDown_GPU";
            this.UpDown_GPU.ReadOnly = true;
            // 
            // LB_SizeRAM
            // 
            resources.ApplyResources(this.LB_SizeRAM, "LB_SizeRAM");
            this.LB_SizeRAM.Name = "LB_SizeRAM";
            // 
            // TrackBarRAM
            // 
            resources.ApplyResources(this.TrackBarRAM, "TrackBarRAM");
            this.TrackBarRAM.LargeChange = 2;
            this.TrackBarRAM.Maximum = 16;
            this.TrackBarRAM.Minimum = 2;
            this.TrackBarRAM.Name = "TrackBarRAM";
            this.TrackBarRAM.SmallChange = 2;
            this.TrackBarRAM.Value = 2;
            // 
            // LB_SizeTotalRAM
            // 
            resources.ApplyResources(this.LB_SizeTotalRAM, "LB_SizeTotalRAM");
            this.LB_SizeTotalRAM.Name = "LB_SizeTotalRAM";
            this.LB_SizeTotalRAM.Click += new System.EventHandler(this.LB_SizeTotalRAM_UpDate);
            // 
            // CheckBox_ROM1
            // 
            resources.ApplyResources(this.CheckBox_ROM1, "CheckBox_ROM1");
            this.CheckBox_ROM1.Name = "CheckBox_ROM1";
            this.CheckBox_ROM1.UseVisualStyleBackColor = true;
            this.CheckBox_ROM1.CheckedChanged += new System.EventHandler(this.CheckBox_ROM1_CheckedChanged);
            // 
            // CheckBox_ROM2
            // 
            resources.ApplyResources(this.CheckBox_ROM2, "CheckBox_ROM2");
            this.CheckBox_ROM2.Name = "CheckBox_ROM2";
            this.CheckBox_ROM2.UseVisualStyleBackColor = true;
            // 
            // CheckBox_ROM3
            // 
            resources.ApplyResources(this.CheckBox_ROM3, "CheckBox_ROM3");
            this.CheckBox_ROM3.Name = "CheckBox_ROM3";
            this.CheckBox_ROM3.UseVisualStyleBackColor = true;
            // 
            // CheckBox_ROM4
            // 
            resources.ApplyResources(this.CheckBox_ROM4, "CheckBox_ROM4");
            this.CheckBox_ROM4.Name = "CheckBox_ROM4";
            this.CheckBox_ROM4.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Name = "dateTimePicker1";
            // 
            // LB_DataBuy
            // 
            resources.ApplyResources(this.LB_DataBuy, "LB_DataBuy");
            this.LB_DataBuy.Name = "LB_DataBuy";
            // 
            // BT_Save
            // 
            this.BT_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.BT_Save, "BT_Save");
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.UseVisualStyleBackColor = true;
            this.BT_Save.Click += new System.EventHandler(this.BT_Save_Click);
            // 
            // BT_Load
            // 
            this.BT_Load.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.BT_Load, "BT_Load");
            this.BT_Load.Name = "BT_Load";
            this.BT_Load.UseVisualStyleBackColor = true;
            this.BT_Load.Click += new System.EventHandler(this.BT_Load_Click);
            // 
            // errorProvider_GPU
            // 
            this.errorProvider_GPU.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider_GPU.ContainerControl = this;
            // 
            // errorProvider_CPU
            // 
            this.errorProvider_CPU.ContainerControl = this;
            // 
            // GroupLB_CPU
            // 
            this.GroupLB_CPU.Controls.Add(this.RadBut_CPU1);
            this.GroupLB_CPU.Controls.Add(this.RadBut_CPU2);
            resources.ApplyResources(this.GroupLB_CPU, "GroupLB_CPU");
            this.GroupLB_CPU.Name = "GroupLB_CPU";
            this.GroupLB_CPU.TabStop = false;
            // 
            // GroupLB_ROM
            // 
            this.GroupLB_ROM.Controls.Add(this.CheckBox_ROM2);
            this.GroupLB_ROM.Controls.Add(this.CheckBox_ROM1);
            this.GroupLB_ROM.Controls.Add(this.CheckBox_ROM3);
            this.GroupLB_ROM.Controls.Add(this.CheckBox_ROM4);
            resources.ApplyResources(this.GroupLB_ROM, "GroupLB_ROM");
            this.GroupLB_ROM.Name = "GroupLB_ROM";
            this.GroupLB_ROM.TabStop = false;
            // 
            // errorProvider_ROM
            // 
            this.errorProvider_ROM.ContainerControl = this;
            // 
            // DataBase
            // 
            this.DataBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1_TypePC,
            this.Column2_CPU,
            this.Column3_GPU,
            this.Column4_RAM,
            this.Column5_ROM,
            this.Column6_DataBuy,
            this.FirstName,
            this.Surname,
            this.Tel,
            this.FileName});
            resources.ApplyResources(this.DataBase, "DataBase");
            this.DataBase.Name = "DataBase";
            this.DataBase.ReadOnly = true;
            this.DataBase.RowTemplate.Height = 24;
            // 
            // Column1_TypePC
            // 
            resources.ApplyResources(this.Column1_TypePC, "Column1_TypePC");
            this.Column1_TypePC.Name = "Column1_TypePC";
            this.Column1_TypePC.ReadOnly = true;
            // 
            // Column2_CPU
            // 
            resources.ApplyResources(this.Column2_CPU, "Column2_CPU");
            this.Column2_CPU.Name = "Column2_CPU";
            this.Column2_CPU.ReadOnly = true;
            // 
            // Column3_GPU
            // 
            resources.ApplyResources(this.Column3_GPU, "Column3_GPU");
            this.Column3_GPU.Name = "Column3_GPU";
            this.Column3_GPU.ReadOnly = true;
            // 
            // Column4_RAM
            // 
            this.Column4_RAM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            resources.ApplyResources(this.Column4_RAM, "Column4_RAM");
            this.Column4_RAM.Name = "Column4_RAM";
            this.Column4_RAM.ReadOnly = true;
            // 
            // Column5_ROM
            // 
            resources.ApplyResources(this.Column5_ROM, "Column5_ROM");
            this.Column5_ROM.Name = "Column5_ROM";
            this.Column5_ROM.ReadOnly = true;
            // 
            // Column6_DataBuy
            // 
            resources.ApplyResources(this.Column6_DataBuy, "Column6_DataBuy");
            this.Column6_DataBuy.Name = "Column6_DataBuy";
            this.Column6_DataBuy.ReadOnly = true;
            // 
            // FirstName
            // 
            resources.ApplyResources(this.FirstName, "FirstName");
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // Surname
            // 
            resources.ApplyResources(this.Surname, "Surname");
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // Tel
            // 
            resources.ApplyResources(this.Tel, "Tel");
            this.Tel.Name = "Tel";
            this.Tel.ReadOnly = true;
            // 
            // FileName
            // 
            resources.ApplyResources(this.FileName, "FileName");
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            // 
            // BT_Add
            // 
            this.BT_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.BT_Add, "BT_Add");
            this.BT_Add.Name = "BT_Add";
            this.BT_Add.UseVisualStyleBackColor = true;
            this.BT_Add.Click += new System.EventHandler(this.BT_Add_Click);
            // 
            // OutData
            // 
            resources.ApplyResources(this.OutData, "OutData");
            this.OutData.Name = "OutData";
            this.OutData.ReadOnly = true;
            // 
            // BT_Find
            // 
            this.BT_Find.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BT_Find.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.BT_Find, "BT_Find");
            this.BT_Find.Name = "BT_Find";
            this.BT_Find.UseVisualStyleBackColor = false;
            this.BT_Find.Click += new System.EventHandler(this.BT_Find_Click);
            // 
            // CloseForm1
            // 
            this.CloseForm1.AutoEllipsis = true;
            this.CloseForm1.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.CloseForm1, "CloseForm1");
            this.CloseForm1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseForm1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CloseForm1.Name = "CloseForm1";
            this.CloseForm1.UseMnemonic = false;
            this.CloseForm1.UseVisualStyleBackColor = false;
            this.CloseForm1.Click += new System.EventHandler(this.CloseForm1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проектToolStripMenuItem,
            this.файлToolStripMenuItem,
            this.сортировкаToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // проектToolStripMenuItem
            // 
            this.проектToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.проектToolStripMenuItem.Name = "проектToolStripMenuItem";
            resources.ApplyResources(this.проектToolStripMenuItem, "проектToolStripMenuItem");
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            resources.ApplyResources(this.оПрограммеToolStripMenuItem, "оПрограммеToolStripMenuItem");
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            resources.ApplyResources(this.выходToolStripMenuItem, "выходToolStripMenuItem");
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьToolStripMenuItem,
            this.toolStripSeparator1,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            resources.ApplyResources(this.файлToolStripMenuItem, "файлToolStripMenuItem");
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            resources.ApplyResources(this.загрузитьToolStripMenuItem, "загрузитьToolStripMenuItem");
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            resources.ApplyResources(this.сохранитьToolStripMenuItem, "сохранитьToolStripMenuItem");
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            resources.ApplyResources(this.сохранитьКакToolStripMenuItem, "сохранитьКакToolStripMenuItem");
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.типКомпьютераToolStripMenuItem,
            this.процессорToolStripMenuItem,
            this.видеокртаToolStripMenuItem,
            this.оЗУToolStripMenuItem,
            this.пЗУToolStripMenuItem,
            this.датаПокупкиToolStripMenuItem});
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            resources.ApplyResources(this.сортировкаToolStripMenuItem, "сортировкаToolStripMenuItem");
            // 
            // типКомпьютераToolStripMenuItem
            // 
            this.типКомпьютераToolStripMenuItem.Name = "типКомпьютераToolStripMenuItem";
            resources.ApplyResources(this.типКомпьютераToolStripMenuItem, "типКомпьютераToolStripMenuItem");
            this.типКомпьютераToolStripMenuItem.Click += new System.EventHandler(this.типКомпьютераToolStripMenuItem_Click);
            // 
            // процессорToolStripMenuItem
            // 
            this.процессорToolStripMenuItem.Name = "процессорToolStripMenuItem";
            resources.ApplyResources(this.процессорToolStripMenuItem, "процессорToolStripMenuItem");
            this.процессорToolStripMenuItem.Click += new System.EventHandler(this.процессорToolStripMenuItem_Click);
            // 
            // видеокртаToolStripMenuItem
            // 
            this.видеокртаToolStripMenuItem.Name = "видеокртаToolStripMenuItem";
            resources.ApplyResources(this.видеокртаToolStripMenuItem, "видеокртаToolStripMenuItem");
            this.видеокртаToolStripMenuItem.Click += new System.EventHandler(this.видеокртаToolStripMenuItem_Click);
            // 
            // оЗУToolStripMenuItem
            // 
            this.оЗУToolStripMenuItem.Name = "оЗУToolStripMenuItem";
            resources.ApplyResources(this.оЗУToolStripMenuItem, "оЗУToolStripMenuItem");
            this.оЗУToolStripMenuItem.Click += new System.EventHandler(this.оЗУToolStripMenuItem_Click);
            // 
            // пЗУToolStripMenuItem
            // 
            this.пЗУToolStripMenuItem.Name = "пЗУToolStripMenuItem";
            resources.ApplyResources(this.пЗУToolStripMenuItem, "пЗУToolStripMenuItem");
            this.пЗУToolStripMenuItem.Click += new System.EventHandler(this.пЗУToolStripMenuItem_Click);
            // 
            // датаПокупкиToolStripMenuItem
            // 
            this.датаПокупкиToolStripMenuItem.Name = "датаПокупкиToolStripMenuItem";
            resources.ApplyResources(this.датаПокупкиToolStripMenuItem, "датаПокупкиToolStripMenuItem");
            this.датаПокупкиToolStripMenuItem.Click += new System.EventHandler(this.датаПокупкиToolStripMenuItem_Click);
            // 
            // BT_About
            // 
            this.BT_About.BackgroundImage = global::CS_LAB_02.Properties.Resources.AboutIcon;
            resources.ApplyResources(this.BT_About, "BT_About");
            this.BT_About.Image = global::CS_LAB_02.Properties.Resources.AboutIcon;
            this.BT_About.Name = "BT_About";
            this.BT_About.UseVisualStyleBackColor = true;
            this.BT_About.Click += new System.EventHandler(this.BT_About_Click);
            // 
            // BT_DeleteRows
            // 
            this.BT_DeleteRows.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.BT_DeleteRows, "BT_DeleteRows");
            this.BT_DeleteRows.Name = "BT_DeleteRows";
            this.BT_DeleteRows.UseVisualStyleBackColor = true;
            this.BT_DeleteRows.Click += new System.EventHandler(this.BT_DeleteRows_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BT_DeleteRows);
            this.Controls.Add(this.BT_About);
            this.Controls.Add(this.CloseForm1);
            this.Controls.Add(this.BT_Find);
            this.Controls.Add(this.OutData);
            this.Controls.Add(this.BT_Add);
            this.Controls.Add(this.DataBase);
            this.Controls.Add(this.GroupLB_ROM);
            this.Controls.Add(this.GroupLB_CPU);
            this.Controls.Add(this.BT_Load);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.LB_DataBuy);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.LB_SizeTotalRAM);
            this.Controls.Add(this.TrackBarRAM);
            this.Controls.Add(this.LB_SizeRAM);
            this.Controls.Add(this.UpDown_GPU);
            this.Controls.Add(this.LB_GPU);
            this.Controls.Add(this.ComboBox_TypePC);
            this.Controls.Add(this.LB_typePc);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_TypePC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_GPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_CPU)).EndInit();
            this.GroupLB_CPU.ResumeLayout(false);
            this.GroupLB_CPU.PerformLayout();
            this.GroupLB_ROM.ResumeLayout(false);
            this.GroupLB_ROM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_ROM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBase)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider_TypePC;
        private System.Windows.Forms.Label LB_typePc;
        private System.Windows.Forms.ComboBox ComboBox_TypePC;
        private System.Windows.Forms.RadioButton RadBut_CPU2;
        private System.Windows.Forms.RadioButton RadBut_CPU1;
        private System.Windows.Forms.DomainUpDown UpDown_GPU;
        private System.Windows.Forms.Label LB_GPU;
        private System.Windows.Forms.TrackBar TrackBarRAM;
        private System.Windows.Forms.Label LB_SizeRAM;
        private System.Windows.Forms.Label LB_SizeTotalRAM;
        private System.Windows.Forms.CheckBox CheckBox_ROM4;
        private System.Windows.Forms.CheckBox CheckBox_ROM3;
        private System.Windows.Forms.CheckBox CheckBox_ROM2;
        private System.Windows.Forms.CheckBox CheckBox_ROM1;
        private System.Windows.Forms.Label LB_DataBuy;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button BT_Load;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.ErrorProvider errorProvider_GPU;
        private System.Windows.Forms.ErrorProvider errorProvider_CPU;
        private System.Windows.Forms.GroupBox GroupLB_CPU;
        private System.Windows.Forms.GroupBox GroupLB_ROM;
        private System.Windows.Forms.ErrorProvider errorProvider_ROM;
        private System.Windows.Forms.Button BT_Add;
        public System.Windows.Forms.TextBox OutData;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.DataGridView DataBase;
        private System.Windows.Forms.Button BT_Find;
        private System.Windows.Forms.Button CloseForm1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1_TypePC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2_CPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3_GPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4_RAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5_ROM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6_DataBuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.Button BT_About;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem проектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_Form1;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типКомпьютераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem процессорToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видеокртаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оЗУToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пЗУToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem датаПокупкиToolStripMenuItem;
        private System.Windows.Forms.Button BT_DeleteRows;
    }
}

