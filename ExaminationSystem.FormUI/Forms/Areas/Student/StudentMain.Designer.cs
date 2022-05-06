namespace ExaminationSystem.FormUI.Forms.Areas.Student
{
    partial class StudentMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentMain));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.Exam = new System.Windows.Forms.TabPage();
            this.Reports = new System.Windows.Forms.TabPage();
            this.Settings = new System.Windows.Forms.TabPage();
            this.Profil = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.Exam);
            this.materialTabControl1.Controls.Add(this.Reports);
            this.materialTabControl1.Controls.Add(this.Settings);
            this.materialTabControl1.Controls.Add(this.Profil);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(888, 614);
            this.materialTabControl1.TabIndex = 3;
            // 
            // Exam
            // 
            this.Exam.BackColor = System.Drawing.Color.White;
            this.Exam.ImageKey = "examicon.png";
            this.Exam.Location = new System.Drawing.Point(4, 39);
            this.Exam.Name = "Exam";
            this.Exam.Padding = new System.Windows.Forms.Padding(3);
            this.Exam.Size = new System.Drawing.Size(880, 571);
            this.Exam.TabIndex = 0;
            this.Exam.Text = "Exam";
            // 
            // Reports
            // 
            this.Reports.ImageKey = "analytics.png";
            this.Reports.Location = new System.Drawing.Point(4, 39);
            this.Reports.Name = "Reports";
            this.Reports.Padding = new System.Windows.Forms.Padding(3);
            this.Reports.Size = new System.Drawing.Size(880, 571);
            this.Reports.TabIndex = 1;
            this.Reports.Text = "Reports";
            this.Reports.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.Settings.ImageKey = "setting.png";
            this.Settings.Location = new System.Drawing.Point(4, 39);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(880, 571);
            this.Settings.TabIndex = 2;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // Profil
            // 
            this.Profil.ImageKey = "usericon.png";
            this.Profil.Location = new System.Drawing.Point(4, 39);
            this.Profil.Name = "Profil";
            this.Profil.Size = new System.Drawing.Size(880, 571);
            this.Profil.TabIndex = 3;
            this.Profil.Text = "Profil";
            this.Profil.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "exam.png");
            this.imageList1.Images.SetKeyName(1, "analytics.png");
            this.imageList1.Images.SetKeyName(2, "usericon.png");
            this.imageList1.Images.SetKeyName(3, "examicon.png");
            this.imageList1.Images.SetKeyName(4, "setting.png");
            // 
            // StudentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 681);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "StudentMain";
            this.Text = "StudentMain";
            this.Load += new System.EventHandler(this.StudentMain_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage Exam;
        private TabPage Reports;
        private TabPage Settings;
        private TabPage Profil;
        private ImageList imageList1;
    }
}