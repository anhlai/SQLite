using System;
using IHIS.CloudConnector.Contracts.Models.Phys;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Phys
{
    public class PHY2001U04BtnDeleteExistYnArgs : IContractArgs
    {
        private String _pkout1001;

        public String Pkout1001
        {
            get { return this._pkout1001; }
            set { this._pkout1001 = value; }
        }

        public PHY2001U04BtnDeleteExistYnArgs() { }

        public PHY2001U04BtnDeleteExistYnArgs(String pkout1001)
        {
            this._pkout1001 = pkout1001;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.PHY2001U04BtnDeleteExistYnRequest();
        }
    }
}