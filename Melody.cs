﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_test
{
     public class Melody
    {
        public List<Note> list_note;
        public Melody() {   }
        public Melody(List<Note> list) { list_note = list;}

        public void play_melody()
        {
            int kol=list_note.Count;
            for (int i = 0; i < kol; i++)
                list_note[i].playNote();
        }
         
    }
}
