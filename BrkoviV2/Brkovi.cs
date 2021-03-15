using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrkoviV2
{
    class Brkovi
    {
        string pod1, pod2, pod4, dodatak;
        int pod3;

        /// <summary>
        /// rimjer setter metode
        /// za varijablu pod1
        /// </summary>
        /// <param name="pod1"></param>
        public void setPod1(string pod1)
        {
            this.pod1 = pod1;
        }

        /// <summary>
        /// primjer getter metode
        /// za varijablu pod1
        /// </summary>
        /// <returns>string pod1</returns>
        public string getPod1()
        {
            return this.pod1;
        }

        /// <summary>
        /// automatske set i get metode za sve varijable
        /// </summary>
        public string Pod1 { get => pod1; set => pod1 = value; }
        public string Pod2 { get => pod2; set => pod2 = value; }
        public string Pod4 { get => pod4; set => pod4 = value; }
        public string Dodatak { get => dodatak; set => dodatak = value; }
        public int Pod3 { get => pod3; set => pod3 = value; }

        public Brkovi()
        {
        }

   
        /// <param name="pod1"></param>
        /// <param name="pod2"></param>
        /// <param name="pod3"></param>
        /// <param name="pod4"></param>
        public Brkovi(string pod1, string pod2, int pod3, string pod4)
        {
            this.pod1 = pod1;
            this.pod2 = pod2;
            this.pod3 = pod3;
            this.pod4 = pod4;
        }

 
        public string Ispis()
        {
            string ispis = pod1 + "\t" + pod2 + "\t"
                + Convert.ToString(pod3) + "\t"
                + pod4 + "\r\n";
            return ispis;
        }


 
        override public string ToString()
        {
            string ispis = pod1 + "\t\t" + pod2 + "\t\t"
                + Convert.ToString(pod3) + "\t\t"
                + pod4 + "\t\t" + dodatak + "\r\n";
            return ispis;
        }










    }
}
