
namespace Library_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtkitapid = new System.Windows.Forms.TextBox();
            this.txtkitapadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtyazar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbtür = new System.Windows.Forms.ComboBox();
            this.radiokullanilmis = new System.Windows.Forms.RadioButton();
            this.radiosifir = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsayfa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnlistele = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtkitapbul = new System.Windows.Forms.TextBox();
            this.btnbul = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 358);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(778, 192);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap id:";
            // 
            // txtkitapid
            // 
            this.txtkitapid.Enabled = false;
            this.txtkitapid.Location = new System.Drawing.Point(118, 12);
            this.txtkitapid.Name = "txtkitapid";
            this.txtkitapid.Size = new System.Drawing.Size(214, 36);
            this.txtkitapid.TabIndex = 2;
            // 
            // txtkitapadi
            // 
            this.txtkitapadi.Location = new System.Drawing.Point(118, 74);
            this.txtkitapadi.Name = "txtkitapadi";
            this.txtkitapadi.Size = new System.Drawing.Size(214, 36);
            this.txtkitapadi.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kitap Adı:";
            // 
            // txtyazar
            // 
            this.txtyazar.Location = new System.Drawing.Point(118, 136);
            this.txtyazar.Name = "txtyazar";
            this.txtyazar.Size = new System.Drawing.Size(214, 36);
            this.txtyazar.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yazar:";
            // 
            // cmbtür
            // 
            this.cmbtür.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtür.FormattingEnabled = true;
            this.cmbtür.Items.AddRange(new object[] {
            "Roman",
            "Hikaye",
            "Şiir",
            "Tiyatro",
            "Söz"});
            this.cmbtür.Location = new System.Drawing.Point(118, 198);
            this.cmbtür.Name = "cmbtür";
            this.cmbtür.Size = new System.Drawing.Size(214, 36);
            this.cmbtür.TabIndex = 7;
            // 
            // radiokullanilmis
            // 
            this.radiokullanilmis.AutoSize = true;
            this.radiokullanilmis.Location = new System.Drawing.Point(111, 318);
            this.radiokullanilmis.Name = "radiokullanilmis";
            this.radiokullanilmis.Size = new System.Drawing.Size(112, 33);
            this.radiokullanilmis.TabIndex = 8;
            this.radiokullanilmis.TabStop = true;
            this.radiokullanilmis.Text = "İkinci El";
            this.radiokullanilmis.UseVisualStyleBackColor = true;
            this.radiokullanilmis.CheckedChanged += new System.EventHandler(this.radiokullanilmis_CheckedChanged);
            // 
            // radiosifir
            // 
            this.radiosifir.AutoSize = true;
            this.radiosifir.Location = new System.Drawing.Point(236, 319);
            this.radiosifir.Name = "radiosifir";
            this.radiosifir.Size = new System.Drawing.Size(75, 33);
            this.radiosifir.TabIndex = 9;
            this.radiosifir.TabStop = true;
            this.radiosifir.Text = "Sıfır";
            this.radiosifir.UseVisualStyleBackColor = true;
            this.radiosifir.CheckedChanged += new System.EventHandler(this.radiosifir_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sayfa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Durum:";
            // 
            // txtsayfa
            // 
            this.txtsayfa.Location = new System.Drawing.Point(118, 260);
            this.txtsayfa.Name = "txtsayfa";
            this.txtsayfa.Size = new System.Drawing.Size(214, 36);
            this.txtsayfa.TabIndex = 13;
            this.txtsayfa.TextChanged += new System.EventHandler(this.txtsayfa_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tür:";
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(383, 32);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(158, 45);
            this.btnlistele.TabIndex = 14;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(383, 94);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(158, 45);
            this.btnkaydet.TabIndex = 15;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(383, 163);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(158, 45);
            this.btnsil.TabIndex = 16;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.Location = new System.Drawing.Point(383, 226);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(158, 45);
            this.btngüncelle.TabIndex = 17;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(635, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 29);
            this.label7.TabIndex = 18;
            this.label7.Text = "Kitap Adı";
            // 
            // txtkitapbul
            // 
            this.txtkitapbul.Location = new System.Drawing.Point(581, 110);
            this.txtkitapbul.Name = "txtkitapbul";
            this.txtkitapbul.Size = new System.Drawing.Size(214, 36);
            this.txtkitapbul.TabIndex = 19;
            // 
            // btnbul
            // 
            this.btnbul.Location = new System.Drawing.Point(613, 152);
            this.btnbul.Name = "btnbul";
            this.btnbul.Size = new System.Drawing.Size(158, 45);
            this.btnbul.TabIndex = 20;
            this.btnbul.Text = "Ara";
            this.btnbul.UseVisualStyleBackColor = true;
            this.btnbul.Click += new System.EventHandler(this.btnbul_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(811, 577);
            this.Controls.Add(this.btnbul);
            this.Controls.Add(this.txtkitapbul);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.txtsayfa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radiosifir);
            this.Controls.Add(this.radiokullanilmis);
            this.Controls.Add(this.cmbtür);
            this.Controls.Add(this.txtyazar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtkitapadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtkitapid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Library Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtkitapid;
        private System.Windows.Forms.TextBox txtkitapadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtyazar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbtür;
        private System.Windows.Forms.RadioButton radiokullanilmis;
        private System.Windows.Forms.RadioButton radiosifir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsayfa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtkitapbul;
        private System.Windows.Forms.Button btnbul;
    }
}

