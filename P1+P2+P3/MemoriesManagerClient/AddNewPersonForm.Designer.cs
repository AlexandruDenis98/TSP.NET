namespace MemoriesManagerClient
{
    partial class AddNewPersonForm
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
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.button_AddNewPerson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(154, 60);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(160, 20);
            this.textBox_FirstName.TabIndex = 0;
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Location = new System.Drawing.Point(193, 42);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(67, 15);
            this.label_FirstName.TabIndex = 1;
            this.label_FirstName.Text = "First Name";
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Location = new System.Drawing.Point(193, 110);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(67, 15);
            this.label_LastName.TabIndex = 3;
            this.label_LastName.Text = "Last Name";
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(154, 128);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(160, 20);
            this.textBox_LastName.TabIndex = 2;
            // 
            // button_AddNewPerson
            // 
            this.button_AddNewPerson.Location = new System.Drawing.Point(183, 167);
            this.button_AddNewPerson.Name = "button_AddNewPerson";
            this.button_AddNewPerson.Size = new System.Drawing.Size(88, 33);
            this.button_AddNewPerson.TabIndex = 4;
            this.button_AddNewPerson.Text = "Add";
            this.button_AddNewPerson.UseVisualStyleBackColor = true;
            this.button_AddNewPerson.Click += new System.EventHandler(this.button_AddNewPerson_Click);
            // 
            // AddNewPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 304);
            this.Controls.Add(this.button_AddNewPerson);
            this.Controls.Add(this.label_LastName);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.label_FirstName);
            this.Controls.Add(this.textBox_FirstName);
            this.Name = "AddNewPersonForm";
            this.Text = "AddNewPersonForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.Button button_AddNewPerson;
    }
}