using System;
using IHIS.CloudConnector.Contracts.Models.Nuro;
using System.Collections.Generic;
using ProtoBuf;
using IHIS.CloudConnector.Contracts.Models.System;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NUR1001R98LayReserInfoQueryEndArgs : IContractArgs
    {
        private String _patientCode;
        private String _reserDate;
        private List<DataStringListItemInfo> _departmentCode = new List<DataStringListItemInfo>();
        private String _reserYn;
        private String _rowNum;
        private String _codeType;
        private List<DataStringListItemInfo> _reserPart = new List<DataStringListItemInfo>();
        private String _codeTypeGetInfoText;

        public String PatientCode
        {
            get { return this._patientCode; }
            set { this._patientCode = value; }
        }

        public String ReserDate
        {
            get { return this._reserDate; }
            set { this._reserDate = value; }
        }

        public List<DataStringListItemInfo> DepartmentCode
        {
            get { return this._departmentCode; }
            set { this._departmentCode = value; }
        }

        public String ReserYn
        {
            get { return this._reserYn; }
            set { this._reserYn = value; }
        }

        public String RowNum
        {
            get { return this._rowNum; }
            set { this._rowNum = value; }
        }

        public String CodeType
        {
            get { return this._codeType; }
            set { this._codeType = value; }
        }

        public List<DataStringListItemInfo> ReserPart
        {
            get { return this._reserPart; }
            set { this._reserPart = value; }
        }

        public String CodeTypeGetInfoText
        {
            get { return this._codeTypeGetInfoText; }
            set { this._codeTypeGetInfoText = value; }
        }

        public NUR1001R98LayReserInfoQueryEndArgs() { }

        public NUR1001R98LayReserInfoQueryEndArgs(String patientCode, String reserDate, List<DataStringListItemInfo> departmentCode, String reserYn, String rowNum, String codeType, List<DataStringListItemInfo> reserPart, String codeTypeGetInfoText)
        {
            this._patientCode = patientCode;
            this._reserDate = reserDate;
            this._departmentCode = departmentCode;
            this._reserYn = reserYn;
            this._rowNum = rowNum;
            this._codeType = codeType;
            this._reserPart = reserPart;
            this._codeTypeGetInfoText = codeTypeGetInfoText;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.NUR1001R98LayReserInfoQueryEndRequest();
        }
    }
}