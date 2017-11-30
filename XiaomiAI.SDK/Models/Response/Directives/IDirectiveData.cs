namespace XiaomiAI.SDK.Models
{
    public interface IDirectiveData
    {
        string Type { get; }

        PlayBehaviorType PlayBehavior { get; set; }
    }
}