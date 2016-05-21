using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comic_Store
{
    struct comic
    {
        public string title;
        public float price;
        public string cover;
        public string issue;
        public string release;
    };
    class Books
    {
        public comic [] Comics = new comic[30];
        public int size;
        public Books()
        {
            size = 0;
        }
        public void add(comic c)
        {
            Comics[size] = c;
            size++;
        }
        public string getSize()
        {
            return size.ToString();
        }
        public string getTitle(int i)
        {
            return Comics[i].title;
        }
        public float getPrice(int i)
        {
            return Comics[i].price;
        }
        public string getCover(int i)
        {
            return Comics[i].cover;
        }
        public string getIssue(int i)
        {
            return Comics[i].issue;
        }
        public string getRelease(int i)
        {
            return Comics[i].release;
        }
        public string info(int i)
        {
            string together;
            together = String.Format("{0} \n {1} \n {2} \n {3}", getTitle(i), getPrice(i), getIssue(i), getRelease(i));
            return together;
        }
        public string cartDisplay()
        {
            int all = size;
            GlobalVar.total = 0;
            string cartComics;
            string c = "";
            while (all > 0)
            {
                c += String.Format(" {0} \t\t\t             \t\t\t ${1:0.00}", getTitle(all - 1), getPrice(all - 1));
                c += "\n-------------------------------------------------------------------------------------------\n";
                GlobalVar.total += getPrice(all - 1);
                all--;
            }
            cartComics = String.Format("{0} \n   Total: \t\t\t\t ${1:0.00}", c, GlobalVar.total);
            return cartComics;
        }

    }
}
