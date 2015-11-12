using System;
using IHIS.CloudConnector.Contracts.Models.Adma;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Adma
{
    public class ADM104UFwkBuseoCodeArgs : IContractArgs
    {
        private String _buseoCode;
        private String _gwaName;
        private String _hospCode;

        public String BuseoCode
        {
            get { return this._buseoCode; }
            set { this._buseoCode = value; }
        }

        public String GwaName
        {
            get { return this._gwaName; }
            set { this._gwaName = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public ADM104UFwkBuseoCodeArgs() { }

        public ADM104UFwkBuseoCodeArgs(String buseoCode, String gwaName, String hospCode)
        {
            this._buseoCode = buseoCode;
            this._gwaName = gwaName;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.ADM104UFwkBuseoCodeRequest();
        }
    }
}