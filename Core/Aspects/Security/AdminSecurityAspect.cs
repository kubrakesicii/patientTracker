﻿using Castle.DynamicProxy;
using Core.Enums;
using Core.Exceptions;
using Core.Token;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Aspects.Security
{
    public class AdminSecurityAspect : MethodInterception
    {
        private readonly IUserService _userService;


        public AdminSecurityAspect()
        {
            Priority = 1;
            _userService = ServiceTool.ServiceProvider.GetService<IUserService>();
        }


        public override void OnBefore(IInvocation invocation)
        {
            if (!_userService.IsAuthenticated || _userService.PersonId == 0)
                throw new AuthenticationException("AuthenticationError");

            if ( PersonType.Admin != _userService.PersonType)
                throw new AuthenticationException("AuthenticationError");
            
        }
    }
}