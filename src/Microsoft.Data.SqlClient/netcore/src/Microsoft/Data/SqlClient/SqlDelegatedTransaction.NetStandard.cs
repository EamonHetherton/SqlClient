﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#if NETSTANDARD2_0

using System;
using System.Transactions;

namespace Microsoft.Data.SqlClient
{
    internal sealed partial class SqlDelegatedTransaction : IPromotableSinglePhaseNotification
    {
        // Get the server-side Global Transaction Id from the PromotedDTCToken
        // Skip first 4 bytes since they contain the version
        private Guid GetGlobalTxnIdentifierFromToken()
        {
            byte[] txnGuid = new byte[16];
            Array.Copy(_connection.PromotedDTCToken, _globalTransactionsTokenVersionSizeInBytes, // Skip the version
                txnGuid, 0, txnGuid.Length);
            return new Guid(txnGuid);
        }
    }
}

#endif
