using System;
using DwarfKiller.Models;

namespace DwarfKiller
{
    public partial class Fight : System.Web.UI.Page
    {
        private Hero hero;
        private Dwarf dwarf;

        protected void Page_Load(object sender, EventArgs e)
        {
            SetCombatants();
            SetLabels();
        }

        protected void Attack(object sender, EventArgs e)
        {
            SetCombatants();

            if (dwarf.HitPoints > 0)
            {
                var rnd = new Random(DateTime.Now.Millisecond);
                var defense = rnd.Next(0, dwarf.DefensePoints);
                var attack = rnd.Next(0, hero.AttackPoints);

                enemyDefensePoints.InnerText = defense.ToString();
                heroAttackPoints.InnerText = attack.ToString();

                var result = (attack - defense);

                if (result < 0)
                {result = 0;}
               
                dwarf.HitPoints = dwarf.HitPoints - (result);
                if (dwarf.HitPoints <= 0)
                {
                    hero.KillCount++; 
                    dwarf.HitPoints = 0;
                }
            }

            SetLabels();
        }

        protected void NewEnemy(object sender, EventArgs e)
        {
            Session["_enemy"] = new Dwarf();
            dwarf = (Dwarf)Session["_enemy"];

            SetLabels();
        }

        private void SetLabels()
        {
            //This is called facade pattern
            //We aggregate some other functions to be recalled in a single line whenever we want
            SetEnemyLabels();
            SetHeroLabels();
        }

        private void SetCombatants()
        {
            //Session storge typically uses string keys for accessing variables.
            //Another option in web forms is called ViewState
            //Look up the difference between ViewState and Session, and let me know
            //You need to cast them (tell the compiler what type they will be) in order to assign them to your variables.
            //Session is typically lazy programming, and this is for educational purposes only
            if (Session["_hero"] == null)
            {
                Session["_hero"] = new Hero()
                {
                    Name = "Jimi Hendrix",
                    AttackPoints = 5,
                    DefensePoints = 5,
                    HitPoints = 50,
                    CombatLevel = 1,
                    DeathCount = 0,
                    KillCount = 0,
                };
            }

            //Notice that there are no curly braces for this if statement
            //If there is only a single line for an if statement, they are not necessary
            //this cleans up the code base a bit by reducing number of lines
            if (Session["_enemy"] == null)
                Session["_enemy"] = new Dwarf();

            hero = (Hero)Session["_hero"];
            dwarf = (Dwarf)Session["_enemy"];
        }

        //Notice how these next two functions are named the same and take the same number of parameters
        //This technique is called "Overloading" and this is very important
        //The compiler knows which function to call based on the types of parameters you pass in
        //A method signature is the unique combination of method name plus method parameters
        //It is okay to have these two methods because the second parameter differs in type
        private void SetLabelText(System.Web.UI.HtmlControls.HtmlGenericControl label, string innerText)
        {
            label.InnerText = innerText;
        }
        private void SetLabelText(System.Web.UI.HtmlControls.HtmlGenericControl label, int innerText)
        {
            label.InnerText = innerText.ToString();
        }

        private void SetHeroLabels()
        {
            SetLabelText(heroAttackPoints, hero.AttackPoints);
            SetLabelText(heroCombatLevel, hero.CombatLevel);
            SetLabelText(heroDefensePoints, hero.DefensePoints);
            SetLabelText(heroHitPoints, hero.HitPoints);
            SetLabelText(heroKillCount, hero.KillCount);
            SetLabelText(heroName, hero.Name);
        }
        private void SetEnemyLabels()
        {
            SetLabelText(enemyName, dwarf.Name);
            SetLabelText(enemyHitPoints, dwarf.HitPoints);
            SetLabelText(enemyDefensePoints, dwarf.DefensePoints);
            SetLabelText(enemyAttackPoints, dwarf.AttackPoints);

            if (dwarf.HitPoints == 0)
            {
                enemyStatus.InnerText = "DEAD!";
                btnNewEnemy.Visible = true;
            }
            else
            {
                enemyStatus.InnerText = "Alive...";
                btnNewEnemy.Visible = false;
            }
        }
    }
}