using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0270U00LayDoctorGradeArgs : IContractArgs
    {
        private String _code;
        private String _hospCode;

        public String Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public BAS0270U00LayDoctorGradeArgs() { }

        public BAS0270U00LayDoctorGradeArgs(String code, String hospCode)
        {
            this._code = code;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0270U00LayDoctorGradeRequest();
        }
    }
}