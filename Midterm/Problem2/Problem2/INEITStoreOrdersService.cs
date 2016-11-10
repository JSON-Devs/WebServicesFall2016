using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Problem2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface INEITStoreOrdersService
    {

        [OperationContract]

        float returnAmountEarned(float balance, float interest);

        [OperationContract]

        Information getBankInformation(string accountID);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Information
    {
        string accountID, ownerName;
        Account[] accounts;

        [DataMember]
        public string AccountID
        {
            get
            {
                return accountID;
            }

            set
            {
                accountID = value;
            }
        }

        [DataMember]
        public Account[] Accounts
        {
            get
            {
                return accounts;
            }

            set
            {
                accounts = value;
            }
        }

        [DataMember]
        public string OwnerName
        {
            get
            {
                return ownerName;
            }

            set
            {
                ownerName = value;
            }
        }
    }

    public class Account
    {
        string accountType;
        Option options;

        public string AccountType
        {
            get
            {
                return accountType;
            }

            set
            {
                accountType = value;
            }
        }

        public Option Options
        {
            get
            {
                return options;
            }

            set
            {
                options = value;
            }
        }
    }

    public class Option
    {
        string freeChecking, overDraftProtection;

        public string FreeChecking
        {
            get
            {
                return freeChecking;
            }

            set
            {
                freeChecking = value;
            }
        }

        public string OverDraftProtection
        {
            get
            {
                return overDraftProtection;
            }

            set
            {
                overDraftProtection = value;
            }
        }
    }

}
