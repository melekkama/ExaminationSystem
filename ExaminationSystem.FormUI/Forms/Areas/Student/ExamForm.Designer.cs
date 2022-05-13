namespace ExaminationSystem.FormUI.Forms.Areas.Student
{
    partial class ExamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lb_timer = new MaterialSkin.Controls.MaterialLabel();
            this.lb_count = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rb_d = new System.Windows.Forms.RadioButton();
            this.rb_c = new System.Windows.Forms.RadioButton();
            this.rb_a = new System.Windows.Forms.RadioButton();
            this.lb_soru = new MaterialSkin.Controls.MaterialLabel();
            this.pb_soru = new System.Windows.Forms.PictureBox();
            this.rb_b = new System.Windows.Forms.RadioButton();
            this.btn_next = new MaterialSkin.Controls.MaterialButton();
            this.exam_timer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_soru)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.materialCard1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.materialCard2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_next, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1036, 662);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lb_timer);
            this.materialCard1.Controls.Add(this.lb_count);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(117, 14);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(800, 38);
            this.materialCard1.TabIndex = 0;
            // 
            // lb_timer
            // 
            this.lb_timer.AutoSize = true;
            this.lb_timer.Depth = 0;
            this.lb_timer.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_timer.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_timer.Location = new System.Drawing.Point(14, 14);
            this.lb_timer.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_timer.Name = "lb_timer";
            this.lb_timer.Size = new System.Drawing.Size(107, 19);
            this.lb_timer.TabIndex = 1;
            this.lb_timer.Text = "materialLabel1";
            // 
            // lb_count
            // 
            this.lb_count.AutoSize = true;
            this.lb_count.Depth = 0;
            this.lb_count.Dock = System.Windows.Forms.DockStyle.Right;
            this.lb_count.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_count.Location = new System.Drawing.Point(679, 14);
            this.lb_count.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_count.Name = "lb_count";
            this.lb_count.Size = new System.Drawing.Size(107, 19);
            this.lb_count.TabIndex = 0;
            this.lb_count.Text = "materialLabel1";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.tableLayoutPanel2);
            this.materialCard2.Depth = 0;
            this.materialCard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(117, 80);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(800, 501);
            this.materialCard2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.rb_d, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.rb_c, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.rb_a, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lb_soru, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pb_soru, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.rb_b, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(14, 14);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(772, 473);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // rb_d
            // 
            this.rb_d.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rb_d.Location = new System.Drawing.Point(389, 357);
            this.rb_d.Name = "rb_d";
            this.rb_d.Size = new System.Drawing.Size(380, 113);
            this.rb_d.TabIndex = 9;
            this.rb_d.TabStop = true;
            this.rb_d.Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem " +
    "Ipsum has been the industry\'s standard dummy text ever since the 1500s";
            this.rb_d.UseVisualStyleBackColor = true;
            // 
            // rb_c
            // 
            this.rb_c.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rb_c.Location = new System.Drawing.Point(3, 357);
            this.rb_c.Name = "rb_c";
            this.rb_c.Size = new System.Drawing.Size(380, 113);
            this.rb_c.TabIndex = 8;
            this.rb_c.TabStop = true;
            this.rb_c.Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem " +
    "Ipsum has been the industry\'s standard dummy text ever since the 1500s";
            this.rb_c.UseVisualStyleBackColor = true;
            // 
            // rb_a
            // 
            this.rb_a.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rb_a.Location = new System.Drawing.Point(3, 239);
            this.rb_a.Name = "rb_a";
            this.rb_a.Size = new System.Drawing.Size(380, 112);
            this.rb_a.TabIndex = 7;
            this.rb_a.TabStop = true;
            this.rb_a.Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem " +
    "Ipsum has been the industry\'s standard dummy text ever since the 1500s";
            this.rb_a.UseVisualStyleBackColor = true;
            // 
            // lb_soru
            // 
            this.lb_soru.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.lb_soru, 2);
            this.lb_soru.Depth = 0;
            this.lb_soru.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_soru.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_soru.Location = new System.Drawing.Point(3, 118);
            this.lb_soru.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_soru.Name = "lb_soru";
            this.lb_soru.Size = new System.Drawing.Size(766, 118);
            this.lb_soru.TabIndex = 0;
            this.lb_soru.Text = resources.GetString("lb_soru.Text");
            // 
            // pb_soru
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.pb_soru, 2);
            this.pb_soru.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_soru.Location = new System.Drawing.Point(3, 3);
            this.pb_soru.Name = "pb_soru";
            this.pb_soru.Size = new System.Drawing.Size(766, 112);
            this.pb_soru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_soru.TabIndex = 1;
            this.pb_soru.TabStop = false;
            // 
            // rb_b
            // 
            this.rb_b.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rb_b.Location = new System.Drawing.Point(389, 239);
            this.rb_b.Name = "rb_b";
            this.rb_b.Size = new System.Drawing.Size(380, 112);
            this.rb_b.TabIndex = 6;
            this.rb_b.TabStop = true;
            this.rb_b.Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem " +
    "Ipsum has been the industry\'s standard dummy text ever since the 1500s";
            this.rb_b.UseVisualStyleBackColor = true;
            // 
            // btn_next
            // 
            this.btn_next.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_next.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_next.Depth = 0;
            this.btn_next.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_next.HighEmphasis = true;
            this.btn_next.Icon = null;
            this.btn_next.Location = new System.Drawing.Point(107, 601);
            this.btn_next.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_next.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_next.Name = "btn_next";
            this.btn_next.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_next.Size = new System.Drawing.Size(820, 55);
            this.btn_next.TabIndex = 2;
            this.btn_next.Text = "NEXT";
            this.btn_next.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_next.UseAccentColor = false;
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // exam_timer
            // 
            this.exam_timer.Enabled = true;
            this.exam_timer.Interval = 1000;
            this.exam_timer.Tick += new System.EventHandler(this.exam_timer_Tick);
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 729);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ExamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExamForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_soru)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialLabel lb_soru;
        private PictureBox pb_soru;
        private RadioButton rb_b;
        private RadioButton rb_d;
        private RadioButton rb_c;
        private RadioButton rb_a;
        private MaterialSkin.Controls.MaterialButton btn_next;
        private MaterialSkin.Controls.MaterialLabel lb_count;
        private System.Windows.Forms.Timer exam_timer;
        private MaterialSkin.Controls.MaterialLabel lb_timer;
    }
}