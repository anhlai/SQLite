using System;
using IHIS.CloudConnector.Contracts.Models.Xrts;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
    public class XRT1002U00BtnDeleteClickArgs : IContractArgs
    {
        private String _fkocs;

        public String Fkocs
        {
            get { return this._fkocs; }
            set { this._fkocs = value; }
        }

        public XRT1002U00BtnDeleteClickArgs() { }

        public XRT1002U00BtnDeleteClickArgs(String fkocs)
        {
            this._fkocs = fkocs;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.XRT1002U00BtnDeleteClickRequest();
        }
    }
}