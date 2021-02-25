
namespace IKEADB
{
    partial class Form1
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
            this.RoomLabel = new System.Windows.Forms.Label();
            this.listSeries = new System.Windows.Forms.ListBox();
            this.SeriesLabel = new System.Windows.Forms.Label();
            this.listRooms = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // RoomLabel
            // 
            this.RoomLabel.AutoSize = true;
            this.RoomLabel.Location = new System.Drawing.Point(253, 64);
            this.RoomLabel.Name = "RoomLabel";
            this.RoomLabel.Size = new System.Drawing.Size(40, 13);
            this.RoomLabel.TabIndex = 0;
            this.RoomLabel.Text = "Rooms";
            // 
            // listSeries
            // 
            this.listSeries.FormattingEnabled = true;
            this.listSeries.Location = new System.Drawing.Point(67, 101);
            this.listSeries.Name = "listSeries";
            this.listSeries.Size = new System.Drawing.Size(120, 95);
            this.listSeries.TabIndex = 1;
            // 
            // SeriesLabel
            // 
            this.SeriesLabel.AutoSize = true;
            this.SeriesLabel.Location = new System.Drawing.Point(64, 64);
            this.SeriesLabel.Name = "SeriesLabel";
            this.SeriesLabel.Size = new System.Drawing.Size(36, 13);
            this.SeriesLabel.TabIndex = 2;
            this.SeriesLabel.Text = "Series";
            // 
            // listRooms
            // 
            this.listRooms.FormattingEnabled = true;
            this.listRooms.Location = new System.Drawing.Point(256, 101);
            this.listRooms.Name = "listRooms";
            this.listRooms.Size = new System.Drawing.Size(120, 95);
            this.listRooms.TabIndex = 3;
            this.listRooms.SelectedIndexChanged += new System.EventHandler(this.listRooms_electedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listRooms);
            this.Controls.Add(this.SeriesLabel);
            this.Controls.Add(this.listSeries);
            this.Controls.Add(this.RoomLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RoomLabel;
        private System.Windows.Forms.ListBox listSeries;
        private System.Windows.Forms.Label SeriesLabel;
        private System.Windows.Forms.ListBox listRooms;
    }
}

