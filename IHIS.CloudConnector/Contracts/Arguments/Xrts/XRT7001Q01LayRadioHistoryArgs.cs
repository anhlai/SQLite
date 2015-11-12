using System;
using IHIS.CloudConnector.Contracts.Models.Xrts;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
    public class XRT7001Q01LayRadioHistoryArgs : IContractArgs
    {
        private String _bunho;
        private String _partCode;

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public String PartCode
        {
            get { return this._partCode; }
            set { this._partCode = value; }
        }

        public XRT7001Q01LayRadioHistoryArgs() { }

        public XRT7001Q01LayRadioHistoryArgs(String bunho, String partCode)
        {
            this._bunho = bunho;
            this._partCode = partCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.XRT7001Q01LayRadioHistoryRequest();
        }
    }
}