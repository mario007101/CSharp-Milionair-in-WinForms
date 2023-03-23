using System;
using System.Windows.Forms;
using System.IO;

namespace editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string meno;
        public string retazec;

        private void Form1_Load(object sender, EventArgs e)
        {
            pridaj.Enabled = false;
        }


        private void otvor_Click(object sender, EventArgs e)
        {
            OpenFileDialog OtvorFile = new OpenFileDialog();
            if (OtvorFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader PrecitajText = new StreamReader(OtvorFile.FileName);
                retazec = PrecitajText.ReadToEnd();
                mojText.Text = retazec;
                meno = OtvorFile.FileName;

                label4.Text = meno;
                PrecitajText.Close();

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        public void nastav_pridaj()
        {
            if ((otazka.Text != "") && (A.Text != "") && (B.Text != "") && (C.Text != "") && (D.Text != ""))
            {
                pridaj.Enabled = true;
            }
            else pridaj.Enabled = false;
        }

        private void pridaj_Click(object sender, EventArgs e)
        {
            string riadok = otazka.Text + "*" + A.Text + "*" + B.Text + "*" + C.Text + "*" + D.Text;          
            mojText.Text += Environment.NewLine + riadok;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            nastav_pridaj();
        }

        private void A_TextChanged(object sender, EventArgs e)
        {
            nastav_pridaj();
        }

        private void otazka_TextChanged(object sender, EventArgs e)
        {
            nastav_pridaj();
        }

        private void B_TextChanged(object sender, EventArgs e)
        {
            nastav_pridaj();
        }

        private void C_TextChanged(object sender, EventArgs e)
        {
            nastav_pridaj();
        }

        private void ulozit_Click(object sender, EventArgs e)
        {
            File.WriteAllText(meno, mojText.Text);
            MessageBox.Show("Súbor " + meno + " bol uložený");
        }
    }
}
