﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Filters;

namespace Storage.Filters
{
    public class ZeroDivideHandlerFilter : Attribute, IExceptionFilter
    {

      
        public bool AllowMultiple
        {
            get
            {
                return false;
            }
        }

        public Task ExecuteExceptionFilterAsync(
            HttpActionExecutedContext actionExecutedContext,
            CancellationToken cancellationToken)
        {
            if(actionExecutedContext.Exception !=null
                && actionExecutedContext.Exception is DivideByZeroException)
            {
                actionExecutedContext.Response = actionExecutedContext.Request.CreateErrorResponse(
                    HttpStatusCode.BadRequest, "Деление на ноль");
            }
            return Task.FromResult<object>(null);
        }

       
    }
}