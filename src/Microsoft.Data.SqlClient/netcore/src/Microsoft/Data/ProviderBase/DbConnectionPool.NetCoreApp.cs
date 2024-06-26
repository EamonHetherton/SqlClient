﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#if NETCOREAPP

using System.Diagnostics;
using Microsoft.Data.Common;
using Microsoft.Data.SqlClient;

namespace Microsoft.Data.ProviderBase
{
    internal sealed partial class DbConnectionPool
    {
        private bool IsBlockingPeriodEnabled()
        {
            var poolGroupConnectionOptions = _connectionPoolGroup.ConnectionOptions as SqlConnectionString;
            if (poolGroupConnectionOptions == null)
            {
                return true;
            }
            var policy = poolGroupConnectionOptions.PoolBlockingPeriod;

            switch (policy)
            {
                case PoolBlockingPeriod.Auto:
                    {
                        return !ADP.IsAzureSqlServerEndpoint(poolGroupConnectionOptions.DataSource);
                    }
                case PoolBlockingPeriod.AlwaysBlock:
                    {
                        return true; //Enabled
                    }
                case PoolBlockingPeriod.NeverBlock:
                    {
                        return false; //Disabled
                    }
                default:
                    {
                        //we should never get into this path.
                        Debug.Fail("Unknown PoolBlockingPeriod. Please specify explicit results in above switch case statement.");
                        return true;
                    }
            }
        }
    }
}

#endif
