using System;
using IHIS.CloudConnector.Contracts.Models.Schs;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
    public class SCH0201U10GrdReserListArgs : IContractArgs
    {
        private String _bunho;

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public SCH0201U10GrdReserListArgs() { }

        public SCH0201U10GrdReserListArgs(String bunho)
        {
            this._bunho = bunho;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.SCH0201U10GrdReserListRequest();
        }
    }
}