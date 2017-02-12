using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace WizardFight
{
    enum Color { Grey, White, Purple, Black };
    
    class Character
    {
        private string name;
        private int life;
        private int mana;
        private int xp;
        private bool evil;
        private Color color;
        private List<Spell> spells;
        private int slife;
        private int smana;
        private int sxp;

        public string Name
        {
            get
            {
                return name;
            }
        }

        public int Life
        {
            get
            {
                return life;
            }
        }

        public int Mana
        {
            get
            {
                return mana;
            }
        }

        public int Xp
        {
            get
            {
                return xp;
            }
        }

        public bool Evil
        {
            get
            {
                return evil;
            }
        }

        public Color Color
        {
            get
            {
                return color;
            }
        }



        public List<Spell> Spells
        {
            get
            {
                return spells;
            }
        }

        public int Slife
        {
            get
            {
                return slife;
            }
        }

        public int Smana
        {
            get
            {
                return smana;
            }

        }

        public int Sxp
        {
            get
            {
                return sxp;
            }
        }



        #region konstruktor
        public Character(string name, int life, int mana, int xp, bool evil) //konstruktor
        {
            Random rnd = new Random();
            spells = new List<Spell>(10);

            this.name = name;
            #region life
            if (evil && life >= 40 && life <=100)
            {
                this.life = life;
                this.slife = life;
            }
            else if (!evil && life >= 40 && life <= 80)
            {
                this.life = life;
                this.slife = life;
            }
            else
            {
                throw new Exception("Valami el van b*szva a life környékén");
            }
            #endregion

            #region mana
            if (evil && mana > 200 && mana <= 320)
            {
                this.mana = mana;
                this.smana = mana;
            }
            else if (!evil && mana > 260 && mana <= 400)
            {
                this.mana = mana;
                this.smana = mana;
            }
            else
            {
                throw new Exception("Valami el van b*szva a mana környékén");
            }
            #endregion


            this.xp = xp;
            this.sxp = xp;

            this.evil = evil;

            # region color
            if (evil)
            {
                this.color = Color.Purple;
            }
            else
            {
                this.color = Color.Grey;
            }
            #endregion

            Random powerrnd = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
            Thread.Sleep(20);
            Random costrnd = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);

            for (int i = 0; i < 10; i++)
            {
                Spell tempspell = new Spell("Varázslat_" + (i + 1), powerrnd.Next(1, 10), costrnd.Next(5, 26));
                spells.Add(tempspell);
            }

        }
        #endregion

        public void Attack(Character enemy)
        {
            Random rnd = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
            int spellindex = rnd.Next(0, 10);

            if (enemy.life - this.spells[spellindex].Power >= 0)
            {
                enemy.life -= this.spells[spellindex].Power;
            }
            else
            {
                enemy.life = 0;
            }
            
            this.mana -= this.spells[spellindex].Cost;

            //return this.spells[spellindex];

        }

        public override string ToString()
        {
            string result = string.Empty;

            result = name + ", Színe: " + color + ", Élet: " +life +", Mana: " + mana + ", XP: " + xp;
            return result;
        }
    }
}
