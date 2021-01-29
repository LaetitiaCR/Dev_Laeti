
namespace WindowsFormsAppFigureS
{
    partial class FrmMontreFigure
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
            this.butShow = new System.Windows.Forms.Button();
            this.butDeplacer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butShow
            // 
            this.butShow.Location = new System.Drawing.Point(516, 105);
            this.butShow.Name = "butShow";
            this.butShow.Size = new System.Drawing.Size(164, 91);
            this.butShow.TabIndex = 0;
            this.butShow.Text = "Afficher la figure";
            this.butShow.UseVisualStyleBackColor = true;
            this.butShow.Click += new System.EventHandler(this.butShow_Click);
            // 
            // butDeplacer
            // 
            this.butDeplacer.Location = new System.Drawing.Point(516, 267);
            this.butDeplacer.Name = "butDeplacer";
            this.butDeplacer.Size = new System.Drawing.Size(164, 76);
            this.butDeplacer.TabIndex = 1;
            this.butDeplacer.Text = "Deplacer la figure";
            this.butDeplacer.UseVisualStyleBackColor = true;
            this.butDeplacer.Click += new System.EventHandler(this.butDeplacer_Click);
            // 
            // FrmMontreFigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butDeplacer);
            this.Controls.Add(this.butShow);
            this.Name = "FrmMontreFigure";
            this.Text = "FrmMontreFigure";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butShow;
        private System.Windows.Forms.Button butDeplacer;
    }
}