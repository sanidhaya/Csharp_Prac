﻿using Microsoft.AspNetCore.Builder;

namespace ILogging
{
    public static class OptionsVerbMiddlewareExtensions
    {
        public static IApplicationBuilder UseOptionsVerbHandler(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<Middleware.OptionsVerbMiddleware>();
        }
    }
}
