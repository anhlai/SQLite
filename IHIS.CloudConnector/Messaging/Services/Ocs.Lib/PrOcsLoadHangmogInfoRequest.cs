//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: service.proto
// Note: requires additional types generated from: import.proto
namespace IHIS.CloudConnector.Messaging
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PrOcsLoadHangmogInfoRequest")]
  public partial class PrOcsLoadHangmogInfoRequest : global::ProtoBuf.IExtensible
  {
    public PrOcsLoadHangmogInfoRequest() {}
    
    private string _app_date = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"app_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string app_date
    {
      get { return _app_date; }
      set { _app_date = value; }
    }
    private string _input_part = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"input_part", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string input_part
    {
      get { return _input_part; }
      set { _input_part = value; }
    }
    private string _input_gwa = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"input_gwa", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string input_gwa
    {
      get { return _input_gwa; }
      set { _input_gwa = value; }
    }
    private string _hangmog_code = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"hangmog_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string hangmog_code
    {
      get { return _hangmog_code; }
      set { _hangmog_code = value; }
    }
    private string _input_tab = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"input_tab", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string input_tab
    {
      get { return _input_tab; }
      set { _input_tab = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}