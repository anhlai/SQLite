using System;
using IHIS.CloudConnector.Contracts.Models.Phys;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Phys
{
    public class PHY8002U01GetLayJissekiDataArgs : IContractArgs
    {
        private String _fkocs;
        private String _inOutGubun;

        public String Fkocs
        {
            get { return this._fkocs; }
            set { this._fkocs = value; }
        }

        public String InOutGubun
        {
            get { return this._inOutGubun; }
            set { this._inOutGubun = value; }
        }

        public PHY8002U01GetLayJissekiDataArgs() { }

        public PHY8002U01GetLayJissekiDataArgs(String fkocs, String inOutGubun)
        {
            this._fkocs = fkocs;
            this._inOutGubun = inOutGubun;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.PHY8002U01GetLayJissekiDataRequest();
        }
    }
}