using System;
using IHIS.CloudConnector.Contracts.Models.Pfes;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Pfes
{
    public class PFE0101U00SaveLayoutArgs : IContractArgs
    {
        private String _userId;
        private List<PFE0101U00SaveLayoutInfo> _saveLayoutItem = new List<PFE0101U00SaveLayoutInfo>();

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public List<PFE0101U00SaveLayoutInfo> SaveLayoutItem
        {
            get { return this._saveLayoutItem; }
            set { this._saveLayoutItem = value; }
        }

        public PFE0101U00SaveLayoutArgs() { }

        public PFE0101U00SaveLayoutArgs(String userId, List<PFE0101U00SaveLayoutInfo> saveLayoutItem)
        {
            this._userId = userId;
            this._saveLayoutItem = saveLayoutItem;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.PFE0101U00SaveLayoutRequest();
        }
    }
}