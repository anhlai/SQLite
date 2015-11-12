using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL2010U00OrderCancelGetYNArgs : IContractArgs
    {
        private String _fkocs1003;

        public String Fkocs1003
        {
            get { return this._fkocs1003; }
            set { this._fkocs1003 = value; }
        }

        public CPL2010U00OrderCancelGetYNArgs() { }

        public CPL2010U00OrderCancelGetYNArgs(String fkocs1003)
        {
            this._fkocs1003 = fkocs1003;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL2010U00OrderCancelGetYNRequest();
        }
    }
}