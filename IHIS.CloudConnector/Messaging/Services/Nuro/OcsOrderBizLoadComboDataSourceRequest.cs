//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: sample.proto
// Note: requires additional types generated from: nuro_model.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OcsOrderBizLoadComboDataSourceRequest")]
  public partial class OcsOrderBizLoadComboDataSourceRequest : global::ProtoBuf.IExtensible
  {
    public OcsOrderBizLoadComboDataSourceRequest() {}
    
    private string _aColName = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"aColName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string aColName
    {
      get { return _aColName; }
      set { _aColName = value; }
    }
    private string _aArgu1 = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"aArgu1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string aArgu1
    {
      get { return _aArgu1; }
      set { _aArgu1 = value; }
    }
    private string _aArgu2 = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"aArgu2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string aArgu2
    {
      get { return _aArgu2; }
      set { _aArgu2 = value; }
    }
    private string _aArgu3 = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"aArgu3", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string aArgu3
    {
      get { return _aArgu3; }
      set { _aArgu3 = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}