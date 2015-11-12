using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
	public class AdmMessageCallArgs : IContractArgs
	{
		private String _senderId;
		private String _recieverGubun;
		private String _recieverId;
		private String _title;
		private String _data;
		private String _userId;

		public String SenderId
		{
			get { return this._senderId; }
			set { this._senderId = value; }
		}

		public String RecieverGubun
		{
			get { return this._recieverGubun; }
			set { this._recieverGubun = value; }
		}

		public String RecieverId
		{
			get { return this._recieverId; }
			set { this._recieverId = value; }
		}

		public String Title
		{
			get { return this._title; }
			set { this._title = value; }
		}

		public String Data
		{
			get { return this._data; }
			set { this._data = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public AdmMessageCallArgs() { }

		public AdmMessageCallArgs(String senderId, String recieverGubun, String recieverId, String title, String data, String userId)
		{
			this._senderId = senderId;
			this._recieverGubun = recieverGubun;
			this._recieverId = recieverId;
			this._title = title;
			this._data = data;
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new AdmMessageCallRequest();
		}
	}
}