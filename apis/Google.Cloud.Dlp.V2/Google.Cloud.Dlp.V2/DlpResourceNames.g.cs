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
using gagr = Google.Api.Gax.ResourceNames;
using gcdv = Google.Cloud.Dlp.V2;
using sys = System;

namespace Google.Cloud.Dlp.V2
{
    /// <summary>Resource name for the <c>Finding</c> resource.</summary>
    public sealed partial class FindingName : gax::IResourceName, sys::IEquatable<FindingName>
    {
        /// <summary>The possible contents of <see cref="FindingName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/findings/{finding}</c>.
            /// </summary>
            ProjectLocationFinding = 1
        }

        private static gax::PathTemplate s_projectLocationFinding = new gax::PathTemplate("projects/{project}/locations/{location}/findings/{finding}");

        /// <summary>Creates a <see cref="FindingName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FindingName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FindingName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FindingName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FindingName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/findings/{finding}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingId">The <c>Finding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FindingName"/> constructed from the provided ids.</returns>
        public static FindingName FromProjectLocationFinding(string projectId, string locationId, string findingId) =>
            new FindingName(ResourceNameType.ProjectLocationFinding, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), findingId: gax::GaxPreconditions.CheckNotNullOrEmpty(findingId, nameof(findingId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FindingName"/> with pattern
        /// <c>projects/{project}/locations/{location}/findings/{finding}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingId">The <c>Finding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FindingName"/> with pattern
        /// <c>projects/{project}/locations/{location}/findings/{finding}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string findingId) =>
            FormatProjectLocationFinding(projectId, locationId, findingId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FindingName"/> with pattern
        /// <c>projects/{project}/locations/{location}/findings/{finding}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingId">The <c>Finding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FindingName"/> with pattern
        /// <c>projects/{project}/locations/{location}/findings/{finding}</c>.
        /// </returns>
        public static string FormatProjectLocationFinding(string projectId, string locationId, string findingId) =>
            s_projectLocationFinding.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(findingId, nameof(findingId)));

        /// <summary>Parses the given resource name string into a new <see cref="FindingName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/findings/{finding}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="findingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FindingName"/> if successful.</returns>
        public static FindingName Parse(string findingName) => Parse(findingName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FindingName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/findings/{finding}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="findingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FindingName"/> if successful.</returns>
        public static FindingName Parse(string findingName, bool allowUnparsed) =>
            TryParse(findingName, allowUnparsed, out FindingName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FindingName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/findings/{finding}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="findingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FindingName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string findingName, out FindingName result) => TryParse(findingName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FindingName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/findings/{finding}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="findingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FindingName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string findingName, bool allowUnparsed, out FindingName result)
        {
            gax::GaxPreconditions.CheckNotNull(findingName, nameof(findingName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationFinding.TryParseName(findingName, out resourceName))
            {
                result = FromProjectLocationFinding(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(findingName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FindingName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string findingId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FindingId = findingId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FindingName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/findings/{finding}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingId">The <c>Finding</c> ID. Must not be <c>null</c> or empty.</param>
        public FindingName(string projectId, string locationId, string findingId) : this(ResourceNameType.ProjectLocationFinding, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), findingId: gax::GaxPreconditions.CheckNotNullOrEmpty(findingId, nameof(findingId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>Finding</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string FindingId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationFinding: return s_projectLocationFinding.Expand(ProjectId, LocationId, FindingId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FindingName);

        /// <inheritdoc/>
        public bool Equals(FindingName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(FindingName a, FindingName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(FindingName a, FindingName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>InspectTemplate</c> resource.</summary>
    public sealed partial class InspectTemplateName : gax::IResourceName, sys::IEquatable<InspectTemplateName>
    {
        /// <summary>The possible contents of <see cref="InspectTemplateName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>organizations/{organization}/inspectTemplates/{inspect_template}</c>.
            /// </summary>
            OrganizationInspectTemplate = 1,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/inspectTemplates/{inspect_template}</c>.
            /// </summary>
            ProjectInspectTemplate = 2,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/locations/{location}/inspectTemplates/{inspect_template}</c>.
            /// </summary>
            OrganizationLocationInspectTemplate = 3,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/inspectTemplates/{inspect_template}</c>.
            /// </summary>
            ProjectLocationInspectTemplate = 4
        }

        private static gax::PathTemplate s_organizationInspectTemplate = new gax::PathTemplate("organizations/{organization}/inspectTemplates/{inspect_template}");

        private static gax::PathTemplate s_projectInspectTemplate = new gax::PathTemplate("projects/{project}/inspectTemplates/{inspect_template}");

        private static gax::PathTemplate s_organizationLocationInspectTemplate = new gax::PathTemplate("organizations/{organization}/locations/{location}/inspectTemplates/{inspect_template}");

        private static gax::PathTemplate s_projectLocationInspectTemplate = new gax::PathTemplate("projects/{project}/locations/{location}/inspectTemplates/{inspect_template}");

        /// <summary>Creates a <see cref="InspectTemplateName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="InspectTemplateName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static InspectTemplateName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new InspectTemplateName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="InspectTemplateName"/> with the pattern
        /// <c>organizations/{organization}/inspectTemplates/{inspect_template}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="inspectTemplateId">The <c>InspectTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="InspectTemplateName"/> constructed from the provided ids.</returns>
        public static InspectTemplateName FromOrganizationInspectTemplate(string organizationId, string inspectTemplateId) =>
            new InspectTemplateName(ResourceNameType.OrganizationInspectTemplate, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), inspectTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(inspectTemplateId, nameof(inspectTemplateId)));

        /// <summary>
        /// Creates a <see cref="InspectTemplateName"/> with the pattern
        /// <c>projects/{project}/inspectTemplates/{inspect_template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="inspectTemplateId">The <c>InspectTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="InspectTemplateName"/> constructed from the provided ids.</returns>
        public static InspectTemplateName FromProjectInspectTemplate(string projectId, string inspectTemplateId) =>
            new InspectTemplateName(ResourceNameType.ProjectInspectTemplate, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), inspectTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(inspectTemplateId, nameof(inspectTemplateId)));

        /// <summary>
        /// Creates a <see cref="InspectTemplateName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/inspectTemplates/{inspect_template}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="inspectTemplateId">The <c>InspectTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="InspectTemplateName"/> constructed from the provided ids.</returns>
        public static InspectTemplateName FromOrganizationLocationInspectTemplate(string organizationId, string locationId, string inspectTemplateId) =>
            new InspectTemplateName(ResourceNameType.OrganizationLocationInspectTemplate, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), inspectTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(inspectTemplateId, nameof(inspectTemplateId)));

        /// <summary>
        /// Creates a <see cref="InspectTemplateName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/inspectTemplates/{inspect_template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="inspectTemplateId">The <c>InspectTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="InspectTemplateName"/> constructed from the provided ids.</returns>
        public static InspectTemplateName FromProjectLocationInspectTemplate(string projectId, string locationId, string inspectTemplateId) =>
            new InspectTemplateName(ResourceNameType.ProjectLocationInspectTemplate, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), inspectTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(inspectTemplateId, nameof(inspectTemplateId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InspectTemplateName"/> with pattern
        /// <c>organizations/{organization}/inspectTemplates/{inspect_template}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="inspectTemplateId">The <c>InspectTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InspectTemplateName"/> with pattern
        /// <c>organizations/{organization}/inspectTemplates/{inspect_template}</c>.
        /// </returns>
        public static string Format(string organizationId, string inspectTemplateId) =>
            FormatOrganizationInspectTemplate(organizationId, inspectTemplateId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InspectTemplateName"/> with pattern
        /// <c>organizations/{organization}/inspectTemplates/{inspect_template}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="inspectTemplateId">The <c>InspectTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InspectTemplateName"/> with pattern
        /// <c>organizations/{organization}/inspectTemplates/{inspect_template}</c>.
        /// </returns>
        public static string FormatOrganizationInspectTemplate(string organizationId, string inspectTemplateId) =>
            s_organizationInspectTemplate.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(inspectTemplateId, nameof(inspectTemplateId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InspectTemplateName"/> with pattern
        /// <c>projects/{project}/inspectTemplates/{inspect_template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="inspectTemplateId">The <c>InspectTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InspectTemplateName"/> with pattern
        /// <c>projects/{project}/inspectTemplates/{inspect_template}</c>.
        /// </returns>
        public static string FormatProjectInspectTemplate(string projectId, string inspectTemplateId) =>
            s_projectInspectTemplate.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(inspectTemplateId, nameof(inspectTemplateId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InspectTemplateName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/inspectTemplates/{inspect_template}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="inspectTemplateId">The <c>InspectTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InspectTemplateName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/inspectTemplates/{inspect_template}</c>.
        /// </returns>
        public static string FormatOrganizationLocationInspectTemplate(string organizationId, string locationId, string inspectTemplateId) =>
            s_organizationLocationInspectTemplate.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(inspectTemplateId, nameof(inspectTemplateId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InspectTemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/inspectTemplates/{inspect_template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="inspectTemplateId">The <c>InspectTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InspectTemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/inspectTemplates/{inspect_template}</c>.
        /// </returns>
        public static string FormatProjectLocationInspectTemplate(string projectId, string locationId, string inspectTemplateId) =>
            s_projectLocationInspectTemplate.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(inspectTemplateId, nameof(inspectTemplateId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InspectTemplateName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>organizations/{organization}/inspectTemplates/{inspect_template}</c></description>
        /// </item>
        /// <item><description><c>projects/{project}/inspectTemplates/{inspect_template}</c></description></item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/inspectTemplates/{inspect_template}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/inspectTemplates/{inspect_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="inspectTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="InspectTemplateName"/> if successful.</returns>
        public static InspectTemplateName Parse(string inspectTemplateName) => Parse(inspectTemplateName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InspectTemplateName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>organizations/{organization}/inspectTemplates/{inspect_template}</c></description>
        /// </item>
        /// <item><description><c>projects/{project}/inspectTemplates/{inspect_template}</c></description></item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/inspectTemplates/{inspect_template}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/inspectTemplates/{inspect_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="inspectTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="InspectTemplateName"/> if successful.</returns>
        public static InspectTemplateName Parse(string inspectTemplateName, bool allowUnparsed) =>
            TryParse(inspectTemplateName, allowUnparsed, out InspectTemplateName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InspectTemplateName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>organizations/{organization}/inspectTemplates/{inspect_template}</c></description>
        /// </item>
        /// <item><description><c>projects/{project}/inspectTemplates/{inspect_template}</c></description></item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/inspectTemplates/{inspect_template}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/inspectTemplates/{inspect_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="inspectTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InspectTemplateName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string inspectTemplateName, out InspectTemplateName result) =>
            TryParse(inspectTemplateName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InspectTemplateName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>organizations/{organization}/inspectTemplates/{inspect_template}</c></description>
        /// </item>
        /// <item><description><c>projects/{project}/inspectTemplates/{inspect_template}</c></description></item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/inspectTemplates/{inspect_template}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/inspectTemplates/{inspect_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="inspectTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InspectTemplateName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string inspectTemplateName, bool allowUnparsed, out InspectTemplateName result)
        {
            gax::GaxPreconditions.CheckNotNull(inspectTemplateName, nameof(inspectTemplateName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationInspectTemplate.TryParseName(inspectTemplateName, out resourceName))
            {
                result = FromOrganizationInspectTemplate(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_projectInspectTemplate.TryParseName(inspectTemplateName, out resourceName))
            {
                result = FromProjectInspectTemplate(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_organizationLocationInspectTemplate.TryParseName(inspectTemplateName, out resourceName))
            {
                result = FromOrganizationLocationInspectTemplate(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectLocationInspectTemplate.TryParseName(inspectTemplateName, out resourceName))
            {
                result = FromProjectLocationInspectTemplate(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(inspectTemplateName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private InspectTemplateName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string inspectTemplateId = null, string locationId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            InspectTemplateId = inspectTemplateId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="InspectTemplateName"/> class from the component parts of pattern
        /// <c>organizations/{organization}/inspectTemplates/{inspect_template}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="inspectTemplateId">The <c>InspectTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        public InspectTemplateName(string organizationId, string inspectTemplateId) : this(ResourceNameType.OrganizationInspectTemplate, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), inspectTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(inspectTemplateId, nameof(inspectTemplateId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>InspectTemplate</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string InspectTemplateId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Organization</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.OrganizationInspectTemplate: return s_organizationInspectTemplate.Expand(OrganizationId, InspectTemplateId);
                case ResourceNameType.ProjectInspectTemplate: return s_projectInspectTemplate.Expand(ProjectId, InspectTemplateId);
                case ResourceNameType.OrganizationLocationInspectTemplate: return s_organizationLocationInspectTemplate.Expand(OrganizationId, LocationId, InspectTemplateId);
                case ResourceNameType.ProjectLocationInspectTemplate: return s_projectLocationInspectTemplate.Expand(ProjectId, LocationId, InspectTemplateId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as InspectTemplateName);

        /// <inheritdoc/>
        public bool Equals(InspectTemplateName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(InspectTemplateName a, InspectTemplateName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(InspectTemplateName a, InspectTemplateName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>DeidentifyTemplate</c> resource.</summary>
    public sealed partial class DeidentifyTemplateName : gax::IResourceName, sys::IEquatable<DeidentifyTemplateName>
    {
        /// <summary>The possible contents of <see cref="DeidentifyTemplateName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>organizations/{organization}/deidentifyTemplates/{deidentify_template}</c>
            /// .
            /// </summary>
            OrganizationDeidentifyTemplate = 1,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/deidentifyTemplates/{deidentify_template}</c>.
            /// </summary>
            ProjectDeidentifyTemplate = 2,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/locations/{location}/deidentifyTemplates/{deidentify_template}</c>.
            /// </summary>
            OrganizationLocationDeidentifyTemplate = 3,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/deidentifyTemplates/{deidentify_template}</c>.
            /// </summary>
            ProjectLocationDeidentifyTemplate = 4
        }

        private static gax::PathTemplate s_organizationDeidentifyTemplate = new gax::PathTemplate("organizations/{organization}/deidentifyTemplates/{deidentify_template}");

        private static gax::PathTemplate s_projectDeidentifyTemplate = new gax::PathTemplate("projects/{project}/deidentifyTemplates/{deidentify_template}");

        private static gax::PathTemplate s_organizationLocationDeidentifyTemplate = new gax::PathTemplate("organizations/{organization}/locations/{location}/deidentifyTemplates/{deidentify_template}");

        private static gax::PathTemplate s_projectLocationDeidentifyTemplate = new gax::PathTemplate("projects/{project}/locations/{location}/deidentifyTemplates/{deidentify_template}");

        /// <summary>Creates a <see cref="DeidentifyTemplateName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DeidentifyTemplateName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DeidentifyTemplateName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DeidentifyTemplateName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DeidentifyTemplateName"/> with the pattern
        /// <c>organizations/{organization}/deidentifyTemplates/{deidentify_template}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deidentifyTemplateId">
        /// The <c>DeidentifyTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="DeidentifyTemplateName"/> constructed from the provided ids.</returns>
        public static DeidentifyTemplateName FromOrganizationDeidentifyTemplate(string organizationId, string deidentifyTemplateId) =>
            new DeidentifyTemplateName(ResourceNameType.OrganizationDeidentifyTemplate, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), deidentifyTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(deidentifyTemplateId, nameof(deidentifyTemplateId)));

        /// <summary>
        /// Creates a <see cref="DeidentifyTemplateName"/> with the pattern
        /// <c>projects/{project}/deidentifyTemplates/{deidentify_template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deidentifyTemplateId">
        /// The <c>DeidentifyTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="DeidentifyTemplateName"/> constructed from the provided ids.</returns>
        public static DeidentifyTemplateName FromProjectDeidentifyTemplate(string projectId, string deidentifyTemplateId) =>
            new DeidentifyTemplateName(ResourceNameType.ProjectDeidentifyTemplate, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), deidentifyTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(deidentifyTemplateId, nameof(deidentifyTemplateId)));

        /// <summary>
        /// Creates a <see cref="DeidentifyTemplateName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/deidentifyTemplates/{deidentify_template}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deidentifyTemplateId">
        /// The <c>DeidentifyTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="DeidentifyTemplateName"/> constructed from the provided ids.</returns>
        public static DeidentifyTemplateName FromOrganizationLocationDeidentifyTemplate(string organizationId, string locationId, string deidentifyTemplateId) =>
            new DeidentifyTemplateName(ResourceNameType.OrganizationLocationDeidentifyTemplate, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), deidentifyTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(deidentifyTemplateId, nameof(deidentifyTemplateId)));

        /// <summary>
        /// Creates a <see cref="DeidentifyTemplateName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/deidentifyTemplates/{deidentify_template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deidentifyTemplateId">
        /// The <c>DeidentifyTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="DeidentifyTemplateName"/> constructed from the provided ids.</returns>
        public static DeidentifyTemplateName FromProjectLocationDeidentifyTemplate(string projectId, string locationId, string deidentifyTemplateId) =>
            new DeidentifyTemplateName(ResourceNameType.ProjectLocationDeidentifyTemplate, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), deidentifyTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(deidentifyTemplateId, nameof(deidentifyTemplateId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DeidentifyTemplateName"/> with pattern
        /// <c>organizations/{organization}/deidentifyTemplates/{deidentify_template}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deidentifyTemplateId">
        /// The <c>DeidentifyTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="DeidentifyTemplateName"/> with pattern
        /// <c>organizations/{organization}/deidentifyTemplates/{deidentify_template}</c>.
        /// </returns>
        public static string Format(string organizationId, string deidentifyTemplateId) =>
            FormatOrganizationDeidentifyTemplate(organizationId, deidentifyTemplateId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DeidentifyTemplateName"/> with pattern
        /// <c>organizations/{organization}/deidentifyTemplates/{deidentify_template}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deidentifyTemplateId">
        /// The <c>DeidentifyTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="DeidentifyTemplateName"/> with pattern
        /// <c>organizations/{organization}/deidentifyTemplates/{deidentify_template}</c>.
        /// </returns>
        public static string FormatOrganizationDeidentifyTemplate(string organizationId, string deidentifyTemplateId) =>
            s_organizationDeidentifyTemplate.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(deidentifyTemplateId, nameof(deidentifyTemplateId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DeidentifyTemplateName"/> with pattern
        /// <c>projects/{project}/deidentifyTemplates/{deidentify_template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deidentifyTemplateId">
        /// The <c>DeidentifyTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="DeidentifyTemplateName"/> with pattern
        /// <c>projects/{project}/deidentifyTemplates/{deidentify_template}</c>.
        /// </returns>
        public static string FormatProjectDeidentifyTemplate(string projectId, string deidentifyTemplateId) =>
            s_projectDeidentifyTemplate.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(deidentifyTemplateId, nameof(deidentifyTemplateId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DeidentifyTemplateName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/deidentifyTemplates/{deidentify_template}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deidentifyTemplateId">
        /// The <c>DeidentifyTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="DeidentifyTemplateName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/deidentifyTemplates/{deidentify_template}</c>.
        /// </returns>
        public static string FormatOrganizationLocationDeidentifyTemplate(string organizationId, string locationId, string deidentifyTemplateId) =>
            s_organizationLocationDeidentifyTemplate.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(deidentifyTemplateId, nameof(deidentifyTemplateId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DeidentifyTemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/deidentifyTemplates/{deidentify_template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deidentifyTemplateId">
        /// The <c>DeidentifyTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="DeidentifyTemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/deidentifyTemplates/{deidentify_template}</c>.
        /// </returns>
        public static string FormatProjectLocationDeidentifyTemplate(string projectId, string locationId, string deidentifyTemplateId) =>
            s_projectLocationDeidentifyTemplate.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(deidentifyTemplateId, nameof(deidentifyTemplateId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DeidentifyTemplateName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>organizations/{organization}/deidentifyTemplates/{deidentify_template}</c></description>
        /// </item>
        /// <item><description><c>projects/{project}/deidentifyTemplates/{deidentify_template}</c></description></item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/deidentifyTemplates/{deidentify_template}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/deidentifyTemplates/{deidentify_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="deidentifyTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DeidentifyTemplateName"/> if successful.</returns>
        public static DeidentifyTemplateName Parse(string deidentifyTemplateName) => Parse(deidentifyTemplateName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DeidentifyTemplateName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>organizations/{organization}/deidentifyTemplates/{deidentify_template}</c></description>
        /// </item>
        /// <item><description><c>projects/{project}/deidentifyTemplates/{deidentify_template}</c></description></item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/deidentifyTemplates/{deidentify_template}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/deidentifyTemplates/{deidentify_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="deidentifyTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DeidentifyTemplateName"/> if successful.</returns>
        public static DeidentifyTemplateName Parse(string deidentifyTemplateName, bool allowUnparsed) =>
            TryParse(deidentifyTemplateName, allowUnparsed, out DeidentifyTemplateName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DeidentifyTemplateName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>organizations/{organization}/deidentifyTemplates/{deidentify_template}</c></description>
        /// </item>
        /// <item><description><c>projects/{project}/deidentifyTemplates/{deidentify_template}</c></description></item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/deidentifyTemplates/{deidentify_template}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/deidentifyTemplates/{deidentify_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="deidentifyTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DeidentifyTemplateName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string deidentifyTemplateName, out DeidentifyTemplateName result) =>
            TryParse(deidentifyTemplateName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DeidentifyTemplateName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>organizations/{organization}/deidentifyTemplates/{deidentify_template}</c></description>
        /// </item>
        /// <item><description><c>projects/{project}/deidentifyTemplates/{deidentify_template}</c></description></item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/deidentifyTemplates/{deidentify_template}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/deidentifyTemplates/{deidentify_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="deidentifyTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DeidentifyTemplateName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string deidentifyTemplateName, bool allowUnparsed, out DeidentifyTemplateName result)
        {
            gax::GaxPreconditions.CheckNotNull(deidentifyTemplateName, nameof(deidentifyTemplateName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationDeidentifyTemplate.TryParseName(deidentifyTemplateName, out resourceName))
            {
                result = FromOrganizationDeidentifyTemplate(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_projectDeidentifyTemplate.TryParseName(deidentifyTemplateName, out resourceName))
            {
                result = FromProjectDeidentifyTemplate(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_organizationLocationDeidentifyTemplate.TryParseName(deidentifyTemplateName, out resourceName))
            {
                result = FromOrganizationLocationDeidentifyTemplate(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectLocationDeidentifyTemplate.TryParseName(deidentifyTemplateName, out resourceName))
            {
                result = FromProjectLocationDeidentifyTemplate(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(deidentifyTemplateName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DeidentifyTemplateName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string deidentifyTemplateId = null, string locationId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DeidentifyTemplateId = deidentifyTemplateId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DeidentifyTemplateName"/> class from the component parts of
        /// pattern <c>organizations/{organization}/deidentifyTemplates/{deidentify_template}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deidentifyTemplateId">
        /// The <c>DeidentifyTemplate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public DeidentifyTemplateName(string organizationId, string deidentifyTemplateId) : this(ResourceNameType.OrganizationDeidentifyTemplate, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), deidentifyTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(deidentifyTemplateId, nameof(deidentifyTemplateId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>DeidentifyTemplate</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string DeidentifyTemplateId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Organization</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.OrganizationDeidentifyTemplate: return s_organizationDeidentifyTemplate.Expand(OrganizationId, DeidentifyTemplateId);
                case ResourceNameType.ProjectDeidentifyTemplate: return s_projectDeidentifyTemplate.Expand(ProjectId, DeidentifyTemplateId);
                case ResourceNameType.OrganizationLocationDeidentifyTemplate: return s_organizationLocationDeidentifyTemplate.Expand(OrganizationId, LocationId, DeidentifyTemplateId);
                case ResourceNameType.ProjectLocationDeidentifyTemplate: return s_projectLocationDeidentifyTemplate.Expand(ProjectId, LocationId, DeidentifyTemplateId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DeidentifyTemplateName);

        /// <inheritdoc/>
        public bool Equals(DeidentifyTemplateName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(DeidentifyTemplateName a, DeidentifyTemplateName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(DeidentifyTemplateName a, DeidentifyTemplateName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>JobTrigger</c> resource.</summary>
    public sealed partial class JobTriggerName : gax::IResourceName, sys::IEquatable<JobTriggerName>
    {
        /// <summary>The possible contents of <see cref="JobTriggerName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/jobTriggers/{job_trigger}</c>.</summary>
            ProjectJobTrigger = 1,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/jobTriggers/{job_trigger}</c>.
            /// </summary>
            ProjectLocationJobTrigger = 2
        }

        private static gax::PathTemplate s_projectJobTrigger = new gax::PathTemplate("projects/{project}/jobTriggers/{job_trigger}");

        private static gax::PathTemplate s_projectLocationJobTrigger = new gax::PathTemplate("projects/{project}/locations/{location}/jobTriggers/{job_trigger}");

        /// <summary>Creates a <see cref="JobTriggerName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="JobTriggerName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static JobTriggerName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new JobTriggerName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="JobTriggerName"/> with the pattern <c>projects/{project}/jobTriggers/{job_trigger}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="jobTriggerId">The <c>JobTrigger</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="JobTriggerName"/> constructed from the provided ids.</returns>
        public static JobTriggerName FromProjectJobTrigger(string projectId, string jobTriggerId) =>
            new JobTriggerName(ResourceNameType.ProjectJobTrigger, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), jobTriggerId: gax::GaxPreconditions.CheckNotNullOrEmpty(jobTriggerId, nameof(jobTriggerId)));

        /// <summary>
        /// Creates a <see cref="JobTriggerName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/jobTriggers/{job_trigger}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="jobTriggerId">The <c>JobTrigger</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="JobTriggerName"/> constructed from the provided ids.</returns>
        public static JobTriggerName FromProjectLocationJobTrigger(string projectId, string locationId, string jobTriggerId) =>
            new JobTriggerName(ResourceNameType.ProjectLocationJobTrigger, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), jobTriggerId: gax::GaxPreconditions.CheckNotNullOrEmpty(jobTriggerId, nameof(jobTriggerId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="JobTriggerName"/> with pattern
        /// <c>projects/{project}/jobTriggers/{job_trigger}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="jobTriggerId">The <c>JobTrigger</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="JobTriggerName"/> with pattern
        /// <c>projects/{project}/jobTriggers/{job_trigger}</c>.
        /// </returns>
        public static string Format(string projectId, string jobTriggerId) => FormatProjectJobTrigger(projectId, jobTriggerId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="JobTriggerName"/> with pattern
        /// <c>projects/{project}/jobTriggers/{job_trigger}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="jobTriggerId">The <c>JobTrigger</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="JobTriggerName"/> with pattern
        /// <c>projects/{project}/jobTriggers/{job_trigger}</c>.
        /// </returns>
        public static string FormatProjectJobTrigger(string projectId, string jobTriggerId) =>
            s_projectJobTrigger.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(jobTriggerId, nameof(jobTriggerId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="JobTriggerName"/> with pattern
        /// <c>projects/{project}/locations/{location}/jobTriggers/{job_trigger}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="jobTriggerId">The <c>JobTrigger</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="JobTriggerName"/> with pattern
        /// <c>projects/{project}/locations/{location}/jobTriggers/{job_trigger}</c>.
        /// </returns>
        public static string FormatProjectLocationJobTrigger(string projectId, string locationId, string jobTriggerId) =>
            s_projectLocationJobTrigger.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(jobTriggerId, nameof(jobTriggerId)));

        /// <summary>Parses the given resource name string into a new <see cref="JobTriggerName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/jobTriggers/{job_trigger}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/jobTriggers/{job_trigger}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="jobTriggerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="JobTriggerName"/> if successful.</returns>
        public static JobTriggerName Parse(string jobTriggerName) => Parse(jobTriggerName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="JobTriggerName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/jobTriggers/{job_trigger}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/jobTriggers/{job_trigger}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="jobTriggerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="JobTriggerName"/> if successful.</returns>
        public static JobTriggerName Parse(string jobTriggerName, bool allowUnparsed) =>
            TryParse(jobTriggerName, allowUnparsed, out JobTriggerName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="JobTriggerName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/jobTriggers/{job_trigger}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/jobTriggers/{job_trigger}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="jobTriggerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="JobTriggerName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string jobTriggerName, out JobTriggerName result) =>
            TryParse(jobTriggerName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="JobTriggerName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/jobTriggers/{job_trigger}</c></description></item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/jobTriggers/{job_trigger}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="jobTriggerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="JobTriggerName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string jobTriggerName, bool allowUnparsed, out JobTriggerName result)
        {
            gax::GaxPreconditions.CheckNotNull(jobTriggerName, nameof(jobTriggerName));
            gax::TemplatedResourceName resourceName;
            if (s_projectJobTrigger.TryParseName(jobTriggerName, out resourceName))
            {
                result = FromProjectJobTrigger(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_projectLocationJobTrigger.TryParseName(jobTriggerName, out resourceName))
            {
                result = FromProjectLocationJobTrigger(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(jobTriggerName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private JobTriggerName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string jobTriggerId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            JobTriggerId = jobTriggerId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="JobTriggerName"/> class from the component parts of pattern
        /// <c>projects/{project}/jobTriggers/{job_trigger}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="jobTriggerId">The <c>JobTrigger</c> ID. Must not be <c>null</c> or empty.</param>
        public JobTriggerName(string projectId, string jobTriggerId) : this(ResourceNameType.ProjectJobTrigger, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), jobTriggerId: gax::GaxPreconditions.CheckNotNullOrEmpty(jobTriggerId, nameof(jobTriggerId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>JobTrigger</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string JobTriggerId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectJobTrigger: return s_projectJobTrigger.Expand(ProjectId, JobTriggerId);
                case ResourceNameType.ProjectLocationJobTrigger: return s_projectLocationJobTrigger.Expand(ProjectId, LocationId, JobTriggerId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as JobTriggerName);

        /// <inheritdoc/>
        public bool Equals(JobTriggerName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(JobTriggerName a, JobTriggerName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(JobTriggerName a, JobTriggerName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>DlpJob</c> resource.</summary>
    public sealed partial class DlpJobName : gax::IResourceName, sys::IEquatable<DlpJobName>
    {
        /// <summary>The possible contents of <see cref="DlpJobName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/dlpJobs/{dlp_job}</c>.</summary>
            ProjectDlpJob = 1,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/dlpJobs/{dlp_job}</c>.
            /// </summary>
            ProjectLocationDlpJob = 2
        }

        private static gax::PathTemplate s_projectDlpJob = new gax::PathTemplate("projects/{project}/dlpJobs/{dlp_job}");

        private static gax::PathTemplate s_projectLocationDlpJob = new gax::PathTemplate("projects/{project}/locations/{location}/dlpJobs/{dlp_job}");

        /// <summary>Creates a <see cref="DlpJobName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DlpJobName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DlpJobName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DlpJobName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DlpJobName"/> with the pattern <c>projects/{project}/dlpJobs/{dlp_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dlpJobId">The <c>DlpJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DlpJobName"/> constructed from the provided ids.</returns>
        public static DlpJobName FromProjectDlpJob(string projectId, string dlpJobId) =>
            new DlpJobName(ResourceNameType.ProjectDlpJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), dlpJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(dlpJobId, nameof(dlpJobId)));

        /// <summary>
        /// Creates a <see cref="DlpJobName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/dlpJobs/{dlp_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dlpJobId">The <c>DlpJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DlpJobName"/> constructed from the provided ids.</returns>
        public static DlpJobName FromProjectLocationDlpJob(string projectId, string locationId, string dlpJobId) =>
            new DlpJobName(ResourceNameType.ProjectLocationDlpJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dlpJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(dlpJobId, nameof(dlpJobId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DlpJobName"/> with pattern
        /// <c>projects/{project}/dlpJobs/{dlp_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dlpJobId">The <c>DlpJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DlpJobName"/> with pattern
        /// <c>projects/{project}/dlpJobs/{dlp_job}</c>.
        /// </returns>
        public static string Format(string projectId, string dlpJobId) => FormatProjectDlpJob(projectId, dlpJobId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DlpJobName"/> with pattern
        /// <c>projects/{project}/dlpJobs/{dlp_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dlpJobId">The <c>DlpJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DlpJobName"/> with pattern
        /// <c>projects/{project}/dlpJobs/{dlp_job}</c>.
        /// </returns>
        public static string FormatProjectDlpJob(string projectId, string dlpJobId) =>
            s_projectDlpJob.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dlpJobId, nameof(dlpJobId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DlpJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dlpJobs/{dlp_job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dlpJobId">The <c>DlpJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DlpJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dlpJobs/{dlp_job}</c>.
        /// </returns>
        public static string FormatProjectLocationDlpJob(string projectId, string locationId, string dlpJobId) =>
            s_projectLocationDlpJob.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dlpJobId, nameof(dlpJobId)));

        /// <summary>Parses the given resource name string into a new <see cref="DlpJobName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/dlpJobs/{dlp_job}</c></description></item>
        /// <item><description><c>projects/{project}/locations/{location}/dlpJobs/{dlp_job}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="dlpJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DlpJobName"/> if successful.</returns>
        public static DlpJobName Parse(string dlpJobName) => Parse(dlpJobName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DlpJobName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/dlpJobs/{dlp_job}</c></description></item>
        /// <item><description><c>projects/{project}/locations/{location}/dlpJobs/{dlp_job}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dlpJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DlpJobName"/> if successful.</returns>
        public static DlpJobName Parse(string dlpJobName, bool allowUnparsed) =>
            TryParse(dlpJobName, allowUnparsed, out DlpJobName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DlpJobName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/dlpJobs/{dlp_job}</c></description></item>
        /// <item><description><c>projects/{project}/locations/{location}/dlpJobs/{dlp_job}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="dlpJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DlpJobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dlpJobName, out DlpJobName result) => TryParse(dlpJobName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DlpJobName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/dlpJobs/{dlp_job}</c></description></item>
        /// <item><description><c>projects/{project}/locations/{location}/dlpJobs/{dlp_job}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dlpJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DlpJobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dlpJobName, bool allowUnparsed, out DlpJobName result)
        {
            gax::GaxPreconditions.CheckNotNull(dlpJobName, nameof(dlpJobName));
            gax::TemplatedResourceName resourceName;
            if (s_projectDlpJob.TryParseName(dlpJobName, out resourceName))
            {
                result = FromProjectDlpJob(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_projectLocationDlpJob.TryParseName(dlpJobName, out resourceName))
            {
                result = FromProjectLocationDlpJob(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(dlpJobName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DlpJobName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string dlpJobId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DlpJobId = dlpJobId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DlpJobName"/> class from the component parts of pattern
        /// <c>projects/{project}/dlpJobs/{dlp_job}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dlpJobId">The <c>DlpJob</c> ID. Must not be <c>null</c> or empty.</param>
        public DlpJobName(string projectId, string dlpJobId) : this(ResourceNameType.ProjectDlpJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), dlpJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(dlpJobId, nameof(dlpJobId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>DlpJob</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string DlpJobId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectDlpJob: return s_projectDlpJob.Expand(ProjectId, DlpJobId);
                case ResourceNameType.ProjectLocationDlpJob: return s_projectLocationDlpJob.Expand(ProjectId, LocationId, DlpJobId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DlpJobName);

        /// <inheritdoc/>
        public bool Equals(DlpJobName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(DlpJobName a, DlpJobName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(DlpJobName a, DlpJobName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>StoredInfoType</c> resource.</summary>
    public sealed partial class StoredInfoTypeName : gax::IResourceName, sys::IEquatable<StoredInfoTypeName>
    {
        /// <summary>The possible contents of <see cref="StoredInfoTypeName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>organizations/{organization}/storedInfoTypes/{stored_info_type}</c>.
            /// </summary>
            OrganizationStoredInfoType = 1,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/storedInfoTypes/{stored_info_type}</c>.
            /// </summary>
            ProjectStoredInfoType = 2,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/locations/{location}/storedInfoTypes/{stored_info_type}</c>.
            /// </summary>
            OrganizationLocationStoredInfoType = 3,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/storedInfoTypes/{stored_info_type}</c>.
            /// </summary>
            ProjectLocationStoredInfoType = 4
        }

        private static gax::PathTemplate s_organizationStoredInfoType = new gax::PathTemplate("organizations/{organization}/storedInfoTypes/{stored_info_type}");

        private static gax::PathTemplate s_projectStoredInfoType = new gax::PathTemplate("projects/{project}/storedInfoTypes/{stored_info_type}");

        private static gax::PathTemplate s_organizationLocationStoredInfoType = new gax::PathTemplate("organizations/{organization}/locations/{location}/storedInfoTypes/{stored_info_type}");

        private static gax::PathTemplate s_projectLocationStoredInfoType = new gax::PathTemplate("projects/{project}/locations/{location}/storedInfoTypes/{stored_info_type}");

        /// <summary>Creates a <see cref="StoredInfoTypeName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="StoredInfoTypeName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static StoredInfoTypeName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new StoredInfoTypeName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="StoredInfoTypeName"/> with the pattern
        /// <c>organizations/{organization}/storedInfoTypes/{stored_info_type}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="storedInfoTypeId">The <c>StoredInfoType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="StoredInfoTypeName"/> constructed from the provided ids.</returns>
        public static StoredInfoTypeName FromOrganizationStoredInfoType(string organizationId, string storedInfoTypeId) =>
            new StoredInfoTypeName(ResourceNameType.OrganizationStoredInfoType, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), storedInfoTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(storedInfoTypeId, nameof(storedInfoTypeId)));

        /// <summary>
        /// Creates a <see cref="StoredInfoTypeName"/> with the pattern
        /// <c>projects/{project}/storedInfoTypes/{stored_info_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="storedInfoTypeId">The <c>StoredInfoType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="StoredInfoTypeName"/> constructed from the provided ids.</returns>
        public static StoredInfoTypeName FromProjectStoredInfoType(string projectId, string storedInfoTypeId) =>
            new StoredInfoTypeName(ResourceNameType.ProjectStoredInfoType, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), storedInfoTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(storedInfoTypeId, nameof(storedInfoTypeId)));

        /// <summary>
        /// Creates a <see cref="StoredInfoTypeName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/storedInfoTypes/{stored_info_type}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="storedInfoTypeId">The <c>StoredInfoType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="StoredInfoTypeName"/> constructed from the provided ids.</returns>
        public static StoredInfoTypeName FromOrganizationLocationStoredInfoType(string organizationId, string locationId, string storedInfoTypeId) =>
            new StoredInfoTypeName(ResourceNameType.OrganizationLocationStoredInfoType, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), storedInfoTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(storedInfoTypeId, nameof(storedInfoTypeId)));

        /// <summary>
        /// Creates a <see cref="StoredInfoTypeName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/storedInfoTypes/{stored_info_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="storedInfoTypeId">The <c>StoredInfoType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="StoredInfoTypeName"/> constructed from the provided ids.</returns>
        public static StoredInfoTypeName FromProjectLocationStoredInfoType(string projectId, string locationId, string storedInfoTypeId) =>
            new StoredInfoTypeName(ResourceNameType.ProjectLocationStoredInfoType, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), storedInfoTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(storedInfoTypeId, nameof(storedInfoTypeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="StoredInfoTypeName"/> with pattern
        /// <c>organizations/{organization}/storedInfoTypes/{stored_info_type}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="storedInfoTypeId">The <c>StoredInfoType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="StoredInfoTypeName"/> with pattern
        /// <c>organizations/{organization}/storedInfoTypes/{stored_info_type}</c>.
        /// </returns>
        public static string Format(string organizationId, string storedInfoTypeId) =>
            FormatOrganizationStoredInfoType(organizationId, storedInfoTypeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="StoredInfoTypeName"/> with pattern
        /// <c>organizations/{organization}/storedInfoTypes/{stored_info_type}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="storedInfoTypeId">The <c>StoredInfoType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="StoredInfoTypeName"/> with pattern
        /// <c>organizations/{organization}/storedInfoTypes/{stored_info_type}</c>.
        /// </returns>
        public static string FormatOrganizationStoredInfoType(string organizationId, string storedInfoTypeId) =>
            s_organizationStoredInfoType.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(storedInfoTypeId, nameof(storedInfoTypeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="StoredInfoTypeName"/> with pattern
        /// <c>projects/{project}/storedInfoTypes/{stored_info_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="storedInfoTypeId">The <c>StoredInfoType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="StoredInfoTypeName"/> with pattern
        /// <c>projects/{project}/storedInfoTypes/{stored_info_type}</c>.
        /// </returns>
        public static string FormatProjectStoredInfoType(string projectId, string storedInfoTypeId) =>
            s_projectStoredInfoType.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(storedInfoTypeId, nameof(storedInfoTypeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="StoredInfoTypeName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/storedInfoTypes/{stored_info_type}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="storedInfoTypeId">The <c>StoredInfoType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="StoredInfoTypeName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/storedInfoTypes/{stored_info_type}</c>.
        /// </returns>
        public static string FormatOrganizationLocationStoredInfoType(string organizationId, string locationId, string storedInfoTypeId) =>
            s_organizationLocationStoredInfoType.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(storedInfoTypeId, nameof(storedInfoTypeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="StoredInfoTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/storedInfoTypes/{stored_info_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="storedInfoTypeId">The <c>StoredInfoType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="StoredInfoTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/storedInfoTypes/{stored_info_type}</c>.
        /// </returns>
        public static string FormatProjectLocationStoredInfoType(string projectId, string locationId, string storedInfoTypeId) =>
            s_projectLocationStoredInfoType.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(storedInfoTypeId, nameof(storedInfoTypeId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="StoredInfoTypeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>organizations/{organization}/storedInfoTypes/{stored_info_type}</c></description>
        /// </item>
        /// <item><description><c>projects/{project}/storedInfoTypes/{stored_info_type}</c></description></item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/storedInfoTypes/{stored_info_type}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/storedInfoTypes/{stored_info_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="storedInfoTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="StoredInfoTypeName"/> if successful.</returns>
        public static StoredInfoTypeName Parse(string storedInfoTypeName) => Parse(storedInfoTypeName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="StoredInfoTypeName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>organizations/{organization}/storedInfoTypes/{stored_info_type}</c></description>
        /// </item>
        /// <item><description><c>projects/{project}/storedInfoTypes/{stored_info_type}</c></description></item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/storedInfoTypes/{stored_info_type}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/storedInfoTypes/{stored_info_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="storedInfoTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="StoredInfoTypeName"/> if successful.</returns>
        public static StoredInfoTypeName Parse(string storedInfoTypeName, bool allowUnparsed) =>
            TryParse(storedInfoTypeName, allowUnparsed, out StoredInfoTypeName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="StoredInfoTypeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>organizations/{organization}/storedInfoTypes/{stored_info_type}</c></description>
        /// </item>
        /// <item><description><c>projects/{project}/storedInfoTypes/{stored_info_type}</c></description></item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/storedInfoTypes/{stored_info_type}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/storedInfoTypes/{stored_info_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="storedInfoTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="StoredInfoTypeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string storedInfoTypeName, out StoredInfoTypeName result) =>
            TryParse(storedInfoTypeName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="StoredInfoTypeName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>organizations/{organization}/storedInfoTypes/{stored_info_type}</c></description>
        /// </item>
        /// <item><description><c>projects/{project}/storedInfoTypes/{stored_info_type}</c></description></item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/storedInfoTypes/{stored_info_type}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/storedInfoTypes/{stored_info_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="storedInfoTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="StoredInfoTypeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string storedInfoTypeName, bool allowUnparsed, out StoredInfoTypeName result)
        {
            gax::GaxPreconditions.CheckNotNull(storedInfoTypeName, nameof(storedInfoTypeName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationStoredInfoType.TryParseName(storedInfoTypeName, out resourceName))
            {
                result = FromOrganizationStoredInfoType(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_projectStoredInfoType.TryParseName(storedInfoTypeName, out resourceName))
            {
                result = FromProjectStoredInfoType(resourceName[0], resourceName[1]);
                return true;
            }
            if (s_organizationLocationStoredInfoType.TryParseName(storedInfoTypeName, out resourceName))
            {
                result = FromOrganizationLocationStoredInfoType(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectLocationStoredInfoType.TryParseName(storedInfoTypeName, out resourceName))
            {
                result = FromProjectLocationStoredInfoType(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(storedInfoTypeName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private StoredInfoTypeName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string organizationId = null, string projectId = null, string storedInfoTypeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
            StoredInfoTypeId = storedInfoTypeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="StoredInfoTypeName"/> class from the component parts of pattern
        /// <c>organizations/{organization}/storedInfoTypes/{stored_info_type}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="storedInfoTypeId">The <c>StoredInfoType</c> ID. Must not be <c>null</c> or empty.</param>
        public StoredInfoTypeName(string organizationId, string storedInfoTypeId) : this(ResourceNameType.OrganizationStoredInfoType, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), storedInfoTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(storedInfoTypeId, nameof(storedInfoTypeId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Organization</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>StoredInfoType</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string StoredInfoTypeId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.OrganizationStoredInfoType: return s_organizationStoredInfoType.Expand(OrganizationId, StoredInfoTypeId);
                case ResourceNameType.ProjectStoredInfoType: return s_projectStoredInfoType.Expand(ProjectId, StoredInfoTypeId);
                case ResourceNameType.OrganizationLocationStoredInfoType: return s_organizationLocationStoredInfoType.Expand(OrganizationId, LocationId, StoredInfoTypeId);
                case ResourceNameType.ProjectLocationStoredInfoType: return s_projectLocationStoredInfoType.Expand(ProjectId, LocationId, StoredInfoTypeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as StoredInfoTypeName);

        /// <inheritdoc/>
        public bool Equals(StoredInfoTypeName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(StoredInfoTypeName a, StoredInfoTypeName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(StoredInfoTypeName a, StoredInfoTypeName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>OrganizationLocation</c> resource.</summary>
    public sealed partial class OrganizationLocationName : gax::IResourceName, sys::IEquatable<OrganizationLocationName>
    {
        /// <summary>The possible contents of <see cref="OrganizationLocationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>organizations/{organization}/locations/{location}</c>.
            /// </summary>
            OrganizationLocation = 1
        }

        private static gax::PathTemplate s_organizationLocation = new gax::PathTemplate("organizations/{organization}/locations/{location}");

        /// <summary>Creates a <see cref="OrganizationLocationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="OrganizationLocationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static OrganizationLocationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new OrganizationLocationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="OrganizationLocationName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="OrganizationLocationName"/> constructed from the provided ids.
        /// </returns>
        public static OrganizationLocationName FromOrganizationLocation(string organizationId, string locationId) =>
            new OrganizationLocationName(ResourceNameType.OrganizationLocation, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OrganizationLocationName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OrganizationLocationName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}</c>.
        /// </returns>
        public static string Format(string organizationId, string locationId) =>
            FormatOrganizationLocation(organizationId, locationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OrganizationLocationName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OrganizationLocationName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}</c>.
        /// </returns>
        public static string FormatOrganizationLocation(string organizationId, string locationId) =>
            s_organizationLocation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OrganizationLocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/locations/{location}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="organizationLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OrganizationLocationName"/> if successful.</returns>
        public static OrganizationLocationName Parse(string organizationLocationName) =>
            Parse(organizationLocationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OrganizationLocationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/locations/{location}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="organizationLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="OrganizationLocationName"/> if successful.</returns>
        public static OrganizationLocationName Parse(string organizationLocationName, bool allowUnparsed) =>
            TryParse(organizationLocationName, allowUnparsed, out OrganizationLocationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OrganizationLocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/locations/{location}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="organizationLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OrganizationLocationName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string organizationLocationName, out OrganizationLocationName result) =>
            TryParse(organizationLocationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OrganizationLocationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/locations/{location}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="organizationLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OrganizationLocationName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string organizationLocationName, bool allowUnparsed, out OrganizationLocationName result)
        {
            gax::GaxPreconditions.CheckNotNull(organizationLocationName, nameof(organizationLocationName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationLocation.TryParseName(organizationLocationName, out resourceName))
            {
                result = FromOrganizationLocation(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(organizationLocationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private OrganizationLocationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string organizationId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            OrganizationId = organizationId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="OrganizationLocationName"/> class from the component parts of
        /// pattern <c>organizations/{organization}/locations/{location}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        public OrganizationLocationName(string organizationId, string locationId) : this(ResourceNameType.OrganizationLocation, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Organization</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.OrganizationLocation: return s_organizationLocation.Expand(OrganizationId, LocationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as OrganizationLocationName);

        /// <inheritdoc/>
        public bool Equals(OrganizationLocationName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(OrganizationLocationName a, OrganizationLocationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(OrganizationLocationName a, OrganizationLocationName b) => !(a == b);
    }

    public partial class Finding
    {
        /// <summary>
        /// <see cref="DlpJobName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        public DlpJobName ResourceNameAsDlpJobName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : DlpJobName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="JobTriggerName"/>-typed view over the <see cref="TriggerName"/> resource name property.
        /// </summary>
        public JobTriggerName TriggerNameAsJobTriggerName
        {
            get => string.IsNullOrEmpty(TriggerName) ? null : JobTriggerName.Parse(TriggerName, allowUnparsed: true);
            set => TriggerName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="DlpJobName"/>-typed view over the <see cref="JobName"/> resource name property.
        /// </summary>
        public DlpJobName JobNameAsDlpJobName
        {
            get => string.IsNullOrEmpty(JobName) ? null : DlpJobName.Parse(JobName, allowUnparsed: true);
            set => JobName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gcdv::FindingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::FindingName FindingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::FindingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class RedactImageRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeidentifyContentRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ReidentifyContentRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class InspectContentRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class InspectTemplate
    {
        /// <summary>
        /// <see cref="gcdv::InspectTemplateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::InspectTemplateName InspectTemplateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::InspectTemplateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeidentifyTemplate
    {
        /// <summary>
        /// <see cref="gcdv::DeidentifyTemplateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DeidentifyTemplateName DeidentifyTemplateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DeidentifyTemplateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class JobTrigger
    {
        /// <summary>
        /// <see cref="gcdv::JobTriggerName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::JobTriggerName JobTriggerName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::JobTriggerName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateInspectTemplateRequest
    {
        /// <summary>
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::OrganizationName ParentAsOrganizationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::OrganizationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="OrganizationLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationLocationName ParentAsOrganizationLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrganizationLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (gagr::OrganizationName.TryParse(Parent, out gagr::OrganizationName organization))
                {
                    return organization;
                }
                if (gagr::ProjectName.TryParse(Parent, out gagr::ProjectName project))
                {
                    return project;
                }
                if (OrganizationLocationName.TryParse(Parent, out OrganizationLocationName organizationLocation))
                {
                    return organizationLocation;
                }
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class UpdateInspectTemplateRequest
    {
        /// <summary>
        /// <see cref="gcdv::InspectTemplateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::InspectTemplateName InspectTemplateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::InspectTemplateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetInspectTemplateRequest
    {
        /// <summary>
        /// <see cref="gcdv::InspectTemplateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::InspectTemplateName InspectTemplateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::InspectTemplateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListInspectTemplatesRequest
    {
        /// <summary>
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::OrganizationName ParentAsOrganizationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::OrganizationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="OrganizationLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationLocationName ParentAsOrganizationLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrganizationLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (gagr::OrganizationName.TryParse(Parent, out gagr::OrganizationName organization))
                {
                    return organization;
                }
                if (gagr::ProjectName.TryParse(Parent, out gagr::ProjectName project))
                {
                    return project;
                }
                if (OrganizationLocationName.TryParse(Parent, out OrganizationLocationName organizationLocation))
                {
                    return organizationLocation;
                }
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteInspectTemplateRequest
    {
        /// <summary>
        /// <see cref="gcdv::InspectTemplateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::InspectTemplateName InspectTemplateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::InspectTemplateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateJobTriggerRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ActivateJobTriggerRequest
    {
        /// <summary>
        /// <see cref="gcdv::JobTriggerName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::JobTriggerName JobTriggerName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::JobTriggerName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class UpdateJobTriggerRequest
    {
        /// <summary>
        /// <see cref="gcdv::JobTriggerName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::JobTriggerName JobTriggerName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::JobTriggerName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetJobTriggerRequest
    {
        /// <summary>
        /// <see cref="gcdv::JobTriggerName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::JobTriggerName JobTriggerName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::JobTriggerName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateDlpJobRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListJobTriggersRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteJobTriggerRequest
    {
        /// <summary>
        /// <see cref="gcdv::JobTriggerName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::JobTriggerName JobTriggerName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::JobTriggerName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DlpJob
    {
        /// <summary>
        /// <see cref="gcdv::DlpJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DlpJobName DlpJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DlpJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetDlpJobRequest
    {
        /// <summary>
        /// <see cref="gcdv::DlpJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DlpJobName DlpJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DlpJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDlpJobsRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CancelDlpJobRequest
    {
        /// <summary>
        /// <see cref="gcdv::DlpJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DlpJobName DlpJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DlpJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class FinishDlpJobRequest
    {
        /// <summary>
        /// <see cref="gcdv::DlpJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DlpJobName DlpJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DlpJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteDlpJobRequest
    {
        /// <summary>
        /// <see cref="gcdv::DlpJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DlpJobName DlpJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DlpJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateDeidentifyTemplateRequest
    {
        /// <summary>
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::OrganizationName ParentAsOrganizationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::OrganizationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="OrganizationLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationLocationName ParentAsOrganizationLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrganizationLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (gagr::OrganizationName.TryParse(Parent, out gagr::OrganizationName organization))
                {
                    return organization;
                }
                if (gagr::ProjectName.TryParse(Parent, out gagr::ProjectName project))
                {
                    return project;
                }
                if (OrganizationLocationName.TryParse(Parent, out OrganizationLocationName organizationLocation))
                {
                    return organizationLocation;
                }
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class UpdateDeidentifyTemplateRequest
    {
        /// <summary>
        /// <see cref="gcdv::DeidentifyTemplateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DeidentifyTemplateName DeidentifyTemplateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DeidentifyTemplateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetDeidentifyTemplateRequest
    {
        /// <summary>
        /// <see cref="gcdv::DeidentifyTemplateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DeidentifyTemplateName DeidentifyTemplateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DeidentifyTemplateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDeidentifyTemplatesRequest
    {
        /// <summary>
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::OrganizationName ParentAsOrganizationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::OrganizationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="OrganizationLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationLocationName ParentAsOrganizationLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrganizationLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (gagr::OrganizationName.TryParse(Parent, out gagr::OrganizationName organization))
                {
                    return organization;
                }
                if (gagr::ProjectName.TryParse(Parent, out gagr::ProjectName project))
                {
                    return project;
                }
                if (OrganizationLocationName.TryParse(Parent, out OrganizationLocationName organizationLocation))
                {
                    return organizationLocation;
                }
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteDeidentifyTemplateRequest
    {
        /// <summary>
        /// <see cref="gcdv::DeidentifyTemplateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DeidentifyTemplateName DeidentifyTemplateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DeidentifyTemplateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class StoredInfoType
    {
        /// <summary>
        /// <see cref="gcdv::StoredInfoTypeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::StoredInfoTypeName StoredInfoTypeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::StoredInfoTypeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateStoredInfoTypeRequest
    {
        /// <summary>
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::OrganizationName ParentAsOrganizationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::OrganizationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="OrganizationLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationLocationName ParentAsOrganizationLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrganizationLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (gagr::OrganizationName.TryParse(Parent, out gagr::OrganizationName organization))
                {
                    return organization;
                }
                if (gagr::ProjectName.TryParse(Parent, out gagr::ProjectName project))
                {
                    return project;
                }
                if (OrganizationLocationName.TryParse(Parent, out OrganizationLocationName organizationLocation))
                {
                    return organizationLocation;
                }
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class UpdateStoredInfoTypeRequest
    {
        /// <summary>
        /// <see cref="gcdv::StoredInfoTypeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::StoredInfoTypeName StoredInfoTypeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::StoredInfoTypeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetStoredInfoTypeRequest
    {
        /// <summary>
        /// <see cref="gcdv::StoredInfoTypeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::StoredInfoTypeName StoredInfoTypeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::StoredInfoTypeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListStoredInfoTypesRequest
    {
        /// <summary>
        /// <see cref="gagr::OrganizationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::OrganizationName ParentAsOrganizationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::OrganizationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="OrganizationLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationLocationName ParentAsOrganizationLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrganizationLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (gagr::OrganizationName.TryParse(Parent, out gagr::OrganizationName organization))
                {
                    return organization;
                }
                if (gagr::ProjectName.TryParse(Parent, out gagr::ProjectName project))
                {
                    return project;
                }
                if (OrganizationLocationName.TryParse(Parent, out OrganizationLocationName organizationLocation))
                {
                    return organizationLocation;
                }
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteStoredInfoTypeRequest
    {
        /// <summary>
        /// <see cref="gcdv::StoredInfoTypeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::StoredInfoTypeName StoredInfoTypeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::StoredInfoTypeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class HybridInspectJobTriggerRequest
    {
        /// <summary>
        /// <see cref="gcdv::JobTriggerName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::JobTriggerName JobTriggerName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::JobTriggerName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class HybridInspectDlpJobRequest
    {
        /// <summary>
        /// <see cref="gcdv::DlpJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DlpJobName DlpJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DlpJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
