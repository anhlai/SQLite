using System;
using IHIS.CloudConnector.Contracts.Models.System;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
    public class MdiFormOpenMainScreenArgs : IContractArgs
    {
        private String _systemId;

        public String SystemId
        {
            get { return this._systemId; }
            set { this._systemId = value; }
        }

        public MdiFormOpenMainScreenArgs() { }

        public MdiFormOpenMainScreenArgs(String systemId)
        {
            this._systemId = systemId;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.MdiFormOpenMainScreenRequest();
        }
    }
}