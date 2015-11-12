using System;
using IHIS.CloudConnector.Contracts.Models.Orca;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Orca
{
    public class ORCATransferOrdersArgs : IContractArgs
    {
        private String _bunho;
        private String _hospCode;
        private String _pkout1001;

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public String Pkout1001
        {
            get { return this._pkout1001; }
            set { this._pkout1001 = value; }
        }

        public ORCATransferOrdersArgs() { }

        public ORCATransferOrdersArgs(String bunho, String hospCode, String pkout1001)
        {
            this._bunho = bunho;
            this._hospCode = hospCode;
            this._pkout1001 = pkout1001;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.ORCATransferOrdersRequest();
        }
    }
}