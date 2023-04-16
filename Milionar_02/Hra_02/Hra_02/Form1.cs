using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Hra_02
{
    public partial class Form1 : Form
    {
        Label[] suma;
        Label[] co;
        
        string vyhra = "0 €";
        string garantovana_vyhra = "0 €";


        public partial class Otazka
        {
            public string oText;
            public string A;
            public string B;
            public string C;
            public string D;
            public string OK;
            public string p1;
            public string p2;
        }

        Otazka q = new Otazka();

        public Form1()
        {
            InitializeComponent();
        }

        int[,] perm = new int[24,4];

        int[,] v50 = new int[6, 2];

        int level, pocet_otazok_suboru, vyber_otazku_cislo, i, permutacia, permutacia_vymazat;
        string subor, odpoved, klikol_si;

        bool klikol_z50 = false;

        public void Oznac(string p)
        {
            hodnotenie.Enabled = true;
            A.BackColor = Color.LightGray;
            B.BackColor = Color.LightGray;
            C.BackColor = Color.LightGray;
            D.BackColor = Color.LightGray;
            label1.BackColor = Color.LightGray;
            label2.BackColor = Color.LightGray;
            label3.BackColor = Color.LightGray;
            label4.BackColor = Color.LightGray;

            switch (p)
            {
                case "A":
                    A.BackColor = Color.DodgerBlue;
                    label1.BackColor = Color.DodgerBlue;
                    odpoved = q.A;                
                    break;

                case "B":
                    B.BackColor = Color.DodgerBlue;
                    label2.BackColor = Color.DodgerBlue;
                    odpoved = q.B;                
                    break;

                case "C":
                    C.BackColor = Color.DodgerBlue;
                    label3.BackColor = Color.DodgerBlue;
                    odpoved = q.C;                  
                    break;

                case "D":
                    D.BackColor = Color.DodgerBlue;
                    label4.BackColor = Color.DodgerBlue;
                    odpoved = q.D;                   
                    break;
            }
          
        }
        private void A_Click(object sender, EventArgs e)
        {
            klikol_si = "A";
            Oznac("A");           
        }

        private void label4_Click(object sender, EventArgs e)
        {
            klikol_si = "D";
            Oznac("D");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            klikol_si = "A";
            Oznac("A");
        }

        private void B_Click(object sender, EventArgs e)
        {
            klikol_si = "B";
            Oznac("B");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            klikol_si = "B";
            Oznac("B");
        }

        private void C_Click(object sender, EventArgs e)
        {
            klikol_si = "C";
            Oznac("C");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            klikol_si = "C";
            Oznac("C");
        }


        private void zPublikum_Click(object sender, EventArgs e)
        {
            zPublikum.Enabled = false;
            int h1, h2, h3, h4;
            string s1, s2, s3, s4, s="";
              
            if (A.Text != "") s += "A";
            if (B.Text != "") s += "B";
            if (C.Text != "") s += "C";
            if (D.Text != "") s += "D";
                  
            graf.Series.Add("Series");
            graf.ChartAreas[0].AxisY.Maximum = 100;
            graf.ChartAreas[0].AxisY.Minimum = 0;
            graf.ChartAreas[0].AxisY.Interval = 10;
            graf.ChartAreas[0].AxisX.Title = "Hlasovanie publika";
            
            if (klikol_z50 && label5.Text == "OK")
            {
                h1 = rnd.Next(100);
                h2 = 100 - h1;
                s1 = s.Substring(0, 1);
                s2 = s.Substring(1, 1);
                graf.Series["Series"].Points.AddXY(s1, h1);
                graf.Series["Series"].Points.AddXY(s2, h2);
            }

            else
            {
                h1 = rnd.Next(100);
                h2 = rnd.Next(100 - h1);
                h3 = rnd.Next(100 - h1 - h2);
                h4 = 100 - h1 - h2 - h3;
                s1 = s.Substring(0, 1);
                s2 = s.Substring(1, 1);
                s3 = s.Substring(2, 1);
                s4 = s.Substring(3, 1);
                graf.Series["Series"].Points.AddXY(s1, h1);
                graf.Series["Series"].Points.AddXY(s2, h2);
                graf.Series["Series"].Points.AddXY(s3, h3);
                graf.Series["Series"].Points.AddXY(s4, h4);
            }
            graf.Visible = true;
        }

        private void zTelefon_Click(object sender, EventArgs e)
        {        
            zTelefon.Enabled = false;
            priatel.Visible = true;
            string odpoved_priatel = "";
            string s1, s2, s = "";

            if (A.Text != "") s +=  "A";
            if (B.Text != "") s +=  "B";
            if (C.Text != "") s +=  "C";
            if (D.Text != "") s +=  "D";

            if (klikol_z50)
            {
                s1 = s.Substring(0, 1);
                s2 = s.Substring(1, 1);
                switch (rnd.Next(3))
                {
                    case 0:
                        odpoved_priatel = "Ja by som zvolil odpoveď " + s1;
                        break;
                    case 1:
                        odpoved_priatel = "Ja by som zvolil odpoveď " + s2;
                        break;
                    case 2:
                        odpoved_priatel = "Je mi ľúto, ale neviem ti poradiť, musíš sa rozhodnúť sám.";
                        break;
                }
            }

            else
            {
                switch (rnd.Next(5))
                {
                    case 0:
                        odpoved_priatel = "Ja by som zvolil odpoveď A";
                        break;
                    case 1:
                        odpoved_priatel = "Ja by som zvolil odpoveď B";
                        break;
                    case 2:
                        odpoved_priatel = "Ja by som zvolil odpoveď C";
                        break;
                    case 3:
                        odpoved_priatel = "Ja by som zvolil odpoveď D";
                        break;
                    case 4:
                        odpoved_priatel = "Je mi ľúto, ale neviem ti poradiť, musíš sa rozhodnúť sám.";
                        break;
                }
            }                                       
            priatel.Text = odpoved_priatel;
        }

        public void ukoncenie_hry(int ako)
        {
            if (level < 13)
            {
                if (ako == 1) MessageBox.Show("Vyhrali ste " + vyhra);
                ButtonyPlusFunkcieVypnutie();
                if (ako == 0) MessageBox.Show("Vyhrali ste " + garantovana_vyhra);
                ButtonyPlusFunkcieVypnutie();
            }
        }

        private void ukoncenie_Click(object sender, EventArgs e)
        {
            ukoncenie_hry(1);
            ukoncenie.Enabled = false;
            if (ukoncenie.Enabled = false && ((A.BackColor == Color.LightGray) || (B.BackColor == Color.LightGray))) 
            {
                if(ukoncenie.Enabled = false && ((C.BackColor == Color.LightGray) || (D.BackColor == Color.LightGray)))
                {
                    A.BackColor = Color.LightGray;
                    B.BackColor = Color.LightGray;
                    C.BackColor = Color.LightGray;
                    D.BackColor = Color.LightGray;
                    label1.BackColor = Color.LightGray;
                    label2.BackColor = Color.LightGray;
                    label3.BackColor = Color.LightGray;
                    label4.BackColor = Color.LightGray;
                    hodnotenie.Enabled = false;
                }             
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart(); 
        }

        private void hodnotenie_Click(object sender, EventArgs e)
        {     
            hodnotenie.Enabled = false;
            label5.Text = null;
            ukoncenie.Enabled = true;
            dalsia_otazka.Enabled = true;
            int kolo = level - 1;
                       
            if (odpoved == q.OK)
            {
                vyhra = suma[kolo].Text;
                if (new List<int> {2, 5, 8, 11}.Contains(kolo)) 
                {
                    garantovana_vyhra = suma[kolo].Text;
                    co[kolo].BackColor = Color.Green;
                    suma[kolo].BackColor = Color.Green;
                    suma[kolo].ForeColor = Color.White;
                    co[kolo].ForeColor = Color.White;                  
                }
                else
                {
                    co[kolo].BackColor = Color.LightBlue;
                    suma[kolo].BackColor = Color.LightBlue;
                }

                
                switch (klikol_si)
                {
                    case "A":
                        A.BackColor = Color.Green;
                        label1.BackColor= Color.Green;
                        VypnutieButtonov();
                        dalsia_otazka.Enabled = true;
                        break;

                    case "B":
                        B.BackColor = Color.Green;
                        label2.BackColor = Color.Green;
                        VypnutieButtonov();
                        dalsia_otazka.Enabled = true;
                        break;

                    case "C":
                        C.BackColor = Color.Green;
                        label3.BackColor = Color.Green;
                        VypnutieButtonov();
                        dalsia_otazka.Enabled = true;
                        break;

                    case "D":
                        D.BackColor = Color.Green;
                        label4.BackColor = Color.Green;                       
                        VypnutieButtonov();
                        dalsia_otazka.Enabled = true;
                        break;
                }
            }
            
            else
            {
                switch (klikol_si)
                {
                    case "A":
                        A.BackColor = Color.Red;
                        label1.BackColor = Color.Red;
                        VypnutieButtonov();
                        break;

                    case "B":
                        B.BackColor = Color.Red;
                        label2.BackColor = Color.Red;
                        VypnutieButtonov();
                        break;

                    case "C":
                        C.BackColor = Color.Red;
                        label3.BackColor = Color.Red;
                        VypnutieButtonov();
                        break;

                    case "D":
                        D.BackColor = Color.Red;
                        label4.BackColor = Color.Red;
                        VypnutieButtonov();
                        break;
                }
                ukoncenie_hry(0);                
            }

            level++;

            if (level == 13)
            {
                if (suma[11].BackColor == Color.Green) 
                {
                    MessageBox.Show("Vyhrali ste " + garantovana_vyhra);
                    dalsia_otazka.Enabled = false;
                }             
                ButtonyPlusFunkcieVypnutie();
            }

        }

        private void D_Click(object sender, EventArgs e)
        {
            klikol_si = "D";
            Oznac("D");
        }

        private void z50_Click(object sender, EventArgs e)
        {
            z50.Enabled = false;
            klikol_z50 = true;
            label5.Text = "OK";
            switch (q.p1)
            {
                case "A":
                    A.Enabled = false;
                    A.Text = "";
                    break;
                case "B":
                    B.Enabled = false;
                    B.Text = "";
                    break;
                case "C":
                    C.Enabled = false;
                    C.Text = "";
                    break;
                case "D":
                    D.Enabled = false;
                    D.Text = "";
                    break;
            }

            switch (q.p2)
            {
                case "A":
                    A.Enabled = false;
                    A.Text = "";
                    break;
                case "B":
                    B.Enabled = false;
                    B.Text = "";
                    break;
                case "C":
                    C.Enabled = false;
                    C.Text = "";
                    break;
                case "D":
                    D.Enabled = false;
                    D.Text = "";
                    break;
            }
        }

        Random rnd = new Random();

        public void citaj_otazku()
        {
            if (graf.Visible == true) graf.Visible = false;
            dalsia_otazka.Enabled = false;
            ukoncenie.Enabled = true;          

            A.BackColor = Color.LightGray;
            B.BackColor = Color.LightGray;
            C.BackColor = Color.LightGray;
            D.BackColor = Color.LightGray;
            label1.BackColor = Color.LightGray;
            label2.BackColor = Color.LightGray;
            label3.BackColor = Color.LightGray;
            label4.BackColor = Color.LightGray;

            A.Enabled = true; B.Enabled = true; C.Enabled = true; D.Enabled = true;

              perm[0, 0] = 1; perm[0, 1] = 2; perm[0, 2] = 3; perm[0, 3] = 4;
              perm[1, 0] = 2; perm[1, 1] = 1; perm[1, 2] = 3; perm[1, 3] = 4;
              perm[2, 0] = 3; perm[2, 1] = 1; perm[2, 2] = 2; perm[2, 3] = 4;
              perm[3, 0] = 1; perm[3, 1] = 3; perm[3, 2] = 2; perm[3, 3] = 4;
              perm[4, 0] = 2; perm[4, 1] = 3; perm[4, 2] = 1; perm[4, 3] = 4;
              perm[5, 0] = 3; perm[5, 1] = 2; perm[5, 2] = 1; perm[5, 3] = 4;
              perm[6, 0] = 3; perm[6, 1] = 2; perm[6, 2] = 4; perm[6, 3] = 1;
              perm[7, 0] = 2; perm[7, 1] = 3; perm[7, 2] = 4; perm[7, 3] = 1;
              perm[8, 0] = 4; perm[8, 1] = 3; perm[8, 2] = 2; perm[8, 3] = 1;
              perm[9, 0] = 3; perm[9, 1] = 4; perm[9, 2] = 2; perm[9, 3] = 1;
            perm[10, 0] = 2; perm[10, 1] = 4; perm[10, 2] = 3; perm[10, 3] = 1;
            perm[11, 0] = 4; perm[11, 1] = 2; perm[11, 2] = 3; perm[11, 3] = 1;
            perm[12, 0] = 4; perm[12, 1] = 1; perm[12, 2] = 3; perm[12, 3] = 2;
            perm[13, 0] = 1; perm[13, 1] = 4; perm[13, 2] = 3; perm[13, 3] = 2;
            perm[14, 0] = 3; perm[14, 1] = 4; perm[14, 2] = 1; perm[14, 3] = 2;
            perm[15, 0] = 4; perm[15, 1] = 3; perm[15, 2] = 1; perm[15, 3] = 2;
            perm[16, 0] = 1; perm[16, 1] = 3; perm[16, 2] = 4; perm[16, 3] = 2;
            perm[17, 0] = 3; perm[17, 1] = 1; perm[17, 2] = 4; perm[17, 3] = 2;
            perm[18, 0] = 2; perm[18, 1] = 1; perm[18, 2] = 4; perm[18, 3] = 3;
            perm[19, 0] = 1; perm[19, 1] = 2; perm[19, 2] = 4; perm[19, 3] = 3;
            perm[20, 0] = 4; perm[20, 1] = 2; perm[20, 2] = 1; perm[20, 3] = 3;
            perm[21, 0] = 2; perm[21, 1] = 4; perm[21, 2] = 1; perm[21, 3] = 3;
            perm[22, 0] = 1; perm[22, 1] = 4; perm[22, 2] = 2; perm[22, 3] = 3;
            perm[23, 0] = 4; perm[23, 1] = 1; perm[23, 2] = 2; perm[23, 3] = 3;

            v50[0, 0] = 2; v50[0, 1] = 3;
            v50[1, 0] = 2; v50[1, 1] = 4;
            v50[2, 0] = 3; v50[2, 1] = 4;

            subor = "q" + level + ".txt";          

            string cesta = Directory.GetCurrentDirectory().Replace("\\Hra_02\\bin\\Debug", "");
            cesta +=  @"\q\";

            pocet_otazok_suboru = File.ReadAllLines(cesta + subor).Length;
            vyber_otazku_cislo = rnd.Next(pocet_otazok_suboru) + 1;

            permutacia = rnd.Next(24);

            permutacia_vymazat = rnd.Next(3);

            i = 1;
            foreach (string r in File.ReadLines(cesta + subor))
            {
                if (i == vyber_otazku_cislo)
                {
                    string[] fraza = r.Split('*');
                    q.oText = fraza[0];
                    q.OK = fraza[1];                    
                    q.A = fraza[perm[permutacia, 0]];
                    q.B = fraza[perm[permutacia, 1]];
                    q.C = fraza[perm[permutacia, 2]];
                    q.D = fraza[perm[permutacia, 3]];

                    otazka.Text = q.oText;
                    A.Text = q.A;
                    B.Text = q.B;
                    C.Text = q.C;
                    D.Text = q.D;

                if (A.Text == fraza[v50[permutacia_vymazat, 0]])  q.p1 = "A";
                if (B.Text == fraza[v50[permutacia_vymazat, 0]])  q.p1 = "B";
                if (C.Text == fraza[v50[permutacia_vymazat, 0]])  q.p1 = "C";
                if (D.Text == fraza[v50[permutacia_vymazat, 0]])  q.p1 = "D";

                if  (A.Text == fraza[v50[permutacia_vymazat, 1]]) q.p2 = "A";
                if  (B.Text == fraza[v50[permutacia_vymazat, 1]]) q.p2 = "B";
                if  (C.Text == fraza[v50[permutacia_vymazat, 1]]) q.p2 = "C";
                if  (D.Text == fraza[v50[permutacia_vymazat, 1]]) q.p2 = "D";
                               
                }
                i++;
            }
         }

        private void dalsia_otazka_Click(object sender, EventArgs e)
        {           
            citaj_otazku();           
            priatel.Visible = false;
            if(level==1)
            {
                ButtonyPlusFunkcieZapnutie();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ButtonyPlusFunkcieVypnutie()
        {
            z50.Enabled = false;
            zTelefon.Enabled = false;
            zPublikum.Enabled = false;
            A.Enabled = false;
            B.Enabled = false;
            C.Enabled = false;
            D.Enabled = false;
            label1.Enabled = false;
            label2.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;
        }
        public void ButtonyPlusFunkcieZapnutie()
        {
            z50.Enabled = true;
            zTelefon.Enabled = true;
            zPublikum.Enabled = true;
            A.Enabled = true;
            B.Enabled = true;
            C.Enabled = true;
            D.Enabled = true;
            label1.Enabled = true;
            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
        }
        public void VypnutieButtonov()
        {
            A.Enabled = false;
            B.Enabled = false;
            C.Enabled = false;
            D.Enabled = false;
            label1.Enabled = false;
            label2.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;
            dalsia_otazka.Enabled = false;
            ukoncenie.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {          
            int c = 45;
            suma = new Label[12];
            for (int i = 0; i < 12; i++)
            {
                suma[i] = new Label();
                suma[i].AutoSize = false;
                suma[i].Size = new Size(150, 45);
                suma[i].Location = new Point(1750, 850 - c);
                suma[i].ForeColor = Color.Gray;
                suma[i].BackColor = Control.DefaultBackColor;
                suma[i].BorderStyle = BorderStyle.None;
                suma[i].Font = new Font("Calibri", 18);
                suma[i].Padding = new Padding(6, 6, 15, 6);
                suma[i].TextAlign = ContentAlignment.MiddleRight;
                this.Controls.Add(suma[i]);
                c += 45;
            }

            c = 45;     
            
            co = new Label[12];
            for (int i = 0; i < 12; i++)
            {
                co[i] = new Label();
                co[i].AutoSize = false;
                co[i].Size = new Size(50, 45);
                co[i].Location = new Point(1700, 850 - c);
                co[i].BorderStyle = BorderStyle.None;
                co[i].Font = new Font("Calibri", 18);
                co[i].BackColor = Control.DefaultBackColor;
                co[i].Padding = new Padding(6);
                co[i].TextAlign = ContentAlignment.MiddleRight;
                co[i].Text = Convert.ToString(i + 1);
                this.Controls.Add(co[i]);
                c += 45;
            }
            
            suma[0].Text = "100 €"; suma[4].Text = "2 000 €"; suma[8].Text = "10 000 €";
            suma[1].Text = "300 €"; suma[5].Text = "5 000 €"; suma[9].Text = "20 000 €";
            suma[2].Text = "500 €"; suma[6].Text = "6 500 €"; suma[10].Text = "25 000 €";
            suma[3].Text = "1 000 €"; suma[7].Text = "8 000 €"; suma[11].Text = "50 000 €";

            level = 1;
            otazka.Text = "Stredná priemyselná škola strojnícka a elektrotechnická, Nitra";
            A.Text = "Mário Markovič";
            B.Text = "IV.A trieda";
            C.Text = "školský rok";
            D.Text = "2022/2023";
           
            hodnotenie.Enabled = false;
            ukoncenie.Enabled = false;
            graf.Visible = false;

            ButtonyPlusFunkcieVypnutie();            
        }
    }
}
