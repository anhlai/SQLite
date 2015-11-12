using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL3010U01LaySpecimenArgs : IContractArgs
    {
        private String _specimenSer;

        public String SpecimenSer
        {
            get { return this._specimenSer; }
            set { this._specimenSer = value; }
        }

        public CPL3010U01LaySpecimenArgs() { }

        public CPL3010U01LaySpecimenArgs(String specimenSer)
        {
            this._specimenSer = specimenSer;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL3010U01LaySpecimenRequest();
        }
    }
}