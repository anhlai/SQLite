using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroOUT1001U01InsertTableOUT1002Args : IContractArgs
    {
        private String _userId;
        private String _updateId;
        private String _hospCode;
        private String _newPkout1001;
        private String _gongbiCode1;
        private String _bunho;
        private String _priority1;

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public String UpdateId
        {
            get { return this._updateId; }
            set { this._updateId = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public String NewPkout1001
        {
            get { return this._newPkout1001; }
            set { this._newPkout1001 = value; }
        }

        public String GongbiCode1
        {
            get { return this._gongbiCode1; }
            set { this._gongbiCode1 = value; }
        }

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public String Priority1
        {
            get { return this._priority1; }
            set { this._priority1 = value; }
        }

        public NuroOUT1001U01InsertTableOUT1002Args() { }

        public NuroOUT1001U01InsertTableOUT1002Args(String userId, String updateId, String hospCode, String newPkout1001, String gongbiCode1, String bunho, String priority1)
        {
            this._userId = userId;
            this._updateId = updateId;
            this._hospCode = hospCode;
            this._newPkout1001 = newPkout1001;
            this._gongbiCode1 = gongbiCode1;
            this._bunho = bunho;
            this._priority1 = priority1;
        }

        public IExtensible GetRequestInstance()
        {
            return new NuroOUT1001U01InsertTableOUT1002Request();
        }
    }
}
