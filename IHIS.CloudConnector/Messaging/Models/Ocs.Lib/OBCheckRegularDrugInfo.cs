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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OBCheckRegularDrugInfo")]
  public partial class OBCheckRegularDrugInfo : global::ProtoBuf.IExtensible
  {
    public OBCheckRegularDrugInfo() {}
    
    private string _suryang = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"suryang", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string suryang
    {
      get { return _suryang; }
      set { _suryang = value; }
    }
    private string _danui = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"danui", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string danui
    {
      get { return _danui; }
      set { _danui = value; }
    }
    private string _dv = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"dv", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string dv
    {
      get { return _dv; }
      set { _dv = value; }
    }
    private string _dv_time = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"dv_time", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string dv_time
    {
      get { return _dv_time; }
      set { _dv_time = value; }
    }
    private string _jusa = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"jusa", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string jusa
    {
      get { return _jusa; }
      set { _jusa = value; }
    }
    private string _bogyong_code = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"bogyong_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string bogyong_code
    {
      get { return _bogyong_code; }
      set { _bogyong_code = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
