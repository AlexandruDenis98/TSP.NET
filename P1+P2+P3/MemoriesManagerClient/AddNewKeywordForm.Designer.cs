namespace MemoriesManagerClient
{
    partial class AddNewKeywordForm
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
            this.label_Kword = new System.Windows.Forms.Label();
            this.textBox_Kword = new System.Windows.Forms.TextBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Kword
            // 
            this.label_Kword.AutoSize = true;
            this.label_Kword.Location = new System.Drawing.Point(161, 53);
            this.label_Kword.Name = "label_Kword";
            this.label_Kword.Size = new System.Drawing.Size(45, 15);
            this.label_Kword.TabIndex = 0;
            this.label_Kword.Text = "Kword:";
            // 
            // textBox_Kword
            // 
            this.textBox_Kword.Location = new System.Drawing.Point(117, 71);
            this.textBox_Kword.Name = "textBox_Kword";
            this.textBox_Kword.Size = new System.Drawing.Size(138, 20);
            this.textBox_Kword.TabIndex = 1;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(144, 124);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(87, 35);
            this.button_Add.TabIndex = 2;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // AddNewKeywordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 236);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.textBox_Kword);
            this.Controls.Add(this.label_Kword);
            this.Name = "AddNewKeywordForm";
            this.Text = "AddNewKeywordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Kword;
        private System.Windows.Forms.TextBox textBox_Kword;
        private System.Windows.Forms.Button button_Add;
    }
}