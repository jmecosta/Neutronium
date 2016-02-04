﻿using MVVM.HTML.Core.V8JavascriptObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVVM.HTML.Core.HTMLBinding
{
    public interface IJSCBridgeCache
    {
        void Cache(object key, IJSCSGlue value);

        void CacheLocal(object key, IJSCSGlue value);

        void RegisterInSession(object key, Action<IJSCSGlue> Continue);

        IJSCSGlue GetCached(object key);

        IJSCSGlue GetCached(IJavascriptObject key);

        IJSCSGlue GetCachedOrCreateBasic(IJavascriptObject key, Type iTargetType);
    }
}