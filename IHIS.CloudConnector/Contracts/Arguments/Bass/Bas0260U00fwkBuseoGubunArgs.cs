using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class Bas0260U00fwkBuseoGubunArgs : IContractArgs
    {
        private String _hospCode;

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public Bas0260U00fwkBuseoGubunArgs() { }

        public Bas0260U00fwkBuseoGubunArgs(String hospCode)
        {
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.Bas0260U00fwkBuseoGubunRequest();
        }
    }
}