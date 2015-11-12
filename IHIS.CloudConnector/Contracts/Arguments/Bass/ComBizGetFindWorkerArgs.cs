using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class ComBizGetFindWorkerArgs : IContractArgs
    {
        private String _colName;
        private String _argu1;
        private String _find1;

        public String ColName
        {
            get { return this._colName; }
            set { this._colName = value; }
        }

        public String Argu1
        {
            get { return this._argu1; }
            set { this._argu1 = value; }
        }

        public String Find1
        {
            get { return this._find1; }
            set { this._find1 = value; }
        }

        public ComBizGetFindWorkerArgs() { }

        public ComBizGetFindWorkerArgs(String colName, String argu1, String find1)
        {
            this._colName = colName;
            this._argu1 = argu1;
            this._find1 = find1;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.ComBizGetFindWorkerRequest();
        }
    }
}