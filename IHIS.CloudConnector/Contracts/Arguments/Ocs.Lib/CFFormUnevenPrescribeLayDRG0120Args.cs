using System;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
    public class CFFormUnevenPrescribeLayDRG0120Args : IContractArgs
    {
        private String _hospCode;
        private String _bogyongCode;

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public String BogyongCode
        {
            get { return this._bogyongCode; }
            set { this._bogyongCode = value; }
        }

        public CFFormUnevenPrescribeLayDRG0120Args() { }

        public CFFormUnevenPrescribeLayDRG0120Args(String hospCode, String bogyongCode)
        {
            this._hospCode = hospCode;
            this._bogyongCode = bogyongCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CFFormUnevenPrescribeLayDRG0120Request();
        }
    }
}