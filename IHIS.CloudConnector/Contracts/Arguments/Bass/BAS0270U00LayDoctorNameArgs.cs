using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0270U00LayDoctorNameArgs : IContractArgs
    {
        private String _doctor;
        private String _doctorYmd;
        private String _hospCode;

        public String Doctor
        {
            get { return this._doctor; }
            set { this._doctor = value; }
        }

        public String DoctorYmd
        {
            get { return this._doctorYmd; }
            set { this._doctorYmd = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public BAS0270U00LayDoctorNameArgs() { }

        public BAS0270U00LayDoctorNameArgs(String doctor, String doctorYmd, String hospCode)
        {
            this._doctor = doctor;
            this._doctorYmd = doctorYmd;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0270U00LayDoctorNameRequest();
        }
    }
}