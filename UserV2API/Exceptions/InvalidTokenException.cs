﻿namespace UserV2API.Exceptions
{
    public class InvalidTokenException: Exception
    {
        public InvalidTokenException() { }
        public InvalidTokenException(string message) : base(message) { }
    }
}
