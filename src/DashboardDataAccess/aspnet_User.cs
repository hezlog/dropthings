﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;

namespace Dropthings.DataAccess
{
    public partial class aspnet_User
    {
        public void Detach()
        {
            this._Pages = new EntitySet<Page>(new Action<Page>(this.attach_Pages), new Action<Page>(this.detach_Pages));
            this._UserSetting = default(EntityRef<UserSetting>);
            this._Tokens = new EntitySet<Token>(new Action<Token>(this.attach_Tokens), new Action<Token>(this.detach_Tokens));
            this._aspnet_UsersInRoles = new EntitySet<aspnet_UsersInRole>(new Action<aspnet_UsersInRole>(this.attach_aspnet_UsersInRoles), new Action<aspnet_UsersInRole>(this.detach_aspnet_UsersInRoles));
            this._RoleTemplates = new EntitySet<RoleTemplate>(new Action<RoleTemplate>(this.attach_RoleTemplates), new Action<RoleTemplate>(this.detach_RoleTemplates));			
        }
    }
}