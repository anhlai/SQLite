//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: schs_service.proto
// Note: requires additional types generated from: schs_model.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SchsSCH0201Q01SCH0001ComboListRequest")]
  public partial class SchsSCH0201Q01SCH0001ComboListRequest : global::ProtoBuf.IExtensible
  {
    public SchsSCH0201Q01SCH0001ComboListRequest() {}
    
    private string _jundal_table = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"jundal_table", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string jundal_table
    {
      get { return _jundal_table; }
      set { _jundal_table = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
