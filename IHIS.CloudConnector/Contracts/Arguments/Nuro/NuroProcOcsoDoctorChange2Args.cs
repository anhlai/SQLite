using System;
using System.Collections.Generic;
using System.Text;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroProcOcsoDoctorChange2Args : IContractArgs
    {
        private String _pkout1001;
        private String _toDoctor;
        private String _toClinicCode;

        public String Pkout1001
        {
            get { return this._pkout1001; }
            set { this._pkout1001 = value; }
        }

        public String ToDoctor
        {
            get { return this._toDoctor; }
            set { this._toDoctor = value; }
        }

        public String ToClinicCode
        {
            get { return this._toClinicCode; }
            set { this._toClinicCode = value; }
        }

        public NuroProcOcsoDoctorChange2Args() { }

        public NuroProcOcsoDoctorChange2Args(String pkout1001, String toDoctor, String toClinicCode)
        {
            this._pkout1001 = pkout1001;
            this._toDoctor = toDoctor;
            this._toClinicCode = toClinicCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new NuroProcOcsoDoctorChange2Request();
        }
    }

}
