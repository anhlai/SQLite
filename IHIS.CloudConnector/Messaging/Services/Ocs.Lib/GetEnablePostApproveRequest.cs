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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GetEnablePostApproveRequest")]
  public partial class GetEnablePostApproveRequest : global::ProtoBuf.IExtensible
  {
    public GetEnablePostApproveRequest() {}
    
    private GetEnablePostApproveInfo _aprove_info = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"aprove_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public GetEnablePostApproveInfo aprove_info
    {
      get { return _aprove_info; }
      set { _aprove_info = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
