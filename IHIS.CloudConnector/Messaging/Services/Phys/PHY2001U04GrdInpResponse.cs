//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: input.proto
// Note: requires additional types generated from: import.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PHY2001U04GrdInpResponse")]
  public partial class PHY2001U04GrdInpResponse : global::ProtoBuf.IExtensible
  {
    public PHY2001U04GrdInpResponse() {}
    
    private readonly global::System.Collections.Generic.List<PHY2001U04GrdInpInfo> _grd_inp_item = new global::System.Collections.Generic.List<PHY2001U04GrdInpInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"grd_inp_item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<PHY2001U04GrdInpInfo> grd_inp_item
    {
      get { return _grd_inp_item; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
