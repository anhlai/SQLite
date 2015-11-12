using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroOUT1001U01GetDepartmentArgs : IContractArgs
    {
        private String _buseoYmd;
        private String _find1;
        private String _buseoGubun;

        public String BuseoYmd
        {
            get { return this._buseoYmd; }
            set { this._buseoYmd = value; }
        }

        public String Find1
        {
            get { return this._find1; }
            set { this._find1 = value; }
        }

        public String BuseoGubun
        {
            get { return this._buseoGubun; }
            set { this._buseoGubun = value; }
        }

        public NuroOUT1001U01GetDepartmentArgs() { }

        public NuroOUT1001U01GetDepartmentArgs(String buseoYmd, String find1, String buseoGubun)
        {
            this._buseoYmd = buseoYmd;
            this._find1 = find1;
            this._buseoGubun = buseoGubun;
        }

        public IExtensible GetRequestInstance()
        {
            return new NuroOUT1001U01GetDepartmentRequest();
        }
    }
}