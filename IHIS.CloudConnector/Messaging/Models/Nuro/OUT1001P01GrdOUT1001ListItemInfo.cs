//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: sample.proto
namespace IHIS.CloudConnector.Messaging
{
    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"OUT1001P01GrdOUT1001ListItemInfo")]
    public partial class OUT1001P01GrdOUT1001ListItemInfo : global::ProtoBuf.IExtensible
    {
        public OUT1001P01GrdOUT1001ListItemInfo() { }

        private string _pkout1001 = "";
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"pkout1001", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string pkout1001
        {
            get { return _pkout1001; }
            set { _pkout1001 = value; }
        }
        private string _bunho = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"bunho", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string bunho
        {
            get { return _bunho; }
            set { _bunho = value; }
        }
        private string _gwa = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"gwa", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string gwa
        {
            get { return _gwa; }
            set { _gwa = value; }
        }
        private string _gwa_name = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"gwa_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string gwa_name
        {
            get { return _gwa_name; }
            set { _gwa_name = value; }
        }
        private string _doctor = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"doctor", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string doctor
        {
            get { return _doctor; }
            set { _doctor = value; }
        }
        private string _doctor_name = "";
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name = @"doctor_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string doctor_name
        {
            get { return _doctor_name; }
            set { _doctor_name = value; }
        }
        private string _jubsu_no = "";
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name = @"jubsu_no", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string jubsu_no
        {
            get { return _jubsu_no; }
            set { _jubsu_no = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }

}