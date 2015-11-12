using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class PrOcsConvertHangmogCodeArgs : IContractArgs
	{
		private String _convClass;
		private String _gubun;
		private String _hangmogCode;
		private String _bunho;
		private String _orderDate;

		public String ConvClass
		{
			get { return this._convClass; }
			set { this._convClass = value; }
		}

		public String Gubun
		{
			get { return this._gubun; }
			set { this._gubun = value; }
		}

		public String HangmogCode
		{
			get { return this._hangmogCode; }
			set { this._hangmogCode = value; }
		}

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String OrderDate
		{
			get { return this._orderDate; }
			set { this._orderDate = value; }
		}

		public PrOcsConvertHangmogCodeArgs() { }

		public PrOcsConvertHangmogCodeArgs(String convClass, String gubun, String hangmogCode, String bunho, String orderDate)
		{
			this._convClass = convClass;
			this._gubun = gubun;
			this._hangmogCode = hangmogCode;
			this._bunho = bunho;
			this._orderDate = orderDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new PrOcsConvertHangmogCodeRequest();
		}
	}
}