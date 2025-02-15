/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the sts-2011-06-15.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.SecurityToken.Model;
using Amazon.SecurityToken.Model.Internal.MarshallTransformations;
using Amazon.SecurityToken.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SecurityToken
{
    /// <summary>
    /// Implementation for accessing SecurityTokenService
    ///
    /// AWS Security Token Service 
    /// <para>
    /// The AWS Security Token Service (STS) is a web service that enables you to request
    /// temporary, limited-privilege credentials for AWS Identity and Access Management (IAM)
    /// users or for users that you authenticate (federated users). This guide provides descriptions
    /// of the STS API. For more detailed information about using this service, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp.html">Temporary
    /// Security Credentials</a>. 
    /// </para>
    ///  
    /// <para>
    /// For information about setting up signatures and authorization through the API, go
    /// to <a href="https://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html">Signing
    /// AWS API Requests</a> in the <i>AWS General Reference</i>. For general information
    /// about the Query API, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html">Making
    /// Query Requests</a> in <i>Using IAM</i>. For information about using security tokens
    /// with other AWS products, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-services-that-work-with-iam.html">AWS
    /// Services That Work with IAM</a> in the <i>IAM User Guide</i>. 
    /// </para>
    ///  
    /// <para>
    /// If you're new to AWS and need additional technical information about a specific AWS
    /// product, you can find the product's technical documentation at <a href="http://aws.amazon.com/documentation/">http://aws.amazon.com/documentation/</a>.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <b>Endpoints</b> 
    /// </para>
    ///  
    /// <para>
    /// By default, AWS Security Token Service (STS) is available as a global service, and
    /// all AWS STS requests go to a single endpoint at <code>https://sts.amazonaws.com</code>.
    /// Global requests map to the US East (N. Virginia) region. AWS recommends using Regional
    /// AWS STS endpoints instead of the global endpoint to reduce latency, build in redundancy,
    /// and increase session token validity. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Managing
    /// AWS STS in an AWS Region</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// Most AWS Regions are enabled for operations in all AWS services by default. Those
    /// Regions are automatically activated for use with AWS STS. Some Regions, such as Asia
    /// Pacific (Hong Kong), must be manually enabled. To learn more about enabling and disabling
    /// AWS Regions, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande-manage.html">Managing
    /// AWS Regions</a> in the <i>AWS General Reference</i>. When you enable these AWS Regions,
    /// they are automatically activated for use with AWS STS. You cannot activate the STS
    /// endpoint for a Region that is disabled. Tokens that are valid in all AWS Regions are
    /// longer than tokens that are valid in Regions that are enabled by default. Changing
    /// this setting might affect existing systems where you temporarily store tokens. For
    /// more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html#sts-regions-manage-tokens">Managing
    /// Global Endpoint Session Tokens</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// After you activate a Region for use with AWS STS, you can direct AWS STS API calls
    /// to that Region. AWS STS recommends that you provide both the Region and endpoint when
    /// you make calls to a Regional endpoint. You can provide the Region alone for manually
    /// enabled Regions, such as Asia Pacific (Hong Kong). In this case, the calls are directed
    /// to the STS Regional endpoint. However, if you provide the Region alone for Regions
    /// enabled by default, the calls are directed to the global endpoint of <code>https://sts.amazonaws.com</code>.
    /// </para>
    ///  
    /// <para>
    /// To view the list of AWS STS endpoints and whether they are active by default, see
    /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html#id_credentials_temp_enable-regions_writing_code">Writing
    /// Code to Use AWS STS Regions</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Recording API requests</b> 
    /// </para>
    ///  
    /// <para>
    /// STS supports AWS CloudTrail, which is a service that records AWS calls for your AWS
    /// account and delivers log files to an Amazon S3 bucket. By using information collected
    /// by CloudTrail, you can determine what requests were successfully made to STS, who
    /// made the request, when it was made, and so on.
    /// </para>
    ///  
    /// <para>
    /// If you activate AWS STS endpoints in Regions other than the default global endpoint,
    /// then you must also turn on CloudTrail logging in those Regions. This is necessary
    /// to record any AWS STS API calls that are made in those Regions. For more information,
    /// see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/aggregating_logs_regions_turn_on_ct.html">Turning
    /// On CloudTrail in Additional Regions</a> in the <i>AWS CloudTrail User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// AWS Security Token Service (STS) is a global service with a single endpoint at <code>https://sts.amazonaws.com</code>.
    /// Calls to this endpoint are logged as calls to a global service. However, because this
    /// endpoint is physically located in the US East (N. Virginia) Region, your logs list
    /// <code>us-east-1</code> as the event Region. CloudTrail does not write these logs to
    /// the US East (Ohio) Region unless you choose to include global service logs in that
    /// Region. CloudTrail writes calls to all Regional endpoints to their respective Regions.
    /// For example, calls to sts.us-east-2.amazonaws.com are published to the US East (Ohio)
    /// Region and calls to sts.eu-central-1.amazonaws.com are published to the EU (Frankfurt)
    /// Region.
    /// </para>
    ///  
    /// <para>
    /// To learn more about CloudTrail, including how to turn it on and find your log files,
    /// see the <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/what_is_cloud_trail_top_level.html">AWS
    /// CloudTrail User Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonSecurityTokenServiceClient : AmazonServiceClient, IAmazonSecurityTokenService
    {
        private static IServiceMetadata serviceMetadata = new AmazonSecurityTokenServiceMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonSecurityTokenServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSecurityTokenServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonSecurityTokenServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSecurityTokenServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonSecurityTokenServiceClient Configuration Object</param>
        public AmazonSecurityTokenServiceClient(AmazonSecurityTokenServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSecurityTokenServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonSecurityTokenServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSecurityTokenServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSecurityTokenServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Credentials and an
        /// AmazonSecurityTokenServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSecurityTokenServiceClient Configuration Object</param>
        public AmazonSecurityTokenServiceClient(AWSCredentials credentials, AmazonSecurityTokenServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSecurityTokenServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSecurityTokenServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSecurityTokenServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSecurityTokenServiceClient Configuration Object</param>
        public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSecurityTokenServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSecurityTokenServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSecurityTokenServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSecurityTokenServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSecurityTokenServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSecurityTokenServiceClient Configuration Object</param>
        public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSecurityTokenServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  AssumeRole

        /// <summary>
        /// Returns a set of temporary security credentials that you can use to access AWS resources
        /// that you might not normally have access to. These temporary credentials consist of
        /// an access key ID, a secret access key, and a security token. Typically, you use <code>AssumeRole</code>
        /// within your account or for cross-account access. For a comparison of <code>AssumeRole</code>
        /// with other API operations that produce temporary credentials, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html">Requesting
        /// Temporary Security Credentials</a> and <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#stsapi_comparison">Comparing
        /// the AWS STS API operations</a> in the <i>IAM User Guide</i>.
        /// 
        ///  <important> 
        /// <para>
        /// You cannot use AWS account root user credentials to call <code>AssumeRole</code>.
        /// You must use credentials for an IAM user or an IAM role to call <code>AssumeRole</code>.
        /// </para>
        ///  </important> 
        /// <para>
        /// For cross-account access, imagine that you own multiple accounts and need to access
        /// resources in each account. You could create long-term credentials in each account
        /// to access those resources. However, managing all those credentials and remembering
        /// which one can access which account can be time consuming. Instead, you can create
        /// one set of long-term credentials in one account. Then use temporary security credentials
        /// to access all the other accounts by assuming roles in those accounts. For more information
        /// about roles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles.html">IAM
        /// Roles</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// By default, the temporary security credentials created by <code>AssumeRole</code>
        /// last for one hour. However, you can use the optional <code>DurationSeconds</code>
        /// parameter to specify the duration of your session. You can provide a value from 900
        /// seconds (15 minutes) up to the maximum session duration setting for the role. This
        /// setting can have a value from 1 hour to 12 hours. To learn how to view the maximum
        /// value for your role, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use.html#id_roles_use_view-role-max-session">View
        /// the Maximum Session Duration Setting for a Role</a> in the <i>IAM User Guide</i>.
        /// The maximum session duration limit applies when you use the <code>AssumeRole*</code>
        /// API operations or the <code>assume-role*</code> CLI commands. However the limit does
        /// not apply when you use those operations to create a console URL. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use.html">Using
        /// IAM Roles</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The temporary security credentials created by <code>AssumeRole</code> can be used
        /// to make API calls to any AWS service with the following exception: You cannot call
        /// the AWS STS <code>GetFederationToken</code> or <code>GetSessionToken</code> API operations.
        /// </para>
        ///  
        /// <para>
        /// (Optional) You can pass inline or managed <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html#policies_session">session
        /// policies</a> to this operation. You can pass a single JSON policy document to use
        /// as an inline session policy. You can also specify up to 10 managed policies to use
        /// as managed session policies. The plain text that you use for both inline and managed
        /// session policies shouldn't exceed 2048 characters. Passing policies to this operation
        /// returns new temporary credentials. The resulting session's permissions are the intersection
        /// of the role's identity-based policy and the session policies. You can use the role's
        /// temporary credentials in subsequent AWS API calls to access resources in the account
        /// that owns the role. You cannot use session policies to grant more permissions than
        /// those allowed by the identity-based policy of the role that is being assumed. For
        /// more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html#policies_session">Session
        /// Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To assume a role from a different account, your AWS account must be trusted by the
        /// role. The trust relationship is defined in the role's trust policy when the role is
        /// created. That trust policy states which accounts are allowed to delegate that access
        /// to users in the account. 
        /// </para>
        ///  
        /// <para>
        /// A user who wants to access a role in a different account must also have permissions
        /// that are delegated from the user account administrator. The administrator must attach
        /// a policy that allows the user to call <code>AssumeRole</code> for the ARN of the role
        /// in the other account. If the user is in the same account as the role, then you can
        /// do either of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Attach a policy to the user (identical to the previous user in a different account).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Add the user as a principal directly in the role's trust policy.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// In this case, the trust policy acts as an IAM resource-based policy. Users in the
        /// same account as the role do not need explicit permission to assume the role. For more
        /// information about trust policies and resource-based policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html">IAM
        /// Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Using MFA with AssumeRole</b> 
        /// </para>
        ///  
        /// <para>
        /// (Optional) You can include multi-factor authentication (MFA) information when you
        /// call <code>AssumeRole</code>. This is useful for cross-account scenarios to ensure
        /// that the user that assumes the role has been authenticated with an AWS MFA device.
        /// In that scenario, the trust policy of the role being assumed includes a condition
        /// that tests for MFA authentication. If the caller does not include valid MFA information,
        /// the request to assume the role is denied. The condition in a trust policy that tests
        /// for MFA authentication might look like the following example.
        /// </para>
        ///  
        /// <para>
        ///  <code>"Condition": {"Bool": {"aws:MultiFactorAuthPresent": true}}</code> 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/MFAProtectedAPI.html">Configuring
        /// MFA-Protected API Access</a> in the <i>IAM User Guide</i> guide.
        /// </para>
        ///  
        /// <para>
        /// To use MFA with <code>AssumeRole</code>, you pass values for the <code>SerialNumber</code>
        /// and <code>TokenCode</code> parameters. The <code>SerialNumber</code> value identifies
        /// the user's hardware or virtual MFA device. The <code>TokenCode</code> is the time-based
        /// one-time password (TOTP) that the MFA device produces. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssumeRole service method.</param>
        /// 
        /// <returns>The response from the AssumeRole service method, as returned by SecurityTokenService.</returns>
        /// <exception cref="Amazon.SecurityToken.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.PackedPolicyTooLargeException">
        /// The request was rejected because the policy document was too large. The error message
        /// describes how big the policy document is, in packed form, as a percentage of what
        /// the API allows.
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.RegionDisabledException">
        /// STS is not activated in the requested region for the account that is being asked to
        /// generate credentials. The account administrator must use the IAM console to activate
        /// STS in that region. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
        /// and Deactivating AWS STS in an AWS Region</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/AssumeRole">REST API Reference for AssumeRole Operation</seealso>
        public virtual AssumeRoleResponse AssumeRole(AssumeRoleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssumeRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssumeRoleResponseUnmarshaller.Instance;

            return Invoke<AssumeRoleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssumeRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssumeRole operation on AmazonSecurityTokenServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssumeRole
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/AssumeRole">REST API Reference for AssumeRole Operation</seealso>
        public virtual IAsyncResult BeginAssumeRole(AssumeRoleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssumeRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssumeRoleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssumeRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssumeRole.</param>
        /// 
        /// <returns>Returns a  AssumeRoleResult from SecurityTokenService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/AssumeRole">REST API Reference for AssumeRole Operation</seealso>
        public virtual AssumeRoleResponse EndAssumeRole(IAsyncResult asyncResult)
        {
            return EndInvoke<AssumeRoleResponse>(asyncResult);
        }

        #endregion
        
        #region  AssumeRoleWithSAML

        /// <summary>
        /// Returns a set of temporary security credentials for users who have been authenticated
        /// via a SAML authentication response. This operation provides a mechanism for tying
        /// an enterprise identity store or directory to role-based AWS access without user-specific
        /// credentials or configuration. For a comparison of <code>AssumeRoleWithSAML</code>
        /// with the other API operations that produce temporary credentials, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html">Requesting
        /// Temporary Security Credentials</a> and <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#stsapi_comparison">Comparing
        /// the AWS STS API operations</a> in the <i>IAM User Guide</i>.
        /// 
        ///  
        /// <para>
        /// The temporary security credentials returned by this operation consist of an access
        /// key ID, a secret access key, and a security token. Applications can use these temporary
        /// security credentials to sign calls to AWS services.
        /// </para>
        ///  
        /// <para>
        /// By default, the temporary security credentials created by <code>AssumeRoleWithSAML</code>
        /// last for one hour. However, you can use the optional <code>DurationSeconds</code>
        /// parameter to specify the duration of your session. Your role session lasts for the
        /// duration that you specify, or until the time specified in the SAML authentication
        /// response's <code>SessionNotOnOrAfter</code> value, whichever is shorter. You can provide
        /// a <code>DurationSeconds</code> value from 900 seconds (15 minutes) up to the maximum
        /// session duration setting for the role. This setting can have a value from 1 hour to
        /// 12 hours. To learn how to view the maximum value for your role, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use.html#id_roles_use_view-role-max-session">View
        /// the Maximum Session Duration Setting for a Role</a> in the <i>IAM User Guide</i>.
        /// The maximum session duration limit applies when you use the <code>AssumeRole*</code>
        /// API operations or the <code>assume-role*</code> CLI commands. However the limit does
        /// not apply when you use those operations to create a console URL. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use.html">Using
        /// IAM Roles</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The temporary security credentials created by <code>AssumeRoleWithSAML</code> can
        /// be used to make API calls to any AWS service with the following exception: you cannot
        /// call the STS <code>GetFederationToken</code> or <code>GetSessionToken</code> API operations.
        /// </para>
        ///  
        /// <para>
        /// (Optional) You can pass inline or managed <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html#policies_session">session
        /// policies</a> to this operation. You can pass a single JSON policy document to use
        /// as an inline session policy. You can also specify up to 10 managed policies to use
        /// as managed session policies. The plain text that you use for both inline and managed
        /// session policies shouldn't exceed 2048 characters. Passing policies to this operation
        /// returns new temporary credentials. The resulting session's permissions are the intersection
        /// of the role's identity-based policy and the session policies. You can use the role's
        /// temporary credentials in subsequent AWS API calls to access resources in the account
        /// that owns the role. You cannot use session policies to grant more permissions than
        /// those allowed by the identity-based policy of the role that is being assumed. For
        /// more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html#policies_session">Session
        /// Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Before your application can call <code>AssumeRoleWithSAML</code>, you must configure
        /// your SAML identity provider (IdP) to issue the claims required by AWS. Additionally,
        /// you must use AWS Identity and Access Management (IAM) to create a SAML provider entity
        /// in your AWS account that represents your identity provider. You must also create an
        /// IAM role that specifies this SAML provider in its trust policy. 
        /// </para>
        ///  
        /// <para>
        /// Calling <code>AssumeRoleWithSAML</code> does not require the use of AWS security credentials.
        /// The identity of the caller is validated by using keys in the metadata document that
        /// is uploaded for the SAML provider entity for your identity provider. 
        /// </para>
        ///  <important> 
        /// <para>
        /// Calling <code>AssumeRoleWithSAML</code> can result in an entry in your AWS CloudTrail
        /// logs. The entry includes the value in the <code>NameID</code> element of the SAML
        /// assertion. We recommend that you use a <code>NameIDType</code> that is not associated
        /// with any personally identifiable information (PII). For example, you could instead
        /// use the Persistent Identifier (<code>urn:oasis:names:tc:SAML:2.0:nameid-format:persistent</code>).
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information, see the following resources:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_saml.html">About
        /// SAML 2.0-based Federation</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_create_saml.html">Creating
        /// SAML Identity Providers</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_create_saml_relying-party.html">Configuring
        /// a Relying Party and Claims</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_create_for-idp_saml.html">Creating
        /// a Role for SAML 2.0 Federation</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssumeRoleWithSAML service method.</param>
        /// 
        /// <returns>The response from the AssumeRoleWithSAML service method, as returned by SecurityTokenService.</returns>
        /// <exception cref="Amazon.SecurityToken.Model.ExpiredTokenException">
        /// The web identity token that was passed is expired or is not valid. Get a new identity
        /// token from the identity provider and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.IDPRejectedClaimException">
        /// The identity provider (IdP) reported that authentication failed. This might be because
        /// the claim is invalid.
        /// 
        ///  
        /// <para>
        /// If this error is returned for the <code>AssumeRoleWithWebIdentity</code> operation,
        /// it can also mean that the claim has expired or has been explicitly revoked. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.InvalidIdentityTokenException">
        /// The web identity token that was passed could not be validated by AWS. Get a new identity
        /// token from the identity provider and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.PackedPolicyTooLargeException">
        /// The request was rejected because the policy document was too large. The error message
        /// describes how big the policy document is, in packed form, as a percentage of what
        /// the API allows.
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.RegionDisabledException">
        /// STS is not activated in the requested region for the account that is being asked to
        /// generate credentials. The account administrator must use the IAM console to activate
        /// STS in that region. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
        /// and Deactivating AWS STS in an AWS Region</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/AssumeRoleWithSAML">REST API Reference for AssumeRoleWithSAML Operation</seealso>
        public virtual AssumeRoleWithSAMLResponse AssumeRoleWithSAML(AssumeRoleWithSAMLRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssumeRoleWithSAMLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssumeRoleWithSAMLResponseUnmarshaller.Instance;

            return Invoke<AssumeRoleWithSAMLResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssumeRoleWithSAML operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssumeRoleWithSAML operation on AmazonSecurityTokenServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssumeRoleWithSAML
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/AssumeRoleWithSAML">REST API Reference for AssumeRoleWithSAML Operation</seealso>
        public virtual IAsyncResult BeginAssumeRoleWithSAML(AssumeRoleWithSAMLRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssumeRoleWithSAMLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssumeRoleWithSAMLResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssumeRoleWithSAML operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssumeRoleWithSAML.</param>
        /// 
        /// <returns>Returns a  AssumeRoleWithSAMLResult from SecurityTokenService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/AssumeRoleWithSAML">REST API Reference for AssumeRoleWithSAML Operation</seealso>
        public virtual AssumeRoleWithSAMLResponse EndAssumeRoleWithSAML(IAsyncResult asyncResult)
        {
            return EndInvoke<AssumeRoleWithSAMLResponse>(asyncResult);
        }

        #endregion
        
        #region  AssumeRoleWithWebIdentity

        /// <summary>
        /// Returns a set of temporary security credentials for users who have been authenticated
        /// in a mobile or web application with a web identity provider. Example providers include
        /// Amazon Cognito, Login with Amazon, Facebook, Google, or any OpenID Connect-compatible
        /// identity provider.
        /// 
        ///  <note> 
        /// <para>
        /// For mobile applications, we recommend that you use Amazon Cognito. You can use Amazon
        /// Cognito with the <a href="http://aws.amazon.com/sdkforios/">AWS SDK for iOS Developer
        /// Guide</a> and the <a href="http://aws.amazon.com/sdkforandroid/">AWS SDK for Android
        /// Developer Guide</a> to uniquely identify a user. You can also supply the user with
        /// a consistent identity throughout the lifetime of an application.
        /// </para>
        ///  
        /// <para>
        /// To learn more about Amazon Cognito, see <a href="https://docs.aws.amazon.com/mobile/sdkforandroid/developerguide/cognito-auth.html#d0e840">Amazon
        /// Cognito Overview</a> in <i>AWS SDK for Android Developer Guide</i> and <a href="https://docs.aws.amazon.com/mobile/sdkforios/developerguide/cognito-auth.html#d0e664">Amazon
        /// Cognito Overview</a> in the <i>AWS SDK for iOS Developer Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Calling <code>AssumeRoleWithWebIdentity</code> does not require the use of AWS security
        /// credentials. Therefore, you can distribute an application (for example, on mobile
        /// devices) that requests temporary security credentials without including long-term
        /// AWS credentials in the application. You also don't need to deploy server-based proxy
        /// services that use long-term AWS credentials. Instead, the identity of the caller is
        /// validated by using a token from the web identity provider. For a comparison of <code>AssumeRoleWithWebIdentity</code>
        /// with the other API operations that produce temporary credentials, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html">Requesting
        /// Temporary Security Credentials</a> and <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#stsapi_comparison">Comparing
        /// the AWS STS API operations</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The temporary security credentials returned by this API consist of an access key ID,
        /// a secret access key, and a security token. Applications can use these temporary security
        /// credentials to sign calls to AWS service API operations.
        /// </para>
        ///  
        /// <para>
        /// By default, the temporary security credentials created by <code>AssumeRoleWithWebIdentity</code>
        /// last for one hour. However, you can use the optional <code>DurationSeconds</code>
        /// parameter to specify the duration of your session. You can provide a value from 900
        /// seconds (15 minutes) up to the maximum session duration setting for the role. This
        /// setting can have a value from 1 hour to 12 hours. To learn how to view the maximum
        /// value for your role, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use.html#id_roles_use_view-role-max-session">View
        /// the Maximum Session Duration Setting for a Role</a> in the <i>IAM User Guide</i>.
        /// The maximum session duration limit applies when you use the <code>AssumeRole*</code>
        /// API operations or the <code>assume-role*</code> CLI commands. However the limit does
        /// not apply when you use those operations to create a console URL. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use.html">Using
        /// IAM Roles</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// The temporary security credentials created by <code>AssumeRoleWithWebIdentity</code>
        /// can be used to make API calls to any AWS service with the following exception: you
        /// cannot call the STS <code>GetFederationToken</code> or <code>GetSessionToken</code>
        /// API operations.
        /// </para>
        ///  
        /// <para>
        /// (Optional) You can pass inline or managed <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html#policies_session">session
        /// policies</a> to this operation. You can pass a single JSON policy document to use
        /// as an inline session policy. You can also specify up to 10 managed policies to use
        /// as managed session policies. The plain text that you use for both inline and managed
        /// session policies shouldn't exceed 2048 characters. Passing policies to this operation
        /// returns new temporary credentials. The resulting session's permissions are the intersection
        /// of the role's identity-based policy and the session policies. You can use the role's
        /// temporary credentials in subsequent AWS API calls to access resources in the account
        /// that owns the role. You cannot use session policies to grant more permissions than
        /// those allowed by the identity-based policy of the role that is being assumed. For
        /// more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html#policies_session">Session
        /// Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Before your application can call <code>AssumeRoleWithWebIdentity</code>, you must
        /// have an identity token from a supported identity provider and create a role that the
        /// application can assume. The role that your application assumes must trust the identity
        /// provider that is associated with the identity token. In other words, the identity
        /// provider must be specified in the role's trust policy. 
        /// </para>
        ///  <important> 
        /// <para>
        /// Calling <code>AssumeRoleWithWebIdentity</code> can result in an entry in your AWS
        /// CloudTrail logs. The entry includes the <a href="http://openid.net/specs/openid-connect-core-1_0.html#Claims">Subject</a>
        /// of the provided Web Identity Token. We recommend that you avoid using any personally
        /// identifiable information (PII) in this field. For example, you could instead use a
        /// GUID or a pairwise identifier, as <a href="http://openid.net/specs/openid-connect-core-1_0.html#SubjectIDTypes">suggested
        /// in the OIDC specification</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about how to use web identity federation and the <code>AssumeRoleWithWebIdentity</code>
        /// API, see the following resources: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_oidc_manual.html">Using
        /// Web Identity Federation API Operations for Mobile Apps</a> and <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#api_assumerolewithwebidentity">Federation
        /// Through a Web-based Identity Provider</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://web-identity-federation-playground.s3.amazonaws.com/index.html">
        /// Web Identity Federation Playground</a>. Walk through the process of authenticating
        /// through Login with Amazon, Facebook, or Google, getting temporary security credentials,
        /// and then using those credentials to make a request to AWS. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="http://aws.amazon.com/sdkforios/">AWS SDK for iOS Developer Guide</a> and
        /// <a href="http://aws.amazon.com/sdkforandroid/">AWS SDK for Android Developer Guide</a>.
        /// These toolkits contain sample apps that show how to invoke the identity providers,
        /// and then how to use the information from these providers to get and use temporary
        /// security credentials. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="http://aws.amazon.com/articles/web-identity-federation-with-mobile-applications">Web
        /// Identity Federation with Mobile Applications</a>. This article discusses web identity
        /// federation and shows an example of how to use web identity federation to get access
        /// to content in Amazon S3. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssumeRoleWithWebIdentity service method.</param>
        /// 
        /// <returns>The response from the AssumeRoleWithWebIdentity service method, as returned by SecurityTokenService.</returns>
        /// <exception cref="Amazon.SecurityToken.Model.ExpiredTokenException">
        /// The web identity token that was passed is expired or is not valid. Get a new identity
        /// token from the identity provider and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.IDPCommunicationErrorException">
        /// The request could not be fulfilled because the non-AWS identity provider (IDP) that
        /// was asked to verify the incoming identity token could not be reached. This is often
        /// a transient error caused by network conditions. Retry the request a limited number
        /// of times so that you don't exceed the request rate. If the error persists, the non-AWS
        /// identity provider might be down or not responding.
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.IDPRejectedClaimException">
        /// The identity provider (IdP) reported that authentication failed. This might be because
        /// the claim is invalid.
        /// 
        ///  
        /// <para>
        /// If this error is returned for the <code>AssumeRoleWithWebIdentity</code> operation,
        /// it can also mean that the claim has expired or has been explicitly revoked. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.InvalidIdentityTokenException">
        /// The web identity token that was passed could not be validated by AWS. Get a new identity
        /// token from the identity provider and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.PackedPolicyTooLargeException">
        /// The request was rejected because the policy document was too large. The error message
        /// describes how big the policy document is, in packed form, as a percentage of what
        /// the API allows.
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.RegionDisabledException">
        /// STS is not activated in the requested region for the account that is being asked to
        /// generate credentials. The account administrator must use the IAM console to activate
        /// STS in that region. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
        /// and Deactivating AWS STS in an AWS Region</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/AssumeRoleWithWebIdentity">REST API Reference for AssumeRoleWithWebIdentity Operation</seealso>
        public virtual AssumeRoleWithWebIdentityResponse AssumeRoleWithWebIdentity(AssumeRoleWithWebIdentityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssumeRoleWithWebIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssumeRoleWithWebIdentityResponseUnmarshaller.Instance;

            return Invoke<AssumeRoleWithWebIdentityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssumeRoleWithWebIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssumeRoleWithWebIdentity operation on AmazonSecurityTokenServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssumeRoleWithWebIdentity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/AssumeRoleWithWebIdentity">REST API Reference for AssumeRoleWithWebIdentity Operation</seealso>
        public virtual IAsyncResult BeginAssumeRoleWithWebIdentity(AssumeRoleWithWebIdentityRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssumeRoleWithWebIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssumeRoleWithWebIdentityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssumeRoleWithWebIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssumeRoleWithWebIdentity.</param>
        /// 
        /// <returns>Returns a  AssumeRoleWithWebIdentityResult from SecurityTokenService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/AssumeRoleWithWebIdentity">REST API Reference for AssumeRoleWithWebIdentity Operation</seealso>
        public virtual AssumeRoleWithWebIdentityResponse EndAssumeRoleWithWebIdentity(IAsyncResult asyncResult)
        {
            return EndInvoke<AssumeRoleWithWebIdentityResponse>(asyncResult);
        }

        #endregion
        
        #region  DecodeAuthorizationMessage

        /// <summary>
        /// Decodes additional information about the authorization status of a request from an
        /// encoded message returned in response to an AWS request.
        /// 
        ///  
        /// <para>
        /// For example, if a user is not authorized to perform an operation that he or she has
        /// requested, the request returns a <code>Client.UnauthorizedOperation</code> response
        /// (an HTTP 403 response). Some AWS operations additionally return an encoded message
        /// that can provide details about this authorization failure. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Only certain AWS operations return an encoded authorization message. The documentation
        /// for an individual operation indicates whether that operation returns an encoded message
        /// in addition to returning an HTTP code.
        /// </para>
        ///  </note> 
        /// <para>
        /// The message is encoded because the details of the authorization status can constitute
        /// privileged information that the user who requested the operation should not see. To
        /// decode an authorization status message, a user must be granted permissions via an
        /// IAM policy to request the <code>DecodeAuthorizationMessage</code> (<code>sts:DecodeAuthorizationMessage</code>)
        /// action. 
        /// </para>
        ///  
        /// <para>
        /// The decoded message includes the following type of information:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Whether the request was denied due to an explicit deny or due to the absence of an
        /// explicit allow. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_evaluation-logic.html#policy-eval-denyallow">Determining
        /// Whether a Request is Allowed or Denied</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The principal who made the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The requested action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The requested resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The values of condition keys in the context of the user's request.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DecodeAuthorizationMessage service method.</param>
        /// 
        /// <returns>The response from the DecodeAuthorizationMessage service method, as returned by SecurityTokenService.</returns>
        /// <exception cref="Amazon.SecurityToken.Model.InvalidAuthorizationMessageException">
        /// This error is returned if the message passed to <code>DecodeAuthorizationMessage</code>
        /// was invalid. This can happen if the token contains invalid characters, such as linebreaks.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/DecodeAuthorizationMessage">REST API Reference for DecodeAuthorizationMessage Operation</seealso>
        public virtual DecodeAuthorizationMessageResponse DecodeAuthorizationMessage(DecodeAuthorizationMessageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DecodeAuthorizationMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DecodeAuthorizationMessageResponseUnmarshaller.Instance;

            return Invoke<DecodeAuthorizationMessageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DecodeAuthorizationMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DecodeAuthorizationMessage operation on AmazonSecurityTokenServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDecodeAuthorizationMessage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/DecodeAuthorizationMessage">REST API Reference for DecodeAuthorizationMessage Operation</seealso>
        public virtual IAsyncResult BeginDecodeAuthorizationMessage(DecodeAuthorizationMessageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DecodeAuthorizationMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DecodeAuthorizationMessageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DecodeAuthorizationMessage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDecodeAuthorizationMessage.</param>
        /// 
        /// <returns>Returns a  DecodeAuthorizationMessageResult from SecurityTokenService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/DecodeAuthorizationMessage">REST API Reference for DecodeAuthorizationMessage Operation</seealso>
        public virtual DecodeAuthorizationMessageResponse EndDecodeAuthorizationMessage(IAsyncResult asyncResult)
        {
            return EndInvoke<DecodeAuthorizationMessageResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAccessKeyInfo

        /// <summary>
        /// Returns the account identifier for the specified access key ID.
        /// 
        ///  
        /// <para>
        /// Access keys consist of two parts: an access key ID (for example, <code>AKIAIOSFODNN7EXAMPLE</code>)
        /// and a secret access key (for example, <code>wJalrXUtnFEMI/K7MDENG/bPxRfiCYEXAMPLEKEY</code>).
        /// For more information about access keys, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_access-keys.html">Managing
        /// Access Keys for IAM Users</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When you pass an access key ID to this operation, it returns the ID of the AWS account
        /// to which the keys belong. Access key IDs beginning with <code>AKIA</code> are long-term
        /// credentials for an IAM user or the AWS account root user. Access key IDs beginning
        /// with <code>ASIA</code> are temporary credentials that are created using STS operations.
        /// If the account in the response belongs to you, you can sign in as the root user and
        /// review your root user access keys. Then, you can pull a <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_getting-report.html">credentials
        /// report</a> to learn which IAM user owns the keys. To learn who requested the temporary
        /// credentials for an <code>ASIA</code> access key, view the STS events in your <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/cloudtrail-integration.html">CloudTrail
        /// logs</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation does not indicate the state of the access key. The key might be active,
        /// inactive, or deleted. Active keys might not have permissions to perform an operation.
        /// Providing a deleted access key might return an error that the key doesn't exist.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessKeyInfo service method.</param>
        /// 
        /// <returns>The response from the GetAccessKeyInfo service method, as returned by SecurityTokenService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/GetAccessKeyInfo">REST API Reference for GetAccessKeyInfo Operation</seealso>
        public virtual GetAccessKeyInfoResponse GetAccessKeyInfo(GetAccessKeyInfoRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccessKeyInfoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessKeyInfoResponseUnmarshaller.Instance;

            return Invoke<GetAccessKeyInfoResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccessKeyInfo operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccessKeyInfo operation on AmazonSecurityTokenServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccessKeyInfo
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/GetAccessKeyInfo">REST API Reference for GetAccessKeyInfo Operation</seealso>
        public virtual IAsyncResult BeginGetAccessKeyInfo(GetAccessKeyInfoRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccessKeyInfoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccessKeyInfoResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccessKeyInfo operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccessKeyInfo.</param>
        /// 
        /// <returns>Returns a  GetAccessKeyInfoResult from SecurityTokenService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/GetAccessKeyInfo">REST API Reference for GetAccessKeyInfo Operation</seealso>
        public virtual GetAccessKeyInfoResponse EndGetAccessKeyInfo(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAccessKeyInfoResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCallerIdentity

        /// <summary>
        /// Returns details about the IAM user or role whose credentials are used to call the
        /// operation.
        /// 
        ///  <note> 
        /// <para>
        /// No permissions are required to perform this operation. If an administrator adds a
        /// policy to your IAM user or role that explicitly denies access to the <code>sts:GetCallerIdentity</code>
        /// action, you can still perform this operation. Permissions are not required because
        /// the same information is returned when an IAM user or role is denied access. To view
        /// an example response, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/troubleshoot_general.html#troubleshoot_general_access-denied-delete-mfa">I
        /// Am Not Authorized to Perform: iam:DeleteVirtualMFADevice</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCallerIdentity service method.</param>
        /// 
        /// <returns>The response from the GetCallerIdentity service method, as returned by SecurityTokenService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/GetCallerIdentity">REST API Reference for GetCallerIdentity Operation</seealso>
        public virtual GetCallerIdentityResponse GetCallerIdentity(GetCallerIdentityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCallerIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCallerIdentityResponseUnmarshaller.Instance;

            return Invoke<GetCallerIdentityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCallerIdentity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCallerIdentity operation on AmazonSecurityTokenServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCallerIdentity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/GetCallerIdentity">REST API Reference for GetCallerIdentity Operation</seealso>
        public virtual IAsyncResult BeginGetCallerIdentity(GetCallerIdentityRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCallerIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCallerIdentityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCallerIdentity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCallerIdentity.</param>
        /// 
        /// <returns>Returns a  GetCallerIdentityResult from SecurityTokenService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/GetCallerIdentity">REST API Reference for GetCallerIdentity Operation</seealso>
        public virtual GetCallerIdentityResponse EndGetCallerIdentity(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCallerIdentityResponse>(asyncResult);
        }

        #endregion
        
        #region  GetFederationToken

        /// <summary>
        /// Returns a set of temporary security credentials (consisting of an access key ID, a
        /// secret access key, and a security token) for a federated user. A typical use is in
        /// a proxy application that gets temporary security credentials on behalf of distributed
        /// applications inside a corporate network. You must call the <code>GetFederationToken</code>
        /// operation using the long-term security credentials of an IAM user. As a result, this
        /// call is appropriate in contexts where those credentials can be safely stored, usually
        /// in a server-based application. For a comparison of <code>GetFederationToken</code>
        /// with the other API operations that produce temporary credentials, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html">Requesting
        /// Temporary Security Credentials</a> and <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#stsapi_comparison">Comparing
        /// the AWS STS API operations</a> in the <i>IAM User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// You can create a mobile-based or browser-based app that can authenticate users using
        /// a web identity provider like Login with Amazon, Facebook, Google, or an OpenID Connect-compatible
        /// identity provider. In this case, we recommend that you use <a href="http://aws.amazon.com/cognito/">Amazon
        /// Cognito</a> or <code>AssumeRoleWithWebIdentity</code>. For more information, see <a
        /// href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#api_assumerolewithwebidentity">Federation
        /// Through a Web-based Identity Provider</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can also call <code>GetFederationToken</code> using the security credentials of
        /// an AWS account root user, but we do not recommend it. Instead, we recommend that you
        /// create an IAM user for the purpose of the proxy application. Then attach a policy
        /// to the IAM user that limits federated users to only the actions and resources that
        /// they need to access. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/best-practices.html">IAM
        /// Best Practices</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// The temporary credentials are valid for the specified duration, from 900 seconds (15
        /// minutes) up to a maximum of 129,600 seconds (36 hours). The default is 43,200 seconds
        /// (12 hours). Temporary credentials that are obtained by using AWS account root user
        /// credentials have a maximum duration of 3,600 seconds (1 hour).
        /// </para>
        ///  
        /// <para>
        /// The temporary security credentials created by <code>GetFederationToken</code> can
        /// be used to make API calls to any AWS service with the following exceptions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You cannot use these credentials to call any IAM API operations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot call any STS API operations except <code>GetCallerIdentity</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// You must pass an inline or managed <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html#policies_session">session
        /// policy</a> to this operation. You can pass a single JSON policy document to use as
        /// an inline session policy. You can also specify up to 10 managed policies to use as
        /// managed session policies. The plain text that you use for both inline and managed
        /// session policies shouldn't exceed 2048 characters.
        /// </para>
        ///  
        /// <para>
        /// Though the session policy parameters are optional, if you do not pass a policy, then
        /// the resulting federated user session has no permissions. The only exception is when
        /// the credentials are used to access a resource that has a resource-based policy that
        /// specifically references the federated user session in the <code>Principal</code> element
        /// of the policy. When you pass session policies, the session permissions are the intersection
        /// of the IAM user policies and the session policies that you pass. This gives you a
        /// way to further restrict the permissions for a federated user. You cannot use session
        /// policies to grant more permissions than those that are defined in the permissions
        /// policy of the IAM user. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html#policies_session">Session
        /// Policies</a> in the <i>IAM User Guide</i>. For information about using <code>GetFederationToken</code>
        /// to create temporary security credentials, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#api_getfederationtoken">GetFederationToken—Federation
        /// Through a Custom Identity Broker</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFederationToken service method.</param>
        /// 
        /// <returns>The response from the GetFederationToken service method, as returned by SecurityTokenService.</returns>
        /// <exception cref="Amazon.SecurityToken.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.PackedPolicyTooLargeException">
        /// The request was rejected because the policy document was too large. The error message
        /// describes how big the policy document is, in packed form, as a percentage of what
        /// the API allows.
        /// </exception>
        /// <exception cref="Amazon.SecurityToken.Model.RegionDisabledException">
        /// STS is not activated in the requested region for the account that is being asked to
        /// generate credentials. The account administrator must use the IAM console to activate
        /// STS in that region. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
        /// and Deactivating AWS STS in an AWS Region</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/GetFederationToken">REST API Reference for GetFederationToken Operation</seealso>
        public virtual GetFederationTokenResponse GetFederationToken(GetFederationTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFederationTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFederationTokenResponseUnmarshaller.Instance;

            return Invoke<GetFederationTokenResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetFederationToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFederationToken operation on AmazonSecurityTokenServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFederationToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/GetFederationToken">REST API Reference for GetFederationToken Operation</seealso>
        public virtual IAsyncResult BeginGetFederationToken(GetFederationTokenRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFederationTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFederationTokenResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFederationToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFederationToken.</param>
        /// 
        /// <returns>Returns a  GetFederationTokenResult from SecurityTokenService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/GetFederationToken">REST API Reference for GetFederationToken Operation</seealso>
        public virtual GetFederationTokenResponse EndGetFederationToken(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFederationTokenResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSessionToken

        /// <summary>
        /// Returns a set of temporary credentials for an AWS account or IAM user. The credentials
        /// consist of an access key ID, a secret access key, and a security token. Typically,
        /// you use <code>GetSessionToken</code> if you want to use MFA to protect programmatic
        /// calls to specific AWS API operations like Amazon EC2 <code>StopInstances</code>. MFA-enabled
        /// IAM users would need to call <code>GetSessionToken</code> and submit an MFA code that
        /// is associated with their MFA device. Using the temporary security credentials that
        /// are returned from the call, IAM users can then make programmatic calls to API operations
        /// that require MFA authentication. If you do not supply a correct MFA code, then the
        /// API returns an access denied error. For a comparison of <code>GetSessionToken</code>
        /// with the other API operations that produce temporary credentials, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html">Requesting
        /// Temporary Security Credentials</a> and <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#stsapi_comparison">Comparing
        /// the AWS STS API operations</a> in the <i>IAM User Guide</i>.
        /// 
        ///  
        /// <para>
        /// The <code>GetSessionToken</code> operation must be called by using the long-term AWS
        /// security credentials of the AWS account root user or an IAM user. Credentials that
        /// are created by IAM users are valid for the duration that you specify. This duration
        /// can range from 900 seconds (15 minutes) up to a maximum of 129,600 seconds (36 hours),
        /// with a default of 43,200 seconds (12 hours). Credentials based on account credentials
        /// can range from 900 seconds (15 minutes) up to 3,600 seconds (1 hour), with a default
        /// of 1 hour. 
        /// </para>
        ///  
        /// <para>
        /// The temporary security credentials created by <code>GetSessionToken</code> can be
        /// used to make API calls to any AWS service with the following exceptions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You cannot call any IAM API operations unless MFA authentication information is included
        /// in the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot call any STS API <i>except</i> <code>AssumeRole</code> or <code>GetCallerIdentity</code>.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// We recommend that you do not call <code>GetSessionToken</code> with AWS account root
        /// user credentials. Instead, follow our <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/best-practices.html#create-iam-users">best
        /// practices</a> by creating one or more IAM users, giving them the necessary permissions,
        /// and using IAM users for everyday interaction with AWS. 
        /// </para>
        ///  </note> 
        /// <para>
        /// The credentials that are returned by <code>GetSessionToken</code> are based on permissions
        /// associated with the user whose credentials were used to call the operation. If <code>GetSessionToken</code>
        /// is called using AWS account root user credentials, the temporary credentials have
        /// root user permissions. Similarly, if <code>GetSessionToken</code> is called using
        /// the credentials of an IAM user, the temporary credentials have the same permissions
        /// as the IAM user. 
        /// </para>
        ///  
        /// <para>
        /// For more information about using <code>GetSessionToken</code> to create temporary
        /// credentials, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#api_getsessiontoken">Temporary
        /// Credentials for Users in Untrusted Environments</a> in the <i>IAM User Guide</i>.
        /// 
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the GetSessionToken service method, as returned by SecurityTokenService.</returns>
        /// <exception cref="Amazon.SecurityToken.Model.RegionDisabledException">
        /// STS is not activated in the requested region for the account that is being asked to
        /// generate credentials. The account administrator must use the IAM console to activate
        /// STS in that region. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
        /// and Deactivating AWS STS in an AWS Region</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/GetSessionToken">REST API Reference for GetSessionToken Operation</seealso>
        public virtual GetSessionTokenResponse GetSessionToken()
        {
            return GetSessionToken(new GetSessionTokenRequest());
        }

        /// <summary>
        /// Returns a set of temporary credentials for an AWS account or IAM user. The credentials
        /// consist of an access key ID, a secret access key, and a security token. Typically,
        /// you use <code>GetSessionToken</code> if you want to use MFA to protect programmatic
        /// calls to specific AWS API operations like Amazon EC2 <code>StopInstances</code>. MFA-enabled
        /// IAM users would need to call <code>GetSessionToken</code> and submit an MFA code that
        /// is associated with their MFA device. Using the temporary security credentials that
        /// are returned from the call, IAM users can then make programmatic calls to API operations
        /// that require MFA authentication. If you do not supply a correct MFA code, then the
        /// API returns an access denied error. For a comparison of <code>GetSessionToken</code>
        /// with the other API operations that produce temporary credentials, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html">Requesting
        /// Temporary Security Credentials</a> and <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#stsapi_comparison">Comparing
        /// the AWS STS API operations</a> in the <i>IAM User Guide</i>.
        /// 
        ///  
        /// <para>
        /// The <code>GetSessionToken</code> operation must be called by using the long-term AWS
        /// security credentials of the AWS account root user or an IAM user. Credentials that
        /// are created by IAM users are valid for the duration that you specify. This duration
        /// can range from 900 seconds (15 minutes) up to a maximum of 129,600 seconds (36 hours),
        /// with a default of 43,200 seconds (12 hours). Credentials based on account credentials
        /// can range from 900 seconds (15 minutes) up to 3,600 seconds (1 hour), with a default
        /// of 1 hour. 
        /// </para>
        ///  
        /// <para>
        /// The temporary security credentials created by <code>GetSessionToken</code> can be
        /// used to make API calls to any AWS service with the following exceptions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You cannot call any IAM API operations unless MFA authentication information is included
        /// in the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot call any STS API <i>except</i> <code>AssumeRole</code> or <code>GetCallerIdentity</code>.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// We recommend that you do not call <code>GetSessionToken</code> with AWS account root
        /// user credentials. Instead, follow our <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/best-practices.html#create-iam-users">best
        /// practices</a> by creating one or more IAM users, giving them the necessary permissions,
        /// and using IAM users for everyday interaction with AWS. 
        /// </para>
        ///  </note> 
        /// <para>
        /// The credentials that are returned by <code>GetSessionToken</code> are based on permissions
        /// associated with the user whose credentials were used to call the operation. If <code>GetSessionToken</code>
        /// is called using AWS account root user credentials, the temporary credentials have
        /// root user permissions. Similarly, if <code>GetSessionToken</code> is called using
        /// the credentials of an IAM user, the temporary credentials have the same permissions
        /// as the IAM user. 
        /// </para>
        ///  
        /// <para>
        /// For more information about using <code>GetSessionToken</code> to create temporary
        /// credentials, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_request.html#api_getsessiontoken">Temporary
        /// Credentials for Users in Untrusted Environments</a> in the <i>IAM User Guide</i>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSessionToken service method.</param>
        /// 
        /// <returns>The response from the GetSessionToken service method, as returned by SecurityTokenService.</returns>
        /// <exception cref="Amazon.SecurityToken.Model.RegionDisabledException">
        /// STS is not activated in the requested region for the account that is being asked to
        /// generate credentials. The account administrator must use the IAM console to activate
        /// STS in that region. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
        /// and Deactivating AWS STS in an AWS Region</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/GetSessionToken">REST API Reference for GetSessionToken Operation</seealso>
        public virtual GetSessionTokenResponse GetSessionToken(GetSessionTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSessionTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionTokenResponseUnmarshaller.Instance;

            return Invoke<GetSessionTokenResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSessionToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSessionToken operation on AmazonSecurityTokenServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSessionToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/GetSessionToken">REST API Reference for GetSessionToken Operation</seealso>
        public virtual IAsyncResult BeginGetSessionToken(GetSessionTokenRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSessionTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionTokenResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSessionToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSessionToken.</param>
        /// 
        /// <returns>Returns a  GetSessionTokenResult from SecurityTokenService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sts-2011-06-15/GetSessionToken">REST API Reference for GetSessionToken Operation</seealso>
        public virtual GetSessionTokenResponse EndGetSessionToken(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSessionTokenResponse>(asyncResult);
        }

        #endregion
        
    }
}