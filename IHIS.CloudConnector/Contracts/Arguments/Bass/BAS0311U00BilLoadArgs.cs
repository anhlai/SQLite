using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0311U00BilLoadArgs : IContractArgs
    {
        private String _fGubunSuga;
        private String _fBunCode;
        private String _fSgCode;
        private String _fOrderDate;

        public String FGubunSuga
        {
            get { return this._fGubunSuga; }
            set { this._fGubunSuga = value; }
        }

        public String FBunCode
        {
            get { return this._fBunCode; }
            set { this._fBunCode = value; }
        }

        public String FSgCode
        {
            get { return this._fSgCode; }
            set { this._fSgCode = value; }
        }

        public String FOrderDate
        {
            get { return this._fOrderDate; }
            set { this._fOrderDate = value; }
        }

        public BAS0311U00BilLoadArgs() { }

        public BAS0311U00BilLoadArgs(String fGubunSuga, String fBunCode, String fSgCode, String fOrderDate)
        {
            this._fGubunSuga = fGubunSuga;
            this._fBunCode = fBunCode;
            this._fSgCode = fSgCode;
            this._fOrderDate = fOrderDate;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0311U00BilLoadRequest();
        }
    }
}