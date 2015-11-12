using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL2010R01LayReserDateArgs : IContractArgs
    {
        private String _hoDong;
        private String _fromDate;
        private String _toDate;

        public String HoDong
        {
            get { return this._hoDong; }
            set { this._hoDong = value; }
        }

        public String FromDate
        {
            get { return this._fromDate; }
            set { this._fromDate = value; }
        }

        public String ToDate
        {
            get { return this._toDate; }
            set { this._toDate = value; }
        }

        public CPL2010R01LayReserDateArgs() { }

        public CPL2010R01LayReserDateArgs(String hoDong, String fromDate, String toDate)
        {
            this._hoDong = hoDong;
            this._fromDate = fromDate;
            this._toDate = toDate;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL2010R01LayReserDateRequest();
        }
    }
}