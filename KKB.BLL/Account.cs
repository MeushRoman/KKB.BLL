using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKB.BLL.Model
{
    public class Account
    {
        public string AccountNumber{get; set;}
        private double Balance_;
        public double Balance { get { return Balance_; }
            set { if (value < 0) throw new Exception("No money but you hold on"); } }

    }
}
