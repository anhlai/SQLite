using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
    public class LoadSearchOrderInfo
    {
        private String _slipCode;
        private String _slipName;
        private String _hangmogCode;
        private String _hangmogName;
        private String _wonnaeDrgYn;
        private String _yakKijunCode;
        private String _trialFlag;

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

        public String YakKijunCode
        {
            get { return this._yakKijunCode; }
            set { this._yakKijunCode = value; }
        }

        public String TrialFlag
        {
            get { return this._trialFlag; }
            set { this._trialFlag = value; }
        }

        public LoadSearchOrderInfo() { }

        public LoadSearchOrderInfo(String slipCode, String slipName, String hangmogCode, String hangmogName, String wonnaeDrgYn, String yakKijunCode, String trialFlag)
        {
            this._slipCode = slipCode;
            this._slipName = slipName;
            this._hangmogCode = hangmogCode;
            this._hangmogName = hangmogName;
            this._wonnaeDrgYn = wonnaeDrgYn;
            this._yakKijunCode = yakKijunCode;
            this._trialFlag = trialFlag;
        }

    }
}