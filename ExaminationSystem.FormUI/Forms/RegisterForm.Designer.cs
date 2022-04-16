namespace ExaminationSystem.FormUI.Forms
{
    partial class RegisterForm
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
            this.rb_examiner = new MaterialSkin.Controls.MaterialRadioButton();
            this.rb_admin = new MaterialSkin.Controls.MaterialRadioButton();
            this.rb_student = new MaterialSkin.Controls.MaterialRadioButton();
            this.btn_register = new MaterialSkin.Controls.MaterialButton();
            this.tb_password = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.tb_email = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.tb_lastName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.tb_firstName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // rb_examiner
            // 
            this.rb_examiner.AutoSize = true;
            this.rb_examiner.Depth = 0;
            this.rb_examiner.Location = new System.Drawing.Point(156, 485);
            this.rb_examiner.Margin = new System.Windows.Forms.Padding(0);
            this.rb_examiner.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb_examiner.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_examiner.Name = "rb_examiner";
            this.rb_examiner.Ripple = true;
            this.rb_examiner.Size = new System.Drawing.Size(101, 37);
            this.rb_examiner.TabIndex = 26;
            this.rb_examiner.TabStop = true;
            this.rb_examiner.Text = "Examiner";
            this.rb_examiner.UseVisualStyleBackColor = true;
            // 
            // rb_admin
            // 
            this.rb_admin.AutoSize = true;
            this.rb_admin.Depth = 0;
            this.rb_admin.Location = new System.Drawing.Point(322, 485);
            this.rb_admin.Margin = new System.Windows.Forms.Padding(0);
            this.rb_admin.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb_admin.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_admin.Name = "rb_admin";
            this.rb_admin.Ripple = true;
            this.rb_admin.Size = new System.Drawing.Size(81, 37);
            this.rb_admin.TabIndex = 25;
            this.rb_admin.TabStop = true;
            this.rb_admin.Text = "Admin";
            this.rb_admin.UseVisualStyleBackColor = true;
            // 
            // rb_student
            // 
            this.rb_student.AutoSize = true;
            this.rb_student.Depth = 0;
            this.rb_student.Location = new System.Drawing.Point(12, 485);
            this.rb_student.Margin = new System.Windows.Forms.Padding(0);
            this.rb_student.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb_student.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_student.Name = "rb_student";
            this.rb_student.Ripple = true;
            this.rb_student.Size = new System.Drawing.Size(90, 37);
            this.rb_student.TabIndex = 24;
            this.rb_student.TabStop = true;
            this.rb_student.Text = "Student";
            this.rb_student.UseVisualStyleBackColor = true;
            // 
            // btn_register
            // 
            this.btn_register.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_register.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_register.Depth = 0;
            this.btn_register.HighEmphasis = true;
            this.btn_register.Icon = null;
            this.btn_register.Location = new System.Drawing.Point(109, 606);
            this.btn_register.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_register.MinimumSize = new System.Drawing.Size(250, 70);
            this.btn_register.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_register.Name = "btn_register";
            this.btn_register.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_register.Size = new System.Drawing.Size(250, 70);
            this.btn_register.TabIndex = 23;
            this.btn_register.Text = "Register";
            this.btn_register.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_register.UseAccentColor = false;
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // tb_password
            // 
            this.tb_password.AllowPromptAsInput = true;
            this.tb_password.AnimateReadOnly = false;
            this.tb_password.AsciiOnly = false;
            this.tb_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_password.BeepOnError = false;
            this.tb_password.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.tb_password.Depth = 0;
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_password.HidePromptOnLeave = false;
            this.tb_password.HideSelection = true;
            this.tb_password.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.tb_password.LeadingIcon = null;
            this.tb_password.Location = new System.Drawing.Point(156, 355);
            this.tb_password.Mask = "";
            this.tb_password.MaxLength = 32767;
            this.tb_password.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.PrefixSuffixText = null;
            this.tb_password.PromptChar = '_';
            this.tb_password.ReadOnly = false;
            this.tb_password.RejectInputOnFirstFailure = false;
            this.tb_password.ResetOnPrompt = true;
            this.tb_password.ResetOnSpace = true;
            this.tb_password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_password.SelectedText = "";
            this.tb_password.SelectionLength = 0;
            this.tb_password.SelectionStart = 0;
            this.tb_password.ShortcutsEnabled = true;
            this.tb_password.Size = new System.Drawing.Size(312, 48);
            this.tb_password.SkipLiterals = true;
            this.tb_password.TabIndex = 22;
            this.tb_password.TabStop = false;
            this.tb_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_password.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.tb_password.TrailingIcon = null;
            this.tb_password.UseSystemPasswordChar = false;
            this.tb_password.ValidatingType = null;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel4.Location = new System.Drawing.Point(12, 365);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(107, 29);
            this.materialLabel4.TabIndex = 21;
            this.materialLabel4.Text = "Password";
            // 
            // tb_email
            // 
            this.tb_email.AllowPromptAsInput = true;
            this.tb_email.AnimateReadOnly = false;
            this.tb_email.AsciiOnly = false;
            this.tb_email.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_email.BeepOnError = false;
            this.tb_email.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.tb_email.Depth = 0;
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_email.HidePromptOnLeave = false;
            this.tb_email.HideSelection = true;
            this.tb_email.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.tb_email.LeadingIcon = null;
            this.tb_email.Location = new System.Drawing.Point(156, 265);
            this.tb_email.Mask = "";
            this.tb_email.MaxLength = 32767;
            this.tb_email.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_email.Name = "tb_email";
            this.tb_email.PasswordChar = '\0';
            this.tb_email.PrefixSuffixText = null;
            this.tb_email.PromptChar = '_';
            this.tb_email.ReadOnly = false;
            this.tb_email.RejectInputOnFirstFailure = false;
            this.tb_email.ResetOnPrompt = true;
            this.tb_email.ResetOnSpace = true;
            this.tb_email.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_email.SelectedText = "";
            this.tb_email.SelectionLength = 0;
            this.tb_email.SelectionStart = 0;
            this.tb_email.ShortcutsEnabled = true;
            this.tb_email.Size = new System.Drawing.Size(312, 48);
            this.tb_email.SkipLiterals = true;
            this.tb_email.TabIndex = 20;
            this.tb_email.TabStop = false;
            this.tb_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_email.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.tb_email.TrailingIcon = null;
            this.tb_email.UseSystemPasswordChar = false;
            this.tb_email.ValidatingType = null;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel3.Location = new System.Drawing.Point(12, 275);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(61, 29);
            this.materialLabel3.TabIndex = 19;
            this.materialLabel3.Text = "Email";
            // 
            // tb_lastName
            // 
            this.tb_lastName.AllowPromptAsInput = true;
            this.tb_lastName.AnimateReadOnly = false;
            this.tb_lastName.AsciiOnly = false;
            this.tb_lastName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_lastName.BeepOnError = false;
            this.tb_lastName.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.tb_lastName.Depth = 0;
            this.tb_lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_lastName.HidePromptOnLeave = false;
            this.tb_lastName.HideSelection = true;
            this.tb_lastName.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.tb_lastName.LeadingIcon = null;
            this.tb_lastName.Location = new System.Drawing.Point(156, 179);
            this.tb_lastName.Mask = "";
            this.tb_lastName.MaxLength = 32767;
            this.tb_lastName.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.PasswordChar = '\0';
            this.tb_lastName.PrefixSuffixText = null;
            this.tb_lastName.PromptChar = '_';
            this.tb_lastName.ReadOnly = false;
            this.tb_lastName.RejectInputOnFirstFailure = false;
            this.tb_lastName.ResetOnPrompt = true;
            this.tb_lastName.ResetOnSpace = true;
            this.tb_lastName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_lastName.SelectedText = "";
            this.tb_lastName.SelectionLength = 0;
            this.tb_lastName.SelectionStart = 0;
            this.tb_lastName.ShortcutsEnabled = true;
            this.tb_lastName.Size = new System.Drawing.Size(312, 48);
            this.tb_lastName.SkipLiterals = true;
            this.tb_lastName.TabIndex = 18;
            this.tb_lastName.TabStop = false;
            this.tb_lastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_lastName.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.tb_lastName.TrailingIcon = null;
            this.tb_lastName.UseSystemPasswordChar = false;
            this.tb_lastName.ValidatingType = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.Location = new System.Drawing.Point(12, 189);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(117, 29);
            this.materialLabel2.TabIndex = 17;
            this.materialLabel2.Text = "Last Name";
            // 
            // tb_firstName
            // 
            this.tb_firstName.AllowPromptAsInput = true;
            this.tb_firstName.AnimateReadOnly = false;
            this.tb_firstName.AsciiOnly = false;
            this.tb_firstName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_firstName.BeepOnError = false;
            this.tb_firstName.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.tb_firstName.Depth = 0;
            this.tb_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_firstName.HidePromptOnLeave = false;
            this.tb_firstName.HideSelection = true;
            this.tb_firstName.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.tb_firstName.LeadingIcon = null;
            this.tb_firstName.Location = new System.Drawing.Point(156, 87);
            this.tb_firstName.Mask = "";
            this.tb_firstName.MaxLength = 32767;
            this.tb_firstName.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_firstName.Name = "tb_firstName";
            this.tb_firstName.PasswordChar = '\0';
            this.tb_firstName.PrefixSuffixText = null;
            this.tb_firstName.PromptChar = '_';
            this.tb_firstName.ReadOnly = false;
            this.tb_firstName.RejectInputOnFirstFailure = false;
            this.tb_firstName.ResetOnPrompt = true;
            this.tb_firstName.ResetOnSpace = true;
            this.tb_firstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_firstName.SelectedText = "";
            this.tb_firstName.SelectionLength = 0;
            this.tb_firstName.SelectionStart = 0;
            this.tb_firstName.ShortcutsEnabled = true;
            this.tb_firstName.Size = new System.Drawing.Size(312, 48);
            this.tb_firstName.SkipLiterals = true;
            this.tb_firstName.TabIndex = 16;
            this.tb_firstName.TabStop = false;
            this.tb_firstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_firstName.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.tb_firstName.TrailingIcon = null;
            this.tb_firstName.UseSystemPasswordChar = false;
            this.tb_firstName.ValidatingType = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(12, 97);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(118, 29);
            this.materialLabel1.TabIndex = 15;
            this.materialLabel1.Text = "First Name";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 724);
            this.Controls.Add(this.rb_examiner);
            this.Controls.Add(this.rb_admin);
            this.Controls.Add(this.rb_student);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.tb_lastName);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.tb_firstName);
            this.Controls.Add(this.materialLabel1);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRadioButton rb_examiner;
        private MaterialSkin.Controls.MaterialRadioButton rb_admin;
        private MaterialSkin.Controls.MaterialRadioButton rb_student;
        private MaterialSkin.Controls.MaterialButton btn_register;
        private MaterialSkin.Controls.MaterialMaskedTextBox tb_password;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialMaskedTextBox tb_email;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialMaskedTextBox tb_lastName;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialMaskedTextBox tb_firstName;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}