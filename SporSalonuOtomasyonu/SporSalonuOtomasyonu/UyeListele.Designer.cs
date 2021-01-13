
namespace SporSalonuOtomasyonu
{
    partial class UyeListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeListele));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uyeEkleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbKullaniciLoginDataSet1 = new SporSalonuOtomasyonu.dbKullaniciLoginDataSet1();
            this.dbKullaniciLoginDataSet = new SporSalonuOtomasyonu.dbKullaniciLoginDataSet();
            this.uyeEkleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uyeEkleTableAdapter = new SporSalonuOtomasyonu.dbKullaniciLoginDataSetTableAdapters.UyeEkleTableAdapter();
            this.uyeEkleTableAdapter1 = new SporSalonuOtomasyonu.dbKullaniciLoginDataSet1TableAdapters.UyeEkleTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.omuz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sil = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeEkleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbKullaniciLoginDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbKullaniciLoginDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeEkleBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.telNoDataGridViewTextBoxColumn,
            this.cinsiyet,
            this.boy,
            this.kilo,
            this.omuz,
            this.kol,
            this.sil});
            this.dataGridView1.DataSource = this.uyeEkleBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(872, 277);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // uyeEkleBindingSource1
            // 
            this.uyeEkleBindingSource1.DataMember = "UyeEkle";
            this.uyeEkleBindingSource1.DataSource = this.dbKullaniciLoginDataSet1;
            // 
            // dbKullaniciLoginDataSet1
            // 
            this.dbKullaniciLoginDataSet1.DataSetName = "dbKullaniciLoginDataSet1";
            this.dbKullaniciLoginDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbKullaniciLoginDataSet
            // 
            this.dbKullaniciLoginDataSet.DataSetName = "dbKullaniciLoginDataSet";
            this.dbKullaniciLoginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uyeEkleBindingSource
            // 
            this.uyeEkleBindingSource.DataMember = "UyeEkle";
            this.uyeEkleBindingSource.DataSource = this.dbKullaniciLoginDataSet;
            // 
            // uyeEkleTableAdapter
            // 
            this.uyeEkleTableAdapter.ClearBeforeFill = true;
            // 
            // uyeEkleTableAdapter1
            // 
            this.uyeEkleTableAdapter1.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 48);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Tan;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(80, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Yönetim Paneli  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Tan;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = "GYM";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(864, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 24);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(6, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kayıtlı Üyelerimiz";
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // telNoDataGridViewTextBoxColumn
            // 
            this.telNoDataGridViewTextBoxColumn.DataPropertyName = "telNo";
            this.telNoDataGridViewTextBoxColumn.HeaderText = "telNo";
            this.telNoDataGridViewTextBoxColumn.Name = "telNoDataGridViewTextBoxColumn";
            // 
            // cinsiyet
            // 
            this.cinsiyet.DataPropertyName = "cinsiyet";
            this.cinsiyet.HeaderText = "cinsiyet";
            this.cinsiyet.Name = "cinsiyet";
            // 
            // boy
            // 
            this.boy.DataPropertyName = "boy";
            this.boy.HeaderText = "boy";
            this.boy.Name = "boy";
            // 
            // kilo
            // 
            this.kilo.DataPropertyName = "kilo";
            this.kilo.HeaderText = "kilo";
            this.kilo.Name = "kilo";
            // 
            // omuz
            // 
            this.omuz.DataPropertyName = "omuz";
            this.omuz.HeaderText = "omuz";
            this.omuz.Name = "omuz";
            // 
            // kol
            // 
            this.kol.DataPropertyName = "kol";
            this.kol.HeaderText = "kol";
            this.kol.Name = "kol";
            // 
            // sil
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.NullValue = false;
            this.sil.DefaultCellStyle = dataGridViewCellStyle1;
            this.sil.HeaderText = "SİL";
            this.sil.Name = "sil";
            this.sil.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // UyeListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(896, 445);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UyeListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UyeListele";
            this.Load += new System.EventHandler(this.UyeListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeEkleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbKullaniciLoginDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbKullaniciLoginDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeEkleBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dbKullaniciLoginDataSet dbKullaniciLoginDataSet;
        private System.Windows.Forms.BindingSource uyeEkleBindingSource;
        private dbKullaniciLoginDataSetTableAdapters.UyeEkleTableAdapter uyeEkleTableAdapter;
        private dbKullaniciLoginDataSet1 dbKullaniciLoginDataSet1;
        private System.Windows.Forms.BindingSource uyeEkleBindingSource1;
        private dbKullaniciLoginDataSet1TableAdapters.UyeEkleTableAdapter uyeEkleTableAdapter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn boy;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn omuz;
        private System.Windows.Forms.DataGridViewTextBoxColumn kol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sil;
    }
}