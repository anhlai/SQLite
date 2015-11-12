using System;
using IHIS.CloudConnector.Contracts.Models.Injs;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Injs
{
    public class INJ1001U01SaveLayoutArgs : IContractArgs
    {
        private String _userId;
        private String _updId;
        private List<INJ1001U01SaveLayoutInfo> _saveLayoutItem = new List<INJ1001U01SaveLayoutInfo>();

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public String UpdId
        {
            get { return this._updId; }
            set { this._updId = value; }
        }

        public List<INJ1001U01SaveLayoutInfo> SaveLayoutItem
        {
            get { return this._saveLayoutItem; }
            set { this._saveLayoutItem = value; }
        }

        public INJ1001U01SaveLayoutArgs() { }

        public INJ1001U01SaveLayoutArgs(String userId, String updId, List<INJ1001U01SaveLayoutInfo> saveLayoutItem)
        {
            this._userId = userId;
            this._updId = updId;
            this._saveLayoutItem = saveLayoutItem;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.INJ1001U01SaveLayoutRequest();
        }
    }
}