using System;
using IHIS.CloudConnector.Contracts.Models.Ocso;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
    public class OCSACTGrdJearyoArgs : IContractArgs
    {
        private String _bunho;
        private String _orderDate;
        private String _ioGubun;
        private String _jundalPart;
        private String _fkocs;

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public String OrderDate
        {
            get { return this._orderDate; }
            set { this._orderDate = value; }
        }

        public String IoGubun
        {
            get { return this._ioGubun; }
            set { this._ioGubun = value; }
        }

        public String JundalPart
        {
            get { return this._jundalPart; }
            set { this._jundalPart = value; }
        }

        public String Fkocs
        {
            get { return this._fkocs; }
            set { this._fkocs = value; }
        }

        public OCSACTGrdJearyoArgs() { }

        public OCSACTGrdJearyoArgs(String bunho, String orderDate, String ioGubun, String jundalPart, String fkocs)
        {
            this._bunho = bunho;
            this._orderDate = orderDate;
            this._ioGubun = ioGubun;
            this._jundalPart = jundalPart;
            this._fkocs = fkocs;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCSACTGrdJearyoRequest();
        }
    }
}