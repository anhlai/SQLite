using System;
using IHIS.CloudConnector.Contracts.Models.Xrts;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
    public class XRT9001R01Lay9001RArgs : IContractArgs
    {
        private String _date;

        public String Date
        {
            get { return this._date; }
            set { this._date = value; }
        }

        public XRT9001R01Lay9001RArgs() { }

        public XRT9001R01Lay9001RArgs(String date)
        {
            this._date = date;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.XRT9001R01Lay9001RRequest();
        }
    }
}