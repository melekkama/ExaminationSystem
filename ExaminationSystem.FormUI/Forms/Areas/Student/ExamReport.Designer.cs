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
            // ExamReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 261);
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
    }
}