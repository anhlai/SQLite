using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class GetEnablePostApproveInfo
	{
		private String _ioGubun;
		private String _approveDoctor;

		public String IoGubun
		{
			get { return this._ioGubun; }
			set { this._ioGubun = value; }
		}

		public String ApproveDoctor
		{
			get { return this._approveDoctor; }
			set { this._approveDoctor = value; }
		}

		public GetEnablePostApproveInfo() { }

		public GetEnablePostApproveInfo(String ioGubun, String approveDoctor)
		{
			this._ioGubun = ioGubun;
			this._approveDoctor = approveDoctor;
		}

	}
}