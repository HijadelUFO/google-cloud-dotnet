﻿// Copyright 2020 Google LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     https://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;

#if NETCOREAPP3_1
namespace Google.Cloud.Diagnostics.AspNetCore3
#elif NETSTANDARD2_0
namespace Google.Cloud.Diagnostics.AspNetCore
#else
#error unknown target framework
#endif
{
    /// <summary>
    /// Provides external trace information to include in a log entry
    /// if there's no Google Trace available.
    /// Implement this interface when traces are being generated by your environment
    /// and sent to Google Cloud Tracing not via the Google.Cloud.Diagnostics library.
    /// </summary>
    public interface IExternalTraceProvider
    {
        /// <summary>
        /// Returns the <see cref="TraceContextForLogEntry"/> that can be associated to a log entry or
        /// null if there's currently no trace context.
        /// </summary>
        /// <param name="serviceProvider">The service provider to resolve services from. Must not be null.</param>
        /// <returns>A <see cref="TraceContextForLogEntry"/> or null if there's no current trace.</returns>
        TraceContextForLogEntry GetCurrentTraceContext(IServiceProvider serviceProvider);
    }
}