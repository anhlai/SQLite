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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DrgsDRG5100P01OrderJungboInfo")]
  public partial class DrgsDRG5100P01OrderJungboInfo : global::ProtoBuf.IExtensible
  {
    public DrgsDRG5100P01OrderJungboInfo() {}
    
    private string _seq_1 = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"seq_1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string seq_1
    {
      get { return _seq_1; }
      set { _seq_1 = value; }
    }
    private string _seq_2 = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"seq_2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string seq_2
    {
      get { return _seq_2; }
      set { _seq_2 = value; }
    }
    private string _text_1 = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"text_1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string text_1
    {
      get { return _text_1; }
      set { _text_1 = value; }
    }
    private string _text_2 = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"text_2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string text_2
    {
      get { return _text_2; }
      set { _text_2 = value; }
    }
    private string _text_3 = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"text_3", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string text_3
    {
      get { return _text_3; }
      set { _text_3 = value; }
    }
    private string _remark = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"remark", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string remark
    {
      get { return _remark; }
      set { _remark = value; }
    }
    private string _bar_drg_bunho = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"bar_drg_bunho", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string bar_drg_bunho
    {
      get { return _bar_drg_bunho; }
      set { _bar_drg_bunho = value; }
    }
    private string _bunho = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"bunho", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string bunho
    {
      get { return _bunho; }
      set { _bunho = value; }
    }
    private DrgsDRG5100P01JungboInfo _jungbo_info = null;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"jungbo_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public DrgsDRG5100P01JungboInfo jungbo_info
    {
      get { return _jungbo_info; }
      set { _jungbo_info = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
