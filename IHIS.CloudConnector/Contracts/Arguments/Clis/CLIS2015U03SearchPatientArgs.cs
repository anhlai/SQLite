using System;
using IHIS.CloudConnector.Contracts.Models.Clis;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Clis
{
    public class CLIS2015U03SearchPatientArgs : IContractArgs
    {
        private String _hospCode;
        private String _sex;
        private String _fromAge;
        private String _toAge;
        private String _naewonDateFrom;
        private String _naewonDateTo;
        private String _makerYn;
        private String _join;
        private String _patientCode;
        private String _filterStringOutsang;
        private String _filterStringOcs1003;
        private String _filterStringView;
        private String _filterStringEmr;
        private String _filterCommandOutsang;
        private String _filterCommandOcs1003;
        private String _filterCommandView;

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public String Sex
        {
            get { return this._sex; }
            set { this._sex = value; }
        }

        public String FromAge
        {
            get { return this._fromAge; }
            set { this._fromAge = value; }
        }

        public String ToAge
        {
            get { return this._toAge; }
            set { this._toAge = value; }
        }

        public String NaewonDateFrom
        {
            get { return this._naewonDateFrom; }
            set { this._naewonDateFrom = value; }
        }

        public String NaewonDateTo
        {
            get { return this._naewonDateTo; }
            set { this._naewonDateTo = value; }
        }

        public String MakerYn
        {
            get { return this._makerYn; }
            set { this._makerYn = value; }
        }

        public String Join
        {
            get { return this._join; }
            set { this._join = value; }
        }

        public String PatientCode
        {
            get { return this._patientCode; }
            set { this._patientCode = value; }
        }

        public String FilterStringOutsang
        {
            get { return this._filterStringOutsang; }
            set { this._filterStringOutsang = value; }
        }

        public String FilterStringOcs1003
        {
            get { return this._filterStringOcs1003; }
            set { this._filterStringOcs1003 = value; }
        }

        public String FilterStringView
        {
            get { return this._filterStringView; }
            set { this._filterStringView = value; }
        }

        public String FilterStringEmr
        {
            get { return this._filterStringEmr; }
            set { this._filterStringEmr = value; }
        }

        public String FilterCommandOutsang
        {
            get { return this._filterCommandOutsang; }
            set { this._filterCommandOutsang = value; }
        }

        public String FilterCommandOcs1003
        {
            get { return this._filterCommandOcs1003; }
            set { this._filterCommandOcs1003 = value; }
        }

        public String FilterCommandView
        {
            get { return this._filterCommandView; }
            set { this._filterCommandView = value; }
        }

        public CLIS2015U03SearchPatientArgs() { }

        public CLIS2015U03SearchPatientArgs(String hospCode, String sex, String fromAge, String toAge, String naewonDateFrom, String naewonDateTo, String makerYn, String join, String patientCode, String filterStringOutsang, String filterStringOcs1003, String filterStringView, String filterStringEmr, String filterCommandOutsang, String filterCommandOcs1003, String filterCommandView)
        {
            this._hospCode = hospCode;
            this._sex = sex;
            this._fromAge = fromAge;
            this._toAge = toAge;
            this._naewonDateFrom = naewonDateFrom;
            this._naewonDateTo = naewonDateTo;
            this._makerYn = makerYn;
            this._join = join;
            this._patientCode = patientCode;
            this._filterStringOutsang = filterStringOutsang;
            this._filterStringOcs1003 = filterStringOcs1003;
            this._filterStringView = filterStringView;
            this._filterStringEmr = filterStringEmr;
            this._filterCommandOutsang = filterCommandOutsang;
            this._filterCommandOcs1003 = filterCommandOcs1003;
            this._filterCommandView = filterCommandView;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CLIS2015U03SearchPatientRequest();
        }
    }
}