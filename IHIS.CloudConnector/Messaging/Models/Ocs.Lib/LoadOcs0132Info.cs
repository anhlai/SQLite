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

  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LoadOcs0132Info")]
  public partial class LoadOcs0132Info : global::ProtoBuf.IExtensible
  {
    public LoadOcs0132Info() {}
    
    private string _code_type = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"code_type", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string code_type
    {
      get { return _code_type; }
      set { _code_type = value; }
    }
    private string _code = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string code
    {
      get { return _code; }
      set { _code = value; }
    }
    private string _code_name = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"code_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string code_name
    {
      get { return _code_name; }
      set { _code_name = value; }
    }
    private string _value_point = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"value_point", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string value_point
    {
      get { return _value_point; }
      set { _value_point = value; }
    }
    private string _sort_key = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"sort_key", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string sort_key
    {
      get { return _sort_key; }
      set { _sort_key = value; }
    }
    private string _group_key = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"group_key", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string group_key
    {
      get { return _group_key; }
      set { _group_key = value; }
    }
    private string _ment = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"ment", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ment
    {
      get { return _ment; }
      set { _ment = value; }
    }
    private string _sys_date = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"sys_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string sys_date
    {
      get { return _sys_date; }
      set { _sys_date = value; }
    }
    private string _upd_id = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"upd_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string upd_id
    {
      get { return _upd_id; }
      set { _upd_id = value; }
    }
    private string _upd_date = "";
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"upd_date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string upd_date
    {
      get { return _upd_date; }
      set { _upd_date = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}