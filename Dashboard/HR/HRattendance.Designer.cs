using leave_management_system.Dashboard.Employee;

namespace leave_management_system.Dashboard.HR
{
    partial class HRattendance
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HRattendance));
            this.HRlabel1 = new System.Windows.Forms.Label();
            this.HRpictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.HRpictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HRlabel1
            // 
            this.HRlabel1.AutoSize = true;
            this.HRlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRlabel1.Location = new System.Drawing.Point(403, 307);
            this.HRlabel1.Name = "HRlabel1";
            this.HRlabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HRlabel1.Size = new System.Drawing.Size(306, 29);
            this.HRlabel1.TabIndex = 0;
            this.HRlabel1.Text = "Attendance will come soon!";
            // 
            // HRpictureBox1
            // 
            this.HRpictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("HRpictureBox1.Image")));
            this.HRpictureBox1.Location = new System.Drawing.Point(419, 64);
            this.HRpictureBox1.Name = "HRpictureBox1";
            this.HRpictureBox1.Size = new System.Drawing.Size(275, 223);
            this.HRpictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HRpictureBox1.TabIndex = 1;
            this.HRpictureBox1.TabStop = false;
            // 
            // HRattendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HRpictureBox1);
            this.Controls.Add(this.HRlabel1);
            this.Name = "HRattendance";
            this.Size = new System.Drawing.Size(1159, 573);
            ((System.ComponentModel.ISupportInitialize)(this.HRpictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HRlabel1;
        private System.Windows.Forms.PictureBox HRpictureBox1;
    }
}
