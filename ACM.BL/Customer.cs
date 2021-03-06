﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
  

        //private setter can be set only in constructor
      public class Customer
    {
        public Customer()
        {

        }

        public Customer(int customerId)
        {
            CustomerId = customerId;

        }
        private string _lastname;

        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";

                    } 

                    fullName += FirstName;
                }
                return fullName;

                }
        

            }

        public static int InstanceCount { get; set; }

        public string LastName
        {
            get
            {
                return _lastname;

            }
            set
            {
                _lastname = value;
            }
        }
        ///<summary>
        
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            return isValid;

        }
    }

 
    }
   
    
