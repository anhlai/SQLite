using System;
using IHIS.CloudConnector.Contracts.Models.Ocso;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
    public class OCSACTProcEkgInterfaceArgs : IContractArgs
    {
        private String _orderDate;
        private String _bunho;
        private String _fkout1001;
        private String _pkocs;
        private String _userId;
        private String _ioGubun;
        private String _sendYn;

        public String OrderDate
        {
            get { return this._orderDate; }
            set { this._orderDate = value; }
        }

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public String Fkout1001
        {
            get { return this._fkout1001; }
            set { this._fkout1001 = value; }
        }

        public String Pkocs
        {
            get { return this._pkocs; }
            set { this._pkocs = value; }
        }

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public String IoGubun
        {
            get { return this._ioGubun; }
            set { this._ioGubun = value; }
        }

        public String SendYn
        {
            get { return this._sendYn; }
            set { this._sendYn = value; }
        }

        public OCSACTProcEkgInterfaceArgs() { }

        public OCSACTProcEkgInterfaceArgs(String orderDate, String bunho, String fkout1001, String pkocs, String userId, String ioGubun, String sendYn)
        {
            this._orderDate = orderDate;
            this._bunho = bunho;
            this._fkout1001 = fkout1001;
            this._pkocs = pkocs;
            this._userId = userId;
            this._ioGubun = ioGubun;
            this._sendYn = sendYn;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCSACTProcEkgInterfaceRequest();
        }
    }
}