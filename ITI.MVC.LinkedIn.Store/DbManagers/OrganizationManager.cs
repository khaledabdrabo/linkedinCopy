﻿using ITI.MVC.LinkedIn.DbLayer.Entities;
using ITI.MVC.LinkedIn.DbManager;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.MVC.LinkedIn.Store.DbManagers
{
    public class OrganizationManager : DbManager<Organization>
    {
        public OrganizationManager(DbContext ctx) : base(ctx)
        {
        }

 
    }
}
