using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL3020U02SetDataIFS7203Args : IContractArgs
    {
        private String _recordGubun;
        private String _sentaCode;
        private String _iraiKey;
        private String _karuteNo;
        private String _kanjamei;
        private String _koumokusuu;
        private String _houkokubi;
        private String _yobi1;
        private String _yobi2;

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

        public String KaruteNo
        {
            get { return this._karuteNo; }
            set { this._karuteNo = value; }
        }

        public String Kanjamei
        {
            get { return this._kanjamei; }
            set { this._kanjamei = value; }
        }

        public String Koumokusuu
        {
            get { return this._koumokusuu; }
            set { this._koumokusuu = value; }
        }

        public String Houkokubi
        {
            get { return this._houkokubi; }
            set { this._houkokubi = value; }
        }

        public String Yobi1
        {
            get { return this._yobi1; }
            set { this._yobi1 = value; }
        }

        public String Yobi2
        {
            get { return this._yobi2; }
            set { this._yobi2 = value; }
        }

        public CPL3020U02SetDataIFS7203Args() { }

        public CPL3020U02SetDataIFS7203Args(String recordGubun, String sentaCode, String iraiKey, String karuteNo, String kanjamei, String koumokusuu, String houkokubi, String yobi1, String yobi2)
        {
            this._recordGubun = recordGubun;
            this._sentaCode = sentaCode;
            this._iraiKey = iraiKey;
            this._karuteNo = karuteNo;
            this._kanjamei = kanjamei;
            this._koumokusuu = koumokusuu;
            this._houkokubi = houkokubi;
            this._yobi1 = yobi1;
            this._yobi2 = yobi2;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL3020U02SetDataIFS7203Request();
        }
    }
}