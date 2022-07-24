namespace DoDoLis
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SortButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.DeleteAllbutton = new System.Windows.Forms.Button();
            this.TasksListBox = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(24, 183);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(75, 23);
            this.SortButton.TabIndex = 2;
            this.SortButton.Text = "Sort A-Z";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(24, 96);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(117, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "ToDo List";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(24, 125);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DeleteAllbutton
            // 
            this.DeleteAllbutton.Location = new System.Drawing.Point(24, 154);
            this.DeleteAllbutton.Name = "DeleteAllbutton";
            this.DeleteAllbutton.Size = new System.Drawing.Size(75, 23);
            this.DeleteAllbutton.TabIndex = 6;
            this.DeleteAllbutton.Text = "Delete All";
            this.DeleteAllbutton.UseVisualStyleBackColor = true;
            this.DeleteAllbutton.Click += new System.EventHandler(this.DeleteAllbutton_Click);
            // 
            // TasksListBox
            // 
            this.TasksListBox.FormattingEnabled = true;
            this.TasksListBox.Location = new System.Drawing.Point(117, 67);
            this.TasksListBox.Name = "TasksListBox";
            this.TasksListBox.Size = new System.Drawing.Size(331, 274);
            this.TasksListBox.TabIndex = 0;
            this.TasksListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.TasksListBox_ItemCheck);
            this.TasksListBox.Click += new System.EventHandler(this.TasksListBox_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Sort Z-A";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeleteAllbutton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TasksListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBox1;
        private Button SortButton;
        private Button AddButton;
        private Label label1;
        private Button DeleteButton;
        private Button DeleteAllbutton;
        private CheckedListBox TasksListBox;
        private Button button1;
    }
}