using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0310P01ProcessArgs : IContractArgs
    {
        private String _updateProcName;
        private String _procGubun;
        private String _userId;

        public String UpdateProcName
        {
            get { return this._updateProcName; }
            set { this._updateProcName = value; }
        }

        public String ProcGubun
        {
            get { return this._procGubun; }
            set { this._procGubun = value; }
        }

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public BAS0310P01ProcessArgs() { }

        public BAS0310P01ProcessArgs(String updateProcName, String procGubun, String userId)
        {
            this._updateProcName = updateProcName;
            this._procGubun = procGubun;
            this._userId = userId;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0310P01ProcessRequest();
        }
    }
}