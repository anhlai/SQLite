using System;

namespace IHIS.CloudConnector.Contracts.Models.Injs
{
    public class INJ1001U01SaveLayoutInfo
    {
        private String _pkinj1002;
        private String _actingDate;
        private String _hangmogName;
        private String _actingFlag;
        private String _tonggyeCode;
        private String _mixGroup;
        private String _jujongja;
        private String _silsiRemark;
        private String _rowState;

        public String Pkinj1002
        {
            get { return this._pkinj1002; }
            set { this._pkinj1002 = value; }
        }

        public String ActingDate
        {
            get { return this._actingDate; }
            set { this._actingDate = value; }
        }

        public String HangmogName
        {
            get { return this._hangmogName; }
            set { this._hangmogName = value; }
        }

        public String ActingFlag
        {
            get { return this._actingFlag; }
            set { this._actingFlag = value; }
        }

        public String TonggyeCode
        {
            get { return this._tonggyeCode; }
            set { this._tonggyeCode = value; }
        }

        public String MixGroup
        {
            get { return this._mixGroup; }
            set { this._mixGroup = value; }
        }

        public String Jujongja
        {
            get { return this._jujongja; }
            set { this._jujongja = value; }
        }

        public String SilsiRemark
        {
            get { return this._silsiRemark; }
            set { this._silsiRemark = value; }
        }

        public String RowState
        {
            get { return this._rowState; }
            set { this._rowState = value; }
        }

        public INJ1001U01SaveLayoutInfo() { }

        public INJ1001U01SaveLayoutInfo(String pkinj1002, String actingDate, String hangmogName, String actingFlag, String tonggyeCode, String mixGroup, String jujongja, String silsiRemark, String rowState)
        {
            this._pkinj1002 = pkinj1002;
            this._actingDate = actingDate;
            this._hangmogName = hangmogName;
            this._actingFlag = actingFlag;
            this._tonggyeCode = tonggyeCode;
            this._mixGroup = mixGroup;
            this._jujongja = jujongja;
            this._silsiRemark = silsiRemark;
            this._rowState = rowState;
        }

    }
}