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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SCH0201U10LayReserInfoResponse")]
  public partial class SCH0201U10LayReserInfoResponse : global::ProtoBuf.IExtensible
  {
    public SCH0201U10LayReserInfoResponse() {}
    
    private readonly global::System.Collections.Generic.List<SCH0201U10LayReserInfo> _lay_list = new global::System.Collections.Generic.List<SCH0201U10LayReserInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"lay_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<SCH0201U10LayReserInfo> lay_list
    {
      get { return _lay_list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
