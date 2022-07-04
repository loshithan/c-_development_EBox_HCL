using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDetails
{
    internal class SavingAccount:Account
    {
        double _interestRate;

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Interest Rate :{0}",_interestRate);
        }
        public SavingAccount()
        {

        }
        public SavingAccount(string _holderName, long _accountNumber, string _IFSCCode, long _contactNumber, double _interestRate) : base(_holderName, _accountNumber, _IFSCCode, _contactNumber)
        {
            this._interestRate = _interestRate;
        }
        
    }
}
