using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class GetBogyongInfo3Args : IContractArgs
	{
		private String _bogyongCode;
		private String _bogyongGubun;

		public String BogyongCode
		{
			get { return this._bogyongCode; }
			set { this._bogyongCode = value; }
		}

		public String BogyongGubun
		{
			get { return this._bogyongGubun; }
			set { this._bogyongGubun = value; }
		}

		public GetBogyongInfo3Args() { }

		public GetBogyongInfo3Args(String bogyongCode, String bogyongGubun)
		{
			this._bogyongCode = bogyongCode;
			this._bogyongGubun = bogyongGubun;
		}

		public IExtensible GetRequestInstance()
		{
			return new GetBogyongInfo3Request();
		}
	}
}