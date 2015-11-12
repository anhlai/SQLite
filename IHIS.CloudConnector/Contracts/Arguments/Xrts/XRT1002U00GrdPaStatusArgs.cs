using System;
using IHIS.CloudConnector.Contracts.Models.Xrts;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
    public class XRT1002U00GrdPaStatusArgs : IContractArgs
    {
        private String _bunho;
        private String _hangmogCode;

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public String HangmogCode
        {
            get { return this._hangmogCode; }
            set { this._hangmogCode = value; }
        }

        public XRT1002U00GrdPaStatusArgs() { }

        public XRT1002U00GrdPaStatusArgs(String bunho, String hangmogCode)
        {
            this._bunho = bunho;
            this._hangmogCode = hangmogCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.XRT1002U00GrdPaStatusRequest();
        }
    }
}