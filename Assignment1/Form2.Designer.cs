namespace Assignment1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.radioFb = new System.Windows.Forms.RadioButton();
            this.radioTweet = new System.Windows.Forms.RadioButton();
            this.radioPhoto = new System.Windows.Forms.RadioButton();
            this.radioVideo = new System.Windows.Forms.RadioButton();
            this.radioTrack = new System.Windows.Forms.RadioButton();
            this.panelFb = new System.Windows.Forms.Panel();
            this.textFbDate = new System.Windows.Forms.TextBox();
            this.labelFbDate = new System.Windows.Forms.Label();
            this.LabelFbText = new System.Windows.Forms.Label();
            this.textFbText = new System.Windows.Forms.TextBox();
            this.panelTwitter = new System.Windows.Forms.Panel();
            this.textTwitterDate = new System.Windows.Forms.TextBox();
            this.labelTwitterDate = new System.Windows.Forms.Label();
            this.labelTwitterText = new System.Windows.Forms.Label();
            this.textTwitterText = new System.Windows.Forms.TextBox();
            this.panelPhoto = new System.Windows.Forms.Panel();
            this.labelPhoto = new System.Windows.Forms.Label();
            this.textPhotoFilePath = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.panelVideo = new System.Windows.Forms.Panel();
            this.labelVideoFilePath = new System.Windows.Forms.Label();
            this.textBoxVideoFilePath = new System.Windows.Forms.TextBox();
            this.panelTrackLog = new System.Windows.Forms.Panel();
            this.labelFilepathTracklog = new System.Windows.Forms.Label();
            this.textBoxFilepathTracklog = new System.Windows.Forms.TextBox();
            this.labelLat2Tracklog = new System.Windows.Forms.Label();
            this.textBoxLat2Tracklog = new System.Windows.Forms.TextBox();
            this.textBoxLongi2Tracklog = new System.Windows.Forms.TextBox();
            this.labelLongi2Tracklog = new System.Windows.Forms.Label();
            this.panelFb.SuspendLayout();
            this.panelTwitter.SuspendLayout();
            this.panelPhoto.SuspendLayout();
            this.panelVideo.SuspendLayout();
            this.panelTrackLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Type";
            // 
            // radioFb
            // 
            this.radioFb.AutoSize = true;
            this.radioFb.Location = new System.Drawing.Point(145, 22);
            this.radioFb.Name = "radioFb";
            this.radioFb.Size = new System.Drawing.Size(106, 17);
            this.radioFb.TabIndex = 1;
            this.radioFb.TabStop = true;
            this.radioFb.Text = "Facebook Status";
            this.radioFb.UseVisualStyleBackColor = true;
            this.radioFb.CheckedChanged += new System.EventHandler(this.fbChecked);
            // 
            // radioTweet
            // 
            this.radioTweet.AutoSize = true;
            this.radioTweet.Location = new System.Drawing.Point(145, 46);
            this.radioTweet.Name = "radioTweet";
            this.radioTweet.Size = new System.Drawing.Size(55, 17);
            this.radioTweet.TabIndex = 2;
            this.radioTweet.TabStop = true;
            this.radioTweet.Text = "Tweet";
            this.radioTweet.UseVisualStyleBackColor = true;
            this.radioTweet.CheckedChanged += new System.EventHandler(this.tweetChecked);
            // 
            // radioPhoto
            // 
            this.radioPhoto.AutoSize = true;
            this.radioPhoto.Location = new System.Drawing.Point(145, 70);
            this.radioPhoto.Name = "radioPhoto";
            this.radioPhoto.Size = new System.Drawing.Size(53, 17);
            this.radioPhoto.TabIndex = 3;
            this.radioPhoto.TabStop = true;
            this.radioPhoto.Text = "Photo";
            this.radioPhoto.UseVisualStyleBackColor = true;
            this.radioPhoto.CheckedChanged += new System.EventHandler(this.photoChecked);
            // 
            // radioVideo
            // 
            this.radioVideo.AutoSize = true;
            this.radioVideo.Location = new System.Drawing.Point(145, 94);
            this.radioVideo.Name = "radioVideo";
            this.radioVideo.Size = new System.Drawing.Size(52, 17);
            this.radioVideo.TabIndex = 4;
            this.radioVideo.TabStop = true;
            this.radioVideo.Text = "Video";
            this.radioVideo.UseVisualStyleBackColor = true;
            this.radioVideo.CheckedChanged += new System.EventHandler(this.videoChecked);
            // 
            // radioTrack
            // 
            this.radioTrack.AutoSize = true;
            this.radioTrack.Location = new System.Drawing.Point(145, 118);
            this.radioTrack.Name = "radioTrack";
            this.radioTrack.Size = new System.Drawing.Size(67, 17);
            this.radioTrack.TabIndex = 5;
            this.radioTrack.TabStop = true;
            this.radioTrack.Text = "Tracklog";
            this.radioTrack.UseVisualStyleBackColor = true;
            this.radioTrack.CheckedChanged += new System.EventHandler(this.tracklogChecked);
            // 
            // panelFb
            // 
            this.panelFb.Controls.Add(this.textFbDate);
            this.panelFb.Controls.Add(this.labelFbDate);
            this.panelFb.Controls.Add(this.LabelFbText);
            this.panelFb.Controls.Add(this.textFbText);
            this.panelFb.Location = new System.Drawing.Point(288, 22);
            this.panelFb.Name = "panelFb";
            this.panelFb.Size = new System.Drawing.Size(200, 100);
            this.panelFb.TabIndex = 6;
            // 
            // textFbDate
            // 
            this.textFbDate.Location = new System.Drawing.Point(67, 33);
            this.textFbDate.Name = "textFbDate";
            this.textFbDate.Size = new System.Drawing.Size(100, 20);
            this.textFbDate.TabIndex = 3;
            // 
            // labelFbDate
            // 
            this.labelFbDate.AutoSize = true;
            this.labelFbDate.Location = new System.Drawing.Point(16, 40);
            this.labelFbDate.Name = "labelFbDate";
            this.labelFbDate.Size = new System.Drawing.Size(33, 13);
            this.labelFbDate.TabIndex = 2;
            this.labelFbDate.Text = "Date:";
            // 
            // LabelFbText
            // 
            this.LabelFbText.AutoSize = true;
            this.LabelFbText.Location = new System.Drawing.Point(13, 7);
            this.LabelFbText.Name = "LabelFbText";
            this.LabelFbText.Size = new System.Drawing.Size(31, 13);
            this.LabelFbText.TabIndex = 1;
            this.LabelFbText.Text = "Text:";
            // 
            // textFbText
            // 
            this.textFbText.Location = new System.Drawing.Point(67, 4);
            this.textFbText.Name = "textFbText";
            this.textFbText.Size = new System.Drawing.Size(100, 20);
            this.textFbText.TabIndex = 0;
            // 
            // panelTwitter
            // 
            this.panelTwitter.Controls.Add(this.textTwitterDate);
            this.panelTwitter.Controls.Add(this.labelTwitterDate);
            this.panelTwitter.Controls.Add(this.labelTwitterText);
            this.panelTwitter.Controls.Add(this.textTwitterText);
            this.panelTwitter.Location = new System.Drawing.Point(288, 22);
            this.panelTwitter.Name = "panelTwitter";
            this.panelTwitter.Size = new System.Drawing.Size(200, 100);
            this.panelTwitter.TabIndex = 7;
            // 
            // textTwitterDate
            // 
            this.textTwitterDate.Location = new System.Drawing.Point(67, 33);
            this.textTwitterDate.Name = "textTwitterDate";
            this.textTwitterDate.Size = new System.Drawing.Size(100, 20);
            this.textTwitterDate.TabIndex = 3;
            // 
            // labelTwitterDate
            // 
            this.labelTwitterDate.AutoSize = true;
            this.labelTwitterDate.Location = new System.Drawing.Point(16, 40);
            this.labelTwitterDate.Name = "labelTwitterDate";
            this.labelTwitterDate.Size = new System.Drawing.Size(33, 13);
            this.labelTwitterDate.TabIndex = 2;
            this.labelTwitterDate.Text = "Date:";
            // 
            // labelTwitterText
            // 
            this.labelTwitterText.AutoSize = true;
            this.labelTwitterText.Location = new System.Drawing.Point(13, 7);
            this.labelTwitterText.Name = "labelTwitterText";
            this.labelTwitterText.Size = new System.Drawing.Size(31, 13);
            this.labelTwitterText.TabIndex = 1;
            this.labelTwitterText.Text = "Text:";
            // 
            // textTwitterText
            // 
            this.textTwitterText.Location = new System.Drawing.Point(67, 4);
            this.textTwitterText.Name = "textTwitterText";
            this.textTwitterText.Size = new System.Drawing.Size(100, 20);
            this.textTwitterText.TabIndex = 0;
            // 
            // panelPhoto
            // 
            this.panelPhoto.Controls.Add(this.labelPhoto);
            this.panelPhoto.Controls.Add(this.textPhotoFilePath);
            this.panelPhoto.Location = new System.Drawing.Point(288, 22);
            this.panelPhoto.Name = "panelPhoto";
            this.panelPhoto.Size = new System.Drawing.Size(200, 100);
            this.panelPhoto.TabIndex = 8;
            // 
            // labelPhoto
            // 
            this.labelPhoto.AutoSize = true;
            this.labelPhoto.Location = new System.Drawing.Point(13, 7);
            this.labelPhoto.Name = "labelPhoto";
            this.labelPhoto.Size = new System.Drawing.Size(51, 13);
            this.labelPhoto.TabIndex = 1;
            this.labelPhoto.Text = "FilePath: ";
            // 
            // textPhotoFilePath
            // 
            this.textPhotoFilePath.Location = new System.Drawing.Point(67, 4);
            this.textPhotoFilePath.Name = "textPhotoFilePath";
            this.textPhotoFilePath.Size = new System.Drawing.Size(100, 20);
            this.textPhotoFilePath.TabIndex = 0;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(543, 22);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 9;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtnClick);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(543, 70);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 10;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtnClick);
            // 
            // panelVideo
            // 
            this.panelVideo.Controls.Add(this.labelVideoFilePath);
            this.panelVideo.Controls.Add(this.textBoxVideoFilePath);
            this.panelVideo.Location = new System.Drawing.Point(288, 22);
            this.panelVideo.Name = "panelVideo";
            this.panelVideo.Size = new System.Drawing.Size(200, 100);
            this.panelVideo.TabIndex = 9;
            // 
            // labelVideoFilePath
            // 
            this.labelVideoFilePath.AutoSize = true;
            this.labelVideoFilePath.Location = new System.Drawing.Point(13, 7);
            this.labelVideoFilePath.Name = "labelVideoFilePath";
            this.labelVideoFilePath.Size = new System.Drawing.Size(51, 13);
            this.labelVideoFilePath.TabIndex = 1;
            this.labelVideoFilePath.Text = "FilePath: ";
            // 
            // textBoxVideoFilePath
            // 
            this.textBoxVideoFilePath.Location = new System.Drawing.Point(67, 4);
            this.textBoxVideoFilePath.Name = "textBoxVideoFilePath";
            this.textBoxVideoFilePath.Size = new System.Drawing.Size(100, 20);
            this.textBoxVideoFilePath.TabIndex = 0;
            // 
            // panelTrackLog
            // 
            this.panelTrackLog.Controls.Add(this.labelLongi2Tracklog);
            this.panelTrackLog.Controls.Add(this.textBoxLongi2Tracklog);
            this.panelTrackLog.Controls.Add(this.textBoxLat2Tracklog);
            this.panelTrackLog.Controls.Add(this.labelLat2Tracklog);
            this.panelTrackLog.Controls.Add(this.labelFilepathTracklog);
            this.panelTrackLog.Controls.Add(this.textBoxFilepathTracklog);
            this.panelTrackLog.Location = new System.Drawing.Point(288, 22);
            this.panelTrackLog.Name = "panelTrackLog";
            this.panelTrackLog.Size = new System.Drawing.Size(200, 100);
            this.panelTrackLog.TabIndex = 10;
            // 
            // labelFilepathTracklog
            // 
            this.labelFilepathTracklog.AutoSize = true;
            this.labelFilepathTracklog.Location = new System.Drawing.Point(7, 10);
            this.labelFilepathTracklog.Name = "labelFilepathTracklog";
            this.labelFilepathTracklog.Size = new System.Drawing.Size(51, 13);
            this.labelFilepathTracklog.TabIndex = 1;
            this.labelFilepathTracklog.Text = "FilePath: ";
            // 
            // textBoxFilepathTracklog
            // 
            this.textBoxFilepathTracklog.Location = new System.Drawing.Point(83, 4);
            this.textBoxFilepathTracklog.Name = "textBoxFilepathTracklog";
            this.textBoxFilepathTracklog.Size = new System.Drawing.Size(100, 20);
            this.textBoxFilepathTracklog.TabIndex = 0;
            // 
            // labelLat2Tracklog
            // 
            this.labelLat2Tracklog.AutoSize = true;
            this.labelLat2Tracklog.Location = new System.Drawing.Point(7, 33);
            this.labelLat2Tracklog.Name = "labelLat2Tracklog";
            this.labelLat2Tracklog.Size = new System.Drawing.Size(84, 13);
            this.labelLat2Tracklog.TabIndex = 2;
            this.labelLat2Tracklog.Text = "Second lattitude";
            //this.labelLat2Tracklog.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxLat2Tracklog
            // 
            this.textBoxLat2Tracklog.Location = new System.Drawing.Point(107, 33);
            this.textBoxLat2Tracklog.Name = "textBoxLat2Tracklog";
            this.textBoxLat2Tracklog.Size = new System.Drawing.Size(76, 20);
            this.textBoxLat2Tracklog.TabIndex = 3;
            // 
            // textBoxLongi2Tracklog
            // 
            this.textBoxLongi2Tracklog.Location = new System.Drawing.Point(107, 57);
            this.textBoxLongi2Tracklog.Name = "textBoxLongi2Tracklog";
            this.textBoxLongi2Tracklog.Size = new System.Drawing.Size(76, 20);
            this.textBoxLongi2Tracklog.TabIndex = 4;
            // 
            // labelLongi2Tracklog
            // 
            this.labelLongi2Tracklog.AutoSize = true;
            this.labelLongi2Tracklog.Location = new System.Drawing.Point(7, 60);
            this.labelLongi2Tracklog.Name = "labelLongi2Tracklog";
            this.labelLongi2Tracklog.Size = new System.Drawing.Size(94, 13);
            this.labelLongi2Tracklog.TabIndex = 5;
            this.labelLongi2Tracklog.Text = "Second Longitude";
            //this.labelLongi2Tracklog.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 175);
            this.Controls.Add(this.panelTrackLog);
            this.Controls.Add(this.panelVideo);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.panelPhoto);
            this.Controls.Add(this.panelTwitter);
            this.Controls.Add(this.panelFb);
            this.Controls.Add(this.radioTrack);
            this.Controls.Add(this.radioVideo);
            this.Controls.Add(this.radioPhoto);
            this.Controls.Add(this.radioTweet);
            this.Controls.Add(this.radioFb);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panelFb.ResumeLayout(false);
            this.panelFb.PerformLayout();
            this.panelTwitter.ResumeLayout(false);
            this.panelTwitter.PerformLayout();
            this.panelPhoto.ResumeLayout(false);
            this.panelPhoto.PerformLayout();
            this.panelVideo.ResumeLayout(false);
            this.panelVideo.PerformLayout();
            this.panelTrackLog.ResumeLayout(false);
            this.panelTrackLog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioFb;
        private System.Windows.Forms.RadioButton radioTweet;
        private System.Windows.Forms.RadioButton radioPhoto;
        private System.Windows.Forms.RadioButton radioVideo;
        private System.Windows.Forms.RadioButton radioTrack;
        private System.Windows.Forms.Panel panelFb;
        private System.Windows.Forms.Label LabelFbText;
        private System.Windows.Forms.TextBox textFbText;
        private System.Windows.Forms.TextBox textFbDate;
        private System.Windows.Forms.Label labelFbDate;
        private System.Windows.Forms.Panel panelTwitter;
        private System.Windows.Forms.TextBox textTwitterDate;
        private System.Windows.Forms.Label labelTwitterDate;
        private System.Windows.Forms.Label labelTwitterText;
        private System.Windows.Forms.TextBox textTwitterText;
        private System.Windows.Forms.Panel panelPhoto;
        private System.Windows.Forms.Label labelPhoto;
        private System.Windows.Forms.TextBox textPhotoFilePath;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Panel panelVideo;
        private System.Windows.Forms.Label labelVideoFilePath;
        private System.Windows.Forms.TextBox textBoxVideoFilePath;
        private System.Windows.Forms.Panel panelTrackLog;
        private System.Windows.Forms.Label labelLat2Tracklog;
        private System.Windows.Forms.Label labelFilepathTracklog;
        private System.Windows.Forms.TextBox textBoxFilepathTracklog;
        private System.Windows.Forms.TextBox textBoxLat2Tracklog;
        private System.Windows.Forms.Label labelLongi2Tracklog;
        private System.Windows.Forms.TextBox textBoxLongi2Tracklog;
    }
}