using System;
using IHIS.CloudConnector.Contracts.Models.Nuro;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class ORDERTRANOrderTransArgs : IContractArgs
    {
        private String _hospCode;
        private String _fkout1003;
        private String _transGubun;

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public String Fkout1003
        {
            get { return this._fkout1003; }
            set { this._fkout1003 = value; }
        }

        public String TransGubun
        {
            get { return this._transGubun; }
            set { this._transGubun = value; }
        }

        public ORDERTRANOrderTransArgs() { }

        public ORDERTRANOrderTransArgs(String hospCode, String fkout1003, String transGubun)
        {
            this._hospCode = hospCode;
            this._fkout1003 = fkout1003;
            this._transGubun = transGubun;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.ORDERTRANOrderTransRequest();
        }
    }
}