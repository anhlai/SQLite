using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class IFS0003U00GridFindClickArgs : IContractArgs
    {
        private String _codeType;
        private String _find1;
        private String _mapGubun;
        private String _colName;

        public String CodeType
        {
            get { return this._codeType; }
            set { this._codeType = value; }
        }

        public String Find1
        {
            get { return this._find1; }
            set { this._find1 = value; }
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

        public IFS0003U00GridFindClickArgs() { }

        public IFS0003U00GridFindClickArgs(String codeType, String find1, String mapGubun, String colName)
        {
            this._codeType = codeType;
            this._find1 = find1;
            this._mapGubun = mapGubun;
            this._colName = colName;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.IFS0003U00GridFindClickRequest();
        }
    }
}