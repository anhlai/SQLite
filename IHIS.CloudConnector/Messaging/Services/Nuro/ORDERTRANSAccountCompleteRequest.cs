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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ORDERTRANSAccountCompleteRequest")]
  public partial class ORDERTRANSAccountCompleteRequest : global::ProtoBuf.IExtensible
  {
    public ORDERTRANSAccountCompleteRequest() {}
    
    private string _hosp_code = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"hosp_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string hosp_code
    {
      get { return _hosp_code; }
      set { _hosp_code = value; }
    }
    private string _bunho = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"bunho", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string bunho
    {
      get { return _bunho; }
      set { _bunho = value; }
    }
    private string _acting_date = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"acting_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string acting_date
    {
      get { return _acting_date; }
      set { _acting_date = value; }
    }
    private string _gubun = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string gubun
    {
      get { return _gubun; }
      set { _gubun = value; }
    }
    private string _gwa = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"gwa", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string gwa
    {
      get { return _gwa; }
      set { _gwa = value; }
    }
    private string _doctor = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"doctor", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string doctor
    {
      get { return _doctor; }
      set { _doctor = value; }
    }
    private string _chojae = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"chojae", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string chojae
    {
      get { return _chojae; }
      set { _chojae = value; }
    }
    private string _sunab_date = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"sunab_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string sunab_date
    {
      get { return _sunab_date; }
      set { _sunab_date = value; }
    }
    private string _io_gubun = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"io_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string io_gubun
    {
      get { return _io_gubun; }
      set { _io_gubun = value; }
    }
    private readonly global::System.Collections.Generic.List<ORDERTRANSAccountCompleteInfo> _acc_complete_item = new global::System.Collections.Generic.List<ORDERTRANSAccountCompleteInfo>();
    [global::ProtoBuf.ProtoMember(10, Name=@"acc_complete_item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ORDERTRANSAccountCompleteInfo> acc_complete_item
    {
      get { return _acc_complete_item; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
