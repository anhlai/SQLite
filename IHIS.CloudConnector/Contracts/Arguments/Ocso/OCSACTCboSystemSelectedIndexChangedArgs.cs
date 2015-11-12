using System;
using IHIS.CloudConnector.Contracts.Models.Ocso;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
    public class OCSACTCboSystemSelectedIndexChangedArgs : IContractArgs
    {
        private String _systemId;
        private String _codeType;
        private String _hoDong;

        public String SystemId
        {
            get { return this._systemId; }
            set { this._systemId = value; }
        }

        public String CodeType
        {
            get { return this._codeType; }
            set { this._codeType = value; }
        }

        public String HoDong
        {
            get { return this._hoDong; }
            set { this._hoDong = value; }
        }

        public OCSACTCboSystemSelectedIndexChangedArgs() { }

        public OCSACTCboSystemSelectedIndexChangedArgs(String systemId, String codeType, String hoDong)
        {
            this._systemId = systemId;
            this._codeType = codeType;
            this._hoDong = hoDong;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCSACTCboSystemSelectedIndexChangedRequest();
        }
    }
}