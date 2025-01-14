﻿using System.Web.Mvc;

namespace FengTe.GamePlay.Web.Areas.UserManage
{
    public class UserManageAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "UserManage";
            }
        }
        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
             this.AreaName + "_Default",
             this.AreaName + "/{controller}/{action}/{id}",
             new { area = this.AreaName, controller = "Home", action = "Index", id = UrlParameter.Optional },
             new string[] { "FengTe.GamePlay.Web.Areas." + this.AreaName + ".Controllers" }
           );
        }
    }
}