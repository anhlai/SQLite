using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class IFS0001U00SaveLayoutArgs : IContractArgs
    {
        private String _userId;
        private List<IFS0001U00GrdMasterInfo> _grdMstItem = new List<IFS0001U00GrdMasterInfo>();
        private List<IFS0001U00GrdDetailInfo> _grdDetailItem = new List<IFS0001U00GrdDetailInfo>();

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public List<IFS0001U00GrdMasterInfo> GrdMstItem
        {
            get { return this._grdMstItem; }
            set { this._grdMstItem = value; }
        }

        public List<IFS0001U00GrdDetailInfo> GrdDetailItem
        {
            get { return this._grdDetailItem; }
            set { this._grdDetailItem = value; }
        }

        public IFS0001U00SaveLayoutArgs() { }

        public IFS0001U00SaveLayoutArgs(String userId, List<IFS0001U00GrdMasterInfo> grdMstItem, List<IFS0001U00GrdDetailInfo> grdDetailItem)
        {
            this._userId = userId;
            this._grdMstItem = grdMstItem;
            this._grdDetailItem = grdDetailItem;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.IFS0001U00SaveLayoutRequest();
        }
    }
}