using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Problem2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class NEITStoreOrdersService : INEITStoreOrdersService
    {
        public Information getBankInformation(string accountID)
        {
            Information myInfo = new Information();
            myInfo.AccountID = "12345";
                Account account1 = new Account();
                account1.AccountType = "Checking";
                    Option acc1Op = new Option();
                    acc1Op.FreeChecking = "N";
                    acc1Op.OverDraftProtection = "Y";
                account1.Options = acc1Op;     
                Account account2 = new Account();
                account2.AccountType = "savings";
                    Option acc2Op = new Option();
                    acc2Op.FreeChecking = null;
                    acc2Op.OverDraftProtection = "N";
                account2.Options = acc2Op;
            Account[] accountsArray = new Account[2];
            accountsArray[0] = account1;
            accountsArray[1] = account2;
            myInfo.Accounts = accountsArray;
            myInfo.OwnerName = "Sam Spade";

            return myInfo;
        }

        public float returnAmountEarned(float balance, float interest)
        {
            return balance * interest;
        }
    }
}
