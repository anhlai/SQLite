using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OcsaOCS0208U00LoadBogyongNameFromOcsArgs : IContractArgs
    {
        private String _code;
        private String _doctor;
        private String _hospCode;

        public String Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        public String Doctor
        {
            get { return this._doctor; }
            set { this._doctor = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public OcsaOCS0208U00LoadBogyongNameFromOcsArgs() { }

        public OcsaOCS0208U00LoadBogyongNameFromOcsArgs(String code, String doctor, String hospCode)
        {
            this._code = code;
            this._doctor = doctor;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OcsaOCS0208U00LoadBogyongNameFromOcsRequest();
        }
    }
}