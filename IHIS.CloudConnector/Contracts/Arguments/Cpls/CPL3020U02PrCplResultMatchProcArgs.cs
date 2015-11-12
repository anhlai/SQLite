using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL3020U02PrCplResultMatchProcArgs : IContractArgs
    {
        private List<CPL3020U02PrCplResultMatchProcInfo> _infoList = new List<CPL3020U02PrCplResultMatchProcInfo>();

        public List<CPL3020U02PrCplResultMatchProcInfo> InfoList
        {
            get { return this._infoList; }
            set { this._infoList = value; }
        }

        public CPL3020U02PrCplResultMatchProcArgs() { }

        public CPL3020U02PrCplResultMatchProcArgs(List<CPL3020U02PrCplResultMatchProcInfo> infoList)
        {
            this._infoList = infoList;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL3020U02PrCplResultMatchProcRequest();
        }
    }
}