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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SpeciFicCommentInputYnResponse")]
  public partial class SpeciFicCommentInputYnResponse : global::ProtoBuf.IExtensible
  {
    public SpeciFicCommentInputYnResponse() {}
    
    private bool _check_table_row = default(bool);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"check_table_row", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool check_table_row
    {
      get { return _check_table_row; }
      set { _check_table_row = value; }
    }
    private string _y_value = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"y_value", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string y_value
    {
      get { return _y_value; }
      set { _y_value = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
