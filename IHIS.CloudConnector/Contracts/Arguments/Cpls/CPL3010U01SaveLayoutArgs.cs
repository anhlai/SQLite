using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL3010U01SaveLayoutArgs : IContractArgs
    {
        private String _userId;
        private List<CPL3010U01SaveLayoutInfo> _saveLayoutLst = new List<CPL3010U01SaveLayoutInfo>();

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public List<CPL3010U01SaveLayoutInfo> SaveLayoutLst
        {
            get { return this._saveLayoutLst; }
            set { this._saveLayoutLst = value; }
        }

        public CPL3010U01SaveLayoutArgs() { }

        public CPL3010U01SaveLayoutArgs(String userId, List<CPL3010U01SaveLayoutInfo> saveLayoutLst)
        {
            this._userId = userId;
            this._saveLayoutLst = saveLayoutLst;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL3010U01SaveLayoutRequest();
        }
    }
}