using System;
using IHIS.CloudConnector.Contracts.Models.System;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
    public class ComboOrdDanuiArgs : IContractArgs
    {
        private Boolean _isAll;
        private String _hospCode;

        public Boolean IsAll
        {
            get { return this._isAll; }
            set { this._isAll = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public ComboOrdDanuiArgs() { }

        public ComboOrdDanuiArgs(Boolean isAll, String hospCode)
        {
            this._isAll = isAll;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.ComboOrdDanuiRequest();
        }
    }
}