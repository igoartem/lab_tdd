using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_test
{
     public class Melody
    {
        public List<Note> list_note;
        public string name {get;set;}
        public Melody() {   }
        public Melody(List<Note> list,string name) 
        {
            list_note =new List<Note>();
            for (int i = 0; i < list.Count;i++ )
                list_note.Add(list[i]);

            this.name = name;
        }

        public void play_melody()
        {
            int kol=list_note.Count;
            for (int i = 0; i < kol; i++)
                list_note[i].playNote();
        }
        public bool proverka(string name)
        {
            if (this.name == name)
                return true;
            else
                return false;
        }
         
    }
}
