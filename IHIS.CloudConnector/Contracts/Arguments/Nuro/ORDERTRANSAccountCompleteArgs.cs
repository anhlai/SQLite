using System;
using IHIS.CloudConnector.Contracts.Models.Nuro;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class ORDERTRANSAccountCompleteArgs : IContractArgs
    {
        private String _hospCode;
        private String _bunho;
        private String _actingDate;
        private String _gubun;
        private String _gwa;
        private String _doctor;
        private String _chojae;
        private String _sunabDate;
        private String _ioGubun;
        private List<ORDERTRANSAccountCompleteInfo> _accCompleteItem = new List<ORDERTRANSAccountCompleteInfo>();

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

        public String Chojae
        {
            get { return this._chojae; }
            set { this._chojae = value; }
        }

        public String SunabDate
        {
            get { return this._sunabDate; }
            set { this._sunabDate = value; }
        }

        public String IoGubun
        {
            get { return this._ioGubun; }
            set { this._ioGubun = value; }
        }

        public List<ORDERTRANSAccountCompleteInfo> AccCompleteItem
        {
            get { return this._accCompleteItem; }
            set { this._accCompleteItem = value; }
        }

        public ORDERTRANSAccountCompleteArgs() { }

        public ORDERTRANSAccountCompleteArgs(String hospCode, String bunho, String actingDate, String gubun, String gwa, String doctor, String chojae, String sunabDate, String ioGubun, List<ORDERTRANSAccountCompleteInfo> accCompleteItem)
        {
            this._hospCode = hospCode;
            this._bunho = bunho;
            this._actingDate = actingDate;
            this._gubun = gubun;
            this._gwa = gwa;
            this._doctor = doctor;
            this._chojae = chojae;
            this._sunabDate = sunabDate;
            this._ioGubun = ioGubun;
            this._accCompleteItem = accCompleteItem;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.ORDERTRANSAccountCompleteRequest();
        }
    }
}