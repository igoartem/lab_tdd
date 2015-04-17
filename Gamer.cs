using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_test
{
    public class Gamer
    {
        public string name { get; set; }
        public int number { get; set; }
        public int rating { get; set; }

        public Gamer() { }

        public void number_plus_num(int num)
        {
            this.number += num;
        }

        public void PlusRating(int kol)
        {
            rating = 25;

        }

    }

}
