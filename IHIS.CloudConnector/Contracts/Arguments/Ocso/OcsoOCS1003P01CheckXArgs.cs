using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
	public class OcsoOCS1003P01CheckXArgs : IContractArgs
	{
		private String _actionDoctor;
		private String _bunho;
		private String _naewonKey;

		public String ActionDoctor
		{
			get { return this._actionDoctor; }
			set { this._actionDoctor = value; }
		}

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String NaewonKey
		{
			get { return this._naewonKey; }
			set { this._naewonKey = value; }
		}

		public OcsoOCS1003P01CheckXArgs() { }

		public OcsoOCS1003P01CheckXArgs(String actionDoctor, String bunho, String naewonKey)
		{
			this._actionDoctor = actionDoctor;
			this._bunho = bunho;
			this._naewonKey = naewonKey;
		}

		public IExtensible GetRequestInstance()
		{
			return new OcsoOCS1003P01CheckXRequest();
		}
	}
}