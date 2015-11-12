using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0103U12SetSameOrderDateGroupSerArgs : IContractArgs
	{
		private String _orderDate;
		private String _inputTab;
		private String _bunho;
		private String _inputDoctor;

		public String OrderDate
		{
			get { return this._orderDate; }
			set { this._orderDate = value; }
		}

		public String InputTab
		{
			get { return this._inputTab; }
			set { this._inputTab = value; }
		}

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String InputDoctor
		{
			get { return this._inputDoctor; }
			set { this._inputDoctor = value; }
		}

		public OCS0103U12SetSameOrderDateGroupSerArgs() { }

		public OCS0103U12SetSameOrderDateGroupSerArgs(String orderDate, String inputTab, String bunho, String inputDoctor)
		{
			this._orderDate = orderDate;
			this._inputTab = inputTab;
			this._bunho = bunho;
			this._inputDoctor = inputDoctor;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0103U12SetSameOrderDateGroupSerRequest();
		}
	}
}