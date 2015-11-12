using System;
using IHIS.CloudConnector.Contracts.Models.Ocso;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
    public class OCS1023U00SaveLayoutArgs : IContractArgs
    {
        private String _userId;
        private List<OCS1023U00GrdOCS1023Info> _inputList = new List<OCS1023U00GrdOCS1023Info>();

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public List<OCS1023U00GrdOCS1023Info> InputList
        {
            get { return this._inputList; }
            set { this._inputList = value; }
        }

        public OCS1023U00SaveLayoutArgs() { }

        public OCS1023U00SaveLayoutArgs(String userId, List<OCS1023U00GrdOCS1023Info> inputList)
        {
            this._userId = userId;
            this._inputList = inputList;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS1023U00SaveLayoutRequest();
        }
    }
}