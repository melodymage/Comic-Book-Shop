using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comic_Store
{
    public partial class Cart : Form
    {

        public Cart()
        {
            InitializeComponent();
        }
        public void playClick()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\melin_000\documents\visual studio 2015\Projects\Comic Store\Comic Store\Sounds\click.wav");
            simpleSound.Play();
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            cartContents.Text = GlobalVar.sCart.cartDisplay();
        
        }

        private void backToStock_Click(object sender, EventArgs e)
        {
            playClick();
            this.Hide();
            GlobalVar.first.Show();
        }
    }
}
