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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OCSAPPROVEGrdOrderRequest")]
  public partial class OCSAPPROVEGrdOrderRequest : global::ProtoBuf.IExtensible
  {
    public OCSAPPROVEGrdOrderRequest() {}
    
    private string _pk_order = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"pk_order", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string pk_order
    {
      get { return _pk_order; }
      set { _pk_order = value; }
    }
    private string _input_tab = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"input_tab", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string input_tab
    {
      get { return _input_tab; }
      set { _input_tab = value; }
    }
    private string _instead_yn = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"instead_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string instead_yn
    {
      get { return _instead_yn; }
      set { _instead_yn = value; }
    }
    private string _approve_yn = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"approve_yn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string approve_yn
    {
      get { return _approve_yn; }
      set { _approve_yn = value; }
    }
    private string _prepost_gubun = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"prepost_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string prepost_gubun
    {
      get { return _prepost_gubun; }
      set { _prepost_gubun = value; }
    }
    private string _bunho = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"bunho", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string bunho
    {
      get { return _bunho; }
      set { _bunho = value; }
    }
    private string _jubsu_no = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"jubsu_no", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string jubsu_no
    {
      get { return _jubsu_no; }
      set { _jubsu_no = value; }
    }
    private string _naewon_date = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"naewon_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string naewon_date
    {
      get { return _naewon_date; }
      set { _naewon_date = value; }
    }
    private string _doctor = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"doctor", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string doctor
    {
      get { return _doctor; }
      set { _doctor = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
