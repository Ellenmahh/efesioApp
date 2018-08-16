using System;
using System.Threading.Tasks;

namespace EfesioApp
{
    public class Core
    {
        public static async Task<LoginClass>GetLoginClass(string login, string pass)
        {
            //usuario = ellen & senha = 123
            string queryString = "http://localhost:8080/efesioapi/api/usuario/login?"+ "login="
                + login + "&pass=" + pass;

            var results = await DataService.get(queryString).ConfigureAwait(false);

            if (results["login"] != null)
            {
                LoginClass loginClass = new LoginClass
                {
                    Usuario = (string)results["login"],
                    Senha = (string)results["pass"]
                };
                return loginClass;
            }
            else
            {
                return null;
            }
        }
    }
}
