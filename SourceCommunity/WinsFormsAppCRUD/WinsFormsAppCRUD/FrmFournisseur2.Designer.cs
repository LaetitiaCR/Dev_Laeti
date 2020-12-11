
namespace WinsFormsAppCRUD
{
    partial class FrmFournisseur2
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
            this.txtSatisfaction = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtCpVille = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblSatisfaction = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblCpVille = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.butRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSatisfaction
            // 
            this.txtSatisfaction.Location = new System.Drawing.Point(341, 378);
            this.txtSatisfaction.Name = "txtSatisfaction";
            this.txtSatisfaction.Size = new System.Drawing.Size(254, 26);
            this.txtSatisfaction.TabIndex = 23;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(341, 298);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(254, 26);
            this.txtContact.TabIndex = 22;
            // 
            // txtCpVille
            // 
            this.txtCpVille.Location = new System.Drawing.Point(341, 220);
            this.txtCpVille.Name = "txtCpVille";
            this.txtCpVille.Size = new System.Drawing.Size(254, 26);
            this.txtCpVille.TabIndex = 21;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(341, 136);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(254, 26);
            this.txtAdresse.TabIndex = 20;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(341, 46);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(254, 26);
            this.txtNom.TabIndex = 19;
            // 
            // lblSatisfaction
            // 
            this.lblSatisfaction.AutoSize = true;
            this.lblSatisfaction.Location = new System.Drawing.Point(205, 378);
            this.lblSatisfaction.Name = "lblSatisfaction";
            this.lblSatisfaction.Size = new System.Drawing.Size(93, 20);
            this.lblSatisfaction.TabIndex = 18;
            this.lblSatisfaction.Text = "Satisfaction";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(205, 298);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(65, 20);
            this.lblContact.TabIndex = 17;
            this.lblContact.Text = "Contact";
            // 
            // lblCpVille
            // 
            this.lblCpVille.AutoSize = true;
            this.lblCpVille.Location = new System.Drawing.Point(205, 223);
            this.lblCpVille.Name = "lblCpVille";
            this.lblCpVille.Size = new System.Drawing.Size(71, 20);
            this.lblCpVille.TabIndex = 16;
            this.lblCpVille.Text = "CP / Ville";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(205, 136);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(68, 20);
            this.lblAdresse.TabIndex = 15;
            this.lblAdresse.Text = "Adresse";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(205, 46);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(42, 20);
            this.lblNom.TabIndex = 14;
            this.lblNom.Text = "Nom";
            // 
            // butRetour
            // 
            this.butRetour.Location = new System.Drawing.Point(622, 459);
            this.butRetour.Name = "butRetour";
            this.butRetour.Size = new System.Drawing.Size(99, 53);
            this.butRetour.TabIndex = 24;
            this.butRetour.Text = "Retour";
            this.butRetour.UseVisualStyleBackColor = true;
            // 
            // FrmFournisseur2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 555);
            this.Controls.Add(this.butRetour);
            this.Controls.Add(this.txtSatisfaction);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtCpVille);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblSatisfaction);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblCpVille);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.lblNom);
            this.Name = "FrmFournisseur2";
            this.Text = "FrmFournisseur2";
            this.Load += new System.EventHandler(this.FrmFournisseur2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSatisfaction;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtCpVille;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblSatisfaction;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblCpVille;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button butRetour;
    }
}