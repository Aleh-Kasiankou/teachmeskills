namespace AsyncHouseholdChores.Household
{
    public abstract class ItemWithState : IChoreResult
    {
        public ItemWithState(State state)
        {
            State = state;
        }

        public State State { get; }
    }
}