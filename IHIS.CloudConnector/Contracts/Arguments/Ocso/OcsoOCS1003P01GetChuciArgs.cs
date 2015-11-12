using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
	public class OcsoOCS1003P01GetChuciArgs : IContractArgs
	{
		private String _codeType;
		private String _valuePoint;

		public String CodeType
		{
			get { return this._codeType; }
			set { this._codeType = value; }
		}

		public String ValuePoint
		{
			get { return this._valuePoint; }
			set { this._valuePoint = value; }
		}

		public OcsoOCS1003P01GetChuciArgs() { }

		public OcsoOCS1003P01GetChuciArgs(String codeType, String valuePoint)
		{
			this._codeType = codeType;
			this._valuePoint = valuePoint;
		}

		public IExtensible GetRequestInstance()
		{
			return new OcsoOCS1003P01GetChuciRequest();
		}
	}
}