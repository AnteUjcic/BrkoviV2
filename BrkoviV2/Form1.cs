using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrkoviV2
{
    public partial class Form1 : Form
    {
        List<Brkovi> lista = new List<Brkovi>();
        public Form1()
        {
            InitializeComponent();


        }

        private void TxtPod1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPod2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPod3_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmBoxPod4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnUnesi_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * instanciranje objekta 'brk' iz klase 'Brkovi
                 * pomoću prilagođenog konstruktora
                 */
                Brkovi brk = new Brkovi(txtPod1.Text, txtPod2.Text, Convert.ToInt32(txtPod3.Text), Convert.ToString(cmBoxPod4.Text));
                /*
                 * dodavanje objekta u listu
                 */
                lista.Add(brk);

                /*
                 * brisanje podataka u formi 
                 * nakon upisa podataka
                 */
                txtPod1.Clear();
                txtPod2.Clear();
                txtPod3.Clear();
            }
            catch (Exception greska)
            {
                /*
                 * ispis poruke prilikom pogrešnog unosa
                 */
                MessageBox.Show("Pogrešan unos!\r\n" + greska.Message,
                    "Greška", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// metoda koja se izvršava klikom na gumb "Ispiši"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void BtnObradi_Click(object sender, EventArgs e)
        {
            /*
             * foreach petlja koja 
             * za svaki objekt 'brk' klase 'Brkovi' iz liste
             * provjerava pomoću getter metode da li je 
             * varijabla pod4 jednaka "M" te sukladno rezultatu
             * postavlja varijablu dodatak pomoću setter metode
             */
            foreach (Brkovi brk in lista)
            {
                if (brk.Pod4 == "M")
                {
                    brk.Dodatak = "Ima brkove.";
                }
                else
                {
                    brk.Dodatak = "Nema brkove";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnIspisi_Click(object sender, EventArgs e)
        {
            // Ispis zaglavlja
            rtbIspis.Text = "Podatak 1" + "\tPodatak 2"
                + "\tPodatak 3" + "\tPodatak 4" + "\tDodatak\r\n";

            /*
             * foreach petlja koja 
             * za svaki objekt 'brk' klase 'Brkovi' iz liste
             * dodaje u richTextBox ispis iz metode ToString()
             * objekta 'brk'
             * (metoda je definirana u klasi 'Brkovi')
             */
            foreach (Brkovi brk in lista)
            {

                rtbIspis.AppendText(brk.ToString());
            }
        }
        /// <summary>
        /// metoda koja se izvršava klikom na gumb "Obradi"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
    

    private void RtbIspis_TextChanged(object sender, EventArgs e)
    {

     }
        }
}


