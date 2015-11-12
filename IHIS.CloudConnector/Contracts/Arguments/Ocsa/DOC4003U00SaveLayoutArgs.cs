using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class DOC4003U00SaveLayoutArgs : IContractArgs
    {
        private String _hospCode;
        private String _userId;
        private List<DOC4003U00GrdDOC4003Info> _saveLayoutItem = new List<DOC4003U00GrdDOC4003Info>();

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public List<DOC4003U00GrdDOC4003Info> SaveLayoutItem
        {
            get { return this._saveLayoutItem; }
            set { this._saveLayoutItem = value; }
        }

        public DOC4003U00SaveLayoutArgs() { }

        public DOC4003U00SaveLayoutArgs(String hospCode, String userId, List<DOC4003U00GrdDOC4003Info> saveLayoutItem)
        {
            this._hospCode = hospCode;
            this._userId = userId;
            this._saveLayoutItem = saveLayoutItem;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.DOC4003U00SaveLayoutRequest();
        }
    }
}