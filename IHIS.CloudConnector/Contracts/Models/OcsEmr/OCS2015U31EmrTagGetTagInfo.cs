using System;

namespace IHIS.CloudConnector.Contracts.Models.OcsEmr
{
    public class OCS2015U31EmrTagGetTagInfo
    {
        private String _tagId;
        private String _tagCode;
        private String _tagName;
        private String _tagDisplayText;
        private String _description;
        private String _filterFlg;
        private String _tagParent;

        public String TagId
        {
            get { return this._tagId; }
            set { this._tagId = value; }
        }

        public String TagCode
        {
            get { return this._tagCode; }
            set { this._tagCode = value; }
        }

        public String TagName
        {
            get { return this._tagName; }
            set { this._tagName = value; }
        }

        public String TagDisplayText
        {
            get { return this._tagDisplayText; }
            set { this._tagDisplayText = value; }
        }

        public String Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        public String FilterFlg
        {
            get { return this._filterFlg; }
            set { this._filterFlg = value; }
        }

        public String TagParent
        {
            get { return this._tagParent; }
            set { this._tagParent = value; }
        }

        public OCS2015U31EmrTagGetTagInfo() { }

        public OCS2015U31EmrTagGetTagInfo(String tagId, String tagCode, String tagName, String tagDisplayText, String description, String filterFlg, String tagParent)
        {
            this._tagId = tagId;
            this._tagCode = tagCode;
            this._tagName = tagName;
            this._tagDisplayText = tagDisplayText;
            this._description = description;
            this._filterFlg = filterFlg;
            this._tagParent = tagParent;
        }

    }
}