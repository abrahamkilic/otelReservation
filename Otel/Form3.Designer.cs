namespace Otel
{
    partial class Form3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.browsebutton = new System.Windows.Forms.Button();
            this.backupbutton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.browse2button = new System.Windows.Forms.Button();
            this.restorebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 41);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(561, 22);
            this.textBox1.TabIndex = 0;
            // 
            // browsebutton
            // 
            this.browsebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.browsebutton.Location = new System.Drawing.Point(459, 73);
            this.browsebutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.browsebutton.Name = "browsebutton";
            this.browsebutton.Size = new System.Drawing.Size(125, 47);
            this.browsebutton.TabIndex = 1;
            this.browsebutton.Text = "KONUM";
            this.browsebutton.UseVisualStyleBackColor = true;
            this.browsebutton.Click += new System.EventHandler(this.browsebutton_Click);
            // 
            // backupbutton
            // 
            this.backupbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backupbutton.Location = new System.Drawing.Point(459, 127);
            this.backupbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backupbutton.Name = "backupbutton";
            this.backupbutton.Size = new System.Drawing.Size(125, 47);
            this.backupbutton.TabIndex = 2;
            this.backupbutton.Text = "BACKUP";
            this.backupbutton.UseVisualStyleBackColor = true;
            this.backupbutton.Click += new System.EventHandler(this.backupbutton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(21, 304);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(561, 22);
            this.textBox2.TabIndex = 3;
            // 
            // browse2button
            // 
            this.browse2button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.browse2button.Location = new System.Drawing.Point(453, 336);
            this.browse2button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.browse2button.Name = "browse2button";
            this.browse2button.Size = new System.Drawing.Size(131, 48);
            this.browse2button.TabIndex = 4;
            this.browse2button.Text = "KONUM";
            this.browse2button.UseVisualStyleBackColor = true;
            this.browse2button.Click += new System.EventHandler(this.browse2button_Click);
            // 
            // restorebutton
            // 
            this.restorebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.restorebutton.Location = new System.Drawing.Point(453, 391);
            this.restorebutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.restorebutton.Name = "restorebutton";
            this.restorebutton.Size = new System.Drawing.Size(131, 48);
            this.restorebutton.TabIndex = 5;
            this.restorebutton.Text = "RESTORE";
            this.restorebutton.UseVisualStyleBackColor = true;
            this.restorebutton.Click += new System.EventHandler(this.restorebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "BACKUP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 281);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "RESTORE";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 564);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.restorebutton);
            this.Controls.Add(this.browse2button);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.backupbutton);
            this.Controls.Add(this.browsebutton);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button browsebutton;
        private System.Windows.Forms.Button backupbutton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button browse2button;
        private System.Windows.Forms.Button restorebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}