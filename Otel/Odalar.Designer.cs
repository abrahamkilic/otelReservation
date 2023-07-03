namespace Otel
{
    partial class Odalar
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
            this.odaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.konumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hizmetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ındexIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaTablosuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelReservationAppDataSet3 = new Otel.HotelReservationAppDataSet3();
            this.odaTablosuTableAdapter = new Otel.HotelReservationAppDataSet3TableAdapters.OdaTablosuTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odaTablosuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationAppDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odaIDDataGridViewTextBoxColumn,
            this.odaAdıDataGridViewTextBoxColumn,
            this.konumDataGridViewTextBoxColumn,
            this.hizmetDataGridViewTextBoxColumn,
            this.ındexIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.odaTablosuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 447);
            this.dataGridView1.TabIndex = 0;
            // 
            // odaIDDataGridViewTextBoxColumn
            // 
            this.odaIDDataGridViewTextBoxColumn.DataPropertyName = "OdaID";
            this.odaIDDataGridViewTextBoxColumn.HeaderText = "OdaID";
            this.odaIDDataGridViewTextBoxColumn.Name = "odaIDDataGridViewTextBoxColumn";
            // 
            // odaAdıDataGridViewTextBoxColumn
            // 
            this.odaAdıDataGridViewTextBoxColumn.DataPropertyName = "OdaAdı";
            this.odaAdıDataGridViewTextBoxColumn.HeaderText = "OdaAdı";
            this.odaAdıDataGridViewTextBoxColumn.Name = "odaAdıDataGridViewTextBoxColumn";
            // 
            // konumDataGridViewTextBoxColumn
            // 
            this.konumDataGridViewTextBoxColumn.DataPropertyName = "Konum";
            this.konumDataGridViewTextBoxColumn.HeaderText = "Konum";
            this.konumDataGridViewTextBoxColumn.Name = "konumDataGridViewTextBoxColumn";
            // 
            // hizmetDataGridViewTextBoxColumn
            // 
            this.hizmetDataGridViewTextBoxColumn.DataPropertyName = "Hizmet";
            this.hizmetDataGridViewTextBoxColumn.HeaderText = "Hizmet";
            this.hizmetDataGridViewTextBoxColumn.Name = "hizmetDataGridViewTextBoxColumn";
            // 
            // ındexIdDataGridViewTextBoxColumn
            // 
            this.ındexIdDataGridViewTextBoxColumn.DataPropertyName = "IndexId";
            this.ındexIdDataGridViewTextBoxColumn.HeaderText = "IndexId";
            this.ındexIdDataGridViewTextBoxColumn.Name = "ındexIdDataGridViewTextBoxColumn";
            this.ındexIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // odaTablosuBindingSource
            // 
            this.odaTablosuBindingSource.DataMember = "OdaTablosu";
            this.odaTablosuBindingSource.DataSource = this.hotelReservationAppDataSet3;
            // 
            // hotelReservationAppDataSet3
            // 
            this.hotelReservationAppDataSet3.DataSetName = "HotelReservationAppDataSet3";
            this.hotelReservationAppDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // odaTablosuTableAdapter
            // 
            this.odaTablosuTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(607, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "OdaID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(607, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "OdaAdı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(607, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Konum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(607, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hizmet";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(658, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(658, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(658, 105);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(658, 141);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(643, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(643, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 33);
            this.button3.TabIndex = 14;
            this.button3.Text = "GÜNCELLE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Odalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(801, 453);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Odalar";
            this.Text = "Odalar";
            this.Load += new System.EventHandler(this.Odalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odaTablosuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelReservationAppDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HotelReservationAppDataSet3 hotelReservationAppDataSet3;
        private System.Windows.Forms.BindingSource odaTablosuBindingSource;
        private HotelReservationAppDataSet3TableAdapters.OdaTablosuTableAdapter odaTablosuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn konumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hizmetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ındexIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}