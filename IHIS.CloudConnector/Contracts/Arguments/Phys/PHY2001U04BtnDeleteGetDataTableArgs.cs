using System;
using IHIS.CloudConnector.Contracts.Models.Phys;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Phys
{
    public class PHY2001U04BtnDeleteGetDataTableArgs : IContractArgs
    {
        private String _bunho;
        private String _pkout1001;

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public String Pkout1001
        {
            get { return this._pkout1001; }
            set { this._pkout1001 = value; }
        }

        public PHY2001U04BtnDeleteGetDataTableArgs() { }

        public PHY2001U04BtnDeleteGetDataTableArgs(String bunho, String pkout1001)
        {
            this._bunho = bunho;
            this._pkout1001 = pkout1001;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.PHY2001U04BtnDeleteGetDataTableRequest();
        }
    }
}