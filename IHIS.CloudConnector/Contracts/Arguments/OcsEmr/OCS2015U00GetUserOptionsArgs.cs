using System;
using IHIS.CloudConnector.Contracts.Models.OcsEmr;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.OcsEmr
{
    public class OCS2015U00GetUserOptionsArgs : IContractArgs
    {
        private String _userId;
        private String _gwa;
        private String _ioGubun;

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public String Gwa
        {
            get { return this._gwa; }
            set { this._gwa = value; }
        }

        public String IoGubun
        {
            get { return this._ioGubun; }
            set { this._ioGubun = value; }
        }

        public OCS2015U00GetUserOptionsArgs() { }

        public OCS2015U00GetUserOptionsArgs(String userId, String gwa, String ioGubun)
        {
            this._userId = userId;
            this._gwa = gwa;
            this._ioGubun = ioGubun;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS2015U00GetUserOptionsRequest();
        }
    }
}