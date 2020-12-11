
namespace WinsFormsAppCRUD
{
    partial class FrmFournisseur
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
            this.txtCodeFournis = new System.Windows.Forms.TextBox();
            this.lblCodeFournis = new System.Windows.Forms.Label();
            this.butValider = new System.Windows.Forms.Button();
            this.butQuitter = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCodeFournis
            // 
            this.txtCodeFournis.Location = new System.Drawing.Point(257, 112);
            this.txtCodeFournis.Name = "txtCodeFournis";
            this.txtCodeFournis.Size = new System.Drawing.Size(100, 26);
            this.txtCodeFournis.TabIndex = 0;
            // 
            // lblCodeFournis
            // 
            this.lblCodeFournis.AutoSize = true;
            this.lblCodeFournis.Location = new System.Drawing.Point(68, 112);
            this.lblCodeFournis.Name = "lblCodeFournis";
            this.lblCodeFournis.Size = new System.Drawing.Size(135, 20);
            this.lblCodeFournis.TabIndex = 1;
            this.lblCodeFournis.Text = "Code Fournisseur";
            // 
            // butValider
            // 
            this.butValider.Location = new System.Drawing.Point(498, 102);
            this.butValider.Name = "butValider";
            this.butValider.Size = new System.Drawing.Size(98, 46);
            this.butValider.TabIndex = 2;
            this.butValider.Text = "Valider";
            this.butValider.UseVisualStyleBackColor = true;
            this.butValider.Click += new System.EventHandler(this.butValider_Click);
            // 
            // butQuitter
            // 
            this.butQuitter.Location = new System.Drawing.Point(675, 102);
            this.butQuitter.Name = "butQuitter";
            this.butQuitter.Size = new System.Drawing.Size(89, 46);
            this.butQuitter.TabIndex = 3;
            this.butQuitter.Text = "Quitter";
            this.butQuitter.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(428, 293);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(295, 156);
            this.txtResult.TabIndex = 4;
            // 
            // FrmFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 679);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.butQuitter);
            this.Controls.Add(this.butValider);
            this.Controls.Add(this.lblCodeFournis);
            this.Controls.Add(this.txtCodeFournis);
            this.Name = "FrmFournisseur";
            this.Text = "FrmFournisseur";
            this.Load += new System.EventHandler(this.FrmFournisseur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodeFournis;
        private System.Windows.Forms.Label lblCodeFournis;
        private System.Windows.Forms.Button butValider;
        private System.Windows.Forms.Button butQuitter;
        private System.Windows.Forms.TextBox txtResult;
    }
}