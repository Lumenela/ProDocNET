﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;
using Ninject;

namespace ProdocNET.Plumber
{
    public class NinjectResolver : NinjectScope, IDependencyResolver
    {
        private IKernel kernel;
        public NinjectResolver(IKernel kernel)
            : base(kernel)
        {
            kernel = kernel;
        }
        public IDependencyScope BeginScope()
        {
            return new NinjectScope(kernel.BeginBlock());
        }
    }
}