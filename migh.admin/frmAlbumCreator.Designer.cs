﻿namespace migh.admin
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
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.txtURLName = new System.Windows.Forms.TextBox();
            this.btnSelectMusicFolder = new System.Windows.Forms.Button();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGitHubFolder = new System.Windows.Forms.TextBox();
            this.btnSelectGitHubFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carpeta";
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
            this.btnAnalizar.Location = new System.Drawing.Point(252, 288);
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
            this.listSong.Size = new System.Drawing.Size(234, 238);
            this.listSong.TabIndex = 5;
            this.listSong.SelectedIndexChanged += new System.EventHandler(this.listSong_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Location = new System.Drawing.Point(398, 288);
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
            this.label5.Location = new System.Drawing.Point(285, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Artista";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Archivo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nombre URL";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(327, 83);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(261, 20);
            this.txtName.TabIndex = 16;
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(327, 109);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(261, 20);
            this.txtAlbum.TabIndex = 17;
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(327, 135);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(261, 20);
            this.txtArtist.TabIndex = 18;
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(327, 161);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(261, 20);
            this.txtFile.TabIndex = 19;
            // 
            // txtURLName
            // 
            this.txtURLName.Location = new System.Drawing.Point(327, 187);
            this.txtURLName.Name = "txtURLName";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "GitHub";
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
            // frmAlbumCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 323);
            this.Controls.Add(this.btnSelectGitHubFolder);
            this.Controls.Add(this.txtGitHubFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectMusicFolder);
            this.Controls.Add(this.txtURLName);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.txtArtist);
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
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.TextBox txtURLName;
        private System.Windows.Forms.Button btnSelectMusicFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGitHubFolder;
        private System.Windows.Forms.Button btnSelectGitHubFolder;
    }
}