﻿/*
 *  Copyright 2012-2017 The Pkcs11Interop Project
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 */

/*
 *  Written for the Pkcs11Interop project by:
 *  Jaroslav IMRICH <jimrich@jimrich.sk>
 */

using System;
using System.Runtime.InteropServices;

namespace Net.Pkcs11Interop.LowLevelAPI81.MechanismParams
{
    /// <summary>
    /// Structure that provides the parameters to the CKM_SSL3_MASTER_KEY_DERIVE and CKM_SSL3_MASTER_KEY_DERIVE_DH mechanisms
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
    public struct CK_SSL3_MASTER_KEY_DERIVE_PARAMS
    {
        /// <summary>
        /// Client's and server's random data information
        /// </summary>
        public CK_SSL3_RANDOM_DATA RandomInfo;

        /// <summary>
        /// Pointer to a CK_VERSION structure which receives the SSL protocol version information
        /// </summary>
        public IntPtr Version;
    }
}
