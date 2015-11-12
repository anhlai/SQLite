using System;
using IHIS.CloudConnector.Contracts.Models.System;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
    public class XMstGridDeleteRowArgs : IContractArgs
    {
        private String _tableName;
        private String _whereCmd;

        public String TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        public String WhereCmd
        {
            get { return this._whereCmd; }
            set { this._whereCmd = value; }
        }

        public XMstGridDeleteRowArgs() { }

        public XMstGridDeleteRowArgs(String tableName, String whereCmd)
        {
            this._tableName = tableName;
            this._whereCmd = whereCmd;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.XMstGridDeleteRowRequest();
        }
    }
}