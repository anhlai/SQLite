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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OCS1003P01GetUserOptionAndOrderCountRequest")]
  public partial class OCS1003P01GetUserOptionAndOrderCountRequest : global::ProtoBuf.IExtensible
  {
    public OCS1003P01GetUserOptionAndOrderCountRequest() {}
    
    private GetUserOptionInfo _user_option = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"user_option", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public GetUserOptionInfo user_option
    {
      get { return _user_option; }
      set { _user_option = value; }
    }
    private GetOrderCountInfo _order_count = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"order_count", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public GetOrderCountInfo order_count
    {
      get { return _order_count; }
      set { _order_count = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
