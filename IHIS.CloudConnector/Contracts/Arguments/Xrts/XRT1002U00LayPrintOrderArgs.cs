using System;
using IHIS.CloudConnector.Contracts.Models.Xrts;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
    public class XRT1002U00LayPrintOrderArgs : IContractArgs
    {
        private String _orderDate;
        private String _gwa;
        private String _inOutGubun;
        private String _pkocs;

        public String OrderDate
        {
            get { return this._orderDate; }
            set { this._orderDate = value; }
        }

        public String Gwa
        {
            get { return this._gwa; }
            set { this._gwa = value; }
        }

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

        public XRT1002U00LayPrintOrderArgs() { }

        public XRT1002U00LayPrintOrderArgs(String orderDate, String gwa, String inOutGubun, String pkocs)
        {
            this._orderDate = orderDate;
            this._gwa = gwa;
            this._inOutGubun = inOutGubun;
            this._pkocs = pkocs;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.XRT1002U00LayPrintOrderRequest();
        }
    }
}