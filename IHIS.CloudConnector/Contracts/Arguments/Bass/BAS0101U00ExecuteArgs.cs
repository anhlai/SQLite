using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0101U00ExecuteArgs : IContractArgs
    {
        private String _userId;
        private List<BAS0101U00GrdMasterItemInfo> _masterInputList = new List<BAS0101U00GrdMasterItemInfo>();
        private List<BAS0101U00grdDetailItemInfo> _detailInputList = new List<BAS0101U00grdDetailItemInfo>();

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public List<BAS0101U00GrdMasterItemInfo> MasterInputList
        {
            get { return this._masterInputList; }
            set { this._masterInputList = value; }
        }

        public List<BAS0101U00grdDetailItemInfo> DetailInputList
        {
            get { return this._detailInputList; }
            set { this._detailInputList = value; }
        }

        public BAS0101U00ExecuteArgs() { }

        public BAS0101U00ExecuteArgs(String userId, List<BAS0101U00GrdMasterItemInfo> masterInputList, List<BAS0101U00grdDetailItemInfo> detailInputList)
        {
            this._userId = userId;
            this._masterInputList = masterInputList;
            this._detailInputList = detailInputList;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0101U00ExecuteRequest();
        }
    }
}