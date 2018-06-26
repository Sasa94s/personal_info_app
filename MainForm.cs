using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Web.Script.Serialization;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JSON File|*.json";
            sfd.FileName = "personal_data";
            sfd.Title = "Save JSON File";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = sfd.FileName;
                using (StreamWriter bw = new StreamWriter(File.Create(path)))
                {
                    bw.Write(getJSON());
                    bw.Close();
                }
            }
        }

        public class PersonalInfo
        {
            public string name;
            public DateTime dob;
            public string linkedin;
            public string github;
            public string bio;

            public PersonalInfo (string name, DateTime dob, string linkedin, string github, string bio)
            {
                this.name = name;
                this.dob = dob;
                this.linkedin = linkedin;
                this.github = github;
                this.bio = bio;
            }
            
        }

        private PersonalInfo getData()
        {
            
            PersonalInfo data = new PersonalInfo(textBoxName.Text,
                                                dateTimePickerDOB.Value,
                                                textBoxLinkedIn.Text,
                                                textBoxGitHub.Text,
                                                richTextBoxBio.Text);
            return data;
        }

        private string getJSON()
        {
            var data = getData();
            string json = new JavaScriptSerializer().Serialize(data);
            return json;
        }

    }
}
