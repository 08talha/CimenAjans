namespace Depo
{
    partial class Form12
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.yuklenenMalzemeler = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hareketSaati = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.depoCalisan_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.seferNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AracModeli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.depo_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.seferNo,
            this.yuklenenMalzemeler,
            this.hareketSaati,
            this.depoCalisan_id,
            this.AracModeli,
            this.depo_id});
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(712, 435);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // yuklenenMalzemeler
            // 
            this.yuklenenMalzemeler.DisplayIndex = 5;
            this.yuklenenMalzemeler.Text = "Yuklenen Malzemeler";
            this.yuklenenMalzemeler.Width = 159;
            // 
            // hareketSaati
            // 
            this.hareketSaati.DisplayIndex = 1;
            this.hareketSaati.Text = "Hareket Saati";
            this.hareketSaati.Width = 95;
            // 
            // depoCalisan_id
            // 
            this.depoCalisan_id.Text = "Depo Calisan id";
            this.depoCalisan_id.Width = 96;
            // 
            // seferNo
            // 
            this.seferNo.Text = "Sefer No";
            this.seferNo.Width = 106;
            // 
            // AracModeli
            // 
            this.AracModeli.DisplayIndex = 2;
            this.AracModeli.Text = "Arac Modeli";
            this.AracModeli.Width = 93;
            // 
            // depo_id
            // 
            this.depo_id.DisplayIndex = 4;
            this.depo_id.Text = "Depo id";
            this.depo_id.Width = 111;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 501);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "Form12";
            this.Text = "Form12";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader seferNo;
        private System.Windows.Forms.ColumnHeader yuklenenMalzemeler;
        private System.Windows.Forms.ColumnHeader hareketSaati;
        private System.Windows.Forms.ColumnHeader depoCalisan_id;
        private System.Windows.Forms.ColumnHeader AracModeli;
        private System.Windows.Forms.ColumnHeader depo_id;
        private System.Windows.Forms.Button button1;
    }
}