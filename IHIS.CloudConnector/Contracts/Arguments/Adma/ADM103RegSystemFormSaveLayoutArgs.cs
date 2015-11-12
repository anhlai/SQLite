using System;
using IHIS.CloudConnector.Contracts.Models.Adma;
using System.Collections.Generic;
using ProtoBuf;
using IHIS.CloudConnector.Contracts.Models.System;

namespace IHIS.CloudConnector.Contracts.Arguments.Adma
{
    public class ADM103RegSystemFormSaveLayoutArgs : IContractArgs
    {
        private String _userId;
        private List<DataStringListItemInfo> _sysId = new List<DataStringListItemInfo>();
        private String _hospCode;

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public List<DataStringListItemInfo> SysId
        {
            get { return this._sysId; }
            set { this._sysId = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public ADM103RegSystemFormSaveLayoutArgs() { }

        public ADM103RegSystemFormSaveLayoutArgs(String userId, List<DataStringListItemInfo> sysId, String hospCode)
        {
            this._userId = userId;
            this._sysId = sysId;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.ADM103RegSystemFormSaveLayoutRequest();
        }
    }
}