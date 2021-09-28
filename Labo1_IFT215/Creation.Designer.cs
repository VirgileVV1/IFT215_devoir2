
namespace Labo1_IFT215
{
    partial class FormCreation
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreation));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.groupBoxAuth = new System.Windows.Forms.GroupBox();
            this.labelPasswordHelpLength = new System.Windows.Forms.Label();
            this.labelPasswordHelpNumber = new System.Windows.Forms.Label();
            this.labelPasswodHelpCarac = new System.Windows.Forms.Label();
            this.labelPasswordHelpMaj = new System.Windows.Forms.Label();
            this.labelPasswordHelpMin = new System.Windows.Forms.Label();
            this.buttonVisiblePassword = new System.Windows.Forms.Button();
            this.labelMailHelp = new System.Windows.Forms.Label();
            this.groupBoxSub = new System.Windows.Forms.GroupBox();
            this.labelSubType = new System.Windows.Forms.Label();
            this.comboBoxSub = new System.Windows.Forms.ComboBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.linkLabelCode = new System.Windows.Forms.LinkLabel();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxAuth.SuspendLayout();
            this.groupBoxSub.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(370, 58);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(364, 48);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Création d\'un compte";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFirstName.Location = new System.Drawing.Point(124, 101);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(80, 28);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "Prénom";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(148, 171);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(56, 28);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Nom";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMail.Location = new System.Drawing.Point(53, 249);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(151, 28);
            this.labelMail.TabIndex = 3;
            this.labelMail.Text = "Adresse courriel";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.Location = new System.Drawing.Point(75, 368);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(129, 28);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Mot de passe";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(232, 92);
            this.textBoxFirstName.Multiline = true;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(407, 43);
            this.textBoxFirstName.TabIndex = 8;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(232, 164);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(407, 43);
            this.textBoxName.TabIndex = 8;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(232, 234);
            this.textBoxMail.Multiline = true;
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(407, 43);
            this.textBoxMail.TabIndex = 8;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(232, 368);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(452, 43);
            this.textBoxPassword.TabIndex = 8;
            // 
            // groupBoxAuth
            // 
            this.groupBoxAuth.Controls.Add(this.labelPasswordHelpLength);
            this.groupBoxAuth.Controls.Add(this.labelPasswordHelpNumber);
            this.groupBoxAuth.Controls.Add(this.labelPasswodHelpCarac);
            this.groupBoxAuth.Controls.Add(this.labelPasswordHelpMaj);
            this.groupBoxAuth.Controls.Add(this.labelPasswordHelpMin);
            this.groupBoxAuth.Controls.Add(this.buttonVisiblePassword);
            this.groupBoxAuth.Controls.Add(this.labelMailHelp);
            this.groupBoxAuth.Controls.Add(this.labelFirstName);
            this.groupBoxAuth.Controls.Add(this.textBoxPassword);
            this.groupBoxAuth.Controls.Add(this.labelName);
            this.groupBoxAuth.Controls.Add(this.textBoxMail);
            this.groupBoxAuth.Controls.Add(this.labelMail);
            this.groupBoxAuth.Controls.Add(this.textBoxName);
            this.groupBoxAuth.Controls.Add(this.labelPassword);
            this.groupBoxAuth.Controls.Add(this.textBoxFirstName);
            this.groupBoxAuth.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxAuth.Location = new System.Drawing.Point(25, 136);
            this.groupBoxAuth.Name = "groupBoxAuth";
            this.groupBoxAuth.Size = new System.Drawing.Size(870, 604);
            this.groupBoxAuth.TabIndex = 9;
            this.groupBoxAuth.TabStop = false;
            this.groupBoxAuth.Text = "Renseignements d\'autentification";
            // 
            // labelPasswordHelpLength
            // 
            this.labelPasswordHelpLength.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPasswordHelpLength.Location = new System.Drawing.Point(230, 469);
            this.labelPasswordHelpLength.Name = "labelPasswordHelpLength";
            this.labelPasswordHelpLength.Size = new System.Drawing.Size(537, 79);
            this.labelPasswordHelpLength.TabIndex = 18;
            this.labelPasswordHelpLength.Text = "Le mot de passe doit contenir au moins 12 caractères ";
            // 
            // labelPasswordHelpNumber
            // 
            this.labelPasswordHelpNumber.AutoSize = true;
            this.labelPasswordHelpNumber.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPasswordHelpNumber.Location = new System.Drawing.Point(369, 429);
            this.labelPasswordHelpNumber.Name = "labelPasswordHelpNumber";
            this.labelPasswordHelpNumber.Size = new System.Drawing.Size(60, 30);
            this.labelPasswordHelpNumber.TabIndex = 17;
            this.labelPasswordHelpNumber.Text = "[0-9]";
            // 
            // labelPasswodHelpCarac
            // 
            this.labelPasswodHelpCarac.AutoSize = true;
            this.labelPasswodHelpCarac.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPasswodHelpCarac.Location = new System.Drawing.Point(434, 429);
            this.labelPasswodHelpCarac.Name = "labelPasswodHelpCarac";
            this.labelPasswodHelpCarac.Size = new System.Drawing.Size(212, 30);
            this.labelPasswodHelpCarac.TabIndex = 15;
            this.labelPasswodHelpCarac.Text = "[@,#, $, %, &, *, ;, :, ~.]";
            // 
            // labelPasswordHelpMaj
            // 
            this.labelPasswordHelpMaj.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPasswordHelpMaj.Location = new System.Drawing.Point(298, 429);
            this.labelPasswordHelpMaj.Name = "labelPasswordHelpMaj";
            this.labelPasswordHelpMaj.Size = new System.Drawing.Size(75, 40);
            this.labelPasswordHelpMaj.TabIndex = 16;
            this.labelPasswordHelpMaj.Text = "[A-Z]";
            // 
            // labelPasswordHelpMin
            // 
            this.labelPasswordHelpMin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPasswordHelpMin.Location = new System.Drawing.Point(232, 429);
            this.labelPasswordHelpMin.Name = "labelPasswordHelpMin";
            this.labelPasswordHelpMin.Size = new System.Drawing.Size(69, 40);
            this.labelPasswordHelpMin.TabIndex = 15;
            this.labelPasswordHelpMin.Text = "[a-z]";
            // 
            // buttonVisiblePassword
            // 
            this.buttonVisiblePassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonVisiblePassword.BackgroundImage")));
            this.buttonVisiblePassword.Location = new System.Drawing.Point(717, 366);
            this.buttonVisiblePassword.Name = "buttonVisiblePassword";
            this.buttonVisiblePassword.Size = new System.Drawing.Size(50, 45);
            this.buttonVisiblePassword.TabIndex = 9;
            this.buttonVisiblePassword.UseVisualStyleBackColor = true;
            this.buttonVisiblePassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonVisiblePassword_MouseDown);
            this.buttonVisiblePassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonVisiblePassword_MouseUp);
            // 
            // labelMailHelp
            // 
            this.labelMailHelp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMailHelp.Location = new System.Drawing.Point(230, 293);
            this.labelMailHelp.Name = "labelMailHelp";
            this.labelMailHelp.Size = new System.Drawing.Size(409, 35);
            this.labelMailHelp.TabIndex = 12;
            this.labelMailHelp.Text = "Adresse e-mail invalide";
            // 
            // groupBoxSub
            // 
            this.groupBoxSub.Controls.Add(this.labelSubType);
            this.groupBoxSub.Controls.Add(this.comboBoxSub);
            this.groupBoxSub.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxSub.Location = new System.Drawing.Point(25, 774);
            this.groupBoxSub.Name = "groupBoxSub";
            this.groupBoxSub.Size = new System.Drawing.Size(560, 150);
            this.groupBoxSub.TabIndex = 10;
            this.groupBoxSub.TabStop = false;
            this.groupBoxSub.Text = "Renseignements d\'abonnement";
            // 
            // labelSubType
            // 
            this.labelSubType.AutoSize = true;
            this.labelSubType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSubType.Location = new System.Drawing.Point(18, 75);
            this.labelSubType.Name = "labelSubType";
            this.labelSubType.Size = new System.Drawing.Size(186, 28);
            this.labelSubType.TabIndex = 1;
            this.labelSubType.Text = "Type d\'abonnement";
            // 
            // comboBoxSub
            // 
            this.comboBoxSub.FormattingEnabled = true;
            this.comboBoxSub.Location = new System.Drawing.Point(257, 66);
            this.comboBoxSub.Name = "comboBoxSub";
            this.comboBoxSub.Size = new System.Drawing.Size(240, 44);
            this.comboBoxSub.TabIndex = 0;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSubmit.Location = new System.Drawing.Point(701, 916);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(194, 39);
            this.buttonSubmit.TabIndex = 11;
            this.buttonSubmit.Text = "Soumettre";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // linkLabelCode
            // 
            this.linkLabelCode.AutoSize = true;
            this.linkLabelCode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelCode.Location = new System.Drawing.Point(919, 465);
            this.linkLabelCode.Name = "linkLabelCode";
            this.linkLabelCode.Size = new System.Drawing.Size(402, 28);
            this.linkLabelCode.TabIndex = 13;
            this.linkLabelCode.TabStop = true;
            this.linkLabelCode.Text = "Vous avez un code d\'activation  ? (cliquez ici)";
            this.linkLabelCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCode_LinkClicked);
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(1028, 565);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(150, 55);
            this.textBoxCode.TabIndex = 14;
            this.textBoxCode.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(995, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 70);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 967);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.linkLabelCode);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.groupBoxSub);
            this.Controls.Add(this.groupBoxAuth);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormCreation";
            this.Text = "Création d\'un compte Pro-Gramme";
            this.groupBoxAuth.ResumeLayout(false);
            this.groupBoxAuth.PerformLayout();
            this.groupBoxSub.ResumeLayout(false);
            this.groupBoxSub.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.GroupBox groupBoxAuth;
        private System.Windows.Forms.GroupBox groupBoxSub;
        private System.Windows.Forms.Label labelSubType;
        private System.Windows.Forms.ComboBox comboBoxSub;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelMailHelp;
        private System.Windows.Forms.Button buttonVisiblePassword;
        private System.Windows.Forms.LinkLabel linkLabelCode;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Label labelPasswordHelpMin;
        private System.Windows.Forms.Label labelPasswodHelpCarac;
        private System.Windows.Forms.Label labelPasswordHelpMaj;
        private System.Windows.Forms.Label labelPasswordHelpNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelPasswordHelpLength;
    }
}

