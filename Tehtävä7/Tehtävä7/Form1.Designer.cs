
namespace Tehtävä7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.VastausLB = new System.Windows.Forms.Label();
            this.LainaTB = new System.Windows.Forms.TextBox();
            this.NesteetTB = new System.Windows.Forms.TextBox();
            this.VakuutuksetTB = new System.Windows.Forms.TextBox();
            this.MuutTB = new System.Windows.Forms.TextBox();
            this.PesutTB = new System.Windows.Forms.TextBox();
            this.HuollotTB = new System.Windows.Forms.TextBox();
            this.RenkaatTB = new System.Windows.Forms.TextBox();
            this.PolttonesteTB = new System.Windows.Forms.TextBox();
            this.KilometriCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(217, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Autonkustannuslaskuri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lainan lyhennys korkoineen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lisättävät nesteet yms:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vakuutusmaksut";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Muut kulut";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pesut:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(389, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Huollot";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(389, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Renkaat:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(389, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Kilometrit/vuosi:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Polttoneste";
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(42, 383);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(193, 15);
            this.VastausLB.TabIndex = 10;
            this.VastausLB.Text = "Kustannukset kilometriä kohti ovat:";
            // 
            // LainaTB
            // 
            this.LainaTB.Location = new System.Drawing.Point(202, 108);
            this.LainaTB.Name = "LainaTB";
            this.LainaTB.Size = new System.Drawing.Size(100, 23);
            this.LainaTB.TabIndex = 11;
            // 
            // NesteetTB
            // 
            this.NesteetTB.Location = new System.Drawing.Point(202, 173);
            this.NesteetTB.Name = "NesteetTB";
            this.NesteetTB.Size = new System.Drawing.Size(100, 23);
            this.NesteetTB.TabIndex = 12;
            // 
            // VakuutuksetTB
            // 
            this.VakuutuksetTB.Location = new System.Drawing.Point(202, 223);
            this.VakuutuksetTB.Name = "VakuutuksetTB";
            this.VakuutuksetTB.Size = new System.Drawing.Size(100, 23);
            this.VakuutuksetTB.TabIndex = 13;
            // 
            // MuutTB
            // 
            this.MuutTB.Location = new System.Drawing.Point(202, 266);
            this.MuutTB.Name = "MuutTB";
            this.MuutTB.Size = new System.Drawing.Size(100, 23);
            this.MuutTB.TabIndex = 14;
            // 
            // PesutTB
            // 
            this.PesutTB.Location = new System.Drawing.Point(504, 113);
            this.PesutTB.Name = "PesutTB";
            this.PesutTB.Size = new System.Drawing.Size(100, 23);
            this.PesutTB.TabIndex = 15;
            // 
            // HuollotTB
            // 
            this.HuollotTB.Location = new System.Drawing.Point(504, 165);
            this.HuollotTB.Name = "HuollotTB";
            this.HuollotTB.Size = new System.Drawing.Size(100, 23);
            this.HuollotTB.TabIndex = 16;
            this.HuollotTB.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // RenkaatTB
            // 
            this.RenkaatTB.Location = new System.Drawing.Point(504, 218);
            this.RenkaatTB.Name = "RenkaatTB";
            this.RenkaatTB.Size = new System.Drawing.Size(100, 23);
            this.RenkaatTB.TabIndex = 17;
            // 
            // PolttonesteTB
            // 
            this.PolttonesteTB.Location = new System.Drawing.Point(202, 324);
            this.PolttonesteTB.Name = "PolttonesteTB";
            this.PolttonesteTB.Size = new System.Drawing.Size(100, 23);
            this.PolttonesteTB.TabIndex = 18;
            // 
            // KilometriCB
            // 
            this.KilometriCB.FormattingEnabled = true;
            this.KilometriCB.Items.AddRange(new object[] {
            "1000",
            "2000",
            "3000",
            "5000",
            "10000",
            "15000",
            "20000",
            "25000",
            "30000",
            "40000",
            "50000"});
            this.KilometriCB.Location = new System.Drawing.Point(504, 266);
            this.KilometriCB.Name = "KilometriCB";
            this.KilometriCB.Size = new System.Drawing.Size(121, 23);
            this.KilometriCB.TabIndex = 19;
            this.KilometriCB.SelectedIndexChanged += new System.EventHandler(this.KilometriCB_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KilometriCB);
            this.Controls.Add(this.PolttonesteTB);
            this.Controls.Add(this.RenkaatTB);
            this.Controls.Add(this.HuollotTB);
            this.Controls.Add(this.PesutTB);
            this.Controls.Add(this.MuutTB);
            this.Controls.Add(this.VakuutuksetTB);
            this.Controls.Add(this.NesteetTB);
            this.Controls.Add(this.LainaTB);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kilometrikulutuslaskuri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label VastausLB;
        private System.Windows.Forms.TextBox LainaTB;
        private System.Windows.Forms.TextBox NesteetTB;
        private System.Windows.Forms.TextBox VakuutuksetTB;
        private System.Windows.Forms.TextBox MuutTB;
        private System.Windows.Forms.TextBox PesutTB;
        private System.Windows.Forms.TextBox HuollotTB;
        private System.Windows.Forms.TextBox RenkaatTB;
        private System.Windows.Forms.TextBox PolttonesteTB;
        private System.Windows.Forms.ComboBox KilometriCB;
    }
}

