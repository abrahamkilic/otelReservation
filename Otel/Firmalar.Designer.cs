namespace Otel
{
    partial class Firmalar
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.firmaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.websitesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ındexIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aracıFirmaTablosuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelReservationAppDataSet2 = new Otel.HotelReservationAppDataSet2();
            this.aracıFirmaTablosuTableAdapter = new Otel.HotelReservationAppDataSet2TableAdapters.AracıFirmaTablosuTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracıFirmaTablosuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationAppDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firmaIDDataGridViewTextBoxColumn,
            this.websitesiDataGridViewTextBoxColumn,
            this.otelIDDataGridViewTextBoxColumn,
            this.telefonNoDataGridViewTextBoxColumn,
            this.mailAdresDataGridViewTextBoxColumn,
            this.ındexIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aracıFirmaTablosuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // firmaIDDataGridViewTextBoxColumn
            // 
            this.firmaIDDataGridViewTextBoxColumn.DataPropertyName = "FirmaID";
            this.firmaIDDataGridViewTextBoxColumn.HeaderText = "FirmaID";
            this.firmaIDDataGridViewTextBoxColumn.Name = "firmaIDDataGridViewTextBoxColumn";
            // 
            // websitesiDataGridViewTextBoxColumn
            // 
            this.websitesiDataGridViewTextBoxColumn.DataPropertyName = "Websitesi";
            this.websitesiDataGridViewTextBoxColumn.HeaderText = "Websitesi";
            this.websitesiDataGridViewTextBoxColumn.Name = "websitesiDataGridViewTextBoxColumn";
            // 
            // otelIDDataGridViewTextBoxColumn
            // 
            this.otelIDDataGridViewTextBoxColumn.DataPropertyName = "OtelID";
            this.otelIDDataGridViewTextBoxColumn.HeaderText = "OtelID";
            this.otelIDDataGridViewTextBoxColumn.Name = "otelIDDataGridViewTextBoxColumn";
            // 
            // telefonNoDataGridViewTextBoxColumn
            // 
            this.telefonNoDataGridViewTextBoxColumn.DataPropertyName = "TelefonNo";
            this.telefonNoDataGridViewTextBoxColumn.HeaderText = "TelefonNo";
            this.telefonNoDataGridViewTextBoxColumn.Name = "telefonNoDataGridViewTextBoxColumn";
            // 
            // mailAdresDataGridViewTextBoxColumn
            // 
            this.mailAdresDataGridViewTextBoxColumn.DataPropertyName = "MailAdres";
            this.mailAdresDataGridViewTextBoxColumn.HeaderText = "MailAdres";
            this.mailAdresDataGridViewTextBoxColumn.Name = "mailAdresDataGridViewTextBoxColumn";
            // 
            // ındexIdDataGridViewTextBoxColumn
            // 
            this.ındexIdDataGridViewTextBoxColumn.DataPropertyName = "IndexId";
            this.ındexIdDataGridViewTextBoxColumn.HeaderText = "IndexId";
            this.ındexIdDataGridViewTextBoxColumn.Name = "ındexIdDataGridViewTextBoxColumn";
            this.ındexIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aracıFirmaTablosuBindingSource
            // 
            this.aracıFirmaTablosuBindingSource.DataMember = "AracıFirmaTablosu";
            this.aracıFirmaTablosuBindingSource.DataSource = this.hotelReservationAppDataSet2;
            // 
            // hotelReservationAppDataSet2
            // 
            this.hotelReservationAppDataSet2.DataSetName = "HotelReservationAppDataSet2";
            this.hotelReservationAppDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aracıFirmaTablosuTableAdapter
            // 
            this.aracıFirmaTablosuTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(677, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(677, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(677, 111);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(677, 154);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(674, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "FirmaID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(677, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "WebSitesi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(674, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "TelefonNo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(677, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "MailAdres";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(677, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(677, 281);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 34);
            this.button3.TabIndex = 11;
            this.button3.Text = "GÜNCELLE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Firmalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Firmalar";
            this.Text = "Firmalar";
            this.Load += new System.EventHandler(this.Firmalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracıFirmaTablosuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationAppDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HotelReservationAppDataSet2 hotelReservationAppDataSet2;
        private System.Windows.Forms.BindingSource aracıFirmaTablosuBindingSource;
        private HotelReservationAppDataSet2TableAdapters.AracıFirmaTablosuTableAdapter aracıFirmaTablosuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn websitesiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ındexIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}