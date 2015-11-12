using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL2010U00GrdPaListArgs : IContractArgs
    {
        private Boolean _rbxJubsuChecked;
        private String _fromDate;
        private String _toDate;
        private String _bunho;

        public Boolean RbxJubsuChecked
        {
            get { return this._rbxJubsuChecked; }
            set { this._rbxJubsuChecked = value; }
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

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public CPL2010U00GrdPaListArgs() { }

        public CPL2010U00GrdPaListArgs(Boolean rbxJubsuChecked, String fromDate, String toDate, String bunho)
        {
            this._rbxJubsuChecked = rbxJubsuChecked;
            this._fromDate = fromDate;
            this._toDate = toDate;
            this._bunho = bunho;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL2010U00GrdPaListRequest();
        }
    }
}