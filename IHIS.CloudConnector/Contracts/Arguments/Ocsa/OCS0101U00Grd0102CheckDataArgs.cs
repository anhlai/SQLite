using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0101U00Grd0102CheckDataArgs : IContractArgs
    {
        private String _value;
        private String _hospCode;

        public String Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public OCS0101U00Grd0102CheckDataArgs() { }

        public OCS0101U00Grd0102CheckDataArgs(String value, String hospCode)
        {
            this._value = value;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0101U00Grd0102CheckDataRequest();
        }
    }
}