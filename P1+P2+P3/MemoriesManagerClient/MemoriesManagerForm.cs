using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MemoriesManager;
using System.IO;
using System.Data.Entity.Spatial;
using System.Data.Entity.Migrations;

namespace MemoriesManagerClient
{
    public partial class MemoriesManagerForm : Form
    {
        
        public MemoriesManagerForm()
        {
            InitializeComponent();
            pictureBox_Files.SizeMode = PictureBoxSizeMode.StretchImage;
            button_AddFileInDb.Enabled = false; //Dezactivam butonul de adaugare fisier in DB
            button_DeleteFileFromDb.Enabled = false; //Dezactivam butonul de stergere fisier in DB
            dgk_DB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgp_DB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgk_file.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgp_file.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            //disable buttons < > 
            button_fIntoK.Enabled = false;
            button_kIntoF.Enabled = false;
            button_fIntoP.Enabled = false;
            button_pIntoF.Enabled = false;
        }

        private void MemoriesManagerForm_Load(object sender, EventArgs e)
        {
            RefreshDgp_DB();
            dgp_DB.ClearSelection();
            RefreshDgk_DB();
            dgk_DB.ClearSelection();
        }

        public void RefreshDgp_DB()
        {
            FilePersonKeywordClient client = new FilePersonKeywordClient();
            List<MemoriesManager.Person> myList;
            myList = client.GetAllPeople().ToList();
            this.dgp_DB.DataSource = myList;
            client.Close();
        }
        public void RefreshDgk_DB()
        {
            FilePersonKeywordClient client = new FilePersonKeywordClient();
            List<MemoriesManager.Keyword> myList;
            myList = client.GetAllKeywords().ToList();
            this.dgk_DB.DataSource = myList;
            client.Close();
        }
        private void RefreshDgp_file()
        {
            FilePersonKeywordClient client = new FilePersonKeywordClient();
            if (listBox_Files.SelectedIndex >= 0)
                if (client.GetFileByPath(listBox_Files.SelectedItem.ToString()) != null)
                {
                    dgp_file.ClearSelection();
                    dgp_file.DataSource = client.GetPeopleFile(listBox_Files.SelectedItem.ToString());
                    client.Close();
                }
        }
        // Check keywords of the current file and display them in data grid view
        public void RefreshDgk_file()
        {
            FilePersonKeywordClient client = new FilePersonKeywordClient();
            if(listBox_Files.SelectedIndex >= 0)
                if(client.GetFileByPath(listBox_Files.SelectedItem.ToString()) != null)
                {
                    dgk_file.ClearSelection();
                    dgk_file.DataSource = client.GetKeywordsOfFile(listBox_Files.SelectedItem.ToString());
                    client.Close();
                }
        }
        private void button_DeletePerson_Click(object sender, EventArgs e)
        {
            if (dgp_DB.SelectedRows.Count != 0)
            {
                for(int i =0; i< dgp_DB.Rows.Count; i++)
                {
                    if(dgp_DB.Rows[i].Selected == true)
                    {
                        FilePersonKeywordClient client = new FilePersonKeywordClient();
                        client.DeletePerson(Convert.ToInt32(dgp_DB[0, i].Value));
                        client.Close();
                        Console.WriteLine(Convert.ToInt32(dgp_DB[0, i].Value));
                    }
                }
                RefreshDgp_DB();
                RefreshDgp_file();
            }
        }
        private void dgp_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            FilePersonKeywordClient client = new FilePersonKeywordClient();
            Console.WriteLine(e.RowIndex + " " + e.ColumnIndex);
            MemoriesManager.Person person;
            Console.WriteLine(dgp_DB[0, e.RowIndex] + " " + dgp_DB[1, e.RowIndex].ToString() + " " + dgp_DB[2, e.RowIndex].ToString());
            person = client.UpdatePersonNameById(Convert.ToInt32(dgp_DB[2, e.RowIndex].Value), dgp_DB[1, e.RowIndex].Value.ToString(), dgp_DB[3, e.RowIndex].Value.ToString());
            client.Close(); 
        }
        private void button_PersonFormOpen_Click(object sender, EventArgs e)
        {
            AddNewPersonForm addNewPersonForm = new AddNewPersonForm(this);
            addNewPersonForm.Show();
        }
        private void button_KeywordFormOpen_Click(object sender, EventArgs e)
        {
            AddNewKeywordForm addNewKeywordForm = new AddNewKeywordForm(this);
            addNewKeywordForm.Show();
        }
        private void button_DeleteKeyword_Click(object sender, EventArgs e)
        {
            if (dgk_DB.SelectedRows.Count != 0)
            {
                for (int i = 0; i < dgk_DB.Rows.Count; i++)
                {
                    if (dgk_DB.Rows[i].Selected == true)
                    {
                        Console.WriteLine(Convert.ToInt32(dgk_DB[0, i].Value));
                        FilePersonKeywordClient client = new FilePersonKeywordClient();
                        client.DeleteKeyword(Convert.ToInt32(dgk_DB[0, i].Value));
                        client.Close();
                    }
                }
                RefreshDgk_DB();
                RefreshDgk_file();
            }
        }
        private void dgk_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            FilePersonKeywordClient client = new FilePersonKeywordClient();
            MemoriesManager.Keyword keyword = new MemoriesManager.Keyword();
            // Updating keyword in data grid view
            Console.WriteLine(((dgk_DB[0, e.RowIndex].Value)));
            keyword = client.UpdateKeywordKwordById(Convert.ToInt32(dgk_DB[0, e.RowIndex].Value), dgk_DB[1, e.RowIndex].Value.ToString());
            RefreshDgk_file();
            client.Close();
        }
        private void button_LoadFiles_Click(object sender, EventArgs e)
        {
            ShowFilesInListbox(this.listBox_Files, myOwnGetFilesFromFolder("*.PNG|*.jpg"));
        }
        public List<string> myOwnGetFilesFromFolder(string searchPattern) // with multiple extensions
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            List<string> filesNamesList = new List<string>();

            string[] extensions = searchPattern.Split('|');
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < extensions.Length; i++)
                {
                    string[] arrayOfFilesNames = Directory.GetFiles(FBD.SelectedPath, extensions[i]);
                    filesNamesList.AddRange(arrayOfFilesNames);
                }
            }
            return filesNamesList;
        }
        public void ShowFilesInListbox(ListBox listBox, List<string> filesNamesList)
        {
            listBox.Items.Clear();
            foreach (string fileName in filesNamesList)
            {
                listBox.Items.Add(fileName);
            }
        }
        public void ChangeImageInPictureBox(PictureBox pictureBox, string fileName)
        {
            pictureBox.ImageLocation = fileName;
        }
        private void listBox_files_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilePersonKeywordClient client = new FilePersonKeywordClient();
            MemoriesManager.File fileSelected = new MemoriesManager.File();
                
            if(listBox_Files.SelectedIndex >= 0)
            {

                ChangeImageInPictureBox(pictureBox_Files, listBox_Files.SelectedItem.ToString());
                if ((fileSelected = client.GetFileByPath(listBox_Files.SelectedItem.ToString())) != null)
                {
                    label_dbResponse.Text = "The file is registered in DB    >";
                    label_dbResponse.ForeColor = Color.Green;
                    textBox_locations.Text = fileSelected.Location;
                    dateTimePicker_createdAt.Value = fileSelected.Created_at;
                    button_AddFileInDb.Enabled = false; //Dezactivam butonul de adaugare fisier in DB
                    button_DeleteFileFromDb.Enabled = true; //Activam butonul de stergere fisier din DB
                    RefreshDgk_file();
                    RefreshDgp_file();
                    dgp_file.ClearSelection();
                    dgk_file.ClearSelection();
                    enableArrowButtons();
                }
                else
                {
                    label_dbResponse.Text = "The file is unregistered in DB    >";
                    label_dbResponse.ForeColor = Color.Red;
                    textBox_locations.Text = "";
                    dateTimePicker_createdAt.Value = DateTime.Now;
                    button_AddFileInDb.Enabled = true; //Activam butonul de adaugare fisier in DB
                    button_DeleteFileFromDb.Enabled = false; //Dezactivam butonul de stergere fisier din DB
                    dgk_DB.ClearSelection();
                    dgp_DB.ClearSelection();
                    //RefreshDgk_file();
                    dgk_file.DataSource = "";
                    //RefreshDgp_file();
                    dgp_file.DataSource = "";
                    disableArrowButtons();
                }
                client.Close();
            }
        }
        private void button_AddFileInDb_Click(object sender, EventArgs e)
        {   
            FilePersonKeywordClient client = new FilePersonKeywordClient();
            MemoriesManager.File file = new MemoriesManager.File
            {
                Path = listBox_Files.SelectedItem.ToString(),
                Created_at = dateTimePicker_createdAt.Value.Date,
                Type = "Image",
                Path_changed = false,
                Location = textBox_locations.Text
            };           
            client.CreateFile(file);
            enableArrowButtons();
            button_AddFileInDb.Enabled = false; //Dezactivam butonul de adaugare fisier in DB
            label_dbResponse.Text = "The file is registered in DB";
            label_dbResponse.ForeColor = Color.Green;
            button_DeleteFileFromDb.Enabled = true; //Activam butonul de stergere fisier din DB
            AddingKeywordsToFile(dgk_DB);
            AddingPersonsToFile(dgp_DB);
            RefreshDgk_file();
            RefreshDgp_file();
            client.Close();
        }

        private void button_DeleteFileFromDb_Click(object sender,EventArgs e)
        {
            FilePersonKeywordClient client = new FilePersonKeywordClient();
            client.DeleteFileByPath(listBox_Files.SelectedItem.ToString());
            label_dbResponse.Text = "The file is unregistered in DB";
            label_dbResponse.ForeColor = Color.Red;
            textBox_locations.Text = "";
            dateTimePicker_createdAt.Value = DateTime.Now;
            button_AddFileInDb.Enabled = true; //Activam butonul de adaugare fisier in DB
            button_DeleteFileFromDb.Enabled = false; //Dezactivam butonul de stergere fisier din DB
            disableArrowButtons();
            client.Close();
            dgk_DB.ClearSelection();
            dgk_file.DataSource = "";
            dgp_DB.ClearSelection();
            dgp_file.DataSource = "";
        }

        private void MemoriesManagerForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            dgp_DB.ClearSelection();
            dgk_DB.ClearSelection();
            dgp_file.ClearSelection();
            dgk_file.ClearSelection();
        }

        private void dgk_SelectionChanged(object sender, EventArgs e)
        {
        }
        //Get selected keywords and bind them with current selected file
        private void AddingKeywordsToFile(DataGridView dgv)
        {
            FilePersonKeywordClient client = new FilePersonKeywordClient();
            Int32 selectedRowCount = dgv.Rows.GetRowCount(DataGridViewElementStates.Selected); //getting number of selected rows
            for (int i = 0; i < selectedRowCount; i++)
            {
                Console.WriteLine(dgv[1, dgv.SelectedRows[i].Index].Value.ToString());
                client.InsertKeywordIntoFile(dgv[1, dgv.SelectedRows[i].Index].Value.ToString(), listBox_Files.SelectedItem.ToString());
            }
            client.Close();
        }

        private void button_fIntoK_Click(object sender, EventArgs e)
        {
            FilePersonKeywordClient client = new FilePersonKeywordClient();
            List<int> ids = getKIdsFromSelectedRows();
            client.DeleteKeywordsFromFile(ids.ToArray(),listBox_Files.SelectedItem.ToString());
            RefreshDgk_file();
            client.Close();
        }
        //getting a list of selected keywords id from dgk_File
        private List<int> getKIdsFromSelectedRows()
        {
            Int32 selectedRowCount = dgk_file.Rows.GetRowCount(DataGridViewElementStates.Selected);
            List<int> ids = new List<int>();
            for (int i = 0; i < selectedRowCount; i++)
            {
                Console.WriteLine(dgk_file[0, dgk_file.SelectedRows[i].Index].Value.ToString());
                ids.Add(Convert.ToInt32(dgk_file[0, dgk_file.SelectedRows[i].Index].Value));
            }
            return ids;
        }

        private void button_kIntoF_Click(object sender, EventArgs e)
        {
            AddingKeywordsToFile(dgk_DB);
            dgk_DB.ClearSelection();
            RefreshDgk_file();
            dgk_file.ClearSelection();

        }
        //Get selected persons and bind them with current selected file
        private void AddingPersonsToFile(DataGridView dgp)
        {
            FilePersonKeywordClient client = new FilePersonKeywordClient();
            Int32 selectedRowCount = dgp.Rows.GetRowCount(DataGridViewElementStates.Selected); //getting number of selected rows
            for (int i = 0; i < selectedRowCount; i++)
            {
                Console.WriteLine(dgp[0, dgp.SelectedRows[i].Index].Value.ToString());
                client.InsertPersonIntoFile(Convert.ToInt32(dgp[0, dgp.SelectedRows[i].Index].Value), listBox_Files.SelectedItem.ToString());
            }
            client.Close();
        }
        private List<int> getPersonIdsFromSelectedRows()
        {
            Int32 selectedRowCount = dgp_file.Rows.GetRowCount(DataGridViewElementStates.Selected);
            List<int> ids = new List<int>();
            for (int i = 0; i < selectedRowCount; i++)
            {
                Console.WriteLine(dgp_file[0, dgp_file.SelectedRows[i].Index].Value.ToString());
                ids.Add(Convert.ToInt32(dgp_file[0, dgp_file.SelectedRows[i].Index].Value));
            }
            return ids;
        }
        private void button_pIntoF_Click(object sender, EventArgs e)
        {
            AddingPersonsToFile(dgp_DB);
            dgp_DB.ClearSelection();
            RefreshDgp_file();
            dgp_file.ClearSelection();
        }
        private void button_fIntoP_Click(object sender, EventArgs e)
        {
            FilePersonKeywordClient client = new FilePersonKeywordClient();
            List<int> ids = getPersonIdsFromSelectedRows();
            client.DeletePeopleFromFile(ids.ToArray(), listBox_Files.SelectedItem.ToString());
            RefreshDgp_file();
            client.Close();
        }
        private void enableArrowButtons()
        {
            button_fIntoK.Enabled = true;
            button_kIntoF.Enabled = true;
            button_fIntoP.Enabled = true;
            button_pIntoF.Enabled = true;
        }
        private void disableArrowButtons()
        {
            button_fIntoK.Enabled = false;
            button_kIntoF.Enabled = false;
            button_fIntoP.Enabled = false;
            button_pIntoF.Enabled = false;
        }
    }
}
