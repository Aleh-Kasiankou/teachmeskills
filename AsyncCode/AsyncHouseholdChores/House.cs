using AsyncHouseholdChores.Household;

namespace AsyncHouseholdChores
{
    public class House
    {
        public Floor Floor { get; set; } = new Floor();
        public Clothing Clothing { get; set; } = new Clothing();
        public Furniture Furniture { get; set; } = new Furniture();
        public Carpet Carpet { get; set; } = new Carpet();
        public Bath Bath { get; set; } = new Bath();
    }
}