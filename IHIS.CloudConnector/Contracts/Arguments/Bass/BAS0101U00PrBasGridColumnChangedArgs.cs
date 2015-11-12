using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0101U00PrBasGridColumnChangedArgs : IContractArgs
    {
        private String _masterCheck;
        private String _codeType;
        private String _colId;
        private String _error;

        public String MasterCheck
        {
            get { return this._masterCheck; }
            set { this._masterCheck = value; }
        }

        public String CodeType
        {
            get { return this._codeType; }
            set { this._codeType = value; }
        }

        public String ColId
        {
            get { return this._colId; }
            set { this._colId = value; }
        }

        public String Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        public BAS0101U00PrBasGridColumnChangedArgs() { }

        public BAS0101U00PrBasGridColumnChangedArgs(String masterCheck, String codeType, String colId, String error)
        {
            this._masterCheck = masterCheck;
            this._codeType = codeType;
            this._colId = colId;
            this._error = error;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0101U00PrBasGridColumnChangedRequest();
        }
    }
}