using System;
using IHIS.CloudConnector.Contracts.Models.Chts;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Chts
{
    public class CHT0115Q01grdCHT0115Args : IContractArgs
    {
        private String _susikDetailGubun;

        public String SusikDetailGubun
        {
            get { return this._susikDetailGubun; }
            set { this._susikDetailGubun = value; }
        }

        public CHT0115Q01grdCHT0115Args() { }

        public CHT0115Q01grdCHT0115Args(String susikDetailGubun)
        {
            this._susikDetailGubun = susikDetailGubun;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CHT0115Q01grdCHT0115Request();
        }
    }
}