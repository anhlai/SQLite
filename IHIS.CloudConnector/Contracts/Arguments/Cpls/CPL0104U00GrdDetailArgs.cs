using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL0104U00GrdDetailArgs : IContractArgs
    {
        private String _hangmogCode;
        private String _specimenCode;
        private String _emergency;
        private String _pageNumber;
        private String _offset;

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

        public String PageNumber
        {
            get { return this._pageNumber; }
            set { this._pageNumber = value; }
        }

        public String Offset
        {
            get { return this._offset; }
            set { this._offset = value; }
        }

        public CPL0104U00GrdDetailArgs() { }

        public CPL0104U00GrdDetailArgs(String hangmogCode, String specimenCode, String emergency, String pageNumber, String offset)
        {
            this._hangmogCode = hangmogCode;
            this._specimenCode = specimenCode;
            this._emergency = emergency;
            this._pageNumber = pageNumber;
            this._offset = offset;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL0104U00GrdDetailRequest();
        }
    }
}