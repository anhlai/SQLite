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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SchsSCH0201U99ExecIUDRequest")]
  public partial class SchsSCH0201U99ExecIUDRequest : global::ProtoBuf.IExtensible
  {
    public SchsSCH0201U99ExecIUDRequest() {}
    
    private string _i_iud_gubun = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"i_iud_gubun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string i_iud_gubun
    {
      get { return _i_iud_gubun; }
      set { _i_iud_gubun = value; }
    }
    private string _i_fksch0201 = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"i_fksch0201", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string i_fksch0201
    {
      get { return _i_fksch0201; }
      set { _i_fksch0201 = value; }
    }
    private string _i_reser_date = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"i_reser_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string i_reser_date
    {
      get { return _i_reser_date; }
      set { _i_reser_date = value; }
    }
    private string _i_reser_time = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"i_reser_time", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string i_reser_time
    {
      get { return _i_reser_time; }
      set { _i_reser_time = value; }
    }
    private string _i_input_id = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"i_input_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string i_input_id
    {
      get { return _i_input_id; }
      set { _i_input_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}