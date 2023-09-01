using System;

namespace Employee
{
    public interface IDeduction
    {
        public double calcIncomeTax(double pay)
        {
            if(pay <= 49000)
            {
                return 15;
            }
            else if(pay >= 49000 && pay <= 98000)
            {
                return 20;
            }
            else if(pay >= 98000 && pay <= 151000)
            {
                return 26;
            }
            else if(pay >= 151000 && pay <= 215000)
            {
                return 29;
            }
            else if(pay > 215000)
            {
                return 33;
            }
            else
            {
                return -1; //error, invalid value
            }
        }

        public double calcPension()
        {
            return 0;
        }

        public double calcUnionDues()
        {
            return 0;
        }

        public double calcInsurance()
        {
            return 0;
        }
    }

    public class Employee : IDeduction
    {
        int SIN, phoneNumber;
        string fullName, fullAddress, emailAddress;
        string companyName = "Jack's Company";
        DateTime hireDate, dateOfBirth;
        bool status;
        
        public Employee(int SIN, int phoneNumber, string fullName, string fullAddress, string email, DateTime hireDate, DateTime dateOfBirth, bool status)
        {
            this.SIN = SIN;
            this.phoneNumber = phoneNumber;
            this.fullName = fullName;
            this.fullAddress = fullAddress;
            this.emailAddress = email;
            this.hireDate = hireDate;
            this.dateOfBirth = dateOfBirth;
            this.status = status;
        }
        
        public double Bonus()
        {
            return 0;
        }

        virtual public double CalculatePay()
        {
            return 0;
        }
        public override string ToString()
        {
            return "Employee full name: " + fullName + ", Phone Number: " + phoneNumber;
        }
        public int getSin()
        {
            if(SIN.ToString().Length == 9) //SIN must be 9 digits
            {
                return SIN;
            }
            else
            {
                return -1; //invalid SIN
            }
        }

        public int getPhoneNumber()
        {
            if (phoneNumber.ToString().Length >= 9 && phoneNumber.ToString().Length <= 11) //phone number must be between 9 and 11 digits
            {
                return phoneNumber;
            }
            else
            {
                return -1; //invalid phone number
            }
        }

        public string getName()
        {
            if(fullName.Length > 3) //Full name must be more than 3 characters
            {
                return fullName;
            }
            else
            {
                return null; //invalid name
            }
        }

        public string getAddress()
        {
            if (fullAddress.Length > 10) //Full address must be more than 10 characters
            {
                return fullAddress;
            }
            else
            {
                return null; //invalid address
            }
        }

        public string getEmailAddress()
        {
            if (emailAddress.Length > 5) //email address must be more than 5
            {
                return fullName;
            }
            else
            {
                return null; //invalid name
            }
        }

        public DateTime? getHireDate()
        {
            if (hireDate.ToString().Length > 5)
            {
                return hireDate;
            }
            else
            {
                return null;
            }
        }

        public DateTime? getDateOfBirth()
        {
            if (dateOfBirth.ToString().Length > 5)
            {
                return dateOfBirth;
            }
            else
            {
                return null;
            }
        }

        public bool getStatus() => status;
        
        struct Address
        {
            string street, city, province, postalCode;

            public Address(string Street, string City, string Province, string PostalCode)
            {
                this.street = Street;
                this.city = City;
                this.province = Province;
                this.postalCode = PostalCode;
            }

            public override string ToString()
            {
                if(street.Length > 3 && city.Length > 3 && province.Length > 3 && postalCode.Length == 5) //street name must be atleast 3 characters
                {
                    return street + ", " + city + ", " + province + ". " + postalCode + " .";
                }
                else
                {
                    return null;
                }          
            }
        }

    }
}
