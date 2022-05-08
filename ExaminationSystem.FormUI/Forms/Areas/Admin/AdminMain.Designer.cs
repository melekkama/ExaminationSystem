namespace ExaminationSystem.FormUI.Forms.Areas.Admin
{
    partial class AdminMain
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChooseA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChooseB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChooseC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChooseD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Topic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_savechanges = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Content,
            this.ChooseA,
            this.ChooseB,
            this.ChooseC,
            this.ChooseD,
            this.Topic,
            this.IsActive});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1083, 478);
            this.dataGridView1.TabIndex = 0;
            // 
            // Content
            // 
            this.Content.DataPropertyName = "Content";
            this.Content.HeaderText = "Content";
            this.Content.MinimumWidth = 6;
            this.Content.Name = "Content";
            this.Content.Width = 125;
            // 
            // ChooseA
            // 
            this.ChooseA.DataPropertyName = "ChooseA";
            this.ChooseA.HeaderText = "A";
            this.ChooseA.MinimumWidth = 6;
            this.ChooseA.Name = "ChooseA";
            this.ChooseA.Width = 125;
            // 
            // ChooseB
            // 
            this.ChooseB.DataPropertyName = "ChooseB";
            this.ChooseB.HeaderText = "B";
            this.ChooseB.MinimumWidth = 6;
            this.ChooseB.Name = "ChooseB";
            this.ChooseB.Width = 125;
            // 
            // ChooseC
            // 
            this.ChooseC.DataPropertyName = "ChooseC";
            this.ChooseC.HeaderText = "C";
            this.ChooseC.MinimumWidth = 6;
            this.ChooseC.Name = "ChooseC";
            this.ChooseC.Width = 125;
            // 
            // ChooseD
            // 
            this.ChooseD.DataPropertyName = "ChooseD";
            this.ChooseD.HeaderText = "D";
            this.ChooseD.MinimumWidth = 6;
            this.ChooseD.Name = "ChooseD";
            this.ChooseD.Width = 125;
            // 
            // Topic
            // 
            this.Topic.DataPropertyName = "Topic";
            this.Topic.HeaderText = "Topic";
            this.Topic.MinimumWidth = 6;
            this.Topic.Name = "Topic";
            this.Topic.Width = 125;
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.HeaderText = "IsActive";
            this.IsActive.MinimumWidth = 6;
            this.IsActive.Name = "IsActive";
            this.IsActive.Width = 125;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_savechanges, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1089, 538);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btn_savechanges
            // 
            this.btn_savechanges.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_savechanges.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_savechanges.Depth = 0;
            this.btn_savechanges.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_savechanges.HighEmphasis = true;
            this.btn_savechanges.Icon = null;
            this.btn_savechanges.Location = new System.Drawing.Point(4, 496);
            this.btn_savechanges.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_savechanges.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_savechanges.Name = "btn_savechanges";
            this.btn_savechanges.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_savechanges.Size = new System.Drawing.Size(1081, 36);
            this.btn_savechanges.TabIndex = 1;
            this.btn_savechanges.Text = "DEĞİŞİKLİKLERİ KAYDET";
            this.btn_savechanges.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_savechanges.UseAccentColor = false;
            this.btn_savechanges.UseVisualStyleBackColor = true;
            this.btn_savechanges.Click += new System.EventHandler(this.btn_savechanges_Click);
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 605);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AdminMain";
            this.Text = "AdminMain";
            this.Load += new System.EventHandler(this.AdminMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Content;
        private DataGridViewTextBoxColumn ChooseA;
        private DataGridViewTextBoxColumn ChooseB;
        private DataGridViewTextBoxColumn ChooseC;
        private DataGridViewTextBoxColumn ChooseD;
        private DataGridViewTextBoxColumn Topic;
        private DataGridViewCheckBoxColumn IsActive;
        private TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton btn_savechanges;
    }
}