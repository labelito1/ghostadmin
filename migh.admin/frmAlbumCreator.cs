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
using System.IO;
using TagLib;
using System.Web;
using System.Net;
using JsonTools;
using System.Drawing.Imaging;

namespace migh.admin
{
    public partial class frmAlbumCreator : Form
    {
        public frmAlbumCreator()
        {
            InitializeComponent();
        }
        public string localLastPath = "";
        private void frmAlbumCreator_Load(object sender, EventArgs e)
        {
            JsonFile file = new JsonFile();
            file.Directory = Application.StartupPath + "\\";
            file.FileName = "gh";
            txtGitHubFolder.Text = file.Read<string>();
            JsonFile file2 = new JsonFile();
            file2.Directory = Application.StartupPath + "\\";
            file2.FileName = "local";
            localLastPath = file2.Read<string>();
            folderBrowser.SelectedPath = localLastPath;
            txtDirectory.Text = localLastPath;
        }
        List<string> Covers = new List<string>();
        List<string> CoversSmall = new List<string>();
        List<string> Files = new List<string>();
        List<Song> songs = new List<Song>();
        List<Album> albums = new List<Album>();
        List<Artist> artists = new List<Artist>();

        private void btnCreate_Click(object sender, EventArgs e)
        {
            songs.Clear();
            albums.Clear();
            artists.Clear();
            listSong.Items.Clear();
            string directory = txtDirectory.Text.Trim();
            //songs = new List<Song>();
            Album album;
            Artist artist;
            string path = txtDirectory.Text.Trim();
            
            try
            {
                var d = Directory.GetFiles(path, "*.*", System.IO.SearchOption.AllDirectories).Where(s => s.EndsWith(".mp3") || s.EndsWith(".m4a")); 
            	foreach(string str in d)
            	{
                    artist = new Artist();
                    album = new Album();
            		TagLib.File tagfile = TagLib.File.Create(str);
            		try
            		{
            			Song song = new Song();
                        try
                        {
                            song.Track = tagfile.Tag.Track;
                            song.TrackCount = tagfile.Tag.TrackCount;
                            song.duration = tagfile.Properties.Duration;
                            song.JoinedPerformers = tagfile.Tag.JoinedPerformers;
                            album.year = tagfile.Tag.Year;
                            album.Disc = tagfile.Tag.Disc;
                            album.DiscCount = tagfile.Tag.DiscCount;
                            song.Disc = tagfile.Tag.Disc;
                            song.DiscCount = tagfile.Tag.DiscCount;
                            album.JoinedAlbumArtists = tagfile.Tag.JoinedAlbumArtists;
                        }
                        catch
                        {

                        }
                        if(tagfile.Tag.FirstAlbumArtist == null || tagfile.Tag.FirstAlbumArtist == string.Empty)
                        {
                            artist.name = tagfile.Tag.FirstPerformer;
                        }
                        else
                        {
                        	artist.name = tagfile.Tag.FirstAlbumArtist;
                        }
                        
                        Artist art = admin.Library.artist_list.FirstOrDefault(a => a.name.ToLower().Equals(artist.name.ToLower()));
                        if(art != null)
                        {
                            artist = art;
                        }
                        else
                        {
                            Artist artx = artists.FirstOrDefault(a => a.name.ToLower().Equals(artist.name.ToLower()));
                            if (artx != null)
                            {
                                artist = artx;
                            }
                            else
                            {
                                artist.url_name = Tools.ConvertToGitHubFolder(artist.name);
                                List<int> artist_ids = new List<int>();
                                foreach (Artist ar in admin.Library.artist_list)
                                {
                                    artist_ids.Add(ar.id);
                                }
                                foreach (Artist ar2 in artists)
                                {
                                    artist_ids.Add(ar2.id);
                                }
                                while (artist_ids.Contains(artist.id))
                                {
                                    artist.id++;
                                }
                                Artist _artist = admin.Library.artist_list.FirstOrDefault(a => a.id == artist.id && a.name.ToLower().Equals(artist.name.ToLower()));
                                if (_artist == null)
                                {
                                    _artist = artists.FirstOrDefault(a => a.id == artist.id && a.name.ToLower().Equals(artist.name.ToLower()));
                                }
                                if (_artist == null)
                                {
                                    artists.Add(artist);
                                }
                                
                            }
                        }
                        
                        Album alb = admin.Library.album_list.FirstOrDefault(a => a.name.ToLower().Equals(tagfile.Tag.Album.ToLower()) && a.artist_id == artist.id);
                        if (alb != null)
                        {
                            album = alb;
                        }
                        else
                        {
                            Album albx = albums.FirstOrDefault(a => a.name.ToLower().Equals(tagfile.Tag.Album.ToLower()));
                            if (albx != null)
                            {
                                album = albx;
                            }
                            else
                            {
                                album.name = tagfile.Tag.Album;
                                album.url_name = Tools.ConvertToGitHubFolder(album.name);
                                album.artist_id = artist.id;
                                album.cover_url = string.Format(admin.Library.configuration.AlbumCoverImageFileURLFormat, artist.url_name, album.url_name);
                                album.url_name = Tools.ConvertToGitHubFolder(album.name);

                                List<int> album_ids = new List<int>();
                                foreach (Album al in admin.Library.album_list)
                                {
                                    album_ids.Add(al.id);
                                }
                                foreach (Album al2 in albums)
                                {
                                    album_ids.Add(al2.id);
                                }
                                while (album_ids.Contains(album.id))
                                {
                                    album.id++;
                                }
                                Album _album = admin.Library.album_list.FirstOrDefault(a => a.artist_id == album.artist_id && a.id == album.id && a.name.ToLower().Equals(album.name.ToLower()));
                                if (_album == null)
                                {
                                    _album = albums.FirstOrDefault(a => a.artist_id == album.artist_id && a.id == album.id && a.name.ToLower().Equals(album.name.ToLower()));
                                }
                                if (_album == null)
                                {
                                    albums.Add(album);
                                }
                                
                            }
                        }
                        List<int> ids = new List<int>();
                        foreach(Song so in admin.Library.song_list)
                        {
                            ids.Add(so.id);
                        }
                        foreach (Song so2 in songs)
                        {
                            ids.Add(so2.id);
                        }
                        while (ids.Contains(song.id))
                        {
                            song.id++;
                        }

                        song.artist_id = artist.id;
                        song.album_id = album.id;
                        song.name = tagfile.Tag.Title;
                        song.file_name = Path.GetFileName(str);
                        song.url_name = Song.getFileFormat(song);

                        Files.Add(str);
                        Song _song = admin.Library.song_list.FirstOrDefault(s => s.artist_id == song.artist_id && s.album_id == song.album_id && s.name.ToLower().Equals(song.name.ToLower()));
                        if(_song == null)
                        {
                            _song = songs.FirstOrDefault(s => s.artist_id == song.artist_id && s.album_id == song.album_id && s.name.ToLower().Equals(song.name.ToLower()));
                        }
                        if(_song == null)
                        {
                            songs.Add(song);
                        }
                        
                        if (tagfile.Tag.Pictures.Length >= 1)
                        {
                            var bin = (byte[])(tagfile.Tag.Pictures[0].Data.Data);
                            try
                            {
                                string filepath = txtGitHubFolder.Text + "/covers/" + Tools.ConvertToGitHubFolder(artist.name) + "/" + Tools.ConvertToGitHubFolder(album.name);
                                if(!Directory.Exists(filepath))
                                {
                                    Directory.CreateDirectory(filepath);
                                }
                                using (var fs = new FileStream(filepath + "/Cover.jpg", FileMode.Create, FileAccess.Write))
                                {
                                    fs.Write(bin, 0, bin.Length);
                                }
                                Image img;
                                using (var ms = new MemoryStream(bin))
                                {
                                    img = Image.FromStream(ms);
                                }
                                Bitmap bmp = Tools.ResizeImage(img, 250, 250);
                                bmp.Save(filepath + "/CoverSmall.jpg", ImageFormat.Jpeg);
                            }
                            catch (Exception ex)
                            {

                            }
                        }
            		}
            		catch(Exception ex)
            		{
            			MessageBox.Show(ex.Message);
            		}
            	}
            	foreach (Song s in songs)
                {
                    listSong.Items.Add(s);
                }
            }
           catch
           {
           	
           }
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Estás seguro?", "Guardar Canciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    foreach(Artist artist in artists)
                    {
                        admin.Library.artist_list.Add(artist);
                    }
                    foreach (Album album in albums)
                    {
                        admin.Library.album_list.Add(album);
                    }
                    foreach (Song song in songs)
                    {
                        if(!admin.Library.song_list.Contains(song))
                        {
                            admin.Library.song_list.Add(song);
                        }
                    }
                    if (!Directory.Exists(txtGitHubFolder.Text))
                    {
                        folderBrowser.ShowDialog();
                        {
                            if (folderBrowser.SelectedPath != string.Empty)
                            {
                                txtGitHubFolder.Text = folderBrowser.SelectedPath;
                                JsonFile file = new JsonFile();
                                file.Directory = Application.StartupPath + "\\";
                                file.FileName = "gh";
                                JsonFileResponse r = file.Write(txtGitHubFolder.Text.Trim());
                            }
                        }
                    }
                    int i = 0;
                    if(chkCopiar.Checked)
                    {
                        foreach (Song s in songs)
                        {
                            Artist a = Artist.get(admin.Library.artist_list, s.artist_id);
                            Album al = Album.get(admin.Library.album_list, s.album_id);
                            if (!Directory.Exists(txtGitHubFolder.Text + "\\" + Tools.ConvertToGitHubFolder(a.name)))
                            {
                                Directory.CreateDirectory(txtGitHubFolder.Text + "\\" + Tools.ConvertToGitHubFolder(a.name));
                            }
                            if (!Directory.Exists(txtGitHubFolder.Text + "\\" + Tools.ConvertToGitHubFolder(a.name) + "\\" + Tools.ConvertToGitHubFolder(al.name)))
                            {
                                Directory.CreateDirectory(txtGitHubFolder.Text + "\\" + Tools.ConvertToGitHubFolder(a.name) + "\\" + Tools.ConvertToGitHubFolder(al.name));
                            }
                            //opus
                            if (!Directory.Exists(txtGitHubFolder.Text + "\\opus\\" + Tools.ConvertToGitHubFolder(a.name) + "\\" + Tools.ConvertToGitHubFolder(al.name)))
                            {
                                Directory.CreateDirectory(txtGitHubFolder.Text + "\\opus\\" + Tools.ConvertToGitHubFolder(a.name) + "\\" + Tools.ConvertToGitHubFolder(al.name));
                            }
                            //if (!System.IO.File.Exists(txtGitHubFolder.Text + "\\" + Tools.ConvertToGitHubFolder(a.name) + "\\" + Tools.ConvertToGitHubFolder(al.name) + "\\Cover.jpg"))
                            //{
                            //    if (System.IO.File.Exists(Covers[i]))
                            //    {
                            //        System.IO.File.Copy(Covers[i], txtGitHubFolder.Text + "\\" + Tools.ConvertToGitHubFolder(a.name) + "\\" + Tools.ConvertToGitHubFolder(al.name) + "\\Cover.jpg");
                            //    }
                            //}
                            //if (!System.IO.File.Exists(txtGitHubFolder.Text + "\\" + Tools.ConvertToGitHubFolder(a.name) + "\\" + Tools.ConvertToGitHubFolder(al.name) + "\\CoverSmall.jpg"))
                            //{
                            //    if (System.IO.File.Exists(CoversSmall[i]))
                            //    {
                            //        System.IO.File.Copy(CoversSmall[i], txtGitHubFolder.Text + "\\" + Tools.ConvertToGitHubFolder(a.name) + "\\" + Tools.ConvertToGitHubFolder(al.name) + "\\CoverSmall.jpg");
                            //    }
                            //}
                            string tn = "";
                            if(s.Track > 0)
                            {
                                if (s.Track < 10)
                                {
                                    tn = "0" + s.Track;
                                }
                                else
                                {
                                    tn = s.Track.ToString();
                                }
                            }
                            
                            System.IO.File.Copy(Files[i], txtGitHubFolder.Text + "\\" + Tools.ConvertToGitHubFolder(a.name) + "\\" + Tools.ConvertToGitHubFolder(al.name) + "\\" + Song.getFileFormat(s));
                            i++;
                        }
                    }
                    
                    this.DialogResult = DialogResult.OK;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    
                }
            }
        }

        private void txtDirectory_TextChanged(object sender, EventArgs e)
        {
            if(Directory.Exists(txtDirectory.Text.Trim()))
            {
                btnAnalizar.Enabled = true;
            }
            else
            {
                btnAnalizar.Enabled = false;
            }
        }

        private void listSong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listSong.SelectedItems.Count > 0)
            {
                try
                {
                    Song song = (Song)listSong.SelectedItem;
                    Album album = Album.get(albums, song.album_id);
                    if (album == null)
                    {
                        album = Album.get(admin.Library.album_list, song.album_id);
                    }
                    Artist artist = Artist.get(artists, song.artist_id);
                    if (artist == null)
                    {
                        artist = Artist.get(admin.Library.artist_list, song.artist_id);
                    }
                    txtName.Text = song.name;
                    txtAlbum.Text = album.name;
                    txtAlbumArtist.Text = artist.name;
                    txtArtists.Text = song.JoinedPerformers;
                    txtTrack.Text = song.Track.ToString();
                    txtDuration.Text = song.duration.ToString("mm\\:ss");
                    txtDisc.Text = album.Disc.ToString();
                    txtDiscCount.Text = album.DiscCount.ToString();
                    txtTrackCount.Text = song.TrackCount.ToString();
                    txtFile.Text = song.file_name;
                    txtURLName.Text = song.url_name;
                    txtYear.Text = album.year.ToString();
                    txtDiscTrack.Text = song.Disc.ToString();
                    txtDiscCountTrack.Text = song.DiscCount.ToString();
                    txtAlbumId.Text = album.id.ToString();
                }
                catch
                {
                    //txtName.Text = "";
                    //txtAlbum.Text = "";
                    //txtAlbumArtist.Text = "";
                    //txtFile.Text = "";
                    //txtURLName.Text = "";
                    txtName.Text = "";
                    txtAlbum.Text = "";
                    txtAlbumArtist.Text = "";
                    txtArtists.Text = "";
                    txtTrack.Text = "";
                    txtDuration.Text = "";
                    txtDisc.Text = "";
                    txtDiscCount.Text = "";
                    txtTrackCount.Text = "";
                    txtFile.Text = "";
                    txtURLName.Text = "";
                    txtDiscTrack.Text = "";
                    txtDiscCountTrack.Text = "";
                    txtAlbumId.Text = "";
                }
            }
            else
            {
                txtName.Text = "";
                txtAlbum.Text = "";
                txtAlbumArtist.Text = "";
                txtArtists.Text = "";
                txtTrack.Text = "";
                txtDuration.Text = "";
                txtDisc.Text = "";
                txtDiscCount.Text = "";
                txtTrackCount.Text = "";
                txtFile.Text = "";
                txtURLName.Text = "";
                txtDiscTrack.Text = "";
                txtDiscCountTrack.Text = "";
                txtAlbumId.Text = "";
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            folderBrowser.SelectedPath = localLastPath;
            //folderBrowser.RootFolder = Environment.SpecialFolder.MyDocuments;
            if(folderBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (folderBrowser.SelectedPath != string.Empty)
                {
                    txtDirectory.Text = folderBrowser.SelectedPath;
                    JsonFile file = new JsonFile();
                    file.Directory = Application.StartupPath + "\\";
                    file.FileName = "local";
                    JsonFileResponse r = file.Write(txtDirectory.Text.Trim());
                }
            }
            
        }
        
        private void btnSelectGitHubFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if(folderBrowser.SelectedPath != string.Empty)
                {
                    txtGitHubFolder.Text = folderBrowser.SelectedPath;
                    JsonFile file = new JsonFile();
                    file.Directory = Application.StartupPath + "\\";
                    file.FileName = "gh";
                    JsonFileResponse r = file.Write(txtGitHubFolder.Text.Trim());
                }
            }
        }

        private void btnStruct_Click(object sender, EventArgs e)
        {
            if(folderBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if(folderBrowser.SelectedPath != "")
                {
                    foreach(Album album in admin.Library.album_list)
                    {
                        Artist artist = admin.Library.artist_list.FirstOrDefault(a => a.id == album.artist_id);
                        string dir = folderBrowser.SelectedPath + "/" + Tools.ConvertToGitHubFolder(artist.name) + "/" + Tools.ConvertToGitHubFolder(album.name);
                        if (!Directory.Exists(dir))
                        {
                            Directory.CreateDirectory(dir);
                        }
                    }
                }
            }
        }
    }
}
