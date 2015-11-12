using System;
using IHIS.CloudConnector.Contracts.Models.Nuro;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class RES1001U00FrmModifySaveLayoutArgs : IContractArgs
    {
        private String _userId;
        private List<RES1001U00FrmModifySaveLayoutInfo> _saveLayoutItem = new List<RES1001U00FrmModifySaveLayoutInfo>();

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public List<RES1001U00FrmModifySaveLayoutInfo> SaveLayoutItem
        {
            get { return this._saveLayoutItem; }
            set { this._saveLayoutItem = value; }
        }

        public RES1001U00FrmModifySaveLayoutArgs() { }

        public RES1001U00FrmModifySaveLayoutArgs(String userId, List<RES1001U00FrmModifySaveLayoutInfo> saveLayoutItem)
        {
            this._userId = userId;
            this._saveLayoutItem = saveLayoutItem;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.RES1001U00FrmModifySaveLayoutRequest();
        }
    }
}