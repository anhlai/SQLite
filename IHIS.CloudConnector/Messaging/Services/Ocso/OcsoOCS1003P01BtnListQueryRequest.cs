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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OcsoOCS1003P01BtnListQueryRequest")]
  public partial class OcsoOCS1003P01BtnListQueryRequest : global::ProtoBuf.IExtensible
  {
    public OcsoOCS1003P01BtnListQueryRequest() {}
    
    private string _bunho = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"bunho", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string bunho
    {
      get { return _bunho; }
      set { _bunho = value; }
    }
    private string _gwa = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"gwa", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string gwa
    {
      get { return _gwa; }
      set { _gwa = value; }
    }
    private string _naewon_date = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"naewon_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string naewon_date
    {
      get { return _naewon_date; }
      set { _naewon_date = value; }
    }
    private string _fkout1001 = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"fkout1001", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string fkout1001
    {
      get { return _fkout1001; }
      set { _fkout1001 = value; }
    }
    private string _query_gubun = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"query_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string query_gubun
    {
      get { return _query_gubun; }
      set { _query_gubun = value; }
    }
    private string _input_gubun = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"input_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string input_gubun
    {
      get { return _input_gubun; }
      set { _input_gubun = value; }
    }
    private string _bunho_2 = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"bunho_2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string bunho_2
    {
      get { return _bunho_2; }
      set { _bunho_2 = value; }
    }
    private string _naewon_date_2 = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"naewon_date_2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string naewon_date_2
    {
      get { return _naewon_date_2; }
      set { _naewon_date_2 = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
