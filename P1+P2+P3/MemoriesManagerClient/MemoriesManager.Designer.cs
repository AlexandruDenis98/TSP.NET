namespace MemoriesManagerClient
{
    partial class MemoriesManagerForm
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
            this.dgp_DB = new System.Windows.Forms.DataGridView();
            this.label_PeopleInDB = new System.Windows.Forms.Label();
            this.button_PersonFormOpen = new System.Windows.Forms.Button();
            this.button_DeletePerson = new System.Windows.Forms.Button();
            this.label_KeywordsInDB = new System.Windows.Forms.Label();
            this.dgk_DB = new System.Windows.Forms.DataGridView();
            this.button_KeywordFormOpen = new System.Windows.Forms.Button();
            this.button_DeleteKeyword = new System.Windows.Forms.Button();
            this.listBox_Files = new System.Windows.Forms.ListBox();
            this.button_LoadFiles = new System.Windows.Forms.Button();
            this.pictureBox_Files = new System.Windows.Forms.PictureBox();
            this.label_dbResponse = new System.Windows.Forms.Label();
            this.dateTimePicker_createdAt = new System.Windows.Forms.DateTimePicker();
            this.button_AddFileInDb = new System.Windows.Forms.Button();
            this.textBox_locations = new System.Windows.Forms.TextBox();
            this.button_DeleteFileFromDb = new System.Windows.Forms.Button();
            this.button_kIntoF = new System.Windows.Forms.Button();
            this.button_fIntoP = new System.Windows.Forms.Button();
            this.button_fIntoK = new System.Windows.Forms.Button();
            this.button_pIntoF = new System.Windows.Forms.Button();
            this.dgp_file = new System.Windows.Forms.DataGridView();
            this.dgk_file = new System.Windows.Forms.DataGridView();
            this.label_peopleInFile = new System.Windows.Forms.Label();
            this.label_keywordsInFile = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgp_DB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgk_DB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Files)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgp_file)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgk_file)).BeginInit();
            this.SuspendLayout();
            // 
            // dgp_DB
            // 
            this.dgp_DB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgp_DB.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgp_DB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgp_DB.Location = new System.Drawing.Point(210, 55);
            this.dgp_DB.Name = "dgp_DB";
            this.dgp_DB.RowHeadersWidth = 45;
            this.dgp_DB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgp_DB.Size = new System.Drawing.Size(334, 150);
            this.dgp_DB.TabIndex = 0;
            this.dgp_DB.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgp_CellValueChanged);
            // 
            // label_PeopleInDB
            // 
            this.label_PeopleInDB.AutoSize = true;
            this.label_PeopleInDB.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.label_PeopleInDB.Location = new System.Drawing.Point(347, 37);
            this.label_PeopleInDB.Name = "label_PeopleInDB";
            this.label_PeopleInDB.Size = new System.Drawing.Size(79, 15);
            this.label_PeopleInDB.TabIndex = 1;
            this.label_PeopleInDB.Text = "People in DB";
            // 
            // button_PersonFormOpen
            // 
            this.button_PersonFormOpen.Location = new System.Drawing.Point(62, 99);
            this.button_PersonFormOpen.Name = "button_PersonFormOpen";
            this.button_PersonFormOpen.Size = new System.Drawing.Size(112, 33);
            this.button_PersonFormOpen.TabIndex = 2;
            this.button_PersonFormOpen.Text = "Add new person";
            this.button_PersonFormOpen.UseVisualStyleBackColor = true;
            this.button_PersonFormOpen.Click += new System.EventHandler(this.button_PersonFormOpen_Click);
            // 
            // button_DeletePerson
            // 
            this.button_DeletePerson.Location = new System.Drawing.Point(62, 138);
            this.button_DeletePerson.Name = "button_DeletePerson";
            this.button_DeletePerson.Size = new System.Drawing.Size(112, 31);
            this.button_DeletePerson.TabIndex = 3;
            this.button_DeletePerson.Text = "Delete person";
            this.button_DeletePerson.UseVisualStyleBackColor = true;
            this.button_DeletePerson.Click += new System.EventHandler(this.button_DeletePerson_Click);
            // 
            // label_KeywordsInDB
            // 
            this.label_KeywordsInDB.AutoSize = true;
            this.label_KeywordsInDB.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.label_KeywordsInDB.Location = new System.Drawing.Point(390, 237);
            this.label_KeywordsInDB.Name = "label_KeywordsInDB";
            this.label_KeywordsInDB.Size = new System.Drawing.Size(93, 15);
            this.label_KeywordsInDB.TabIndex = 4;
            this.label_KeywordsInDB.Text = "Keywords in DB";
            // 
            // dgk_DB
            // 
            this.dgk_DB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgk_DB.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgk_DB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgk_DB.Location = new System.Drawing.Point(328, 255);
            this.dgk_DB.Name = "dgk_DB";
            this.dgk_DB.RowHeadersWidth = 45;
            this.dgk_DB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgk_DB.Size = new System.Drawing.Size(216, 150);
            this.dgk_DB.TabIndex = 5;
            this.dgk_DB.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgk_CellValueChanged);
            this.dgk_DB.SelectionChanged += new System.EventHandler(this.dgk_SelectionChanged);
            // 
            // button_KeywordFormOpen
            // 
            this.button_KeywordFormOpen.Location = new System.Drawing.Point(62, 288);
            this.button_KeywordFormOpen.Name = "button_KeywordFormOpen";
            this.button_KeywordFormOpen.Size = new System.Drawing.Size(112, 29);
            this.button_KeywordFormOpen.TabIndex = 6;
            this.button_KeywordFormOpen.Text = "Add new keyword";
            this.button_KeywordFormOpen.UseVisualStyleBackColor = true;
            this.button_KeywordFormOpen.Click += new System.EventHandler(this.button_KeywordFormOpen_Click);
            // 
            // button_DeleteKeyword
            // 
            this.button_DeleteKeyword.Location = new System.Drawing.Point(62, 323);
            this.button_DeleteKeyword.Name = "button_DeleteKeyword";
            this.button_DeleteKeyword.Size = new System.Drawing.Size(112, 29);
            this.button_DeleteKeyword.TabIndex = 7;
            this.button_DeleteKeyword.Text = "Delete keyword";
            this.button_DeleteKeyword.UseVisualStyleBackColor = true;
            this.button_DeleteKeyword.Click += new System.EventHandler(this.button_DeleteKeyword_Click);
            // 
            // listBox_Files
            // 
            this.listBox_Files.FormattingEnabled = true;
            this.listBox_Files.Location = new System.Drawing.Point(180, 443);
            this.listBox_Files.Name = "listBox_Files";
            this.listBox_Files.Size = new System.Drawing.Size(364, 134);
            this.listBox_Files.TabIndex = 8;
            this.listBox_Files.SelectedIndexChanged += new System.EventHandler(this.listBox_files_SelectedIndexChanged);
            // 
            // button_LoadFiles
            // 
            this.button_LoadFiles.BackColor = System.Drawing.SystemColors.Info;
            this.button_LoadFiles.Location = new System.Drawing.Point(264, 593);
            this.button_LoadFiles.Name = "button_LoadFiles";
            this.button_LoadFiles.Size = new System.Drawing.Size(192, 42);
            this.button_LoadFiles.TabIndex = 9;
            this.button_LoadFiles.Text = "Load files in app";
            this.button_LoadFiles.UseVisualStyleBackColor = false;
            this.button_LoadFiles.Click += new System.EventHandler(this.button_LoadFiles_Click);
            // 
            // pictureBox_Files
            // 
            this.pictureBox_Files.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox_Files.Location = new System.Drawing.Point(1202, 55);
            this.pictureBox_Files.Name = "pictureBox_Files";
            this.pictureBox_Files.Size = new System.Drawing.Size(559, 580);
            this.pictureBox_Files.TabIndex = 10;
            this.pictureBox_Files.TabStop = false;
            // 
            // label_dbResponse
            // 
            this.label_dbResponse.AutoSize = true;
            this.label_dbResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dbResponse.Location = new System.Drawing.Point(846, 480);
            this.label_dbResponse.Name = "label_dbResponse";
            this.label_dbResponse.Size = new System.Drawing.Size(0, 25);
            this.label_dbResponse.TabIndex = 11;
            // 
            // dateTimePicker_createdAt
            // 
            this.dateTimePicker_createdAt.Location = new System.Drawing.Point(597, 483);
            this.dateTimePicker_createdAt.Name = "dateTimePicker_createdAt";
            this.dateTimePicker_createdAt.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_createdAt.TabIndex = 12;
            // 
            // button_AddFileInDb
            // 
            this.button_AddFileInDb.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_AddFileInDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddFileInDb.Location = new System.Drawing.Point(851, 526);
            this.button_AddFileInDb.Name = "button_AddFileInDb";
            this.button_AddFileInDb.Size = new System.Drawing.Size(139, 51);
            this.button_AddFileInDb.TabIndex = 14;
            this.button_AddFileInDb.Text = "Add file in DB";
            this.button_AddFileInDb.UseVisualStyleBackColor = false;
            this.button_AddFileInDb.Click += new System.EventHandler(this.button_AddFileInDb_Click);
            // 
            // textBox_locations
            // 
            this.textBox_locations.Location = new System.Drawing.Point(597, 522);
            this.textBox_locations.Name = "textBox_locations";
            this.textBox_locations.Size = new System.Drawing.Size(200, 20);
            this.textBox_locations.TabIndex = 15;
            // 
            // button_DeleteFileFromDb
            // 
            this.button_DeleteFileFromDb.BackColor = System.Drawing.Color.Salmon;
            this.button_DeleteFileFromDb.Location = new System.Drawing.Point(1015, 532);
            this.button_DeleteFileFromDb.Name = "button_DeleteFileFromDb";
            this.button_DeleteFileFromDb.Size = new System.Drawing.Size(99, 42);
            this.button_DeleteFileFromDb.TabIndex = 16;
            this.button_DeleteFileFromDb.Text = "Delete file from DB";
            this.button_DeleteFileFromDb.UseVisualStyleBackColor = false;
            this.button_DeleteFileFromDb.Click += new System.EventHandler(this.button_DeleteFileFromDb_Click);
            // 
            // button_kIntoF
            // 
            this.button_kIntoF.Location = new System.Drawing.Point(689, 288);
            this.button_kIntoF.Name = "button_kIntoF";
            this.button_kIntoF.Size = new System.Drawing.Size(96, 64);
            this.button_kIntoF.TabIndex = 17;
            this.button_kIntoF.Text = ">";
            this.button_kIntoF.UseVisualStyleBackColor = true;
            this.button_kIntoF.Click += new System.EventHandler(this.button_kIntoF_Click);
            // 
            // button_fIntoP
            // 
            this.button_fIntoP.Location = new System.Drawing.Point(587, 99);
            this.button_fIntoP.Name = "button_fIntoP";
            this.button_fIntoP.Size = new System.Drawing.Size(96, 70);
            this.button_fIntoP.TabIndex = 18;
            this.button_fIntoP.Text = "<";
            this.button_fIntoP.UseVisualStyleBackColor = true;
            this.button_fIntoP.Click += new System.EventHandler(this.button_fIntoP_Click);
            // 
            // button_fIntoK
            // 
            this.button_fIntoK.Location = new System.Drawing.Point(587, 288);
            this.button_fIntoK.Name = "button_fIntoK";
            this.button_fIntoK.Size = new System.Drawing.Size(96, 64);
            this.button_fIntoK.TabIndex = 19;
            this.button_fIntoK.Text = "<";
            this.button_fIntoK.UseVisualStyleBackColor = true;
            this.button_fIntoK.Click += new System.EventHandler(this.button_fIntoK_Click);
            // 
            // button_pIntoF
            // 
            this.button_pIntoF.Location = new System.Drawing.Point(689, 99);
            this.button_pIntoF.Name = "button_pIntoF";
            this.button_pIntoF.Size = new System.Drawing.Size(96, 70);
            this.button_pIntoF.TabIndex = 20;
            this.button_pIntoF.Text = ">";
            this.button_pIntoF.UseVisualStyleBackColor = true;
            this.button_pIntoF.Click += new System.EventHandler(this.button_pIntoF_Click);
            // 
            // dgp_file
            // 
            this.dgp_file.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgp_file.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgp_file.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgp_file.Location = new System.Drawing.Point(811, 55);
            this.dgp_file.Name = "dgp_file";
            this.dgp_file.RowHeadersWidth = 45;
            this.dgp_file.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgp_file.Size = new System.Drawing.Size(331, 150);
            this.dgp_file.TabIndex = 21;
            // 
            // dgk_file
            // 
            this.dgk_file.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgk_file.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgk_file.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgk_file.Location = new System.Drawing.Point(811, 268);
            this.dgk_file.Name = "dgk_file";
            this.dgk_file.RowHeadersWidth = 45;
            this.dgk_file.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgk_file.Size = new System.Drawing.Size(214, 150);
            this.dgk_file.TabIndex = 22;
            // 
            // label_peopleInFile
            // 
            this.label_peopleInFile.AutoSize = true;
            this.label_peopleInFile.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.label_peopleInFile.Location = new System.Drawing.Point(943, 37);
            this.label_peopleInFile.Name = "label_peopleInFile";
            this.label_peopleInFile.Size = new System.Drawing.Size(82, 15);
            this.label_peopleInFile.TabIndex = 23;
            this.label_peopleInFile.Text = "People in File";
            // 
            // label_keywordsInFile
            // 
            this.label_keywordsInFile.AutoSize = true;
            this.label_keywordsInFile.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.label_keywordsInFile.Location = new System.Drawing.Point(869, 250);
            this.label_keywordsInFile.Name = "label_keywordsInFile";
            this.label_keywordsInFile.Size = new System.Drawing.Size(96, 15);
            this.label_keywordsInFile.TabIndex = 24;
            this.label_keywordsInFile.Text = "Keywords in File";
            // 
            // MemoriesManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1814, 693);
            this.Controls.Add(this.label_keywordsInFile);
            this.Controls.Add(this.label_peopleInFile);
            this.Controls.Add(this.dgk_file);
            this.Controls.Add(this.dgp_file);
            this.Controls.Add(this.button_pIntoF);
            this.Controls.Add(this.button_fIntoK);
            this.Controls.Add(this.button_fIntoP);
            this.Controls.Add(this.button_kIntoF);
            this.Controls.Add(this.button_DeleteFileFromDb);
            this.Controls.Add(this.textBox_locations);
            this.Controls.Add(this.button_AddFileInDb);
            this.Controls.Add(this.dateTimePicker_createdAt);
            this.Controls.Add(this.label_dbResponse);
            this.Controls.Add(this.pictureBox_Files);
            this.Controls.Add(this.button_LoadFiles);
            this.Controls.Add(this.listBox_Files);
            this.Controls.Add(this.button_DeleteKeyword);
            this.Controls.Add(this.button_KeywordFormOpen);
            this.Controls.Add(this.dgk_DB);
            this.Controls.Add(this.label_KeywordsInDB);
            this.Controls.Add(this.button_DeletePerson);
            this.Controls.Add(this.button_PersonFormOpen);
            this.Controls.Add(this.label_PeopleInDB);
            this.Controls.Add(this.dgp_DB);
            this.Name = "MemoriesManagerForm";
            this.Text = "MemoriesManager";
            this.Load += new System.EventHandler(this.MemoriesManagerForm_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MemoriesManagerForm_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dgp_DB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgk_DB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Files)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgp_file)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgk_file)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgp_DB;
        private System.Windows.Forms.Label label_PeopleInDB;
        private System.Windows.Forms.Button button_PersonFormOpen;
        private System.Windows.Forms.Button button_DeletePerson;
        private System.Windows.Forms.Label label_KeywordsInDB;
        private System.Windows.Forms.DataGridView dgk_DB;
        private System.Windows.Forms.Button button_KeywordFormOpen;
        private System.Windows.Forms.Button button_DeleteKeyword;
        private System.Windows.Forms.ListBox listBox_Files;
        private System.Windows.Forms.Button button_LoadFiles;
        private System.Windows.Forms.PictureBox pictureBox_Files;
        private System.Windows.Forms.Label label_dbResponse;
        private System.Windows.Forms.DateTimePicker dateTimePicker_createdAt;
        private System.Windows.Forms.Button button_AddFileInDb;
        private System.Windows.Forms.TextBox textBox_locations;
        private System.Windows.Forms.Button button_DeleteFileFromDb;
        private System.Windows.Forms.Button button_kIntoF;
        private System.Windows.Forms.Button button_fIntoP;
        private System.Windows.Forms.Button button_fIntoK;
        private System.Windows.Forms.Button button_pIntoF;
        private System.Windows.Forms.DataGridView dgp_file;
        private System.Windows.Forms.DataGridView dgk_file;
        private System.Windows.Forms.Label label_peopleInFile;
        private System.Windows.Forms.Label label_keywordsInFile;
    }
}

