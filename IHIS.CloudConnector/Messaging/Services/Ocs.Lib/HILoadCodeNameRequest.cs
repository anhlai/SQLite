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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HILoadCodeNameRequest")]
  public partial class HILoadCodeNameRequest : global::ProtoBuf.IExtensible
  {
    public HILoadCodeNameRequest() {}
    
    private string _order_gubun = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"order_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string order_gubun
    {
      get { return _order_gubun; }
      set { _order_gubun = value; }
    }
    private string _specimen_code = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"specimen_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string specimen_code
    {
      get { return _specimen_code; }
      set { _specimen_code = value; }
    }
    private string _jusa = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"jusa", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string jusa
    {
      get { return _jusa; }
      set { _jusa = value; }
    }
    private string _pay = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"pay", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string pay
    {
      get { return _pay; }
      set { _pay = value; }
    }
    private string _order_gubun_bas = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"order_gubun_bas", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string order_gubun_bas
    {
      get { return _order_gubun_bas; }
      set { _order_gubun_bas = value; }
    }
    private string _bogyong_code = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"bogyong_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string bogyong_code
    {
      get { return _bogyong_code; }
      set { _bogyong_code = value; }
    }
    private string _jusa_spd_gubun = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"jusa_spd_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string jusa_spd_gubun
    {
      get { return _jusa_spd_gubun; }
      set { _jusa_spd_gubun = value; }
    }
    private string _jundal_part_out = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"jundal_part_out", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string jundal_part_out
    {
      get { return _jundal_part_out; }
      set { _jundal_part_out = value; }
    }
    private string _jundal_part_inp = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"jundal_part_inp", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string jundal_part_inp
    {
      get { return _jundal_part_inp; }
      set { _jundal_part_inp = value; }
    }
    private string _ord_danui = "";
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"ord_danui", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ord_danui
    {
      get { return _ord_danui; }
      set { _ord_danui = value; }
    }
    private string _hangmog_code = "";
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"hangmog_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string hangmog_code
    {
      get { return _hangmog_code; }
      set { _hangmog_code = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
