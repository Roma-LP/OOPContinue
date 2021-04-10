
namespace CS_LAB_02
{
    partial class AboutForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BT_OK4Form = new System.Windows.Forms.Button();
            this.Label1_4Form = new System.Windows.Forms.Label();
            this.LabelTime_4Form = new System.Windows.Forms.Label();
            this.Timer_4Form = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CS_LAB_02.Properties.Resources.original;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 375);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BT_OK4Form
            // 
            this.BT_OK4Form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_OK4Form.Location = new System.Drawing.Point(521, 325);
            this.BT_OK4Form.Name = "BT_OK4Form";
            this.BT_OK4Form.Size = new System.Drawing.Size(303, 62);
            this.BT_OK4Form.TabIndex = 1;
            this.BT_OK4Form.Text = "OK";
            this.BT_OK4Form.UseVisualStyleBackColor = true;
            this.BT_OK4Form.Click += new System.EventHandler(this.BT_OK4Form_Click);
            // 
            // Label1_4Form
            // 
            this.Label1_4Form.AutoSize = true;
            this.Label1_4Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label1_4Form.Location = new System.Drawing.Point(517, 32);
            this.Label1_4Form.Name = "Label1_4Form";
            this.Label1_4Form.Size = new System.Drawing.Size(315, 40);
            this.Label1_4Form.TabIndex = 2;
            this.Label1_4Form.Text = "                 Лепеш Рома v2.4\r\n© Все права защищены ООО \"LRD\" 2021";
            // 
            // LabelTime_4Form
            // 
            this.LabelTime_4Form.AutoSize = true;
            this.LabelTime_4Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTime_4Form.Location = new System.Drawing.Point(576, 165);
            this.LabelTime_4Form.Name = "LabelTime_4Form";
            this.LabelTime_4Form.Size = new System.Drawing.Size(0, 20);
            this.LabelTime_4Form.TabIndex = 3;
            // 
            // Timer_4Form
            // 
            this.Timer_4Form.Enabled = true;
            this.Timer_4Form.Tick += new System.EventHandler(this.Timer_4Form_Tick);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 404);
            this.Controls.Add(this.LabelTime_4Form);
            this.Controls.Add(this.Label1_4Form);
            this.Controls.Add(this.BT_OK4Form);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AboutForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AboutForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BT_OK4Form;
        private System.Windows.Forms.Label Label1_4Form;
        private System.Windows.Forms.Label LabelTime_4Form;
        private System.Windows.Forms.Timer Timer_4Form;
    }
}