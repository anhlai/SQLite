using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroInspectionOrderGetMaxCodeNameArgs : IContractArgs
    {
        private String _codeType;
        private String _reserPart;

        public String CodeType
        {
            get { return this._codeType; }
            set { this._codeType = value; }
        }

        public String ReserPart
        {
            get { return this._reserPart; }
            set { this._reserPart = value; }
        }

        public NuroInspectionOrderGetMaxCodeNameArgs() { }

        public NuroInspectionOrderGetMaxCodeNameArgs(String codeType, String reserPart)
        {
            this._codeType = codeType;
            this._reserPart = reserPart;
        }

        public IExtensible GetRequestInstance()
        {
            return new NuroInspectionOrderGetMaxCodeNameRequest();
        }
    }
}