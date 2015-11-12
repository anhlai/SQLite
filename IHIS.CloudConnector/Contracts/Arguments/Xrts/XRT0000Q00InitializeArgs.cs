using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
	public class XRT0000Q00InitializeArgs : IContractArgs
	{
		private String _sortLayOrder;
		private String _bunhoLayOrder;
		private String _jundalPartLayOrder;

		public String SortLayOrder
		{
			get { return this._sortLayOrder; }
			set { this._sortLayOrder = value; }
		}

		public String BunhoLayOrder
		{
			get { return this._bunhoLayOrder; }
			set { this._bunhoLayOrder = value; }
		}

		public String JundalPartLayOrder
		{
			get { return this._jundalPartLayOrder; }
			set { this._jundalPartLayOrder = value; }
		}

		public XRT0000Q00InitializeArgs() { }

		public XRT0000Q00InitializeArgs(String sortLayOrder, String bunhoLayOrder, String jundalPartLayOrder)
		{
			this._sortLayOrder = sortLayOrder;
			this._bunhoLayOrder = bunhoLayOrder;
			this._jundalPartLayOrder = jundalPartLayOrder;
		}

		public IExtensible GetRequestInstance()
		{
			return new XRT0000Q00InitializeRequest();
		}
	}
}