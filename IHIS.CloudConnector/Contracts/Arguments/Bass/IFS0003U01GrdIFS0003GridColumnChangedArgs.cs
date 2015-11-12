using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class IFS0003U01GrdIFS0003GridColumnChangedArgs : IContractArgs
    {
        private String _colName;
        private String _mapGubun;
        private String _code;

        public String ColName
        {
            get { return this._colName; }
            set { this._colName = value; }
        }

        public String MapGubun
        {
            get { return this._mapGubun; }
            set { this._mapGubun = value; }
        }

        public String Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        public IFS0003U01GrdIFS0003GridColumnChangedArgs() { }

        public IFS0003U01GrdIFS0003GridColumnChangedArgs(String colName, String mapGubun, String code)
        {
            this._colName = colName;
            this._mapGubun = mapGubun;
            this._code = code;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.IFS0003U01GrdIFS0003GridColumnChangedRequest();
        }
    }
}