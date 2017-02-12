using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizardFight
{
    

    class GoodWizard : Character
    {
        static Random rnd = new Random();
        //private List<Spell> gspells;
        //private static int life = rnd.Next(40, 81); //hogyen lehetne mogoldani, hogy ne legyen static, vagyis osztályszintű? 

        //public List<Spell> Gspells
        //{
        //    get
        //    {
        //        return gspells;
        //    }
        //}

        public GoodWizard(string name, int mana, int xp) : base(name, rnd.Next(40, 81), mana, xp, false)
        {
            //gspells = new List<Spell>(10);
            //Random rnd = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
            //for (int i = 0; i < 10; i++)
            //{
            //    Spell tempspell = new Spell("Varázslat_" + (i + 1), rnd.Next(1, 10), rnd.Next(5, 26));
            //    //Console.WriteLine(tempspell.ToString());
            //    Gspells.Add(tempspell);
            //}

            
        }
    }
}
