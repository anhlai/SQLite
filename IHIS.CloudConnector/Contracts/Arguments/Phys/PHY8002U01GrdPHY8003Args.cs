using System;
using IHIS.CloudConnector.Contracts.Models.Phys;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Phys
{
    public class PHY8002U01GrdPHY8003Args : IContractArgs
    {
        private String _kanjaNo;
        private String _fkOcsIrai;

        public String KanjaNo
        {
            get { return this._kanjaNo; }
            set { this._kanjaNo = value; }
        }

        public String FkOcsIrai
        {
            get { return this._fkOcsIrai; }
            set { this._fkOcsIrai = value; }
        }

        public PHY8002U01GrdPHY8003Args() { }

        public PHY8002U01GrdPHY8003Args(String kanjaNo, String fkOcsIrai)
        {
            this._kanjaNo = kanjaNo;
            this._fkOcsIrai = fkOcsIrai;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.PHY8002U01GrdPHY8003Request();
        }
    }
}