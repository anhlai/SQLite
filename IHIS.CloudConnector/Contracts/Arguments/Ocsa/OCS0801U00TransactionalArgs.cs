using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0801U00TransactionalArgs : IContractArgs
    {
        private List<OCS0801U00GrdOCS0801ListItemInfo> _listInfo1 = new List<OCS0801U00GrdOCS0801ListItemInfo>();
        private List<OCS0801U00GrdOCS0802ListItemInfo> _listInfo2 = new List<OCS0801U00GrdOCS0802ListItemInfo>();
        private String _userId;

        public List<OCS0801U00GrdOCS0801ListItemInfo> ListInfo1
        {
            get { return this._listInfo1; }
            set { this._listInfo1 = value; }
        }

        public List<OCS0801U00GrdOCS0802ListItemInfo> ListInfo2
        {
            get { return this._listInfo2; }
            set { this._listInfo2 = value; }
        }

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public OCS0801U00TransactionalArgs() { }

        public OCS0801U00TransactionalArgs(List<OCS0801U00GrdOCS0801ListItemInfo> listInfo1, List<OCS0801U00GrdOCS0802ListItemInfo> listInfo2, String userId)
        {
            this._listInfo1 = listInfo1;
            this._listInfo2 = listInfo2;
            this._userId = userId;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0801U00TransactionalRequest();
        }
    }
}