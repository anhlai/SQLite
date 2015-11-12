using System;
using System.Collections.Generic;
using System.Text;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroNUR2001U04ComingStatusArgs : IContractArgs
    {
        private string _patientCode;
        private string _comingDate;
        private string _departmentCode;
        private string _doctorCode;
        private string _comingType;
        private string _oldReceptionNo;
        private string _examStatus;

        public string PatientCode
        {
            get { return _patientCode; }
            set { _patientCode = value; }
        }

        public string ComingDate
        {
            get { return _comingDate; }
            set { _comingDate = value; }
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

        public string OldReceptionNo
        {
            get { return _oldReceptionNo; }
            set { _oldReceptionNo = value; }
        }

        public string ExamStatus
        {
            get { return _examStatus; }
            set { _examStatus = value; }
        }

        public NuroNUR2001U04ComingStatusArgs(string patientCode, string comingDate, string departmentCode, string doctorCode, string comingType, string oldReceptionNo, string examStatus)
        {
            _patientCode = patientCode;
            _comingDate = comingDate;
            _departmentCode = departmentCode;
            _doctorCode = doctorCode;
            _comingType = comingType;
            _oldReceptionNo = oldReceptionNo;
            _examStatus = examStatus;
        }

        public NuroNUR2001U04ComingStatusArgs()
        {
        }

        public IExtensible GetRequestInstance()
        {
            return new NuroNUR2001U04ComingStatusRequest();
        }
    }
}
