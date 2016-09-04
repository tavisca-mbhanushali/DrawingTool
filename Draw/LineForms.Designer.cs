namespace ShapeForm
{
    partial class LineForms
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
            this.linepanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // linepanel
            // 
            this.linepanel.Location = new System.Drawing.Point(12, 12);
            this.linepanel.Name = "linepanel";
            this.linepanel.Size = new System.Drawing.Size(260, 238);
            this.linepanel.TabIndex = 0;
            this.linepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.linepanel_Paint);
            // 
            // LineForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.linepanel);
            this.Name = "LineForms";
            this.Text = "LineForms";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel linepanel;
    }
}