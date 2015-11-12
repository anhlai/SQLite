using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL0106U00GrdCodeArgs : IContractArgs
    {
        private String _hangmogCode;
        private String _specimenCode;
        private String _emergency;
        private String _groupGubun;

        public String HangmogCode
        {
            get { return this._hangmogCode; }
            set { this._hangmogCode = value; }
        }

        public String SpecimenCode
        {
            get { return this._specimenCode; }
            set { this._specimenCode = value; }
        }

        public String Emergency
        {
            get { return this._emergency; }
            set { this._emergency = value; }
        }

        public String GroupGubun
        {
            get { return this._groupGubun; }
            set { this._groupGubun = value; }
        }

        public CPL0106U00GrdCodeArgs() { }

        public CPL0106U00GrdCodeArgs(String hangmogCode, String specimenCode, String emergency, String groupGubun)
        {
            this._hangmogCode = hangmogCode;
            this._specimenCode = specimenCode;
            this._emergency = emergency;
            this._groupGubun = groupGubun;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL0106U00GrdCodeRequest();
        }
    }
}