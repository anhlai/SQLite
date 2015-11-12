using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0103U16GrdSlipHangmogArgs : IContractArgs
	{
		private String _mode;
		private String _xrayCodeYn;
		private String _slipCode;
		private String _orderDate;
		private String _inputTab;
		private String _xrayBuwi;
		private String _wonnaeDrgYn;
		private String _searchWord;

		public String Mode
		{
			get { return this._mode; }
			set { this._mode = value; }
		}

		public String XrayCodeYn
		{
			get { return this._xrayCodeYn; }
			set { this._xrayCodeYn = value; }
		}

		public String SlipCode
		{
			get { return this._slipCode; }
			set { this._slipCode = value; }
		}

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

		public String XrayBuwi
		{
			get { return this._xrayBuwi; }
			set { this._xrayBuwi = value; }
		}

		public String WonnaeDrgYn
		{
			get { return this._wonnaeDrgYn; }
			set { this._wonnaeDrgYn = value; }
		}

		public String SearchWord
		{
			get { return this._searchWord; }
			set { this._searchWord = value; }
		}

		public OCS0103U16GrdSlipHangmogArgs() { }

		public OCS0103U16GrdSlipHangmogArgs(String mode, String xrayCodeYn, String slipCode, String orderDate, String inputTab, String xrayBuwi, String wonnaeDrgYn, String searchWord)
		{
			this._mode = mode;
			this._xrayCodeYn = xrayCodeYn;
			this._slipCode = slipCode;
			this._orderDate = orderDate;
			this._inputTab = inputTab;
			this._xrayBuwi = xrayBuwi;
			this._wonnaeDrgYn = wonnaeDrgYn;
			this._searchWord = searchWord;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0103U16GrdSlipHangmogRequest();
		}
	}
}