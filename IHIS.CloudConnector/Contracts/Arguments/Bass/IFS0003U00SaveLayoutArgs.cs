using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class IFS0003U00SaveLayoutArgs : IContractArgs
    {
        private String _userId;
        private List<IFS0003U00GrdIFS0003Info> _inputList = new List<IFS0003U00GrdIFS0003Info>();

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public List<IFS0003U00GrdIFS0003Info> InputList
        {
            get { return this._inputList; }
            set { this._inputList = value; }
        }

        public IFS0003U00SaveLayoutArgs() { }

        public IFS0003U00SaveLayoutArgs(String userId, List<IFS0003U00GrdIFS0003Info> inputList)
        {
            this._userId = userId;
            this._inputList = inputList;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.IFS0003U00SaveLayoutRequest();
        }
    }
}