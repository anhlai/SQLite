using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL2010U00ChangeTimeGrdSpecimenArgs : IContractArgs
    {
        private String _orderDate;
        private String _bunho;
        private String _gwa;
        private String _gubun;
        private String _doctor;
        private String _inOutGubun;

        public String OrderDate
        {
            get { return this._orderDate; }
            set { this._orderDate = value; }
        }

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public String Gwa
        {
            get { return this._gwa; }
            set { this._gwa = value; }
        }

        public String Gubun
        {
            get { return this._gubun; }
            set { this._gubun = value; }
        }

        public String Doctor
        {
            get { return this._doctor; }
            set { this._doctor = value; }
        }

        public String InOutGubun
        {
            get { return this._inOutGubun; }
            set { this._inOutGubun = value; }
        }

        public CPL2010U00ChangeTimeGrdSpecimenArgs() { }

        public CPL2010U00ChangeTimeGrdSpecimenArgs(String orderDate, String bunho, String gwa, String gubun, String doctor, String inOutGubun)
        {
            this._orderDate = orderDate;
            this._bunho = bunho;
            this._gwa = gwa;
            this._gubun = gubun;
            this._doctor = doctor;
            this._inOutGubun = inOutGubun;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL2010U00ChangeTimeGrdSpecimenRequest();
        }
    }
}