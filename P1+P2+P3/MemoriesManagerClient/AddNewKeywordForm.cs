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
    public partial class AddNewKeywordForm : Form
    {
        MemoriesManagerForm memoriesManagerForm;
        public AddNewKeywordForm(MemoriesManagerForm mmf)
        {
            InitializeComponent();
            memoriesManagerForm = mmf;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            FilePersonKeywordClient client = new FilePersonKeywordClient();
            if ((client.GetKeywordByKword(textBox_Kword.Text) == null))
            {
                global::MemoriesManager.Keyword newKeyword = new global::MemoriesManager.Keyword
                {
                    Kword = textBox_Kword.Text
                    
                };
                client.CreateKeyword(newKeyword);
            }
            else
            {
                MessageBox.Show("That keyword already exists in DB", "Error");
            }
            memoriesManagerForm.RefreshDgk_DB();
        }
    }
}
