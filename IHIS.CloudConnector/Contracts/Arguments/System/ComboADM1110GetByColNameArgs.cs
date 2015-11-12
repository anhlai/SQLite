using System;
using IHIS.CloudConnector.Contracts.Models.System;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
    public class ComboADM1110GetByColNameArgs : IContractArgs
    {
        private String _colName;
        private Boolean _getAll;
        private String _hospCode;

        public String ColName
        {
            get { return this._colName; }
            set { this._colName = value; }
        }

        public Boolean GetAll
        {
            get { return this._getAll; }
            set { this._getAll = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public ComboADM1110GetByColNameArgs() { }

        public ComboADM1110GetByColNameArgs(String colName, Boolean getAll, String hospCode)
        {
            this._colName = colName;
            this._getAll = getAll;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.ComboADM1110GetByColNameRequest();
        }
    }
}