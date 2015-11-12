using System;
using IHIS.CloudConnector.Contracts.Models.Xrts;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
    public class XRT1002U00LayPrintDateArgs : IContractArgs
    {
        private String _orderDate;
        private String _inOutGubun;
        private String _fkout1001;
        private String _printOnly;
        private String _jundalPart;
        private String _pkocs;
        private String _fkinp1001;

        public String OrderDate
        {
            get { return this._orderDate; }
            set { this._orderDate = value; }
        }

        public String InOutGubun
        {
            get { return this._inOutGubun; }
            set { this._inOutGubun = value; }
        }

        public String Fkout1001
        {
            get { return this._fkout1001; }
            set { this._fkout1001 = value; }
        }

        public String PrintOnly
        {
            get { return this._printOnly; }
            set { this._printOnly = value; }
        }

        public String JundalPart
        {
            get { return this._jundalPart; }
            set { this._jundalPart = value; }
        }

        public String Pkocs
        {
            get { return this._pkocs; }
            set { this._pkocs = value; }
        }

        public String Fkinp1001
        {
            get { return this._fkinp1001; }
            set { this._fkinp1001 = value; }
        }

        public XRT1002U00LayPrintDateArgs() { }

        public XRT1002U00LayPrintDateArgs(String orderDate, String inOutGubun, String fkout1001, String printOnly, String jundalPart, String pkocs, String fkinp1001)
        {
            this._orderDate = orderDate;
            this._inOutGubun = inOutGubun;
            this._fkout1001 = fkout1001;
            this._printOnly = printOnly;
            this._jundalPart = jundalPart;
            this._pkocs = pkocs;
            this._fkinp1001 = fkinp1001;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.XRT1002U00LayPrintDateRequest();
        }
    }
}