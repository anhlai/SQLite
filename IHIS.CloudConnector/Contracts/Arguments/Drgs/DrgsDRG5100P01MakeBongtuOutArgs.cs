using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DrgsDRG5100P01MakeBongtuOutArgs : IContractArgs
	{
		private String _iSysDate;
		private String _iUserId;
		private String _iOrderDate;
		private String _iJubsuDate;
		private String _iJubsuTime;
		private String _iDrgBunho;
		private String _iWonyoiOrderYn;
		private String _iJubsuYn;
		private String _iGyunbonYn;

		public String ISysDate
		{
			get { return this._iSysDate; }
			set { this._iSysDate = value; }
		}

		public String IUserId
		{
			get { return this._iUserId; }
			set { this._iUserId = value; }
		}

		public String IOrderDate
		{
			get { return this._iOrderDate; }
			set { this._iOrderDate = value; }
		}

		public String IJubsuDate
		{
			get { return this._iJubsuDate; }
			set { this._iJubsuDate = value; }
		}

		public String IJubsuTime
		{
			get { return this._iJubsuTime; }
			set { this._iJubsuTime = value; }
		}

		public String IDrgBunho
		{
			get { return this._iDrgBunho; }
			set { this._iDrgBunho = value; }
		}

		public String IWonyoiOrderYn
		{
			get { return this._iWonyoiOrderYn; }
			set { this._iWonyoiOrderYn = value; }
		}

		public String IJubsuYn
		{
			get { return this._iJubsuYn; }
			set { this._iJubsuYn = value; }
		}

		public String IGyunbonYn
		{
			get { return this._iGyunbonYn; }
			set { this._iGyunbonYn = value; }
		}

		public DrgsDRG5100P01MakeBongtuOutArgs() { }

		public DrgsDRG5100P01MakeBongtuOutArgs(String iSysDate, String iUserId, String iOrderDate, String iJubsuDate, String iJubsuTime, String iDrgBunho, String iWonyoiOrderYn, String iJubsuYn, String iGyunbonYn)
		{
			this._iSysDate = iSysDate;
			this._iUserId = iUserId;
			this._iOrderDate = iOrderDate;
			this._iJubsuDate = iJubsuDate;
			this._iJubsuTime = iJubsuTime;
			this._iDrgBunho = iDrgBunho;
			this._iWonyoiOrderYn = iWonyoiOrderYn;
			this._iJubsuYn = iJubsuYn;
			this._iGyunbonYn = iGyunbonYn;
		}

		public IExtensible GetRequestInstance()
		{
			return new DrgsDRG5100P01MakeBongtuOutRequest();
		}
	}
}