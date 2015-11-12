using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuri
{
	public class NuriNUR1016U00NurAlegyMappingArgs : IContractArgs
	{
		private String _bunho;
		private String _tableId;
		private String _userId;

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String TableId
		{
			get { return this._tableId; }
			set { this._tableId = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public NuriNUR1016U00NurAlegyMappingArgs() { }

		public NuriNUR1016U00NurAlegyMappingArgs(String bunho, String tableId, String userId)
		{
			this._bunho = bunho;
			this._tableId = tableId;
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuriNUR1016U00NurAlegyMappingRequest();
		}
	}
}