using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace classeEmploye
{
    public class Employe
    {
        private string matricule; 
        public string Matricule {
            get { return matricule; }
            set 
            { 
                //verifie la longueur du matricule
                if (value.Length == 7 && long.TryParse(value, out _)) { matricule = value; }
                else { throw new ArgumentException("Le matricule doit etre composé de 7 chiffres."); }
            } 
        }
        public string Nom { get; set;}
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        private float salaireAnnuel;
        public float SalaireAnnuel {
            get { return salaireAnnuel; }
            set { salaireAnnuel = (float)Math.Round(value, 2); }
                }
        public DateTime DateEntreeFonction { get; set;}

        public Employe(string matricule,string nom, string prenom, DateTime dateNaissance, float salaireAnnuel, DateTime dateEntreeFonction)
        {
            this.matricule = matricule;
            this.Nom = nom;
            this.Prenom = prenom;
            this.DateNaissance = dateNaissance;
            this.SalaireAnnuel = salaireAnnuel;
            this.DateEntreeFonction = dateEntreeFonction;

        }

















































    }
}
