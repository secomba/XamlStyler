﻿// © Xavalon. All rights reserved.

using System;

namespace Xavalon.XamlStyler.Core.Parser
{
    [Flags]
    public enum ContentTypeEnum
    {
        None = 0,
        SingleLineTextOnly = 1,
        MultiLineTextOnly = 2,
        Mixed = 4,
    }
}