using KKB.BLL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
using RandomUser.Model;
using  KKB.BLL.Model;
using Newtonsoft.Json;*/


namespace KKB.BLL.Model
{
     public class ServiceUser
    {

        public bool logOn(User user,out string message)
        {
            if (user.Login == "admin" && user.Password == "111")
            {
                Result res = RandomUser.GetUser.GetRndUser();
                message = "";
                return true;
            }
            message = "Wrong name or pass";
            return false;
        }

    }
}
