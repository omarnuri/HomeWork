namespace Cinema
{
    partial class Form1
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
            this.MenuText = new System.Windows.Forms.Label();
            this.FilmList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // MenuText
            // 
            this.MenuText.AutoSize = true;
            this.MenuText.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MenuText.Location = new System.Drawing.Point(188, 140);
            this.MenuText.Name = "MenuText";
            this.MenuText.Size = new System.Drawing.Size(431, 37);
            this.MenuText.TabIndex = 0;
            this.MenuText.Text = "Какой фильм вы хотите выбрать?";
            // 
            // FilmList
            // 
            this.FilmList.FormattingEnabled = true;
            this.FilmList.Items.AddRange(new object[] {
            "Мстители",
            "Малифисента",
            "Точка кипения"});
            this.FilmList.Location = new System.Drawing.Point(277, 180);
            this.FilmList.Name = "FilmList";
            this.FilmList.Size = new System.Drawing.Size(226, 23);
            this.FilmList.TabIndex = 1;
            this.FilmList.SelectedIndexChanged += new System.EventHandler(this.FilmList_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FilmList);
            this.Controls.Add(this.MenuText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label MenuText;
        private ComboBox FilmList;
    }
}