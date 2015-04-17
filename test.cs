using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab3_test
{
    [TestClass]
    public class Test_gamer
    {


        [TestMethod]
        public void TestNewGamer()
        {
            Gamer gamer = new Gamer();
            Assert.IsNotNull(gamer);
        }

        [TestMethod]
        public void TestName()
        {
            Gamer gamer = new Gamer();
            gamer.name = "test";
            Assert.AreEqual(gamer.name, "test");

        }
        [TestMethod]
        public void Test_number_plus_num()
        {
            Gamer gamer = new Gamer();
            gamer.number = 90;
            gamer.number_plus_num(10);
            Assert.AreEqual(gamer.number, 100);
        }

        [TestMethod]
        public void Test_number_plus_num2()
        {
            Gamer gamer = new Gamer();
            gamer.number = 10;
            gamer.number_plus_num(30);
            Assert.AreEqual(gamer.number, 40);
        }

        [TestMethod]
        public void TestNewNote()
        {
            Note note = new Note();
            Assert.IsNotNull(note);
        }

        [TestMethod]
        public void TestNoteFrequency()
        {
            Note note = new Note();
            note.frequency = 10;
            Assert.AreEqual(note.frequency, 10);

        }

        [TestMethod]
        public void TestNoteDuration()
        {
            Note note = new Note();
            note.duration= 20;
            Assert.AreEqual(note.duration, 20);

        }

        [TestMethod]
        public void TestNoteSleep()
        {
            Note note = new Note();
            note.sleep = 30;
            Assert.AreEqual(note.sleep, 30);

        }

         [TestMethod]
        public void TestNewNoteDur()
        {
            Note note = new Note(0,10,0);
            Assert.AreEqual(note.duration, 10);

        }

         [TestMethod]
         public void TestNewNoteFreq()
         {
             Note note = new Note(10, 0, 0);
             Assert.AreEqual(note.frequency, 10);

         }

         [TestMethod]
         public void TestNewNoteSleep()
         {
             Note note = new Note(0, 0, 10);
             Assert.AreEqual(note.sleep, 10);

         }


         [TestMethod]
         public void TestGamerRating()
         {
             Gamer gamer = new Gamer();
             gamer.rating = 10;
             Assert.AreEqual(gamer.rating, 10);

         }

         [TestMethod]
         public void TestGamerRatingPlus()
         {
             Gamer gamer = new Gamer();
             gamer.rating = 10;
             gamer.PlusRating(15);
             Assert.AreEqual(gamer.rating, 25);

         }

         [TestMethod]
         public void TestGamerRatingPlus2()
         {
             Gamer gamer = new Gamer();
             gamer.rating = 10;
             gamer.PlusRating(2);
             Assert.AreEqual(gamer.rating, 12);

         }
         [TestMethod]
         public void TestNewGamerName()
         {
             Gamer gamer = new Gamer("test",0);
             Assert.AreEqual(gamer.name, "test");

         }
    }
}
