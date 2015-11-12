using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0101PreDeleteOcs0102CheckArgs : IContractArgs
    {
        private String _slipCode;
        private String _hospCode;

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

        public OCS0101PreDeleteOcs0102CheckArgs() { }

        public OCS0101PreDeleteOcs0102CheckArgs(String slipCode, String hospCode)
        {
            this._slipCode = slipCode;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0101PreDeleteOcs0102CheckRequest();
        }
    }
}