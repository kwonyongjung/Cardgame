using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class card
    {
        private int attak;
        private string name;
        private string image;

        public void set_card(int attak, string name, string image)
        {
            this.attak = attak;
            this.name = name;
            this.image = image;
        }
        public int get_attak()
        {
            return this.attak;
        }
        public string get_name()
        {
            return this.name;
        }
        public string get_image()
        {
            return this.image;
        }
    }
}
