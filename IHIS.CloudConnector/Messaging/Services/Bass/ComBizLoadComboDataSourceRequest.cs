//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: sample.proto
// Note: requires additional types generated from: mixed_model.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ComBizLoadComboDataSourceRequest")]
  public partial class ComBizLoadComboDataSourceRequest : global::ProtoBuf.IExtensible
  {
    public ComBizLoadComboDataSourceRequest() {}
    
    private string _col_name = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"col_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string col_name
    {
      get { return _col_name; }
      set { _col_name = value; }
    }
    private string _argu1 = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"argu1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string argu1
    {
      get { return _argu1; }
      set { _argu1 = value; }
    }
    private string _argu2 = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"argu2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string argu2
    {
      get { return _argu2; }
      set { _argu2 = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
