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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SchsSCH0201U99DateScheduleListRequest")]
  public partial class SchsSCH0201U99DateScheduleListRequest : global::ProtoBuf.IExtensible
  {
    public SchsSCH0201U99DateScheduleListRequest() {}
    
    private string _f_start_date = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"f_start_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string f_start_date
    {
      get { return _f_start_date; }
      set { _f_start_date = value; }
    }
    private string _f_jundal_table = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"f_jundal_table", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string f_jundal_table
    {
      get { return _f_jundal_table; }
      set { _f_jundal_table = value; }
    }
    private string _f_jundal_part = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"f_jundal_part", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string f_jundal_part
    {
      get { return _f_jundal_part; }
      set { _f_jundal_part = value; }
    }
    private string _f_hangmog_code = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"f_hangmog_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string f_hangmog_code
    {
      get { return _f_hangmog_code; }
      set { _f_hangmog_code = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}