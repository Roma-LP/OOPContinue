
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
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.TB_SecName = new System.Windows.Forms.TextBox();
            this.LB_SecName = new System.Windows.Forms.Label();
            this.LB_Number = new System.Windows.Forms.Label();
            this.TB_MaskedNumber = new System.Windows.Forms.MaskedTextBox();
            this.BT_SecSave = new System.Windows.Forms.Button();
            this.LB_NameFile = new System.Windows.Forms.Label();
            this.TB_NameFile = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LB_Name
            // 
            this.LB_Name.AutoSize = true;
            this.LB_Name.Location = new System.Drawing.Point(47, 13);
            this.LB_Name.Name = "LB_Name";
            this.LB_Name.Size = new System.Drawing.Size(39, 17);
            this.LB_Name.TabIndex = 0;
            this.LB_Name.Text = "Имя:";
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(92, 13);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(119, 22);
            this.TB_Name.TabIndex = 1;
            // 
            // TB_SecName
            // 
            this.TB_SecName.Location = new System.Drawing.Point(92, 65);
            this.TB_SecName.Name = "TB_SecName";
            this.TB_SecName.Size = new System.Drawing.Size(119, 22);
            this.TB_SecName.TabIndex = 2;
            // 
            // LB_SecName
            // 
            this.LB_SecName.AutoSize = true;
            this.LB_SecName.Location = new System.Drawing.Point(12, 65);
            this.LB_SecName.Name = "LB_SecName";
            this.LB_SecName.Size = new System.Drawing.Size(74, 17);
            this.LB_SecName.TabIndex = 2;
            this.LB_SecName.Text = "Фамилия:";
            // 
            // LB_Number
            // 
            this.LB_Number.AutoSize = true;
            this.LB_Number.Location = new System.Drawing.Point(14, 115);
            this.LB_Number.Name = "LB_Number";
            this.LB_Number.Size = new System.Drawing.Size(72, 17);
            this.LB_Number.TabIndex = 4;
            this.LB_Number.Text = "Телефон:";
            // 
            // TB_MaskedNumber
            // 
            this.TB_MaskedNumber.Location = new System.Drawing.Point(92, 115);
            this.TB_MaskedNumber.Mask = "(999) 00-0000009";
            this.TB_MaskedNumber.Name = "TB_MaskedNumber";
            this.TB_MaskedNumber.Size = new System.Drawing.Size(119, 22);
            this.TB_MaskedNumber.TabIndex = 3;
            // 
            // BT_SecSave
            // 
            this.BT_SecSave.Location = new System.Drawing.Point(17, 264);
            this.BT_SecSave.Name = "BT_SecSave";
            this.BT_SecSave.Size = new System.Drawing.Size(194, 46);
            this.BT_SecSave.TabIndex = 5;
            this.BT_SecSave.Text = "Save";
            this.BT_SecSave.UseVisualStyleBackColor = true;
            this.BT_SecSave.Click += new System.EventHandler(this.BT_SecSave_Click);
            // 
            // LB_NameFile
            // 
            this.LB_NameFile.AutoSize = true;
            this.LB_NameFile.Location = new System.Drawing.Point(0, 174);
            this.LB_NameFile.Name = "LB_NameFile";
            this.LB_NameFile.Size = new System.Drawing.Size(86, 17);
            this.LB_NameFile.TabIndex = 7;
            this.LB_NameFile.Text = "Имя файла:";
            // 
            // TB_NameFile
            // 
            this.TB_NameFile.Location = new System.Drawing.Point(92, 174);
            this.TB_NameFile.Name = "TB_NameFile";
            this.TB_NameFile.Size = new System.Drawing.Size(119, 22);
            this.TB_NameFile.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 322);
            this.Controls.Add(this.TB_NameFile);
            this.Controls.Add(this.LB_NameFile);
            this.Controls.Add(this.BT_SecSave);
            this.Controls.Add(this.TB_MaskedNumber);
            this.Controls.Add(this.LB_Number);
            this.Controls.Add(this.TB_SecName);
            this.Controls.Add(this.LB_SecName);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.LB_Name);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Name;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.TextBox TB_SecName;
        private System.Windows.Forms.Label LB_SecName;
        private System.Windows.Forms.Label LB_Number;
        private System.Windows.Forms.MaskedTextBox TB_MaskedNumber;
        private System.Windows.Forms.Button BT_SecSave;
        private System.Windows.Forms.Label LB_NameFile;
        private System.Windows.Forms.TextBox TB_NameFile;
    }
}