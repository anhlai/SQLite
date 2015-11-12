using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL2010U00SetPrintArgs : IContractArgs
    {
        private String _userId;
        private String _bPrintName;
        private String _ipAddr;

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public String BPrintName
        {
            get { return this._bPrintName; }
            set { this._bPrintName = value; }
        }

        public String IpAddr
        {
            get { return this._ipAddr; }
            set { this._ipAddr = value; }
        }

        public CPL2010U00SetPrintArgs() { }

        public CPL2010U00SetPrintArgs(String userId, String bPrintName, String ipAddr)
        {
            this._userId = userId;
            this._bPrintName = bPrintName;
            this._ipAddr = ipAddr;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL2010U00SetPrintRequest();
        }
    }
}