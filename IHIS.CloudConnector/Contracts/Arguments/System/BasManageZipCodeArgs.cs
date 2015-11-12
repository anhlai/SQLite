using System;
using System.Collections.Generic;
using System.Text;
using IHIS.CloudConnector.Contracts.Arguments;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
    public class BasManageZipCodeArgs : IContractArgs
    {
        private String _condition;
        private String _address;
        private String _zip1;
        private String _zip2;

        public String Condition
        {
            get { return this._condition; }
            set { this._condition = value; }
        }

        public String Address
        {
            get { return this._address; }
            set { this._address = value; }
        }

        public String Zip1
        {
            get { return this._zip1; }
            set { this._zip1 = value; }
        }

        public String Zip2
        {
            get { return this._zip2; }
            set { this._zip2 = value; }
        }

        public BasManageZipCodeArgs()
        {
        }

        public BasManageZipCodeArgs(String condition, String address, String zip1, String zip2)
        {
            this._condition = condition;
            this._address = address;
            this._zip1 = zip1;
            this._zip2 = zip2;
        }

        public IExtensible GetRequestInstance()
        {
            return new BasManageZipCodeRequest();
        }
    }
}