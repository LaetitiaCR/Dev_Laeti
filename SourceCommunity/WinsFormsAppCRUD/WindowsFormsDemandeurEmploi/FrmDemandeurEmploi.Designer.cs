
namespace WindowsFormsDemandeurEmploi
{
    partial class FrmDemandeurEmploi
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
            this.butAjouter = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblnumSS = new System.Windows.Forms.Label();
            this.lblnom = new System.Windows.Forms.Label();
            this.lblprenom = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butAjouter
            // 
            this.butAjouter.Location = new System.Drawing.Point(788, 549);
            this.butAjouter.Name = "butAjouter";
            this.butAjouter.Size = new System.Drawing.Size(125, 72);
            this.butAjouter.TabIndex = 0;
            this.butAjouter.Text = "Ajouter";
            this.butAjouter.UseVisualStyleBackColor = true;
            this.butAjouter.Click += new System.EventHandler(this.butAjouter_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(487, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(468, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(487, 210);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(468, 26);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(487, 317);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(468, 26);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(487, 419);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(468, 26);
            this.textBox4.TabIndex = 4;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lblnumSS
            // 
            this.lblnumSS.AutoSize = true;
            this.lblnumSS.Location = new System.Drawing.Point(145, 128);
            this.lblnumSS.Name = "lblnumSS";
            this.lblnumSS.Size = new System.Drawing.Size(198, 20);
            this.lblnumSS.TabIndex = 5;
            this.lblnumSS.Text = "numéro de sécurité sociale";
            this.lblnumSS.Click += new System.EventHandler(this.lblnumSS_Click);
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.Location = new System.Drawing.Point(145, 199);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(40, 20);
            this.lblnom.TabIndex = 6;
            this.lblnom.Text = "nom";
            this.lblnom.Click += new System.EventHandler(this.lblnom_Click);
            // 
            // lblprenom
            // 
            this.lblprenom.AutoSize = true;
            this.lblprenom.Location = new System.Drawing.Point(145, 287);
            this.lblprenom.Name = "lblprenom";
            this.lblprenom.Size = new System.Drawing.Size(63, 20);
            this.lblprenom.TabIndex = 7;
            this.lblprenom.Text = "prenom";
            this.lblprenom.Click += new System.EventHandler(this.lblprenom_Click);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(145, 410);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(128, 20);
            this.lbldate.TabIndex = 8;
            this.lbldate.Text = "date d\'inscription";
            this.lbldate.Click += new System.EventHandler(this.lbldate_Click);
            // 
            // FrmDemandeurEmploi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 803);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lblprenom);
            this.Controls.Add(this.lblnom);
            this.Controls.Add(this.lblnumSS);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.butAjouter);
            this.Name = "FrmDemandeurEmploi";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmDemandeurEmploi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butAjouter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblnumSS;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.Label lblprenom;
        private System.Windows.Forms.Label lbldate;
    }
}

