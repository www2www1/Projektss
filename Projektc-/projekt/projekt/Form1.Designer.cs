namespace projekt
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
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.btTaBort = new System.Windows.Forms.Button();
            this.btSpara = new System.Windows.Forms.Button();
            this.btNy = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btUrlTaBort = new System.Windows.Forms.Button();
            this.btUrlSpara = new System.Windows.Forms.Button();
            this.btUrlNy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.lvPodcast = new System.Windows.Forms.ListView();
            this.chAvsnitt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNamn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFrekvens = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chKategori1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.CBC = new System.Windows.Forms.ComboBox();
            this.lbEpisode = new System.Windows.Forms.ListBox();
            this.tbUF = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Location = new System.Drawing.Point(13, 449);
            this.linkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(0, 17);
            this.linkLabel.TabIndex = 39;
            // 
            // btTaBort
            // 
            this.btTaBort.Location = new System.Drawing.Point(787, 191);
            this.btTaBort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btTaBort.Name = "btTaBort";
            this.btTaBort.Size = new System.Drawing.Size(75, 34);
            this.btTaBort.TabIndex = 35;
            this.btTaBort.Text = "Ta bort";
            this.btTaBort.UseVisualStyleBackColor = true;
            this.btTaBort.Click += new System.EventHandler(this.btTaBort_Click);
            // 
            // btSpara
            // 
            this.btSpara.Location = new System.Drawing.Point(707, 191);
            this.btSpara.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSpara.Name = "btSpara";
            this.btSpara.Size = new System.Drawing.Size(75, 34);
            this.btSpara.TabIndex = 34;
            this.btSpara.Text = "Spara";
            this.btSpara.UseVisualStyleBackColor = true;
            this.btSpara.Click += new System.EventHandler(this.btSpara_Click);
            // 
            // btNy
            // 
            this.btNy.Location = new System.Drawing.Point(627, 191);
            this.btNy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btNy.Name = "btNy";
            this.btNy.Size = new System.Drawing.Size(75, 34);
            this.btNy.TabIndex = 33;
            this.btNy.Text = "Ny";
            this.btNy.UseVisualStyleBackColor = true;
            this.btNy.Click += new System.EventHandler(this.btNy_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(659, 103);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 22);
            this.textBox1.TabIndex = 32;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(659, 48);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(171, 24);
            this.comboBox3.TabIndex = 31;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Updateringsfrekvens :";
            // 
            // btUrlTaBort
            // 
            this.btUrlTaBort.Location = new System.Drawing.Point(195, 238);
            this.btUrlTaBort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btUrlTaBort.Name = "btUrlTaBort";
            this.btUrlTaBort.Size = new System.Drawing.Size(75, 34);
            this.btUrlTaBort.TabIndex = 28;
            this.btUrlTaBort.Text = "Ta bort";
            this.btUrlTaBort.UseVisualStyleBackColor = true;
            this.btUrlTaBort.Click += new System.EventHandler(this.btUrlTaBort_Click);
            // 
            // btUrlSpara
            // 
            this.btUrlSpara.Location = new System.Drawing.Point(105, 238);
            this.btUrlSpara.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btUrlSpara.Name = "btUrlSpara";
            this.btUrlSpara.Size = new System.Drawing.Size(75, 34);
            this.btUrlSpara.TabIndex = 27;
            this.btUrlSpara.Text = "Spara";
            this.btUrlSpara.UseVisualStyleBackColor = true;
            this.btUrlSpara.Click += new System.EventHandler(this.btUrlSpara_Click);
            // 
            // btUrlNy
            // 
            this.btUrlNy.Location = new System.Drawing.Point(11, 238);
            this.btUrlNy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btUrlNy.Name = "btUrlNy";
            this.btUrlNy.Size = new System.Drawing.Size(75, 34);
            this.btUrlNy.TabIndex = 26;
            this.btUrlNy.Text = "Hitta";
            this.btUrlNy.UseVisualStyleBackColor = true;
            this.btUrlNy.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Kategori :";
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(5, 210);
            this.tbUrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(217, 22);
            this.tbUrl.TabIndex = 24;
            this.tbUrl.Tag = "";
            // 
            // lvPodcast
            // 
            this.lvPodcast.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chAvsnitt,
            this.chNamn,
            this.chFrekvens,
            this.chKategori1});
            this.lvPodcast.Location = new System.Drawing.Point(8, 11);
            this.lvPodcast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvPodcast.Name = "lvPodcast";
            this.lvPodcast.Size = new System.Drawing.Size(601, 159);
            this.lvPodcast.TabIndex = 22;
            this.lvPodcast.UseCompatibleStateImageBehavior = false;
            this.lvPodcast.View = System.Windows.Forms.View.Details;
            this.lvPodcast.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvPodcast_ItemSelectionChanged);
            // 
            // chAvsnitt
            // 
            this.chAvsnitt.Text = "Avsnitt";
            this.chAvsnitt.Width = 122;
            // 
            // chNamn
            // 
            this.chNamn.Text = "Namn";
            this.chNamn.Width = 119;
            // 
            // chFrekvens
            // 
            this.chFrekvens.Text = "Frekvens";
            this.chFrekvens.Width = 132;
            // 
            // chKategori1
            // 
            this.chKategori1.Text = "Kategori";
            this.chKategori1.Width = 123;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "URL";
            // 
            // CBC
            // 
            this.CBC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBC.FormattingEnabled = true;
            this.CBC.Location = new System.Drawing.Point(384, 210);
            this.CBC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBC.Name = "CBC";
            this.CBC.Size = new System.Drawing.Size(119, 24);
            this.CBC.TabIndex = 44;
            // 
            // lbEpisode
            // 
            this.lbEpisode.FormattingEnabled = true;
            this.lbEpisode.ItemHeight = 16;
            this.lbEpisode.Location = new System.Drawing.Point(17, 305);
            this.lbEpisode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbEpisode.Name = "lbEpisode";
            this.lbEpisode.Size = new System.Drawing.Size(371, 132);
            this.lbEpisode.TabIndex = 46;
            this.lbEpisode.SelectedIndexChanged += new System.EventHandler(this.lbEpisode_SelectedIndexChanged);
            // 
            // tbUF
            // 
            this.tbUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbUF.FormattingEnabled = true;
            this.tbUF.Location = new System.Drawing.Point(229, 210);
            this.tbUF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUF.Name = "tbUF";
            this.tbUF.Size = new System.Drawing.Size(144, 24);
            this.tbUF.TabIndex = 48;
            this.tbUF.SelectedIndexChanged += new System.EventHandler(this.tbUF_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(459, 305);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(371, 132);
            this.richTextBox1.TabIndex = 49;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 279);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "List of Episodes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(587, 279);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 17);
            this.label5.TabIndex = 51;
            this.label5.Text = "Episode Description";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 476);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.tbUF);
            this.Controls.Add(this.lbEpisode);
            this.Controls.Add(this.CBC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.btTaBort);
            this.Controls.Add(this.btSpara);
            this.Controls.Add(this.btNy);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btUrlTaBort);
            this.Controls.Add(this.btUrlSpara);
            this.Controls.Add(this.btUrlNy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.lvPodcast);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.Button btTaBort;
        private System.Windows.Forms.Button btSpara;
        private System.Windows.Forms.Button btNy;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btUrlTaBort;
        private System.Windows.Forms.Button btUrlSpara;
        private System.Windows.Forms.Button btUrlNy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.ListView lvPodcast;
        private System.Windows.Forms.ColumnHeader chAvsnitt;
        private System.Windows.Forms.ColumnHeader chNamn;
        private System.Windows.Forms.ColumnHeader chFrekvens;
        private System.Windows.Forms.ColumnHeader chKategori1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBC;
        private System.Windows.Forms.ListBox lbEpisode;
        private System.Windows.Forms.ComboBox tbUF;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

