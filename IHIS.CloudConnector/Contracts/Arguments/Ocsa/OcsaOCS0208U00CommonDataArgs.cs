using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OcsaOCS0208U00CommonDataArgs : IContractArgs
    {
        private String _doctor;
        private String _bunryu1;
        private String _hospCode;

        public String Doctor
        {
            get { return this._doctor; }
            set { this._doctor = value; }
        }

        public String Bunryu1
        {
            get { return this._bunryu1; }
            set { this._bunryu1 = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public OcsaOCS0208U00CommonDataArgs() { }

        public OcsaOCS0208U00CommonDataArgs(String doctor, String bunryu1, String hospCode)
        {
            this._doctor = doctor;
            this._bunryu1 = bunryu1;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OcsaOCS0208U00CommonDataRequest();
        }
    }
}