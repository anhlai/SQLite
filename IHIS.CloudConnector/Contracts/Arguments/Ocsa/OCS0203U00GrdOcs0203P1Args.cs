using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0203U00GrdOcs0203P1Args : IContractArgs
    {
        private String _memb;
        private String _slipCode;
        private String _hospCode;

        public String Memb
        {
            get { return this._memb; }
            set { this._memb = value; }
        }

        public String SlipCode
        {
            get { return this._slipCode; }
            set { this._slipCode = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public OCS0203U00GrdOcs0203P1Args() { }

        public OCS0203U00GrdOcs0203P1Args(String memb, String slipCode, String hospCode)
        {
            this._memb = memb;
            this._slipCode = slipCode;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0203U00GrdOcs0203P1Request();
        }
    }
}