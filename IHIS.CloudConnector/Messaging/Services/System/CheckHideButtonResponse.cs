//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: input.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CheckHideButtonResponse")]
  public partial class CheckHideButtonResponse : global::ProtoBuf.IExtensible
  {
    public CheckHideButtonResponse() {}
    
    private readonly global::System.Collections.Generic.List<CheckHideButtonInfo> _dt = new global::System.Collections.Generic.List<CheckHideButtonInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"dt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CheckHideButtonInfo> dt
    {
      get { return _dt; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}