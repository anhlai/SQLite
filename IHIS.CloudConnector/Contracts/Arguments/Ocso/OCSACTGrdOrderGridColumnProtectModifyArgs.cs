using System;
using IHIS.CloudConnector.Contracts.Models.Ocso;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
    public class OCSACTGrdOrderGridColumnProtectModifyArgs : IContractArgs
    {
        private String _inOutGubun;
        private String _pkocs;

        public String InOutGubun
        {
            get { return this._inOutGubun; }
            set { this._inOutGubun = value; }
        }

        public String Pkocs
        {
            get { return this._pkocs; }
            set { this._pkocs = value; }
        }

        public OCSACTGrdOrderGridColumnProtectModifyArgs() { }

        public OCSACTGrdOrderGridColumnProtectModifyArgs(String inOutGubun, String pkocs)
        {
            this._inOutGubun = inOutGubun;
            this._pkocs = pkocs;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCSACTGrdOrderGridColumnProtectModifyRequest();
        }
    }
}