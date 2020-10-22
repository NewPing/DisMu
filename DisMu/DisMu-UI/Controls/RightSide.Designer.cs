namespace DisMu_UI.Controls
{
    partial class RightSide
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
            this.panelRightSide = new System.Windows.Forms.TableLayoutPanel();
            this.labelTitleRight = new System.Windows.Forms.Label();
            this.listRightSide = new System.Windows.Forms.ListView();
            this.panelRightSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRightSide
            // 
            this.panelRightSide.BackColor = System.Drawing.SystemColors.Control;
            this.panelRightSide.ColumnCount = 1;
            this.panelRightSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelRightSide.Controls.Add(this.labelTitleRight, 0, 0);
            this.panelRightSide.Controls.Add(this.listRightSide, 0, 1);
            this.panelRightSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRightSide.Location = new System.Drawing.Point(0, 0);
            this.panelRightSide.Name = "panelRightSide";
            this.panelRightSide.RowCount = 2;
            this.panelRightSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.panelRightSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.panelRightSide.Size = new System.Drawing.Size(857, 614);
            this.panelRightSide.TabIndex = 3;
            // 
            // labelTitleRight
            // 
            this.labelTitleRight.AutoSize = true;
            this.labelTitleRight.BackColor = System.Drawing.Color.Navy;
            this.labelTitleRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitleRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleRight.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelTitleRight.Location = new System.Drawing.Point(0, 0);
            this.labelTitleRight.Margin = new System.Windows.Forms.Padding(0);
            this.labelTitleRight.Name = "labelTitleRight";
            this.labelTitleRight.Size = new System.Drawing.Size(857, 61);
            this.labelTitleRight.TabIndex = 0;
            this.labelTitleRight.Text = "Songpool";
            this.labelTitleRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listRightSide
            // 
            this.listRightSide.BackColor = System.Drawing.SystemColors.HotTrack;
            this.listRightSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listRightSide.HideSelection = false;
            this.listRightSide.Location = new System.Drawing.Point(0, 61);
            this.listRightSide.Margin = new System.Windows.Forms.Padding(0);
            this.listRightSide.Name = "listRightSide";
            this.listRightSide.Size = new System.Drawing.Size(857, 553);
            this.listRightSide.TabIndex = 1;
            this.listRightSide.UseCompatibleStateImageBehavior = false;
            // 
            // RightSide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelRightSide);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "RightSide";
            this.Size = new System.Drawing.Size(857, 614);
            this.panelRightSide.ResumeLayout(false);
            this.panelRightSide.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel panelRightSide;
        public System.Windows.Forms.Label labelTitleRight;
        public System.Windows.Forms.ListView listRightSide;
    }
}
