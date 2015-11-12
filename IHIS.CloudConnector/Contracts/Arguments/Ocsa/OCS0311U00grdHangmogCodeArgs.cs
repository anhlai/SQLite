using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0311U00grdHangmogCodeArgs : IContractArgs
    {
        private String _setPart;

        public String SetPart
        {
            get { return this._setPart; }
            set { this._setPart = value; }
        }

        public OCS0311U00grdHangmogCodeArgs() { }

        public OCS0311U00grdHangmogCodeArgs(String setPart)
        {
            this._setPart = setPart;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0311U00grdHangmogCodeRequest();
        }
    }
}