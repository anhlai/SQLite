using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0311Q00CboSetPartArgs : IContractArgs
    {
        private String _setTable;

        public String SetTable
        {
            get { return this._setTable; }
            set { this._setTable = value; }
        }

        public OCS0311Q00CboSetPartArgs() { }

        public OCS0311Q00CboSetPartArgs(String setTable)
        {
            this._setTable = setTable;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0311Q00CboSetPartRequest();
        }
    }
}