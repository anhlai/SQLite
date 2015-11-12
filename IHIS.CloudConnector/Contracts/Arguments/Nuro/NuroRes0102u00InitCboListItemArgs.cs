using System;
using IHIS.CloudConnector.Contracts.Models.Nuro;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroRes0102u00InitCboListItemArgs : IContractArgs
    {
        private String _comingDate;
        private String _codeType;
        private String _hospCode;

        public String ComingDate
        {
            get { return this._comingDate; }
            set { this._comingDate = value; }
        }

        public String CodeType
        {
            get { return this._codeType; }
            set { this._codeType = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public NuroRes0102u00InitCboListItemArgs() { }

        public NuroRes0102u00InitCboListItemArgs(String comingDate, String codeType, String hospCode)
        {
            this._comingDate = comingDate;
            this._codeType = codeType;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.NuroRes0102u00InitCboListItemRequest();
        }
    }
}