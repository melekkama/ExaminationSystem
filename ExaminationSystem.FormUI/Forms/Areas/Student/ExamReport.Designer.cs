namespace ExaminationSystem.FormUI.Forms.Areas.Student
{
    partial class ExamReport
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lb_result = new MaterialSkin.Controls.MaterialLabel();
            this.btn_redirect = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.Location = new System.Drawing.Point(19, 81);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(611, 41);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Doğru Cevap Sayısı / Toplam Soru Sayısı";
            // 
            // lb_result
            // 
            this.lb_result.AutoSize = true;
            this.lb_result.Depth = 0;
            this.lb_result.Font = new System.Drawing.Font("Roboto Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_result.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            this.lb_result.Location = new System.Drawing.Point(257, 139);
            this.lb_result.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(154, 72);
            this.lb_result.TabIndex = 1;
            this.lb_result.Text = "6 / 10";
            // 
            // btn_redirect
            // 
            this.btn_redirect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_redirect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_redirect.Depth = 0;
            this.btn_redirect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_redirect.HighEmphasis = true;
            this.btn_redirect.Icon = null;
            this.btn_redirect.Location = new System.Drawing.Point(3, 260);
            this.btn_redirect.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_redirect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_redirect.Name = "btn_redirect";
            this.btn_redirect.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_redirect.Size = new System.Drawing.Size(653, 36);
            this.btn_redirect.TabIndex = 2;
            this.btn_redirect.Text = "Öğrenci paneline git";
            this.btn_redirect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_redirect.UseAccentColor = false;
            this.btn_redirect.UseVisualStyleBackColor = true;
            this.btn_redirect.Click += new System.EventHandler(this.btn_redirect_Click);
            // 
            // ExamReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 299);
            this.Controls.Add(this.btn_redirect);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.materialLabel1);
            this.Name = "ExamReport";
            this.Text = "ExamReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lb_result;
        private MaterialSkin.Controls.MaterialButton btn_redirect;
    }
}