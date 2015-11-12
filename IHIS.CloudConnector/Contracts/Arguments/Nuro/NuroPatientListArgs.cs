using System;
using System.Collections.Generic;
using System.Text;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroPatientListArgs : IContractArgs
    {
        private string _hospitalCode;
        private string _comingDate;
        private string _departmentCode;
        private string _doctorCode;
        private string _patientCode;
        private string _receptionType;
        private string _examStatus;
        private string _comingStatus;
        private string _currentSystemId;

        public string HospitalCode
        {
            get { return _hospitalCode; }
            set { _hospitalCode = value; }
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

        public string PatientCode
        {
            get { return _patientCode; }
            set { _patientCode = value; }
        }

        public string ReceptionType
        {
            get { return _receptionType; }
            set { _receptionType = value; }
        }

        public string ExamStatus
        {
            get { return _examStatus; }
            set { _examStatus = value; }
        }

        public string ComingStatus
        {
            get { return _comingStatus; }
            set { _comingStatus = value; }
        }

        public string CurrentSystemId
        {
            get { return _currentSystemId; }
            set { _currentSystemId = value; }
        }

        public NuroPatientListArgs()
        {
        }

        public IExtensible GetRequestInstance()
        {
            return new NuroPatientListRequest();
        }
    }
}
