using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class IFS0003U00GrdIFS0003Args : IContractArgs
    {
        private String _mapGubun;
        private String _mapGubunYmd;
        private String _code;

        public String MapGubun
        {
            get { return this._mapGubun; }
            set { this._mapGubun = value; }
        }

        public String MapGubunYmd
        {
            get { return this._mapGubunYmd; }
            set { this._mapGubunYmd = value; }
        }

        public String Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        public IFS0003U00GrdIFS0003Args() { }

        public IFS0003U00GrdIFS0003Args(String mapGubun, String mapGubunYmd, String code)
        {
            this._mapGubun = mapGubun;
            this._mapGubunYmd = mapGubunYmd;
            this._code = code;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.IFS0003U00GrdIFS0003Request();
        }
    }
}