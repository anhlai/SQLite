//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: sample.proto
// Note: requires additional types generated from: mixed_model.proto
namespace IHIS.CloudConnector.Messaging
{

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPL2010U00GrdSpecimenRequest")]
  public partial class CPL2010U00GrdSpecimenRequest : global::ProtoBuf.IExtensible
  {
    public CPL2010U00GrdSpecimenRequest() {}
    
    private string _mJubsu_yn = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"mJubsu_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string mJubsu_yn
    {
      get { return _mJubsu_yn; }
      set { _mJubsu_yn = value; }
    }
    private string _order_date = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"order_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string order_date
    {
      get { return _order_date; }
      set { _order_date = value; }
    }
    private string _bunho = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"bunho", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string bunho
    {
      get { return _bunho; }
      set { _bunho = value; }
    }
    private string _gwa = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"gwa", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string gwa
    {
      get { return _gwa; }
      set { _gwa = value; }
    }
    private string _order_time = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"order_time", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string order_time
    {
      get { return _order_time; }
      set { _order_time = value; }
    }
    private string _doctor = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"doctor", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string doctor
    {
      get { return _doctor; }
      set { _doctor = value; }
    }
    private string _reser_date = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"reser_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string reser_date
    {
      get { return _reser_date; }
      set { _reser_date = value; }
    }
    private string _jubsu_date = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"jubsu_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string jubsu_date
    {
      get { return _jubsu_date; }
      set { _jubsu_date = value; }
    }
    private string _jubsu_time = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"jubsu_time", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string jubsu_time
    {
      get { return _jubsu_time; }
      set { _jubsu_time = value; }
    }
    private string _jubsuja = "";
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"jubsuja", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string jubsuja
    {
      get { return _jubsuja; }
      set { _jubsuja = value; }
    }
    private string _group_ser = "";
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"group_ser", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string group_ser
    {
      get { return _group_ser; }
      set { _group_ser = value; }
    }
    private string _reser_yn = "";
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"reser_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string reser_yn
    {
      get { return _reser_yn; }
      set { _reser_yn = value; }
    }
    private string _emergency_yn = "";
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"emergency_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string emergency_yn
    {
      get { return _emergency_yn; }
      set { _emergency_yn = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
