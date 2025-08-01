/* SPDX-License-Identifier: Apache-2.0
*
* The OpenSearch Contributors require contributions made to
* this file be licensed under the Apache-2.0 license or a
* compatible open source license.
*/
/*
* Modifications Copyright OpenSearch Contributors. See
* GitHub history for details.
*
*  Licensed to Elasticsearch B.V. under one or more contributor
*  license agreements. See the NOTICE file distributed with
*  this work for additional information regarding copyright
*  ownership. Elasticsearch B.V. licenses this file to you under
*  the Apache License, Version 2.0 (the "License"); you may
*  not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
*   http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing,
*  software distributed under the License is distributed on an
*  "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
*  KIND, either express or implied.  See the License for the
*  specific language governing permissions and limitations
*  under the License.
*/
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//
// This file is automatically generated
// Please do not edit these files manually
// Run the following in the root of the repos:
//
//      *NIX        :   ./build.sh codegen
//      Windows     :   build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.Text;
using OpenSearch.Net;
using OpenSearch.Net.Specification.SnapshotApi;
using OpenSearch.Net.Utf8Json;

// ReSharper disable RedundantBaseConstructorCall
// ReSharper disable UnusedTypeParameter
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
namespace OpenSearch.Client
{
    [InterfaceDataContract]
    public partial interface ICleanupRepositoryRequest
        : IRequest<CleanupRepositoryRequestParameters>
    {
        [IgnoreDataMember]
        Name RepositoryName { get; }
    }

    /// <summary>Request for CleanupRepository <para>https://opensearch.org/docs/latest</para></summary>
    public partial class CleanupRepositoryRequest
        : PlainRequestBase<CleanupRepositoryRequestParameters>,
            ICleanupRepositoryRequest
    {
        protected ICleanupRepositoryRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotCleanupRepository;

        /// <summary>/_snapshot/{repository}/_cleanup</summary>
        /// <param name="repository">this parameter is required</param>
        public CleanupRepositoryRequest(Name repository)
            : base(r => r.Required("repository", repository)) { }

        /// <summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
        [SerializationConstructor]
        protected CleanupRepositoryRequest()
            : base() { }

        // values part of the url path
        [IgnoreDataMember]
        Name ICleanupRepositoryRequest.RepositoryName => Self.RouteValues.Get<Name>("repository");

        // Request parameters
        /// <summary>
        /// The amount of time to wait for a response from the cluster manager node. For more information about supported time units, see <a
        /// href="https://opensearch.org/docs/latest/api-reference/common-parameters/#time-units">Common parameters</a>.
        /// </summary>
        /// <remarks>Supported by OpenSearch servers of version 2.0.0 or greater.</remarks>
        public Time ClusterManagerTimeout
        {
            get => Q<Time>("cluster_manager_timeout");
            set => Q("cluster_manager_timeout", value);
        }

        /// <summary>Period to wait for a connection to the cluster-manager node.</summary>
        [Obsolete(
            "Deprecated as of: 2.0.0, reason: To promote inclusive language, use `cluster_manager_timeout` instead."
        )]
        public Time MasterTimeout
        {
            get => Q<Time>("master_timeout");
            set => Q("master_timeout", value);
        }

        /// <summary>The amount of time to wait for a response.</summary>
        public Time Timeout
        {
            get => Q<Time>("timeout");
            set => Q("timeout", value);
        }
    }

    [InterfaceDataContract]
    public partial interface ICloneSnapshotRequest : IRequest<CloneSnapshotRequestParameters>
    {
        [IgnoreDataMember]
        Name RepositoryName { get; }

        [IgnoreDataMember]
        Name Snapshot { get; }

        [IgnoreDataMember]
        Name TargetSnapshot { get; }
    }

    /// <summary>Request for Clone <para>https://opensearch.org/docs/latest</para></summary>
    public partial class CloneSnapshotRequest
        : PlainRequestBase<CloneSnapshotRequestParameters>,
            ICloneSnapshotRequest
    {
        protected ICloneSnapshotRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotClone;

        /// <summary>/_snapshot/{repository}/{snapshot}/_clone/{target_snapshot}</summary>
        /// <param name="repository">this parameter is required</param>
        /// <param name="snapshot">this parameter is required</param>
        /// <param name="targetSnapshot">this parameter is required</param>
        public CloneSnapshotRequest(Name repository, Name snapshot, Name targetSnapshot)
            : base(r =>
                r.Required("repository", repository)
                    .Required("snapshot", snapshot)
                    .Required("target_snapshot", targetSnapshot)
            ) { }

        /// <summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
        [SerializationConstructor]
        protected CloneSnapshotRequest()
            : base() { }

        // values part of the url path
        [IgnoreDataMember]
        Name ICloneSnapshotRequest.RepositoryName => Self.RouteValues.Get<Name>("repository");

        [IgnoreDataMember]
        Name ICloneSnapshotRequest.Snapshot => Self.RouteValues.Get<Name>("snapshot");

        [IgnoreDataMember]
        Name ICloneSnapshotRequest.TargetSnapshot => Self.RouteValues.Get<Name>("target_snapshot");

        // Request parameters
        /// <summary>
        /// The amount of time to wait for a response from the cluster manager node. For more information about supported time units, see <a
        /// href="https://opensearch.org/docs/latest/api-reference/common-parameters/#time-units">Common parameters</a>.
        /// </summary>
        /// <remarks>Supported by OpenSearch servers of version 2.0.0 or greater.</remarks>
        public Time ClusterManagerTimeout
        {
            get => Q<Time>("cluster_manager_timeout");
            set => Q("cluster_manager_timeout", value);
        }

        /// <summary>Explicit operation timeout for connection to cluster-manager node.</summary>
        [Obsolete(
            "Deprecated as of: 2.0.0, reason: To promote inclusive language, use `cluster_manager_timeout` instead."
        )]
        public Time MasterTimeout
        {
            get => Q<Time>("master_timeout");
            set => Q("master_timeout", value);
        }
    }

    [InterfaceDataContract]
    public partial interface ISnapshotRequest : IRequest<SnapshotRequestParameters>
    {
        [IgnoreDataMember]
        Name RepositoryName { get; }

        [IgnoreDataMember]
        Name Snapshot { get; }
    }

    /// <summary>Request for Snapshot <para>https://opensearch.org/docs/latest/api-reference/snapshots/create-snapshot/</para></summary>
    public partial class SnapshotRequest
        : PlainRequestBase<SnapshotRequestParameters>,
            ISnapshotRequest
    {
        protected ISnapshotRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotSnapshot;

        /// <summary>/_snapshot/{repository}/{snapshot}</summary>
        /// <param name="repository">this parameter is required</param>
        /// <param name="snapshot">this parameter is required</param>
        public SnapshotRequest(Name repository, Name snapshot)
            : base(r => r.Required("repository", repository).Required("snapshot", snapshot)) { }

        /// <summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
        [SerializationConstructor]
        protected SnapshotRequest()
            : base() { }

        // values part of the url path
        [IgnoreDataMember]
        Name ISnapshotRequest.RepositoryName => Self.RouteValues.Get<Name>("repository");

        [IgnoreDataMember]
        Name ISnapshotRequest.Snapshot => Self.RouteValues.Get<Name>("snapshot");

        // Request parameters
        /// <summary>
        /// The amount of time to wait for a response from the cluster manager node. For more information about supported time units, see <a
        /// href="https://opensearch.org/docs/latest/api-reference/common-parameters/#time-units">Common parameters</a>.
        /// </summary>
        /// <remarks>Supported by OpenSearch servers of version 2.0.0 or greater.</remarks>
        public Time ClusterManagerTimeout
        {
            get => Q<Time>("cluster_manager_timeout");
            set => Q("cluster_manager_timeout", value);
        }

        /// <summary>
        /// Period to wait for a connection to the cluster-manager node. If no response is received before the timeout expires, the request fails and
        /// returns an error.
        /// </summary>
        [Obsolete(
            "Deprecated as of: 2.0.0, reason: To promote inclusive language, use `cluster_manager_timeout` instead."
        )]
        public Time MasterTimeout
        {
            get => Q<Time>("master_timeout");
            set => Q("master_timeout", value);
        }

        /// <summary>
        /// When <c>true</c>, the request returns a response when the snapshot is complete. When <c>false</c>, the request returns a response when the
        /// snapshot initializes.
        /// </summary>
        public bool? WaitForCompletion
        {
            get => Q<bool?>("wait_for_completion");
            set => Q("wait_for_completion", value);
        }
    }

    [InterfaceDataContract]
    public partial interface ICreateRepositoryRequest : IRequest<CreateRepositoryRequestParameters>
    {
        [IgnoreDataMember]
        Name RepositoryName { get; }
    }

    /// <summary>Request for CreateRepository <para>https://opensearch.org/docs/latest/api-reference/snapshots/create-repository/</para></summary>
    public partial class CreateRepositoryRequest
        : PlainRequestBase<CreateRepositoryRequestParameters>,
            ICreateRepositoryRequest
    {
        protected ICreateRepositoryRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotCreateRepository;

        /// <summary>/_snapshot/{repository}</summary>
        /// <param name="repository">this parameter is required</param>
        public CreateRepositoryRequest(Name repository)
            : base(r => r.Required("repository", repository)) { }

        /// <summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
        [SerializationConstructor]
        protected CreateRepositoryRequest()
            : base() { }

        // values part of the url path
        [IgnoreDataMember]
        Name ICreateRepositoryRequest.RepositoryName => Self.RouteValues.Get<Name>("repository");

        // Request parameters
        /// <summary>
        /// The amount of time to wait for a response from the cluster manager node. For more information about supported time units, see <a
        /// href="https://opensearch.org/docs/latest/api-reference/common-parameters/#time-units">Common parameters</a>.
        /// </summary>
        /// <remarks>Supported by OpenSearch servers of version 2.0.0 or greater.</remarks>
        public Time ClusterManagerTimeout
        {
            get => Q<Time>("cluster_manager_timeout");
            set => Q("cluster_manager_timeout", value);
        }

        /// <summary>Explicit operation timeout for connection to cluster-manager node.</summary>
        [Obsolete(
            "Deprecated as of: 2.0.0, reason: To promote inclusive language, use `cluster_manager_timeout` instead."
        )]
        public Time MasterTimeout
        {
            get => Q<Time>("master_timeout");
            set => Q("master_timeout", value);
        }

        /// <summary>The amount of time to wait for a response.</summary>
        public Time Timeout
        {
            get => Q<Time>("timeout");
            set => Q("timeout", value);
        }

        /// <summary>When <c>true</c>, verifies the creation of the snapshot repository.</summary>
        public bool? Verify
        {
            get => Q<bool?>("verify");
            set => Q("verify", value);
        }
    }

    [InterfaceDataContract]
    public partial interface IDeleteSnapshotRequest : IRequest<DeleteSnapshotRequestParameters>
    {
        [IgnoreDataMember]
        Name RepositoryName { get; }

        [IgnoreDataMember]
        Name Snapshot { get; }
    }

    /// <summary>Request for Delete <para>https://opensearch.org/docs/latest/api-reference/snapshots/delete-snapshot/</para></summary>
    public partial class DeleteSnapshotRequest
        : PlainRequestBase<DeleteSnapshotRequestParameters>,
            IDeleteSnapshotRequest
    {
        protected IDeleteSnapshotRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotDelete;

        /// <summary>/_snapshot/{repository}/{snapshot}</summary>
        /// <param name="repository">this parameter is required</param>
        /// <param name="snapshot">this parameter is required</param>
        public DeleteSnapshotRequest(Name repository, Name snapshot)
            : base(r => r.Required("repository", repository).Required("snapshot", snapshot)) { }

        /// <summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
        [SerializationConstructor]
        protected DeleteSnapshotRequest()
            : base() { }

        // values part of the url path
        [IgnoreDataMember]
        Name IDeleteSnapshotRequest.RepositoryName => Self.RouteValues.Get<Name>("repository");

        [IgnoreDataMember]
        Name IDeleteSnapshotRequest.Snapshot => Self.RouteValues.Get<Name>("snapshot");

        // Request parameters
        /// <summary>
        /// The amount of time to wait for a response from the cluster manager node. For more information about supported time units, see <a
        /// href="https://opensearch.org/docs/latest/api-reference/common-parameters/#time-units">Common parameters</a>.
        /// </summary>
        /// <remarks>Supported by OpenSearch servers of version 2.0.0 or greater.</remarks>
        public Time ClusterManagerTimeout
        {
            get => Q<Time>("cluster_manager_timeout");
            set => Q("cluster_manager_timeout", value);
        }

        /// <summary>Explicit operation timeout for connection to cluster-manager node.</summary>
        [Obsolete(
            "Deprecated as of: 2.0.0, reason: To promote inclusive language, use `cluster_manager_timeout` instead."
        )]
        public Time MasterTimeout
        {
            get => Q<Time>("master_timeout");
            set => Q("master_timeout", value);
        }
    }

    [InterfaceDataContract]
    public partial interface IDeleteRepositoryRequest : IRequest<DeleteRepositoryRequestParameters>
    {
        [IgnoreDataMember]
        Names RepositoryName { get; }
    }

    /// <summary>Request for DeleteRepository <para>https://opensearch.org/docs/latest/api-reference/snapshots/delete-snapshot-repository/</para></summary>
    public partial class DeleteRepositoryRequest
        : PlainRequestBase<DeleteRepositoryRequestParameters>,
            IDeleteRepositoryRequest
    {
        protected IDeleteRepositoryRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotDeleteRepository;

        /// <summary>/_snapshot/{repository}</summary>
        /// <param name="repository">this parameter is required</param>
        public DeleteRepositoryRequest(Names repository)
            : base(r => r.Required("repository", repository)) { }

        /// <summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
        [SerializationConstructor]
        protected DeleteRepositoryRequest()
            : base() { }

        // values part of the url path
        [IgnoreDataMember]
        Names IDeleteRepositoryRequest.RepositoryName => Self.RouteValues.Get<Names>("repository");

        // Request parameters
        /// <summary>
        /// The amount of time to wait for a response from the cluster manager node. For more information about supported time units, see <a
        /// href="https://opensearch.org/docs/latest/api-reference/common-parameters/#time-units">Common parameters</a>.
        /// </summary>
        /// <remarks>Supported by OpenSearch servers of version 2.0.0 or greater.</remarks>
        public Time ClusterManagerTimeout
        {
            get => Q<Time>("cluster_manager_timeout");
            set => Q("cluster_manager_timeout", value);
        }

        /// <summary>Explicit operation timeout for connection to cluster-manager node.</summary>
        [Obsolete(
            "Deprecated as of: 2.0.0, reason: To promote inclusive language, use `cluster_manager_timeout` instead."
        )]
        public Time MasterTimeout
        {
            get => Q<Time>("master_timeout");
            set => Q("master_timeout", value);
        }

        /// <summary>The amount of time to wait for a response.</summary>
        public Time Timeout
        {
            get => Q<Time>("timeout");
            set => Q("timeout", value);
        }
    }

    [InterfaceDataContract]
    public partial interface IGetSnapshotRequest : IRequest<GetSnapshotRequestParameters>
    {
        [IgnoreDataMember]
        Name RepositoryName { get; }

        [IgnoreDataMember]
        Names Snapshot { get; }
    }

    /// <summary>Request for Get <para>https://opensearch.org/docs/latest</para></summary>
    public partial class GetSnapshotRequest
        : PlainRequestBase<GetSnapshotRequestParameters>,
            IGetSnapshotRequest
    {
        protected IGetSnapshotRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotGet;

        /// <summary>/_snapshot/{repository}/{snapshot}</summary>
        /// <param name="repository">this parameter is required</param>
        /// <param name="snapshot">this parameter is required</param>
        public GetSnapshotRequest(Name repository, Names snapshot)
            : base(r => r.Required("repository", repository).Required("snapshot", snapshot)) { }

        /// <summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
        [SerializationConstructor]
        protected GetSnapshotRequest()
            : base() { }

        // values part of the url path
        [IgnoreDataMember]
        Name IGetSnapshotRequest.RepositoryName => Self.RouteValues.Get<Name>("repository");

        [IgnoreDataMember]
        Names IGetSnapshotRequest.Snapshot => Self.RouteValues.Get<Names>("snapshot");

        // Request parameters
        /// <summary>
        /// The amount of time to wait for a response from the cluster manager node. For more information about supported time units, see <a
        /// href="https://opensearch.org/docs/latest/api-reference/common-parameters/#time-units">Common parameters</a>.
        /// </summary>
        /// <remarks>Supported by OpenSearch servers of version 2.0.0 or greater.</remarks>
        public Time ClusterManagerTimeout
        {
            get => Q<Time>("cluster_manager_timeout");
            set => Q("cluster_manager_timeout", value);
        }

        /// <summary>When <c>false</c>, the request returns an error for any snapshots that are unavailable.</summary>
        public bool? IgnoreUnavailable
        {
            get => Q<bool?>("ignore_unavailable");
            set => Q("ignore_unavailable", value);
        }

        /// <summary>
        /// Period to wait for a connection to the cluster-manager node. If no response is received before the timeout expires, the request fails and
        /// returns an error.
        /// </summary>
        [Obsolete(
            "Deprecated as of: 2.0.0, reason: To promote inclusive language, use `cluster_manager_timeout` instead."
        )]
        public Time MasterTimeout
        {
            get => Q<Time>("master_timeout");
            set => Q("master_timeout", value);
        }

        /// <summary>
        /// When <c>true</c>, returns additional information about each snapshot such as the version of OpenSearch which took the snapshot, the start
        /// and end times of the snapshot, and the number of shards contained in the snapshot.
        /// </summary>
        public bool? Verbose
        {
            get => Q<bool?>("verbose");
            set => Q("verbose", value);
        }
    }

    [InterfaceDataContract]
    public partial interface IGetRepositoryRequest : IRequest<GetRepositoryRequestParameters>
    {
        [IgnoreDataMember]
        Names RepositoryName { get; }
    }

    /// <summary>Request for GetRepository <para>https://opensearch.org/docs/latest/api-reference/snapshots/get-snapshot-repository/</para></summary>
    public partial class GetRepositoryRequest
        : PlainRequestBase<GetRepositoryRequestParameters>,
            IGetRepositoryRequest
    {
        protected IGetRepositoryRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotGetRepository;

        /// <summary>/_snapshot</summary>
        public GetRepositoryRequest()
            : base() { }

        /// <summary>/_snapshot/{repository}</summary>
        /// <param name="repository">Optional, accepts null</param>
        public GetRepositoryRequest(Names repository)
            : base(r => r.Optional("repository", repository)) { }

        // values part of the url path
        [IgnoreDataMember]
        Names IGetRepositoryRequest.RepositoryName => Self.RouteValues.Get<Names>("repository");

        // Request parameters
        /// <summary>
        /// The amount of time to wait for a response from the cluster manager node. For more information about supported time units, see <a
        /// href="https://opensearch.org/docs/latest/api-reference/common-parameters/#time-units">Common parameters</a>.
        /// </summary>
        /// <remarks>Supported by OpenSearch servers of version 2.0.0 or greater.</remarks>
        public Time ClusterManagerTimeout
        {
            get => Q<Time>("cluster_manager_timeout");
            set => Q("cluster_manager_timeout", value);
        }

        /// <summary>Whether to get information from the local node.</summary>
        public bool? Local
        {
            get => Q<bool?>("local");
            set => Q("local", value);
        }

        /// <summary>Explicit operation timeout for connection to cluster-manager node.</summary>
        [Obsolete(
            "Deprecated as of: 2.0.0, reason: To promote inclusive language, use `cluster_manager_timeout` instead."
        )]
        public Time MasterTimeout
        {
            get => Q<Time>("master_timeout");
            set => Q("master_timeout", value);
        }
    }

    [InterfaceDataContract]
    public partial interface IRestoreRequest : IRequest<RestoreRequestParameters>
    {
        [IgnoreDataMember]
        Name RepositoryName { get; }

        [IgnoreDataMember]
        Name Snapshot { get; }
    }

    /// <summary>Request for Restore <para>https://opensearch.org/docs/latest/api-reference/snapshots/restore-snapshot/</para></summary>
    public partial class RestoreRequest
        : PlainRequestBase<RestoreRequestParameters>,
            IRestoreRequest
    {
        protected IRestoreRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotRestore;

        /// <summary>/_snapshot/{repository}/{snapshot}/_restore</summary>
        /// <param name="repository">this parameter is required</param>
        /// <param name="snapshot">this parameter is required</param>
        public RestoreRequest(Name repository, Name snapshot)
            : base(r => r.Required("repository", repository).Required("snapshot", snapshot)) { }

        /// <summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
        [SerializationConstructor]
        protected RestoreRequest()
            : base() { }

        // values part of the url path
        [IgnoreDataMember]
        Name IRestoreRequest.RepositoryName => Self.RouteValues.Get<Name>("repository");

        [IgnoreDataMember]
        Name IRestoreRequest.Snapshot => Self.RouteValues.Get<Name>("snapshot");

        // Request parameters
        /// <summary>
        /// The amount of time to wait for a response from the cluster manager node. For more information about supported time units, see <a
        /// href="https://opensearch.org/docs/latest/api-reference/common-parameters/#time-units">Common parameters</a>.
        /// </summary>
        /// <remarks>Supported by OpenSearch servers of version 2.0.0 or greater.</remarks>
        public Time ClusterManagerTimeout
        {
            get => Q<Time>("cluster_manager_timeout");
            set => Q("cluster_manager_timeout", value);
        }

        /// <summary>Explicit operation timeout for connection to cluster-manager node.</summary>
        [Obsolete(
            "Deprecated as of: 2.0.0, reason: To promote inclusive language, use `cluster_manager_timeout` instead."
        )]
        public Time MasterTimeout
        {
            get => Q<Time>("master_timeout");
            set => Q("master_timeout", value);
        }

        /// <summary>
        /// -| Whether to return a response after the restore operation has completed. When <c>false</c>, the request returns a response when the
        /// restore operation initializes. When <c>true</c>, the request returns a response when the restore operation completes.
        /// </summary>
        public bool? WaitForCompletion
        {
            get => Q<bool?>("wait_for_completion");
            set => Q("wait_for_completion", value);
        }
    }

    [InterfaceDataContract]
    public partial interface ISnapshotStatusRequest : IRequest<SnapshotStatusRequestParameters>
    {
        [IgnoreDataMember]
        Name RepositoryName { get; }

        [IgnoreDataMember]
        Names Snapshot { get; }
    }

    /// <summary>Request for Status <para>https://opensearch.org/docs/latest/api-reference/snapshots/get-snapshot-status/</para></summary>
    public partial class SnapshotStatusRequest
        : PlainRequestBase<SnapshotStatusRequestParameters>,
            ISnapshotStatusRequest
    {
        protected ISnapshotStatusRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotStatus;

        /// <summary>/_snapshot/_status</summary>
        public SnapshotStatusRequest()
            : base() { }

        /// <summary>/_snapshot/{repository}/_status</summary>
        /// <param name="repository">Optional, accepts null</param>
        public SnapshotStatusRequest(Name repository)
            : base(r => r.Optional("repository", repository)) { }

        /// <summary>/_snapshot/{repository}/{snapshot}/_status</summary>
        /// <param name="repository">Optional, accepts null</param>
        /// <param name="snapshot">Optional, accepts null</param>
        public SnapshotStatusRequest(Name repository, Names snapshot)
            : base(r => r.Optional("repository", repository).Optional("snapshot", snapshot)) { }

        // values part of the url path
        [IgnoreDataMember]
        Name ISnapshotStatusRequest.RepositoryName => Self.RouteValues.Get<Name>("repository");

        [IgnoreDataMember]
        Names ISnapshotStatusRequest.Snapshot => Self.RouteValues.Get<Names>("snapshot");

        // Request parameters
        /// <summary>
        /// The amount of time to wait for a response from the cluster manager node. For more information about supported time units, see <a
        /// href="https://opensearch.org/docs/latest/api-reference/common-parameters/#time-units">Common parameters</a>.
        /// </summary>
        /// <remarks>Supported by OpenSearch servers of version 2.0.0 or greater.</remarks>
        public Time ClusterManagerTimeout
        {
            get => Q<Time>("cluster_manager_timeout");
            set => Q("cluster_manager_timeout", value);
        }

        /// <summary>Whether to ignore any unavailable snapshots, When <c>false</c>, a <c>SnapshotMissingException</c> is thrown.</summary>
        public bool? IgnoreUnavailable
        {
            get => Q<bool?>("ignore_unavailable");
            set => Q("ignore_unavailable", value);
        }

        /// <summary>Explicit operation timeout for connection to cluster-manager node.</summary>
        [Obsolete(
            "Deprecated as of: 2.0.0, reason: To promote inclusive language, use `cluster_manager_timeout` instead."
        )]
        public Time MasterTimeout
        {
            get => Q<Time>("master_timeout");
            set => Q("master_timeout", value);
        }
    }

    [InterfaceDataContract]
    public partial interface IVerifyRepositoryRequest : IRequest<VerifyRepositoryRequestParameters>
    {
        [IgnoreDataMember]
        Name RepositoryName { get; }
    }

    /// <summary>Request for VerifyRepository <para>https://opensearch.org/docs/latest/api-reference/snapshots/verify-snapshot-repository/</para></summary>
    public partial class VerifyRepositoryRequest
        : PlainRequestBase<VerifyRepositoryRequestParameters>,
            IVerifyRepositoryRequest
    {
        protected IVerifyRepositoryRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotVerifyRepository;

        /// <summary>/_snapshot/{repository}/_verify</summary>
        /// <param name="repository">this parameter is required</param>
        public VerifyRepositoryRequest(Name repository)
            : base(r => r.Required("repository", repository)) { }

        /// <summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
        [SerializationConstructor]
        protected VerifyRepositoryRequest()
            : base() { }

        // values part of the url path
        [IgnoreDataMember]
        Name IVerifyRepositoryRequest.RepositoryName => Self.RouteValues.Get<Name>("repository");

        // Request parameters
        /// <summary>
        /// The amount of time to wait for a response from the cluster manager node. For more information about supported time units, see <a
        /// href="https://opensearch.org/docs/latest/api-reference/common-parameters/#time-units">Common parameters</a>.
        /// </summary>
        /// <remarks>Supported by OpenSearch servers of version 2.0.0 or greater.</remarks>
        public Time ClusterManagerTimeout
        {
            get => Q<Time>("cluster_manager_timeout");
            set => Q("cluster_manager_timeout", value);
        }

        /// <summary>Explicit operation timeout for connection to cluster-manager node.</summary>
        [Obsolete(
            "Deprecated as of: 2.0.0, reason: To promote inclusive language, use `cluster_manager_timeout` instead."
        )]
        public Time MasterTimeout
        {
            get => Q<Time>("master_timeout");
            set => Q("master_timeout", value);
        }

        /// <summary>The amount of time to wait for a response.</summary>
        public Time Timeout
        {
            get => Q<Time>("timeout");
            set => Q("timeout", value);
        }
    }
}
