using System;
using System.Media;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
//NC-1 More namespaces.
using System.Data.SqlClient;
using System.Configuration;

namespace Comic_Store
{
    
    public partial class Stock : Form
    {
        //Create variables for each displayed comic
        int c1, c2, c3, c4;
        //Add sound
        public void playClick()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\melin_000\documents\visual studio 2015\Projects\Comic Store\Comic Store\Sounds\click.wav");
            simpleSound.Play();
        }
        public void errorSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\melin_000\documents\visual studio 2015\Projects\Comic Store\Comic Store\Sounds\error.wav");
            simpleSound.Play();
        }
        //State connection
        public string connstr = Comic_Store.Utility.GetConnectionString();
                    
        public Stock()
        {
            InitializeComponent();
        }
        public void forward()
        {
            c1 += 4;
            c2 += 4;
            c3 += 4;
            c4 += 4;
        }
        public void rewind()
        {
            c1 -= 4;
            c2 -= 4;
            c3 -= 4;
            c4 -= 4;
        }
        public void cycle()
        {
           
                book1.Text = GlobalVar.inventory.info(c1);
                pic1.BackgroundImage = new Bitmap(GlobalVar.inventory.getCover(c1));
                book2.Text = GlobalVar.inventory.info(c2);
                pic2.BackgroundImage = new Bitmap(GlobalVar.inventory.getCover(c2));
                book3.Text = GlobalVar.inventory.info(c3);
                pic3.BackgroundImage = new Bitmap(GlobalVar.inventory.getCover(c3));
                book4.Text = GlobalVar.inventory.info(c4);
                pic4.BackgroundImage = new Bitmap(GlobalVar.inventory.getCover(c4));
               
        }
        
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        } 

        private void book1_Click(object sender, EventArgs e)
        {

        }

        private void Stock_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connstr);
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand();
            myCommand.Connection = conn;
            myCommand.CommandText = "SELECT * FROM Stock";
            conn.Open();
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                GlobalVar.pack.title = myReader["Title"].ToString();
                GlobalVar.pack.price = Convert.ToSingle(myReader["Price"]);
                GlobalVar.pack.cover = Convert.ToString(myReader["Cover"]);
                if (GlobalVar.pack.cover.Length > 0)
                {
                    GlobalVar.pack.cover = GlobalVar.pack.cover.Remove(GlobalVar.pack.cover.Length - 1, 1);
                    GlobalVar.pack.cover = GlobalVar.pack.cover.Remove(0, 1);
                }
                GlobalVar.pack.issue = myReader["Issue"].ToString();
                GlobalVar.pack.release = myReader["Release"].ToString();
                GlobalVar.inventory.add(GlobalVar.pack);
            }
            conn.Close();
            c1 = 0;
            c2 = 1;
            c3 = 2;
            c4 = 3;
            cycle();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            GlobalVar.sCart.add(GlobalVar.inventory.Comics[c1]);
            shoppingCart.Text = "Cart:  " + GlobalVar.sCart.getSize();
            playClick();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            playClick();
            GlobalVar.sCart.add(GlobalVar.inventory.Comics[c2]);
            shoppingCart.Text = "Cart:  " + GlobalVar.sCart.getSize();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            playClick();
            GlobalVar.sCart.add(GlobalVar.inventory.Comics[c3]);
            shoppingCart.Text = "Cart:  " + GlobalVar.sCart.getSize();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            playClick();
            GlobalVar.sCart.add(GlobalVar.inventory.Comics[c4]);
            shoppingCart.Text = "Cart:  " + GlobalVar.sCart.getSize();
        }
        

        private void book3_Click(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {

            if (c4 + 4 <= GlobalVar.inventory.size)
            {
                playClick();
                forward();
                cycle();
            }
            else
                errorSound();
        }

        private void shoppingCart_Click(object sender, EventArgs e)
        {

        }
        private void cart_Click(object sender, EventArgs e)
        {
            playClick();
            this.Hide();
            (new Cart()).Show();
        }

        private void back_Click(object sender, EventArgs e)
        {


            if (c1 - 4 >= 0)
            {
                playClick();
                rewind();
                cycle();
            }
            else
                errorSound();
        }
    }
}
