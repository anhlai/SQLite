using System;
using IHIS.CloudConnector.Contracts.Models.Drgs;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
    public class DRGOCSCHKGrdOcsChkArgs : IContractArgs
    {
        private String _jaeryoCode;
        private String _jaeryoName;
        private String _preSmallCode;
        private String _smallCode;
        private String _drgPackYn;
        private String _phamarcyYn;
        private String _powderYn;
        private String _hubalYn;
        private String _mayakYn;
        private String _beforeUseYn;
        private String _pageNumber;

        public String JaeryoCode
        {
            get { return this._jaeryoCode; }
            set { this._jaeryoCode = value; }
        }

        public String JaeryoName
        {
            get { return this._jaeryoName; }
            set { this._jaeryoName = value; }
        }

        public String PreSmallCode
        {
            get { return this._preSmallCode; }
            set { this._preSmallCode = value; }
        }

        public String SmallCode
        {
            get { return this._smallCode; }
            set { this._smallCode = value; }
        }

        public String DrgPackYn
        {
            get { return this._drgPackYn; }
            set { this._drgPackYn = value; }
        }

        public String PhamarcyYn
        {
            get { return this._phamarcyYn; }
            set { this._phamarcyYn = value; }
        }

        public String PowderYn
        {
            get { return this._powderYn; }
            set { this._powderYn = value; }
        }

        public String HubalYn
        {
            get { return this._hubalYn; }
            set { this._hubalYn = value; }
        }

        public String MayakYn
        {
            get { return this._mayakYn; }
            set { this._mayakYn = value; }
        }

        public String BeforeUseYn
        {
            get { return this._beforeUseYn; }
            set { this._beforeUseYn = value; }
        }

        public String PageNumber
        {
            get { return this._pageNumber; }
            set { this._pageNumber = value; }
        }

        public DRGOCSCHKGrdOcsChkArgs() { }

        public DRGOCSCHKGrdOcsChkArgs(String jaeryoCode, String jaeryoName, String preSmallCode, String smallCode, String drgPackYn, String phamarcyYn, String powderYn, String hubalYn, String mayakYn, String beforeUseYn, String pageNumber)
        {
            this._jaeryoCode = jaeryoCode;
            this._jaeryoName = jaeryoName;
            this._preSmallCode = preSmallCode;
            this._smallCode = smallCode;
            this._drgPackYn = drgPackYn;
            this._phamarcyYn = phamarcyYn;
            this._powderYn = powderYn;
            this._hubalYn = hubalYn;
            this._mayakYn = mayakYn;
            this._beforeUseYn = beforeUseYn;
            this._pageNumber = pageNumber;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.DRGOCSCHKGrdOcsChkRequest();
        }
    }
}