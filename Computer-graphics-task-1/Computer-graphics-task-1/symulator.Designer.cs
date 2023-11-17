using System.Threading;
using System.Diagnostics;
namespace Graf_kom
{
    partial class f_graf_kom
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
            Process.GetCurrentProcess().Kill();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picbx_ekran = new System.Windows.Forms.PictureBox();
            this.picbx_pamiec_obrazu = new System.Windows.Forms.PictureBox();
            this.lb_obraz_w_pamieci_opis = new System.Windows.Forms.Label();
            this.lb_obraz_na_ekranie_opis = new System.Windows.Forms.Label();
            this.b_load = new System.Windows.Forms.Button();
            this.lb_roz_obrazu_opis = new System.Windows.Forms.Label();
            this.lb_roz_obrazu = new System.Windows.Forms.Label();
            this.b_kolejna_klatka = new System.Windows.Forms.Button();
            this.b_reset = new System.Windows.Forms.Button();
            this.lb_nr_klatki = new System.Windows.Forms.Label();
            this.b_start = new System.Windows.Forms.Button();
            this.b_stop = new System.Windows.Forms.Button();
            this.rb_przesuwanie = new System.Windows.Forms.RadioButton();
            this.rb_przewijanie = new System.Windows.Forms.RadioButton();
            this.rb_zaslanianie = new System.Windows.Forms.RadioButton();
            this.lb_efekty_opis = new System.Windows.Forms.Label();
            this.lb_wykonywanie_opis = new System.Windows.Forms.Label();
            this.lb_po_klatce_opis = new System.Windows.Forms.Label();
            this.timer_automat = new System.Windows.Forms.Timer(this.components);
            this.b_zmien_obraz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.radioButtonHLS = new System.Windows.Forms.RadioButton();
            this.radioButtonHSV = new System.Windows.Forms.RadioButton();
            this.radioButtonAvg = new System.Windows.Forms.RadioButton();
            this.brightnessLabel = new System.Windows.Forms.Label();
            this.contrastLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonBC = new System.Windows.Forms.RadioButton();
            this.brightnessBar = new System.Windows.Forms.HScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contrastBar = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_ekran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_pamiec_obrazu)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picbx_ekran
            // 
            this.picbx_ekran.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbx_ekran.Location = new System.Drawing.Point(350, 96);
            this.picbx_ekran.Name = "picbx_ekran";
            this.picbx_ekran.Size = new System.Drawing.Size(200, 200);
            this.picbx_ekran.TabIndex = 0;
            this.picbx_ekran.TabStop = false;
            // 
            // picbx_pamiec_obrazu
            // 
            this.picbx_pamiec_obrazu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbx_pamiec_obrazu.Location = new System.Drawing.Point(11, 96);
            this.picbx_pamiec_obrazu.Name = "picbx_pamiec_obrazu";
            this.picbx_pamiec_obrazu.Size = new System.Drawing.Size(200, 200);
            this.picbx_pamiec_obrazu.TabIndex = 2;
            this.picbx_pamiec_obrazu.TabStop = false;
            // 
            // lb_obraz_w_pamieci_opis
            // 
            this.lb_obraz_w_pamieci_opis.AutoSize = true;
            this.lb_obraz_w_pamieci_opis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_obraz_w_pamieci_opis.Location = new System.Drawing.Point(8, 77);
            this.lb_obraz_w_pamieci_opis.Name = "lb_obraz_w_pamieci_opis";
            this.lb_obraz_w_pamieci_opis.Size = new System.Drawing.Size(110, 16);
            this.lb_obraz_w_pamieci_opis.TabIndex = 3;
            this.lb_obraz_w_pamieci_opis.Text = "Image in memory";
            // 
            // lb_obraz_na_ekranie_opis
            // 
            this.lb_obraz_na_ekranie_opis.AutoSize = true;
            this.lb_obraz_na_ekranie_opis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_obraz_na_ekranie_opis.Location = new System.Drawing.Point(350, 77);
            this.lb_obraz_na_ekranie_opis.Name = "lb_obraz_na_ekranie_opis";
            this.lb_obraz_na_ekranie_opis.Size = new System.Drawing.Size(91, 16);
            this.lb_obraz_na_ekranie_opis.TabIndex = 4;
            this.lb_obraz_na_ekranie_opis.Text = "Screen image";
            // 
            // b_load
            // 
            this.b_load.Location = new System.Drawing.Point(248, 117);
            this.b_load.Name = "b_load";
            this.b_load.Size = new System.Drawing.Size(75, 23);
            this.b_load.TabIndex = 5;
            this.b_load.Text = "LOAD";
            this.b_load.UseVisualStyleBackColor = true;
            this.b_load.Click += new System.EventHandler(this.b_load_Click);
            // 
            // lb_roz_obrazu_opis
            // 
            this.lb_roz_obrazu_opis.AutoSize = true;
            this.lb_roz_obrazu_opis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_roz_obrazu_opis.Location = new System.Drawing.Point(121, 77);
            this.lb_roz_obrazu_opis.Name = "lb_roz_obrazu_opis";
            this.lb_roz_obrazu_opis.Size = new System.Drawing.Size(44, 16);
            this.lb_roz_obrazu_opis.TabIndex = 6;
            this.lb_roz_obrazu_opis.Text = "L x K =";
            // 
            // lb_roz_obrazu
            // 
            this.lb_roz_obrazu.AutoSize = true;
            this.lb_roz_obrazu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_roz_obrazu.Location = new System.Drawing.Point(163, 77);
            this.lb_roz_obrazu.Name = "lb_roz_obrazu";
            this.lb_roz_obrazu.Size = new System.Drawing.Size(33, 16);
            this.lb_roz_obrazu.TabIndex = 7;
            this.lb_roz_obrazu.Text = "0 x 0";
            // 
            // b_kolejna_klatka
            // 
            this.b_kolejna_klatka.Enabled = false;
            this.b_kolejna_klatka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_kolejna_klatka.Location = new System.Drawing.Point(613, 261);
            this.b_kolejna_klatka.Name = "b_kolejna_klatka";
            this.b_kolejna_klatka.Size = new System.Drawing.Size(108, 23);
            this.b_kolejna_klatka.TabIndex = 10;
            this.b_kolejna_klatka.Text = "Next frame";
            this.b_kolejna_klatka.UseVisualStyleBackColor = true;
            this.b_kolejna_klatka.Click += new System.EventHandler(this.b_kolejna_klatka_Click);
            // 
            // b_reset
            // 
            this.b_reset.Enabled = false;
            this.b_reset.Location = new System.Drawing.Point(248, 247);
            this.b_reset.Name = "b_reset";
            this.b_reset.Size = new System.Drawing.Size(75, 23);
            this.b_reset.TabIndex = 17;
            this.b_reset.Text = "RESET";
            this.b_reset.UseVisualStyleBackColor = true;
            this.b_reset.Click += new System.EventHandler(this.b_reset_Click);
            // 
            // lb_nr_klatki
            // 
            this.lb_nr_klatki.AutoSize = true;
            this.lb_nr_klatki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_nr_klatki.Location = new System.Drawing.Point(612, 297);
            this.lb_nr_klatki.Name = "lb_nr_klatki";
            this.lb_nr_klatki.Size = new System.Drawing.Size(61, 16);
            this.lb_nr_klatki.TabIndex = 20;
            this.lb_nr_klatki.Text = "frame = 0";
            this.lb_nr_klatki.Click += new System.EventHandler(this.lb_nr_klatki_Click);
            // 
            // b_start
            // 
            this.b_start.Enabled = false;
            this.b_start.Location = new System.Drawing.Point(613, 208);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(51, 23);
            this.b_start.TabIndex = 21;
            this.b_start.Text = "START";
            this.b_start.UseVisualStyleBackColor = true;
            this.b_start.Click += new System.EventHandler(this.b_start_Click);
            // 
            // b_stop
            // 
            this.b_stop.Enabled = false;
            this.b_stop.Location = new System.Drawing.Point(670, 208);
            this.b_stop.Name = "b_stop";
            this.b_stop.Size = new System.Drawing.Size(51, 23);
            this.b_stop.TabIndex = 22;
            this.b_stop.Text = "STOP";
            this.b_stop.UseVisualStyleBackColor = true;
            this.b_stop.Click += new System.EventHandler(this.b_stop_Click);
            // 
            // rb_przesuwanie
            // 
            this.rb_przesuwanie.AutoSize = true;
            this.rb_przesuwanie.Checked = true;
            this.rb_przesuwanie.Location = new System.Drawing.Point(612, 98);
            this.rb_przesuwanie.Name = "rb_przesuwanie";
            this.rb_przesuwanie.Size = new System.Drawing.Size(258, 17);
            this.rb_przesuwanie.TabIndex = 23;
            this.rb_przesuwanie.TabStop = true;
            this.rb_przesuwanie.Text = "Shifting effect towards the right side of the screen";
            this.rb_przesuwanie.UseVisualStyleBackColor = true;
            // 
            // rb_przewijanie
            // 
            this.rb_przewijanie.AutoSize = true;
            this.rb_przewijanie.Location = new System.Drawing.Point(612, 120);
            this.rb_przewijanie.Name = "rb_przewijanie";
            this.rb_przewijanie.Size = new System.Drawing.Size(380, 17);
            this.rb_przewijanie.TabIndex = 24;
            this.rb_przewijanie.Text = "Effect of scrolling along the diagonal of the screen towards the top-left apex";
            this.rb_przewijanie.UseVisualStyleBackColor = true;
            // 
            // rb_zaslanianie
            // 
            this.rb_zaslanianie.AutoSize = true;
            this.rb_zaslanianie.Location = new System.Drawing.Point(612, 142);
            this.rb_zaslanianie.Name = "rb_zaslanianie";
            this.rb_zaslanianie.Size = new System.Drawing.Size(233, 17);
            this.rb_zaslanianie.TabIndex = 25;
            this.rb_zaslanianie.Text = "Blinding effect towards the top of the screen";
            this.rb_zaslanianie.UseVisualStyleBackColor = true;
            // 
            // lb_efekty_opis
            // 
            this.lb_efekty_opis.AutoSize = true;
            this.lb_efekty_opis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_efekty_opis.Location = new System.Drawing.Point(610, 77);
            this.lb_efekty_opis.Name = "lb_efekty_opis";
            this.lb_efekty_opis.Size = new System.Drawing.Size(47, 16);
            this.lb_efekty_opis.TabIndex = 26;
            this.lb_efekty_opis.Text = "Effects";
            // 
            // lb_wykonywanie_opis
            // 
            this.lb_wykonywanie_opis.AutoSize = true;
            this.lb_wykonywanie_opis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_wykonywanie_opis.Location = new System.Drawing.Point(613, 189);
            this.lb_wykonywanie_opis.Name = "lb_wykonywanie_opis";
            this.lb_wykonywanie_opis.Size = new System.Drawing.Size(101, 16);
            this.lb_wykonywanie_opis.TabIndex = 27;
            this.lb_wykonywanie_opis.Text = "Implementation:";
            this.lb_wykonywanie_opis.Click += new System.EventHandler(this.lb_wykonywanie_opis_Click);
            // 
            // lb_po_klatce_opis
            // 
            this.lb_po_klatce_opis.AutoSize = true;
            this.lb_po_klatce_opis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_po_klatce_opis.Location = new System.Drawing.Point(613, 242);
            this.lb_po_klatce_opis.Name = "lb_po_klatce_opis";
            this.lb_po_klatce_opis.Size = new System.Drawing.Size(122, 16);
            this.lb_po_klatce_opis.TabIndex = 29;
            this.lb_po_klatce_opis.Text = "One frame at a time";
            // 
            // timer_automat
            // 
            this.timer_automat.Tick += new System.EventHandler(this.timer_automat_Tick);
            // 
            // b_zmien_obraz
            // 
            this.b_zmien_obraz.Enabled = false;
            this.b_zmien_obraz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_zmien_obraz.Location = new System.Drawing.Point(613, 329);
            this.b_zmien_obraz.Name = "b_zmien_obraz";
            this.b_zmien_obraz.Size = new System.Drawing.Size(108, 32);
            this.b_zmien_obraz.TabIndex = 30;
            this.b_zmien_obraz.Text = "Change image";
            this.b_zmien_obraz.UseVisualStyleBackColor = true;
            this.b_zmien_obraz.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Bartosz Baniak";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(325, 338);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(257, 23);
            this.progressBar1.TabIndex = 32;
            // 
            // radioButtonHLS
            // 
            this.radioButtonHLS.AutoSize = true;
            this.radioButtonHLS.Location = new System.Drawing.Point(6, 35);
            this.radioButtonHLS.Name = "radioButtonHLS";
            this.radioButtonHLS.Size = new System.Drawing.Size(46, 17);
            this.radioButtonHLS.TabIndex = 34;
            this.radioButtonHLS.Text = "HLS";
            this.radioButtonHLS.UseVisualStyleBackColor = true;
            // 
            // radioButtonHSV
            // 
            this.radioButtonHSV.AutoSize = true;
            this.radioButtonHSV.Location = new System.Drawing.Point(6, 58);
            this.radioButtonHSV.Name = "radioButtonHSV";
            this.radioButtonHSV.Size = new System.Drawing.Size(60, 17);
            this.radioButtonHSV.TabIndex = 35;
            this.radioButtonHSV.Text = "HSV(B)";
            this.radioButtonHSV.UseVisualStyleBackColor = true;
            // 
            // radioButtonAvg
            // 
            this.radioButtonAvg.AutoSize = true;
            this.radioButtonAvg.Location = new System.Drawing.Point(7, 81);
            this.radioButtonAvg.Name = "radioButtonAvg";
            this.radioButtonAvg.Size = new System.Drawing.Size(47, 17);
            this.radioButtonAvg.TabIndex = 36;
            this.radioButtonAvg.Text = "AVG";
            this.radioButtonAvg.UseVisualStyleBackColor = true;
            // 
            // brightnessLabel
            // 
            this.brightnessLabel.AutoSize = true;
            this.brightnessLabel.Location = new System.Drawing.Point(813, 309);
            this.brightnessLabel.Name = "brightnessLabel";
            this.brightnessLabel.Size = new System.Drawing.Size(59, 13);
            this.brightnessLabel.TabIndex = 37;
            this.brightnessLabel.Text = "Brightness:";
            // 
            // contrastLabel
            // 
            this.contrastLabel.AutoSize = true;
            this.contrastLabel.Location = new System.Drawing.Point(813, 329);
            this.contrastLabel.Name = "contrastLabel";
            this.contrastLabel.Size = new System.Drawing.Size(49, 13);
            this.contrastLabel.TabIndex = 38;
            this.contrastLabel.Text = "Contrast:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonBC);
            this.panel1.Controls.Add(this.radioButtonHLS);
            this.panel1.Controls.Add(this.radioButtonHSV);
            this.panel1.Controls.Add(this.radioButtonAvg);
            this.panel1.Location = new System.Drawing.Point(812, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 101);
            this.panel1.TabIndex = 39;
            // 
            // radioButtonBC
            // 
            this.radioButtonBC.AutoSize = true;
            this.radioButtonBC.Checked = true;
            this.radioButtonBC.Location = new System.Drawing.Point(6, 12);
            this.radioButtonBC.Name = "radioButtonBC";
            this.radioButtonBC.Size = new System.Drawing.Size(118, 17);
            this.radioButtonBC.TabIndex = 40;
            this.radioButtonBC.TabStop = true;
            this.radioButtonBC.Text = "Brightness/Contrast";
            this.radioButtonBC.UseVisualStyleBackColor = true;
            // 
            // brightnessBar
            // 
            this.brightnessBar.LargeChange = 1;
            this.brightnessBar.Location = new System.Drawing.Point(73, 309);
            this.brightnessBar.Maximum = 255;
            this.brightnessBar.Minimum = -255;
            this.brightnessBar.Name = "brightnessBar";
            this.brightnessBar.Size = new System.Drawing.Size(138, 17);
            this.brightnessBar.TabIndex = 40;
            this.brightnessBar.ValueChanged += new System.EventHandler(this.brightnessBar_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Brightness";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Contrast";
            // 
            // contrastBar
            // 
            this.contrastBar.LargeChange = 1;
            this.contrastBar.Location = new System.Drawing.Point(73, 338);
            this.contrastBar.Maximum = 157;
            this.contrastBar.Name = "contrastBar";
            this.contrastBar.Size = new System.Drawing.Size(138, 17);
            this.contrastBar.TabIndex = 43;
            this.contrastBar.Value = 78;
            this.contrastBar.ValueChanged += new System.EventHandler(this.contrastBar_ValueChanged);
            // 
            // f_graf_kom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 384);
            this.Controls.Add(this.contrastBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.brightnessBar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.contrastLabel);
            this.Controls.Add(this.brightnessLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_zmien_obraz);
            this.Controls.Add(this.lb_po_klatce_opis);
            this.Controls.Add(this.lb_wykonywanie_opis);
            this.Controls.Add(this.lb_efekty_opis);
            this.Controls.Add(this.rb_zaslanianie);
            this.Controls.Add(this.rb_przewijanie);
            this.Controls.Add(this.rb_przesuwanie);
            this.Controls.Add(this.b_stop);
            this.Controls.Add(this.b_start);
            this.Controls.Add(this.lb_nr_klatki);
            this.Controls.Add(this.b_reset);
            this.Controls.Add(this.b_kolejna_klatka);
            this.Controls.Add(this.lb_roz_obrazu);
            this.Controls.Add(this.lb_roz_obrazu_opis);
            this.Controls.Add(this.b_load);
            this.Controls.Add(this.lb_obraz_na_ekranie_opis);
            this.Controls.Add(this.lb_obraz_w_pamieci_opis);
            this.Controls.Add(this.picbx_pamiec_obrazu);
            this.Controls.Add(this.picbx_ekran);
            this.Location = new System.Drawing.Point(200, 100);
            this.MaximizeBox = false;
            this.Name = "f_graf_kom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Effects simulator";
            this.Load += new System.EventHandler(this.f_graf_kom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbx_ekran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_pamiec_obrazu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbx_ekran;
        private System.Windows.Forms.PictureBox picbx_pamiec_obrazu;
        private System.Windows.Forms.Label lb_obraz_w_pamieci_opis;
        private System.Windows.Forms.Label lb_obraz_na_ekranie_opis;
        private System.Windows.Forms.Button b_load;
        private System.Windows.Forms.Label lb_roz_obrazu_opis;
        private System.Windows.Forms.Label lb_roz_obrazu;
        private System.Windows.Forms.Button b_kolejna_klatka;
        private System.Windows.Forms.Button b_reset;
        private System.Windows.Forms.Label lb_nr_klatki;
        private System.Windows.Forms.Button b_start;
        private System.Windows.Forms.Button b_stop;
        private System.Windows.Forms.RadioButton rb_przesuwanie;
        private System.Windows.Forms.RadioButton rb_przewijanie;
        private System.Windows.Forms.RadioButton rb_zaslanianie;
        private System.Windows.Forms.Label lb_efekty_opis;
        private System.Windows.Forms.Label lb_wykonywanie_opis;
        private System.Windows.Forms.Label lb_po_klatce_opis;
        private System.Windows.Forms.Timer timer_automat;
        private System.Windows.Forms.Button b_zmien_obraz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RadioButton radioButtonHLS;
        private System.Windows.Forms.RadioButton radioButtonHSV;
        private System.Windows.Forms.RadioButton radioButtonAvg;
        private System.Windows.Forms.Label brightnessLabel;
        private System.Windows.Forms.Label contrastLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonBC;
        private System.Windows.Forms.HScrollBar brightnessBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HScrollBar contrastBar;
    }
}

