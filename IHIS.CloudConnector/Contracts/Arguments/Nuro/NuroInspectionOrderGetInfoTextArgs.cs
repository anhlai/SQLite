using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroInspectionOrderGetInfoTextArgs : IContractArgs
    {
        private String _codeType;

        public String CodeType
        {
            get { return this._codeType; }
            set { this._codeType = value; }
        }

        public NuroInspectionOrderGetInfoTextArgs() { }

        public NuroInspectionOrderGetInfoTextArgs(String codeType)
        {
            this._codeType = codeType;
        }

        public IExtensible GetRequestInstance()
        {
            return new NuroInspectionOrderGetInfoTextRequest();
        }
    }
}
