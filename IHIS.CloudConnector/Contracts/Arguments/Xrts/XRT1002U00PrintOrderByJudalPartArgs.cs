using System;
using IHIS.CloudConnector.Contracts.Models.Xrts;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
    public class XRT1002U00PrintOrderByJudalPartArgs : IContractArgs
    {
        private String _bunho;
        private String _hangmogCodes;

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public String HangmogCodes
        {
            get { return this._hangmogCodes; }
            set { this._hangmogCodes = value; }
        }

        public XRT1002U00PrintOrderByJudalPartArgs() { }

        public XRT1002U00PrintOrderByJudalPartArgs(String bunho, String hangmogCodes)
        {
            this._bunho = bunho;
            this._hangmogCodes = hangmogCodes;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.XRT1002U00PrintOrderByJudalPartRequest();
        }
    }
}