using System;
using IHIS.CloudConnector.Contracts.Models.Endo;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Endo
{
    public class END1001U02DsvDwArgs : IContractArgs
    {
        private String _fkocs;
        private String _hospCode;

        public String Fkocs
        {
            get { return this._fkocs; }
            set { this._fkocs = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public END1001U02DsvDwArgs() { }

        public END1001U02DsvDwArgs(String fkocs, String hospCode)
        {
            this._fkocs = fkocs;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.END1001U02DsvDwRequest();
        }
    }
}