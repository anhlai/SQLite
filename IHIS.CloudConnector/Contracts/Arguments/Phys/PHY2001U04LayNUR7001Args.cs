using System;
using IHIS.CloudConnector.Contracts.Models.Phys;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Phys
{
    public class PHY2001U04LayNUR7001Args : IContractArgs
    {
        private String _bunho;
        private String _measureDate;

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public String MeasureDate
        {
            get { return this._measureDate; }
            set { this._measureDate = value; }
        }

        public PHY2001U04LayNUR7001Args() { }

        public PHY2001U04LayNUR7001Args(String bunho, String measureDate)
        {
            this._bunho = bunho;
            this._measureDate = measureDate;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.PHY2001U04LayNUR7001Request();
        }
    }
}