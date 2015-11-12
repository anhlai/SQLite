using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL2010R01LaySpecimenListArgs : IContractArgs
    {
        private String _hoDong;
        private String _reserDate;

        public String HoDong
        {
            get { return this._hoDong; }
            set { this._hoDong = value; }
        }

        public String ReserDate
        {
            get { return this._reserDate; }
            set { this._reserDate = value; }
        }

        public CPL2010R01LaySpecimenListArgs() { }

        public CPL2010R01LaySpecimenListArgs(String hoDong, String reserDate)
        {
            this._hoDong = hoDong;
            this._reserDate = reserDate;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL2010R01LaySpecimenListRequest();
        }
    }
}