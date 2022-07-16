using System;
using System.Collections.Generic;
using System.Text;

namespace DripchatCommon.User
{
    public abstract class User : IUser
    {
        private readonly string username;
        private readonly string password;
        private readonly string email;
    }
}
