using System;
using System.Collections.Generic;
using System.Text;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
    public class FindPatientFromArgs : IContractArgs
    {
        private String patientName2;
        private String sex;
        private String brith;
        private String tel;
        private String patientCode;

        public FindPatientFromArgs()
        {
        }

        public FindPatientFromArgs(string patientName2, string sex, string brith, string tel, string patientCode)
        {
            this.patientName2 = patientName2;
            this.sex = sex;
            this.brith = brith;
            this.tel = tel;
            this.patientCode = patientCode;
        }

        public String PatientName2
        {
            get { return this.patientName2; }
            set { this.patientName2 = value; }
        }

        public String Sex
        {
            get { return this.sex; }
            set { this.sex = value; }
        }

        public String Brith
        {
            get { return this.brith; }
            set { this.brith = value; }
        }

        public String Tel
        {
            get { return this.tel; }
            set { this.tel = value; }
        }

        public String PatientCode
        {
            get { return this.patientCode; }
            set { this.patientCode = value; }
        }

        public IExtensible GetRequestInstance()
        {
            return new FindPatientFromRequest();
        }
    }
}