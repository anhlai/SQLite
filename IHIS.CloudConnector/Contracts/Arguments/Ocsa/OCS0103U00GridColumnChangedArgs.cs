using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0103U00GridColumnChangedArgs : IContractArgs
    {
        private String _gridName;
        private String _colName;
        private String _changeValue;
        private String _hospCode;

        public String GridName
        {
            get { return this._gridName; }
            set { this._gridName = value; }
        }

        public String ColName
        {
            get { return this._colName; }
            set { this._colName = value; }
        }

        public String ChangeValue
        {
            get { return this._changeValue; }
            set { this._changeValue = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public OCS0103U00GridColumnChangedArgs() { }

        public OCS0103U00GridColumnChangedArgs(String gridName, String colName, String changeValue, String hospCode)
        {
            this._gridName = gridName;
            this._colName = colName;
            this._changeValue = changeValue;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0103U00GridColumnChangedRequest();
        }
    }
}