﻿namespace Messages.Commands.Users
{
    public class SignOut : AuthenticatedCommand
    {
        public string SessionId { get; set; }
    }
}