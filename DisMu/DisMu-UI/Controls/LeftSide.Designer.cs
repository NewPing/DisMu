namespace DisMu_UI.Controls
{
    partial class LeftSide
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLeftSide = new System.Windows.Forms.TableLayoutPanel();
            this.labelTitleLeft = new System.Windows.Forms.Label();
            this.listLeftSide = new System.Windows.Forms.ListView();
            this.panelLeftSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeftSide
            // 
            this.panelLeftSide.BackColor = System.Drawing.SystemColors.Control;
            this.panelLeftSide.ColumnCount = 1;
            this.panelLeftSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelLeftSide.Controls.Add(this.labelTitleLeft, 0, 0);
            this.panelLeftSide.Controls.Add(this.listLeftSide, 0, 1);
            this.panelLeftSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeftSide.Location = new System.Drawing.Point(0, 0);
            this.panelLeftSide.Name = "panelLeftSide";
            this.panelLeftSide.RowCount = 2;
            this.panelLeftSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.panelLeftSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.panelLeftSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelLeftSide.Size = new System.Drawing.Size(782, 426);
            this.panelLeftSide.TabIndex = 2;
            // 
            // labelTitleLeft
            // 
            this.labelTitleLeft.AutoSize = true;
            this.labelTitleLeft.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.labelTitleLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitleLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleLeft.Location = new System.Drawing.Point(0, 0);
            this.labelTitleLeft.Margin = new System.Windows.Forms.Padding(0);
            this.labelTitleLeft.Name = "labelTitleLeft";
            this.labelTitleLeft.Size = new System.Drawing.Size(782, 42);
            this.labelTitleLeft.TabIndex = 0;
            this.labelTitleLeft.Text = "Playlists";
            this.labelTitleLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listLeftSide
            // 
            this.listLeftSide.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.listLeftSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listLeftSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLeftSide.HideSelection = false;
            this.listLeftSide.Location = new System.Drawing.Point(0, 42);
            this.listLeftSide.Margin = new System.Windows.Forms.Padding(0);
            this.listLeftSide.Name = "listLeftSide";
            this.listLeftSide.Size = new System.Drawing.Size(782, 384);
            this.listLeftSide.TabIndex = 1;
            this.listLeftSide.UseCompatibleStateImageBehavior = false;
            // 
            // LeftSide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelLeftSide);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "LeftSide";
            this.Size = new System.Drawing.Size(782, 426);
            this.panelLeftSide.ResumeLayout(false);
            this.panelLeftSide.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel panelLeftSide;
        public System.Windows.Forms.Label labelTitleLeft;
        public System.Windows.Forms.ListView listLeftSide;
    }
}
