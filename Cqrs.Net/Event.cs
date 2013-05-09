namespace Cqrs.Net
{
    public abstract class Event : Message
    {
        public int Version;
    }
}