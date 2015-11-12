using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
    public class OcsoLoadCht0110Info
    {
        private String _sangCode;
        private String _sangName;
        private String _icd9Code;

        public String SangCode
        {
            get { return this._sangCode; }
            set { this._sangCode = value; }
        }

        public String SangName
        {
            get { return this._sangName; }
            set { this._sangName = value; }
        }

        public String Icd9Code
        {
            get { return this._icd9Code; }
            set { this._icd9Code = value; }
        }

        public OcsoLoadCht0110Info() { }

        public OcsoLoadCht0110Info(String sangCode, String sangName, String icd9Code)
        {
            this._sangCode = sangCode;
            this._sangName = sangName;
            this._icd9Code = icd9Code;
        }

    }
}