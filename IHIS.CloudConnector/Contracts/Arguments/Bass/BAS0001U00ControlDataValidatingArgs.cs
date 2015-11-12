using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0001U00ControlDataValidatingArgs : IContractArgs
    {
        private String _zipCode1;
        private String _zipCode2;
        private String _ctlName;

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

        public String CtlName
        {
            get { return this._ctlName; }
            set { this._ctlName = value; }
        }

        public BAS0001U00ControlDataValidatingArgs() { }

        public BAS0001U00ControlDataValidatingArgs(String zipCode1, String zipCode2, String ctlName)
        {
            this._zipCode1 = zipCode1;
            this._zipCode2 = zipCode2;
            this._ctlName = ctlName;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0001U00ControlDataValidatingRequest();
        }
    }
}