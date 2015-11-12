using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class ComBizLoadColumnCodeNameArgs : IContractArgs
    {
        private String _colName;
        private String _argu1;
        private String _argu2;

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

        public String Argu2
        {
            get { return this._argu2; }
            set { this._argu2 = value; }
        }

        public ComBizLoadColumnCodeNameArgs() { }

        public ComBizLoadColumnCodeNameArgs(String colName, String argu1, String argu2)
        {
            this._colName = colName;
            this._argu1 = argu1;
            this._argu2 = argu2;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.ComBizLoadColumnCodeNameRequest();
        }
    }
}