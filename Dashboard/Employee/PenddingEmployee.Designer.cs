namespace leave_management_system.Dashboard.Employee
{
    partial class PenddingEmployee
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
            this.Pendding = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Pendding
            // 
            this.Pendding.AutoSize = true;
            this.Pendding.Location = new System.Drawing.Point(448, 241);
            this.Pendding.Name = "Pendding";
            this.Pendding.Size = new System.Drawing.Size(65, 16);
            this.Pendding.TabIndex = 0;
            this.Pendding.Text = "Pendding";
            // 
            // PenddingEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Pendding);
            this.Name = "PenddingEmployee";
            this.Size = new System.Drawing.Size(1158, 576);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Pendding;
    }
}
