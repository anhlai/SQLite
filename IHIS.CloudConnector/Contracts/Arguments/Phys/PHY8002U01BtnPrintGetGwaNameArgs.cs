using System;
using IHIS.CloudConnector.Contracts.Models.Phys;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Phys
{
    public class PHY8002U01BtnPrintGetGwaNameArgs : IContractArgs
    {
        private String _colName;
        private String _startDate;
        private String _endDate;
        private String _gwa;
        private String _iraiDate;

        public String ColName
        {
            get { return this._colName; }
            set { this._colName = value; }
        }

        public String StartDate
        {
            get { return this._startDate; }
            set { this._startDate = value; }
        }

        public String EndDate
        {
            get { return this._endDate; }
            set { this._endDate = value; }
        }

        public String Gwa
        {
            get { return this._gwa; }
            set { this._gwa = value; }
        }

        public String IraiDate
        {
            get { return this._iraiDate; }
            set { this._iraiDate = value; }
        }

        public PHY8002U01BtnPrintGetGwaNameArgs() { }

        public PHY8002U01BtnPrintGetGwaNameArgs(String colName, String startDate, String endDate, String gwa, String iraiDate)
        {
            this._colName = colName;
            this._startDate = startDate;
            this._endDate = endDate;
            this._gwa = gwa;
            this._iraiDate = iraiDate;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.PHY8002U01BtnPrintGetGwaNameRequest();
        }
    }
}