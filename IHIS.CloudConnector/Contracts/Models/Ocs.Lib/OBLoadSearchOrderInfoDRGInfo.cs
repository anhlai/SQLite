using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
    public class OBLoadSearchOrderInfoDRGInfo
    {
        private String _slipCode;
        private String _slipName;
        private String _hangmogCode;
        private String _hangmogName;
        private String _wonnaeDrgYn;
        private String _genericName;
        private String _emptyStr;
        private String _genericCodeOrgSubstr;
        private String _genericCodeOrg;
        private String _yakKijunCode;
        private String _trialFlg;

        public String SlipCode
        {
            get { return this._slipCode; }
            set { this._slipCode = value; }
        }

        public String SlipName
        {
            get { return this._slipName; }
            set { this._slipName = value; }
        }

        public String HangmogCode
        {
            get { return this._hangmogCode; }
            set { this._hangmogCode = value; }
        }

        public String HangmogName
        {
            get { return this._hangmogName; }
            set { this._hangmogName = value; }
        }

        public String WonnaeDrgYn
        {
            get { return this._wonnaeDrgYn; }
            set { this._wonnaeDrgYn = value; }
        }

        public String GenericName
        {
            get { return this._genericName; }
            set { this._genericName = value; }
        }

        public String EmptyStr
        {
            get { return this._emptyStr; }
            set { this._emptyStr = value; }
        }

        public String GenericCodeOrgSubstr
        {
            get { return this._genericCodeOrgSubstr; }
            set { this._genericCodeOrgSubstr = value; }
        }

        public String GenericCodeOrg
        {
            get { return this._genericCodeOrg; }
            set { this._genericCodeOrg = value; }
        }

        public String YakKijunCode
        {
            get { return this._yakKijunCode; }
            set { this._yakKijunCode = value; }
        }

        public String TrialFlg
        {
            get { return this._trialFlg; }
            set { this._trialFlg = value; }
        }

        public OBLoadSearchOrderInfoDRGInfo() { }

        public OBLoadSearchOrderInfoDRGInfo(String slipCode, String slipName, String hangmogCode, String hangmogName, String wonnaeDrgYn, String genericName, String emptyStr, String genericCodeOrgSubstr, String genericCodeOrg, String yakKijunCode, String trialFlg)
        {
            this._slipCode = slipCode;
            this._slipName = slipName;
            this._hangmogCode = hangmogCode;
            this._hangmogName = hangmogName;
            this._wonnaeDrgYn = wonnaeDrgYn;
            this._genericName = genericName;
            this._emptyStr = emptyStr;
            this._genericCodeOrgSubstr = genericCodeOrgSubstr;
            this._genericCodeOrg = genericCodeOrg;
            this._yakKijunCode = yakKijunCode;
            this._trialFlg = trialFlg;
        }

    }
}