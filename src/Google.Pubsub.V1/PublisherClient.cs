// Copyright 2016 Google Inc. All Rights Reserved.
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

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Pubsub.V1
{

    /// <summary>
    /// Extension methods to assist with using <see cref="PublisherClient"/>.
    /// </summary>
    public static partial class PublisherExtensions
    {
        /// <summary>
        /// Wrap a GRPC Publisher client for more convenient use.
        /// </summary>
        /// <param name="grpcClient">A GRPC client to wrap.</param>
        /// <param name="settings">
        /// An optional <see cref="PublisherSettings"/> to configure this wrapper.
        /// If null or not specified, then the default settings are used.
        /// </param>
        /// <returns>A <see cref="PublisherClient"/> that wraps the specified GRPC client.</returns>
        public static PublisherClient ToClient(
            this Publisher.IPublisherClient grpcClient,
            PublisherSettings settings = null
        ) => new PublisherClientImpl(grpcClient, settings);
    }

    /// <summary>
    /// Settings for a Publisher wrapper.
    /// </summary>
    public sealed partial class PublisherSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="PublisherSettings"/>.
        /// </summary>
        /// <returns>A new instance of the default PublisherSettings.</returns>
        public static PublisherSettings GetDefault() => new PublisherSettings();

        /// <summary>
        /// Constructs a new PublisherSettings object with default settings.
        /// </summary>
        public PublisherSettings() { }

        private PublisherSettings(PublisherSettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateTopicRetry = existing.CreateTopicRetry?.Clone();
            PublishRetry = existing.PublishRetry?.Clone();
            GetTopicRetry = existing.GetTopicRetry?.Clone();
            ListTopicsRetry = existing.ListTopicsRetry?.Clone();
            ListTopicSubscriptionsRetry = existing.ListTopicSubscriptionsRetry?.Clone();
            DeleteTopicRetry = existing.DeleteTopicRetry?.Clone();
        }

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="PublisherClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static Predicate<RpcException> IdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes(StatusCode.DeadlineExceeded, StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="PublisherClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode">s eligilbe for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="PublisherClient"/> RPC methods.
        /// </summary>
        /// <returns>The "Default" retry backoff for <see cref="PublisherClient"/> RPC methods.</returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="PublisherClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.2</description></item>
        /// <item><description>Maximum delay: 1000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultRetryBackoff() => new BackoffSettings
        {
            Delay = TimeSpan.FromMilliseconds(100),
            DelayMultiplier = 1.2,
            MaxDelay = TimeSpan.FromMilliseconds(1000),
        };

        /// <summary>
        /// "Default" timeout backoff for <see cref="PublisherClient"/> RPC methods.
        /// </summary>
        /// <returns>The "Default" timeout backoff for <see cref="PublisherClient"/> RPC methods.</returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="PublisherClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 2000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Maximum timeout: 30000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings
        {
            Delay = TimeSpan.FromMilliseconds(2000),
            DelayMultiplier = 1.5,
            MaxDelay = TimeSpan.FromMilliseconds(30000),
        };

        /// <summary>
        /// <see cref="RetrySettings"/> for asynchronous and synchronous calls to
        /// <see cref="PublisherClient.CreateTopic"/> and <see cref="PublisherClient.CreateTopicAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="PublisherClient.CreateTopic"/> and
        /// <see cref="PublisherClient.CreateTopicAsync"/> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 1000 milliseconds</description></item>
        /// <item><description>Initial timeout: 2000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Timeout maximum delay: 30000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public RetrySettings CreateTopicRetry { get; set; } = new RetrySettings
        {
            RetryBackoff = GetDefaultRetryBackoff(),
            TimeoutBackoff = GetDefaultTimeoutBackoff(),
            RetryFilter = IdempotentRetryFilter,
        };

        /// <summary>
        /// <see cref="RetrySettings"/> for asynchronous and synchronous calls to
        /// <see cref="PublisherClient.Publish"/> and <see cref="PublisherClient.PublishAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="PublisherClient.Publish"/> and
        /// <see cref="PublisherClient.PublishAsync"/> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 1000 milliseconds</description></item>
        /// <item><description>Initial timeout: 2000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Timeout maximum delay: 30000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// </remarks>
        public RetrySettings PublishRetry { get; set; } = new RetrySettings
        {
            RetryBackoff = GetDefaultRetryBackoff(),
            TimeoutBackoff = GetDefaultTimeoutBackoff(),
            RetryFilter = NonIdempotentRetryFilter,
        };

        /// <summary>
        /// <see cref="RetrySettings"/> for asynchronous and synchronous calls to
        /// <see cref="PublisherClient.GetTopic"/> and <see cref="PublisherClient.GetTopicAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="PublisherClient.GetTopic"/> and
        /// <see cref="PublisherClient.GetTopicAsync"/> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 1000 milliseconds</description></item>
        /// <item><description>Initial timeout: 2000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Timeout maximum delay: 30000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public RetrySettings GetTopicRetry { get; set; } = new RetrySettings
        {
            RetryBackoff = GetDefaultRetryBackoff(),
            TimeoutBackoff = GetDefaultTimeoutBackoff(),
            RetryFilter = IdempotentRetryFilter,
        };

        /// <summary>
        /// <see cref="RetrySettings"/> for asynchronous and synchronous calls to
        /// <see cref="PublisherClient.ListTopics"/> and <see cref="PublisherClient.ListTopicsAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="PublisherClient.ListTopics"/> and
        /// <see cref="PublisherClient.ListTopicsAsync"/> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 1000 milliseconds</description></item>
        /// <item><description>Initial timeout: 2000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Timeout maximum delay: 30000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public RetrySettings ListTopicsRetry { get; set; } = new RetrySettings
        {
            RetryBackoff = GetDefaultRetryBackoff(),
            TimeoutBackoff = GetDefaultTimeoutBackoff(),
            RetryFilter = IdempotentRetryFilter,
        };

        /// <summary>
        /// <see cref="RetrySettings"/> for asynchronous and synchronous calls to
        /// <see cref="PublisherClient.ListTopicSubscriptions"/> and <see cref="PublisherClient.ListTopicSubscriptionsAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="PublisherClient.ListTopicSubscriptions"/> and
        /// <see cref="PublisherClient.ListTopicSubscriptionsAsync"/> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 1000 milliseconds</description></item>
        /// <item><description>Initial timeout: 2000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Timeout maximum delay: 30000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public RetrySettings ListTopicSubscriptionsRetry { get; set; } = new RetrySettings
        {
            RetryBackoff = GetDefaultRetryBackoff(),
            TimeoutBackoff = GetDefaultTimeoutBackoff(),
            RetryFilter = IdempotentRetryFilter,
        };

        /// <summary>
        /// <see cref="RetrySettings"/> for asynchronous and synchronous calls to
        /// <see cref="PublisherClient.DeleteTopic"/> and <see cref="PublisherClient.DeleteTopicAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="PublisherClient.DeleteTopic"/> and
        /// <see cref="PublisherClient.DeleteTopicAsync"/> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 1000 milliseconds</description></item>
        /// <item><description>Initial timeout: 2000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Timeout maximum delay: 30000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public RetrySettings DeleteTopicRetry { get; set; } = new RetrySettings
        {
            RetryBackoff = GetDefaultRetryBackoff(),
            TimeoutBackoff = GetDefaultTimeoutBackoff(),
            RetryFilter = IdempotentRetryFilter,
        };


        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this set of Publisher settings.</returns>
        public PublisherSettings Clone() => new PublisherSettings(this);
    }

    /// <summary>
    /// Publisher client wrapper, for convenient use.
    /// </summary>
    public abstract partial class PublisherClient
    {
        /// <summary>
        /// The default endpoint for the Publisher service, which is a host of "pubsub-experimental.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("pubsub-experimental.googleapis.com", 443);

        /// <summary>
        /// The default Publisher scopes
        /// </summary>
        /// <remarks>
        /// The default Publisher scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/pubsub"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new[] {
            "https://www.googleapis.com/auth/pubsub",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>
        /// Path template for a project resource. Parameters:
        /// <list type="bullet">
        /// <item><description>project</description></item>
        /// </list>
        /// </summary>
        public static PathTemplate ProjectTemplate { get; } = new PathTemplate("projects/{project}");

        /// <summary>
        /// Creates a project resource name from its component IDs.
        /// </summary>
        /// <param name="projectId">The project ID.</param>
        /// <returns>The full project resource name.</returns>
        public static string GetProjectName(string projectId) => ProjectTemplate.Expand(projectId);

        /// <summary>
        /// Path template for a topic resource. Parameters:
        /// <list type="bullet">
        /// <item><description>project</description></item>
        /// <item><description>topic</description></item>
        /// </list>
        /// </summary>
        public static PathTemplate TopicTemplate { get; } = new PathTemplate("projects/{project}/topics/{topic}");

        /// <summary>
        /// Creates a topic resource name from its component IDs.
        /// </summary>
        /// <param name="projectId">The project ID.</param>
        /// <param name="topicId">The topic ID.</param>
        /// <returns>The full topic resource name.</returns>
        public static string GetTopicName(string projectId, string topicId) => TopicTemplate.Expand(projectId, topicId);

        // Note: we could have parameterless overloads of Create and CreateAsync,
        // documented to just use the default endpoint, settings and credentials.
        // Pros:
        // - Might be more reassuring on first use
        // - Allows method group conversions
        // Con: overloads!

        /// <summary>
        /// Asynchronously creates a <see cref="PublisherClient"/>, applying defaults for all unspecified settings.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="PublisherSettings"/>.</param>
        /// <param name="credentials">Optional <see cref="ChannelCredentials"/>.</param>
        /// <returns>The task representing the created <see cref="PublisherClient"/>.</returns>
        public static async Task<PublisherClient> CreateAsync(
            ServiceEndpoint endpoint = null,
            PublisherSettings settings = null,
            ChannelCredentials credentials = null)
        {
            Channel channel = await ClientHelper.CreateChannelAsync(endpoint ?? DefaultEndpoint, credentials).ConfigureAwait(false);
            Publisher.PublisherClient grpcClient = new Publisher.PublisherClient(channel);
            return new PublisherClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="PublisherClient"/>, applying defaults for all unspecified settings.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="PublisherSettings"/>.</param>
        /// <param name="credentials">Optional <see cref="ChannelCredentials"/>.</param>
        /// <returns>The created <see cref="PublisherClient"/>.</returns>
        public static PublisherClient Create(
            ServiceEndpoint endpoint = null,
            PublisherSettings settings = null,
            ChannelCredentials credentials = null)
        {
            Channel channel = ClientHelper.CreateChannel(endpoint ?? DefaultEndpoint, credentials);
            Publisher.PublisherClient grpcClient = new Publisher.PublisherClient(channel);
            return new PublisherClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// The underlying GRPC Publisher client.
        /// </summary>
        public virtual Publisher.IPublisherClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Creates the given topic with the given name.
        /// </summary>
        /// <param name="name">
        /// The name of the topic. It must have the format
        /// `"projects/{project}/topics/{topic}"`. `{topic}` must start with a letter,
        /// and contain only letters (`[A-Za-z]`), numbers (`[0-9]`), dashes (`-`),
        /// underscores (`_`), periods (`.`), tildes (`~`), plus (`+`) or percent
        /// signs (`%`). It must be between 3 and 255 characters in length, and it
        /// must not start with `"goog"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<Topic> CreateTopicAsync(
            string name,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates the given topic with the given name.
        /// </summary>
        /// <param name="name">
        /// The name of the topic. It must have the format
        /// `"projects/{project}/topics/{topic}"`. `{topic}` must start with a letter,
        /// and contain only letters (`[A-Za-z]`), numbers (`[0-9]`), dashes (`-`),
        /// underscores (`_`), periods (`.`), tildes (`~`), plus (`+`) or percent
        /// signs (`%`). It must be between 3 and 255 characters in length, and it
        /// must not start with `"goog"`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<Topic> CreateTopicAsync(
            string name,
            CancellationToken cancellationToken) => CreateTopicAsync(
                name,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Creates the given topic with the given name.
        /// </summary>
        /// <param name="name">
        /// The name of the topic. It must have the format
        /// `"projects/{project}/topics/{topic}"`. `{topic}` must start with a letter,
        /// and contain only letters (`[A-Za-z]`), numbers (`[0-9]`), dashes (`-`),
        /// underscores (`_`), periods (`.`), tildes (`~`), plus (`+`) or percent
        /// signs (`%`). It must be between 3 and 255 characters in length, and it
        /// must not start with `"goog"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Topic CreateTopic(
            string name,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds one or more messages to the topic. Generates `NOT_FOUND` if the topic
        /// does not exist. The message payload must not be empty; it must contain
        ///  either a non-empty data field, or at least one attribute.
        /// </summary>
        /// <param name="topic">The messages in the request will be published on this topic.</param>
        /// <param name="messages">The messages to publish.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<PublishResponse> PublishAsync(
            string topic,
            IEnumerable<PubsubMessage> messages,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds one or more messages to the topic. Generates `NOT_FOUND` if the topic
        /// does not exist. The message payload must not be empty; it must contain
        ///  either a non-empty data field, or at least one attribute.
        /// </summary>
        /// <param name="topic">The messages in the request will be published on this topic.</param>
        /// <param name="messages">The messages to publish.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<PublishResponse> PublishAsync(
            string topic,
            IEnumerable<PubsubMessage> messages,
            CancellationToken cancellationToken) => PublishAsync(
                topic,
                messages,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Adds one or more messages to the topic. Generates `NOT_FOUND` if the topic
        /// does not exist. The message payload must not be empty; it must contain
        ///  either a non-empty data field, or at least one attribute.
        /// </summary>
        /// <param name="topic">The messages in the request will be published on this topic.</param>
        /// <param name="messages">The messages to publish.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PublishResponse Publish(
            string topic,
            IEnumerable<PubsubMessage> messages,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the configuration of a topic.
        /// </summary>
        /// <param name="topic">The name of the topic to get.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<Topic> GetTopicAsync(
            string topic,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the configuration of a topic.
        /// </summary>
        /// <param name="topic">The name of the topic to get.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<Topic> GetTopicAsync(
            string topic,
            CancellationToken cancellationToken) => GetTopicAsync(
                topic,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Gets the configuration of a topic.
        /// </summary>
        /// <param name="topic">The name of the topic to get.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Topic GetTopic(
            string topic,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists matching topics.
        /// </summary>
        /// <param name="project">The name of the cloud project that topics belong to.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual IAsyncEnumerable<Topic> ListTopicsAsync(
            string project,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists matching topics.
        /// </summary>
        /// <param name="project">The name of the cloud project that topics belong to.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IEnumerable<Topic> ListTopics(
            string project,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists the name of the subscriptions for this topic.
        /// </summary>
        /// <param name="topic">The name of the topic that subscriptions are attached to.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual IAsyncEnumerable<string> ListTopicSubscriptionsAsync(
            string topic,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists the name of the subscriptions for this topic.
        /// </summary>
        /// <param name="topic">The name of the topic that subscriptions are attached to.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IEnumerable<string> ListTopicSubscriptions(
            string topic,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes the topic with the given name. Generates `NOT_FOUND` if the topic
        /// does not exist. After a topic is deleted, a new topic may be created with
        /// the same name; this is an entirely new topic with none of the old
        /// configuration or subscriptions. Existing subscriptions to this topic are
        /// not deleted, but their `topic` field is set to `_deleted-topic_`.
        /// </summary>
        /// <param name="topic">Name of the topic to delete.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task DeleteTopicAsync(
            string topic,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes the topic with the given name. Generates `NOT_FOUND` if the topic
        /// does not exist. After a topic is deleted, a new topic may be created with
        /// the same name; this is an entirely new topic with none of the old
        /// configuration or subscriptions. Existing subscriptions to this topic are
        /// not deleted, but their `topic` field is set to `_deleted-topic_`.
        /// </summary>
        /// <param name="topic">Name of the topic to delete.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task DeleteTopicAsync(
            string topic,
            CancellationToken cancellationToken) => DeleteTopicAsync(
                topic,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Deletes the topic with the given name. Generates `NOT_FOUND` if the topic
        /// does not exist. After a topic is deleted, a new topic may be created with
        /// the same name; this is an entirely new topic with none of the old
        /// configuration or subscriptions. Existing subscriptions to this topic are
        /// not deleted, but their `topic` field is set to `_deleted-topic_`.
        /// </summary>
        /// <param name="topic">Name of the topic to delete.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTopic(
            string topic,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    public sealed partial class PublisherClientImpl : PublisherClient
    {
        private static readonly PageStreamer<Topic, ListTopicsRequest, ListTopicsResponse, string> s_listTopicsPageStreamer =
            new PageStreamer<Topic, ListTopicsRequest, ListTopicsResponse, string>(
                (request, token) => {
                    request.PageToken = token;
                    return request;
                },
                response => response.NextPageToken,
                response => response.Topics,
                "" // An empty page-token
            );

        private static readonly PageStreamer<string, ListTopicSubscriptionsRequest, ListTopicSubscriptionsResponse, string> s_listTopicSubscriptionsPageStreamer =
            new PageStreamer<string, ListTopicSubscriptionsRequest, ListTopicSubscriptionsResponse, string>(
                (request, token) => {
                    request.PageToken = token;
                    return request;
                },
                response => response.NextPageToken,
                response => response.Subscriptions,
                "" // An empty page-token
            );

        private readonly ClientHelper _clientHelper;
        private readonly ApiCall<Topic, Topic> _callCreateTopic;
        private readonly ApiCall<PublishRequest, PublishResponse> _callPublish;
        private readonly ApiCall<GetTopicRequest, Topic> _callGetTopic;
        private readonly ApiCall<ListTopicsRequest, ListTopicsResponse> _callListTopics;
        private readonly ApiCall<ListTopicSubscriptionsRequest, ListTopicSubscriptionsResponse> _callListTopicSubscriptions;
        private readonly ApiCall<DeleteTopicRequest, Empty> _callDeleteTopic;

        public PublisherClientImpl(Publisher.IPublisherClient grpcClient, PublisherSettings settings)
        {
            this.GrpcClient = grpcClient;
            PublisherSettings effectiveSettings = settings ?? PublisherSettings.GetDefault();
            IClock effectiveClock = effectiveSettings.Clock ?? SystemClock.Instance;
            _clientHelper = new ClientHelper(effectiveSettings);
            _callCreateTopic = _clientHelper.BuildApiCall<Topic, Topic>(GrpcClient.CreateTopicAsync, GrpcClient.CreateTopic)
                .WithRetry(effectiveSettings.CreateTopicRetry, effectiveClock, null);
            _callPublish = _clientHelper.BuildApiCall<PublishRequest, PublishResponse>(GrpcClient.PublishAsync, GrpcClient.Publish)
                .WithRetry(effectiveSettings.PublishRetry, effectiveClock, null);
            _callGetTopic = _clientHelper.BuildApiCall<GetTopicRequest, Topic>(GrpcClient.GetTopicAsync, GrpcClient.GetTopic)
                .WithRetry(effectiveSettings.GetTopicRetry, effectiveClock, null);
            _callListTopics = _clientHelper.BuildApiCall<ListTopicsRequest, ListTopicsResponse>(GrpcClient.ListTopicsAsync, GrpcClient.ListTopics)
                .WithRetry(effectiveSettings.ListTopicsRetry, effectiveClock, null);
            _callListTopicSubscriptions = _clientHelper.BuildApiCall<ListTopicSubscriptionsRequest, ListTopicSubscriptionsResponse>(GrpcClient.ListTopicSubscriptionsAsync, GrpcClient.ListTopicSubscriptions)
                .WithRetry(effectiveSettings.ListTopicSubscriptionsRetry, effectiveClock, null);
            _callDeleteTopic = _clientHelper.BuildApiCall<DeleteTopicRequest, Empty>(GrpcClient.DeleteTopicAsync, GrpcClient.DeleteTopic)
                .WithRetry(effectiveSettings.DeleteTopicRetry, effectiveClock, null);
        }

        public override Publisher.IPublisherClient GrpcClient { get; }

        /// <summary>
        /// Creates the given topic with the given name.
        /// </summary>
        /// <param name="name">
        /// The name of the topic. It must have the format
        /// `"projects/{project}/topics/{topic}"`. `{topic}` must start with a letter,
        /// and contain only letters (`[A-Za-z]`), numbers (`[0-9]`), dashes (`-`),
        /// underscores (`_`), periods (`.`), tildes (`~`), plus (`+`) or percent
        /// signs (`%`). It must be between 3 and 255 characters in length, and it
        /// must not start with `"goog"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<Topic> CreateTopicAsync(
            string name,
            CallSettings callSettings = null) => _callCreateTopic.Async(
                new Topic
                {
                    Name = name,
                },
                callSettings);

        /// <summary>
        /// Creates the given topic with the given name.
        /// </summary>
        /// <param name="name">
        /// The name of the topic. It must have the format
        /// `"projects/{project}/topics/{topic}"`. `{topic}` must start with a letter,
        /// and contain only letters (`[A-Za-z]`), numbers (`[0-9]`), dashes (`-`),
        /// underscores (`_`), periods (`.`), tildes (`~`), plus (`+`) or percent
        /// signs (`%`). It must be between 3 and 255 characters in length, and it
        /// must not start with `"goog"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Topic CreateTopic(
            string name,
            CallSettings callSettings = null) => _callCreateTopic.Sync(
                new Topic
                {
                    Name = name,
                },
                callSettings);
        /// <summary>
        /// Adds one or more messages to the topic. Generates `NOT_FOUND` if the topic
        /// does not exist. The message payload must not be empty; it must contain
        ///  either a non-empty data field, or at least one attribute.
        /// </summary>
        /// <param name="topic">The messages in the request will be published on this topic.</param>
        /// <param name="messages">The messages to publish.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<PublishResponse> PublishAsync(
            string topic,
            IEnumerable<PubsubMessage> messages,
            CallSettings callSettings = null) => _callPublish.Async(
                new PublishRequest
                {
                    Topic = topic,
                    Messages = { messages },
                },
                callSettings);

        /// <summary>
        /// Adds one or more messages to the topic. Generates `NOT_FOUND` if the topic
        /// does not exist. The message payload must not be empty; it must contain
        ///  either a non-empty data field, or at least one attribute.
        /// </summary>
        /// <param name="topic">The messages in the request will be published on this topic.</param>
        /// <param name="messages">The messages to publish.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PublishResponse Publish(
            string topic,
            IEnumerable<PubsubMessage> messages,
            CallSettings callSettings = null) => _callPublish.Sync(
                new PublishRequest
                {
                    Topic = topic,
                    Messages = { messages },
                },
                callSettings);
        /// <summary>
        /// Gets the configuration of a topic.
        /// </summary>
        /// <param name="topic">The name of the topic to get.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<Topic> GetTopicAsync(
            string topic,
            CallSettings callSettings = null) => _callGetTopic.Async(
                new GetTopicRequest
                {
                    Topic = topic,
                },
                callSettings);

        /// <summary>
        /// Gets the configuration of a topic.
        /// </summary>
        /// <param name="topic">The name of the topic to get.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Topic GetTopic(
            string topic,
            CallSettings callSettings = null) => _callGetTopic.Sync(
                new GetTopicRequest
                {
                    Topic = topic,
                },
                callSettings);
        /// <summary>
        /// Lists matching topics.
        /// </summary>
        /// <param name="project">The name of the cloud project that topics belong to.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override IAsyncEnumerable<Topic> ListTopicsAsync(
            string project,
            CallSettings callSettings = null) => s_listTopicsPageStreamer.FetchAsync(
                callSettings,
                new ListTopicsRequest
                {
                    Project = project,
                },
                _callListTopics);

        /// <summary>
        /// Lists matching topics.
        /// </summary>
        /// <param name="project">The name of the cloud project that topics belong to.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override IEnumerable<Topic> ListTopics(
            string project,
            CallSettings callSettings = null) => s_listTopicsPageStreamer.Fetch(
                callSettings,
                new ListTopicsRequest
                {
                    Project = project,
                },
                _callListTopics);
        /// <summary>
        /// Lists the name of the subscriptions for this topic.
        /// </summary>
        /// <param name="topic">The name of the topic that subscriptions are attached to.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override IAsyncEnumerable<string> ListTopicSubscriptionsAsync(
            string topic,
            CallSettings callSettings = null) => s_listTopicSubscriptionsPageStreamer.FetchAsync(
                callSettings,
                new ListTopicSubscriptionsRequest
                {
                    Topic = topic,
                },
                _callListTopicSubscriptions);

        /// <summary>
        /// Lists the name of the subscriptions for this topic.
        /// </summary>
        /// <param name="topic">The name of the topic that subscriptions are attached to.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override IEnumerable<string> ListTopicSubscriptions(
            string topic,
            CallSettings callSettings = null) => s_listTopicSubscriptionsPageStreamer.Fetch(
                callSettings,
                new ListTopicSubscriptionsRequest
                {
                    Topic = topic,
                },
                _callListTopicSubscriptions);
        /// <summary>
        /// Deletes the topic with the given name. Generates `NOT_FOUND` if the topic
        /// does not exist. After a topic is deleted, a new topic may be created with
        /// the same name; this is an entirely new topic with none of the old
        /// configuration or subscriptions. Existing subscriptions to this topic are
        /// not deleted, but their `topic` field is set to `_deleted-topic_`.
        /// </summary>
        /// <param name="topic">Name of the topic to delete.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task DeleteTopicAsync(
            string topic,
            CallSettings callSettings = null) => _callDeleteTopic.Async(
                new DeleteTopicRequest
                {
                    Topic = topic,
                },
                callSettings);

        /// <summary>
        /// Deletes the topic with the given name. Generates `NOT_FOUND` if the topic
        /// does not exist. After a topic is deleted, a new topic may be created with
        /// the same name; this is an entirely new topic with none of the old
        /// configuration or subscriptions. Existing subscriptions to this topic are
        /// not deleted, but their `topic` field is set to `_deleted-topic_`.
        /// </summary>
        /// <param name="topic">Name of the topic to delete.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteTopic(
            string topic,
            CallSettings callSettings = null) => _callDeleteTopic.Sync(
                new DeleteTopicRequest
                {
                    Topic = topic,
                },
                callSettings);
    }
}