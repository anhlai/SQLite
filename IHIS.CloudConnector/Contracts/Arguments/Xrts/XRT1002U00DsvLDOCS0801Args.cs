using System;
using IHIS.CloudConnector.Contracts.Models.Xrts;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
    public class XRT1002U00DsvLDOCS0801Args : IContractArgs
    {
        private String _hangmogCode;

        public String HangmogCode
        {
            get { return this._hangmogCode; }
            set { this._hangmogCode = value; }
        }

        public XRT1002U00DsvLDOCS0801Args() { }

        public XRT1002U00DsvLDOCS0801Args(String hangmogCode)
        {
            this._hangmogCode = hangmogCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.XRT1002U00DsvLDOCS0801Request();
        }
    }
}