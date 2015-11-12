using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0110U00GrdJohapGubunArgs : IContractArgs
    {
        private String _code;
        private String _zipCode1;
        private String _zipCode2;
        private String _colName;

        public String Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

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

        public String ColName
        {
            get { return this._colName; }
            set { this._colName = value; }
        }

        public BAS0110U00GrdJohapGubunArgs() { }

        public BAS0110U00GrdJohapGubunArgs(String code, String zipCode1, String zipCode2, String colName)
        {
            this._code = code;
            this._zipCode1 = zipCode1;
            this._zipCode2 = zipCode2;
            this._colName = colName;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0110U00GrdJohapGubunRequest();
        }
    }
}