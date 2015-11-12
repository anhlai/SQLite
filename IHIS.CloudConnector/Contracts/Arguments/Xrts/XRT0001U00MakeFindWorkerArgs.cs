using System;
using IHIS.CloudConnector.Contracts.Models.Xrts;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
    public class XRT0001U00MakeFindWorkerArgs : IContractArgs
    {
        private String _ctrName;
        private String _find1;

        public String CtrName
        {
            get { return this._ctrName; }
            set { this._ctrName = value; }
        }

        public String Find1
        {
            get { return this._find1; }
            set { this._find1 = value; }
        }

        public XRT0001U00MakeFindWorkerArgs() { }

        public XRT0001U00MakeFindWorkerArgs(String ctrName, String find1)
        {
            this._ctrName = ctrName;
            this._find1 = find1;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.XRT0001U00MakeFindWorkerRequest();
        }
    }
}