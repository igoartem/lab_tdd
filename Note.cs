﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab3_test
{
     public class Note
    {
        public int frequency {get; set;}
        public int duration { get; set; }
        public int sleep { get; set; }
        public Note() { }
        public Note(int freq,int dur,int sleep) 
        {
            this.duration = dur;
            this.frequency = freq;
            this.sleep = sleep;
        }

        public void playNote() 
        {
            Thread.Sleep(sleep);
            Console.Beep(frequency,duration);
        }

    }
}
