//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: adma_model.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ADM108UTvwSystemListItemInfo")]
  public partial class ADM108UTvwSystemListItemInfo : global::ProtoBuf.IExtensible
  {
    public ADM108UTvwSystemListItemInfo() {}
    
    private string _pgm_nm = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"pgm_nm", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string pgm_nm
    {
      get { return _pgm_nm; }
      set { _pgm_nm = value; }
    }
    private string _sys_id = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"sys_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string sys_id
    {
      get { return _sys_id; }
      set { _sys_id = value; }
    }
    private string _sys_nm = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"sys_nm", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string sys_nm
    {
      get { return _sys_nm; }
      set { _sys_nm = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
