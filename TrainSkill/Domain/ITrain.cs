namespace TrainSkill.Domain
{
    public interface ITrain
    {
        bool IsDelayed { get; }
        int DelayInMinutes { get; }
    }
}
