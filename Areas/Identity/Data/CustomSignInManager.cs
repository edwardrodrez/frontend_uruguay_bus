using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UruguayBus.conexiones;

namespace UruguayBus.Areas.Identity.Data
{
    public class CustomSignInManager 
    {
        private readonly SignInManager<UruguayBusUser> _signInManager;
        private readonly UserManager<UruguayBusUser> _userManager;
        private readonly IHttpContextAccessor _contextAccessor;
        ConexionesController api = new ConexionesController();

        public async Task<bool> login(string Email, string password, bool isPersistent, bool lockoutOnFailure)
        {
            UruguayBusUser result = await api.login(Email, password);

            if (result != null) {

                await _signInManager.SignInAsync(result, isPersistent: isPersistent);
                return true;
            }

            return false;
        }
    }
}
