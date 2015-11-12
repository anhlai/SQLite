using System;
using IHIS.CloudConnector.Contracts.Models.Xrts;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
    public class XRT0001U00FbxDataValidatingArgs : IContractArgs
    {
        private String _fbName;
        private String _code;

        public String FbName
        {
            get { return this._fbName; }
            set { this._fbName = value; }
        }

        public String Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        public XRT0001U00FbxDataValidatingArgs() { }

        public XRT0001U00FbxDataValidatingArgs(String fbName, String code)
        {
            this._fbName = fbName;
            this._code = code;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.XRT0001U00FbxDataValidatingRequest();
        }
    }
}