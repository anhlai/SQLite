using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL2010U00PaqryGrdPaArgs : IContractArgs
    {
        private String _suname;
        private String _orderDate;
        private String _jubsuYn;
        private String _bunho;
        private String _gwaName;
        private String _orderTime;
        private String _mJubsuYn;

        public String Suname
        {
            get { return this._suname; }
            set { this._suname = value; }
        }

        public String OrderDate
        {
            get { return this._orderDate; }
            set { this._orderDate = value; }
        }

        public String JubsuYn
        {
            get { return this._jubsuYn; }
            set { this._jubsuYn = value; }
        }

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public String GwaName
        {
            get { return this._gwaName; }
            set { this._gwaName = value; }
        }

        public String OrderTime
        {
            get { return this._orderTime; }
            set { this._orderTime = value; }
        }

        public String MJubsuYn
        {
            get { return this._mJubsuYn; }
            set { this._mJubsuYn = value; }
        }

        public CPL2010U00PaqryGrdPaArgs() { }

        public CPL2010U00PaqryGrdPaArgs(String suname, String orderDate, String jubsuYn, String bunho, String gwaName, String orderTime, String mJubsuYn)
        {
            this._suname = suname;
            this._orderDate = orderDate;
            this._jubsuYn = jubsuYn;
            this._bunho = bunho;
            this._gwaName = gwaName;
            this._orderTime = orderTime;
            this._mJubsuYn = mJubsuYn;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL2010U00PaqryGrdPaRequest();
        }
    }
}