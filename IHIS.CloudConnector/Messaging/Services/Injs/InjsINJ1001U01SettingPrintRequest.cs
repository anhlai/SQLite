//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: service.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"InjsINJ1001U01SettingPrintRequest")]
  public partial class InjsINJ1001U01SettingPrintRequest : global::ProtoBuf.IExtensible
  {
    public InjsINJ1001U01SettingPrintRequest() {}
    
    private string _user_id = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"user_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string user_id
    {
      get { return _user_id; }
      set { _user_id = value; }
    }
    private string _b_print_name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"b_print_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string b_print_name
    {
      get { return _b_print_name; }
      set { _b_print_name = value; }
    }
    private string _ip_addr;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"ip_addr", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string ip_addr
    {
      get { return _ip_addr; }
      set { _ip_addr = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
