namespace Punto_di_Pareggio
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_cfp = new System.Windows.Forms.Button();
            this.tb_descrizione = new System.Windows.Forms.TextBox();
            this.tb_cfp = new System.Windows.Forms.TextBox();
            this.list_CostiFissiProduzione = new System.Windows.Forms.ListBox();
            this.lb_CostiProduzione = new System.Windows.Forms.Label();
            this.list_CostiVariabiliProduzione = new System.Windows.Forms.ListBox();
            this.lb_CostiFissiProduzione = new System.Windows.Forms.Label();
            this.lb_CostiVariabiliProduzione = new System.Windows.Forms.Label();
            this.lb_DescrizioneProdFissi = new System.Windows.Forms.Label();
            this.lb_CostoProdFissi = new System.Windows.Forms.Label();
            this.lb_CostoProdVariabili = new System.Windows.Forms.Label();
            this.tb_cvp = new System.Windows.Forms.TextBox();
            this.btn_cvp = new System.Windows.Forms.Button();
            this.lb_CostoAcquistoVariabili = new System.Windows.Forms.Label();
            this.tb_cva = new System.Windows.Forms.TextBox();
            this.btn_cva = new System.Windows.Forms.Button();
            this.lb_CostoAcquistoFissi = new System.Windows.Forms.Label();
            this.lb_CostiVariabiliAcquisto = new System.Windows.Forms.Label();
            this.lb_CostiFissiAcquisto = new System.Windows.Forms.Label();
            this.list_CostiVariabiliAcquisto = new System.Windows.Forms.ListBox();
            this.lb_CostiAcquisto = new System.Windows.Forms.Label();
            this.list_CostiFissiAcquisto = new System.Windows.Forms.ListBox();
            this.tb_cfa = new System.Windows.Forms.TextBox();
            this.btn_cfa = new System.Windows.Forms.Button();
            this.list_Q = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_addQ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cfp
            // 
            this.btn_cfp.Location = new System.Drawing.Point(26, 934);
            this.btn_cfp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cfp.Name = "btn_cfp";
            this.btn_cfp.Size = new System.Drawing.Size(256, 42);
            this.btn_cfp.TabIndex = 0;
            this.btn_cfp.Text = "AGGIUNGI";
            this.btn_cfp.UseVisualStyleBackColor = true;
            this.btn_cfp.Click += new System.EventHandler(this.btn_cfp_Click);
            // 
            // tb_descrizione
            // 
            this.tb_descrizione.Location = new System.Drawing.Point(670, 806);
            this.tb_descrizione.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_descrizione.Name = "tb_descrizione";
            this.tb_descrizione.Size = new System.Drawing.Size(254, 26);
            this.tb_descrizione.TabIndex = 1;
            this.tb_descrizione.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_cfp
            // 
            this.tb_cfp.Location = new System.Drawing.Point(26, 894);
            this.tb_cfp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_cfp.Name = "tb_cfp";
            this.tb_cfp.Size = new System.Drawing.Size(254, 26);
            this.tb_cfp.TabIndex = 3;
            this.tb_cfp.TextChanged += new System.EventHandler(this.tb_cvp_TextChanged);
            // 
            // list_CostiFissiProduzione
            // 
            this.list_CostiFissiProduzione.FormattingEnabled = true;
            this.list_CostiFissiProduzione.ItemHeight = 20;
            this.list_CostiFissiProduzione.Location = new System.Drawing.Point(26, 132);
            this.list_CostiFissiProduzione.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.list_CostiFissiProduzione.Name = "list_CostiFissiProduzione";
            this.list_CostiFissiProduzione.Size = new System.Drawing.Size(254, 624);
            this.list_CostiFissiProduzione.TabIndex = 8;
            // 
            // lb_CostiProduzione
            // 
            this.lb_CostiProduzione.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CostiProduzione.Location = new System.Drawing.Point(26, 14);
            this.lb_CostiProduzione.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_CostiProduzione.Name = "lb_CostiProduzione";
            this.lb_CostiProduzione.Size = new System.Drawing.Size(522, 38);
            this.lb_CostiProduzione.TabIndex = 9;
            this.lb_CostiProduzione.Text = "Costi Produzione";
            this.lb_CostiProduzione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_CostiProduzione.Click += new System.EventHandler(this.label1_Click);
            // 
            // list_CostiVariabiliProduzione
            // 
            this.list_CostiVariabiliProduzione.FormattingEnabled = true;
            this.list_CostiVariabiliProduzione.ItemHeight = 20;
            this.list_CostiVariabiliProduzione.Location = new System.Drawing.Point(291, 132);
            this.list_CostiVariabiliProduzione.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.list_CostiVariabiliProduzione.Name = "list_CostiVariabiliProduzione";
            this.list_CostiVariabiliProduzione.Size = new System.Drawing.Size(254, 624);
            this.list_CostiVariabiliProduzione.TabIndex = 10;
            // 
            // lb_CostiFissiProduzione
            // 
            this.lb_CostiFissiProduzione.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CostiFissiProduzione.Location = new System.Drawing.Point(26, 89);
            this.lb_CostiFissiProduzione.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_CostiFissiProduzione.Name = "lb_CostiFissiProduzione";
            this.lb_CostiFissiProduzione.Size = new System.Drawing.Size(256, 38);
            this.lb_CostiFissiProduzione.TabIndex = 11;
            this.lb_CostiFissiProduzione.Text = "Fissi";
            this.lb_CostiFissiProduzione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_CostiFissiProduzione.Click += new System.EventHandler(this.lb_CostiFissiProduzione_Click);
            // 
            // lb_CostiVariabiliProduzione
            // 
            this.lb_CostiVariabiliProduzione.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CostiVariabiliProduzione.Location = new System.Drawing.Point(291, 89);
            this.lb_CostiVariabiliProduzione.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_CostiVariabiliProduzione.Name = "lb_CostiVariabiliProduzione";
            this.lb_CostiVariabiliProduzione.Size = new System.Drawing.Size(256, 38);
            this.lb_CostiVariabiliProduzione.TabIndex = 12;
            this.lb_CostiVariabiliProduzione.Text = "Variabili";
            this.lb_CostiVariabiliProduzione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_DescrizioneProdFissi
            // 
            this.lb_DescrizioneProdFissi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DescrizioneProdFissi.Location = new System.Drawing.Point(666, 763);
            this.lb_DescrizioneProdFissi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_DescrizioneProdFissi.Name = "lb_DescrizioneProdFissi";
            this.lb_DescrizioneProdFissi.Size = new System.Drawing.Size(261, 38);
            this.lb_DescrizioneProdFissi.TabIndex = 13;
            this.lb_DescrizioneProdFissi.Text = "Descrizione";
            this.lb_DescrizioneProdFissi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_DescrizioneProdFissi.Click += new System.EventHandler(this.lb_DescrizioneProdFissi_Click);
            // 
            // lb_CostoProdFissi
            // 
            this.lb_CostoProdFissi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CostoProdFissi.Location = new System.Drawing.Point(26, 851);
            this.lb_CostoProdFissi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_CostoProdFissi.Name = "lb_CostoProdFissi";
            this.lb_CostoProdFissi.Size = new System.Drawing.Size(256, 38);
            this.lb_CostoProdFissi.TabIndex = 14;
            this.lb_CostoProdFissi.Text = "Costo";
            this.lb_CostoProdFissi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_CostoProdVariabili
            // 
            this.lb_CostoProdVariabili.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CostoProdVariabili.Location = new System.Drawing.Point(291, 851);
            this.lb_CostoProdVariabili.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_CostoProdVariabili.Name = "lb_CostoProdVariabili";
            this.lb_CostoProdVariabili.Size = new System.Drawing.Size(256, 38);
            this.lb_CostoProdVariabili.TabIndex = 19;
            this.lb_CostoProdVariabili.Text = "Costo";
            this.lb_CostoProdVariabili.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_cvp
            // 
            this.tb_cvp.Location = new System.Drawing.Point(291, 894);
            this.tb_cvp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_cvp.Name = "tb_cvp";
            this.tb_cvp.Size = new System.Drawing.Size(254, 26);
            this.tb_cvp.TabIndex = 17;
            // 
            // btn_cvp
            // 
            this.btn_cvp.Location = new System.Drawing.Point(291, 934);
            this.btn_cvp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cvp.Name = "btn_cvp";
            this.btn_cvp.Size = new System.Drawing.Size(256, 42);
            this.btn_cvp.TabIndex = 15;
            this.btn_cvp.Text = "AGGIUNGI";
            this.btn_cvp.UseVisualStyleBackColor = true;
            this.btn_cvp.Click += new System.EventHandler(this.btn_cvp_Click_1);
            // 
            // lb_CostoAcquistoVariabili
            // 
            this.lb_CostoAcquistoVariabili.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CostoAcquistoVariabili.Location = new System.Drawing.Point(1317, 851);
            this.lb_CostoAcquistoVariabili.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_CostoAcquistoVariabili.Name = "lb_CostoAcquistoVariabili";
            this.lb_CostoAcquistoVariabili.Size = new System.Drawing.Size(256, 38);
            this.lb_CostoAcquistoVariabili.TabIndex = 34;
            this.lb_CostoAcquistoVariabili.Text = "Costo";
            this.lb_CostoAcquistoVariabili.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_cva
            // 
            this.tb_cva.Location = new System.Drawing.Point(1317, 894);
            this.tb_cva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_cva.Name = "tb_cva";
            this.tb_cva.Size = new System.Drawing.Size(254, 26);
            this.tb_cva.TabIndex = 32;
            // 
            // btn_cva
            // 
            this.btn_cva.Location = new System.Drawing.Point(1317, 934);
            this.btn_cva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cva.Name = "btn_cva";
            this.btn_cva.Size = new System.Drawing.Size(256, 42);
            this.btn_cva.TabIndex = 30;
            this.btn_cva.Text = "AGGIUNGI";
            this.btn_cva.UseVisualStyleBackColor = true;
            this.btn_cva.Click += new System.EventHandler(this.btn_cva_Click);
            // 
            // lb_CostoAcquistoFissi
            // 
            this.lb_CostoAcquistoFissi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CostoAcquistoFissi.Location = new System.Drawing.Point(1052, 851);
            this.lb_CostoAcquistoFissi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_CostoAcquistoFissi.Name = "lb_CostoAcquistoFissi";
            this.lb_CostoAcquistoFissi.Size = new System.Drawing.Size(256, 38);
            this.lb_CostoAcquistoFissi.TabIndex = 29;
            this.lb_CostoAcquistoFissi.Text = "Costo";
            this.lb_CostoAcquistoFissi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_CostiVariabiliAcquisto
            // 
            this.lb_CostiVariabiliAcquisto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CostiVariabiliAcquisto.Location = new System.Drawing.Point(1317, 89);
            this.lb_CostiVariabiliAcquisto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_CostiVariabiliAcquisto.Name = "lb_CostiVariabiliAcquisto";
            this.lb_CostiVariabiliAcquisto.Size = new System.Drawing.Size(256, 38);
            this.lb_CostiVariabiliAcquisto.TabIndex = 27;
            this.lb_CostiVariabiliAcquisto.Text = "Variabili";
            this.lb_CostiVariabiliAcquisto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_CostiFissiAcquisto
            // 
            this.lb_CostiFissiAcquisto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CostiFissiAcquisto.Location = new System.Drawing.Point(1052, 89);
            this.lb_CostiFissiAcquisto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_CostiFissiAcquisto.Name = "lb_CostiFissiAcquisto";
            this.lb_CostiFissiAcquisto.Size = new System.Drawing.Size(256, 38);
            this.lb_CostiFissiAcquisto.TabIndex = 26;
            this.lb_CostiFissiAcquisto.Text = "Fissi";
            this.lb_CostiFissiAcquisto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // list_CostiVariabiliAcquisto
            // 
            this.list_CostiVariabiliAcquisto.FormattingEnabled = true;
            this.list_CostiVariabiliAcquisto.ItemHeight = 20;
            this.list_CostiVariabiliAcquisto.Location = new System.Drawing.Point(1317, 132);
            this.list_CostiVariabiliAcquisto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.list_CostiVariabiliAcquisto.Name = "list_CostiVariabiliAcquisto";
            this.list_CostiVariabiliAcquisto.Size = new System.Drawing.Size(254, 624);
            this.list_CostiVariabiliAcquisto.TabIndex = 25;
            // 
            // lb_CostiAcquisto
            // 
            this.lb_CostiAcquisto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CostiAcquisto.Location = new System.Drawing.Point(1052, 14);
            this.lb_CostiAcquisto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_CostiAcquisto.Name = "lb_CostiAcquisto";
            this.lb_CostiAcquisto.Size = new System.Drawing.Size(522, 38);
            this.lb_CostiAcquisto.TabIndex = 24;
            this.lb_CostiAcquisto.Text = "Costi Acquisto";
            this.lb_CostiAcquisto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // list_CostiFissiAcquisto
            // 
            this.list_CostiFissiAcquisto.FormattingEnabled = true;
            this.list_CostiFissiAcquisto.ItemHeight = 20;
            this.list_CostiFissiAcquisto.Location = new System.Drawing.Point(1052, 132);
            this.list_CostiFissiAcquisto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.list_CostiFissiAcquisto.Name = "list_CostiFissiAcquisto";
            this.list_CostiFissiAcquisto.Size = new System.Drawing.Size(254, 624);
            this.list_CostiFissiAcquisto.TabIndex = 23;
            this.list_CostiFissiAcquisto.SelectedIndexChanged += new System.EventHandler(this.list_CostiFissiAcquisto_SelectedIndexChanged);
            // 
            // tb_cfa
            // 
            this.tb_cfa.Location = new System.Drawing.Point(1052, 894);
            this.tb_cfa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_cfa.Name = "tb_cfa";
            this.tb_cfa.Size = new System.Drawing.Size(254, 26);
            this.tb_cfa.TabIndex = 22;
            // 
            // btn_cfa
            // 
            this.btn_cfa.Location = new System.Drawing.Point(1052, 934);
            this.btn_cfa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cfa.Name = "btn_cfa";
            this.btn_cfa.Size = new System.Drawing.Size(256, 42);
            this.btn_cfa.TabIndex = 20;
            this.btn_cfa.Text = "AGGIUNGI";
            this.btn_cfa.UseVisualStyleBackColor = true;
            this.btn_cfa.Click += new System.EventHandler(this.btn_cfa_Click);
            // 
            // list_Q
            // 
            this.list_Q.FormattingEnabled = true;
            this.list_Q.ItemHeight = 20;
            this.list_Q.Location = new System.Drawing.Point(670, 132);
            this.list_Q.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.list_Q.Name = "list_Q";
            this.list_Q.Size = new System.Drawing.Size(254, 624);
            this.list_Q.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(670, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 114);
            this.label1.TabIndex = 36;
            this.label1.Text = "Quantità";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btn_addQ
            // 
            this.btn_addQ.Location = new System.Drawing.Point(671, 894);
            this.btn_addQ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_addQ.Name = "btn_addQ";
            this.btn_addQ.Size = new System.Drawing.Size(253, 82);
            this.btn_addQ.TabIndex = 37;
            this.btn_addQ.Text = "AGGIUNGI Q";
            this.btn_addQ.UseVisualStyleBackColor = true;
            this.btn_addQ.Click += new System.EventHandler(this.btn_addQ_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1593, 1057);
            this.Controls.Add(this.btn_addQ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_Q);
            this.Controls.Add(this.lb_CostoAcquistoVariabili);
            this.Controls.Add(this.tb_cva);
            this.Controls.Add(this.btn_cva);
            this.Controls.Add(this.lb_CostoAcquistoFissi);
            this.Controls.Add(this.lb_CostiVariabiliAcquisto);
            this.Controls.Add(this.lb_CostiFissiAcquisto);
            this.Controls.Add(this.list_CostiVariabiliAcquisto);
            this.Controls.Add(this.lb_CostiAcquisto);
            this.Controls.Add(this.list_CostiFissiAcquisto);
            this.Controls.Add(this.tb_cfa);
            this.Controls.Add(this.btn_cfa);
            this.Controls.Add(this.lb_CostoProdVariabili);
            this.Controls.Add(this.tb_cvp);
            this.Controls.Add(this.btn_cvp);
            this.Controls.Add(this.lb_CostoProdFissi);
            this.Controls.Add(this.lb_DescrizioneProdFissi);
            this.Controls.Add(this.lb_CostiVariabiliProduzione);
            this.Controls.Add(this.lb_CostiFissiProduzione);
            this.Controls.Add(this.list_CostiVariabiliProduzione);
            this.Controls.Add(this.lb_CostiProduzione);
            this.Controls.Add(this.list_CostiFissiProduzione);
            this.Controls.Add(this.tb_cfp);
            this.Controls.Add(this.tb_descrizione);
            this.Controls.Add(this.btn_cfp);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cfp;
        private System.Windows.Forms.TextBox tb_descrizione;
        private System.Windows.Forms.TextBox tb_cfp;
        private System.Windows.Forms.ListBox list_CostiFissiProduzione;
        private System.Windows.Forms.Label lb_CostiProduzione;
        private System.Windows.Forms.ListBox list_CostiVariabiliProduzione;
        private System.Windows.Forms.Label lb_CostiFissiProduzione;
        private System.Windows.Forms.Label lb_CostiVariabiliProduzione;
        private System.Windows.Forms.Label lb_DescrizioneProdFissi;
        private System.Windows.Forms.Label lb_CostoProdFissi;
        private System.Windows.Forms.Label lb_CostoProdVariabili;
        private System.Windows.Forms.TextBox tb_cvp;
        private System.Windows.Forms.Button btn_cvp;
        private System.Windows.Forms.Label lb_CostoAcquistoVariabili;
        private System.Windows.Forms.TextBox tb_cva;
        private System.Windows.Forms.Button btn_cva;
        private System.Windows.Forms.Label lb_CostoAcquistoFissi;
        private System.Windows.Forms.Label lb_CostiVariabiliAcquisto;
        private System.Windows.Forms.Label lb_CostiFissiAcquisto;
        private System.Windows.Forms.ListBox list_CostiVariabiliAcquisto;
        private System.Windows.Forms.Label lb_CostiAcquisto;
        private System.Windows.Forms.ListBox list_CostiFissiAcquisto;
        private System.Windows.Forms.TextBox tb_cfa;
        private System.Windows.Forms.Button btn_cfa;
        private System.Windows.Forms.ListBox list_Q;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_addQ;
    }
}

