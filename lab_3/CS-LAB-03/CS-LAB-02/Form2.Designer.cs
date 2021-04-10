
namespace CS_LAB_02
{
    partial class Form2
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
            this.LB_Name = new System.Windows.Forms.Label();
            this.TB_FirstName = new System.Windows.Forms.TextBox();
            this.TB_SecName = new System.Windows.Forms.TextBox();
            this.LB_SecName = new System.Windows.Forms.Label();
            this.LB_Number = new System.Windows.Forms.Label();
            this.TB_MaskedNumber = new System.Windows.Forms.MaskedTextBox();
            this.BT_SecSave = new System.Windows.Forms.Button();
            this.LB_NameFile = new System.Windows.Forms.Label();
            this.TB_NameFile = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_Name
            // 
            this.LB_Name.AutoSize = true;
            this.LB_Name.BackColor = System.Drawing.Color.LightBlue;
            this.LB_Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LB_Name.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LB_Name.Location = new System.Drawing.Point(42, 13);
            this.LB_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Name.Name = "LB_Name";
            this.LB_Name.Size = new System.Drawing.Size(39, 18);
            this.LB_Name.TabIndex = 0;
            this.LB_Name.Text = "Имя:";
            // 
            // TB_FirstName
            // 
            this.TB_FirstName.Location = new System.Drawing.Point(83, 11);
            this.TB_FirstName.Margin = new System.Windows.Forms.Padding(2);
            this.TB_FirstName.Name = "TB_FirstName";
            this.TB_FirstName.Size = new System.Drawing.Size(90, 20);
            this.TB_FirstName.TabIndex = 1;
            // 
            // TB_SecName
            // 
            this.TB_SecName.Location = new System.Drawing.Point(83, 53);
            this.TB_SecName.Margin = new System.Windows.Forms.Padding(2);
            this.TB_SecName.Name = "TB_SecName";
            this.TB_SecName.Size = new System.Drawing.Size(90, 20);
            this.TB_SecName.TabIndex = 2;
            // 
            // LB_SecName
            // 
            this.LB_SecName.AutoSize = true;
            this.LB_SecName.BackColor = System.Drawing.Color.LightBlue;
            this.LB_SecName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LB_SecName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LB_SecName.Location = new System.Drawing.Point(11, 53);
            this.LB_SecName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_SecName.Name = "LB_SecName";
            this.LB_SecName.Size = new System.Drawing.Size(70, 18);
            this.LB_SecName.TabIndex = 2;
            this.LB_SecName.Text = "Фамилия:";
            // 
            // LB_Number
            // 
            this.LB_Number.AutoSize = true;
            this.LB_Number.BackColor = System.Drawing.Color.LightBlue;
            this.LB_Number.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LB_Number.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LB_Number.Location = new System.Drawing.Point(14, 93);
            this.LB_Number.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Number.Name = "LB_Number";
            this.LB_Number.Size = new System.Drawing.Size(67, 18);
            this.LB_Number.TabIndex = 4;
            this.LB_Number.Text = "Телефон:";
            // 
            // TB_MaskedNumber
            // 
            this.TB_MaskedNumber.Location = new System.Drawing.Point(83, 93);
            this.TB_MaskedNumber.Margin = new System.Windows.Forms.Padding(2);
            this.TB_MaskedNumber.Mask = "(999) 00-0000009";
            this.TB_MaskedNumber.Name = "TB_MaskedNumber";
            this.TB_MaskedNumber.Size = new System.Drawing.Size(90, 20);
            this.TB_MaskedNumber.TabIndex = 3;
            // 
            // BT_SecSave
            // 
            this.BT_SecSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_SecSave.Location = new System.Drawing.Point(17, 220);
            this.BT_SecSave.Margin = new System.Windows.Forms.Padding(2);
            this.BT_SecSave.Name = "BT_SecSave";
            this.BT_SecSave.Size = new System.Drawing.Size(158, 37);
            this.BT_SecSave.TabIndex = 5;
            this.BT_SecSave.Text = "Save";
            this.BT_SecSave.UseVisualStyleBackColor = true;
            this.BT_SecSave.Click += new System.EventHandler(this.BT_SecSave_Click);
            // 
            // LB_NameFile
            // 
            this.LB_NameFile.AutoSize = true;
            this.LB_NameFile.BackColor = System.Drawing.Color.LightBlue;
            this.LB_NameFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LB_NameFile.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LB_NameFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LB_NameFile.Location = new System.Drawing.Point(0, 141);
            this.LB_NameFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_NameFile.Name = "LB_NameFile";
            this.LB_NameFile.Size = new System.Drawing.Size(81, 18);
            this.LB_NameFile.TabIndex = 7;
            this.LB_NameFile.Text = "Имя файла:";
            // 
            // TB_NameFile
            // 
            this.TB_NameFile.Location = new System.Drawing.Point(83, 141);
            this.TB_NameFile.Margin = new System.Windows.Forms.Padding(2);
            this.TB_NameFile.Name = "TB_NameFile";
            this.TB_NameFile.Size = new System.Drawing.Size(90, 20);
            this.TB_NameFile.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.BT_SecSave);
            this.panel1.Location = new System.Drawing.Point(-6, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 276);
            this.panel1.TabIndex = 8;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 262);
            this.Controls.Add(this.TB_NameFile);
            this.Controls.Add(this.LB_NameFile);
            this.Controls.Add(this.TB_MaskedNumber);
            this.Controls.Add(this.LB_Number);
            this.Controls.Add(this.TB_SecName);
            this.Controls.Add(this.LB_SecName);
            this.Controls.Add(this.TB_FirstName);
            this.Controls.Add(this.LB_Name);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Name;
        private System.Windows.Forms.TextBox TB_FirstName;
        private System.Windows.Forms.TextBox TB_SecName;
        private System.Windows.Forms.Label LB_SecName;
        private System.Windows.Forms.Label LB_Number;
        private System.Windows.Forms.MaskedTextBox TB_MaskedNumber;
        private System.Windows.Forms.Button BT_SecSave;
        private System.Windows.Forms.Label LB_NameFile;
        private System.Windows.Forms.TextBox TB_NameFile;
        private System.Windows.Forms.Panel panel1;
    }
}