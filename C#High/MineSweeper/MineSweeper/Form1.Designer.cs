namespace Minesweeper
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 

        
        private void InitializeComponent()
        {
            this.bommer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bommer)).BeginInit();
            this.SuspendLayout();
            this.bommer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bommer.Location = new System.Drawing.Point(13, 13);
            this.bommer.Name = "bommer";
            this.bommer.RowTemplate.Height = 23;
            this.bommer.Size = new System.Drawing.Size(554, 529);
            this.bommer.TabIndex = 0;
            this.bommer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bommer_CellClick);
            this.bommer.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.bommer_CellMouseClick);
            this.bommer.SelectionChanged += new System.EventHandler(this.bommer_SelectionChanged);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 575);
            this.Controls.Add(this.bommer);
            this.Name = "Form1";
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bommer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bommer;
    }
}

