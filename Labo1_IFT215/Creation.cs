﻿using System;
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
    public partial class FormCreation : Form
    {
        // - Variables globales -
        //Liste des comptes qui se sont inscrit au Pro-Gramme
        List<Compte> comptes;

        /**
         * Methode appelée au lancement du formCreation
         */
        public FormCreation()
        {
            InitializeComponent();
            InitMyComponents();
            labelMailHelp.Visible = false;
            CreerCompte();
            textBoxMail.TextChanged += CourrielChange;
            textBoxPassword.TextChanged += passwordChange;

        }

        /**
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

        /**
         * Action lors du clic sur le bouton "soumettre"
         */
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            // --- soumission avec email ---
            string prenom = textBoxFirstName.Text;
            string nom = textBoxName.Text;
            string courriel = textBoxMail.Text;
            string motDePasse = textBoxPassword.Text;
            bool testSubmit = true;
            //bool test = false;

            if (!prenom.Equals(""))
            {
                testSubmit = true;
            }
            else {
                if (testSubmit)
                {
                    testSubmit = false;
                    MessageBox.Show("Veuillez entrer un prénom");
                }
            }
            if (testSubmit && !nom.Equals(""))
            {
                testSubmit = true;
            }
            else
            {
                if (testSubmit)
                {
                    testSubmit = false;
                    MessageBox.Show("Veuillez entrer un nom");
                }

            }

            if (testSubmit && IsEmailAddressValid(courriel))
            {
                testSubmit = true;
            }
            else
            {
                if (testSubmit)
                {
                    testSubmit = false;
                    MessageBox.Show("E-Mail invalide");
                }
            }

            if (testSubmit && ValidatePassword(motDePasse))
            {
                testSubmit = true;
            }
            else
            {
                if (testSubmit)
                {
                    testSubmit = false;
                    MessageBox.Show("Mot de passe invalide");
                }
            }
        
         
            if (testSubmit)
            {

                AbonnementItem abonnement = (AbonnementItem)comboBoxSub.SelectedItem;
                string resume = prenom + " " + nom + " " + courriel + " " +
                                abonnement.Texte + " à " + abonnement.Valeur + "$.";


                // --- soumission avec code : ---
                /*si la txb pour le code n'est pas vide alors on a juste
                 a verifier si il y a un nom et un prenom*/

                MessageBox.Show(resume);

                //Si tout s'est bien passé, on créé le compte et on l'ajoute a la liste "comptes"
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

        }

        /**
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

        /**
         * Action lors de la modification de la textbox de l'e-mail
         */
        int cptCar = 0;
        private void CourrielChange(object sender, EventArgs e)
        {
            cptCar++;
            string email = textBoxMail.Text;
            // verification du format de l'adresse mail
            if (IsEmailAddressValid(email))
            {
                var compteExistant = comptes.FirstOrDefault(o => o.Courriel == email);
                // verification de l'adresse email parmis les comptes existants
                if (compteExistant != null)
                {
                    textBoxMail.BackColor = Color.Red;
                    labelMailHelp.Text = "Cette adresse e-mail possède déjà un compte";
                    labelMailHelp.ForeColor = Color.Red;
                }
                else
                {
                    textBoxMail.BackColor = Color.Green;
                    labelMailHelp.Text = "Format correct";
                    labelMailHelp.ForeColor = Color.Green;

                }
            }
            else
            {
                textBoxMail.BackColor = Color.Red;
                labelMailHelp.Text = "Format incorrect";
                labelMailHelp.Visible = true;
                labelMailHelp.ForeColor = Color.Red;
            }
            if(textBoxMail.Text == "")
            {
                labelMailHelp.Visible = false;
                textBoxMail.BackColor = Color.White;

            }
        }

        /**
         * Création de compte par défaut
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


        /**
         * Action lors de l'appui sur le clic de la souris
         */
        public void buttonVisiblePassword_MouseDown(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
        }

        /**
         * Action lors du relachement du clic de la souris
         */
        public void buttonVisiblePassword_MouseUp(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = false;
        }

        /**
         * Action lors du clic sur l'hyperlien
         */
        private void linkLabelCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // on fait apparaitre une textbox pour permettre a l'utilisateur de rentrer son code
            textBoxCode.Visible = true;
        }

        /**
         * Methode permettant de vérifier si le mdp est au bon format
         * Modifie la couleur des labels pour permettre a l'utilisateur de voir ce qu'il lui manque
         * @return 1 si le mot de passe est au bon format, 0 sinon
         */
        private bool ValidatePassword(string password)
        {

            const int MIN_LENGTH = 12;

            bool LengthValid = (password.Length >= MIN_LENGTH);

            bool hasUpperCaseLetter = false;
            bool hasLowerCaseLetter = false;
            bool hasDecimalDigit = false;
            var hasSymbols = new Regex(@"[!@#$%^&*;:~.]");
            var hasUpper = new Regex(@"[a-z]");
            var hasLower = new Regex(@"[A-Z]");
            var nbCaractere = 0;
          
                foreach (char c in password)
                {
                if (char.IsUpper(c))
                {
                    hasUpperCaseLetter = true;
                    labelPasswordHelpMaj.ForeColor = Color.Green;

                }
                else if (char.IsLower(c) == true)
                {
                    hasLowerCaseLetter = true;
                    labelPasswordHelpMin.ForeColor = Color.Green;
                }
               
                else if (char.IsDigit(c))
                {
                    hasDecimalDigit = true;
                    labelPasswordHelpNumber.ForeColor = Color.Green;
                }
                else if (hasSymbols.IsMatch(password))
                {
                    nbCaractere++;
                    if (nbCaractere >= 2) {
                       
                        labelPasswodHelpCarac.ForeColor = Color.Green;

                    }
                }
                if (LengthValid)
                {
                    labelPasswordHelpLength.ForeColor = Color.Green;
                }
                }
            
            bool isValid = LengthValid
              && hasUpperCaseLetter
              && hasLowerCaseLetter
              && hasDecimalDigit
              && hasSymbols.IsMatch(password);
              ;
            return isValid;
        }

        /**
         * Action lors de la modification du text de la textBoxPassword 
         */
        private void passwordChange(object sender, EventArgs e)
        {
            labelPasswordHelpMin.ForeColor = Color.Red;
            labelPasswordHelpMaj.ForeColor = Color.Red;
            labelPasswodHelpCarac.ForeColor = Color.Red;
            labelPasswordHelpNumber.ForeColor = Color.Red;
            labelPasswordHelpLength.ForeColor = Color.Red;


            string password = textBoxPassword.Text;
            ValidatePassword(password);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            FormNotification formNotif = new FormNotification();
            formNotif.Show();
        }

  
    }
     

}