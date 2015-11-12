using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using NotApproveOrderCntInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.NotApproveOrderCntInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
	public class OCS1003P01GrdPatientArgs : IContractArgs
	{
		private String _naewonYn;
		private String _naewonDate;
		private String _reserYn;
		private String _doctor;
		private String _doctorModeYn;
		private String _bunho;
		private NotApproveOrderCntInfo _orderCnt;

		public String NaewonYn
		{
			get { return this._naewonYn; }
			set { this._naewonYn = value; }
		}

		public String NaewonDate
		{
			get { return this._naewonDate; }
			set { this._naewonDate = value; }
		}

		public String ReserYn
		{
			get { return this._reserYn; }
			set { this._reserYn = value; }
		}

		public String Doctor
		{
			get { return this._doctor; }
			set { this._doctor = value; }
		}

		public String DoctorModeYn
		{
			get { return this._doctorModeYn; }
			set { this._doctorModeYn = value; }
		}

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public NotApproveOrderCntInfo OrderCnt
		{
			get { return this._orderCnt; }
			set { this._orderCnt = value; }
		}

		public OCS1003P01GrdPatientArgs() { }

		public OCS1003P01GrdPatientArgs(String naewonYn, String naewonDate, String reserYn, String doctor, String doctorModeYn, String bunho, NotApproveOrderCntInfo orderCnt)
		{
			this._naewonYn = naewonYn;
			this._naewonDate = naewonDate;
			this._reserYn = reserYn;
			this._doctor = doctor;
			this._doctorModeYn = doctorModeYn;
			this._bunho = bunho;
			this._orderCnt = orderCnt;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS1003P01GrdPatientRequest();
		}
	}
}