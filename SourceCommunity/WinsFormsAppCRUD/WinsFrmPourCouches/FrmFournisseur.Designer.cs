
namespace WinsFrmPourCouches
{
    partial class FrmFournisseur
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
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
            this.butSupprimer.Location = new System.Drawing.Point(805, 382);
            this.butSupprimer.Name = "butSupprimer";
            this.butSupprimer.Size = new System.Drawing.Size(162, 43);
            this.butSupprimer.TabIndex = 35;
            this.butSupprimer.Text = "supprimer";
            this.butSupprimer.UseVisualStyleBackColor = true;
            // 
            // butModifier
            // 
            this.butModifier.Location = new System.Drawing.Point(805, 292);
            this.butModifier.Name = "butModifier";
            this.butModifier.Size = new System.Drawing.Size(162, 41);
            this.butModifier.TabIndex = 34;
            this.butModifier.Text = "modifier";
            this.butModifier.UseVisualStyleBackColor = true;
            // 
            // butCreer
            // 
            this.butCreer.Location = new System.Drawing.Point(805, 207);
            this.butCreer.Name = "butCreer";
            this.butCreer.Size = new System.Drawing.Size(162, 36);
            this.butCreer.TabIndex = 33;
            this.butCreer.Text = "créer";
            this.butCreer.UseVisualStyleBackColor = true;
            this.butCreer.Click += new System.EventHandler(this.butCreer_Click);
            // 
            // butRechercher
            // 
            this.butRechercher.Location = new System.Drawing.Point(805, 126);
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
            this.lblSatisfaction.Location = new System.Drawing.Point(280, 626);
            this.lblSatisfaction.Name = "lblSatisfaction";
            this.lblSatisfaction.Size = new System.Drawing.Size(90, 20);
            this.lblSatisfaction.TabIndex = 31;
            this.lblSatisfaction.Text = "satisfaction";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(305, 549);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(65, 20);
            this.lblContact.TabIndex = 30;
            this.lblContact.Text = "Contact";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(332, 462);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(38, 20);
            this.lblVille.TabIndex = 29;
            this.lblVille.Text = "Ville";
            // 
            // lblCodePostale
            // 
            this.lblCodePostale.AutoSize = true;
            this.lblCodePostale.Location = new System.Drawing.Point(285, 379);
            this.lblCodePostale.Name = "lblCodePostale";
            this.lblCodePostale.Size = new System.Drawing.Size(100, 20);
            this.lblCodePostale.TabIndex = 28;
            this.lblCodePostale.Text = "code postale";
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Location = new System.Drawing.Point(326, 292);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(32, 20);
            this.lblRue.TabIndex = 27;
            this.lblRue.Text = "rue";
            // 
            // lblNomFourni
            // 
            this.lblNomFourni.AutoSize = true;
            this.lblNomFourni.Location = new System.Drawing.Point(225, 213);
            this.lblNomFourni.Name = "lblNomFourni";
            this.lblNomFourni.Size = new System.Drawing.Size(145, 20);
            this.lblNomFourni.TabIndex = 26;
            this.lblNomFourni.Text = "nom du fournisseur";
            // 
            // lblNumFourni
            // 
            this.lblNumFourni.AutoSize = true;
            this.lblNumFourni.Location = new System.Drawing.Point(202, 117);
            this.lblNumFourni.Name = "lblNumFourni";
            this.lblNumFourni.Size = new System.Drawing.Size(168, 20);
            this.lblNumFourni.TabIndex = 25;
            this.lblNumFourni.Text = "numéro de fournisseur";
            // 
            // txtBoxSatisfaction
            // 
            this.txtBoxSatisfaction.Location = new System.Drawing.Point(442, 626);
            this.txtBoxSatisfaction.Name = "txtBoxSatisfaction";
            this.txtBoxSatisfaction.Size = new System.Drawing.Size(161, 26);
            this.txtBoxSatisfaction.TabIndex = 24;
            // 
            // txtBoxContact
            // 
            this.txtBoxContact.Location = new System.Drawing.Point(442, 543);
            this.txtBoxContact.Name = "txtBoxContact";
            this.txtBoxContact.Size = new System.Drawing.Size(161, 26);
            this.txtBoxContact.TabIndex = 23;
            // 
            // txtBoxVille
            // 
            this.txtBoxVille.Location = new System.Drawing.Point(442, 456);
            this.txtBoxVille.Name = "txtBoxVille";
            this.txtBoxVille.Size = new System.Drawing.Size(161, 26);
            this.txtBoxVille.TabIndex = 22;
            // 
            // txtBoxCP
            // 
            this.txtBoxCP.Location = new System.Drawing.Point(442, 379);
            this.txtBoxCP.Name = "txtBoxCP";
            this.txtBoxCP.Size = new System.Drawing.Size(161, 26);
            this.txtBoxCP.TabIndex = 21;
            // 
            // txtBoxRue
            // 
            this.txtBoxRue.Location = new System.Drawing.Point(442, 289);
            this.txtBoxRue.Name = "txtBoxRue";
            this.txtBoxRue.Size = new System.Drawing.Size(161, 26);
            this.txtBoxRue.TabIndex = 20;
            // 
            // txtBoxNomFourni
            // 
            this.txtBoxNomFourni.Location = new System.Drawing.Point(442, 207);
            this.txtBoxNomFourni.Name = "txtBoxNomFourni";
            this.txtBoxNomFourni.Size = new System.Drawing.Size(161, 26);
            this.txtBoxNomFourni.TabIndex = 19;
            // 
            // txtBoxNumFourni
            // 
            this.txtBoxNumFourni.Location = new System.Drawing.Point(442, 114);
            this.txtBoxNumFourni.Name = "txtBoxNumFourni";
            this.txtBoxNumFourni.Size = new System.Drawing.Size(161, 26);
            this.txtBoxNumFourni.TabIndex = 18;
            // 
            // FrmFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 767);
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
            this.Text = "Form1";
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

