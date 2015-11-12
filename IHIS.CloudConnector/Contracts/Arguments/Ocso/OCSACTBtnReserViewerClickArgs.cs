using System;
using IHIS.CloudConnector.Contracts.Models.Ocso;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
    public class OCSACTBtnReserViewerClickArgs : IContractArgs
    {
        private String _code;

        public String Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        public OCSACTBtnReserViewerClickArgs() { }

        public OCSACTBtnReserViewerClickArgs(String code)
        {
            this._code = code;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCSACTBtnReserViewerClickRequest();
        }
    }
}