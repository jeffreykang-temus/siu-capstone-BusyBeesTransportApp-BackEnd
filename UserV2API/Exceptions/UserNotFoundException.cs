﻿namespace UserV2API.Exceptions
{
    public class UserNotFoundException: Exception
    {
        public UserNotFoundException() { }
        public UserNotFoundException(string message) : base(message) { }
    }
}
