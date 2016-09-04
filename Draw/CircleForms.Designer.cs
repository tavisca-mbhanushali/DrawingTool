namespace Draw
{
    partial class CircleForms
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
            this.Circlepanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Circlepanel
            // 
            this.Circlepanel.Location = new System.Drawing.Point(12, 12);
            this.Circlepanel.Name = "Circlepanel";
            this.Circlepanel.Size = new System.Drawing.Size(260, 238);
            this.Circlepanel.TabIndex = 0;
            this.Circlepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Circlepanel_Paint);
            // 
            // CircleForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Circlepanel);
            this.Name = "CircleForms";
            this.Text = "CircleForms";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Circlepanel;
    }
}