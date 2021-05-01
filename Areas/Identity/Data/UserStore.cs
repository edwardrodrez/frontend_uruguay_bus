using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using UruguayBus.Areas.Identity.Data;
using UruguayBus.conexiones;

namespace UruguayBus.Areas.Identity.Data
{
    public class CustomUserStore :
        IUserStore<UruguayBusUser>,
        IUserPasswordStore<UruguayBusUser>,
        IUserEmailStore<UruguayBusUser>,
        IUserLoginStore<UruguayBusUser>,
        IUserRoleStore<UruguayBusUser>
    {
        ConexionesController api = new ConexionesController();
        string Baseurl = "https://apprestproyectonet.azurewebsites.net/";

        public Task AddLoginAsync(UruguayBusUser user, UserLoginInfo login, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task AddToRoleAsync(UruguayBusUser user, string roleName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<IdentityResult> CreateAsync(UruguayBusUser user, CancellationToken cancellationToken)
        {

            cancellationToken.ThrowIfCancellationRequested();

            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            UruguayBusUser ret = new UruguayBusUser();
                using (var client = new System.Net.Http.HttpClient())
                {
                    client.BaseAddress = new Uri(Baseurl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    // Agrega el header Accept: application/json para recibir la data como json  
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var json = JsonConvert.SerializeObject(user);
                    var stringContent = new System.Net.Http.StringContent(json, System.Text.UnicodeEncoding.UTF8, "application/json");

                    var response2 = await client.PostAsync("api/Account/Register", stringContent); 
                
                    if (response2.IsSuccessStatusCode)
                    {
                        // Si el servicio responde correctamente
                        var aux2 = response2.Content.ReadAsStringAsync().Result;
                        // Lee el response y lo deserializa como un Product
                        ret = JsonConvert.DeserializeObject<UruguayBusUser>(aux2);
                        return IdentityResult.Success;
                    }

                    return IdentityResult.Failed();

                }
               


        }



        public async Task<IdentityResult> CreateAsync(UruguayBusUser user, String password)
        {


            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            user.password = password;

            UruguayBusUser ret = new UruguayBusUser();
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Accept.Clear();
                // Agrega el header Accept: application/json para recibir la data como json  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var json = JsonConvert.SerializeObject(user);
                var stringContent = new System.Net.Http.StringContent(json, System.Text.UnicodeEncoding.UTF8, "application/json");

                var response2 = await client.PostAsync("api/Account/Register", stringContent);

                if (response2.IsSuccessStatusCode)
                {
                    // Si el servicio responde correctamente
                    var aux2 = response2.Content.ReadAsStringAsync().Result;
                    // Lee el response y lo deserializa como un Product
                    ret = JsonConvert.DeserializeObject<UruguayBusUser>(aux2);
                    return IdentityResult.Success;
                }

                return IdentityResult.Failed();

            }



        }

        public async Task<IdentityResult> DeleteAsync(UruguayBusUser user,
              CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();

        }

        public void Dispose()
        {
        }

        public Task<UruguayBusUser> FindByEmailAsync(string normalizedEmail, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<UruguayBusUser> FindByIdAsync(string userId,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (userId == null) throw new ArgumentNullException(nameof(userId));


            return await api.getUsuarioBus(Int32.Parse(userId));

        }

        public Task<UruguayBusUser> FindByLoginAsync(string loginProvider, string providerKey, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<UruguayBusUser> FindByNameAsync(string userName,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (userName == null) throw new ArgumentNullException(nameof(userName));

            return await api.GetPorCorreo(userName);
        }

        public Task<string> GetEmailAsync(UruguayBusUser user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.Email); 
        }

        public Task<bool> GetEmailConfirmedAsync(UruguayBusUser user, CancellationToken cancellationToken)
        {
            return Task.FromResult(false);
        }

        public Task<IList<UserLoginInfo>> GetLoginsAsync(UruguayBusUser user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetNormalizedEmailAsync(UruguayBusUser user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetNormalizedUserNameAsync(UruguayBusUser user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetPasswordHashAsync(UruguayBusUser user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));

            return Task.FromResult(user.PasswordHash);
        }

        public Task<IList<string>> GetRolesAsync(UruguayBusUser user, CancellationToken cancellationToken)
        {
            IList<string> result = new List<string>();
            if (user.rol == null) {
                result.Add("User");
            }
            else
            {
                result.Add(user.rol);
            }
            return Task.FromResult(result);
        }

        public Task<string> GetUserIdAsync(UruguayBusUser user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));

            return Task.FromResult("0");
        }

        public Task<string> GetUserNameAsync(UruguayBusUser user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));

            return Task.FromResult(user.UserName);
        }

        public Task<IList<UruguayBusUser>> GetUsersInRoleAsync(string roleName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> HasPasswordAsync(UruguayBusUser user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsInRoleAsync(UruguayBusUser user, string roleName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task RemoveFromRoleAsync(UruguayBusUser user, string roleName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task RemoveLoginAsync(UruguayBusUser user, string loginProvider, string providerKey, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task SetEmailAsync(UruguayBusUser user, string email, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task SetEmailConfirmedAsync(UruguayBusUser user, bool confirmed, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task SetNormalizedEmailAsync(UruguayBusUser user, string normalizedEmail, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));
            if (normalizedEmail == null) throw new ArgumentNullException(nameof(normalizedEmail));

            user.NormalizedEmail= normalizedEmail;
            return Task.FromResult<object>(null);
        }

        public Task SetNormalizedUserNameAsync(UruguayBusUser user, string normalizedName, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));
            if (normalizedName == null) throw new ArgumentNullException(nameof(normalizedName));

            user.NormalizedUserName = normalizedName;
            return Task.FromResult<object>(null);
        }

        public Task SetPasswordHashAsync(UruguayBusUser user, string passwordHash, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));
            if (passwordHash == null) throw new ArgumentNullException(nameof(passwordHash));

            user.PasswordHash = passwordHash;
            return Task.FromResult<object>(null);

        }

        public Task SetUserNameAsync(UruguayBusUser user, string userName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> UpdateAsync(UruguayBusUser user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}