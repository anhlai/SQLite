using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0270U00GrdBAS0271Args : IContractArgs
    {
        private String _doctorYmd;
        private String _doctorName;
        private String _hospCode;

        public String DoctorYmd
        {
            get { return this._doctorYmd; }
            set { this._doctorYmd = value; }
        }

        public String DoctorName
        {
            get { return this._doctorName; }
            set { this._doctorName = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public BAS0270U00GrdBAS0271Args() { }

        public BAS0270U00GrdBAS0271Args(String doctorYmd, String doctorName, String hospCode)
        {
            this._doctorYmd = doctorYmd;
            this._doctorName = doctorName;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0270U00GrdBAS0271Request();
        }
    }
}