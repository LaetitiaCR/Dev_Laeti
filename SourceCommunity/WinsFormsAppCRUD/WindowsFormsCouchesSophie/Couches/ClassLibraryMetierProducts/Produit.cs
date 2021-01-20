using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMetierProducts
{
    public class Produit
    {
        private int code_article;
        private string libelle_article;
        private int qte_en_cours_commande;
        private int stock_physique;

        public Produit(int code_article, string libelle_article, int qte_en_cours_commande, int stock_physique)
        {
            this.code_article = code_article;
            this.libelle_article = libelle_article ?? throw new ArgumentNullException(nameof(libelle_article));
            this.qte_en_cours_commande = qte_en_cours_commande;
            this.stock_physique = stock_physique;
        }

        //manipuler la persistance
    }
}
