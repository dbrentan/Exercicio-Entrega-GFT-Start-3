namespace GFT_Proj.src.Entities
{
    public class Archer : Hero
    {
        public Archer(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
         public string Attack(int Bonus)
        {
             if(Bonus > 6)
            {
                return this.Name + "Fez um ataque poderoso com a sua flecha com bonus de " + Bonus;
            }
            else
            {
              return this.Name + "Lançou uma flecha fraca com bonus de " + Bonus;
            }
        }
    }
}
