using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL3010U01SearchMaxArgs : IContractArgs
    {
        private String _infoGb;
        private String _fromPartJubsuDate;
        private String _toPartJubsuDate;
        private String _fromSeq;
        private String _toSeq;
        private String _fromSpecimenSer;
        private String _toSpecimenSer;

        public String InfoGb
        {
            get { return this._infoGb; }
            set { this._infoGb = value; }
        }

        public String FromPartJubsuDate
        {
            get { return this._fromPartJubsuDate; }
            set { this._fromPartJubsuDate = value; }
        }

        public String ToPartJubsuDate
        {
            get { return this._toPartJubsuDate; }
            set { this._toPartJubsuDate = value; }
        }

        public String FromSeq
        {
            get { return this._fromSeq; }
            set { this._fromSeq = value; }
        }

        public String ToSeq
        {
            get { return this._toSeq; }
            set { this._toSeq = value; }
        }

        public String FromSpecimenSer
        {
            get { return this._fromSpecimenSer; }
            set { this._fromSpecimenSer = value; }
        }

        public String ToSpecimenSer
        {
            get { return this._toSpecimenSer; }
            set { this._toSpecimenSer = value; }
        }

        public CPL3010U01SearchMaxArgs() { }

        public CPL3010U01SearchMaxArgs(String infoGb, String fromPartJubsuDate, String toPartJubsuDate, String fromSeq, String toSeq, String fromSpecimenSer, String toSpecimenSer)
        {
            this._infoGb = infoGb;
            this._fromPartJubsuDate = fromPartJubsuDate;
            this._toPartJubsuDate = toPartJubsuDate;
            this._fromSeq = fromSeq;
            this._toSeq = toSeq;
            this._fromSpecimenSer = fromSpecimenSer;
            this._toSpecimenSer = toSpecimenSer;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL3010U01SearchMaxRequest();
        }
    }
}