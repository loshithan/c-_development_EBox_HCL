using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDetails
{
    internal class CurrentAccount:Account
    {
        string _organizationName;
        long _TIN;

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Organization Name :{0}",_organizationName);
            Console.WriteLine("TIN :{0}",_TIN);


        }
        public CurrentAccount()
        {

        }
        public CurrentAccount(string _holderName, long _accountNumber, string _IFSCCode, long _contactNumber, string _organizationName, long _TIN): base(_holderName, _accountNumber, _IFSCCode, _contactNumber)
        {
            this._organizationName = _organizationName;
            this._TIN = _TIN;
        }
    }
}
