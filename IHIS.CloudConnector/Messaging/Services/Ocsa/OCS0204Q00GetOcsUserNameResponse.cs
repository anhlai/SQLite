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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OCS0204Q00GetOcsUserNameResponse")]
  public partial class OCS0204Q00GetOcsUserNameResponse : global::ProtoBuf.IExtensible
  {
    public OCS0204Q00GetOcsUserNameResponse() {}
    
    private string _memb_name = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"memb_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string memb_name
    {
      get { return _memb_name; }
      set { _memb_name = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
