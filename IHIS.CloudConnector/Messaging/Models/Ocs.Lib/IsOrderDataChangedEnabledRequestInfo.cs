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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"IsOrderDataChangedEnabledRequestInfo")]
  public partial class IsOrderDataChangedEnabledRequestInfo : global::ProtoBuf.IExtensible
  {
    public IsOrderDataChangedEnabledRequestInfo() {}
    
    private string _iud_gubun = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"iud_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string iud_gubun
    {
      get { return _iud_gubun; }
      set { _iud_gubun = value; }
    }
    private string _aioe_gubun = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"aioe_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string aioe_gubun
    {
      get { return _aioe_gubun; }
      set { _aioe_gubun = value; }
    }
    private string _pkocskey = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"pkocskey", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string pkocskey
    {
      get { return _pkocskey; }
      set { _pkocskey = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}