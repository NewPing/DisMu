using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace DisMu_UI
{
    public partial class DisMuMain : MaterialForm
    {
        public DisMuMain()
        {
            InitializeComponent();

            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;

            skinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue600,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void DisMuMain_Load(object sender, EventArgs e)
        {
        // --- Just for testing purpose: ---
            for (int i = 1; i < 4; i++)
            {
                var playlist = new Playlist("Playlist" + i);
                for (int j = 1; j < 11; j++)
                {
                    var title = new Title("title" + j);
                    playlist.Titles.Add(title);
                }
                DisMuManager.getInstance().Playlists.Add(playlist);
            }
            // ---------------------------------

            /*
            foreach (var playlist in DisMuManager.getInstance().Playlists)
            {
                Console.WriteLine(playlist.Id +": " + playlist.Name);
                foreach (var title in playlist.Titles)
                {

                    Console.WriteLine(title.Id + ": " + title.Name);
                }
                Console.WriteLine("-----");
            }
            */


            loadListViewPlaylist();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnAdd.Visible == false)
            {
                btnEdit.Text = "X";
                btnAdd.Visible = true;
                textFieldPlaylistName.Visible = true;
            }
            else
            {
                btnEdit.Text = "...";
                btnAdd.Visible = false;
                textFieldPlaylistName.Visible = false;
            }
        }

        private void loadListViewPlaylist()
        {
            playlistListView.Items.Clear();
            foreach (var playlist in DisMuManager.getInstance().Playlists)
            {
                var item = new ListViewItem(playlist.Name, playlist.Id);
                playlistListView.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var playlist = new Playlist();
            if (textFieldPlaylistName.Text != "") playlist.Name = textFieldPlaylistName.Text;
            DisMuManager.getInstance().Playlists.Add(playlist);
            loadListViewPlaylist();
        }

        private void playlistListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            Console.WriteLine(e.Item.Text);
        }

        private void playlistListView_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            
        }
    }
}
