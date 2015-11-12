using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL3020U02SetDataIFS7204Args : IContractArgs
    {
        private String _fk;
        private String _recordGubun;
        private String _sentaCode;
        private String _iraiKey;
        private String _hangmogCode;
        private String _resultCode;
        private String _specimenSer;
        private String _resultVal;
        private String _danui;
        private String _fromStandard;
        private String _toStandard;
        private String _emergency;
        private String _yobi1;

        public String Fk
        {
            get { return this._fk; }
            set { this._fk = value; }
        }

        public String RecordGubun
        {
            get { return this._recordGubun; }
            set { this._recordGubun = value; }
        }

        public String SentaCode
        {
            get { return this._sentaCode; }
            set { this._sentaCode = value; }
        }

        public String IraiKey
        {
            get { return this._iraiKey; }
            set { this._iraiKey = value; }
        }

        public String HangmogCode
        {
            get { return this._hangmogCode; }
            set { this._hangmogCode = value; }
        }

        public String ResultCode
        {
            get { return this._resultCode; }
            set { this._resultCode = value; }
        }

        public String SpecimenSer
        {
            get { return this._specimenSer; }
            set { this._specimenSer = value; }
        }

        public String ResultVal
        {
            get { return this._resultVal; }
            set { this._resultVal = value; }
        }

        public String Danui
        {
            get { return this._danui; }
            set { this._danui = value; }
        }

        public String FromStandard
        {
            get { return this._fromStandard; }
            set { this._fromStandard = value; }
        }

        public String ToStandard
        {
            get { return this._toStandard; }
            set { this._toStandard = value; }
        }

        public String Emergency
        {
            get { return this._emergency; }
            set { this._emergency = value; }
        }

        public String Yobi1
        {
            get { return this._yobi1; }
            set { this._yobi1 = value; }
        }

        public CPL3020U02SetDataIFS7204Args() { }

        public CPL3020U02SetDataIFS7204Args(String fk, String recordGubun, String sentaCode, String iraiKey, String hangmogCode, String resultCode, String specimenSer, String resultVal, String danui, String fromStandard, String toStandard, String emergency, String yobi1)
        {
            this._fk = fk;
            this._recordGubun = recordGubun;
            this._sentaCode = sentaCode;
            this._iraiKey = iraiKey;
            this._hangmogCode = hangmogCode;
            this._resultCode = resultCode;
            this._specimenSer = specimenSer;
            this._resultVal = resultVal;
            this._danui = danui;
            this._fromStandard = fromStandard;
            this._toStandard = toStandard;
            this._emergency = emergency;
            this._yobi1 = yobi1;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL3020U02SetDataIFS7204Request();
        }
    }
}