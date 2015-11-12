using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL3020U02GrdResultArgs : IContractArgs
    {
        private String _labNo;
        private String _specimenSer;
        private String _jundalGubun;

        public String LabNo
        {
            get { return this._labNo; }
            set { this._labNo = value; }
        }

        public String SpecimenSer
        {
            get { return this._specimenSer; }
            set { this._specimenSer = value; }
        }

        public String JundalGubun
        {
            get { return this._jundalGubun; }
            set { this._jundalGubun = value; }
        }

        public CPL3020U02GrdResultArgs() { }

        public CPL3020U02GrdResultArgs(String labNo, String specimenSer, String jundalGubun)
        {
            this._labNo = labNo;
            this._specimenSer = specimenSer;
            this._jundalGubun = jundalGubun;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL3020U02GrdResultRequest();
        }
    }
}