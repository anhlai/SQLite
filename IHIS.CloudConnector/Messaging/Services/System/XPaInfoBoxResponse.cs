//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: XPaInfoBox.proto
namespace IHIS.CloudConnector.Messaging
{
    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name = @"XPaInfoBoxResponse")]
    public partial class XPaInfoBoxResponse : global::ProtoBuf.IExtensible
    {
        public XPaInfoBoxResponse() { }

        private readonly global::System.Collections.Generic.List<XPaInfoBoxInfo> _patient_info_item = new global::System.Collections.Generic.List<XPaInfoBoxInfo>();
        [global::ProtoBuf.ProtoMember(1, Name = @"patient_info_item", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<XPaInfoBoxInfo> patient_info_item
        {
            get { return _patient_info_item; }
        }

        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }
}
