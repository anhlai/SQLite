using System;
using IHIS.CloudConnector.Contracts.Models.Phys;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Phys
{
    public class PHY2001U04GrdListArgs : IContractArgs
    {
        private String _bunho;
        private String _statFlg;
        private String _naewonDate;
        private String _gwa;
        private String _doctor;
        private String _gubun;

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public String StatFlg
        {
            get { return this._statFlg; }
            set { this._statFlg = value; }
        }

        public String NaewonDate
        {
            get { return this._naewonDate; }
            set { this._naewonDate = value; }
        }

        public String Gwa
        {
            get { return this._gwa; }
            set { this._gwa = value; }
        }

        public String Doctor
        {
            get { return this._doctor; }
            set { this._doctor = value; }
        }

        public String Gubun
        {
            get { return this._gubun; }
            set { this._gubun = value; }
        }

        public PHY2001U04GrdListArgs() { }

        public PHY2001U04GrdListArgs(String bunho, String statFlg, String naewonDate, String gwa, String doctor, String gubun)
        {
            this._bunho = bunho;
            this._statFlg = statFlg;
            this._naewonDate = naewonDate;
            this._gwa = gwa;
            this._doctor = doctor;
            this._gubun = gubun;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.PHY2001U04GrdListRequest();
        }
    }
}