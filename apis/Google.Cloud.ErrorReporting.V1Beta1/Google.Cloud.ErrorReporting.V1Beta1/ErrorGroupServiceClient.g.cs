// Copyright 2020 Google LLC
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

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.ErrorReporting.V1Beta1
{
    /// <summary>Settings for <see cref="ErrorGroupServiceClient"/> instances.</summary>
    public sealed partial class ErrorGroupServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ErrorGroupServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ErrorGroupServiceSettings"/>.</returns>
        public static ErrorGroupServiceSettings GetDefault() => new ErrorGroupServiceSettings();

        /// <summary>Constructs a new <see cref="ErrorGroupServiceSettings"/> object with default settings.</summary>
        public ErrorGroupServiceSettings()
        {
        }

        private ErrorGroupServiceSettings(ErrorGroupServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetGroupSettings = existing.GetGroupSettings;
            UpdateGroupSettings = existing.UpdateGroupSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ErrorGroupServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ErrorGroupServiceClient.GetGroup</c> and <c>ErrorGroupServiceClient.GetGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetGroupSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ErrorGroupServiceClient.UpdateGroup</c> and <c>ErrorGroupServiceClient.UpdateGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateGroupSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ErrorGroupServiceSettings"/> object.</returns>
        public ErrorGroupServiceSettings Clone() => new ErrorGroupServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ErrorGroupServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ErrorGroupServiceClientBuilder : gaxgrpc::ClientBuilderBase<ErrorGroupServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ErrorGroupServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref ErrorGroupServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ErrorGroupServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ErrorGroupServiceClient Build()
        {
            ErrorGroupServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ErrorGroupServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ErrorGroupServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ErrorGroupServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ErrorGroupServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<ErrorGroupServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ErrorGroupServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => ErrorGroupServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => ErrorGroupServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ErrorGroupServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>ErrorGroupService client wrapper, for convenient use.</summary>
    public abstract partial class ErrorGroupServiceClient
    {
        /// <summary>
        /// The default endpoint for the ErrorGroupService service, which is a host of
        /// "clouderrorreporting.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "clouderrorreporting.googleapis.com:443";

        /// <summary>The default ErrorGroupService scopes.</summary>
        /// <remarks>
        /// The default ErrorGroupService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="ErrorGroupServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ErrorGroupServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ErrorGroupServiceClient"/>.</returns>
        public static stt::Task<ErrorGroupServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ErrorGroupServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ErrorGroupServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ErrorGroupServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ErrorGroupServiceClient"/>.</returns>
        public static ErrorGroupServiceClient Create() => new ErrorGroupServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ErrorGroupServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ErrorGroupServiceSettings"/>.</param>
        /// <returns>The created <see cref="ErrorGroupServiceClient"/>.</returns>
        internal static ErrorGroupServiceClient Create(grpccore::CallInvoker callInvoker, ErrorGroupServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ErrorGroupService.ErrorGroupServiceClient grpcClient = new ErrorGroupService.ErrorGroupServiceClient(callInvoker);
            return new ErrorGroupServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/>. Channels which weren't automatically created are not
        /// affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/> will create new channels, which could in turn be shut down
        /// by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC ErrorGroupService client</summary>
        public virtual ErrorGroupService.ErrorGroupServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Get the specified group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ErrorGroup GetGroup(GetGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the specified group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ErrorGroup> GetGroupAsync(GetGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the specified group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ErrorGroup> GetGroupAsync(GetGroupRequest request, st::CancellationToken cancellationToken) =>
            GetGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the specified group.
        /// </summary>
        /// <param name="groupName">
        /// The group resource name. Written as
        /// `projects/{projectID}/groups/{group_name}`. Call
        /// [`groupStats.list`](https://cloud.google.com/error-reporting/reference/rest/v1beta1/projects.groupStats/list)
        /// to return a list of groups belonging to this project.
        /// 
        /// Example: `projects/my-project-123/groups/my-group`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ErrorGroup GetGroup(string groupName, gaxgrpc::CallSettings callSettings = null) =>
            GetGroup(new GetGroupRequest
            {
                GroupName = gax::GaxPreconditions.CheckNotNullOrEmpty(groupName, nameof(groupName)),
            }, callSettings);

        /// <summary>
        /// Get the specified group.
        /// </summary>
        /// <param name="groupName">
        /// The group resource name. Written as
        /// `projects/{projectID}/groups/{group_name}`. Call
        /// [`groupStats.list`](https://cloud.google.com/error-reporting/reference/rest/v1beta1/projects.groupStats/list)
        /// to return a list of groups belonging to this project.
        /// 
        /// Example: `projects/my-project-123/groups/my-group`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ErrorGroup> GetGroupAsync(string groupName, gaxgrpc::CallSettings callSettings = null) =>
            GetGroupAsync(new GetGroupRequest
            {
                GroupName = gax::GaxPreconditions.CheckNotNullOrEmpty(groupName, nameof(groupName)),
            }, callSettings);

        /// <summary>
        /// Get the specified group.
        /// </summary>
        /// <param name="groupName">
        /// The group resource name. Written as
        /// `projects/{projectID}/groups/{group_name}`. Call
        /// [`groupStats.list`](https://cloud.google.com/error-reporting/reference/rest/v1beta1/projects.groupStats/list)
        /// to return a list of groups belonging to this project.
        /// 
        /// Example: `projects/my-project-123/groups/my-group`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ErrorGroup> GetGroupAsync(string groupName, st::CancellationToken cancellationToken) =>
            GetGroupAsync(groupName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the specified group.
        /// </summary>
        /// <param name="groupName">
        /// The group resource name. Written as
        /// `projects/{projectID}/groups/{group_name}`. Call
        /// [`groupStats.list`](https://cloud.google.com/error-reporting/reference/rest/v1beta1/projects.groupStats/list)
        /// to return a list of groups belonging to this project.
        /// 
        /// Example: `projects/my-project-123/groups/my-group`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ErrorGroup GetGroup(ErrorGroupName groupName, gaxgrpc::CallSettings callSettings = null) =>
            GetGroup(new GetGroupRequest
            {
                GroupNameAsErrorGroupName = gax::GaxPreconditions.CheckNotNull(groupName, nameof(groupName)),
            }, callSettings);

        /// <summary>
        /// Get the specified group.
        /// </summary>
        /// <param name="groupName">
        /// The group resource name. Written as
        /// `projects/{projectID}/groups/{group_name}`. Call
        /// [`groupStats.list`](https://cloud.google.com/error-reporting/reference/rest/v1beta1/projects.groupStats/list)
        /// to return a list of groups belonging to this project.
        /// 
        /// Example: `projects/my-project-123/groups/my-group`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ErrorGroup> GetGroupAsync(ErrorGroupName groupName, gaxgrpc::CallSettings callSettings = null) =>
            GetGroupAsync(new GetGroupRequest
            {
                GroupNameAsErrorGroupName = gax::GaxPreconditions.CheckNotNull(groupName, nameof(groupName)),
            }, callSettings);

        /// <summary>
        /// Get the specified group.
        /// </summary>
        /// <param name="groupName">
        /// The group resource name. Written as
        /// `projects/{projectID}/groups/{group_name}`. Call
        /// [`groupStats.list`](https://cloud.google.com/error-reporting/reference/rest/v1beta1/projects.groupStats/list)
        /// to return a list of groups belonging to this project.
        /// 
        /// Example: `projects/my-project-123/groups/my-group`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ErrorGroup> GetGroupAsync(ErrorGroupName groupName, st::CancellationToken cancellationToken) =>
            GetGroupAsync(groupName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Replace the data for the specified group.
        /// Fails if the group does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ErrorGroup UpdateGroup(UpdateGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Replace the data for the specified group.
        /// Fails if the group does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ErrorGroup> UpdateGroupAsync(UpdateGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Replace the data for the specified group.
        /// Fails if the group does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ErrorGroup> UpdateGroupAsync(UpdateGroupRequest request, st::CancellationToken cancellationToken) =>
            UpdateGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Replace the data for the specified group.
        /// Fails if the group does not exist.
        /// </summary>
        /// <param name="group">
        /// Required. The group which replaces the resource on the server.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ErrorGroup UpdateGroup(ErrorGroup group, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGroup(new UpdateGroupRequest
            {
                Group = gax::GaxPreconditions.CheckNotNull(group, nameof(group)),
            }, callSettings);

        /// <summary>
        /// Replace the data for the specified group.
        /// Fails if the group does not exist.
        /// </summary>
        /// <param name="group">
        /// Required. The group which replaces the resource on the server.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ErrorGroup> UpdateGroupAsync(ErrorGroup group, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGroupAsync(new UpdateGroupRequest
            {
                Group = gax::GaxPreconditions.CheckNotNull(group, nameof(group)),
            }, callSettings);

        /// <summary>
        /// Replace the data for the specified group.
        /// Fails if the group does not exist.
        /// </summary>
        /// <param name="group">
        /// Required. The group which replaces the resource on the server.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ErrorGroup> UpdateGroupAsync(ErrorGroup group, st::CancellationToken cancellationToken) =>
            UpdateGroupAsync(group, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ErrorGroupService client wrapper implementation, for convenient use.</summary>
    public sealed partial class ErrorGroupServiceClientImpl : ErrorGroupServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetGroupRequest, ErrorGroup> _callGetGroup;

        private readonly gaxgrpc::ApiCall<UpdateGroupRequest, ErrorGroup> _callUpdateGroup;

        /// <summary>
        /// Constructs a client wrapper for the ErrorGroupService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ErrorGroupServiceSettings"/> used within this client.</param>
        public ErrorGroupServiceClientImpl(ErrorGroupService.ErrorGroupServiceClient grpcClient, ErrorGroupServiceSettings settings)
        {
            GrpcClient = grpcClient;
            ErrorGroupServiceSettings effectiveSettings = settings ?? ErrorGroupServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetGroup = clientHelper.BuildApiCall<GetGroupRequest, ErrorGroup>(grpcClient.GetGroupAsync, grpcClient.GetGroup, effectiveSettings.GetGroupSettings).WithGoogleRequestParam("group_name", request => request.GroupName);
            Modify_ApiCall(ref _callGetGroup);
            Modify_GetGroupApiCall(ref _callGetGroup);
            _callUpdateGroup = clientHelper.BuildApiCall<UpdateGroupRequest, ErrorGroup>(grpcClient.UpdateGroupAsync, grpcClient.UpdateGroup, effectiveSettings.UpdateGroupSettings).WithGoogleRequestParam("group.name", request => request.Group?.Name);
            Modify_ApiCall(ref _callUpdateGroup);
            Modify_UpdateGroupApiCall(ref _callUpdateGroup);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetGroupApiCall(ref gaxgrpc::ApiCall<GetGroupRequest, ErrorGroup> call);

        partial void Modify_UpdateGroupApiCall(ref gaxgrpc::ApiCall<UpdateGroupRequest, ErrorGroup> call);

        partial void OnConstruction(ErrorGroupService.ErrorGroupServiceClient grpcClient, ErrorGroupServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ErrorGroupService client</summary>
        public override ErrorGroupService.ErrorGroupServiceClient GrpcClient { get; }

        partial void Modify_GetGroupRequest(ref GetGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateGroupRequest(ref UpdateGroupRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Get the specified group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ErrorGroup GetGroup(GetGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGroupRequest(ref request, ref callSettings);
            return _callGetGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Get the specified group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ErrorGroup> GetGroupAsync(GetGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGroupRequest(ref request, ref callSettings);
            return _callGetGroup.Async(request, callSettings);
        }

        /// <summary>
        /// Replace the data for the specified group.
        /// Fails if the group does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ErrorGroup UpdateGroup(UpdateGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGroupRequest(ref request, ref callSettings);
            return _callUpdateGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Replace the data for the specified group.
        /// Fails if the group does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ErrorGroup> UpdateGroupAsync(UpdateGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGroupRequest(ref request, ref callSettings);
            return _callUpdateGroup.Async(request, callSettings);
        }
    }
}
