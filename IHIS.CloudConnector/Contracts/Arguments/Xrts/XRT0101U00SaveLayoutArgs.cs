using System;
using IHIS.CloudConnector.Contracts.Models.Xrts;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
    public class XRT0101U00SaveLayoutArgs : IContractArgs
    {
        private String _userId;
        private List<XRT0101U00SaveLayoutInfo> _saveLayoutItem = new List<XRT0101U00SaveLayoutInfo>();

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public List<XRT0101U00SaveLayoutInfo> SaveLayoutItem
        {
            get { return this._saveLayoutItem; }
            set { this._saveLayoutItem = value; }
        }

        public XRT0101U00SaveLayoutArgs() { }

        public XRT0101U00SaveLayoutArgs(String userId, List<XRT0101U00SaveLayoutInfo> saveLayoutItem)
        {
            this._userId = userId;
            this._saveLayoutItem = saveLayoutItem;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.XRT0101U00SaveLayoutRequest();
        }
    }
}