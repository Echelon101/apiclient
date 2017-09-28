using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopwareApi.Models.Customers
{
    public class Customer
    {
        public int id;
        public int paymentId;
        public string groupKey;
        public string shopId;
        public int priceGroupId;
        public string encoderName;
        public string hashPassword;
        public bool active;
        public string email;
        public string firstLogin;
        public string lastLogin;
        public int accountMode;
        public string confirmationKey;
        public string sessionId;
        public bool newsletter;
        public string validation;
        public bool affiliate;
        public int paymentPreset;
        public int languageId;
        public string referer;
        public string internalComment;
        public int failedLogins;
        public string lockedUntil;
    }
}
