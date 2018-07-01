namespace WindowsFormsApp1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelName = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelLinkedIn = new System.Windows.Forms.Label();
            this.labelGitHub = new System.Windows.Forms.Label();
            this.labelBio = new System.Windows.Forms.Label();
            this.textBoxGitHub = new System.Windows.Forms.TextBox();
            this.textBoxLinkedIn = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.richTextBoxBio = new System.Windows.Forms.RichTextBox();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.pictureBoxPersonal = new System.Windows.Forms.PictureBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(13, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Location = new System.Drawing.Point(13, 43);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(30, 13);
            this.labelDOB.TabIndex = 1;
            this.labelDOB.Text = "DOB";
            // 
            // labelLinkedIn
            // 
            this.labelLinkedIn.AutoSize = true;
            this.labelLinkedIn.Location = new System.Drawing.Point(13, 74);
            this.labelLinkedIn.Name = "labelLinkedIn";
            this.labelLinkedIn.Size = new System.Drawing.Size(48, 13);
            this.labelLinkedIn.TabIndex = 2;
            this.labelLinkedIn.Text = "LinkedIn";
            // 
            // labelGitHub
            // 
            this.labelGitHub.AutoSize = true;
            this.labelGitHub.Location = new System.Drawing.Point(13, 110);
            this.labelGitHub.Name = "labelGitHub";
            this.labelGitHub.Size = new System.Drawing.Size(40, 13);
            this.labelGitHub.TabIndex = 3;
            this.labelGitHub.Text = "GitHub";
            // 
            // labelBio
            // 
            this.labelBio.AutoSize = true;
            this.labelBio.Location = new System.Drawing.Point(13, 144);
            this.labelBio.Name = "labelBio";
            this.labelBio.Size = new System.Drawing.Size(54, 13);
            this.labelBio.TabIndex = 4;
            this.labelBio.Text = "Biography";
            // 
            // textBoxGitHub
            // 
            this.textBoxGitHub.Location = new System.Drawing.Point(76, 107);
            this.textBoxGitHub.Name = "textBoxGitHub";
            this.textBoxGitHub.Size = new System.Drawing.Size(270, 20);
            this.textBoxGitHub.TabIndex = 4;
            // 
            // textBoxLinkedIn
            // 
            this.textBoxLinkedIn.Location = new System.Drawing.Point(76, 71);
            this.textBoxLinkedIn.Name = "textBoxLinkedIn";
            this.textBoxLinkedIn.Size = new System.Drawing.Size(270, 20);
            this.textBoxLinkedIn.TabIndex = 3;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(76, 10);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(270, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // richTextBoxBio
            // 
            this.richTextBoxBio.Location = new System.Drawing.Point(76, 141);
            this.richTextBoxBio.Name = "richTextBoxBio";
            this.richTextBoxBio.Size = new System.Drawing.Size(269, 119);
            this.richTextBoxBio.TabIndex = 5;
            this.richTextBoxBio.Text = "";
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Location = new System.Drawing.Point(76, 37);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(270, 20);
            this.dateTimePickerDOB.TabIndex = 2;
            // 
            // pictureBoxPersonal
            // 
            this.pictureBoxPersonal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPersonal.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPersonal.Image")));
            this.pictureBoxPersonal.InitialImage = null;
            this.pictureBoxPersonal.Location = new System.Drawing.Point(372, 10);
            this.pictureBoxPersonal.Name = "pictureBoxPersonal";
            this.pictureBoxPersonal.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxPersonal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxPersonal.TabIndex = 12;
            this.pictureBoxPersonal.TabStop = false;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(372, 267);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(250, 23);
            this.buttonBrowse.TabIndex = 6;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(209, 266);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(137, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save Info";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(76, 266);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(127, 23);
            this.buttonLoad.TabIndex = 7;
            this.buttonLoad.Text = "Load Info";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 304);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.pictureBoxPersonal);
            this.Controls.Add(this.dateTimePickerDOB);
            this.Controls.Add(this.richTextBoxBio);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxLinkedIn);
            this.Controls.Add(this.textBoxGitHub);
            this.Controls.Add(this.labelBio);
            this.Controls.Add(this.labelGitHub);
            this.Controls.Add(this.labelLinkedIn);
            this.Controls.Add(this.labelDOB);
            this.Controls.Add(this.labelName);
            this.Name = "MainForm";
            this.Text = "Personal Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPersonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelLinkedIn;
        private System.Windows.Forms.Label labelGitHub;
        private System.Windows.Forms.Label labelBio;
        private System.Windows.Forms.TextBox textBoxGitHub;
        private System.Windows.Forms.TextBox textBoxLinkedIn;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.RichTextBox richTextBoxBio;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.PictureBox pictureBoxPersonal;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
    }
}

