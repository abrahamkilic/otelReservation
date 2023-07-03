namespace Otel
{
    partial class IMPORT
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
            this.ResultGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ResultGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultGrid
            // 
            this.ResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultGrid.Location = new System.Drawing.Point(2, 76);
            this.ResultGrid.Name = "ResultGrid";
            this.ResultGrid.RowHeadersWidth = 51;
            this.ResultGrid.RowTemplate.Height = 24;
            this.ResultGrid.Size = new System.Drawing.Size(677, 375);
            this.ResultGrid.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(2, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IMPORT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ResultGrid);
            this.Name = "IMPORT";
            this.Text = "IMPORT";
            this.Load += new System.EventHandler(this.IMPORT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResultGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ResultGrid;
        private System.Windows.Forms.Button button1;
    }
}