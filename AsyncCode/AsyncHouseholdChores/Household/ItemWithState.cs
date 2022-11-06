namespace AsyncHouseholdChores
{
    public abstract class ItemWithState
    {
        public ItemWithState(State state)
        {
            State = state;
        }

        public State State { get; }
    }
}