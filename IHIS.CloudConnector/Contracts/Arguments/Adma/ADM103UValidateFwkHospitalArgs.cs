using System;
using IHIS.CloudConnector.Contracts.Models.Adma;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Adma
{
    public class ADM103UValidateFwkHospitalArgs : IContractArgs
    {
        private String _hospCode;

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public ADM103UValidateFwkHospitalArgs() { }

        public ADM103UValidateFwkHospitalArgs(String hospCode)
        {
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.ADM103UValidateFwkHospitalRequest();
        }
    }
}