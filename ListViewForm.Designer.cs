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
            this.SuspendLayout();
            // 
            // carsListView
            // 
            this.carsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.brandColumn,
            this.maxSpeedColumn,
            this.productionYearColumn,
            this.typeColumn});
            this.carsListView.Location = new System.Drawing.Point(0, 0);
            this.carsListView.Name = "carsListView";
            this.carsListView.Size = new System.Drawing.Size(464, 262);
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
            // ListViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 262);
            this.Controls.Add(this.carsListView);
            this.Name = "ListViewForm";
            this.Text = "ListViewForm";
            this.Controls.SetChildIndex(this.carsListView, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView carsListView;
        private System.Windows.Forms.ColumnHeader brandColumn;
        private System.Windows.Forms.ColumnHeader maxSpeedColumn;
        private System.Windows.Forms.ColumnHeader productionYearColumn;
        private System.Windows.Forms.ColumnHeader typeColumn;
    }
}