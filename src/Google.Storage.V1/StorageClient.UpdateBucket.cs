﻿// Copyright 2016 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Apis.Storage.v1.Data;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Storage.V1
{
    public abstract partial class StorageClient
    {
        /// <summary>
        /// Updates the metadata for a storage bucket synchronously.
        /// </summary>
        /// <remarks>
        /// As this is a full update, <paramref name="bucket"/> must be fully populated. This is typically
        /// obtained by performing another operation (such as <see cref="GetBucket(string, GetBucketOptions)"/>
        /// with a "full" projection, and then modifying the returned object.
        /// </remarks>
        /// <param name="bucket">Bucket to update. Must not be null, and must have populated <c>Name</c>,
        /// <c>Bucket</c> and <c>Acl</c> properties.</param>
        /// <param name="options">Additional options for the update. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <returns>The <see cref="Bucket"/> representation of the updated storage bucket.</returns>
        public virtual Bucket UpdateBucket(
            Bucket bucket,
            UpdateBucketOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates the metadata for storage bucket asynchronously.
        /// </summary>
        /// <remarks>
        /// As this is a full update, <paramref name="bucket"/> must be fully populated. This is typically
        /// obtained by performing another operation (such as <see cref="GetBucketAsync(string, GetBucketOptions, CancellationToken)"/>
        /// with a "full" projection, and then modifying the returned object.
        /// </remarks>
        /// <param name="bucket">Bucket to update. Must not be null, and must have populated <c>Name</c>
        /// and <c>Acl</c> properties.</param>
        /// <param name="options">Additional options for the update. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation, with a result returning the
        /// <see cref="Bucket"/> representation of the storage bucket.</returns>
        public virtual Task<Bucket> UpdateBucketAsync(
            Bucket bucket,
            UpdateBucketOptions options = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }
    }
}
