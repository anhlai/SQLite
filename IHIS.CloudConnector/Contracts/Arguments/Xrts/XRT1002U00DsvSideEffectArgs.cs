using System;
using IHIS.CloudConnector.Contracts.Models.Xrts;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
    public class XRT1002U00DsvSideEffectArgs : IContractArgs
    {
        private String _bunho;

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public XRT1002U00DsvSideEffectArgs() { }

        public XRT1002U00DsvSideEffectArgs(String bunho)
        {
            this._bunho = bunho;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.XRT1002U00DsvSideEffectRequest();
        }
    }
}