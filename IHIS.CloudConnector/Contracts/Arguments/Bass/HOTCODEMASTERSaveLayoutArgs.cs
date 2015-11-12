using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class HOTCODEMASTERSaveLayoutArgs : IContractArgs
    {
        private String _userId;
        private String _hospCode;
        private String _truncateYn;
        private List<HOTCODEMASTERGetGrdListInfo> _layoutItem = new List<HOTCODEMASTERGetGrdListInfo>();

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public String TruncateYn
        {
            get { return this._truncateYn; }
            set { this._truncateYn = value; }
        }

        public List<HOTCODEMASTERGetGrdListInfo> LayoutItem
        {
            get { return this._layoutItem; }
            set { this._layoutItem = value; }
        }

        public HOTCODEMASTERSaveLayoutArgs() { }

        public HOTCODEMASTERSaveLayoutArgs(String userId, String hospCode, String truncateYn, List<HOTCODEMASTERGetGrdListInfo> layoutItem)
        {
            this._userId = userId;
            this._hospCode = hospCode;
            this._truncateYn = truncateYn;
            this._layoutItem = layoutItem;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.HOTCODEMASTERSaveLayoutRequest();
        }
    }
}