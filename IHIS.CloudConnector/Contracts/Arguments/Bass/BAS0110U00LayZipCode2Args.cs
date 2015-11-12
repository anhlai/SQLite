using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0110U00LayZipCode2Args : IContractArgs
    {
        private String _zipCode1;
        private String _zipCode2;

        public String ZipCode1
        {
            get { return this._zipCode1; }
            set { this._zipCode1 = value; }
        }

        public String ZipCode2
        {
            get { return this._zipCode2; }
            set { this._zipCode2 = value; }
        }

        public BAS0110U00LayZipCode2Args() { }

        public BAS0110U00LayZipCode2Args(String zipCode1, String zipCode2)
        {
            this._zipCode1 = zipCode1;
            this._zipCode2 = zipCode2;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0110U00LayZipCode2Request();
        }
    }
}