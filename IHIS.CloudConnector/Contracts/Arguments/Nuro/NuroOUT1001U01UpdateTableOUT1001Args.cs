using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroOUT1001U01UpdateTableOUT1001Args : IContractArgs
    {
        private String _userId;
        private String _doctor;
        private String _chojae;
        private String _jubsuNo;
        private String _gubun;
        private String _jubsuTime;
        private String _arriveTime;
        private String _jubsuGubun;
        private String _checkNaewon;
        private String _pkout1001;

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public String Doctor
        {
            get { return this._doctor; }
            set { this._doctor = value; }
        }

        public String Chojae
        {
            get { return this._chojae; }
            set { this._chojae = value; }
        }

        public String JubsuNo
        {
            get { return this._jubsuNo; }
            set { this._jubsuNo = value; }
        }

        public String Gubun
        {
            get { return this._gubun; }
            set { this._gubun = value; }
        }

        public String JubsuTime
        {
            get { return this._jubsuTime; }
            set { this._jubsuTime = value; }
        }

        public String ArriveTime
        {
            get { return this._arriveTime; }
            set { this._arriveTime = value; }
        }

        public String JubsuGubun
        {
            get { return this._jubsuGubun; }
            set { this._jubsuGubun = value; }
        }

        public String CheckNaewon
        {
            get { return this._checkNaewon; }
            set { this._checkNaewon = value; }
        }

        public String Pkout1001
        {
            get { return this._pkout1001; }
            set { this._pkout1001 = value; }
        }

        public NuroOUT1001U01UpdateTableOUT1001Args() { }

        public NuroOUT1001U01UpdateTableOUT1001Args(String userId, String doctor, String chojae, String jubsuNo, String gubun, String jubsuTime, String arriveTime, String jubsuGubun, String checkNaewon, String pkout1001)
        {
            this._userId = userId;
            this._doctor = doctor;
            this._chojae = chojae;
            this._jubsuNo = jubsuNo;
            this._gubun = gubun;
            this._jubsuTime = jubsuTime;
            this._arriveTime = arriveTime;
            this._jubsuGubun = jubsuGubun;
            this._checkNaewon = checkNaewon;
            this._pkout1001 = pkout1001;
        }

        public IExtensible GetRequestInstance()
        {
            return new NuroOUT1001U01UpdateTableOUT1001Request();
        }
    }
}