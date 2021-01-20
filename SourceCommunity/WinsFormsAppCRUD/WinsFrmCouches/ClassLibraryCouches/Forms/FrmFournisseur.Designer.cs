
namespace WinsFormsAppCRUD.ClassLibraryCouches.Forms
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
            this.butSupprimer = new System.Windows.Forms.Button();
            this.butModifier = new System.Windows.Forms.Button();
            this.butCreer = new System.Windows.Forms.Button();
            this.butRechercher = new System.Windows.Forms.Button();
            this.lblSatisfaction = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblCodePostale = new System.Windows.Forms.Label();
            this.lblRue = new System.Windows.Forms.Label();
            this.lblNomFourni = new System.Windows.Forms.Label();
            this.lblNumFourni = new System.Windows.Forms.Label();
            this.txtBoxSatisfaction = new System.Windows.Forms.TextBox();
            this.txtBoxContact = new System.Windows.Forms.TextBox();
            this.txtBoxVille = new System.Windows.Forms.TextBox();
            this.txtBoxCP = new System.Windows.Forms.TextBox();
            this.txtBoxRue = new System.Windows.Forms.TextBox();
            this.txtBoxNomFourni = new System.Windows.Forms.TextBox();
            this.txtBoxNumFourni = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butSupprimer
            // 
            this.butSupprimer.Location = new System.Drawing.Point(802, 409);
            this.butSupprimer.Name = "butSupprimer";
            this.butSupprimer.Size = new System.Drawing.Size(162, 43);
            this.butSupprimer.TabIndex = 35;
            this.butSupprimer.Text = "supprimer";
            this.butSupprimer.UseVisualStyleBackColor = true;
            // 
            // butModifier
            // 
            this.butModifier.Location = new System.Drawing.Point(802, 319);
            this.butModifier.Name = "butModifier";
            this.butModifier.Size = new System.Drawing.Size(162, 41);
            this.butModifier.TabIndex = 34;
            this.butModifier.Text = "modifier";
            this.butModifier.UseVisualStyleBackColor = true;
            // 
            // butCreer
            // 
            this.butCreer.Location = new System.Drawing.Point(802, 234);
            this.butCreer.Name = "butCreer";
            this.butCreer.Size = new System.Drawing.Size(162, 36);
            this.butCreer.TabIndex = 33;
            this.butCreer.Text = "créer";
            this.butCreer.UseVisualStyleBackColor = true;
            // 
            // butRechercher
            // 
            this.butRechercher.Location = new System.Drawing.Point(802, 153);
            this.butRechercher.Name = "butRechercher";
            this.butRechercher.Size = new System.Drawing.Size(162, 38);
            this.butRechercher.TabIndex = 32;
            this.butRechercher.Text = "Rechercher";
            this.butRechercher.UseVisualStyleBackColor = true;
            this.butRechercher.Click += new System.EventHandler(this.butRechercher_Click);
            // 
            // lblSatisfaction
            // 
            this.lblSatisfaction.AutoSize = true;
            this.lblSatisfaction.Location = new System.Drawing.Point(277, 653);
            this.lblSatisfaction.Name = "lblSatisfaction";
            this.lblSatisfaction.Size = new System.Drawing.Size(90, 20);
            this.lblSatisfaction.TabIndex = 31;
            this.lblSatisfaction.Text = "satisfaction";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(302, 576);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(65, 20);
            this.lblContact.TabIndex = 30;
            this.lblContact.Text = "Contact";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(329, 489);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(38, 20);
            this.lblVille.TabIndex = 29;
            this.lblVille.Text = "Ville";
            // 
            // lblCodePostale
            // 
            this.lblCodePostale.AutoSize = true;
            this.lblCodePostale.Location = new System.Drawing.Point(282, 406);
            this.lblCodePostale.Name = "lblCodePostale";
            this.lblCodePostale.Size = new System.Drawing.Size(100, 20);
            this.lblCodePostale.TabIndex = 28;
            this.lblCodePostale.Text = "code postale";
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Location = new System.Drawing.Point(323, 319);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(32, 20);
            this.lblRue.TabIndex = 27;
            this.lblRue.Text = "rue";
            // 
            // lblNomFourni
            // 
            this.lblNomFourni.AutoSize = true;
            this.lblNomFourni.Location = new System.Drawing.Point(222, 240);
            this.lblNomFourni.Name = "lblNomFourni";
            this.lblNomFourni.Size = new System.Drawing.Size(145, 20);
            this.lblNomFourni.TabIndex = 26;
            this.lblNomFourni.Text = "nom du fournisseur";
            // 
            // lblNumFourni
            // 
            this.lblNumFourni.AutoSize = true;
            this.lblNumFourni.Location = new System.Drawing.Point(199, 144);
            this.lblNumFourni.Name = "lblNumFourni";
            this.lblNumFourni.Size = new System.Drawing.Size(168, 20);
            this.lblNumFourni.TabIndex = 25;
            this.lblNumFourni.Text = "numéro de fournisseur";
            // 
            // txtBoxSatisfaction
            // 
            this.txtBoxSatisfaction.Location = new System.Drawing.Point(439, 653);
            this.txtBoxSatisfaction.Name = "txtBoxSatisfaction";
            this.txtBoxSatisfaction.Size = new System.Drawing.Size(161, 26);
            this.txtBoxSatisfaction.TabIndex = 24;
            // 
            // txtBoxContact
            // 
            this.txtBoxContact.Location = new System.Drawing.Point(439, 570);
            this.txtBoxContact.Name = "txtBoxContact";
            this.txtBoxContact.Size = new System.Drawing.Size(161, 26);
            this.txtBoxContact.TabIndex = 23;
            // 
            // txtBoxVille
            // 
            this.txtBoxVille.Location = new System.Drawing.Point(439, 483);
            this.txtBoxVille.Name = "txtBoxVille";
            this.txtBoxVille.Size = new System.Drawing.Size(161, 26);
            this.txtBoxVille.TabIndex = 22;
            // 
            // txtBoxCP
            // 
            this.txtBoxCP.Location = new System.Drawing.Point(439, 406);
            this.txtBoxCP.Name = "txtBoxCP";
            this.txtBoxCP.Size = new System.Drawing.Size(161, 26);
            this.txtBoxCP.TabIndex = 21;
            // 
            // txtBoxRue
            // 
            this.txtBoxRue.Location = new System.Drawing.Point(439, 316);
            this.txtBoxRue.Name = "txtBoxRue";
            this.txtBoxRue.Size = new System.Drawing.Size(161, 26);
            this.txtBoxRue.TabIndex = 20;
            // 
            // txtBoxNomFourni
            // 
            this.txtBoxNomFourni.Location = new System.Drawing.Point(439, 234);
            this.txtBoxNomFourni.Name = "txtBoxNomFourni";
            this.txtBoxNomFourni.Size = new System.Drawing.Size(161, 26);
            this.txtBoxNomFourni.TabIndex = 19;
            // 
            // txtBoxNumFourni
            // 
            this.txtBoxNumFourni.Location = new System.Drawing.Point(439, 141);
            this.txtBoxNumFourni.Name = "txtBoxNumFourni";
            this.txtBoxNumFourni.Size = new System.Drawing.Size(161, 26);
            this.txtBoxNumFourni.TabIndex = 18;
            // 
            // FrmFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 821);
            this.Controls.Add(this.butSupprimer);
            this.Controls.Add(this.butModifier);
            this.Controls.Add(this.butCreer);
            this.Controls.Add(this.butRechercher);
            this.Controls.Add(this.lblSatisfaction);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.lblCodePostale);
            this.Controls.Add(this.lblRue);
            this.Controls.Add(this.lblNomFourni);
            this.Controls.Add(this.lblNumFourni);
            this.Controls.Add(this.txtBoxSatisfaction);
            this.Controls.Add(this.txtBoxContact);
            this.Controls.Add(this.txtBoxVille);
            this.Controls.Add(this.txtBoxCP);
            this.Controls.Add(this.txtBoxRue);
            this.Controls.Add(this.txtBoxNomFourni);
            this.Controls.Add(this.txtBoxNumFourni);
            this.Name = "FrmFournisseur";
            this.Text = "FrmFournisseur";
            this.Load += new System.EventHandler(this.FrmFournisseur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butSupprimer;
        private System.Windows.Forms.Button butModifier;
        private System.Windows.Forms.Button butCreer;
        private System.Windows.Forms.Button butRechercher;
        private System.Windows.Forms.Label lblSatisfaction;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblCodePostale;
        private System.Windows.Forms.Label lblRue;
        private System.Windows.Forms.Label lblNomFourni;
        private System.Windows.Forms.Label lblNumFourni;
        private System.Windows.Forms.TextBox txtBoxSatisfaction;
        private System.Windows.Forms.TextBox txtBoxContact;
        private System.Windows.Forms.TextBox txtBoxVille;
        private System.Windows.Forms.TextBox txtBoxCP;
        private System.Windows.Forms.TextBox txtBoxRue;
        private System.Windows.Forms.TextBox txtBoxNomFourni;
        private System.Windows.Forms.TextBox txtBoxNumFourni;
    }
}