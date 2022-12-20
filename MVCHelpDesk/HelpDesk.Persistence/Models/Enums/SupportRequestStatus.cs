namespace HelpDesk.Persistence.Models.Enums
{
    public enum SupportRequestStatus
    {
        New = 1,
        Open = 2,
        Reopen = 3,
        AwaitingCustomerReply = 4,
        AwaitingCredentials = 5,
        TechnicalInvestigation = 6,
        Resolved = 7,
        Closed = 8
    }
}