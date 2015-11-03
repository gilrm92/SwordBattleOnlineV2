using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;

namespace SwordBattleOnline.Site.asmx
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    [ScriptService]
    public class Login : System.Web.Services.WebService
    {
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string CreateUser(string userJSON)
        {
            var serializer = new JavaScriptSerializer();
            var objAnom = new
            {
                Nome = "",
                Email = "",
                Senha = ""
            };

            var userDes = serializer.Deserialize<Dictionary<string,string>>(userJSON);
            return "Baah!";
        }
    }
}
