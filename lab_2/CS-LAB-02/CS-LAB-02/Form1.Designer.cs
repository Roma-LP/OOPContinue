
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
            this.BT_Add = new System.Windows.Forms.Button();
            this.OutData = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_TypePC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_GPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_CPU)).BeginInit();
            this.GroupLB_CPU.SuspendLayout();
            this.GroupLB_ROM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_ROM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBase)).BeginInit();
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
            this.UpDown_GPU.Items.Add(resources.GetString("UpDown_GPU.Items5"));
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
            this.TrackBarRAM.LargeChange = 2;
            resources.ApplyResources(this.TrackBarRAM, "TrackBarRAM");
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
            resources.ApplyResources(this.BT_Save, "BT_Save");
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.UseVisualStyleBackColor = true;
            this.BT_Save.Click += new System.EventHandler(this.BT_Save_Click);
            // 
            // BT_Load
            // 
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
            this.Column6_DataBuy});
            resources.ApplyResources(this.DataBase, "DataBase");
            this.DataBase.Name = "DataBase";
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
            // BT_Add
            // 
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
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
        private System.Windows.Forms.DataGridView DataBase;
        private System.Windows.Forms.Button BT_Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1_TypePC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2_CPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3_GPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4_RAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5_ROM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6_DataBuy;
        public System.Windows.Forms.TextBox OutData;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

