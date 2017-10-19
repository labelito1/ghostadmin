using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using migh.api;
using JsonTools;
using simple.ftp;
using System.IO;
namespace migh.admin
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            admin.Library = (Library.read_local(Configuration.LibraryFileName)).ToObject<Library>();
            //Configuration.Load();
            RefreshComboWebFile();
            SessionVersion = admin.Library.Version + 1;
            lblVersion.Text = "Versión: " + admin.Library.Version;
            lblSessionVersion.Text = "Sesión: " + SessionVersion;
        }

        private void RefreshComboWebFile()
        {
            cbxWebFile.Items.Add("Default");
            foreach (WebFile webfile in admin.Library.configuration.WebFile_List)
            {
                if (webfile.FTP)
                {
                    cbxWebFile.Items.Add(webfile);
                }
            }
            if (cbxWebFile.Items.Count > 1)
            {
                cbxWebFile.SelectedIndex = 1;
            }
        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            frmUser frm = new frmUser();
            frm.ShowDialog();
        }

        private void btnArtist_Click(object sender, EventArgs e)
        {
            frmArtist frm = new frmArtist();
            frm.ShowDialog();
        }

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            frmAlbum frm = new frmAlbum();
            frm.ShowDialog();
        }

        private void btnSong_Click(object sender, EventArgs e)
        {
            frmSong frm = new frmSong();
            frm.ShowDialog();
        }
        int SessionVersion = 0;


        class newArtist
        {
            public int id { get; set; }
            public string name { get; set; }
            public string image { get; set; }
            public string image_small { get; set; }
        }
        class 
            newAlbum
        {
            public int id { get; set; }
            public string title { get; set; }
            public string artist { get; set; }
            public string cover { get; set; }
            public string cover_small { get; set; }
            public int year { get; set; }
            public int artist_id { get; set; }
        }
        class newTrack
        {
            public int id { get; set; }
            public string title { get; set; }
            public string artist { get; set; }
            public string JoinedPerformers { get; set; }
            public string album { get; set; }
            public string duration { get; set; }
            public int tracknumber { get; set; }
            public int album_id { get; set; }
            public int artist_id { get; set; }
            public string hq_src { get; set; }
            public string mq_src { get; set; }
            public string lq_src { get; set; }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            admin.Library.Version = SessionVersion;
            //admin.Library.configuration = Configuration.Data;
            Library.write_local(admin.Library, Configuration.LibraryFileName);

            List<newArtist> artist_list = new List<newArtist>();
            foreach (Artist art in admin.Library.artist_list)
            {
                newArtist newart = new newArtist();
                newart.id = art.id;
                newart.name = art.name;
                newart.image = string.Format("https://github.com/ghostapphd/artistimages/blob/master/{0}/image.jpg?raw=true", Tools.ConvertToGitHubFolder(art.name));
                newart.image_small = string.Format("https://github.com/ghostapphd/artistimages/blob/master/{0}/imagesmall.jpg?raw=true", Tools.ConvertToGitHubFolder(art.name));
                artist_list.Add(newart);
            }
            File.WriteAllText(Environment.CurrentDirectory + "/ghost-artists.json", artist_list.OrderBy(a => a.name).ToJsonString());

            List<newAlbum> album_list = new List<newAlbum>();
            
            foreach (Artist _art in admin.Library.artist_list)
            {
                List<Album> albums = admin.Library.album_list.Where(_a_ => _a_.artist_id == _art.id).ToList<Album>();
                List<newAlbum> x = new List<newAlbum>();
                foreach (Album alb in albums)
                {
                    newAlbum newalb = new newAlbum();
                    Artist art = admin.Library.artist_list.FirstOrDefault(ar => ar.id == alb.artist_id);


                    newalb.id = alb.id;
                    newalb.title = alb.name;
                    newalb.artist = art.name;
                    newalb.cover = string.Format(admin.Library.configuration.AlbumCoverImageFileURLFormat, Tools.ConvertToGitHubFolder(art.name), Tools.ConvertToGitHubFolder(alb.name));
                    newalb.cover_small = string.Format(admin.Library.configuration.AlbumCoverImageFileURLFormat.Replace("Cover.jpg", "CoverSmall.jpg"), Tools.ConvertToGitHubFolder(art.name), Tools.ConvertToGitHubFolder(alb.name));
                    newalb.year = Convert.ToInt32(alb.year);
                    newalb.artist_id = alb.artist_id;
                    x.Add(newalb);
                }
                x = x.OrderByDescending(xd => xd.year).ToList<newAlbum>();
                foreach (newAlbum tal in x)
                {
                    album_list.Add(tal);
                }
            }

            int ab = 1;
            File.WriteAllText(Environment.CurrentDirectory + "/ghost-albums.json", album_list.ToJsonString());

            List<newTrack> track_list = new List<newTrack>();
            foreach (Song sng in admin.Library.song_list)
            {
                newTrack newt = new newTrack();
                Artist art = admin.Library.artist_list.FirstOrDefault(ar => ar.id == sng.artist_id);
                Album alb = admin.Library.album_list.FirstOrDefault(al => al.id == sng.album_id);
                newt.id = sng.id;
                newt.title = sng.name;
                newt.artist = art.name;
                newt.JoinedPerformers = sng.JoinedPerformers.Replace(";", ",");
                newt.album = alb.name;
                newt.duration = sng.duration.ToString("mm\\:ss");
                newt.tracknumber = Convert.ToInt32(sng.Track);
                newt.album_id = sng.album_id;
                newt.artist_id = sng.artist_id;
                newt.hq_src = string.Format("https://raw.githubusercontent.com/ghostapphd/{0}/master/{1}/{2}.m4a", Tools.ConvertToGitHubFolder(art.name), Tools.ConvertToGitHubFolder(alb.name), Song.getFileFormat(sng));
                newt.mq_src = string.Format("https://raw.githubusercontent.com/ghostapphdmq/{0}/master/{1}/{2}.mp3", Tools.ConvertToGitHubFolder(art.name), Tools.ConvertToGitHubFolder(alb.name), Song.getFileFormat(sng));
                newt.lq_src = string.Format("https://raw.githubusercontent.com/ghostapphdlq/{0}/master/{1}/{2}.opus", Tools.ConvertToGitHubFolder(art.name), Tools.ConvertToGitHubFolder(alb.name), Song.getFileFormat(sng));
                track_list.Add(newt);
            }
            File.WriteAllText(Environment.CurrentDirectory + "/ghost-tracks.json", track_list.OrderBy(t => t.tracknumber).ToJsonString());

            MessageBox.Show("Guardado");
            if (chkSubir.Checked)
            {
                string WebFile = cbxWebFile.Text;
                BackgroundWorker worker = new BackgroundWorker() { WorkerReportsProgress = true };

                worker.DoWork += delegate(object s, DoWorkEventArgs args)
                {
                    try
                    {
                        WebFile wf = admin.Library.configuration.WebFile_List.Single(w => w.Name.Equals(WebFile));
                        ftp.Upload(Configuration.LibraryFileName, wf.URL, wf.Credentials.UserName, Tools.DecodeStringFromBase64(wf.Credentials.Password));
                        args.Result = "Archivo subido";
                    }
                    catch (Exception ex)
                    {
                        args.Result = ex.Message;
                    }
                };

                worker.RunWorkerCompleted += delegate(object s, RunWorkerCompletedEventArgs args)
                {
                    MessageBox.Show(args.Result.ToString(), "Guardar y subir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };
                worker.RunWorkerAsync();
            }
            
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Estás seguro?", "Descargar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(cbxWebFile.Text == "Default")
                {
                    Library l = new Library("ftp://migh.somee.com/www.migh.somee.com/migh/migh.lib", "eduardohley", "@Poder123");
                    Library.write_local(l, Configuration.LibraryFileName);
                    return;
                }
                WebFile wf = (WebFile)cbxWebFile.SelectedItem;
                Library lib = new Library(wf.URL, wf.Credentials.UserName, Tools.DecodeStringFromBase64(wf.Credentials.Password));
                Library.write_local(lib, Configuration.LibraryFileName);
            }
        }

        private void btnConfiguration_Click(object sender, EventArgs e)
        {
            frmConfiguration frm = new frmConfiguration();
            frm.ShowDialog();
            if(frm.DialogResult == DialogResult.OK)
            {
                RefreshComboWebFile();
            }
        }

        private void lblVersion_Click(object sender, EventArgs e)
        {
            try
            {
                WebFile wf = (WebFile)cbxWebFile.SelectedItem;
                Library lib = new Library(wf.URL, wf.Credentials.UserName, Tools.DecodeStringFromBase64(wf.Credentials.Password));
                MessageBox.Show("Versión en línea: " + lib.Version, "Versión", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                
            }
        }

        private void txtPIN_TextChanged(object sender, EventArgs e)
        {
            if(txtPIN.Text == "::0437")
            {
                btnDownload.Enabled = true;
                btnSave.Enabled = true;
                btnConfiguration.Enabled = true;
                txtPIN.Visible = false;
            }
            if (txtPIN.Text == "::clear")
            {
                admin.Library.song_list.Clear();
                admin.Library.album_list.Clear();
                admin.Library.artist_list.Clear();
                MessageBox.Show("Clear", "Clear");
            }
        }
        public static string ServerURL = "";
        private void txtServer_TextChanged(object sender, EventArgs e)
        {
            ServerURL = txtServer.Text;
        }

        private void btnAlbumCreator_Click(object sender, EventArgs e)
        {
            frmAlbumCreator frm = new frmAlbumCreator();
            frm.ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var window = MessageBox.Show("¿Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = window == System.Windows.Forms.DialogResult.No;
        }
    }
}
