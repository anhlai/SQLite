using System;
using IHIS.CloudConnector.Contracts.Models.Phys;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Phys
{
    public class PHY2001U04GrdOut1001Args : IContractArgs
    {
        private String _gwa;
        private String _bunho;
        private String _naewonDate;

        public String Gwa
        {
            get { return this._gwa; }
            set { this._gwa = value; }
        }

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public String NaewonDate
        {
            get { return this._naewonDate; }
            set { this._naewonDate = value; }
        }

        public PHY2001U04GrdOut1001Args() { }

        public PHY2001U04GrdOut1001Args(String gwa, String bunho, String naewonDate)
        {
            this._gwa = gwa;
            this._bunho = bunho;
            this._naewonDate = naewonDate;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.PHY2001U04GrdOut1001Request();
        }
    }
}