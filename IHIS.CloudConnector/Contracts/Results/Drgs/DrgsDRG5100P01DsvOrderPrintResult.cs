using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Contracts.Models.Drgs;

namespace IHIS.CloudConnector.Contracts.Results.Drgs
{
	public class DrgsDRG5100P01DsvOrderPrintResult : AbstractContractResult
	{
		private String _retVal;
		private DrgsDRG5100P01LoadChebangPrintInfo _chebangPrintItem;
		private DrgsDRG5100P01LoadMakayJungboInfo _makayJungbo;
		private List<DrgsDRG5100P01DrgwonneaOWnCurListInfo> _drgwonneaOwnCur = new List<DrgsDRG5100P01DrgwonneaOWnCurListInfo>();
		private List<DrgsDRG5100P01WnSerialQryListItemInfo> _wnSerialItem = new List<DrgsDRG5100P01WnSerialQryListItemInfo>();

		public String RetVal
		{
			get { return this._retVal; }
			set { this._retVal = value; }
		}

		public DrgsDRG5100P01LoadChebangPrintInfo ChebangPrintItem
		{
			get { return this._chebangPrintItem; }
			set { this._chebangPrintItem = value; }
		}

		public DrgsDRG5100P01LoadMakayJungboInfo MakayJungbo
		{
			get { return this._makayJungbo; }
			set { this._makayJungbo = value; }
		}

		public List<DrgsDRG5100P01DrgwonneaOWnCurListInfo> DrgwonneaOwnCur
		{
			get { return this._drgwonneaOwnCur; }
			set { this._drgwonneaOwnCur = value; }
		}

		public List<DrgsDRG5100P01WnSerialQryListItemInfo> WnSerialItem
		{
			get { return this._wnSerialItem; }
			set { this._wnSerialItem = value; }
		}

		public DrgsDRG5100P01DsvOrderPrintResult() { }

	}
}