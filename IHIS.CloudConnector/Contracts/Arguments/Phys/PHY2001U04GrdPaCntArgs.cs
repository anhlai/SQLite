using System;
using IHIS.CloudConnector.Contracts.Models.Phys;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Phys
{
    public class PHY2001U04GrdPaCntArgs : IContractArgs
    {
        private String _naewonDate;

        public String NaewonDate
        {
            get { return this._naewonDate; }
            set { this._naewonDate = value; }
        }

        public PHY2001U04GrdPaCntArgs() { }

        public PHY2001U04GrdPaCntArgs(String naewonDate)
        {
            this._naewonDate = naewonDate;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.PHY2001U04GrdPaCntRequest();
        }
    }
}