using System;
using IHIS.CloudConnector.Contracts.Models.OcsEmr;
using System.Collections.Generic;

namespace IHIS.CloudConnector.Contracts.Results.OcsEmr
{
    public class OCS2015U00GetUserOptionsResult : AbstractContractResult
    {
        private String _allergyPopYn;
        private String _specialwritePopYn;
        private String _sameNameCheckYn;
        private String _vitalsignsPopYn;
        private String _emrPopYn;
        private String _orderLabelPrtYn;

        public String AllergyPopYn
        {
            get { return this._allergyPopYn; }
            set { this._allergyPopYn = value; }
        }

        public String SpecialwritePopYn
        {
            get { return this._specialwritePopYn; }
            set { this._specialwritePopYn = value; }
        }

        public String SameNameCheckYn
        {
            get { return this._sameNameCheckYn; }
            set { this._sameNameCheckYn = value; }
        }

        public String VitalsignsPopYn
        {
            get { return this._vitalsignsPopYn; }
            set { this._vitalsignsPopYn = value; }
        }

        public String EmrPopYn
        {
            get { return this._emrPopYn; }
            set { this._emrPopYn = value; }
        }

        public String OrderLabelPrtYn
        {
            get { return this._orderLabelPrtYn; }
            set { this._orderLabelPrtYn = value; }
        }

        public OCS2015U00GetUserOptionsResult() { }

    }
}