
namespace Tehtävä_15
{
    partial class SekkariForm
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
            this.components = new System.ComponentModel.Container();
            this.AikaLB = new System.Windows.Forms.Label();
            this.KaunnistaBT = new System.Windows.Forms.Button();
            this.TyhjennaBT = new System.Windows.Forms.Button();
            this.LopetaBT = new System.Windows.Forms.Button();
            this.AjanottoTM = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // AikaLB
            // 
            this.AikaLB.AutoSize = true;
            this.AikaLB.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AikaLB.Location = new System.Drawing.Point(48, 9);
            this.AikaLB.Name = "AikaLB";
            this.AikaLB.Size = new System.Drawing.Size(533, 128);
            this.AikaLB.TabIndex = 0;
            this.AikaLB.Text = "00:00:00:00";
            // 
            // KaunnistaBT
            // 
            this.KaunnistaBT.Location = new System.Drawing.Point(113, 187);
            this.KaunnistaBT.Name = "KaunnistaBT";
            this.KaunnistaBT.Size = new System.Drawing.Size(75, 23);
            this.KaunnistaBT.TabIndex = 1;
            this.KaunnistaBT.Text = "Käynnistä";
            this.KaunnistaBT.UseVisualStyleBackColor = true;
            this.KaunnistaBT.Click += new System.EventHandler(this.KaunnistaBT_Click);
            // 
            // TyhjennaBT
            // 
            this.TyhjennaBT.Location = new System.Drawing.Point(451, 187);
            this.TyhjennaBT.Name = "TyhjennaBT";
            this.TyhjennaBT.Size = new System.Drawing.Size(75, 23);
            this.TyhjennaBT.TabIndex = 2;
            this.TyhjennaBT.Text = "Tyhjennä";
            this.TyhjennaBT.UseVisualStyleBackColor = true;
            this.TyhjennaBT.Click += new System.EventHandler(this.TyhjennaBT_Click);
            // 
            // LopetaBT
            // 
            this.LopetaBT.Location = new System.Drawing.Point(282, 187);
            this.LopetaBT.Name = "LopetaBT";
            this.LopetaBT.Size = new System.Drawing.Size(75, 23);
            this.LopetaBT.TabIndex = 3;
            this.LopetaBT.Text = "Lopeta";
            this.LopetaBT.UseVisualStyleBackColor = true;
            this.LopetaBT.Click += new System.EventHandler(this.LopetaBT_Click);
            // 
            // AjanottoTM
            // 
            this.AjanottoTM.Enabled = true;
            this.AjanottoTM.Tick += new System.EventHandler(this.AjanottoTM_Tick);
            // 
            // SekkariForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 268);
            this.Controls.Add(this.LopetaBT);
            this.Controls.Add(this.TyhjennaBT);
            this.Controls.Add(this.KaunnistaBT);
            this.Controls.Add(this.AikaLB);
            this.Name = "SekkariForm";
            this.Text = "Stopwatch";
            this.Load += new System.EventHandler(this.SekkariForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AikaLB;
        private System.Windows.Forms.Button KaunnistaBT;
        private System.Windows.Forms.Button TyhjennaBT;
        private System.Windows.Forms.Button LopetaBT;
        private System.Windows.Forms.Timer AjanottoTM;
    }
}

