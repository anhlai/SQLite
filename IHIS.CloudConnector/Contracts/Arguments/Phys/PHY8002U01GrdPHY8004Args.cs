using System;
using IHIS.CloudConnector.Contracts.Models.Phys;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Phys
{
    public class PHY8002U01GrdPHY8004Args : IContractArgs
    {
        private String _fkOcsIrai;

        public String FkOcsIrai
        {
            get { return this._fkOcsIrai; }
            set { this._fkOcsIrai = value; }
        }

        public PHY8002U01GrdPHY8004Args() { }

        public PHY8002U01GrdPHY8004Args(String fkOcsIrai)
        {
            this._fkOcsIrai = fkOcsIrai;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.PHY8002U01GrdPHY8004Request();
        }
    }
}