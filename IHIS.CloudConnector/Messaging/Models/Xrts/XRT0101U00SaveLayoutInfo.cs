//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: input.proto
// Note: requires additional types generated from: import.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"XRT0101U00SaveLayoutInfo")]
  public partial class XRT0101U00SaveLayoutInfo : global::ProtoBuf.IExtensible
  {
    public XRT0101U00SaveLayoutInfo() {}
    
    private string _code_type = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"code_type", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string code_type
    {
      get { return _code_type; }
      set { _code_type = value; }
    }
    private string _code_type_name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"code_type_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string code_type_name
    {
      get { return _code_type_name; }
      set { _code_type_name = value; }
    }
    private string _code = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string code
    {
      get { return _code; }
      set { _code = value; }
    }
    private string _code_name = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"code_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string code_name
    {
      get { return _code_name; }
      set { _code_name = value; }
    }
    private string _code2 = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"code2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string code2
    {
      get { return _code2; }
      set { _code2 = value; }
    }
    private string _seq = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"seq", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string seq
    {
      get { return _seq; }
      set { _seq = value; }
    }
    private string _code_value = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"code_value", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string code_value
    {
      get { return _code_value; }
      set { _code_value = value; }
    }
    private string _row_state = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"row_state", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string row_state
    {
      get { return _row_state; }
      set { _row_state = value; }
    }
    private string _caller_id = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"caller_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string caller_id
    {
      get { return _caller_id; }
      set { _caller_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
