using System;
using IHIS.CloudConnector.Contracts.Models.Phys;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Phys
{
    public class PHY2001U04RefreshCounterArgs : IContractArgs
    {
        private String _gwa;
        private String _naewonDate;

        public String Gwa
        {
            get { return this._gwa; }
            set { this._gwa = value; }
        }

        public String NaewonDate
        {
            get { return this._naewonDate; }
            set { this._naewonDate = value; }
        }

        public PHY2001U04RefreshCounterArgs() { }

        public PHY2001U04RefreshCounterArgs(String gwa, String naewonDate)
        {
            this._gwa = gwa;
            this._naewonDate = naewonDate;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.PHY2001U04RefreshCounterRequest();
        }
    }
}