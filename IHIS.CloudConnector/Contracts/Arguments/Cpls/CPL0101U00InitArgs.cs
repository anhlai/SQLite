using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL0101U00InitArgs : IContractArgs
    {
        private String _txtHangmog;
        private String _ioGubun;
        private String _pageNumber;
        private String _offset;

        public String TxtHangmog
        {
            get { return this._txtHangmog; }
            set { this._txtHangmog = value; }
        }

        public String IoGubun
        {
            get { return this._ioGubun; }
            set { this._ioGubun = value; }
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

        public CPL0101U00InitArgs() { }

        public CPL0101U00InitArgs(String txtHangmog, String ioGubun, String pageNumber, String offset)
        {
            this._txtHangmog = txtHangmog;
            this._ioGubun = ioGubun;
            this._pageNumber = pageNumber;
            this._offset = offset;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL0101U00InitRequest();
        }
    }
}