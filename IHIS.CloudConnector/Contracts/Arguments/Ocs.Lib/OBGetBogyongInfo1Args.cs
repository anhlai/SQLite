using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class OBGetBogyongInfo1Args : IContractArgs
	{
		private String _bogyongCode;

		public String BogyongCode
		{
			get { return this._bogyongCode; }
			set { this._bogyongCode = value; }
		}

		public OBGetBogyongInfo1Args() { }

		public OBGetBogyongInfo1Args(String bogyongCode)
		{
			this._bogyongCode = bogyongCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new OBGetBogyongInfo1Request();
		}
	}
}