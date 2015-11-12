using System;

namespace IHIS.CloudConnector.Contracts.Models.Bass
{
    public class IFS0001U00GrdMasterInfo
    {
        private String _codeType;
        private String _codeTypeName;
        private String _remark;
        private String _rowState;

        public String CodeType
        {
            get { return this._codeType; }
            set { this._codeType = value; }
        }

        public String CodeTypeName
        {
            get { return this._codeTypeName; }
            set { this._codeTypeName = value; }
        }

        public String Remark
        {
            get { return this._remark; }
            set { this._remark = value; }
        }

        public String RowState
        {
            get { return this._rowState; }
            set { this._rowState = value; }
        }

        public IFS0001U00GrdMasterInfo() { }

        public IFS0001U00GrdMasterInfo(String codeType, String codeTypeName, String remark, String rowState)
        {
            this._codeType = codeType;
            this._codeTypeName = codeTypeName;
            this._remark = remark;
            this._rowState = rowState;
        }

    }
}