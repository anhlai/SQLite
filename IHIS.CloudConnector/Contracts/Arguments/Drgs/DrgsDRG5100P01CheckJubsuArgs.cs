using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DrgsDRG5100P01CheckJubsuArgs : IContractArgs
	{
		private String _orderDate;
		private String _drgBunho;

		public String OrderDate
		{
			get { return this._orderDate; }
			set { this._orderDate = value; }
		}

		public String DrgBunho
		{
			get { return this._drgBunho; }
			set { this._drgBunho = value; }
		}

		public DrgsDRG5100P01CheckJubsuArgs() { }

		public DrgsDRG5100P01CheckJubsuArgs(String orderDate, String drgBunho)
		{
			this._orderDate = orderDate;
			this._drgBunho = drgBunho;
		}

		public IExtensible GetRequestInstance()
		{
			return new DrgsDRG5100P01CheckJubsuRequest();
		}
	}
}