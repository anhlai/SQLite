using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class UdpHelperSendMsgToID2Args : IContractArgs
	{
		private String _senderId;
		private String _sendSeq;

		public String SenderId
		{
			get { return this._senderId; }
			set { this._senderId = value; }
		}

		public String SendSeq
		{
			get { return this._sendSeq; }
			set { this._sendSeq = value; }
		}

		public UdpHelperSendMsgToID2Args() { }

		public UdpHelperSendMsgToID2Args(String senderId, String sendSeq)
		{
			this._senderId = senderId;
			this._sendSeq = sendSeq;
		}

		public IExtensible GetRequestInstance()
		{
			return new UdpHelperSendMsgToID2Request();
		}
	}
}