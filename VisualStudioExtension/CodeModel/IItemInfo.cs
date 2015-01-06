﻿using System;
using System.Collections.Generic;
using Typewriter.CodeModel.Attributes;

namespace Typewriter.CodeModel
{
    public interface IItemInfo
    {
        object Parent { get; }

        [Property("string Name", "The name of the $context")]
        string Name { get; }

        [Property("string FullName", "The namespace and name of the $context")]
        string FullName { get; }

        [Property("collection Attributes", "All attributes defined on the $context")]
        ICollection<IAttributeInfo> Attributes { get; }
    }
}