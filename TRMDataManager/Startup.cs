﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(TRMDataManager.Startup))]

namespace TRMDataManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}