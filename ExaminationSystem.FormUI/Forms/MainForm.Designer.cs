namespace ExaminationSystem.FormUI.Forms
{
    partial class MainForm
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
            this.lb_userStatus = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // lb_userStatus
            // 
            this.lb_userStatus.AutoSize = true;
            this.lb_userStatus.Depth = 0;
            this.lb_userStatus.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_userStatus.Location = new System.Drawing.Point(16, 84);
            this.lb_userStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_userStatus.Name = "lb_userStatus";
            this.lb_userStatus.Size = new System.Drawing.Size(43, 19);
            this.lb_userStatus.TabIndex = 0;
            this.lb_userStatus.Text = "Melek";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 603);
            this.Controls.Add(this.lb_userStatus);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lb_userStatus;
    }
}