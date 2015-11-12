using System;
using IHIS.CloudConnector.Contracts.Models.Chts;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Chts
{
    public class CHT0110U00grdCHT0110Args : IContractArgs
    {
        private String _sangInx;

        public String SangInx
        {
            get { return this._sangInx; }
            set { this._sangInx = value; }
        }

        public CHT0110U00grdCHT0110Args() { }

        public CHT0110U00grdCHT0110Args(String sangInx)
        {
            this._sangInx = sangInx;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CHT0110U00grdCHT0110Request();
        }
    }
}