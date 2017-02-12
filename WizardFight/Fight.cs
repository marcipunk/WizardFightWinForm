using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizardFight
{
    class Fight
    {
        Random rnd = new Random();

        public GoodWizard Gandalf = new GoodWizard("Gandalf", 340, 100);
        public BadWizard Devil = new BadWizard("Devil", 280, 100);

        public Character WFight()
        {
 

            if (rnd.Next(1001) < 700)
            {
                do
                {
                    Devil.Attack(Gandalf);
                    
                    Gandalf.Attack(Devil);
                } while (Devil.Life > 0 && Gandalf.Life > 0);
            }
            else
            {
                do
                {
                    Gandalf.Attack(Devil);

                    Devil.Attack(Gandalf);
                } while (Devil.Life > 0 && Gandalf.Life > 0);
            }

            Character result = Devil.Life <= 0 ? (Character)Gandalf : Devil; //belekényszerítem a Character típusba. Jó ez?
            return result;
        }

    }
}
