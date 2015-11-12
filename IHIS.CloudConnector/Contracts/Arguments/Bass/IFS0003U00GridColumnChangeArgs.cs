using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class IFS0003U00GridColumnChangeArgs : IContractArgs
    {
        private String _code;
        private String _mapGubun;
        private String _colName;

        public String Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        public String MapGubun
        {
            get { return this._mapGubun; }
            set { this._mapGubun = value; }
        }

        public String ColName
        {
            get { return this._colName; }
            set { this._colName = value; }
        }

        public IFS0003U00GridColumnChangeArgs() { }

        public IFS0003U00GridColumnChangeArgs(String code, String mapGubun, String colName)
        {
            this._code = code;
            this._mapGubun = mapGubun;
            this._colName = colName;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.IFS0003U00GridColumnChangeRequest();
        }
    }
}