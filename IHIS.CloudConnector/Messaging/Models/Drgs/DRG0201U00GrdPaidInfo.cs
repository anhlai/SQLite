//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: input.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DRG0201U00GrdPaidInfo")]
  public partial class DRG0201U00GrdPaidInfo : global::ProtoBuf.IExtensible
  {
    public DRG0201U00GrdPaidInfo() {}
    
    private string _drg_bunho = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"drg_bunho", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string drg_bunho
    {
      get { return _drg_bunho; }
      set { _drg_bunho = value; }
    }
    private string _bunho = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"bunho", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string bunho
    {
      get { return _bunho; }
      set { _bunho = value; }
    }
    private string _order_date = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"order_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string order_date
    {
      get { return _order_date; }
      set { _order_date = value; }
    }
    private string _joje_yn = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"joje_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string joje_yn
    {
      get { return _joje_yn; }
      set { _joje_yn = value; }
    }
    private string _suname = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"suname", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string suname
    {
      get { return _suname; }
      set { _suname = value; }
    }
    private string _order_remark = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"order_remark", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string order_remark
    {
      get { return _order_remark; }
      set { _order_remark = value; }
    }
    private string _drg_remark = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"drg_remark", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string drg_remark
    {
      get { return _drg_remark; }
      set { _drg_remark = value; }
    }
    private string _trial_yn = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"trial_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string trial_yn
    {
      get { return _trial_yn; }
      set { _trial_yn = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
