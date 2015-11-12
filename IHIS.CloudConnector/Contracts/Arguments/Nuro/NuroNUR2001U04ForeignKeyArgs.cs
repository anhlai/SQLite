using System;
using System.Collections.Generic;
using System.Text;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroNUR2001U04ForeignKeyArgs : IContractArgs
    {
        private string _comingDate;
        private string _patientCode;
        private string _departmentCode;
        private string _doctorCode;
        private string _comingType;
        private string _receptionNo;

        public string ComingDate
        {
            get { return _comingDate; }
            set { _comingDate = value; }
        }

        public string PatientCode
        {
            get { return _patientCode; }
            set { _patientCode = value; }
        }

        public string DepartmentCode
        {
            get { return _departmentCode; }
            set { _departmentCode = value; }
        }

        public string DoctorCode
        {
            get { return _doctorCode; }
            set { _doctorCode = value; }
        }

        public string ComingType
        {
            get { return _comingType; }
            set { _comingType = value; }
        }

        public string ReceptionNo
        {
            get { return _receptionNo; }
            set { _receptionNo = value; }
        }

        public NuroNUR2001U04ForeignKeyArgs(string comingDate, string patientCode, string departmentCode, string doctorCode, string comingType, string receptionNo)
        {
            _comingDate = comingDate;
            _patientCode = patientCode;
            _departmentCode = departmentCode;
            _doctorCode = doctorCode;
            _comingType = comingType;
            _receptionNo = receptionNo;
        }

        public NuroNUR2001U04ForeignKeyArgs()
        {
        }

        public IExtensible GetRequestInstance()
        {
            return new NuroNUR2001U04ForeignKeyRequest();
        }
    }
}
