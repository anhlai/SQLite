using System;
using IHIS.CloudConnector.Contracts.Models.Endo;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Endo
{
    public class END1001U02DsvLDOCS0801Args : IContractArgs
    {
        private String _hangmogCode;
        private String _hospCode;

        public String HangmogCode
        {
            get { return this._hangmogCode; }
            set { this._hangmogCode = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public END1001U02DsvLDOCS0801Args() { }

        public END1001U02DsvLDOCS0801Args(String hangmogCode, String hospCode)
        {
            this._hangmogCode = hangmogCode;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.END1001U02DsvLDOCS0801Request();
        }
    }
}