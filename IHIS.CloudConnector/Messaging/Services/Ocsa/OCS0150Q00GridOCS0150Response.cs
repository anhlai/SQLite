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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OCS0150Q00GridOCS0150Response")]
  public partial class OCS0150Q00GridOCS0150Response : global::ProtoBuf.IExtensible
  {
    public OCS0150Q00GridOCS0150Response() {}
    
    private readonly global::System.Collections.Generic.List<OCS0150Q00GridOCS0150Info> _grid_ocs0150_info = new global::System.Collections.Generic.List<OCS0150Q00GridOCS0150Info>();
    [global::ProtoBuf.ProtoMember(1, Name=@"grid_ocs0150_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<OCS0150Q00GridOCS0150Info> grid_ocs0150_info
    {
      get { return _grid_ocs0150_info; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
