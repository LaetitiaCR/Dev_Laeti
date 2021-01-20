
namespace WinsFrmDemandeurEmploi
{
    partial class FrmAjoutDemEmploi
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
            this.lbldate = new System.Windows.Forms.Label();
            this.lblprenom = new System.Windows.Forms.Label();
            this.lblnom = new System.Windows.Forms.Label();
            this.lblnumSS = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtsecu = new System.Windows.Forms.TextBox();
            this.butAjouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(138, 429);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(128, 20);
            this.lbldate.TabIndex = 17;
            this.lbldate.Text = "date d\'inscription";
            // 
            // lblprenom
            // 
            this.lblprenom.AutoSize = true;
            this.lblprenom.Location = new System.Drawing.Point(138, 306);
            this.lblprenom.Name = "lblprenom";
            this.lblprenom.Size = new System.Drawing.Size(63, 20);
            this.lblprenom.TabIndex = 16;
            this.lblprenom.Text = "prenom";
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.Location = new System.Drawing.Point(138, 218);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(40, 20);
            this.lblnom.TabIndex = 15;
            this.lblnom.Text = "nom";
            // 
            // lblnumSS
            // 
            this.lblnumSS.AutoSize = true;
            this.lblnumSS.Location = new System.Drawing.Point(138, 147);
            this.lblnumSS.Name = "lblnumSS";
            this.lblnumSS.Size = new System.Drawing.Size(198, 20);
            this.lblnumSS.TabIndex = 14;
            this.lblnumSS.Text = "numéro de sécurité sociale";
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(480, 438);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(468, 26);
            this.txtdate.TabIndex = 13;
            // 
            // txtprenom
            // 
            this.txtprenom.Location = new System.Drawing.Point(480, 336);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(468, 26);
            this.txtprenom.TabIndex = 12;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(480, 229);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(468, 26);
            this.txtnom.TabIndex = 11;
            // 
            // txtsecu
            // 
            this.txtsecu.Location = new System.Drawing.Point(480, 147);
            this.txtsecu.Name = "txtsecu";
            this.txtsecu.Size = new System.Drawing.Size(468, 26);
            this.txtsecu.TabIndex = 10;
            this.txtsecu.TextChanged += new System.EventHandler(this.txtsecu_TextChanged);
            // 
            // butAjouter
            // 
            this.butAjouter.Location = new System.Drawing.Point(781, 568);
            this.butAjouter.Name = "butAjouter";
            this.butAjouter.Size = new System.Drawing.Size(125, 72);
            this.butAjouter.TabIndex = 9;
            this.butAjouter.Text = "Ajouter";
            this.butAjouter.UseVisualStyleBackColor = true;
            this.butAjouter.Click += new System.EventHandler(this.butAjouter_Click);
            // 
            // FrmAjoutDemEmploi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 786);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lblprenom);
            this.Controls.Add(this.lblnom);
            this.Controls.Add(this.lblnumSS);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.txtprenom);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.txtsecu);
            this.Controls.Add(this.butAjouter);
            this.Name = "FrmAjoutDemEmploi";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblprenom;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.Label lblnumSS;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtsecu;
        private System.Windows.Forms.Button butAjouter;
    }
}

