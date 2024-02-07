using Castle.DynamicProxy;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Core.Utilities.Interceptors.AspectInterceptorSelector;

namespace Core.Utilities.Business.BusinessAspects.Autofac
{
    public class SecuredOperation
    {
        public class SecuredOperation : MethodInterception
        {
            private string[] _roles;
            private IHttpContextAccessor _httpContextAccessor;

            public SecuredOperation(string roles)
            {
                _roles = roles.Split(',');
                _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();

            }

            public object Messages { get; private set; }

            protected override void OnBefore(IInvocation invocation)
            {
                var roleClaims = _httpContextAccessor.HttpContext.User.ClaimRoles();
                foreach (var role in _roles)
                {
                    if (roleClaims.Contains(role))
                    {
                        return;
                    }
                }
                throw new Exception("Authorization Denied");
            }
        }
    }
}
