
namespace WinsFormsAppCRUD
{
    partial class Form1
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
            this.butConnect = new System.Windows.Forms.Button();
            this.butDeconnect = new System.Windows.Forms.Button();
            this.butQuit = new System.Windows.Forms.Button();
            this.lblServeur = new System.Windows.Forms.Label();
            this.lblBdd = new System.Windows.Forms.Label();
            this.txtServeur = new System.Windows.Forms.TextBox();
            this.txtBdd = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.lblEtat = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butConnect
            // 
            this.butConnect.Location = new System.Drawing.Point(78, 302);
            this.butConnect.Name = "butConnect";
            this.butConnect.Size = new System.Drawing.Size(177, 45);
            this.butConnect.TabIndex = 0;
            this.butConnect.Text = "Connection";
            this.butConnect.UseVisualStyleBackColor = true;
            this.butConnect.Click += new System.EventHandler(this.butConnect_Click);
            // 
            // butDeconnect
            // 
            this.butDeconnect.Location = new System.Drawing.Point(335, 302);
            this.butDeconnect.Name = "butDeconnect";
            this.butDeconnect.Size = new System.Drawing.Size(151, 45);
            this.butDeconnect.TabIndex = 1;
            this.butDeconnect.Text = "Deconnection";
            this.butDeconnect.UseVisualStyleBackColor = true;
            // 
            // butQuit
            // 
            this.butQuit.Location = new System.Drawing.Point(578, 302);
            this.butQuit.Name = "butQuit";
            this.butQuit.Size = new System.Drawing.Size(156, 45);
            this.butQuit.TabIndex = 2;
            this.butQuit.Text = "Quitter";
            this.butQuit.UseVisualStyleBackColor = true;
            // 
            // lblServeur
            // 
            this.lblServeur.AutoSize = true;
            this.lblServeur.Location = new System.Drawing.Point(121, 87);
            this.lblServeur.Name = "lblServeur";
            this.lblServeur.Size = new System.Drawing.Size(64, 20);
            this.lblServeur.TabIndex = 3;
            this.lblServeur.Text = "Serveur";
            // 
            // lblBdd
            // 
            this.lblBdd.AutoSize = true;
            this.lblBdd.Location = new System.Drawing.Point(121, 180);
            this.lblBdd.Name = "lblBdd";
            this.lblBdd.Size = new System.Drawing.Size(134, 20);
            this.lblBdd.TabIndex = 4;
            this.lblBdd.Text = "Base de données";
            // 
            // txtServeur
            // 
            this.txtServeur.Location = new System.Drawing.Point(371, 80);
            this.txtServeur.Name = "txtServeur";
            this.txtServeur.Size = new System.Drawing.Size(329, 26);
            this.txtServeur.TabIndex = 5;
            // 
            // txtBdd
            // 
            this.txtBdd.Location = new System.Drawing.Point(371, 180);
            this.txtBdd.Name = "txtBdd";
            this.txtBdd.Size = new System.Drawing.Size(329, 26);
            this.txtBdd.TabIndex = 6;
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(429, 529);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(305, 184);
            this.txtInfo.TabIndex = 7;
            // 
            // lblEtat
            // 
            this.lblEtat.AutoSize = true;
            this.lblEtat.Location = new System.Drawing.Point(429, 465);
            this.lblEtat.Name = "lblEtat";
            this.lblEtat.Size = new System.Drawing.Size(159, 20);
            this.lblEtat.TabIndex = 8;
            this.lblEtat.Text = "Etat de la connection";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Location = new System.Drawing.Point(649, 465);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(49, 20);
            this.lblClose.TabIndex = 9;
            this.lblClose.Text = "Close";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 830);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblEtat);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.txtBdd);
            this.Controls.Add(this.txtServeur);
            this.Controls.Add(this.lblBdd);
            this.Controls.Add(this.lblServeur);
            this.Controls.Add(this.butQuit);
            this.Controls.Add(this.butDeconnect);
            this.Controls.Add(this.butConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butConnect;
        private System.Windows.Forms.Button butDeconnect;
        private System.Windows.Forms.Button butQuit;
        private System.Windows.Forms.Label lblServeur;
        private System.Windows.Forms.Label lblBdd;
        private System.Windows.Forms.TextBox txtServeur;
        private System.Windows.Forms.TextBox txtBdd;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label lblEtat;
        private System.Windows.Forms.Label lblClose;
    }
}

