using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDetails
{
    internal class Account
    {
        string _holderName;
        long _accountNumber;
        string _IFSCCode;
        long _contactNumber;

        public  Account(string holderName, long accountNumber, string iFSCCode, long contactNumber)
        {
            _holderName = holderName;
            _accountNumber = accountNumber;
            _IFSCCode = iFSCCode;
            _contactNumber = contactNumber;
        }
        public Account()
        {

        }
        public long AccountNumber
        {
            get { return _accountNumber; }      
            set { _accountNumber = value; }
        }
        public string IFSCCode
        {
            get { return _IFSCCode; }
            set { _IFSCCode = value; }
        }
        public long ContactNumber
        {
            get { return _contactNumber; }
            set
            {
                _contactNumber = value;
            }
        }
        public string HolderName
        {
            get { return _holderName; }
            set
            {
                _holderName = value;
            }
        }

        public virtual void  Display()
        {
            Console.WriteLine("Your Contact Details\nHolderName :{0}\nAccount Number :{1}\nIFSCCode :{2}\nContactNumber :{3}",HolderName,AccountNumber,IFSCCode,ContactNumber);

        }
    }
}
