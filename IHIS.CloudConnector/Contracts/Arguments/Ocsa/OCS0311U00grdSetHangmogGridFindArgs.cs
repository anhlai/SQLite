using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0311U00grdSetHangmogGridFindArgs : IContractArgs
    {
        private String _hangmogCode;

        public String HangmogCode
        {
            get { return this._hangmogCode; }
            set { this._hangmogCode = value; }
        }

        public OCS0311U00grdSetHangmogGridFindArgs() { }

        public OCS0311U00grdSetHangmogGridFindArgs(String hangmogCode)
        {
            this._hangmogCode = hangmogCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0311U00grdSetHangmogGridFindRequest();
        }
    }
}