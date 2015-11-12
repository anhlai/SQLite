using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroOUT1001U01CheckDoctorArgs : IContractArgs
    {
        private String _gubun;
        private String _date;
        private String _time;
        private String _doctor;

        public String Gubun
        {
            get { return this._gubun; }
            set { this._gubun = value; }
        }

        public String Date
        {
            get { return this._date; }
            set { this._date = value; }
        }

        public String Time
        {
            get { return this._time; }
            set { this._time = value; }
        }

        public String Doctor
        {
            get { return this._doctor; }
            set { this._doctor = value; }
        }

        public NuroOUT1001U01CheckDoctorArgs() { }

        public NuroOUT1001U01CheckDoctorArgs(String gubun, String date, String time, String doctor)
        {
            this._gubun = gubun;
            this._date = date;
            this._time = time;
            this._doctor = doctor;
        }

        public IExtensible GetRequestInstance()
        {
            return new NuroOUT1001U01CheckDoctorRequest();
        }
    }
}
