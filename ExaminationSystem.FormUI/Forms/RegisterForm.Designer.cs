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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_lastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_firstName = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rb_student = new System.Windows.Forms.RadioButton();
            this.rb_examiner = new System.Windows.Forms.RadioButton();
            this.rb_admin = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.tb_password, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_email, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_lastName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_firstName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_register, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tb_password
            // 
            this.tb_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_password.Location = new System.Drawing.Point(163, 249);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(634, 27);
            this.tb_password.TabIndex = 8;
            // 
            // tb_email
            // 
            this.tb_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_email.Location = new System.Drawing.Point(163, 174);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(634, 27);
            this.tb_email.TabIndex = 7;
            // 
            // tb_lastName
            // 
            this.tb_lastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_lastName.Location = new System.Drawing.Point(163, 99);
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.Size = new System.Drawing.Size(634, 27);
            this.tb_lastName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 75);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 75);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 75);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_firstName
            // 
            this.tb_firstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_firstName.Location = new System.Drawing.Point(163, 24);
            this.tb_firstName.Name = "tb_firstName";
            this.tb_firstName.Size = new System.Drawing.Size(634, 27);
            this.tb_firstName.TabIndex = 5;
            // 
            // btn_register
            // 
            this.btn_register.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_register.Location = new System.Drawing.Point(163, 378);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(634, 69);
            this.btn_register.TabIndex = 9;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.rb_student);
            this.flowLayoutPanel1.Controls.Add(this.rb_examiner);
            this.flowLayoutPanel1.Controls.Add(this.rb_admin);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(163, 303);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(634, 69);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // rb_student
            // 
            this.rb_student.AutoSize = true;
            this.rb_student.Location = new System.Drawing.Point(3, 3);
            this.rb_student.Name = "rb_student";
            this.rb_student.Size = new System.Drawing.Size(81, 24);
            this.rb_student.TabIndex = 1;
            this.rb_student.Text = "Student";
            this.rb_student.UseVisualStyleBackColor = true;
            // 
            // rb_examiner
            // 
            this.rb_examiner.AutoSize = true;
            this.rb_examiner.Location = new System.Drawing.Point(90, 3);
            this.rb_examiner.Name = "rb_examiner";
            this.rb_examiner.Size = new System.Drawing.Size(91, 24);
            this.rb_examiner.TabIndex = 0;
            this.rb_examiner.TabStop = true;
            this.rb_examiner.Text = "Examiner";
            this.rb_examiner.UseVisualStyleBackColor = true;
            // 
            // rb_admin
            // 
            this.rb_admin.AutoSize = true;
            this.rb_admin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rb_admin.Location = new System.Drawing.Point(187, 3);
            this.rb_admin.Name = "rb_admin";
            this.rb_admin.Size = new System.Drawing.Size(74, 24);
            this.rb_admin.TabIndex = 2;
            this.rb_admin.TabStop = true;
            this.rb_admin.Text = "Admin";
            this.rb_admin.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox tb_firstName;
        private TextBox tb_email;
        private TextBox tb_lastName;
        private TextBox tb_password;
        private Button btn_register;
        private FlowLayoutPanel flowLayoutPanel1;
        private RadioButton rb_student;
        private RadioButton rb_examiner;
        private RadioButton rb_admin;
    }
}