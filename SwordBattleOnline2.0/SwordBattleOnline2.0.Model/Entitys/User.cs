using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwordBattleOnline.Model.Entitys
{
    public class User
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}