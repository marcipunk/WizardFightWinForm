using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizardFight
{
    class BadWizard : Character
    {
        static Random rnd = new Random();
        
        //private static int life = rnd.Next(40, 101); //hogyen lehetne mogoldani, hogy ne legyen static, vagyis osztályszintű? 



        public BadWizard(string name, int mana, int xp) : base(name, rnd.Next(40, 101), mana, xp, true)
        {
        }
    }
}
