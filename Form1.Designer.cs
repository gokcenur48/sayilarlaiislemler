
namespace GokceNurSonmez_210601694
{
    partial class frmOdev1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdev1));
            this.grpGiris = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.msktxtBaslangic = new System.Windows.Forms.MaskedTextBox();
            this.msktxtBitis = new System.Windows.Forms.MaskedTextBox();
            this.btnCalistir = new System.Windows.Forms.Button();
            this.tabSayilar = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lvTekSayilar = new System.Windows.Forms.ListView();
            this.lvCiftSayilar = new System.Windows.Forms.ListView();
            this.lvAsalSayilar = new System.Windows.Forms.ListView();
            this.lvMukemmelSayilar = new System.Windows.Forms.ListView();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.programaHoşgeldinizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nesneyeYönelimliProgramlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tekCiftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpGiris.SuspendLayout();
            this.tabSayilar.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGiris
            // 
            this.grpGiris.Controls.Add(this.btnCalistir);
            this.grpGiris.Controls.Add(this.msktxtBitis);
            this.grpGiris.Controls.Add(this.msktxtBaslangic);
            this.grpGiris.Controls.Add(this.label2);
            this.grpGiris.Controls.Add(this.label1);
            this.grpGiris.Location = new System.Drawing.Point(0, 0);
            this.grpGiris.Name = "grpGiris";
            this.grpGiris.Size = new System.Drawing.Size(788, 122);
            this.grpGiris.TabIndex = 0;
            this.grpGiris.TabStop = false;
            this.grpGiris.Text = "Giriş Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bitiş :";
            // 
            // msktxtBaslangic
            // 
            this.msktxtBaslangic.Location = new System.Drawing.Point(95, 49);
            this.msktxtBaslangic.Name = "msktxtBaslangic";
            this.msktxtBaslangic.Size = new System.Drawing.Size(100, 22);
            this.msktxtBaslangic.TabIndex = 2;
            // 
            // msktxtBitis
            // 
            this.msktxtBitis.Location = new System.Drawing.Point(391, 46);
            this.msktxtBitis.Name = "msktxtBitis";
            this.msktxtBitis.Size = new System.Drawing.Size(100, 22);
            this.msktxtBitis.TabIndex = 3;
            // 
            // btnCalistir
            // 
            this.btnCalistir.Location = new System.Drawing.Point(236, 93);
            this.btnCalistir.Name = "btnCalistir";
            this.btnCalistir.Size = new System.Drawing.Size(75, 23);
            this.btnCalistir.TabIndex = 4;
            this.btnCalistir.Text = "Çalıştır";
            this.btnCalistir.UseVisualStyleBackColor = true;
            this.btnCalistir.Click += new System.EventHandler(this.btnCalistir_Click);
            // 
            // tabSayilar
            // 
            this.tabSayilar.Controls.Add(this.tabPage1);
            this.tabSayilar.Controls.Add(this.tabPage2);
            this.tabSayilar.Controls.Add(this.tabPage3);
            this.tabSayilar.Controls.Add(this.tabPage4);
            this.tabSayilar.Location = new System.Drawing.Point(12, 149);
            this.tabSayilar.Name = "tabSayilar";
            this.tabSayilar.SelectedIndex = 0;
            this.tabSayilar.Size = new System.Drawing.Size(776, 289);
            this.tabSayilar.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvTekSayilar);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 260);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tek Sayılar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lvCiftSayilar);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 260);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Çift Sayılar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lvAsalSayilar);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 260);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Asal Sayılar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lvMukemmelSayilar);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(768, 260);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Mükemmel Sayılar";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lvTekSayilar
            // 
            this.lvTekSayilar.HideSelection = false;
            this.lvTekSayilar.Location = new System.Drawing.Point(20, 6);
            this.lvTekSayilar.Name = "lvTekSayilar";
            this.lvTekSayilar.Size = new System.Drawing.Size(710, 248);
            this.lvTekSayilar.TabIndex = 0;
            this.lvTekSayilar.UseCompatibleStateImageBehavior = false;
            // 
            // lvCiftSayilar
            // 
            this.lvCiftSayilar.HideSelection = false;
            this.lvCiftSayilar.Location = new System.Drawing.Point(20, 6);
            this.lvCiftSayilar.Name = "lvCiftSayilar";
            this.lvCiftSayilar.Size = new System.Drawing.Size(742, 248);
            this.lvCiftSayilar.TabIndex = 0;
            this.lvCiftSayilar.UseCompatibleStateImageBehavior = false;
            // 
            // lvAsalSayilar
            // 
            this.lvAsalSayilar.HideSelection = false;
            this.lvAsalSayilar.Location = new System.Drawing.Point(20, 6);
            this.lvAsalSayilar.Name = "lvAsalSayilar";
            this.lvAsalSayilar.Size = new System.Drawing.Size(725, 248);
            this.lvAsalSayilar.TabIndex = 0;
            this.lvAsalSayilar.UseCompatibleStateImageBehavior = false;
            // 
            // lvMukemmelSayilar
            // 
            this.lvMukemmelSayilar.HideSelection = false;
            this.lvMukemmelSayilar.Location = new System.Drawing.Point(20, 6);
            this.lvMukemmelSayilar.Name = "lvMukemmelSayilar";
            this.lvMukemmelSayilar.Size = new System.Drawing.Size(729, 248);
            this.lvMukemmelSayilar.TabIndex = 0;
            this.lvMukemmelSayilar.UseCompatibleStateImageBehavior = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Bildirim İçeriği";
            this.notifyIcon1.BalloonTipTitle = "Bildirim Başlığı";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Uygulama";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programaHoşgeldinizToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(231, 28);
            // 
            // programaHoşgeldinizToolStripMenuItem
            // 
            this.programaHoşgeldinizToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nesneyeYönelimliProgramlamaToolStripMenuItem});
            this.programaHoşgeldinizToolStripMenuItem.Name = "programaHoşgeldinizToolStripMenuItem";
            this.programaHoşgeldinizToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.programaHoşgeldinizToolStripMenuItem.Text = "Programa Hoşgeldiniz!";
            // 
            // nesneyeYönelimliProgramlamaToolStripMenuItem
            // 
            this.nesneyeYönelimliProgramlamaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tekCiftToolStripMenuItem});
            this.nesneyeYönelimliProgramlamaToolStripMenuItem.Name = "nesneyeYönelimliProgramlamaToolStripMenuItem";
            this.nesneyeYönelimliProgramlamaToolStripMenuItem.Size = new System.Drawing.Size(358, 26);
            this.nesneyeYönelimliProgramlamaToolStripMenuItem.Text = "Nesneye Yönelimli Programlama Ödev 1";
            // 
            // tekCiftToolStripMenuItem
            // 
            this.tekCiftToolStripMenuItem.Name = "tekCiftToolStripMenuItem";
            this.tekCiftToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tekCiftToolStripMenuItem.Text = "Tek Cift";
            // 
            // frmOdev1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabSayilar);
            this.Controls.Add(this.grpGiris);
            this.Name = "frmOdev1";
            this.Text = "Form1";
            this.grpGiris.ResumeLayout(false);
            this.grpGiris.PerformLayout();
            this.tabSayilar.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGiris;
        private System.Windows.Forms.Button btnCalistir;
        private System.Windows.Forms.MaskedTextBox msktxtBitis;
        private System.Windows.Forms.MaskedTextBox msktxtBaslangic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabSayilar;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView lvTekSayilar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lvCiftSayilar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView lvAsalSayilar;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView lvMukemmelSayilar;
        protected internal System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programaHoşgeldinizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nesneyeYönelimliProgramlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tekCiftToolStripMenuItem;
    }
}

