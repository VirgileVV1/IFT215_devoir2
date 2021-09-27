using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo1_IFT215
{
    public partial class FormDevoir2 : Form
    {
        // Variables globales
        List<Compte> comptes;

        public FormDevoir2()
        {
            InitializeComponent();
            InitMyComponents();
            labelMailHelp.Visible = false;
            CreerCompte();
            textBoxMail.TextChanged += CourrielChange;

        }

        /*
         * Initialise les valeurs de la combo box d'abonnement
         */
        private void InitMyComponents()
        {
            comboBoxSub.DataSource = new AbonnementItem[]
            {
                new AbonnementItem {ID = 0, Texte = "Basique", Valeur = 10.99},
                new AbonnementItem {ID = 1, Texte = "Premium", Valeur = 50.99},
                new AbonnementItem {ID = 2, Texte = "Entraineur", Valeur = 100.99},
            };
            comboBoxSub.DisplayMember = "Texte";
            comboBoxSub.ValueMember = "ID";

        }

        /*
         * Action lors du clic sur le bouton "soumettre"
         */
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string prenom = textBoxFirstName.Text;
            string nom = textBoxName.Text;
            string courriel = textBoxMail.Text;
            string motDePasse = textBoxPassword.Text;

            AbonnementItem abonnement = (AbonnementItem)comboBoxSub.SelectedItem;
            string resume = prenom + " " + nom + " " + courriel + " " +
                            abonnement.Texte + " à " + abonnement.Valeur + "$.";

            MessageBox.Show(resume);

            Compte nouveau = new Compte
            {
                Prenom = prenom,
                Nom = nom,
                Courriel = courriel,
                MotDePasse = motDePasse,
                Abonnement = abonnement.ID
            };
            comptes.Add(nouveau);

        }

        /*
         * Methode de verification de l'adresse e-mail
         */
        public bool IsEmailAddressValid(string email)
        {
            try
            {
                Regex reg = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$",
                RegexOptions.IgnoreCase);
                return (reg.IsMatch(email));
            }
            catch
            {
                return false;
            }
        }

        /*
         * Action lors de la modification de la textbox de l'e-mail
         */
        private void CourrielChange(object sender, EventArgs e)
        {
            string email = textBoxMail.Text;

            //Verification du format de l'adresse mail
            if (IsEmailAddressValid(email))
            {
                var compteExistant = comptes.FirstOrDefault(o => o.Courriel == email);
                //verification de l'adresse email parmis les comptes existants
                if (compteExistant != null)
                {
                    textBoxMail.BackColor = Color.Coral;
                    //labelMailExist.Visible = true;
                    //labelMailExist.ForeColor = Color.Coral;
                    labelMailHelp.Text = "Cette adresse e-mail possède déjà un compte";
                    labelMailHelp.ForeColor = Color.Coral;
                }
                else
                {
                    textBoxMail.BackColor = Color.Aquamarine;
                    labelMailHelp.Text = "Format correct";
                    //labelMailHelp.Visible = false;
                    //labelMailExist.Visible = false;
                }
            }
            else
            {
                textBoxMail.BackColor = Color.Coral;
                labelMailHelp.Visible = true;
                labelMailHelp.ForeColor = Color.Coral;
            }
        }

        /*
         * Methode de création de compte 
         */
        private void CreerCompte()
        {
            comptes = new List<Compte>();
            comptes.Add(new Compte
            {
                Prenom = "John",
                Nom = "Wick",
                Courriel =
           "donotkill@my.dog",
                MotDePasse = "asdfsdfsdf",
                Abonnement = 0
            });
            comptes.Add(new Compte
            {
                Prenom = "John",
                Nom = "Malchovick",
                Courriel =
           "being@him.com",
                MotDePasse = "asdfsdfsdf",
                Abonnement = 1
            });
            comptes.Add(new Compte
            {
                Prenom = "Frédéric",
                Nom = "Bergeron",
                Courriel =
           "courriel@serveur.domaine",
                MotDePasse = "asdfsdfsdf",
                Abonnement = 0
            });
        }
       

        /*
         * Action lors de l'appui du clic de la souris
         **/
        public void buttonVisiblePassword_MouseDown(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
        }

        /*
         * Action lors du relachement du clic de la souris
         **/
        public void buttonVisiblePassword_MouseUp(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = false;
        }
        
        /*
         * Action lors du clic sur l'hyperlien
         */
        private void linkLabelCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBoxCode.Visible = true;
        }
    }

}

