//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: FindPatientForm.proto
namespace IHIS.CloudConnector.Messaging
{
    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"FindPatientInfo")]
    public partial class FindPatientInfo : global::ProtoBuf.IExtensible
    {
        public FindPatientInfo() { }

        private string _patient_code = "";
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name = @"patient_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string patient_code
        {
            get { return _patient_code; }
            set { _patient_code = value; }
        }
        private string _patient_name = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name = @"patient_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string patient_name
        {
            get { return _patient_name; }
            set { _patient_name = value; }
        }
        private string _patient_name2 = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name = @"patient_name2", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string patient_name2
        {
            get { return _patient_name2; }
            set { _patient_name2 = value; }
        }
        private string _sex = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name = @"sex", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string sex
        {
            get { return _sex; }
            set { _sex = value; }
        }
        private string _birth = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name = @"birth", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string birth
        {
            get { return _birth; }
            set { _birth = value; }
        }
        private string _last_comming_date = "";
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name = @"last_comming_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string last_comming_date
        {
            get { return _last_comming_date; }
            set { _last_comming_date = value; }
        }
        private string _address = "";
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name = @"address", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string address
        {
            get { return _address; }
            set { _address = value; }
        }
        private string _ipwon_yn = "";
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name = @"ipwon_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string ipwon_yn
        {
            get { return _ipwon_yn; }
            set { _ipwon_yn = value; }
        }
        private string _treatment_area = "";
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name = @"treatment_area", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string treatment_area
        {
            get { return _treatment_area; }
            set { _treatment_area = value; }
        }
        private string _tel = "";
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name = @"tel", DataFormat = global::ProtoBuf.DataFormat.Default)]
        [global::System.ComponentModel.DefaultValue("")]
        public string tel
        {
            get { return _tel; }
            set { _tel = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }
}