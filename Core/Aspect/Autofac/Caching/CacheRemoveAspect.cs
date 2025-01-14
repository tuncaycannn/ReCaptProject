﻿using Castle.DynamicProxy;
using Core.CrossCuttingConcerns;
using Core.Utilities.Interceptors;
using Microsoft.Extensions.DependencyInjection;
using Core.Utilities.IoC;

namespace Core.Aspect.Autofac.Caching
{
    public class CacheRemoveAspect : MethodInterception
    {
        private string _pattern;
        private ICacheManager _cacheManager;

        public CacheRemoveAspect(string pattern)
        {
            _pattern = pattern;
            _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
        }

        protected override void OnSuccess(IInvocation invocation)
        {
            _cacheManager.RemoveByPattern(_pattern);
        }
    }
}
