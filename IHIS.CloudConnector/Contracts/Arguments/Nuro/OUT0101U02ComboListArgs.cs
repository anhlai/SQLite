using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class OUT0101U02ComboListArgs : IContractArgs
	{
		private String _sexCodeType;
		private String _bunhoCodeType;
		private String _telCodeType;
		private String _boninCodeType;

		public String SexCodeType
		{
			get { return this._sexCodeType; }
			set { this._sexCodeType = value; }
		}

		public String BunhoCodeType
		{
			get { return this._bunhoCodeType; }
			set { this._bunhoCodeType = value; }
		}

		public String TelCodeType
		{
			get { return this._telCodeType; }
			set { this._telCodeType = value; }
		}

		public String BoninCodeType
		{
			get { return this._boninCodeType; }
			set { this._boninCodeType = value; }
		}

		public OUT0101U02ComboListArgs() { }

		public OUT0101U02ComboListArgs(String sexCodeType, String bunhoCodeType, String telCodeType, String boninCodeType)
		{
			this._sexCodeType = sexCodeType;
			this._bunhoCodeType = bunhoCodeType;
			this._telCodeType = telCodeType;
			this._boninCodeType = boninCodeType;
		}

		public IExtensible GetRequestInstance()
		{
			return new OUT0101U02ComboListRequest();
		}
	}
}