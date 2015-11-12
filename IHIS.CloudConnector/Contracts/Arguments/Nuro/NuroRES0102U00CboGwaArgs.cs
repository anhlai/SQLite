using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroRES0102U00CboGwaArgs : IContractArgs
    {
        private String _appDate;
        private String _hospCode;

        public String AppDate
        {
            get { return this._appDate; }
            set { this._appDate = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public NuroRES0102U00CboGwaArgs() { }

        public NuroRES0102U00CboGwaArgs(String appDate, String hospCode)
        {
            this._appDate = appDate;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new NuroRES0102U00CboGwaRequest();
        }
    }
}