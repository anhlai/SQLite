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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPL3020U00GrdResultRequest")]
  public partial class CPL3020U00GrdResultRequest : global::ProtoBuf.IExtensible
  {
    public CPL3020U00GrdResultRequest() {}
    
    private string _specimen_ser = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"specimen_ser", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string specimen_ser
    {
      get { return _specimen_ser; }
      set { _specimen_ser = value; }
    }
    private string _lab_no = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"lab_no", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string lab_no
    {
      get { return _lab_no; }
      set { _lab_no = value; }
    }
    private string _jundal_gubun = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"jundal_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string jundal_gubun
    {
      get { return _jundal_gubun; }
      set { _jundal_gubun = value; }
    }
    private string _code_type = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"code_type", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string code_type
    {
      get { return _code_type; }
      set { _code_type = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
