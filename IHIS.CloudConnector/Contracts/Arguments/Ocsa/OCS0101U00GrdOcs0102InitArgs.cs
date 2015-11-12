using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0101U00GrdOcs0102InitArgs : IContractArgs
    {
        private String _slipGubun;
        private String _hospCode;

        public String SlipGubun
        {
            get { return this._slipGubun; }
            set { this._slipGubun = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public OCS0101U00GrdOcs0102InitArgs() { }

        public OCS0101U00GrdOcs0102InitArgs(String slipGubun, String hospCode)
        {
            this._slipGubun = slipGubun;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0101U00GrdOcs0102InitRequest();
        }
    }
}