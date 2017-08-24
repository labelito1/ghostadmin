namespace migh.admin
{
    partial class frmAlbumCreator
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
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.listSong = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.txtAlbumArtist = new System.Windows.Forms.TextBox();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.txtURLName = new System.Windows.Forms.TextBox();
            this.btnSelectMusicFolder = new System.Windows.Forms.Button();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGitHubFolder = new System.Windows.Forms.TextBox();
            this.btnSelectGitHubFolder = new System.Windows.Forms.Button();
            this.chkCopiar = new System.Windows.Forms.CheckBox();
            this.de = new System.Windows.Forms.Label();
            this.txtTrack = new System.Windows.Forms.TextBox();
            this.txtTrackCount = new System.Windows.Forms.TextBox();
            this.txtArtists = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtDiscCount = new System.Windows.Forms.TextBox();
            this.txtDisc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtDiscCountTrack = new System.Windows.Forms.TextBox();
            this.txtDiscTrack = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnStruct = new System.Windows.Forms.Button();
            this.txtAlbumId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fuente";
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(62, 12);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.ReadOnly = true;
            this.txtDirectory.Size = new System.Drawing.Size(462, 20);
            this.txtDirectory.TabIndex = 1;
            this.txtDirectory.TextChanged += new System.EventHandler(this.txtDirectory_TextChanged);
            // 
            // btnAnalizar
            // 
            this.btnAnalizar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAnalizar.Location = new System.Drawing.Point(255, 336);
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(75, 23);
            this.btnAnalizar.TabIndex = 4;
            this.btnAnalizar.Text = "Analizar";
            this.btnAnalizar.UseVisualStyleBackColor = true;
            this.btnAnalizar.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // listSong
            // 
            this.listSong.FormattingEnabled = true;
            this.listSong.Location = new System.Drawing.Point(12, 73);
            this.listSong.Name = "listSong";
            this.listSong.Size = new System.Drawing.Size(234, 290);
            this.listSong.TabIndex = 5;
            this.listSong.SelectedIndexChanged += new System.EventHandler(this.listSong_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Location = new System.Drawing.Point(398, 336);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(190, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Álbum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Artista (álbum)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Archivo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nombre URL";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(327, 83);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(261, 20);
            this.txtName.TabIndex = 16;
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(327, 109);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.ReadOnly = true;
            this.txtAlbum.Size = new System.Drawing.Size(261, 20);
            this.txtAlbum.TabIndex = 17;
            // 
            // txtAlbumArtist
            // 
            this.txtAlbumArtist.Location = new System.Drawing.Point(327, 180);
            this.txtAlbumArtist.Name = "txtAlbumArtist";
            this.txtAlbumArtist.ReadOnly = true;
            this.txtAlbumArtist.Size = new System.Drawing.Size(261, 20);
            this.txtAlbumArtist.TabIndex = 18;
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(327, 232);
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(261, 20);
            this.txtFile.TabIndex = 19;
            // 
            // txtURLName
            // 
            this.txtURLName.Location = new System.Drawing.Point(327, 258);
            this.txtURLName.Name = "txtURLName";
            this.txtURLName.ReadOnly = true;
            this.txtURLName.Size = new System.Drawing.Size(261, 20);
            this.txtURLName.TabIndex = 20;
            // 
            // btnSelectMusicFolder
            // 
            this.btnSelectMusicFolder.Location = new System.Drawing.Point(530, 10);
            this.btnSelectMusicFolder.Name = "btnSelectMusicFolder";
            this.btnSelectMusicFolder.Size = new System.Drawing.Size(58, 23);
            this.btnSelectMusicFolder.TabIndex = 22;
            this.btnSelectMusicFolder.Text = "...";
            this.btnSelectMusicFolder.UseVisualStyleBackColor = true;
            this.btnSelectMusicFolder.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // folderBrowser
            // 
            this.folderBrowser.ShowNewFolderButton = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Destino";
            // 
            // txtGitHubFolder
            // 
            this.txtGitHubFolder.Location = new System.Drawing.Point(62, 38);
            this.txtGitHubFolder.Name = "txtGitHubFolder";
            this.txtGitHubFolder.ReadOnly = true;
            this.txtGitHubFolder.Size = new System.Drawing.Size(462, 20);
            this.txtGitHubFolder.TabIndex = 24;
            // 
            // btnSelectGitHubFolder
            // 
            this.btnSelectGitHubFolder.Location = new System.Drawing.Point(530, 36);
            this.btnSelectGitHubFolder.Name = "btnSelectGitHubFolder";
            this.btnSelectGitHubFolder.Size = new System.Drawing.Size(58, 23);
            this.btnSelectGitHubFolder.TabIndex = 25;
            this.btnSelectGitHubFolder.Text = "...";
            this.btnSelectGitHubFolder.UseVisualStyleBackColor = true;
            this.btnSelectGitHubFolder.Click += new System.EventHandler(this.btnSelectGitHubFolder_Click);
            // 
            // chkCopiar
            // 
            this.chkCopiar.AutoSize = true;
            this.chkCopiar.Checked = true;
            this.chkCopiar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCopiar.Location = new System.Drawing.Point(530, 313);
            this.chkCopiar.Name = "chkCopiar";
            this.chkCopiar.Size = new System.Drawing.Size(56, 17);
            this.chkCopiar.TabIndex = 26;
            this.chkCopiar.Text = "Copiar";
            this.chkCopiar.UseVisualStyleBackColor = true;
            // 
            // de
            // 
            this.de.AutoSize = true;
            this.de.Location = new System.Drawing.Point(375, 287);
            this.de.Name = "de";
            this.de.Size = new System.Drawing.Size(19, 13);
            this.de.TabIndex = 27;
            this.de.Text = "de";
            // 
            // txtTrack
            // 
            this.txtTrack.Location = new System.Drawing.Point(327, 284);
            this.txtTrack.Name = "txtTrack";
            this.txtTrack.ReadOnly = true;
            this.txtTrack.Size = new System.Drawing.Size(42, 20);
            this.txtTrack.TabIndex = 28;
            // 
            // txtTrackCount
            // 
            this.txtTrackCount.Location = new System.Drawing.Point(400, 284);
            this.txtTrackCount.Name = "txtTrackCount";
            this.txtTrackCount.ReadOnly = true;
            this.txtTrackCount.Size = new System.Drawing.Size(40, 20);
            this.txtTrackCount.TabIndex = 29;
            // 
            // txtArtists
            // 
            this.txtArtists.Location = new System.Drawing.Point(327, 206);
            this.txtArtists.Name = "txtArtists";
            this.txtArtists.ReadOnly = true;
            this.txtArtists.Size = new System.Drawing.Size(261, 20);
            this.txtArtists.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(285, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Artista";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(488, 284);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.ReadOnly = true;
            this.txtDuration.Size = new System.Drawing.Size(100, 20);
            this.txtDuration.TabIndex = 32;
            // 
            // txtDiscCount
            // 
            this.txtDiscCount.Location = new System.Drawing.Point(400, 135);
            this.txtDiscCount.Name = "txtDiscCount";
            this.txtDiscCount.ReadOnly = true;
            this.txtDiscCount.Size = new System.Drawing.Size(40, 20);
            this.txtDiscCount.TabIndex = 35;
            // 
            // txtDisc
            // 
            this.txtDisc.Location = new System.Drawing.Point(327, 135);
            this.txtDisc.Name = "txtDisc";
            this.txtDisc.ReadOnly = true;
            this.txtDisc.Size = new System.Drawing.Size(42, 20);
            this.txtDisc.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(375, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "de";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(518, 135);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(68, 20);
            this.txtYear.TabIndex = 36;
            // 
            // txtDiscCountTrack
            // 
            this.txtDiscCountTrack.Location = new System.Drawing.Point(400, 310);
            this.txtDiscCountTrack.Name = "txtDiscCountTrack";
            this.txtDiscCountTrack.ReadOnly = true;
            this.txtDiscCountTrack.Size = new System.Drawing.Size(40, 20);
            this.txtDiscCountTrack.TabIndex = 39;
            // 
            // txtDiscTrack
            // 
            this.txtDiscTrack.Location = new System.Drawing.Point(327, 310);
            this.txtDiscTrack.Name = "txtDiscTrack";
            this.txtDiscTrack.ReadOnly = true;
            this.txtDiscTrack.Size = new System.Drawing.Size(42, 20);
            this.txtDiscTrack.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(375, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "de";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(286, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Track";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(293, 313);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "Disc";
            // 
            // btnStruct
            // 
            this.btnStruct.Location = new System.Drawing.Point(334, 336);
            this.btnStruct.Name = "btnStruct";
            this.btnStruct.Size = new System.Drawing.Size(58, 23);
            this.btnStruct.TabIndex = 42;
            this.btnStruct.Text = "...";
            this.btnStruct.UseVisualStyleBackColor = true;
            this.btnStruct.Click += new System.EventHandler(this.btnStruct_Click);
            // 
            // txtAlbumId
            // 
            this.txtAlbumId.Location = new System.Drawing.Point(444, 135);
            this.txtAlbumId.Name = "txtAlbumId";
            this.txtAlbumId.ReadOnly = true;
            this.txtAlbumId.Size = new System.Drawing.Size(68, 20);
            this.txtAlbumId.TabIndex = 43;
            // 
            // frmAlbumCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 371);
            this.Controls.Add(this.txtAlbumId);
            this.Controls.Add(this.btnStruct);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDiscCountTrack);
            this.Controls.Add(this.txtDiscTrack);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtDiscCount);
            this.Controls.Add(this.txtDisc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.txtArtists);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTrackCount);
            this.Controls.Add(this.txtTrack);
            this.Controls.Add(this.de);
            this.Controls.Add(this.chkCopiar);
            this.Controls.Add(this.btnSelectGitHubFolder);
            this.Controls.Add(this.txtGitHubFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectMusicFolder);
            this.Controls.Add(this.txtURLName);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.txtAlbumArtist);
            this.Controls.Add(this.txtAlbum);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.listSong);
            this.Controls.Add(this.btnAnalizar);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAlbumCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlbumCreator";
            this.Load += new System.EventHandler(this.frmAlbumCreator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Button btnAnalizar;
        private System.Windows.Forms.ListBox listSong;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.TextBox txtAlbumArtist;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.TextBox txtURLName;
        private System.Windows.Forms.Button btnSelectMusicFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGitHubFolder;
        private System.Windows.Forms.Button btnSelectGitHubFolder;
        private System.Windows.Forms.CheckBox chkCopiar;
        private System.Windows.Forms.Label de;
        private System.Windows.Forms.TextBox txtTrack;
        private System.Windows.Forms.TextBox txtTrackCount;
        private System.Windows.Forms.TextBox txtArtists;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtDiscCount;
        private System.Windows.Forms.TextBox txtDisc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtDiscCountTrack;
        private System.Windows.Forms.TextBox txtDiscTrack;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnStruct;
        private System.Windows.Forms.TextBox txtAlbumId;
    }
}