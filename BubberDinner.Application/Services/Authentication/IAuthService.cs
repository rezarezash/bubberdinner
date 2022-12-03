﻿namespace BubberDinner.Application.Services.Authentication;

public interface IAuthService
{
    AuthenticationResult Register(string firstName, string lastName, string email, string password);
    AuthenticationResult Login(string email, string password);
}