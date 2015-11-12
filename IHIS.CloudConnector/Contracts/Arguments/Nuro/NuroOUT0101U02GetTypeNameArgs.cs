using System;
using IHIS.CloudConnector.Contracts.Models.Nuro;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroOUT0101U02GetTypeNameArgs : IContractArgs
    {
        private String _typeCode;

        public String TypeCode
        {
            get { return this._typeCode; }
            set { this._typeCode = value; }
        }

        public NuroOUT0101U02GetTypeNameArgs() { }

        public NuroOUT0101U02GetTypeNameArgs(String typeCode)
        {
            this._typeCode = typeCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.NuroOUT0101U02GetTypeNameRequest();
        }
    }
}