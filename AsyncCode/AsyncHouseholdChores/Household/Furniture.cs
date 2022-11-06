namespace AsyncHouseholdChores.Household
{
    public class Furniture : ItemWithState
    {
        public Furniture(State state = State.Disgusting) : base(state)
        {
        }
    }
}