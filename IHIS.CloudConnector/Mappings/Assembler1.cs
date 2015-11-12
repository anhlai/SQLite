namespace IHIS.CloudConnector
{
    using System;
    using System.Text;
    using System.Collections;
    using System.Collections.Generic;
    using Otis;

    public class Assembler : IAssembler<IHIS.CloudConnector.Messaging.FormGwaListRequest, IHIS.CloudConnector.Contracts.Arguments.System.FormGwaListArgs>, IAssembler<IHIS.CloudConnector.Contracts.Results.System.FormGwaListResult, IHIS.CloudConnector.Messaging.FormGwaListResponse>, IAssembler<IHIS.CloudConnector.Contracts.Models.System.FormGwaItemInfo, IHIS.CloudConnector.Messaging.FormGwaItemInfo>, IAssembler<IHIS.CloudConnector.Messaging.MainMenuRequest, IHIS.CloudConnector.Contracts.Arguments.System.MainMenuArgs>, IAssembler<IHIS.CloudConnector.Contracts.Results.System.MainMenuResult, IHIS.CloudConnector.Messaging.MainMenuResponse>, IAssembler<IHIS.CloudConnector.Contracts.Models.System.MainMenuItemInfo, IHIS.CloudConnector.Messaging.MainMenuItemInfo>
    {
                        
        IHIS.CloudConnector.Messaging.MainMenuRequest IAssembler<IHIS.CloudConnector.Messaging.MainMenuRequest, IHIS.CloudConnector.Contracts.Arguments.System.MainMenuArgs>.AssembleFrom(IHIS.CloudConnector.Contracts.Arguments.System.MainMenuArgs source)
        {
            IHIS.CloudConnector.Messaging.MainMenuRequest target = new IHIS.CloudConnector.Messaging.MainMenuRequest();
            target.msg_user_yn = (source.MsgUserYn).ToString();
            target.admin_user_yn = (source.AdminUserYn).ToString();
            return target;
        }
        
        void IAssembler<IHIS.CloudConnector.Messaging.MainMenuRequest, IHIS.CloudConnector.Contracts.Arguments.System.MainMenuArgs>.Assemble(IHIS.CloudConnector.Messaging.MainMenuRequest target, IHIS.CloudConnector.Contracts.Arguments.System.MainMenuArgs source)
        {
            target.msg_user_yn = (source.MsgUserYn).ToString();
            target.admin_user_yn = (source.AdminUserYn).ToString();
        }
        
        void IAssembler<IHIS.CloudConnector.Messaging.MainMenuRequest, IHIS.CloudConnector.Contracts.Arguments.System.MainMenuArgs>.Assemble(ref IHIS.CloudConnector.Messaging.MainMenuRequest target, ref IHIS.CloudConnector.Contracts.Arguments.System.MainMenuArgs source)
        {
            target.msg_user_yn = (source.MsgUserYn).ToString();
            target.admin_user_yn = (source.AdminUserYn).ToString();
        }
        
        List<IHIS.CloudConnector.Messaging.MainMenuRequest> IAssembler<IHIS.CloudConnector.Messaging.MainMenuRequest, IHIS.CloudConnector.Contracts.Arguments.System.MainMenuArgs>.ToList(IEnumerable<IHIS.CloudConnector.Contracts.Arguments.System.MainMenuArgs> source)
        {
            if ((source == null))
            {
                return null;
            }
            List<IHIS.CloudConnector.Messaging.MainMenuRequest> lst = new List<IHIS.CloudConnector.Messaging.MainMenuRequest>(10);
            IAssembler<IHIS.CloudConnector.Messaging.MainMenuRequest, IHIS.CloudConnector.Contracts.Arguments.System.MainMenuArgs> _this = this;
            foreach(IHIS.CloudConnector.Contracts.Arguments.System.MainMenuArgs srcItem in source){ lst.Add(_this.AssembleFrom(srcItem)); };
            return lst;
        }
        
        IHIS.CloudConnector.Messaging.MainMenuRequest[] IAssembler<IHIS.CloudConnector.Messaging.MainMenuRequest, IHIS.CloudConnector.Contracts.Arguments.System.MainMenuArgs>.ToArray(IEnumerable<IHIS.CloudConnector.Contracts.Arguments.System.MainMenuArgs> source)
        {
            if ((source == null))
            {
                return null;
            }
            IAssembler<IHIS.CloudConnector.Messaging.MainMenuRequest, IHIS.CloudConnector.Contracts.Arguments.System.MainMenuArgs> _this = this;
            return _this.ToList(source).ToArray();
        }
        
        IHIS.CloudConnector.Contracts.Results.System.MainMenuResult IAssembler<IHIS.CloudConnector.Contracts.Results.System.MainMenuResult, IHIS.CloudConnector.Messaging.MainMenuResponse>.AssembleFrom(IHIS.CloudConnector.Messaging.MainMenuResponse source)
        {
            IHIS.CloudConnector.Contracts.Results.System.MainMenuResult target = new IHIS.CloudConnector.Contracts.Results.System.MainMenuResult();
            this.TransformToList(target.MenuItem, source.menu_item);
            return target;
        }
        
        void IAssembler<IHIS.CloudConnector.Contracts.Results.System.MainMenuResult, IHIS.CloudConnector.Messaging.MainMenuResponse>.Assemble(IHIS.CloudConnector.Contracts.Results.System.MainMenuResult target, IHIS.CloudConnector.Messaging.MainMenuResponse source)
        {
            this.TransformToList(target.MenuItem, source.menu_item);
        }
        
        void IAssembler<IHIS.CloudConnector.Contracts.Results.System.MainMenuResult, IHIS.CloudConnector.Messaging.MainMenuResponse>.Assemble(ref IHIS.CloudConnector.Contracts.Results.System.MainMenuResult target, ref IHIS.CloudConnector.Messaging.MainMenuResponse source)
        {
            this.TransformToList(target.MenuItem, source.menu_item);
        }
        
        List<IHIS.CloudConnector.Contracts.Results.System.MainMenuResult> IAssembler<IHIS.CloudConnector.Contracts.Results.System.MainMenuResult, IHIS.CloudConnector.Messaging.MainMenuResponse>.ToList(IEnumerable<IHIS.CloudConnector.Messaging.MainMenuResponse> source)
        {
            if ((source == null))
            {
                return null;
            }
            List<IHIS.CloudConnector.Contracts.Results.System.MainMenuResult> lst = new List<IHIS.CloudConnector.Contracts.Results.System.MainMenuResult>(10);
            IAssembler<IHIS.CloudConnector.Contracts.Results.System.MainMenuResult, IHIS.CloudConnector.Messaging.MainMenuResponse> _this = this;
            foreach(IHIS.CloudConnector.Messaging.MainMenuResponse srcItem in source){ lst.Add(_this.AssembleFrom(srcItem)); };
            return lst;
        }
        
        IHIS.CloudConnector.Contracts.Results.System.MainMenuResult[] IAssembler<IHIS.CloudConnector.Contracts.Results.System.MainMenuResult, IHIS.CloudConnector.Messaging.MainMenuResponse>.ToArray(IEnumerable<IHIS.CloudConnector.Messaging.MainMenuResponse> source)
        {
            if ((source == null))
            {
                return null;
            }
            IAssembler<IHIS.CloudConnector.Contracts.Results.System.MainMenuResult, IHIS.CloudConnector.Messaging.MainMenuResponse> _this = this;
            return _this.ToList(source).ToArray();
        }
        
        IHIS.CloudConnector.Contracts.Models.System.MainMenuItemInfo IAssembler<IHIS.CloudConnector.Contracts.Models.System.MainMenuItemInfo, IHIS.CloudConnector.Messaging.MainMenuItemInfo>.AssembleFrom(IHIS.CloudConnector.Messaging.MainMenuItemInfo source)
        {
            IHIS.CloudConnector.Contracts.Models.System.MainMenuItemInfo target = new IHIS.CloudConnector.Contracts.Models.System.MainMenuItemInfo();
            target.GroupId = (source.group_id).ToString();
            target.GroupName = (source.group_name).ToString();
            target.SystemId = (source.system_id).ToString();
            target.SystemName = (source.system_name).ToString();
            target.DisplayGroupId = (source.display_group_id).ToString();
            target.DisplayGroupName = (source.display_group_name).ToString();
            target.Description = (source.description).ToString();
            return target;
        }
        
        void IAssembler<IHIS.CloudConnector.Contracts.Models.System.MainMenuItemInfo, IHIS.CloudConnector.Messaging.MainMenuItemInfo>.Assemble(IHIS.CloudConnector.Contracts.Models.System.MainMenuItemInfo target, IHIS.CloudConnector.Messaging.MainMenuItemInfo source)
        {
            target.GroupId = (source.group_id).ToString();
            target.GroupName = (source.group_name).ToString();
            target.SystemId = (source.system_id).ToString();
            target.SystemName = (source.system_name).ToString();
            target.DisplayGroupId = (source.display_group_id).ToString();
            target.DisplayGroupName = (source.display_group_name).ToString();
            target.Description = (source.description).ToString();
        }
        
        void IAssembler<IHIS.CloudConnector.Contracts.Models.System.MainMenuItemInfo, IHIS.CloudConnector.Messaging.MainMenuItemInfo>.Assemble(ref IHIS.CloudConnector.Contracts.Models.System.MainMenuItemInfo target, ref IHIS.CloudConnector.Messaging.MainMenuItemInfo source)
        {
            target.GroupId = (source.group_id).ToString();
            target.GroupName = (source.group_name).ToString();
            target.SystemId = (source.system_id).ToString();
            target.SystemName = (source.system_name).ToString();
            target.DisplayGroupId = (source.display_group_id).ToString();
            target.DisplayGroupName = (source.display_group_name).ToString();
            target.Description = (source.description).ToString();
        }
        
        List<IHIS.CloudConnector.Contracts.Models.System.MainMenuItemInfo> IAssembler<IHIS.CloudConnector.Contracts.Models.System.MainMenuItemInfo, IHIS.CloudConnector.Messaging.MainMenuItemInfo>.ToList(IEnumerable<IHIS.CloudConnector.Messaging.MainMenuItemInfo> source)
        {
            if ((source == null))
            {
                return null;
            }
            List<IHIS.CloudConnector.Contracts.Models.System.MainMenuItemInfo> lst = new List<IHIS.CloudConnector.Contracts.Models.System.MainMenuItemInfo>(10);
            IAssembler<IHIS.CloudConnector.Contracts.Models.System.MainMenuItemInfo, IHIS.CloudConnector.Messaging.MainMenuItemInfo> _this = this;
            foreach(IHIS.CloudConnector.Messaging.MainMenuItemInfo srcItem in source){ lst.Add(_this.AssembleFrom(srcItem)); };
            return lst;
        }
        
        IHIS.CloudConnector.Contracts.Models.System.MainMenuItemInfo[] IAssembler<IHIS.CloudConnector.Contracts.Models.System.MainMenuItemInfo, IHIS.CloudConnector.Messaging.MainMenuItemInfo>.ToArray(IEnumerable<IHIS.CloudConnector.Messaging.MainMenuItemInfo> source)
        {
            if ((source == null))
            {
                return null;
            }
            IAssembler<IHIS.CloudConnector.Contracts.Models.System.MainMenuItemInfo, IHIS.CloudConnector.Messaging.MainMenuItemInfo> _this = this;
            return _this.ToList(source).ToArray();
        }
        
        
        IHIS.CloudConnector.Messaging.FormGwaListRequest IAssembler<IHIS.CloudConnector.Messaging.FormGwaListRequest, IHIS.CloudConnector.Contracts.Arguments.System.FormGwaListArgs>.AssembleFrom(IHIS.CloudConnector.Contracts.Arguments.System.FormGwaListArgs source)
        {
            IHIS.CloudConnector.Messaging.FormGwaListRequest target = new IHIS.CloudConnector.Messaging.FormGwaListRequest();
            target.user_id = (source.UserId).ToString();
            return target;
        }
        
        void IAssembler<IHIS.CloudConnector.Messaging.FormGwaListRequest, IHIS.CloudConnector.Contracts.Arguments.System.FormGwaListArgs>.Assemble(IHIS.CloudConnector.Messaging.FormGwaListRequest target, IHIS.CloudConnector.Contracts.Arguments.System.FormGwaListArgs source)
        {
            target.user_id = (source.UserId).ToString();
        }
        
        void IAssembler<IHIS.CloudConnector.Messaging.FormGwaListRequest, IHIS.CloudConnector.Contracts.Arguments.System.FormGwaListArgs>.Assemble(ref IHIS.CloudConnector.Messaging.FormGwaListRequest target, ref IHIS.CloudConnector.Contracts.Arguments.System.FormGwaListArgs source)
        {
            target.user_id = (source.UserId).ToString();
        }
        
        List<IHIS.CloudConnector.Messaging.FormGwaListRequest> IAssembler<IHIS.CloudConnector.Messaging.FormGwaListRequest, IHIS.CloudConnector.Contracts.Arguments.System.FormGwaListArgs>.ToList(IEnumerable<IHIS.CloudConnector.Contracts.Arguments.System.FormGwaListArgs> source)
        {
            if ((source == null))
            {
                return null;
            }
            List<IHIS.CloudConnector.Messaging.FormGwaListRequest> lst = new List<IHIS.CloudConnector.Messaging.FormGwaListRequest>(10);
            IAssembler<IHIS.CloudConnector.Messaging.FormGwaListRequest, IHIS.CloudConnector.Contracts.Arguments.System.FormGwaListArgs> _this = this;
            foreach(IHIS.CloudConnector.Contracts.Arguments.System.FormGwaListArgs srcItem in source){ lst.Add(_this.AssembleFrom(srcItem)); };
            return lst;
        }
        
        IHIS.CloudConnector.Messaging.FormGwaListRequest[] IAssembler<IHIS.CloudConnector.Messaging.FormGwaListRequest, IHIS.CloudConnector.Contracts.Arguments.System.FormGwaListArgs>.ToArray(IEnumerable<IHIS.CloudConnector.Contracts.Arguments.System.FormGwaListArgs> source)
        {
            if ((source == null))
            {
                return null;
            }
            IAssembler<IHIS.CloudConnector.Messaging.FormGwaListRequest, IHIS.CloudConnector.Contracts.Arguments.System.FormGwaListArgs> _this = this;
            return _this.ToList(source).ToArray();
        }

        IHIS.CloudConnector.Contracts.Models.System.FormGwaItemInfo IAssembler<IHIS.CloudConnector.Contracts.Models.System.FormGwaItemInfo, IHIS.CloudConnector.Messaging.FormGwaItemInfo>.AssembleFrom(IHIS.CloudConnector.Messaging.FormGwaItemInfo source)
        {
            IHIS.CloudConnector.Contracts.Models.System.FormGwaItemInfo target = new IHIS.CloudConnector.Contracts.Models.System.FormGwaItemInfo();
            target.Doctor = (source.doctor).ToString();
            target.DoctorGwa = (source.doctor_gwa).ToString();
            target.GwaName = (source.gwa_name).ToString();
            return target;
        }

        void IAssembler<IHIS.CloudConnector.Contracts.Models.System.FormGwaItemInfo, IHIS.CloudConnector.Messaging.FormGwaItemInfo>.Assemble(IHIS.CloudConnector.Contracts.Models.System.FormGwaItemInfo target, IHIS.CloudConnector.Messaging.FormGwaItemInfo source)
        {
            target.Doctor = (source.doctor).ToString();
            target.DoctorGwa = (source.doctor_gwa).ToString();
            target.GwaName = (source.gwa_name).ToString();
        }

        void IAssembler<IHIS.CloudConnector.Contracts.Models.System.FormGwaItemInfo, IHIS.CloudConnector.Messaging.FormGwaItemInfo>.Assemble(ref IHIS.CloudConnector.Contracts.Models.System.FormGwaItemInfo target, ref IHIS.CloudConnector.Messaging.FormGwaItemInfo source)
        {
            target.Doctor = (source.doctor).ToString();
            target.DoctorGwa = (source.doctor_gwa).ToString();
            target.GwaName = (source.gwa_name).ToString();
        }

        List<IHIS.CloudConnector.Contracts.Models.System.FormGwaItemInfo> IAssembler<IHIS.CloudConnector.Contracts.Models.System.FormGwaItemInfo, IHIS.CloudConnector.Messaging.FormGwaItemInfo>.ToList(IEnumerable<IHIS.CloudConnector.Messaging.FormGwaItemInfo> source)
        {
            if ((source == null))
            {
                return null;
            }
            List<IHIS.CloudConnector.Contracts.Models.System.FormGwaItemInfo> lst = new List<IHIS.CloudConnector.Contracts.Models.System.FormGwaItemInfo>(10);
            IAssembler<IHIS.CloudConnector.Contracts.Models.System.FormGwaItemInfo, IHIS.CloudConnector.Messaging.FormGwaItemInfo> _this = this;
            foreach (IHIS.CloudConnector.Messaging.FormGwaItemInfo srcItem in source) { lst.Add(_this.AssembleFrom(srcItem)); };
            return lst;
        }

        IHIS.CloudConnector.Contracts.Models.System.FormGwaItemInfo[] IAssembler<IHIS.CloudConnector.Contracts.Models.System.FormGwaItemInfo, IHIS.CloudConnector.Messaging.FormGwaItemInfo>.ToArray(IEnumerable<IHIS.CloudConnector.Messaging.FormGwaItemInfo> source)
        {
            if ((source == null))
            {
                return null;
            }
            IAssembler<IHIS.CloudConnector.Contracts.Models.System.FormGwaItemInfo, IHIS.CloudConnector.Messaging.FormGwaItemInfo> _this = this;
            return _this.ToList(source).ToArray();
        }

        IHIS.CloudConnector.Contracts.Results.System.FormGwaListResult IAssembler<IHIS.CloudConnector.Contracts.Results.System.FormGwaListResult, IHIS.CloudConnector.Messaging.FormGwaListResponse>.AssembleFrom(IHIS.CloudConnector.Messaging.FormGwaListResponse source)
        {
            IHIS.CloudConnector.Contracts.Results.System.FormGwaListResult target = new IHIS.CloudConnector.Contracts.Results.System.FormGwaListResult();
            this.TransformToList(target.ItemInfo, source.item_info);
            return target;
        }
        
        void IAssembler<IHIS.CloudConnector.Contracts.Results.System.FormGwaListResult, IHIS.CloudConnector.Messaging.FormGwaListResponse>.Assemble(IHIS.CloudConnector.Contracts.Results.System.FormGwaListResult target, IHIS.CloudConnector.Messaging.FormGwaListResponse source)
        {
            this.TransformToList(target.ItemInfo, source.item_info);
        }
        
        void IAssembler<IHIS.CloudConnector.Contracts.Results.System.FormGwaListResult, IHIS.CloudConnector.Messaging.FormGwaListResponse>.Assemble(ref IHIS.CloudConnector.Contracts.Results.System.FormGwaListResult target, ref IHIS.CloudConnector.Messaging.FormGwaListResponse source)
        {
            this.TransformToList(target.ItemInfo, source.item_info);
        }
        
        List<IHIS.CloudConnector.Contracts.Results.System.FormGwaListResult> IAssembler<IHIS.CloudConnector.Contracts.Results.System.FormGwaListResult, IHIS.CloudConnector.Messaging.FormGwaListResponse>.ToList(IEnumerable<IHIS.CloudConnector.Messaging.FormGwaListResponse> source)
        {
            if ((source == null))
            {
                return null;
            }
            List<IHIS.CloudConnector.Contracts.Results.System.FormGwaListResult> lst = new List<IHIS.CloudConnector.Contracts.Results.System.FormGwaListResult>(10);
            IAssembler<IHIS.CloudConnector.Contracts.Results.System.FormGwaListResult, IHIS.CloudConnector.Messaging.FormGwaListResponse> _this = this;
            foreach(IHIS.CloudConnector.Messaging.FormGwaListResponse srcItem in source){ lst.Add(_this.AssembleFrom(srcItem)); };
            return lst;
        }
        
        IHIS.CloudConnector.Contracts.Results.System.FormGwaListResult[] IAssembler<IHIS.CloudConnector.Contracts.Results.System.FormGwaListResult, IHIS.CloudConnector.Messaging.FormGwaListResponse>.ToArray(IEnumerable<IHIS.CloudConnector.Messaging.FormGwaListResponse> source)
        {
            if ((source == null))
            {
                return null;
            }
            IAssembler<IHIS.CloudConnector.Contracts.Results.System.FormGwaListResult, IHIS.CloudConnector.Messaging.FormGwaListResponse> _this = this;
            return _this.ToList(source).ToArray();
        }                

        private T Transform<T, S>(T target, S source)
        {
            if ((source == null))
            {
                return default(T);
            }
            IAssembler<T, S> converter = this as IAssembler<T, S>;
            if ((converter == null))
            {
                string msg = string.Format("Assembler for transformation [{0} -> {1}] is not configured", typeof(S).FullName, typeof(T).FullName);
                throw new OtisException(msg);
            }
            return converter.AssembleFrom(source);
        }

        private T Transform<T, S>(T target, S source, T nullValue)
        {
            if ((source == null))
            {
                return nullValue;
            }
            IAssembler<T, S> converter = this as IAssembler<T, S>;
            if ((converter == null))
            {
                string msg = string.Format("Assembler for transformation [{0} -> {1}] is not configured", typeof(S).FullName, typeof(T).FullName);
                throw new OtisException(msg);
            }
            return converter.AssembleFrom(source);
        }

        private T[] TransformToArray<T, S>(T[] dummy, IEnumerable<S> source)
        {
            if ((source == null))
            {
                return null;
            }
            List<T> lst = new List<T>(10);
            foreach (S srcItem in source) { lst.Add(Transform(default(T), srcItem)); };
            return lst.ToArray();
        }

        private void TransformToList<T, S>(ICollection<T> target, IEnumerable<S> source)
        {
            if ((source == null))
            {
                return;
            }
            target.Clear();
            foreach (S srcItem in source) { target.Add(Transform(default(T), srcItem)); };
        }      
    }
}
