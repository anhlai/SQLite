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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BAS0230U00GrdBas0230Info")]
  public partial class BAS0230U00GrdBas0230Info : global::ProtoBuf.IExtensible
  {
    public BAS0230U00GrdBas0230Info() {}
    
    private string _bun_code = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"bun_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string bun_code
    {
      get { return _bun_code; }
      set { _bun_code = value; }
    }
    private string _bun_name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"bun_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string bun_name
    {
      get { return _bun_name; }
      set { _bun_name = value; }
    }
    private string _bun_ymd = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"bun_ymd", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string bun_ymd
    {
      get { return _bun_ymd; }
      set { _bun_ymd = value; }
    }
    private string _data_row_state = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"data_row_state", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string data_row_state
    {
      get { return _data_row_state; }
      set { _data_row_state = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
