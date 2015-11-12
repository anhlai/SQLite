using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL3010U01GrdHangmogArgs : IContractArgs
    {
        private String _requestKey;

        public String RequestKey
        {
            get { return this._requestKey; }
            set { this._requestKey = value; }
        }

        public CPL3010U01GrdHangmogArgs() { }

        public CPL3010U01GrdHangmogArgs(String requestKey)
        {
            this._requestKey = requestKey;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL3010U01GrdHangmogRequest();
        }
    }
}