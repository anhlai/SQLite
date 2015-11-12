using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0223U00GrdOCS0223Args : IContractArgs
    {
        private String _jundalPart;
        private String _hospCode;

        public String JundalPart
        {
            get { return this._jundalPart; }
            set { this._jundalPart = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public OCS0223U00GrdOCS0223Args() { }

        public OCS0223U00GrdOCS0223Args(String jundalPart, String hospCode)
        {
            this._jundalPart = jundalPart;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0223U00GrdOCS0223Request();
        }
    }
}