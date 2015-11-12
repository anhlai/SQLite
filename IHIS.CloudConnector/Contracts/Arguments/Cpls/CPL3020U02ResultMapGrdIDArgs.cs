using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL3020U02ResultMapGrdIDArgs : IContractArgs
    {
        private String _jangbiCode;
        private String _specimenSer;
        private String _fromDate;
        private String _toDate;
        private String _allYn;

        public String JangbiCode
        {
            get { return this._jangbiCode; }
            set { this._jangbiCode = value; }
        }

        public String SpecimenSer
        {
            get { return this._specimenSer; }
            set { this._specimenSer = value; }
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

        public String AllYn
        {
            get { return this._allYn; }
            set { this._allYn = value; }
        }

        public CPL3020U02ResultMapGrdIDArgs() { }

        public CPL3020U02ResultMapGrdIDArgs(String jangbiCode, String specimenSer, String fromDate, String toDate, String allYn)
        {
            this._jangbiCode = jangbiCode;
            this._specimenSer = specimenSer;
            this._fromDate = fromDate;
            this._toDate = toDate;
            this._allYn = allYn;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL3020U02ResultMapGrdIDRequest();
        }
    }
}