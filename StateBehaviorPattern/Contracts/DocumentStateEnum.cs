namespace StateBehaviorPattern.Contracts
{
    public enum DocumentStateEnum
    {
        New,
        Draft,
        ReadyToProcess,
        Processed,
        Archived,
        Failed
    }
}