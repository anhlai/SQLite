using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
    [Serializable]
    public class DRG0120U00ComboListArgs : IContractArgs
    {
        private String _param32;
        private String _param33;
        private String _param34;
        private String _param35;
        private String _paramUA;

        public String Param32
        {
            get { return this._param32; }
            set { this._param32 = value; }
        }

        public String Param33
        {
            get { return this._param33; }
            set { this._param33 = value; }
        }

        public String Param34
        {
            get { return this._param34; }
            set { this._param34 = value; }
        }

        public String Param35
        {
            get { return this._param35; }
            set { this._param35 = value; }
        }

        public String ParamUA
        {
            get { return this._paramUA; }
            set { this._paramUA = value; }
        }

        public DRG0120U00ComboListArgs() { }

        public DRG0120U00ComboListArgs(String param32, String param33, String param34, String param35, String paramUA)
        {
            this._param32 = param32;
            this._param33 = param33;
            this._param34 = param34;
            this._param35 = param35;
            this._paramUA = paramUA;
        }

        public IExtensible GetRequestInstance()
        {
            return new DRG0120U00ComboListRequest();
        }
    }
}