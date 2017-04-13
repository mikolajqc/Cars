namespace PAIN_Projekt
{
    partial class ListViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.carsListView = new System.Windows.Forms.ListView();
            this.brandColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maxSpeedColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productionYearColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxSpeed100ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxSpeed100ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // carsListView
            // 
            this.carsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.brandColumn,
            this.maxSpeedColumn,
            this.productionYearColumn,
            this.typeColumn});
            this.carsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carsListView.Location = new System.Drawing.Point(0, 49);
            this.carsListView.Name = "carsListView";
            this.carsListView.Size = new System.Drawing.Size(464, 191);
            this.carsListView.TabIndex = 1;
            this.carsListView.UseCompatibleStateImageBehavior = false;
            this.carsListView.View = System.Windows.Forms.View.Details;
            // 
            // brandColumn
            // 
            this.brandColumn.Text = "Brand";
            this.brandColumn.Width = 115;
            // 
            // maxSpeedColumn
            // 
            this.maxSpeedColumn.Text = "Max speed";
            this.maxSpeedColumn.Width = 118;
            // 
            // productionYearColumn
            // 
            this.productionYearColumn.Text = "Production year";
            this.productionYearColumn.Width = 123;
            // 
            // typeColumn
            // 
            this.typeColumn.Text = "Type";
            this.typeColumn.Width = 88;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 25);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(464, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem,
            this.maxSpeed100ToolStripMenuItem,
            this.maxSpeed100ToolStripMenuItem1});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // maxSpeed100ToolStripMenuItem
            // 
            this.maxSpeed100ToolStripMenuItem.Name = "maxSpeed100ToolStripMenuItem";
            this.maxSpeed100ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.maxSpeed100ToolStripMenuItem.Text = "Max speed < 100";
            this.maxSpeed100ToolStripMenuItem.Click += new System.EventHandler(this.maxSpeed100ToolStripMenuItem_Click);
            // 
            // maxSpeed100ToolStripMenuItem1
            // 
            this.maxSpeed100ToolStripMenuItem1.Name = "maxSpeed100ToolStripMenuItem1";
            this.maxSpeed100ToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.maxSpeed100ToolStripMenuItem1.Text = "Max speed >= 100";
            this.maxSpeed100ToolStripMenuItem1.Click += new System.EventHandler(this.maxSpeed100ToolStripMenuItem1_Click);
            // 
            // ListViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 262);
            this.Controls.Add(this.carsListView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListViewForm";
            this.Text = "ListViewForm";
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.carsListView, 0);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView carsListView;
        private System.Windows.Forms.ColumnHeader brandColumn;
        private System.Windows.Forms.ColumnHeader maxSpeedColumn;
        private System.Windows.Forms.ColumnHeader productionYearColumn;
        private System.Windows.Forms.ColumnHeader typeColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maxSpeed100ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maxSpeed100ToolStripMenuItem1;
    }
}