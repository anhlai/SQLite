using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0103U00GrdOCS0113ColChangedArgs : IContractArgs
    {
        private String _specimenCode;
        private String _hospCode;

        public String SpecimenCode
        {
            get { return this._specimenCode; }
            set { this._specimenCode = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public OCS0103U00GrdOCS0113ColChangedArgs() { }

        public OCS0103U00GrdOCS0113ColChangedArgs(String specimenCode, String hospCode)
        {
            this._specimenCode = specimenCode;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0103U00GrdOCS0113ColChangedRequest();
        }
    }
}