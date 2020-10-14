namespace DisMu_UI
{
    partial class DisMuMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.playlistListView = new MaterialSkin.Controls.MaterialListView();
            this.textFieldPlaylistName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.colPlaylists = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEdit = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // playlistListView
            // 
            this.playlistListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playlistListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPlaylists});
            this.playlistListView.Depth = 0;
            this.playlistListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playlistListView.FullRowSelect = true;
            this.playlistListView.GridLines = true;
            this.playlistListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.playlistListView.HideSelection = false;
            this.playlistListView.Location = new System.Drawing.Point(0, 63);
            this.playlistListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.playlistListView.MouseState = MaterialSkin.MouseState.OUT;
            this.playlistListView.Name = "playlistListView";
            this.playlistListView.OwnerDraw = true;
            this.playlistListView.Size = new System.Drawing.Size(525, 493);
            this.playlistListView.TabIndex = 0;
            this.playlistListView.UseCompatibleStateImageBehavior = false;
            this.playlistListView.View = System.Windows.Forms.View.Details;
            this.playlistListView.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.playlistListView_ItemMouseHover);
            this.playlistListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.playlistListView_ItemSelectionChanged);
            // 
            // textFieldPlaylistName
            // 
            this.textFieldPlaylistName.Depth = 0;
            this.textFieldPlaylistName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFieldPlaylistName.Hint = "";
            this.textFieldPlaylistName.Location = new System.Drawing.Point(170, 78);
            this.textFieldPlaylistName.MaxLength = 32767;
            this.textFieldPlaylistName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textFieldPlaylistName.Name = "textFieldPlaylistName";
            this.textFieldPlaylistName.PasswordChar = '\0';
            this.textFieldPlaylistName.SelectedText = "";
            this.textFieldPlaylistName.SelectionLength = 0;
            this.textFieldPlaylistName.SelectionStart = 0;
            this.textFieldPlaylistName.Size = new System.Drawing.Size(311, 23);
            this.textFieldPlaylistName.TabIndex = 2;
            this.textFieldPlaylistName.TabStop = false;
            this.textFieldPlaylistName.UseSystemPasswordChar = false;
            this.textFieldPlaylistName.Visible = false;
            // 
            // colPlaylists
            // 
            this.colPlaylists.Text = "Playlists";
            this.colPlaylists.Width = 525;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.Depth = 0;
            this.btnEdit.Icon = null;
            this.btnEdit.Location = new System.Drawing.Point(131, 65);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Primary = false;
            this.btnEdit.Size = new System.Drawing.Size(32, 36);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "...";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Depth = 0;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(488, 65);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Primary = false;
            this.btnAdd.Size = new System.Drawing.Size(29, 36);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // DisMuMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 559);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.textFieldPlaylistName);
            this.Controls.Add(this.playlistListView);
            this.Name = "DisMuMain";
            this.Text = "DisMu";
            this.Load += new System.EventHandler(this.DisMuMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView playlistListView;
        private MaterialSkin.Controls.MaterialSingleLineTextField textFieldPlaylistName;
        private System.Windows.Forms.ColumnHeader colPlaylists;
        private MaterialSkin.Controls.MaterialFlatButton btnEdit;
        private MaterialSkin.Controls.MaterialFlatButton btnAdd;
    }
}

