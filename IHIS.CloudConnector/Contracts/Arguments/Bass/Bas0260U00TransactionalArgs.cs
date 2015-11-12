using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class Bas0260U00TransactionalArgs : IContractArgs
    {
        private List<BAS0260GrdBuseoListItemInfo> _grdBuseoList = new List<BAS0260GrdBuseoListItemInfo>();
        private String _userId;
        private String _hospCode;

        public List<BAS0260GrdBuseoListItemInfo> GrdBuseoList
        {
            get { return this._grdBuseoList; }
            set { this._grdBuseoList = value; }
        }

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

        public Bas0260U00TransactionalArgs() { }

        public Bas0260U00TransactionalArgs(List<BAS0260GrdBuseoListItemInfo> grdBuseoList, String userId, String hospCode)
        {
            this._grdBuseoList = grdBuseoList;
            this._userId = userId;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.Bas0260U00TransactionalRequest();
        }
    }
}