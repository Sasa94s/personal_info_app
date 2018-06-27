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
            public string name; // Name
            public DateTime dob; // DOB
            public string linkedin; // LinkedIn
            public string github; // GitHub
            public string bio; // Biography

            [ScriptIgnore]
            private Image img;
            [ScriptIgnore]
            public Image Img
            {
                get
                {
                    if (this.byteImg == null)
                        return this.img;
                    return this.ByteArrayToImage(this.byteImg);
                }
                set
                {
                    this.img = value;
                }
            } // Image

            // byte array of image to be serialized
            public byte[] byteImg;

            // Default Constructor
            public PersonalInfo () { }

            // Constructor for setting up all instance members except byte array
            public PersonalInfo (string name, DateTime dob, string linkedin, string github, string bio, Image img)
            {
                this.name = name;
                this.dob = dob;
                this.linkedin = linkedin;
                this.github = github;
                this.bio = bio;
                this.Img = img;
                this.byteImg = this.ImageToByteArray(this.Img);
            }

            // Constructor for setting up instance members except Image
            public PersonalInfo(string name, DateTime dob, string linkedin, string github, string bio, byte[] byteImg)
            {
                this.name = name;
                this.dob = dob;
                this.linkedin = linkedin;
                this.github = github;
                this.bio = bio;
                this.byteImg = byteImg;
                this.Img = this.ByteArrayToImage(this.byteImg);
            }

            /// <summary>
            /// Converting Image to Byte array using MemoryStream
            /// </summary>
            public byte[] ImageToByteArray(Image imageIn)
            {
                using (var ms = new MemoryStream())
                {
                    // Saving image to memory stream
                    imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                   
                    // Returning a byte array
                    return ms.ToArray();
                }
            }

            /// <summary>
            /// Converting Byte array to Image using MemoryStream 
            /// </summary>
            public Image ByteArrayToImage(byte[] byteArrayIn)
            {
                using (var ms = new MemoryStream(byteArrayIn))
                {
                    // Creating image from memory stream
                    Image returnImage = Image.FromStream(ms);
                    // Returning an image
                    return returnImage;
                }
            }
        }

        private PersonalInfo getData()
        {
            // Creating instance of PersonalInfo and passing parameters of input fields
            PersonalInfo data = new PersonalInfo(textBoxName.Text,
                                                dateTimePickerDOB.Value,
                                                textBoxLinkedIn.Text,
                                                textBoxGitHub.Text,
                                                richTextBoxBio.Text,
                                                pictureBoxPersonal.Image);
            return data;
        }

        private void setData(PersonalInfo data)
        {
            // Setting input fields by getting values from PersonalInfo instance
            textBoxName.Text = data.name;
            dateTimePickerDOB.Value = data.dob;
            textBoxLinkedIn.Text = data.linkedin;
            textBoxGitHub.Text = data.github;
            richTextBoxBio.Text = data.bio;
            pictureBoxPersonal.Image = data.Img;
        }

        private string getJSON()
        {
            PersonalInfo data = getData();

            // Serializing PersonalInfo data inserted in input fields
            string json = new JavaScriptSerializer().Serialize(data);
            return json;
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // Creating Image type from filename
                Image img = new Bitmap(open.FileName);

                // Getting image filename
                string imagename = open.SafeFileName;
                
                // Showing thumbnail of current image in picture box
                pictureBoxPersonal.Image = img.GetThumbnailImage(250, 250, null, new IntPtr());
                open.RestoreDirectory = true;
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "JSON Files(*.json)|*.json";
            if (open.ShowDialog() == DialogResult.OK)
            {
                string infoName = open.FileName;
                string infoPath = open.SafeFileName;
                PersonalInfo data = null;
                using (StreamReader r = new StreamReader(infoName))
                {
                    string json = r.ReadToEnd();
                    data = new JavaScriptSerializer().Deserialize<PersonalInfo>(json);
                }
                setData(data);
                open.RestoreDirectory = true;
            }
        }
    }
}
