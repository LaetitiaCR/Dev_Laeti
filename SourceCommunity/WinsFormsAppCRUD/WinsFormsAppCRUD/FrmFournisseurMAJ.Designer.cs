
namespace WinsFormsAppCRUD
{
    partial class FrmFournisseurMAJ
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
            this.components = new System.ComponentModel.Container();
            this.txtBoxNumFourni = new System.Windows.Forms.TextBox();
            this.txtBoxNomFourni = new System.Windows.Forms.TextBox();
            this.txtBoxRue = new System.Windows.Forms.TextBox();
            this.txtBoxCP = new System.Windows.Forms.TextBox();
            this.txtBoxVille = new System.Windows.Forms.TextBox();
            this.txtBoxContact = new System.Windows.Forms.TextBox();
            this.txtBoxSatisfaction = new System.Windows.Forms.TextBox();
            this.lblNumFourni = new System.Windows.Forms.Label();
            this.lblNomFourni = new System.Windows.Forms.Label();
            this.lblRue = new System.Windows.Forms.Label();
            this.lblCodePostale = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblSatisfaction = new System.Windows.Forms.Label();
            this.butRechercher = new System.Windows.Forms.Button();
            this.butCreer = new System.Windows.Forms.Button();
            this.butModifier = new System.Windows.Forms.Button();
            this.butSupprimer = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxNumFourni
            // 
            this.txtBoxNumFourni.Location = new System.Drawing.Point(509, 132);
            this.txtBoxNumFourni.Name = "txtBoxNumFourni";
            this.txtBoxNumFourni.Size = new System.Drawing.Size(161, 26);
            this.txtBoxNumFourni.TabIndex = 0;
            this.txtBoxNumFourni.TextChanged += new System.EventHandler(this.txtBoxNumFourni_TextChanged);
            // 
            // txtBoxNomFourni
            // 
            this.txtBoxNomFourni.Location = new System.Drawing.Point(509, 225);
            this.txtBoxNomFourni.Name = "txtBoxNomFourni";
            this.txtBoxNomFourni.Size = new System.Drawing.Size(161, 26);
            this.txtBoxNomFourni.TabIndex = 1;
            this.txtBoxNomFourni.TextChanged += new System.EventHandler(this.txtBoxNomFourni_TextChanged);
            // 
            // txtBoxRue
            // 
            this.txtBoxRue.Location = new System.Drawing.Point(509, 307);
            this.txtBoxRue.Name = "txtBoxRue";
            this.txtBoxRue.Size = new System.Drawing.Size(161, 26);
            this.txtBoxRue.TabIndex = 2;
            // 
            // txtBoxCP
            // 
            this.txtBoxCP.Location = new System.Drawing.Point(509, 397);
            this.txtBoxCP.Name = "txtBoxCP";
            this.txtBoxCP.Size = new System.Drawing.Size(161, 26);
            this.txtBoxCP.TabIndex = 3;
            // 
            // txtBoxVille
            // 
            this.txtBoxVille.Location = new System.Drawing.Point(509, 474);
            this.txtBoxVille.Name = "txtBoxVille";
            this.txtBoxVille.Size = new System.Drawing.Size(161, 26);
            this.txtBoxVille.TabIndex = 4;
            // 
            // txtBoxContact
            // 
            this.txtBoxContact.Location = new System.Drawing.Point(509, 561);
            this.txtBoxContact.Name = "txtBoxContact";
            this.txtBoxContact.Size = new System.Drawing.Size(161, 26);
            this.txtBoxContact.TabIndex = 5;
            // 
            // txtBoxSatisfaction
            // 
            this.txtBoxSatisfaction.Location = new System.Drawing.Point(509, 644);
            this.txtBoxSatisfaction.Name = "txtBoxSatisfaction";
            this.txtBoxSatisfaction.Size = new System.Drawing.Size(161, 26);
            this.txtBoxSatisfaction.TabIndex = 6;
            // 
            // lblNumFourni
            // 
            this.lblNumFourni.AutoSize = true;
            this.lblNumFourni.Location = new System.Drawing.Point(269, 135);
            this.lblNumFourni.Name = "lblNumFourni";
            this.lblNumFourni.Size = new System.Drawing.Size(168, 20);
            this.lblNumFourni.TabIndex = 7;
            this.lblNumFourni.Text = "numéro de fournisseur";
            // 
            // lblNomFourni
            // 
            this.lblNomFourni.AutoSize = true;
            this.lblNomFourni.Location = new System.Drawing.Point(292, 231);
            this.lblNomFourni.Name = "lblNomFourni";
            this.lblNomFourni.Size = new System.Drawing.Size(145, 20);
            this.lblNomFourni.TabIndex = 8;
            this.lblNomFourni.Text = "nom du fournisseur";
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Location = new System.Drawing.Point(393, 310);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(32, 20);
            this.lblRue.TabIndex = 9;
            this.lblRue.Text = "rue";
            // 
            // lblCodePostale
            // 
            this.lblCodePostale.AutoSize = true;
            this.lblCodePostale.Location = new System.Drawing.Point(352, 397);
            this.lblCodePostale.Name = "lblCodePostale";
            this.lblCodePostale.Size = new System.Drawing.Size(100, 20);
            this.lblCodePostale.TabIndex = 10;
            this.lblCodePostale.Text = "code postale";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(399, 480);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(38, 20);
            this.lblVille.TabIndex = 11;
            this.lblVille.Text = "Ville";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(372, 567);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(65, 20);
            this.lblContact.TabIndex = 12;
            this.lblContact.Text = "Contact";
            // 
            // lblSatisfaction
            // 
            this.lblSatisfaction.AutoSize = true;
            this.lblSatisfaction.Location = new System.Drawing.Point(347, 644);
            this.lblSatisfaction.Name = "lblSatisfaction";
            this.lblSatisfaction.Size = new System.Drawing.Size(90, 20);
            this.lblSatisfaction.TabIndex = 13;
            this.lblSatisfaction.Text = "satisfaction";
            // 
            // butRechercher
            // 
            this.butRechercher.Location = new System.Drawing.Point(872, 144);
            this.butRechercher.Name = "butRechercher";
            this.butRechercher.Size = new System.Drawing.Size(162, 38);
            this.butRechercher.TabIndex = 14;
            this.butRechercher.Text = "Rechercher";
            this.butRechercher.UseVisualStyleBackColor = true;
            this.butRechercher.Click += new System.EventHandler(this.butRechercher_Click);
            // 
            // butCreer
            // 
            this.butCreer.Location = new System.Drawing.Point(872, 225);
            this.butCreer.Name = "butCreer";
            this.butCreer.Size = new System.Drawing.Size(162, 36);
            this.butCreer.TabIndex = 15;
            this.butCreer.Text = "créer";
            this.butCreer.UseVisualStyleBackColor = true;
            this.butCreer.Click += new System.EventHandler(this.butCreer_Click);
            // 
            // butModifier
            // 
            this.butModifier.Location = new System.Drawing.Point(872, 310);
            this.butModifier.Name = "butModifier";
            this.butModifier.Size = new System.Drawing.Size(162, 41);
            this.butModifier.TabIndex = 16;
            this.butModifier.Text = "modifier";
            this.butModifier.UseVisualStyleBackColor = true;
            this.butModifier.Click += new System.EventHandler(this.butModifier_Click);
            // 
            // butSupprimer
            // 
            this.butSupprimer.Location = new System.Drawing.Point(872, 400);
            this.butSupprimer.Name = "butSupprimer";
            this.butSupprimer.Size = new System.Drawing.Size(162, 43);
            this.butSupprimer.TabIndex = 17;
            this.butSupprimer.Text = "supprimer";
            this.butSupprimer.UseVisualStyleBackColor = true;
            this.butSupprimer.Click += new System.EventHandler(this.butSupprimer_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmFournisseurMAJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 756);
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
            this.Name = "FrmFournisseurMAJ";
            this.Text = "FrmFournisseurMAJ";
            this.Load += new System.EventHandler(this.FrmFournisseurMAJ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxNumFourni;
        private System.Windows.Forms.TextBox txtBoxNomFourni;
        private System.Windows.Forms.TextBox txtBoxRue;
        private System.Windows.Forms.TextBox txtBoxCP;
        private System.Windows.Forms.TextBox txtBoxVille;
        private System.Windows.Forms.TextBox txtBoxContact;
        private System.Windows.Forms.TextBox txtBoxSatisfaction;
        private System.Windows.Forms.Label lblNumFourni;
        private System.Windows.Forms.Label lblNomFourni;
        private System.Windows.Forms.Label lblRue;
        private System.Windows.Forms.Label lblCodePostale;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblSatisfaction;
        private System.Windows.Forms.Button butRechercher;
        private System.Windows.Forms.Button butCreer;
        private System.Windows.Forms.Button butModifier;
        private System.Windows.Forms.Button butSupprimer;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        
    }
}