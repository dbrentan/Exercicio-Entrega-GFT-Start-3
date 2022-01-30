namespace GFT_Proj.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;

        }

         public override string Attack()
        {
           return this.Name + "Lançou uma magia";
        }
        public string Attack(int Bonus)
        {
            if(Bonus > 6)
            {
                return this.Name + "Lançou uma magia super efetiva com bonus de " + Bonus;
            }
            else
            {
              return this.Name + "Lançou uma magia fraca com uma força de bonus de "+ Bonus;
            }
        }
    }
}