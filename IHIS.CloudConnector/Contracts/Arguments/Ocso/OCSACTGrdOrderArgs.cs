using System;
using IHIS.CloudConnector.Contracts.Models.Ocso;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
    public class OCSACTGrdOrderArgs : IContractArgs
    {
        private Boolean _rbxNonAct;
        private Boolean _rbxAct;
        private String _cboSystem;
        private String _cboVal;
        private String _ioGubun;
        private String _actGubun;
        private String _fromDate;
        private String _toDate;
        private String _jundalTableCode;
        private String _jundalPart;
        private String _bunho;
        private String _gwa;
        private String _doctor;
        private String _systemId;
        private String _cboPart;

        public Boolean RbxNonAct
        {
            get { return this._rbxNonAct; }
            set { this._rbxNonAct = value; }
        }

        public Boolean RbxAct
        {
            get { return this._rbxAct; }
            set { this._rbxAct = value; }
        }

        public String CboSystem
        {
            get { return this._cboSystem; }
            set { this._cboSystem = value; }
        }

        public String CboVal
        {
            get { return this._cboVal; }
            set { this._cboVal = value; }
        }

        public String IoGubun
        {
            get { return this._ioGubun; }
            set { this._ioGubun = value; }
        }

        public String ActGubun
        {
            get { return this._actGubun; }
            set { this._actGubun = value; }
        }

        public String FromDate
        {
            get { return this._fromDate; }
            set { this._fromDate = value; }
        }

        public String ToDate
        {
            get { return this._toDate; }
            set { this._toDate = value; }
        }

        public String JundalTableCode
        {
            get { return this._jundalTableCode; }
            set { this._jundalTableCode = value; }
        }

        public String JundalPart
        {
            get { return this._jundalPart; }
            set { this._jundalPart = value; }
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

        public String Doctor
        {
            get { return this._doctor; }
            set { this._doctor = value; }
        }

        public String SystemId
        {
            get { return this._systemId; }
            set { this._systemId = value; }
        }

        public String CboPart
        {
            get { return this._cboPart; }
            set { this._cboPart = value; }
        }

        public OCSACTGrdOrderArgs() { }

        public OCSACTGrdOrderArgs(Boolean rbxNonAct, Boolean rbxAct, String cboSystem, String cboVal, String ioGubun, String actGubun, String fromDate, String toDate, String jundalTableCode, String jundalPart, String bunho, String gwa, String doctor, String systemId, String cboPart)
        {
            this._rbxNonAct = rbxNonAct;
            this._rbxAct = rbxAct;
            this._cboSystem = cboSystem;
            this._cboVal = cboVal;
            this._ioGubun = ioGubun;
            this._actGubun = actGubun;
            this._fromDate = fromDate;
            this._toDate = toDate;
            this._jundalTableCode = jundalTableCode;
            this._jundalPart = jundalPart;
            this._bunho = bunho;
            this._gwa = gwa;
            this._doctor = doctor;
            this._systemId = systemId;
            this._cboPart = cboPart;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCSACTGrdOrderRequest();
        }
    }
}