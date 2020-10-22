namespace DisMu_UI
{
    partial class DisMu_Main
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
            this.layoutBase = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.layoutBottom = new System.Windows.Forms.TableLayoutPanel();
            this.lblCurrentTitle = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.TableLayoutPanel();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.leftSide = new DisMu_UI.Controls.LeftSide();
            this.rightSide = new DisMu_UI.Controls.RightSide();
            this.layoutBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.layoutBottom.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutBase
            // 
            this.layoutBase.ColumnCount = 1;
            this.layoutBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutBase.Controls.Add(this.splitContainer, 0, 0);
            this.layoutBase.Controls.Add(this.layoutBottom, 0, 1);
            this.layoutBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutBase.Location = new System.Drawing.Point(0, 0);
            this.layoutBase.Name = "layoutBase";
            this.layoutBase.RowCount = 2;
            this.layoutBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.layoutBase.Size = new System.Drawing.Size(684, 461);
            this.layoutBase.TabIndex = 0;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.leftSide);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.rightSide);
            this.splitContainer.Size = new System.Drawing.Size(684, 386);
            this.splitContainer.SplitterDistance = 228;
            this.splitContainer.TabIndex = 0;
            // 
            // layoutBottom
            // 
            this.layoutBottom.ColumnCount = 3;
            this.layoutBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layoutBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layoutBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layoutBottom.Controls.Add(this.panelBottom, 1, 0);
            this.layoutBottom.Controls.Add(this.lblCurrentTitle, 0, 0);
            this.layoutBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutBottom.Location = new System.Drawing.Point(0, 386);
            this.layoutBottom.Margin = new System.Windows.Forms.Padding(0);
            this.layoutBottom.Name = "layoutBottom";
            this.layoutBottom.RowCount = 1;
            this.layoutBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutBottom.Size = new System.Drawing.Size(684, 75);
            this.layoutBottom.TabIndex = 1;
            // 
            // lblCurrentTitle
            // 
            this.lblCurrentTitle.AutoSize = true;
            this.lblCurrentTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTitle.Location = new System.Drawing.Point(3, 0);
            this.lblCurrentTitle.Name = "lblCurrentTitle";
            this.lblCurrentTitle.Size = new System.Drawing.Size(221, 75);
            this.lblCurrentTitle.TabIndex = 0;
            this.lblCurrentTitle.Text = "Aktueller Titel";
            this.lblCurrentTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelBottom
            // 
            this.panelBottom.ColumnCount = 3;
            this.panelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelBottom.Controls.Add(this.btnPlayPause, 1, 0);
            this.panelBottom.Controls.Add(this.btnPrevious, 0, 0);
            this.panelBottom.Controls.Add(this.btnNext, 2, 0);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(230, 3);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.RowCount = 1;
            this.panelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelBottom.Size = new System.Drawing.Size(221, 69);
            this.panelBottom.TabIndex = 6;
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.BackColor = System.Drawing.Color.Brown;
            this.btnPlayPause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlayPause.FlatAppearance.BorderSize = 0;
            this.btnPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayPause.Location = new System.Drawing.Point(73, 0);
            this.btnPlayPause.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(73, 69);
            this.btnPlayPause.TabIndex = 0;
            this.btnPlayPause.Text = "Play";
            this.btnPlayPause.UseVisualStyleBackColor = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Salmon;
            this.btnPrevious.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Location = new System.Drawing.Point(0, 0);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(73, 69);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.OrangeRed;
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(146, 0);
            this.btnNext.Margin = new System.Windows.Forms.Padding(0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 69);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // leftSide
            // 
            this.leftSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftSide.Location = new System.Drawing.Point(0, 0);
            this.leftSide.Margin = new System.Windows.Forms.Padding(0);
            this.leftSide.Name = "leftSide";
            this.leftSide.Size = new System.Drawing.Size(228, 386);
            this.leftSide.TabIndex = 0;
            // 
            // rightSide
            // 
            this.rightSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightSide.Location = new System.Drawing.Point(0, 0);
            this.rightSide.Margin = new System.Windows.Forms.Padding(0);
            this.rightSide.Name = "rightSide";
            this.rightSide.Size = new System.Drawing.Size(452, 386);
            this.rightSide.TabIndex = 0;
            // 
            // DisMu_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.layoutBase);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "DisMu_Main";
            this.Text = "DisMu";
            this.Load += new System.EventHandler(this.DisMu_Main_Load);
            this.layoutBase.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.layoutBottom.ResumeLayout(false);
            this.layoutBottom.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutBase;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TableLayoutPanel layoutBottom;
        private Controls.LeftSide leftSide;
        private Controls.RightSide rightSide;
        public System.Windows.Forms.TableLayoutPanel panelBottom;
        public System.Windows.Forms.Button btnPlayPause;
        public System.Windows.Forms.Button btnPrevious;
        public System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblCurrentTitle;
    }
}

