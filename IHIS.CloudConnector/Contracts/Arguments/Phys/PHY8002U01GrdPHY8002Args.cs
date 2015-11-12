using System;
using IHIS.CloudConnector.Contracts.Models.Phys;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Phys
{
    public class PHY8002U01GrdPHY8002Args : IContractArgs
    {
        private String _fkOcs;

        public String FkOcs
        {
            get { return this._fkOcs; }
            set { this._fkOcs = value; }
        }

        public PHY8002U01GrdPHY8002Args() { }

        public PHY8002U01GrdPHY8002Args(String fkOcs)
        {
            this._fkOcs = fkOcs;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.PHY8002U01GrdPHY8002Request();
        }
    }
}