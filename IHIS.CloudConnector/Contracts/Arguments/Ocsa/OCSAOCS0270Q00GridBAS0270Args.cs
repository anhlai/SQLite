using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCSAOCS0270Q00GridBAS0270Args : IContractArgs
    {
        private String _allGubun;
        private String _gwa;
        private String _doctorGrade;
        private String _query;
        private String _osimGubun;
        private String _date;
        private String _hospCode;

        public String AllGubun
        {
            get { return this._allGubun; }
            set { this._allGubun = value; }
        }

        public String Gwa
        {
            get { return this._gwa; }
            set { this._gwa = value; }
        }

        public String DoctorGrade
        {
            get { return this._doctorGrade; }
            set { this._doctorGrade = value; }
        }

        public String Query
        {
            get { return this._query; }
            set { this._query = value; }
        }

        public String OsimGubun
        {
            get { return this._osimGubun; }
            set { this._osimGubun = value; }
        }

        public String Date
        {
            get { return this._date; }
            set { this._date = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public OCSAOCS0270Q00GridBAS0270Args() { }

        public OCSAOCS0270Q00GridBAS0270Args(String allGubun, String gwa, String doctorGrade, String query, String osimGubun, String date, String hospCode)
        {
            this._allGubun = allGubun;
            this._gwa = gwa;
            this._doctorGrade = doctorGrade;
            this._query = query;
            this._osimGubun = osimGubun;
            this._date = date;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCSAOCS0270Q00GridBAS0270Request();
        }
    }
}