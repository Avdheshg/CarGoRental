using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGoRental.Model.Account
{
    public class LicenseInfo
    {
        public string LicenseNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string IssuedAtPlace { get; set; }
        public string IssuedInState { get; set; }
        public string IssuedInCountry { get; set; }
        public LicenseType LicenseType { get; set; }

        public LicenseInfo(string licenseNumber, DateTime issueDate, DateTime expiryDate, string issuedAtPlace, string issuedInState, string issuedInCountry, LicenseType licenseType)
        {
            LicenseNumber = licenseNumber;
            IssueDate = issueDate;
            ExpiryDate = expiryDate;
            IssuedAtPlace = issuedAtPlace;
            IssuedInState = issuedInState;
            IssuedInCountry = issuedInCountry;
            LicenseType = licenseType;
        }
    }
}
