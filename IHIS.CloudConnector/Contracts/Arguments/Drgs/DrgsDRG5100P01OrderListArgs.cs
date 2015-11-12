using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DrgsDRG5100P01OrderListArgs : IContractArgs
	{
		private String _orderDate;
		private String _drgBunho;
		private String _gubun;
		private String _wonyoiYn;
		private String _bunho;

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

		public String Gubun
		{
			get { return this._gubun; }
			set { this._gubun = value; }
		}

		public String WonyoiYn
		{
			get { return this._wonyoiYn; }
			set { this._wonyoiYn = value; }
		}

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public DrgsDRG5100P01OrderListArgs() { }

		public DrgsDRG5100P01OrderListArgs(String orderDate, String drgBunho, String gubun, String wonyoiYn, String bunho)
		{
			this._orderDate = orderDate;
			this._drgBunho = drgBunho;
			this._gubun = gubun;
			this._wonyoiYn = wonyoiYn;
			this._bunho = bunho;
		}

		public IExtensible GetRequestInstance()
		{
			return new DrgsDRG5100P01OrderListRequest();
		}
	}
}