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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SchsSCH0201U99ReserListResponse")]
  public partial class SchsSCH0201U99ReserListResponse : global::ProtoBuf.IExtensible
  {
    public SchsSCH0201U99ReserListResponse() {}
    
    private readonly global::System.Collections.Generic.List<SchsSCH0201U99ReserListInfo> _reser_list = new global::System.Collections.Generic.List<SchsSCH0201U99ReserListInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"reser_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<SchsSCH0201U99ReserListInfo> reser_list
    {
      get { return _reser_list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
