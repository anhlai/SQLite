//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: xrts_model.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"XRT0201U00DefaultJearyoItemInfo")]
  public partial class XRT0201U00DefaultJearyoItemInfo : global::ProtoBuf.IExtensible
  {
    public XRT0201U00DefaultJearyoItemInfo() {}
    
    private string _set_hangmog_code = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"set_hangmog_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string set_hangmog_code
    {
      get { return _set_hangmog_code; }
      set { _set_hangmog_code = value; }
    }
    private string _suryang = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"suryang", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string suryang
    {
      get { return _suryang; }
      set { _suryang = value; }
    }
    private string _danui = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"danui", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string danui
    {
      get { return _danui; }
      set { _danui = value; }
    }
    private string _danui_name = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"danui_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string danui_name
    {
      get { return _danui_name; }
      set { _danui_name = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}