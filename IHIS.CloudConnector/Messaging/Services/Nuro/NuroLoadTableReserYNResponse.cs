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

    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"NuroLoadTableReserYNResponse")]
    public partial class NuroLoadTableReserYNResponse : global::ProtoBuf.IExtensible
    {
        public NuroLoadTableReserYNResponse() { }

        private readonly global::System.Collections.Generic.List<DataStringListItemInfo> _jubsu_time = new global::System.Collections.Generic.List<DataStringListItemInfo>();
        [global::ProtoBuf.ProtoMember(1, Name = @"jubsu_time", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<DataStringListItemInfo> jubsu_time
        {
            get { return _jubsu_time; }
        }

        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }
  
}