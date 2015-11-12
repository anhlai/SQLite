using System;
using IHIS.CloudConnector.Contracts.Models.Ocso;
using System.Collections.Generic;
using ProtoBuf;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
    public class OCS1003Q09LoadComboDataSourceArgs : IContractArgs
    {
        private ComboDataSourceInfo _forColPay;
        private ComboDataSourceInfo _forPortableYn;
        private ComboDataSourceInfo _forJusaSpdGubun;
        private ComboDataSourceInfo _forNalsu;
        private ComboDataSourceInfo _forSuryang;
        private ComboDataSourceInfo _forDv;

        public ComboDataSourceInfo ForColPay
        {
            get { return this._forColPay; }
            set { this._forColPay = value; }
        }

        public ComboDataSourceInfo ForPortableYn
        {
            get { return this._forPortableYn; }
            set { this._forPortableYn = value; }
        }

        public ComboDataSourceInfo ForJusaSpdGubun
        {
            get { return this._forJusaSpdGubun; }
            set { this._forJusaSpdGubun = value; }
        }

        public ComboDataSourceInfo ForNalsu
        {
            get { return this._forNalsu; }
            set { this._forNalsu = value; }
        }

        public ComboDataSourceInfo ForSuryang
        {
            get { return this._forSuryang; }
            set { this._forSuryang = value; }
        }

        public ComboDataSourceInfo ForDv
        {
            get { return this._forDv; }
            set { this._forDv = value; }
        }

        public OCS1003Q09LoadComboDataSourceArgs() { }

        public OCS1003Q09LoadComboDataSourceArgs(ComboDataSourceInfo forColPay, ComboDataSourceInfo forPortableYn, ComboDataSourceInfo forJusaSpdGubun, ComboDataSourceInfo forNalsu, ComboDataSourceInfo forSuryang, ComboDataSourceInfo forDv)
        {
            this._forColPay = forColPay;
            this._forPortableYn = forPortableYn;
            this._forJusaSpdGubun = forJusaSpdGubun;
            this._forNalsu = forNalsu;
            this._forSuryang = forSuryang;
            this._forDv = forDv;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS1003Q09LoadComboDataSourceRequest();
        }
    }
}