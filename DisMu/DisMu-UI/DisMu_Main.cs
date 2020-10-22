using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DisMu_Base;
using DisMu_Base.Models;

namespace DisMu_UI
{
    public partial class DisMu_Main : Form
    {
        private Dictionary<int,Playlist> playlists;
        public DisMu_Main()
        {
            InitializeComponent();
            
        }

        private void DisMu_Main_Load(object sender, EventArgs e)
        {
            
            if ( LoadData() )
            {
                LoadListLeft();
            }
            
        }

        private bool LoadData()
        {
            var exData = new ExampleData();

            exData.addPlaylist("Playlist1");

            playlists = exData.playlists;

            return true;
        }

        private bool LoadListLeft()
        {
            LoadListStyle();
            
            foreach (var playlist in playlists)
            {
                var item = new ListViewItem();

                item.Text = playlist.Value.name;
                
                leftSide.listLeftSide.Items.Add(item);
            }
            
            return true;
        }

        private bool LoadListStyle()
        {
            var headerWidth = (leftSide.Width - 12);
            leftSide.listLeftSide.Columns.Add("", headerWidth, HorizontalAlignment.Left);
            leftSide.listLeftSide.FullRowSelect = true;
            leftSide.listLeftSide.View = View.Details;
            leftSide.listLeftSide.HeaderStyle = ColumnHeaderStyle.None;
            return true;
        }
    }
}
