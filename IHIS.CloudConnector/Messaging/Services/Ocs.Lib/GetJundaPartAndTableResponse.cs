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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GetJundaPartAndTableResponse")]
  public partial class GetJundaPartAndTableResponse : global::ProtoBuf.IExtensible
  {
    public GetJundaPartAndTableResponse() {}
    
    private bool _exe_result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"exe_result", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool exe_result
    {
      get { return _exe_result; }
      set { _exe_result = value; }
    }
    private string _jundal_part_out = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"jundal_part_out", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string jundal_part_out
    {
      get { return _jundal_part_out; }
      set { _jundal_part_out = value; }
    }
    private string _jundal_part_inp = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"jundal_part_inp", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string jundal_part_inp
    {
      get { return _jundal_part_inp; }
      set { _jundal_part_inp = value; }
    }
    private string _jundal_table_out = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"jundal_table_out", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string jundal_table_out
    {
      get { return _jundal_table_out; }
      set { _jundal_table_out = value; }
    }
    private string _jundal_table_inp = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"jundal_table_inp", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string jundal_table_inp
    {
      get { return _jundal_table_inp; }
      set { _jundal_table_inp = value; }
    }
    private string _move_part = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"move_part", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string move_part
    {
      get { return _move_part; }
      set { _move_part = value; }
    }
    private string _flag = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"flag", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string flag
    {
      get { return _flag; }
      set { _flag = value; }
    }
    private string _msg = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"msg", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string msg
    {
      get { return _msg; }
      set { _msg = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
