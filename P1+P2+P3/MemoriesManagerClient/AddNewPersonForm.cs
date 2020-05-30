using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoriesManagerClient
{
    public partial class AddNewPersonForm : Form
    {
        readonly MemoriesManagerForm memoriesManagerForm;
        public AddNewPersonForm(MemoriesManagerForm mmf)
        {
            memoriesManagerForm = mmf;
            InitializeComponent();
            
        }


        private void button_AddNewPerson_Click(object sender, EventArgs e)
        {
            FilePersonKeywordClient client = new FilePersonKeywordClient();
            if ((client.GetPersonByName(textBox_FirstName.Text, textBox_LastName.Text)) ==null)
            {
                global::MemoriesManager.Person newPerson = new global::MemoriesManager.Person
                {
                    First_name = textBox_FirstName.Text,
                    Last_name = textBox_LastName.Text
                };
                client.CreatePerson(newPerson);
            }
            else
            {
                MessageBox.Show("That person already exists in DB", "Error");
            }
            memoriesManagerForm.RefreshDgp_DB();
        }


    }
}
