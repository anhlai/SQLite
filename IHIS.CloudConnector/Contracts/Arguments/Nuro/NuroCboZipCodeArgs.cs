using System;
using System.Collections.Generic;
using System.Text;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroCboZipCodeArgs : IContractArgs
    {
        public string _zipCode1;
        public string _zipCode2;

        public NuroCboZipCodeArgs()
        {
        }

        public NuroCboZipCodeArgs(string zipCode1, string zipCode2)
        {
            _zipCode1 = zipCode1;
            _zipCode2 = zipCode2;
        }

        public string ZipCode1
        {
            get { return _zipCode1; }
            set { _zipCode1 = value; }
        }

        public string ZipCode2
        {
            get { return _zipCode2; }
            set { _zipCode2 = value; }
        }

        public IExtensible GetRequestInstance()
        {
            return  new NuroCboZipCodeRequest();
        }
    }
}
