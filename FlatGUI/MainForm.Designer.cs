namespace FlatGUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSerials = new System.Windows.Forms.Button();
            this.btnFilms = new System.Windows.Forms.Button();
            this.lineMenu = new FlatGUI.MyLine();
            this.labelMenu = new System.Windows.Forms.Label();
            this.panelBar = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.iconMinimize = new System.Windows.Forms.PictureBox();
            this.iconMaximize = new System.Windows.Forms.PictureBox();
            this.iconRestore = new System.Windows.Forms.PictureBox();
            this.iconClose = new System.Windows.Forms.PictureBox();
            this.iconMenu = new System.Windows.Forms.PictureBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.SystemTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.развернутьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMenu.SuspendLayout();
            this.panelBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMenu)).BeginInit();
            this.contextMenuTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.btnSerials);
            this.panelMenu.Controls.Add(this.btnFilms);
            this.panelMenu.Controls.Add(this.lineMenu);
            this.panelMenu.Controls.Add(this.labelMenu);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 650);
            this.panelMenu.TabIndex = 0;
            // 
            // btnSerials
            // 
            this.btnSerials.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSerials.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSerials.FlatAppearance.BorderSize = 0;
            this.btnSerials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerials.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSerials.Location = new System.Drawing.Point(11, 116);
            this.btnSerials.Name = "btnSerials";
            this.btnSerials.Size = new System.Drawing.Size(180, 50);
            this.btnSerials.TabIndex = 3;
            this.btnSerials.Text = "Сериалы";
            this.btnSerials.UseVisualStyleBackColor = true;
            this.btnSerials.Click += new System.EventHandler(this.BtnSerials_Click);
            // 
            // btnFilms
            // 
            this.btnFilms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilms.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFilms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFilms.FlatAppearance.BorderSize = 0;
            this.btnFilms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilms.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFilms.Location = new System.Drawing.Point(11, 60);
            this.btnFilms.Name = "btnFilms";
            this.btnFilms.Size = new System.Drawing.Size(180, 50);
            this.btnFilms.TabIndex = 2;
            this.btnFilms.Text = "Фильмы";
            this.btnFilms.UseVisualStyleBackColor = false;
            this.btnFilms.Click += new System.EventHandler(this.BtnFilms_Click);
            // 
            // lineMenu
            // 
            this.lineMenu.Location = new System.Drawing.Point(10, 53);
            this.lineMenu.Name = "lineMenu";
            this.lineMenu.Size = new System.Drawing.Size(180, 1);
            this.lineMenu.TabIndex = 1;
            // 
            // labelMenu
            // 
            this.labelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMenu.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMenu.Location = new System.Drawing.Point(0, 0);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(198, 50);
            this.labelMenu.TabIndex = 0;
            this.labelMenu.Text = "MENU";
            this.labelMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBar.Controls.Add(this.labelHeader);
            this.panelBar.Controls.Add(this.iconMinimize);
            this.panelBar.Controls.Add(this.iconMaximize);
            this.panelBar.Controls.Add(this.iconRestore);
            this.panelBar.Controls.Add(this.iconClose);
            this.panelBar.Controls.Add(this.iconMenu);
            this.panelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBar.Location = new System.Drawing.Point(200, 0);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(800, 51);
            this.panelBar.TabIndex = 1;
            this.panelBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBar_MouseDown);
            // 
            // labelHeader
            // 
            this.labelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHeader.Enabled = false;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.Location = new System.Drawing.Point(46, 0);
            this.labelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(674, 49);
            this.labelHeader.TabIndex = 5;
            this.labelHeader.Text = "Abkmvs";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconMinimize
            // 
            this.iconMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMinimize.Image = ((System.Drawing.Image)(resources.GetObject("iconMinimize.Image")));
            this.iconMinimize.Location = new System.Drawing.Point(723, 3);
            this.iconMinimize.Name = "iconMinimize";
            this.iconMinimize.Size = new System.Drawing.Size(20, 20);
            this.iconMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMinimize.TabIndex = 4;
            this.iconMinimize.TabStop = false;
            this.iconMinimize.Click += new System.EventHandler(this.MinimizeApplication_Click);
            this.iconMinimize.MouseEnter += new System.EventHandler(this.Icon_MouseEnter);
            this.iconMinimize.MouseLeave += new System.EventHandler(this.Icon_MouseLeave);
            // 
            // iconMaximize
            // 
            this.iconMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMaximize.Image = ((System.Drawing.Image)(resources.GetObject("iconMaximize.Image")));
            this.iconMaximize.Location = new System.Drawing.Point(749, 3);
            this.iconMaximize.Name = "iconMaximize";
            this.iconMaximize.Size = new System.Drawing.Size(20, 20);
            this.iconMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMaximize.TabIndex = 3;
            this.iconMaximize.TabStop = false;
            this.iconMaximize.Click += new System.EventHandler(this.MaximizeApplication_Click);
            this.iconMaximize.MouseEnter += new System.EventHandler(this.Icon_MouseEnter);
            this.iconMaximize.MouseLeave += new System.EventHandler(this.Icon_MouseLeave);
            // 
            // iconRestore
            // 
            this.iconRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconRestore.Image = ((System.Drawing.Image)(resources.GetObject("iconRestore.Image")));
            this.iconRestore.Location = new System.Drawing.Point(749, 3);
            this.iconRestore.Name = "iconRestore";
            this.iconRestore.Size = new System.Drawing.Size(20, 20);
            this.iconRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconRestore.TabIndex = 2;
            this.iconRestore.TabStop = false;
            this.iconRestore.Visible = false;
            this.iconRestore.Click += new System.EventHandler(this.RestoreApplication_Click);
            this.iconRestore.MouseEnter += new System.EventHandler(this.Icon_MouseEnter);
            this.iconRestore.MouseLeave += new System.EventHandler(this.Icon_MouseLeave);
            // 
            // iconClose
            // 
            this.iconClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconClose.Image = ((System.Drawing.Image)(resources.GetObject("iconClose.Image")));
            this.iconClose.Location = new System.Drawing.Point(775, 3);
            this.iconClose.Name = "iconClose";
            this.iconClose.Size = new System.Drawing.Size(20, 20);
            this.iconClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconClose.TabIndex = 1;
            this.iconClose.TabStop = false;
            this.iconClose.Click += new System.EventHandler(this.CloseApplication_Click);
            this.iconClose.MouseEnter += new System.EventHandler(this.Icon_MouseEnter);
            this.iconClose.MouseLeave += new System.EventHandler(this.Icon_MouseLeave);
            // 
            // iconMenu
            // 
            this.iconMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMenu.Image = ((System.Drawing.Image)(resources.GetObject("iconMenu.Image")));
            this.iconMenu.Location = new System.Drawing.Point(8, 8);
            this.iconMenu.Name = "iconMenu";
            this.iconMenu.Size = new System.Drawing.Size(35, 35);
            this.iconMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMenu.TabIndex = 0;
            this.iconMenu.TabStop = false;
            this.iconMenu.Click += new System.EventHandler(this.IconMenu_Click);
            this.iconMenu.MouseEnter += new System.EventHandler(this.Icon_MouseEnter);
            this.iconMenu.MouseLeave += new System.EventHandler(this.Icon_MouseLeave);
            // 
            // panelContent
            // 
            this.panelContent.AutoScroll = true;
            this.panelContent.BackColor = System.Drawing.SystemColors.Control;
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(200, 51);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(800, 599);
            this.panelContent.TabIndex = 2;
            // 
            // SystemTrayIcon
            // 
            this.SystemTrayIcon.ContextMenuStrip = this.contextMenuTray;
            this.SystemTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("SystemTrayIcon.Icon")));
            this.SystemTrayIcon.Text = "Flat GUI";
            this.SystemTrayIcon.DoubleClick += new System.EventHandler(this.SystemTrayIcon_DoubleClick);
            // 
            // contextMenuTray
            // 
            this.contextMenuTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.развернутьToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.contextMenuTray.Name = "contextMenuTray";
            this.contextMenuTray.Size = new System.Drawing.Size(136, 48);
            this.contextMenuTray.Text = "sdsdfsdf";
            // 
            // развернутьToolStripMenuItem
            // 
            this.развернутьToolStripMenuItem.Name = "развернутьToolStripMenuItem";
            this.развернутьToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.развернутьToolStripMenuItem.Text = "Развернуть";
            this.развернутьToolStripMenuItem.Click += new System.EventHandler(this.SystemTrayIcon_DoubleClick);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.CloseApplication_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMenu)).EndInit();
            this.contextMenuTray.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.PictureBox iconMenu;
        private System.Windows.Forms.PictureBox iconMinimize;
        private System.Windows.Forms.PictureBox iconMaximize;
        private System.Windows.Forms.PictureBox iconRestore;
        private System.Windows.Forms.PictureBox iconClose;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label labelMenu;
        private MyLine lineMenu;
        private System.Windows.Forms.Button btnFilms;
        private System.Windows.Forms.Button btnSerials;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.NotifyIcon SystemTrayIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuTray;
        private System.Windows.Forms.ToolStripMenuItem развернутьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
    }
}

