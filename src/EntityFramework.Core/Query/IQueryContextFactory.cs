// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.Framework.Logging;

namespace Microsoft.Data.Entity.Query
{
    public interface IQueryContextFactory
    {
        ILogger Logger { get; }
        QueryContext CreateQueryContext();
    }
}
