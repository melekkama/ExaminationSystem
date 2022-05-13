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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lb_sınavSüre = new MaterialSkin.Controls.MaterialLabel();
            this.lb_tarih = new MaterialSkin.Controls.MaterialLabel();
            this.lb_hosgeldin = new MaterialSkin.Controls.MaterialLabel();
            this.lb_sınav_süre = new MaterialSkin.Controls.MaterialLabel();
            this.lb_sınav_tarih = new MaterialSkin.Controls.MaterialLabel();
            this.lb_sınav_bilgi = new MaterialSkin.Controls.MaterialLabel();
            this.btn_start_exam = new MaterialSkin.Controls.MaterialButton();
            this.Reports = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Settings = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.lb_aralık6 = new MaterialSkin.Controls.MaterialLabel();
            this.lb_aralık5 = new MaterialSkin.Controls.MaterialLabel();
            this.lb_aralık4 = new MaterialSkin.Controls.MaterialLabel();
            this.lb_aralık3 = new MaterialSkin.Controls.MaterialLabel();
            this.lb_aralık2 = new MaterialSkin.Controls.MaterialLabel();
            this.lb_aralık1 = new MaterialSkin.Controls.MaterialLabel();
            this.cb_aralık6 = new MaterialSkin.Controls.MaterialComboBox();
            this.cb_aralık5 = new MaterialSkin.Controls.MaterialComboBox();
            this.cb_aralık4 = new MaterialSkin.Controls.MaterialComboBox();
            this.cb_aralık3 = new MaterialSkin.Controls.MaterialComboBox();
            this.cb_aralık2 = new MaterialSkin.Controls.MaterialComboBox();
            this.cb_aralık1 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_zamanKaydet = new MaterialSkin.Controls.MaterialButton();
            this.Profil = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.lb_kayıt_tarih = new MaterialSkin.Controls.MaterialLabel();
            this.lb_email = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.lb_soyad = new MaterialSkin.Controls.MaterialLabel();
            this.lb_ad = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.materialTabControl1.SuspendLayout();
            this.Exam.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.Reports.SuspendLayout();
            this.Settings.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.Profil.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.materialCard5.SuspendLayout();
            this.materialCard6.SuspendLayout();
            this.materialCard2.SuspendLayout();
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
            this.materialTabControl1.Size = new System.Drawing.Size(904, 629);
            this.materialTabControl1.TabIndex = 3;
            // 
            // Exam
            // 
            this.Exam.BackColor = System.Drawing.Color.White;
            this.Exam.Controls.Add(this.tableLayoutPanel1);
            this.Exam.ImageKey = "examicon.png";
            this.Exam.Location = new System.Drawing.Point(4, 39);
            this.Exam.Name = "Exam";
            this.Exam.Padding = new System.Windows.Forms.Padding(3);
            this.Exam.Size = new System.Drawing.Size(896, 586);
            this.Exam.TabIndex = 0;
            this.Exam.Text = "Exam";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.materialCard1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(890, 580);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lb_sınavSüre);
            this.materialCard1.Controls.Add(this.lb_tarih);
            this.materialCard1.Controls.Add(this.lb_hosgeldin);
            this.materialCard1.Controls.Add(this.lb_sınav_süre);
            this.materialCard1.Controls.Add(this.lb_sınav_tarih);
            this.materialCard1.Controls.Add(this.lb_sınav_bilgi);
            this.materialCard1.Controls.Add(this.btn_start_exam);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(103, 72);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(684, 436);
            this.materialCard1.TabIndex = 0;
            // 
            // lb_sınavSüre
            // 
            this.lb_sınavSüre.AutoSize = true;
            this.lb_sınavSüre.Depth = 0;
            this.lb_sınavSüre.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_sınavSüre.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lb_sınavSüre.Location = new System.Drawing.Point(256, 236);
            this.lb_sınavSüre.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_sınavSüre.Name = "lb_sınavSüre";
            this.lb_sınavSüre.Size = new System.Drawing.Size(88, 24);
            this.lb_sınavSüre.TabIndex = 6;
            this.lb_sınavSüre.Text = "10 Dakika";
            // 
            // lb_tarih
            // 
            this.lb_tarih.AutoSize = true;
            this.lb_tarih.Depth = 0;
            this.lb_tarih.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_tarih.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lb_tarih.Location = new System.Drawing.Point(256, 162);
            this.lb_tarih.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_tarih.Name = "lb_tarih";
            this.lb_tarih.Size = new System.Drawing.Size(42, 24);
            this.lb_tarih.TabIndex = 5;
            this.lb_tarih.Text = "tarih";
            // 
            // lb_hosgeldin
            // 
            this.lb_hosgeldin.AutoSize = true;
            this.lb_hosgeldin.Depth = 0;
            this.lb_hosgeldin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_hosgeldin.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_hosgeldin.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.lb_hosgeldin.ForeColor = System.Drawing.Color.Black;
            this.lb_hosgeldin.Location = new System.Drawing.Point(14, 14);
            this.lb_hosgeldin.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_hosgeldin.Name = "lb_hosgeldin";
            this.lb_hosgeldin.Size = new System.Drawing.Size(574, 58);
            this.lb_hosgeldin.TabIndex = 4;
            this.lb_hosgeldin.Text = "Sınav Ekranına Hoşgeldiniz";
            this.lb_hosgeldin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_hosgeldin.UseMnemonic = false;
            // 
            // lb_sınav_süre
            // 
            this.lb_sınav_süre.AutoSize = true;
            this.lb_sınav_süre.Depth = 0;
            this.lb_sınav_süre.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_sınav_süre.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lb_sınav_süre.Location = new System.Drawing.Point(17, 236);
            this.lb_sınav_süre.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_sınav_süre.Name = "lb_sınav_süre";
            this.lb_sınav_süre.Size = new System.Drawing.Size(132, 24);
            this.lb_sınav_süre.TabIndex = 3;
            this.lb_sınav_süre.Text = "Sınav Süreniz: ";
            // 
            // lb_sınav_tarih
            // 
            this.lb_sınav_tarih.AutoSize = true;
            this.lb_sınav_tarih.Depth = 0;
            this.lb_sınav_tarih.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_sınav_tarih.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lb_sınav_tarih.ForeColor = System.Drawing.Color.Black;
            this.lb_sınav_tarih.Location = new System.Drawing.Point(14, 162);
            this.lb_sınav_tarih.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_sınav_tarih.Name = "lb_sınav_tarih";
            this.lb_sınav_tarih.Size = new System.Drawing.Size(236, 24);
            this.lb_sınav_tarih.TabIndex = 2;
            this.lb_sınav_tarih.Text = "Sınava Başlama Tarihiniz: ";
            // 
            // lb_sınav_bilgi
            // 
            this.lb_sınav_bilgi.AutoSize = true;
            this.lb_sınav_bilgi.Depth = 0;
            this.lb_sınav_bilgi.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_sınav_bilgi.Location = new System.Drawing.Point(235, 121);
            this.lb_sınav_bilgi.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_sınav_bilgi.Name = "lb_sınav_bilgi";
            this.lb_sınav_bilgi.Size = new System.Drawing.Size(1, 0);
            this.lb_sınav_bilgi.TabIndex = 1;
            // 
            // btn_start_exam
            // 
            this.btn_start_exam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_start_exam.BackColor = System.Drawing.Color.Transparent;
            this.btn_start_exam.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_start_exam.Depth = 0;
            this.btn_start_exam.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_start_exam.HighEmphasis = true;
            this.btn_start_exam.Icon = null;
            this.btn_start_exam.Location = new System.Drawing.Point(14, 386);
            this.btn_start_exam.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_start_exam.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_start_exam.Name = "btn_start_exam";
            this.btn_start_exam.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_start_exam.Size = new System.Drawing.Size(656, 36);
            this.btn_start_exam.TabIndex = 0;
            this.btn_start_exam.Text = "S ı n a v a   B a ş l a";
            this.btn_start_exam.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_start_exam.UseAccentColor = false;
            this.btn_start_exam.UseVisualStyleBackColor = false;
            this.btn_start_exam.Click += new System.EventHandler(this.btn_start_exam_Click);
            // 
            // Reports
            // 
            this.Reports.Controls.Add(this.tableLayoutPanel3);
            this.Reports.ImageKey = "analytics.png";
            this.Reports.Location = new System.Drawing.Point(4, 39);
            this.Reports.Name = "Reports";
            this.Reports.Padding = new System.Windows.Forms.Padding(3);
            this.Reports.Size = new System.Drawing.Size(896, 586);
            this.Reports.TabIndex = 1;
            this.Reports.Text = "Reports";
            this.Reports.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(890, 580);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.tableLayoutPanel5);
            this.Settings.ImageKey = "setting.png";
            this.Settings.Location = new System.Drawing.Point(4, 39);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(896, 586);
            this.Settings.TabIndex = 2;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.Controls.Add(this.materialCard3, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.materialCard4, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btn_zamanKaydet, 1, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(896, 586);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.lb_aralık6);
            this.materialCard3.Controls.Add(this.lb_aralık5);
            this.materialCard3.Controls.Add(this.lb_aralık4);
            this.materialCard3.Controls.Add(this.lb_aralık3);
            this.materialCard3.Controls.Add(this.lb_aralık2);
            this.materialCard3.Controls.Add(this.lb_aralık1);
            this.materialCard3.Controls.Add(this.cb_aralık6);
            this.materialCard3.Controls.Add(this.cb_aralık5);
            this.materialCard3.Controls.Add(this.cb_aralık4);
            this.materialCard3.Controls.Add(this.cb_aralık3);
            this.materialCard3.Controls.Add(this.cb_aralık2);
            this.materialCard3.Controls.Add(this.cb_aralık1);
            this.materialCard3.Depth = 0;
            this.materialCard3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(103, 72);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(688, 440);
            this.materialCard3.TabIndex = 0;
            // 
            // lb_aralık6
            // 
            this.lb_aralık6.AutoSize = true;
            this.lb_aralık6.Depth = 0;
            this.lb_aralık6.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_aralık6.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lb_aralık6.Location = new System.Drawing.Point(98, 384);
            this.lb_aralık6.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_aralık6.Name = "lb_aralık6";
            this.lb_aralık6.Size = new System.Drawing.Size(153, 24);
            this.lb_aralık6.TabIndex = 12;
            this.lb_aralık6.Text = "6. zaman aralığı: ";
            // 
            // lb_aralık5
            // 
            this.lb_aralık5.AutoSize = true;
            this.lb_aralık5.Depth = 0;
            this.lb_aralık5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_aralık5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lb_aralık5.Location = new System.Drawing.Point(98, 322);
            this.lb_aralık5.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_aralık5.Name = "lb_aralık5";
            this.lb_aralık5.Size = new System.Drawing.Size(153, 24);
            this.lb_aralık5.TabIndex = 11;
            this.lb_aralık5.Text = "5. zaman aralığı: ";
            // 
            // lb_aralık4
            // 
            this.lb_aralık4.AutoSize = true;
            this.lb_aralık4.Depth = 0;
            this.lb_aralık4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_aralık4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lb_aralık4.Location = new System.Drawing.Point(98, 251);
            this.lb_aralık4.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_aralık4.Name = "lb_aralık4";
            this.lb_aralık4.Size = new System.Drawing.Size(153, 24);
            this.lb_aralık4.TabIndex = 10;
            this.lb_aralık4.Text = "4. zaman aralığı: ";
            // 
            // lb_aralık3
            // 
            this.lb_aralık3.AutoSize = true;
            this.lb_aralık3.Depth = 0;
            this.lb_aralık3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_aralık3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lb_aralık3.Location = new System.Drawing.Point(98, 182);
            this.lb_aralık3.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_aralık3.Name = "lb_aralık3";
            this.lb_aralık3.Size = new System.Drawing.Size(153, 24);
            this.lb_aralık3.TabIndex = 9;
            this.lb_aralık3.Text = "3. zaman aralığı: ";
            // 
            // lb_aralık2
            // 
            this.lb_aralık2.AutoSize = true;
            this.lb_aralık2.Depth = 0;
            this.lb_aralık2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_aralık2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lb_aralık2.Location = new System.Drawing.Point(98, 107);
            this.lb_aralık2.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_aralık2.Name = "lb_aralık2";
            this.lb_aralık2.Size = new System.Drawing.Size(153, 24);
            this.lb_aralık2.TabIndex = 8;
            this.lb_aralık2.Text = "2. zaman aralığı: ";
            // 
            // lb_aralık1
            // 
            this.lb_aralık1.AutoSize = true;
            this.lb_aralık1.Depth = 0;
            this.lb_aralık1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_aralık1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lb_aralık1.Location = new System.Drawing.Point(98, 42);
            this.lb_aralık1.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_aralık1.Name = "lb_aralık1";
            this.lb_aralık1.Size = new System.Drawing.Size(148, 24);
            this.lb_aralık1.TabIndex = 7;
            this.lb_aralık1.Text = "1. zaman aralığı:";
            // 
            // cb_aralık6
            // 
            this.cb_aralık6.AutoResize = false;
            this.cb_aralık6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cb_aralık6.Depth = 0;
            this.cb_aralık6.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_aralık6.DropDownHeight = 174;
            this.cb_aralık6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_aralık6.DropDownWidth = 121;
            this.cb_aralık6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cb_aralık6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb_aralık6.FormattingEnabled = true;
            this.cb_aralık6.IntegralHeight = false;
            this.cb_aralık6.ItemHeight = 43;
            this.cb_aralık6.Items.AddRange(new object[] {
            "3   AY",
            "6   AY",
            "9   AY",
            "12 AY"});
            this.cb_aralık6.Location = new System.Drawing.Point(347, 374);
            this.cb_aralık6.MaxDropDownItems = 4;
            this.cb_aralık6.MouseState = MaterialSkin.MouseState.OUT;
            this.cb_aralık6.Name = "cb_aralık6";
            this.cb_aralık6.Size = new System.Drawing.Size(151, 49);
            this.cb_aralık6.StartIndex = 0;
            this.cb_aralık6.TabIndex = 6;
            // 
            // cb_aralık5
            // 
            this.cb_aralık5.AutoResize = false;
            this.cb_aralık5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cb_aralık5.Depth = 0;
            this.cb_aralık5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_aralık5.DropDownHeight = 174;
            this.cb_aralık5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_aralık5.DropDownWidth = 121;
            this.cb_aralık5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cb_aralık5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb_aralık5.FormattingEnabled = true;
            this.cb_aralık5.IntegralHeight = false;
            this.cb_aralık5.ItemHeight = 43;
            this.cb_aralık5.Items.AddRange(new object[] {
            "1  AY",
            "2  AY",
            "3  AY",
            "4  AY",
            "5  AY",
            "6  AY",
            "7  AY",
            "8  AY",
            "9  AY"});
            this.cb_aralık5.Location = new System.Drawing.Point(347, 306);
            this.cb_aralık5.MaxDropDownItems = 4;
            this.cb_aralık5.MouseState = MaterialSkin.MouseState.OUT;
            this.cb_aralık5.Name = "cb_aralık5";
            this.cb_aralık5.Size = new System.Drawing.Size(151, 49);
            this.cb_aralık5.StartIndex = 0;
            this.cb_aralık5.TabIndex = 5;
            // 
            // cb_aralık4
            // 
            this.cb_aralık4.AutoResize = false;
            this.cb_aralık4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cb_aralık4.Depth = 0;
            this.cb_aralık4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_aralık4.DropDownHeight = 174;
            this.cb_aralık4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_aralık4.DropDownWidth = 121;
            this.cb_aralık4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cb_aralık4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb_aralık4.FormattingEnabled = true;
            this.cb_aralık4.IntegralHeight = false;
            this.cb_aralık4.ItemHeight = 43;
            this.cb_aralık4.Items.AddRange(new object[] {
            "1  AY",
            "2  AY",
            "3  AY",
            "4  AY",
            "5  AY",
            "6  AY"});
            this.cb_aralık4.Location = new System.Drawing.Point(347, 237);
            this.cb_aralık4.MaxDropDownItems = 4;
            this.cb_aralık4.MouseState = MaterialSkin.MouseState.OUT;
            this.cb_aralık4.Name = "cb_aralık4";
            this.cb_aralık4.Size = new System.Drawing.Size(151, 49);
            this.cb_aralık4.StartIndex = 0;
            this.cb_aralık4.TabIndex = 4;
            // 
            // cb_aralık3
            // 
            this.cb_aralık3.AutoResize = false;
            this.cb_aralık3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cb_aralık3.Depth = 0;
            this.cb_aralık3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_aralık3.DropDownHeight = 174;
            this.cb_aralık3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_aralık3.DropDownWidth = 121;
            this.cb_aralık3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cb_aralık3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb_aralık3.FormattingEnabled = true;
            this.cb_aralık3.IntegralHeight = false;
            this.cb_aralık3.ItemHeight = 43;
            this.cb_aralık3.Items.AddRange(new object[] {
            "1 HAFTA",
            "2 HAFTA",
            "3 HAFTA",
            "4 HAFTA",
            "5 HAFTA",
            "6 HAFTA",
            "7 HAFTA",
            "8 HAFTA"});
            this.cb_aralık3.Location = new System.Drawing.Point(347, 166);
            this.cb_aralık3.MaxDropDownItems = 4;
            this.cb_aralık3.MouseState = MaterialSkin.MouseState.OUT;
            this.cb_aralık3.Name = "cb_aralık3";
            this.cb_aralık3.Size = new System.Drawing.Size(151, 49);
            this.cb_aralık3.StartIndex = 0;
            this.cb_aralık3.TabIndex = 3;
            // 
            // cb_aralık2
            // 
            this.cb_aralık2.AutoResize = false;
            this.cb_aralık2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cb_aralık2.Depth = 0;
            this.cb_aralık2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_aralık2.DropDownHeight = 174;
            this.cb_aralık2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_aralık2.DropDownWidth = 121;
            this.cb_aralık2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cb_aralık2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb_aralık2.FormattingEnabled = true;
            this.cb_aralık2.IntegralHeight = false;
            this.cb_aralık2.ItemHeight = 43;
            this.cb_aralık2.Items.AddRange(new object[] {
            "1  GÜN",
            "2  GÜN",
            "3  GÜN",
            "4  GÜN",
            "5  GÜN",
            "6  GÜN",
            "7  GÜN",
            "8  GÜN",
            "9  GÜN",
            "10  GÜN",
            "11  GÜN",
            "12  GÜN",
            "13  GÜN",
            "14  GÜN",
            "15  GÜN"});
            this.cb_aralık2.Location = new System.Drawing.Point(347, 92);
            this.cb_aralık2.MaxDropDownItems = 4;
            this.cb_aralık2.MouseState = MaterialSkin.MouseState.OUT;
            this.cb_aralık2.Name = "cb_aralık2";
            this.cb_aralık2.Size = new System.Drawing.Size(151, 49);
            this.cb_aralık2.StartIndex = 0;
            this.cb_aralık2.TabIndex = 2;
            // 
            // cb_aralık1
            // 
            this.cb_aralık1.AutoResize = false;
            this.cb_aralık1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cb_aralık1.Depth = 0;
            this.cb_aralık1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_aralık1.DropDownHeight = 174;
            this.cb_aralık1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_aralık1.DropDownWidth = 121;
            this.cb_aralık1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cb_aralık1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb_aralık1.FormattingEnabled = true;
            this.cb_aralık1.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.cb_aralık1.IntegralHeight = false;
            this.cb_aralık1.ItemHeight = 43;
            this.cb_aralık1.Items.AddRange(new object[] {
            "1  GÜN",
            "2  GÜN",
            "3  GÜN",
            "4  GÜN",
            "5  GÜN",
            "6  GÜN",
            "7  GÜN"});
            this.cb_aralık1.Location = new System.Drawing.Point(347, 17);
            this.cb_aralık1.MaxDropDownItems = 4;
            this.cb_aralık1.MouseState = MaterialSkin.MouseState.OUT;
            this.cb_aralık1.Name = "cb_aralık1";
            this.cb_aralık1.Size = new System.Drawing.Size(151, 49);
            this.cb_aralık1.StartIndex = 0;
            this.cb_aralık1.TabIndex = 1;
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.materialLabel8);
            this.materialCard4.Depth = 0;
            this.materialCard4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(103, 14);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(688, 30);
            this.materialCard4.TabIndex = 1;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel8.Location = new System.Drawing.Point(129, 6);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(391, 24);
            this.materialLabel8.TabIndex = 0;
            this.materialLabel8.Text = "Lütfen sınavlarınızın zaman sıklığını seçiniz.";
            // 
            // btn_zamanKaydet
            // 
            this.btn_zamanKaydet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_zamanKaydet.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_zamanKaydet.Depth = 0;
            this.btn_zamanKaydet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_zamanKaydet.HighEmphasis = true;
            this.btn_zamanKaydet.Icon = null;
            this.btn_zamanKaydet.Location = new System.Drawing.Point(93, 532);
            this.btn_zamanKaydet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_zamanKaydet.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_zamanKaydet.Name = "btn_zamanKaydet";
            this.btn_zamanKaydet.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_zamanKaydet.Size = new System.Drawing.Size(708, 48);
            this.btn_zamanKaydet.TabIndex = 2;
            this.btn_zamanKaydet.Text = "DEĞİŞİKLİKLERİ KAYDET";
            this.btn_zamanKaydet.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_zamanKaydet.UseAccentColor = false;
            this.btn_zamanKaydet.UseVisualStyleBackColor = true;
            this.btn_zamanKaydet.Click += new System.EventHandler(this.btn_zamanKaydet_Click);
            // 
            // Profil
            // 
            this.Profil.Controls.Add(this.tableLayoutPanel6);
            this.Profil.ImageKey = "usericon.png";
            this.Profil.Location = new System.Drawing.Point(4, 39);
            this.Profil.Name = "Profil";
            this.Profil.Size = new System.Drawing.Size(896, 586);
            this.Profil.TabIndex = 3;
            this.Profil.Text = "Profil";
            this.Profil.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.Controls.Add(this.materialCard5, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.materialCard6, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(896, 586);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.lb_kayıt_tarih);
            this.materialCard5.Controls.Add(this.lb_email);
            this.materialCard5.Controls.Add(this.materialLabel14);
            this.materialCard5.Controls.Add(this.lb_soyad);
            this.materialCard5.Controls.Add(this.lb_ad);
            this.materialCard5.Controls.Add(this.materialLabel13);
            this.materialCard5.Controls.Add(this.materialLabel12);
            this.materialCard5.Controls.Add(this.materialLabel11);
            this.materialCard5.Controls.Add(this.materialLabel10);
            this.materialCard5.Controls.Add(this.materialLabel9);
            this.materialCard5.Depth = 0;
            this.materialCard5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(103, 72);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(688, 440);
            this.materialCard5.TabIndex = 0;
            // 
            // lb_kayıt_tarih
            // 
            this.lb_kayıt_tarih.AutoSize = true;
            this.lb_kayıt_tarih.Depth = 0;
            this.lb_kayıt_tarih.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_kayıt_tarih.Location = new System.Drawing.Point(321, 269);
            this.lb_kayıt_tarih.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_kayıt_tarih.Name = "lb_kayıt_tarih";
            this.lb_kayıt_tarih.Size = new System.Drawing.Size(1, 0);
            this.lb_kayıt_tarih.TabIndex = 9;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Depth = 0;
            this.lb_email.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_email.Location = new System.Drawing.Point(177, 210);
            this.lb_email.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(116, 19);
            this.lb_email.TabIndex = 8;
            this.lb_email.Text = "materialLabel15";
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel14.Location = new System.Drawing.Point(177, 153);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(49, 19);
            this.materialLabel14.TabIndex = 7;
            this.materialLabel14.Text = "8. sınıf";
            // 
            // lb_soyad
            // 
            this.lb_soyad.AutoSize = true;
            this.lb_soyad.Depth = 0;
            this.lb_soyad.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_soyad.Location = new System.Drawing.Point(177, 99);
            this.lb_soyad.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_soyad.Name = "lb_soyad";
            this.lb_soyad.Size = new System.Drawing.Size(116, 19);
            this.lb_soyad.TabIndex = 6;
            this.lb_soyad.Text = "materialLabel14";
            // 
            // lb_ad
            // 
            this.lb_ad.AutoSize = true;
            this.lb_ad.Depth = 0;
            this.lb_ad.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_ad.Location = new System.Drawing.Point(177, 49);
            this.lb_ad.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_ad.Name = "lb_ad";
            this.lb_ad.Size = new System.Drawing.Size(116, 19);
            this.lb_ad.TabIndex = 5;
            this.lb_ad.Text = "materialLabel14";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.Location = new System.Drawing.Point(55, 210);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(55, 19);
            this.materialLabel13.TabIndex = 4;
            this.materialLabel13.Text = "EMAİL: ";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.Location = new System.Drawing.Point(55, 269);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(238, 19);
            this.materialLabel12.TabIndex = 3;
            this.materialLabel12.Text = "SİSTEME KAYIT OLUNAN TARİH: ";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(55, 153);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(47, 19);
            this.materialLabel11.TabIndex = 2;
            this.materialLabel11.Text = "SINIF: ";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(55, 99);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(61, 19);
            this.materialLabel10.TabIndex = 1;
            this.materialLabel10.Text = "SOYAD: ";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(55, 49);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(30, 19);
            this.materialLabel9.TabIndex = 0;
            this.materialLabel9.Text = "AD: ";
            // 
            // materialCard6
            // 
            this.materialCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard6.Controls.Add(this.materialLabel15);
            this.materialCard6.Depth = 0;
            this.materialCard6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard6.Location = new System.Drawing.Point(103, 14);
            this.materialCard6.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard6.Name = "materialCard6";
            this.materialCard6.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard6.Size = new System.Drawing.Size(688, 30);
            this.materialCard6.TabIndex = 1;
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel15.Location = new System.Drawing.Point(250, 11);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(141, 19);
            this.materialLabel15.TabIndex = 0;
            this.materialLabel15.Text = "ÖĞRENCİ BİLGİLERİ";
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
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.materialLabel2);
            this.materialCard2.Controls.Add(this.materialLabel3);
            this.materialCard2.Controls.Add(this.materialLabel4);
            this.materialCard2.Controls.Add(this.materialLabel5);
            this.materialCard2.Controls.Add(this.materialLabel6);
            this.materialCard2.Controls.Add(this.materialLabel7);
            this.materialCard2.Controls.Add(this.materialButton1);
            this.materialCard2.Depth = 0;
            this.materialCard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(34, 14);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(132, 424);
            this.materialCard2.TabIndex = 0;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(256, 236);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(88, 24);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "10 Dakika";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(256, 162);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(42, 24);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "tarih";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.materialLabel4.ForeColor = System.Drawing.Color.Black;
            this.materialLabel4.Location = new System.Drawing.Point(14, 14);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(574, 58);
            this.materialLabel4.TabIndex = 4;
            this.materialLabel4.Text = "Sınav Ekranına Hoşgeldiniz";
            this.materialLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.materialLabel4.UseMnemonic = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(17, 236);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(132, 24);
            this.materialLabel5.TabIndex = 3;
            this.materialLabel5.Text = "Sınav Süreniz: ";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel6.ForeColor = System.Drawing.Color.Black;
            this.materialLabel6.Location = new System.Drawing.Point(14, 162);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(236, 24);
            this.materialLabel6.TabIndex = 2;
            this.materialLabel6.Text = "Sınava Başlama Tarihiniz: ";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(235, 121);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(1, 0);
            this.materialLabel7.TabIndex = 1;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.BackColor = System.Drawing.Color.Transparent;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(14, 374);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(104, 36);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "S ı n a v a   B a ş l a";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // StudentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 696);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "StudentMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentMain";
            this.Load += new System.EventHandler(this.StudentMain_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.Exam.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.Reports.ResumeLayout(false);
            this.Settings.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            this.Profil.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.materialCard5.ResumeLayout(false);
            this.materialCard5.PerformLayout();
            this.materialCard6.ResumeLayout(false);
            this.materialCard6.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage Exam;
        private TabPage Reports;
        private TabPage Settings;
        private TabPage Profil;
        private ImageList imageList1;
        private TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel lb_sınav_bilgi;
        private MaterialSkin.Controls.MaterialButton btn_start_exam;
        private MaterialSkin.Controls.MaterialLabel lb_hosgeldin;
        private MaterialSkin.Controls.MaterialLabel lb_sınav_süre;
        private MaterialSkin.Controls.MaterialLabel lb_sınav_tarih;
        private MaterialSkin.Controls.MaterialLabel lb_sınavSüre;
        private MaterialSkin.Controls.MaterialLabel lb_tarih;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel4;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel lb_aralık6;
        private MaterialSkin.Controls.MaterialLabel lb_aralık5;
        private MaterialSkin.Controls.MaterialLabel lb_aralık4;
        private MaterialSkin.Controls.MaterialLabel lb_aralık3;
        private MaterialSkin.Controls.MaterialLabel lb_aralık2;
        private MaterialSkin.Controls.MaterialLabel lb_aralık1;
        private MaterialSkin.Controls.MaterialComboBox cb_aralık6;
        private MaterialSkin.Controls.MaterialComboBox cb_aralık5;
        private MaterialSkin.Controls.MaterialComboBox cb_aralık4;
        private MaterialSkin.Controls.MaterialComboBox cb_aralık3;
        private MaterialSkin.Controls.MaterialComboBox cb_aralık2;
        private MaterialSkin.Controls.MaterialComboBox cb_aralık1;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private TableLayoutPanel tableLayoutPanel6;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel lb_kayıt_tarih;
        private MaterialSkin.Controls.MaterialLabel lb_email;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel lb_soyad;
        private MaterialSkin.Controls.MaterialLabel lb_ad;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialButton btn_zamanKaydet;
    }
}