using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0311U00CboPartBySetTableArgs : IContractArgs
    {
        private String _currGroupId;

        public String CurrGroupId
        {
            get { return this._currGroupId; }
            set { this._currGroupId = value; }
        }

        public OCS0311U00CboPartBySetTableArgs() { }

        public OCS0311U00CboPartBySetTableArgs(String currGroupId)
        {
            this._currGroupId = currGroupId;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0311U00CboPartBySetTableRequest();
        }
    }
}