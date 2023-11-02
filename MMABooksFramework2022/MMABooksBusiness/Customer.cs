using System;
using System.Collections.Generic;
using System.Text;

using MMABooksTools;
using MMABooksProps;
using MMABooksDB;

namespace MMABooksBusiness
{
    public class Customer : BaseBusiness
    {
        public String Name
        {
            get
            {
                return ((StateProps)mProps).Name;
            }

            set
            {
                if (!(value == ((StateProps)mProps).Name))
                {
                    if (value.Trim().Length >= 1 && value.Trim().Length <= 20)
                    {
                        mRules.RuleBroken("Name", false);
                        ((StateProps)mProps).Name = value;
                        mIsDirty = true;
                    }

                    else
                    {
                        throw new ArgumentOutOfRangeException("Name must be no more than 20 characters long.");
                    }
                }
            }
        }

        public override object GetList()
        {
            throw new NotImplementedException();
        }

        protected override void SetDefaultProperties()
        {
            throw new NotImplementedException();
        }

        protected override void SetRequiredRules()
        {
            throw new NotImplementedException();
        }

        protected override void SetUp()
        {
            throw new NotImplementedException();
        }

        #region constructors
        /// <summary>
        /// Default constructor - gets the connection string - assumes a new record that is not in the database.
        /// </summary>
        public Customer()
        {
        }

        /// <summary>
        /// Calls methods SetUp() and Load().
        /// Use this constructor when the object is in the database AND the connection string is in a config file
        /// </summary>
        /// <param name="key">ID number of a record in the database.
        /// Sent as an arg to Load() to set values of record to properties of an 
        /// object.</param>
        public Customer(int key)
            : base(key)
        {
        }

        private Customer(CustomerProps props)
            : base(props)
        {
        }

        #endregion
    }
}
