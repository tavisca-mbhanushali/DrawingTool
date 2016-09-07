namespace Draw
{
    partial class RectangleForm
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
            this.Rectanglepanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Rectanglepanel
            // 
            this.Rectanglepanel.Location = new System.Drawing.Point(12, 12);
            this.Rectanglepanel.Name = "Rectanglepanel";
            this.Rectanglepanel.Size = new System.Drawing.Size(260, 238);
            this.Rectanglepanel.TabIndex = 0;
            // 
            // RectangleForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Rectanglepanel);
            this.Name = "RectangleForms";
            this.Text = "RectangleForms";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Rectanglepanel;
    }
}