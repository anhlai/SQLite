using System;
using IHIS.CloudConnector.Contracts.Models.Nuro;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NUROAccountForcedEndArgs : IContractArgs
    {
        private String _hospCode;
        private String _bunho;
        private List<NUROAccountForcedEndInfo> _listInfo = new List<NUROAccountForcedEndInfo>();
        private String _actingDate;
        private String _gubun;
        private String _gwa;
        private String _doctor;
        private String _pk;

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public List<NUROAccountForcedEndInfo> ListInfo
        {
            get { return this._listInfo; }
            set { this._listInfo = value; }
        }

        public String ActingDate
        {
            get { return this._actingDate; }
            set { this._actingDate = value; }
        }

        public String Gubun
        {
            get { return this._gubun; }
            set { this._gubun = value; }
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

        public String Pk
        {
            get { return this._pk; }
            set { this._pk = value; }
        }

        public NUROAccountForcedEndArgs() { }

        public NUROAccountForcedEndArgs(String hospCode, String bunho, List<NUROAccountForcedEndInfo> listInfo, String actingDate, String gubun, String gwa, String doctor, String pk)
        {
            this._hospCode = hospCode;
            this._bunho = bunho;
            this._listInfo = listInfo;
            this._actingDate = actingDate;
            this._gubun = gubun;
            this._gwa = gwa;
            this._doctor = doctor;
            this._pk = pk;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.NUROAccountForcedEndRequest();
        }
    }
}