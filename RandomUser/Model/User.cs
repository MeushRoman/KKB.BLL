using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKB.BLL.Model{
    public class User{

        public string Login{ get; set; }
        public string Password{ get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate{ get; set; }
        public int IIN{ get; set; }
        public string Phone{
            get { return this.Phone; }

            set {

                if (!value.StartsWith("+"))
                    throw new Exception("Wrong phone number!");

                this.Phone = Phone;
            }

        }

    }

     public class Result{

        public string Gender { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

    }

    public class Users{
        public List<Result> results = new List<Result>();
    }

    public class Name{

        public string Prefix{ get; set; }
        public string First{ get; set; }
        public string Last{ get; set; }

    }

    public class Location{

        public string City { get; set; }
        public string Country { get; set; }
        public string PostCode { get; set; }

    }

}