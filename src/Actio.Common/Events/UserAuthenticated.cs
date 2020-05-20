using System;

namespace Actio.Common.Events
{
    public class UserAuthenticated : IEvent
    {
        public string Email { get; }
        
        UserAuthenticated(){}

        UserAuthenticated(string email)
        {
            Email = email;
        }
    }
}