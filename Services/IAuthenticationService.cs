using System;
using sharp_tasks.Models;

namespace sharp_tasks.Services;

public interface IAuthenticationProvider
{
    public bool AuthenticateUser(Login model);
    public void Logout();
    public bool IsAuthenticated();
}
