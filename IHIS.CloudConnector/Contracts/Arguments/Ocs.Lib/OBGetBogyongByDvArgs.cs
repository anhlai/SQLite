using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class OBGetBogyongByDvArgs : IContractArgs
	{
		private String _bogyongCode;

		public String BogyongCode
		{
			get { return this._bogyongCode; }
			set { this._bogyongCode = value; }
		}

		public OBGetBogyongByDvArgs() { }

		public OBGetBogyongByDvArgs(String bogyongCode)
		{
			this._bogyongCode = bogyongCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new OBGetBogyongByDvRequest();
		}
	}
}