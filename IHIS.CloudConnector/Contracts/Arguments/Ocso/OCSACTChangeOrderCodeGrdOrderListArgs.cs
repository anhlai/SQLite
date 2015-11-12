using System;
using IHIS.CloudConnector.Contracts.Models.Ocso;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
    public class OCSACTChangeOrderCodeGrdOrderListArgs : IContractArgs
    {
        private String _codeType;

        public String CodeType
        {
            get { return this._codeType; }
            set { this._codeType = value; }
        }

        public OCSACTChangeOrderCodeGrdOrderListArgs() { }

        public OCSACTChangeOrderCodeGrdOrderListArgs(String codeType)
        {
            this._codeType = codeType;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCSACTChangeOrderCodeGrdOrderListRequest();
        }
    }
}