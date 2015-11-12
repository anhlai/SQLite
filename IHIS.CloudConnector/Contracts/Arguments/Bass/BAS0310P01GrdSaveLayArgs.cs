using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0310P01GrdSaveLayArgs : IContractArgs
    {
        private String _tableName;
        private String _currentType;
        private String _userId;
        private List<BAS0310P01GrdJinryoMasterInfo> _dt = new List<BAS0310P01GrdJinryoMasterInfo>();

        public String TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        public String CurrentType
        {
            get { return this._currentType; }
            set { this._currentType = value; }
        }

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public List<BAS0310P01GrdJinryoMasterInfo> Dt
        {
            get { return this._dt; }
            set { this._dt = value; }
        }

        public BAS0310P01GrdSaveLayArgs() { }

        public BAS0310P01GrdSaveLayArgs(String tableName, String currentType, String userId, List<BAS0310P01GrdJinryoMasterInfo> dt)
        {
            this._tableName = tableName;
            this._currentType = currentType;
            this._userId = userId;
            this._dt = dt;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0310P01GrdSaveLayRequest();
        }
    }
}