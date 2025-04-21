namespace Prog2Start
{
    partial class FurnitureForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            createToolStripMenuItem = new ToolStripMenuItem();
            couchToolStripMenuItem = new ToolStripMenuItem();
            deskChairToolStripMenuItem = new ToolStripMenuItem();
            furnitureListView = new ListView();
            typeColumn = new ColumnHeader();
            weightHeader = new ColumnHeader();
            categoryHeader = new ColumnHeader();
            detailsButton = new Button();
            saveToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, createToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(394, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, loadToolStripMenuItem, aboutToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            aboutToolStripMenuItem.Size = new Size(185, 26);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            exitToolStripMenuItem.Size = new Size(185, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // createToolStripMenuItem
            // 
            createToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { couchToolStripMenuItem, deskChairToolStripMenuItem });
            createToolStripMenuItem.Name = "createToolStripMenuItem";
            createToolStripMenuItem.Size = new Size(59, 24);
            createToolStripMenuItem.Text = "Insert";
            // 
            // couchToolStripMenuItem
            // 
            couchToolStripMenuItem.Name = "couchToolStripMenuItem";
            couchToolStripMenuItem.Size = new Size(162, 26);
            couchToolStripMenuItem.Text = "Couch";
            couchToolStripMenuItem.Click += couchToolStripMenuItem_Click;
            // 
            // deskChairToolStripMenuItem
            // 
            deskChairToolStripMenuItem.Name = "deskChairToolStripMenuItem";
            deskChairToolStripMenuItem.Size = new Size(162, 26);
            deskChairToolStripMenuItem.Text = "Desk Chair";
            deskChairToolStripMenuItem.Click += deskChairToolStripMenuItem_Click;
            // 
            // furnitureListView
            // 
            furnitureListView.Columns.AddRange(new ColumnHeader[] { typeColumn, weightHeader, categoryHeader });
            furnitureListView.Location = new Point(19, 51);
            furnitureListView.Margin = new Padding(3, 4, 3, 4);
            furnitureListView.MultiSelect = false;
            furnitureListView.Name = "furnitureListView";
            furnitureListView.Size = new Size(349, 388);
            furnitureListView.TabIndex = 1;
            furnitureListView.UseCompatibleStateImageBehavior = false;
            furnitureListView.View = View.Details;
            // 
            // typeColumn
            // 
            typeColumn.Text = "Furniture Type";
            typeColumn.Width = 100;
            // 
            // weightHeader
            // 
            weightHeader.Text = "Weight";
            weightHeader.Width = 100;
            // 
            // categoryHeader
            // 
            categoryHeader.Text = "Category";
            categoryHeader.Width = 100;
            // 
            // detailsButton
            // 
            detailsButton.Location = new Point(145, 457);
            detailsButton.Margin = new Padding(3, 4, 3, 4);
            detailsButton.Name = "detailsButton";
            detailsButton.Size = new Size(86, 31);
            detailsButton.TabIndex = 2;
            detailsButton.Text = "Details";
            detailsButton.UseVisualStyleBackColor = true;
            detailsButton.Click += detailsButton_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(185, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.L;
            loadToolStripMenuItem.Size = new Size(185, 26);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // FurnitureForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 541);
            Controls.Add(detailsButton);
            Controls.Add(furnitureListView);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FurnitureForm";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Furniture Form";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem createToolStripMenuItem;
        private ToolStripMenuItem couchToolStripMenuItem;
        private ToolStripMenuItem deskChairToolStripMenuItem;
        private ListView furnitureListView;
        private ColumnHeader typeColumn;
        private ColumnHeader weightHeader;
        private ColumnHeader categoryHeader;
        private Button detailsButton;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
    }
}
