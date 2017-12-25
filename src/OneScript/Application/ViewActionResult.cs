﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ScriptEngine.Machine;
using ScriptEngine.Machine.Contexts;

namespace OneScript.WebHost.Application
{
    [ContextClass("РезультатДействияСтраница")]
    public class ViewActionResult : AutoContext<ViewActionResult>, IObjectWrapper
    {
        private ViewResult _result = new ViewResult();

        [ContextProperty("ИмяШаблона")]
        public string ViewName { get=>_result.ViewName; set=>_result.ViewName = value; }

        [ContextProperty("ТипСодержимого")]
        public string ContentType { get => _result.ContentType; set => _result.ContentType = value; }

        [ContextProperty("ТипСодержимого")]
        public int StatusCode { get => _result.StatusCode??200; set => _result.StatusCode = value; }
        
        public object UnderlyingObject => _result;

        [ScriptConstructor]
        public static ViewActionResult Constructor()
        {
            return new ViewActionResult();
        }
    }
}