using System;

namespace IHIS.CloudConnector.Contracts.Models.Pfes
{
    public class PFE0101U01GrdMCodeInfo
    {
        private String _codeType;
        private String _codeTypeName;
        private String _adminGubun;
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

        public String AdminGubun
        {
            get { return this._adminGubun; }
            set { this._adminGubun = value; }
        }

        public String RowState
        {
            get { return this._rowState; }
            set { this._rowState = value; }
        }

        public PFE0101U01GrdMCodeInfo() { }

        public PFE0101U01GrdMCodeInfo(String codeType, String codeTypeName, String adminGubun, String rowState)
        {
            this._codeType = codeType;
            this._codeTypeName = codeTypeName;
            this._adminGubun = adminGubun;
            this._rowState = rowState;
        }

    }
}