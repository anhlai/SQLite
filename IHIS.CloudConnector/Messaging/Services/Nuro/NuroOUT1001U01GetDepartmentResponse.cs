//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: nuro_service.proto
// Note: requires additional types generated from: nuro_model.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NuroOUT1001U01GetDepartmentResponse")]
  public partial class NuroOUT1001U01GetDepartmentResponse : global::ProtoBuf.IExtensible
  {
    public NuroOUT1001U01GetDepartmentResponse() {}
    
    private readonly global::System.Collections.Generic.List<NuroOUT1001U01GetDepartmentInfo> _dept_item = new global::System.Collections.Generic.List<NuroOUT1001U01GetDepartmentInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"dept_item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NuroOUT1001U01GetDepartmentInfo> dept_item
    {
      get { return _dept_item; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
