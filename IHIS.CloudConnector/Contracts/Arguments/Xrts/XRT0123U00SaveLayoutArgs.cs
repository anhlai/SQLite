using System;
using IHIS.CloudConnector.Contracts.Models.Xrts;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
    public class XRT0123U00SaveLayoutArgs : IContractArgs
    {
        private String _userId;
        private List<XRT0123U00GrdDCodeItemInfo> _inputList = new List<XRT0123U00GrdDCodeItemInfo>();

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public List<XRT0123U00GrdDCodeItemInfo> InputList
        {
            get { return this._inputList; }
            set { this._inputList = value; }
        }

        public XRT0123U00SaveLayoutArgs() { }

        public XRT0123U00SaveLayoutArgs(String userId, List<XRT0123U00GrdDCodeItemInfo> inputList)
        {
            this._userId = userId;
            this._inputList = inputList;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.XRT0123U00SaveLayoutRequest();
        }
    }
}