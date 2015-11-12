using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroInspectionOrderGetReserMoveNameArgs : IContractArgs
    {
        private String _patientCode;
        private String _reserDate;
        private String _departmentCode;
        private String _reserYn;
        private String _rowNum;

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

        public String DepartmentCode
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

        public NuroInspectionOrderGetReserMoveNameArgs() { }

        public NuroInspectionOrderGetReserMoveNameArgs(String patientCode, String reserDate, String departmentCode, String reserYn, String rowNum)
        {
            this._patientCode = patientCode;
            this._reserDate = reserDate;
            this._departmentCode = departmentCode;
            this._reserYn = reserYn;
            this._rowNum = rowNum;
        }

        public IExtensible GetRequestInstance()
        {
            return new NuroInspectionOrderGetReserMoveNameRequest();
        }
    }
}