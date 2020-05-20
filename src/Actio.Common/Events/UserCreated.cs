namespace Actio.Common.Events
{
    public class UserCreated : IEvent
    {
        public string Email { get; }
        public string Name { get; }

        // Created so the serializer won't have any issues
        protected UserCreated()
        { }

        public UserCreated(string email, string name)
        {
            Email = email;
            Name = name;
        }
    }
}