//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IHIS.CloudConnector.Messaging
{
    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"NuroOUT1001U01InsertTableOUT1002Request")]
    public partial class NuroOUT1001U01InsertTableOUT1002Request : global::ProtoBuf.IExtensible
    {
        public NuroOUT1001U01InsertTableOUT1002Request() { }

        private string _user_id = "";
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"user_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string user_id
        {
            get { return _user_id; }
            set { _user_id = value; }
        }
        private string _update_id = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"update_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string update_id
        {
            get { return _update_id; }
            set { _update_id = value; }
        }
        private string _hosp_code = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"hosp_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string hosp_code
        {
            get { return _hosp_code; }
            set { _hosp_code = value; }
        }
        private string _new_pkout1001 = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"new_pkout1001", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string new_pkout1001
        {
            get { return _new_pkout1001; }
            set { _new_pkout1001 = value; }
        }
        private string _gongbi_code1 = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"gongbi_code1", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string gongbi_code1
        {
            get { return _gongbi_code1; }
            set { _gongbi_code1 = value; }
        }
        private string _bunho = "";
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name = @"bunho", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string bunho
        {
            get { return _bunho; }
            set { _bunho = value; }
        }
        private string _priority1 = "";
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name = @"priority1", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string priority1
        {
            get { return _priority1; }
            set { _priority1 = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }
}