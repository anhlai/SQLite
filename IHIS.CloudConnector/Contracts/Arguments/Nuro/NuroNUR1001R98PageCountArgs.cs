using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroNUR1001R98PageCountArgs : IContractArgs
    {
        private String _codeType;
        private String _code;

        public String CodeType
        {
            get { return this._codeType; }
            set { this._codeType = value; }
        }

        public String Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        public NuroNUR1001R98PageCountArgs() { }

        public NuroNUR1001R98PageCountArgs(String codeType, String code)
        {
            this._codeType = codeType;
            this._code = code;
        }

        public IExtensible GetRequestInstance()
        {
            return new NuroNUR1001R98PageCountRequest();
        }
    }
}