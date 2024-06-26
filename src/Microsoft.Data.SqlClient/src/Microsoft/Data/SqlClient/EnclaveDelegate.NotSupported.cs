﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#if NETSTANDARD2_0

using System;
using System.Collections.Concurrent;

namespace Microsoft.Data.SqlClient
{
    internal sealed partial class EnclaveDelegate
    {
        internal byte[] GetSerializedAttestationParameters(
            SqlEnclaveAttestationParameters sqlEnclaveAttestationParameters, string enclaveType)
        {
            throw new PlatformNotSupportedException();
        }

        /// <summary>
        /// Create a new enclave session
        /// </summary>
        /// <param name="attestationProtocol">attestation protocol</param>
        /// <param name="enclaveType">enclave type</param>
        /// <param name="enclaveSessionParameters">The set of parameters required for enclave session.</param>
        /// <param name="attestationInfo">attestation info from SQL Server</param>
        /// <param name="attestationParameters">attestation parameters</param>
        /// <param name="customData">A set of extra data needed for attesting the enclave.</param>
        /// <param name="customDataLength">The length of the extra data needed for attesting the enclave.</param>
        /// <param name="isRetry">Indicates if this is a retry from a failed call.</param>
        internal void CreateEnclaveSession(SqlConnectionAttestationProtocol attestationProtocol, string enclaveType, EnclaveSessionParameters enclaveSessionParameters,
            byte[] attestationInfo, SqlEnclaveAttestationParameters attestationParameters, byte[] customData, int customDataLength, bool isRetry)
        {
            throw new PlatformNotSupportedException();
        }

        internal void GetEnclaveSession(SqlConnectionAttestationProtocol attestationProtocol, string enclaveType, EnclaveSessionParameters enclaveSessionParameters, bool generateCustomData, bool isRetry, out SqlEnclaveSession sqlEnclaveSession, out byte[] customData, out int customDataLength)
        {
            throw new PlatformNotSupportedException();
        }

        internal EnclavePackage GenerateEnclavePackage(SqlConnectionAttestationProtocol attestationProtocol, ConcurrentDictionary<int, SqlTceCipherInfoEntry> keysTobeSentToEnclave, string queryText, string enclaveType, EnclaveSessionParameters enclaveSessionParameters, SqlConnection connection, SqlCommand command)
        {
            throw new PlatformNotSupportedException();
        }

        internal void InvalidateEnclaveSession(SqlConnectionAttestationProtocol attestationProtocol, string enclaveType, EnclaveSessionParameters enclaveSessionParameters, SqlEnclaveSession enclaveSession)
        {
            throw new PlatformNotSupportedException();
        }

        internal SqlEnclaveAttestationParameters GetAttestationParameters(SqlConnectionAttestationProtocol attestationProtocol, string enclaveType, string attestationUrl, byte[] customData, int customDataLength)
        {
            throw new PlatformNotSupportedException();
        }
    }
}

#endif
