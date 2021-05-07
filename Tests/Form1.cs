using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tests
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FaceitFinderAPI.FaceitFinder faceit = new FaceitFinderAPI.FaceitFinder();
            var faceitresponce = faceit.GetResponce("Steam ID");
            Console.WriteLine("Faceit link: " + faceitresponce.Faceit);
            Console.WriteLine("Trust Factor: " + faceitresponce.Trust + "% from " + (100 - faceitresponce.Trust) + "%");
        }
    }
}
