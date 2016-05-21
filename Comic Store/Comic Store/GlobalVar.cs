using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Comic_Store
{
    class GlobalVar
    {
        public static Books inventory = new Books();
        public static Books sCart = new Books();
        public static comic pack = new comic();
        public static Stock first = new Stock();
        public static Cart second = new Cart();
        public static float total;
        public void playClick()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\melin_000\documents\visual studio 2015\Projects\Comic Store\Comic Store\Sounds\click.wav");
            simpleSound.Play();
        }
    }
}
