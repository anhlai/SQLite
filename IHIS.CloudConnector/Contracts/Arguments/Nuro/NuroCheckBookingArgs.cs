using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroCheckBookingArgs : IContractArgs
    {
        private String _patientCode;
        private String _reserDate;

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

        public NuroCheckBookingArgs() { }

        public NuroCheckBookingArgs(String patientCode, String reserDate)
        {
            this._patientCode = patientCode;
            this._reserDate = reserDate;
        }

        public IExtensible GetRequestInstance()
        {
            return new NuroCheckBookingRequest();
        }
    }
}
