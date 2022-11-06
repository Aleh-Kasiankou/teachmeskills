namespace AsyncHouseholdChores.Household
{
    public class Bath : ItemWithState
    {
        public Bath(State state = State.Disgusting) : base(state)
        {
        }
    }
}