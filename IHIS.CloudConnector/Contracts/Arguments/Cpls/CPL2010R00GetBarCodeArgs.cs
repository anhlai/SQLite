using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL2010R00GetBarCodeArgs : IContractArgs
    {
        private String _specimenSer;

        public String SpecimenSer
        {
            get { return this._specimenSer; }
            set { this._specimenSer = value; }
        }

        public CPL2010R00GetBarCodeArgs() { }

        public CPL2010R00GetBarCodeArgs(String specimenSer)
        {
            this._specimenSer = specimenSer;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL2010R00GetBarCodeRequest();
        }
    }
}