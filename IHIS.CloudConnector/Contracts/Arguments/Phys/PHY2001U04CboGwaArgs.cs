using System;
using IHIS.CloudConnector.Contracts.Models.Phys;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Phys
{
    public class PHY2001U04CboGwaArgs : IContractArgs
    {
        private String _buseoYmd;

        public String BuseoYmd
        {
            get { return this._buseoYmd; }
            set { this._buseoYmd = value; }
        }

        public PHY2001U04CboGwaArgs() { }

        public PHY2001U04CboGwaArgs(String buseoYmd)
        {
            this._buseoYmd = buseoYmd;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.PHY2001U04CboGwaRequest();
        }
    }
}