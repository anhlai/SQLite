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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DupCheckInputInpOrderRequestInfo")]
  public partial class DupCheckInputInpOrderRequestInfo : global::ProtoBuf.IExtensible
  {
    public DupCheckInputInpOrderRequestInfo() {}
    
    private string _bunho = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"bunho", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string bunho
    {
      get { return _bunho; }
      set { _bunho = value; }
    }
    private string _fkinp1001 = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"fkinp1001", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string fkinp1001
    {
      get { return _fkinp1001; }
      set { _fkinp1001 = value; }
    }
    private string _orderDate = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"orderDate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string orderDate
    {
      get { return _orderDate; }
      set { _orderDate = value; }
    }
    private string _hangmog_Code = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"hangmog_Code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string hangmog_Code
    {
      get { return _hangmog_Code; }
      set { _hangmog_Code = value; }
    }
    private string _hopeDate = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"hopeDate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string hopeDate
    {
      get { return _hopeDate; }
      set { _hopeDate = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}