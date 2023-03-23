
namespace editor
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
            this.otvor = new System.Windows.Forms.Button();
            this.mojText = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.otazka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pridaj = new System.Windows.Forms.Button();
            this.A = new System.Windows.Forms.TextBox();
            this.D = new System.Windows.Forms.TextBox();
            this.C = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ulozit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // otvor
            // 
            this.otvor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.otvor.Location = new System.Drawing.Point(1148, 457);
            this.otvor.Name = "otvor";
            this.otvor.Size = new System.Drawing.Size(125, 38);
            this.otvor.TabIndex = 0;
            this.otvor.Text = "Otvor";
            this.otvor.UseVisualStyleBackColor = true;
            this.otvor.Click += new System.EventHandler(this.otvor_Click);
            // 
            // mojText
            // 
            this.mojText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mojText.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mojText.Location = new System.Drawing.Point(23, 60);
            this.mojText.Name = "mojText";
            this.mojText.Size = new System.Drawing.Size(1268, 310);
            this.mojText.TabIndex = 1;
            this.mojText.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(1148, 711);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Koniec";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // otazka
            // 
            this.otazka.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.otazka.Location = new System.Drawing.Point(23, 457);
            this.otazka.Name = "otazka";
            this.otazka.Size = new System.Drawing.Size(1017, 33);
            this.otazka.TabIndex = 3;
            this.otazka.TextChanged += new System.EventHandler(this.otazka_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(23, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Zadajte otázku:";
            // 
            // pridaj
            // 
            this.pridaj.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pridaj.Location = new System.Drawing.Point(1148, 581);
            this.pridaj.Name = "pridaj";
            this.pridaj.Size = new System.Drawing.Size(125, 38);
            this.pridaj.TabIndex = 6;
            this.pridaj.Text = "Pridaj otázku";
            this.pridaj.UseVisualStyleBackColor = true;
            this.pridaj.Click += new System.EventHandler(this.pridaj_Click);
            // 
            // A
            // 
            this.A.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A.Location = new System.Drawing.Point(36, 104);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(457, 33);
            this.A.TabIndex = 7;
            this.A.TextChanged += new System.EventHandler(this.A_TextChanged);
            // 
            // D
            // 
            this.D.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.D.Location = new System.Drawing.Point(518, 185);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(457, 33);
            this.D.TabIndex = 8;
            this.D.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // C
            // 
            this.C.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.C.Location = new System.Drawing.Point(36, 185);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(457, 33);
            this.C.TabIndex = 9;
            this.C.TextChanged += new System.EventHandler(this.C_TextChanged);
            // 
            // B
            // 
            this.B.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.B.Location = new System.Drawing.Point(518, 104);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(457, 33);
            this.B.TabIndex = 10;
            this.B.TextChanged += new System.EventHandler(this.B_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.A);
            this.panel1.Controls.Add(this.D);
            this.panel1.Controls.Add(this.C);
            this.panel1.Controls.Add(this.B);
            this.panel1.Location = new System.Drawing.Point(28, 531);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 258);
            this.panel1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(32, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sem zadajte správnu odpoveď:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(31, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Zadajte odpovede:";
            // 
            // ulozit
            // 
            this.ulozit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ulozit.Location = new System.Drawing.Point(1148, 635);
            this.ulozit.Name = "ulozit";
            this.ulozit.Size = new System.Drawing.Size(125, 38);
            this.ulozit.TabIndex = 12;
            this.ulozit.Text = "Uložiť";
            this.ulozit.UseVisualStyleBackColor = true;
            this.ulozit.Click += new System.EventHandler(this.ulozit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(28, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 827);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ulozit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pridaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.otazka);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mojText);
            this.Controls.Add(this.otvor);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button otvor;
        private System.Windows.Forms.RichTextBox mojText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox otazka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pridaj;
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.TextBox D;
        private System.Windows.Forms.TextBox C;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ulozit;
        private System.Windows.Forms.Label label4;
    }
}

