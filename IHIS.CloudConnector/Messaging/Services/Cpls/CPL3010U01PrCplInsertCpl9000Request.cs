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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPL3010U01PrCplInsertCpl9000Request")]
  public partial class CPL3010U01PrCplInsertCpl9000Request : global::ProtoBuf.IExtensible
  {
    public CPL3010U01PrCplInsertCpl9000Request() {}
    
    private string _user_id = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"user_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string user_id
    {
      get { return _user_id; }
      set { _user_id = value; }
    }
    private readonly global::System.Collections.Generic.List<CPL3010U01PrCplInsertCpl9000Info> _pr_cpl_lst = new global::System.Collections.Generic.List<CPL3010U01PrCplInsertCpl9000Info>();
    [global::ProtoBuf.ProtoMember(2, Name=@"pr_cpl_lst", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CPL3010U01PrCplInsertCpl9000Info> pr_cpl_lst
    {
      get { return _pr_cpl_lst; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
