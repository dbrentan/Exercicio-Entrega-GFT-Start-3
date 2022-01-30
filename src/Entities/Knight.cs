namespace GFT_Proj.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
         public string Attack(int Bonus)
        {
             if(Bonus > 6)
            {
                return this.Name + "Fez um ataque poderoso com a sua Espada com bonus de " + Bonus;
            }
            else
            {
              return this.Name + "Fez um ataque fraco com a sua Espada com bonus de "+ Bonus;
            }
        }
    }
}