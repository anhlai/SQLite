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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AbleInsteadOrderResponse")]
  public partial class AbleInsteadOrderResponse : global::ProtoBuf.IExtensible
  {
    public AbleInsteadOrderResponse() {}
    
    private string _ret_val = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ret_val", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ret_val
    {
      get { return _ret_val; }
      set { _ret_val = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
