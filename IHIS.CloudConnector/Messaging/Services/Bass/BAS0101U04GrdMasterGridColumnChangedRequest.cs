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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BAS0101U04GrdMasterGridColumnChangedRequest")]
  public partial class BAS0101U04GrdMasterGridColumnChangedRequest : global::ProtoBuf.IExtensible
  {
    public BAS0101U04GrdMasterGridColumnChangedRequest() {}
    
    private string _master_check = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"master_check", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string master_check
    {
      get { return _master_check; }
      set { _master_check = value; }
    }
    private string _code_type = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"code_type", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string code_type
    {
      get { return _code_type; }
      set { _code_type = value; }
    }
    private string _col_id = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"col_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string col_id
    {
      get { return _col_id; }
      set { _col_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
