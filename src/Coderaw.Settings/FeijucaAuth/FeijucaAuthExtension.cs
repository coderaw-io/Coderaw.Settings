﻿using Coderaw.Settings.Models;
using Feijuca.Auth.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace Coderaw.Settings.FeijucaAuth
{
    public static class FeijucaAuthExtension
    {
        public static IServiceCollection AddApiAuthentication(this IServiceCollection services, FeijucaAuthSettings settings)
        {
            services.AddHttpContextAccessor();
            services.AddKeyCloakAuth(settings.Client, settings.ServerSettings, [settings.Realm]);

            return services;
        }
    }
}