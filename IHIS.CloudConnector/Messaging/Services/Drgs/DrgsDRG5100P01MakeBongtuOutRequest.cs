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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DrgsDRG5100P01MakeBongtuOutRequest")]
  public partial class DrgsDRG5100P01MakeBongtuOutRequest : global::ProtoBuf.IExtensible
  {
    public DrgsDRG5100P01MakeBongtuOutRequest() {}
    
    private string _i_sys_date = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"i_sys_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string i_sys_date
    {
      get { return _i_sys_date; }
      set { _i_sys_date = value; }
    }
    private string _i_user_id = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"i_user_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string i_user_id
    {
      get { return _i_user_id; }
      set { _i_user_id = value; }
    }
    private string _i_order_date = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"i_order_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string i_order_date
    {
      get { return _i_order_date; }
      set { _i_order_date = value; }
    }
    private string _i_jubsu_date = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"i_jubsu_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string i_jubsu_date
    {
      get { return _i_jubsu_date; }
      set { _i_jubsu_date = value; }
    }
    private string _i_jubsu_time = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"i_jubsu_time", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string i_jubsu_time
    {
      get { return _i_jubsu_time; }
      set { _i_jubsu_time = value; }
    }
    private string _i_drg_bunho = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"i_drg_bunho", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string i_drg_bunho
    {
      get { return _i_drg_bunho; }
      set { _i_drg_bunho = value; }
    }
    private string _i_wonyoi_order_yn = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"i_wonyoi_order_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string i_wonyoi_order_yn
    {
      get { return _i_wonyoi_order_yn; }
      set { _i_wonyoi_order_yn = value; }
    }
    private string _i_jubsu_yn = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"i_jubsu_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string i_jubsu_yn
    {
      get { return _i_jubsu_yn; }
      set { _i_jubsu_yn = value; }
    }
    private string _i_gyunbon_yn = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"i_gyunbon_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string i_gyunbon_yn
    {
      get { return _i_gyunbon_yn; }
      set { _i_gyunbon_yn = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
