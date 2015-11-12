using System;
using IHIS.CloudConnector.Contracts.Models.Phys;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Phys
{
    public class PHY2001U04SetSinryouryouAutoArgs : IContractArgs
    {
        private String _code1;
        private String _code2;
        private String _codeType;

        public String Code1
        {
            get { return this._code1; }
            set { this._code1 = value; }
        }

        public String Code2
        {
            get { return this._code2; }
            set { this._code2 = value; }
        }

        public String CodeType
        {
            get { return this._codeType; }
            set { this._codeType = value; }
        }

        public PHY2001U04SetSinryouryouAutoArgs() { }

        public PHY2001U04SetSinryouryouAutoArgs(String code1, String code2, String codeType)
        {
            this._code1 = code1;
            this._code2 = code2;
            this._codeType = codeType;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.PHY2001U04SetSinryouryouAutoRequest();
        }
    }
}