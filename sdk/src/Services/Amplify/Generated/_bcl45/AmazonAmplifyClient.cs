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
 * Do not modify this file. This file is generated from the amplify-2017-07-25.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Amplify.Model;
using Amazon.Amplify.Model.Internal.MarshallTransformations;
using Amazon.Amplify.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Amplify
{
    /// <summary>
    /// Implementation for accessing Amplify
    ///
    /// Amplify is a fully managed continuous deployment and hosting service for modern web
    /// apps.
    /// </summary>
    public partial class AmazonAmplifyClient : AmazonServiceClient, IAmazonAmplify
    {
        private static IServiceMetadata serviceMetadata = new AmazonAmplifyMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonAmplifyClient with the credentials loaded from the application's
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
        public AmazonAmplifyClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAmplifyConfig()) { }

        /// <summary>
        /// Constructs AmazonAmplifyClient with the credentials loaded from the application's
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
        public AmazonAmplifyClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAmplifyConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAmplifyClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAmplifyClient Configuration Object</param>
        public AmazonAmplifyClient(AmazonAmplifyConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonAmplifyClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAmplifyClient(AWSCredentials credentials)
            : this(credentials, new AmazonAmplifyConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAmplifyClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAmplifyConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyClient with AWS Credentials and an
        /// AmazonAmplifyClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAmplifyClient Configuration Object</param>
        public AmazonAmplifyClient(AWSCredentials credentials, AmazonAmplifyConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAmplifyClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAmplifyConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAmplifyClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAmplifyConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAmplifyClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAmplifyClient Configuration Object</param>
        public AmazonAmplifyClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAmplifyConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAmplifyClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAmplifyConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAmplifyClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAmplifyConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAmplifyClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAmplifyClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAmplifyClient Configuration Object</param>
        public AmazonAmplifyClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAmplifyConfig clientConfig)
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


        #region  CreateApp


        /// <summary>
        /// Creates a new Amplify App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApp service method.</param>
        /// 
        /// <returns>The response from the CreateApp service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// Exception thrown when an operation fails due to a dependent service throwing an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// Exception thrown when a resource could not be created because of service limits.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/CreateApp">REST API Reference for CreateApp Operation</seealso>
        public virtual CreateAppResponse CreateApp(CreateAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppResponseUnmarshaller.Instance;

            return Invoke<CreateAppResponse>(request, options);
        }


        /// <summary>
        /// Creates a new Amplify App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApp service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// Exception thrown when an operation fails due to a dependent service throwing an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// Exception thrown when a resource could not be created because of service limits.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/CreateApp">REST API Reference for CreateApp Operation</seealso>
        public virtual Task<CreateAppResponse> CreateAppAsync(CreateAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateAppResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateBranch


        /// <summary>
        /// Creates a new Branch for an Amplify App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBranch service method.</param>
        /// 
        /// <returns>The response from the CreateBranch service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// Exception thrown when an operation fails due to a dependent service throwing an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// Exception thrown when a resource could not be created because of service limits.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/CreateBranch">REST API Reference for CreateBranch Operation</seealso>
        public virtual CreateBranchResponse CreateBranch(CreateBranchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBranchResponseUnmarshaller.Instance;

            return Invoke<CreateBranchResponse>(request, options);
        }


        /// <summary>
        /// Creates a new Branch for an Amplify App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBranch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBranch service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// Exception thrown when an operation fails due to a dependent service throwing an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// Exception thrown when a resource could not be created because of service limits.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/CreateBranch">REST API Reference for CreateBranch Operation</seealso>
        public virtual Task<CreateBranchResponse> CreateBranchAsync(CreateBranchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBranchResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateBranchResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDeployment


        /// <summary>
        /// Create a deployment for manual deploy apps. (Apps are not connected to repository)
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment service method.</param>
        /// 
        /// <returns>The response from the CreateDeployment service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// Exception thrown when a resource could not be created because of service limits.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        public virtual CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return Invoke<CreateDeploymentResponse>(request, options);
        }


        /// <summary>
        /// Create a deployment for manual deploy apps. (Apps are not connected to repository)
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDeployment service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// Exception thrown when a resource could not be created because of service limits.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        public virtual Task<CreateDeploymentResponse> CreateDeploymentAsync(CreateDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeploymentResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDeploymentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDomainAssociation


        /// <summary>
        /// Create a new DomainAssociation on an App
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainAssociation service method.</param>
        /// 
        /// <returns>The response from the CreateDomainAssociation service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// Exception thrown when an operation fails due to a dependent service throwing an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// Exception thrown when a resource could not be created because of service limits.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/CreateDomainAssociation">REST API Reference for CreateDomainAssociation Operation</seealso>
        public virtual CreateDomainAssociationResponse CreateDomainAssociation(CreateDomainAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainAssociationResponseUnmarshaller.Instance;

            return Invoke<CreateDomainAssociationResponse>(request, options);
        }


        /// <summary>
        /// Create a new DomainAssociation on an App
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDomainAssociation service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// Exception thrown when an operation fails due to a dependent service throwing an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// Exception thrown when a resource could not be created because of service limits.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/CreateDomainAssociation">REST API Reference for CreateDomainAssociation Operation</seealso>
        public virtual Task<CreateDomainAssociationResponse> CreateDomainAssociationAsync(CreateDomainAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainAssociationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDomainAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateWebhook


        /// <summary>
        /// Create a new webhook on an App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebhook service method.</param>
        /// 
        /// <returns>The response from the CreateWebhook service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// Exception thrown when an operation fails due to a dependent service throwing an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// Exception thrown when a resource could not be created because of service limits.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/CreateWebhook">REST API Reference for CreateWebhook Operation</seealso>
        public virtual CreateWebhookResponse CreateWebhook(CreateWebhookRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWebhookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWebhookResponseUnmarshaller.Instance;

            return Invoke<CreateWebhookResponse>(request, options);
        }


        /// <summary>
        /// Create a new webhook on an App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebhook service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWebhook service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// Exception thrown when an operation fails due to a dependent service throwing an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// Exception thrown when a resource could not be created because of service limits.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/CreateWebhook">REST API Reference for CreateWebhook Operation</seealso>
        public virtual Task<CreateWebhookResponse> CreateWebhookAsync(CreateWebhookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWebhookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWebhookResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateWebhookResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteApp


        /// <summary>
        /// Delete an existing Amplify App by appId.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp service method.</param>
        /// 
        /// <returns>The response from the DeleteApp service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// Exception thrown when an operation fails due to a dependent service throwing an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        public virtual DeleteAppResponse DeleteApp(DeleteAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppResponseUnmarshaller.Instance;

            return Invoke<DeleteAppResponse>(request, options);
        }


        /// <summary>
        /// Delete an existing Amplify App by appId.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApp service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// Exception thrown when an operation fails due to a dependent service throwing an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        public virtual Task<DeleteAppResponse> DeleteAppAsync(DeleteAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAppResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBranch


        /// <summary>
        /// Deletes a branch for an Amplify App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBranch service method.</param>
        /// 
        /// <returns>The response from the DeleteBranch service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// Exception thrown when an operation fails due to a dependent service throwing an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/DeleteBranch">REST API Reference for DeleteBranch Operation</seealso>
        public virtual DeleteBranchResponse DeleteBranch(DeleteBranchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBranchResponseUnmarshaller.Instance;

            return Invoke<DeleteBranchResponse>(request, options);
        }


        /// <summary>
        /// Deletes a branch for an Amplify App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBranch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBranch service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// Exception thrown when an operation fails due to a dependent service throwing an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/DeleteBranch">REST API Reference for DeleteBranch Operation</seealso>
        public virtual Task<DeleteBranchResponse> DeleteBranchAsync(DeleteBranchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBranchResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteBranchResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDomainAssociation


        /// <summary>
        /// Deletes a DomainAssociation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainAssociation service method.</param>
        /// 
        /// <returns>The response from the DeleteDomainAssociation service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// Exception thrown when an operation fails due to a dependent service throwing an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/DeleteDomainAssociation">REST API Reference for DeleteDomainAssociation Operation</seealso>
        public virtual DeleteDomainAssociationResponse DeleteDomainAssociation(DeleteDomainAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainAssociationResponse>(request, options);
        }


        /// <summary>
        /// Deletes a DomainAssociation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDomainAssociation service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// Exception thrown when an operation fails due to a dependent service throwing an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/DeleteDomainAssociation">REST API Reference for DeleteDomainAssociation Operation</seealso>
        public virtual Task<DeleteDomainAssociationResponse> DeleteDomainAssociationAsync(DeleteDomainAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainAssociationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDomainAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteJob


        /// <summary>
        /// Delete a job, for an Amplify branch, part of Amplify App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJob service method.</param>
        /// 
        /// <returns>The response from the DeleteJob service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// Exception thrown when a resource could not be created because of service limits.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        public virtual DeleteJobResponse DeleteJob(DeleteJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJobResponseUnmarshaller.Instance;

            return Invoke<DeleteJobResponse>(request, options);
        }


        /// <summary>
        /// Delete a job, for an Amplify branch, part of Amplify App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteJob service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// Exception thrown when a resource could not be created because of service limits.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        public virtual Task<DeleteJobResponse> DeleteJobAsync(DeleteJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteWebhook


        /// <summary>
        /// Deletes a webhook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebhook service method.</param>
        /// 
        /// <returns>The response from the DeleteWebhook service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// Exception thrown when a resource could not be created because of service limits.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/DeleteWebhook">REST API Reference for DeleteWebhook Operation</seealso>
        public virtual DeleteWebhookResponse DeleteWebhook(DeleteWebhookRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWebhookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWebhookResponseUnmarshaller.Instance;

            return Invoke<DeleteWebhookResponse>(request, options);
        }


        /// <summary>
        /// Deletes a webhook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebhook service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWebhook service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// Exception thrown when a resource could not be created because of service limits.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/DeleteWebhook">REST API Reference for DeleteWebhook Operation</seealso>
        public virtual Task<DeleteWebhookResponse> DeleteWebhookAsync(DeleteWebhookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWebhookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWebhookResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteWebhookResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GenerateAccessLogs


        /// <summary>
        /// Retrieve website access logs for a specific time range via a pre-signed URL. Optionally,
        /// deliver the logs to a given S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateAccessLogs service method.</param>
        /// 
        /// <returns>The response from the GenerateAccessLogs service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GenerateAccessLogs">REST API Reference for GenerateAccessLogs Operation</seealso>
        public virtual GenerateAccessLogsResponse GenerateAccessLogs(GenerateAccessLogsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateAccessLogsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateAccessLogsResponseUnmarshaller.Instance;

            return Invoke<GenerateAccessLogsResponse>(request, options);
        }


        /// <summary>
        /// Retrieve website access logs for a specific time range via a pre-signed URL. Optionally,
        /// deliver the logs to a given S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateAccessLogs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateAccessLogs service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GenerateAccessLogs">REST API Reference for GenerateAccessLogs Operation</seealso>
        public virtual Task<GenerateAccessLogsResponse> GenerateAccessLogsAsync(GenerateAccessLogsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateAccessLogsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateAccessLogsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GenerateAccessLogsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetApp


        /// <summary>
        /// Retrieves an existing Amplify App by appId.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApp service method.</param>
        /// 
        /// <returns>The response from the GetApp service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetApp">REST API Reference for GetApp Operation</seealso>
        public virtual GetAppResponse GetApp(GetAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppResponseUnmarshaller.Instance;

            return Invoke<GetAppResponse>(request, options);
        }


        /// <summary>
        /// Retrieves an existing Amplify App by appId.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApp service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetApp">REST API Reference for GetApp Operation</seealso>
        public virtual Task<GetAppResponse> GetAppAsync(GetAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAppResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetArtifactUrl


        /// <summary>
        /// Retrieves artifact info that corresponds to a artifactId.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetArtifactUrl service method.</param>
        /// 
        /// <returns>The response from the GetArtifactUrl service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// Exception thrown when a resource could not be created because of service limits.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetArtifactUrl">REST API Reference for GetArtifactUrl Operation</seealso>
        public virtual GetArtifactUrlResponse GetArtifactUrl(GetArtifactUrlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetArtifactUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetArtifactUrlResponseUnmarshaller.Instance;

            return Invoke<GetArtifactUrlResponse>(request, options);
        }


        /// <summary>
        /// Retrieves artifact info that corresponds to a artifactId.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetArtifactUrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetArtifactUrl service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// Exception thrown when a resource could not be created because of service limits.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetArtifactUrl">REST API Reference for GetArtifactUrl Operation</seealso>
        public virtual Task<GetArtifactUrlResponse> GetArtifactUrlAsync(GetArtifactUrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetArtifactUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetArtifactUrlResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetArtifactUrlResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBranch


        /// <summary>
        /// Retrieves a branch for an Amplify App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBranch service method.</param>
        /// 
        /// <returns>The response from the GetBranch service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetBranch">REST API Reference for GetBranch Operation</seealso>
        public virtual GetBranchResponse GetBranch(GetBranchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBranchResponseUnmarshaller.Instance;

            return Invoke<GetBranchResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a branch for an Amplify App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBranch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBranch service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetBranch">REST API Reference for GetBranch Operation</seealso>
        public virtual Task<GetBranchResponse> GetBranchAsync(GetBranchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBranchResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetBranchResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDomainAssociation


        /// <summary>
        /// Retrieves domain info that corresponds to an appId and domainName.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainAssociation service method.</param>
        /// 
        /// <returns>The response from the GetDomainAssociation service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetDomainAssociation">REST API Reference for GetDomainAssociation Operation</seealso>
        public virtual GetDomainAssociationResponse GetDomainAssociation(GetDomainAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainAssociationResponseUnmarshaller.Instance;

            return Invoke<GetDomainAssociationResponse>(request, options);
        }


        /// <summary>
        /// Retrieves domain info that corresponds to an appId and domainName.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDomainAssociation service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetDomainAssociation">REST API Reference for GetDomainAssociation Operation</seealso>
        public virtual Task<GetDomainAssociationResponse> GetDomainAssociationAsync(GetDomainAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainAssociationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDomainAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetJob


        /// <summary>
        /// Get a job for a branch, part of an Amplify App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJob service method.</param>
        /// 
        /// <returns>The response from the GetJob service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// Exception thrown when a resource could not be created because of service limits.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetJob">REST API Reference for GetJob Operation</seealso>
        public virtual GetJobResponse GetJob(GetJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobResponseUnmarshaller.Instance;

            return Invoke<GetJobResponse>(request, options);
        }


        /// <summary>
        /// Get a job for a branch, part of an Amplify App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetJob service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// Exception thrown when a resource could not be created because of service limits.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetJob">REST API Reference for GetJob Operation</seealso>
        public virtual Task<GetJobResponse> GetJobAsync(GetJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetWebhook


        /// <summary>
        /// Retrieves webhook info that corresponds to a webhookId.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebhook service method.</param>
        /// 
        /// <returns>The response from the GetWebhook service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// Exception thrown when a resource could not be created because of service limits.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetWebhook">REST API Reference for GetWebhook Operation</seealso>
        public virtual GetWebhookResponse GetWebhook(GetWebhookRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWebhookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWebhookResponseUnmarshaller.Instance;

            return Invoke<GetWebhookResponse>(request, options);
        }


        /// <summary>
        /// Retrieves webhook info that corresponds to a webhookId.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebhook service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWebhook service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// Exception thrown when a resource could not be created because of service limits.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetWebhook">REST API Reference for GetWebhook Operation</seealso>
        public virtual Task<GetWebhookResponse> GetWebhookAsync(GetWebhookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWebhookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWebhookResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetWebhookResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListApps


        /// <summary>
        /// Lists existing Amplify Apps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApps service method.</param>
        /// 
        /// <returns>The response from the ListApps service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListApps">REST API Reference for ListApps Operation</seealso>
        public virtual ListAppsResponse ListApps(ListAppsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppsResponseUnmarshaller.Instance;

            return Invoke<ListAppsResponse>(request, options);
        }


        /// <summary>
        /// Lists existing Amplify Apps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApps service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListApps">REST API Reference for ListApps Operation</seealso>
        public virtual Task<ListAppsResponse> ListAppsAsync(ListAppsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAppsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListArtifacts


        /// <summary>
        /// List artifacts with an app, a branch, a job and an artifact type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListArtifacts service method.</param>
        /// 
        /// <returns>The response from the ListArtifacts service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// Exception thrown when a resource could not be created because of service limits.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListArtifacts">REST API Reference for ListArtifacts Operation</seealso>
        public virtual ListArtifactsResponse ListArtifacts(ListArtifactsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListArtifactsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListArtifactsResponseUnmarshaller.Instance;

            return Invoke<ListArtifactsResponse>(request, options);
        }


        /// <summary>
        /// List artifacts with an app, a branch, a job and an artifact type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListArtifacts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListArtifacts service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// Exception thrown when a resource could not be created because of service limits.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListArtifacts">REST API Reference for ListArtifacts Operation</seealso>
        public virtual Task<ListArtifactsResponse> ListArtifactsAsync(ListArtifactsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListArtifactsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListArtifactsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListArtifactsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBranches


        /// <summary>
        /// Lists branches for an Amplify App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBranches service method.</param>
        /// 
        /// <returns>The response from the ListBranches service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListBranches">REST API Reference for ListBranches Operation</seealso>
        public virtual ListBranchesResponse ListBranches(ListBranchesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBranchesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBranchesResponseUnmarshaller.Instance;

            return Invoke<ListBranchesResponse>(request, options);
        }


        /// <summary>
        /// Lists branches for an Amplify App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBranches service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBranches service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListBranches">REST API Reference for ListBranches Operation</seealso>
        public virtual Task<ListBranchesResponse> ListBranchesAsync(ListBranchesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBranchesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBranchesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListBranchesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDomainAssociations


        /// <summary>
        /// List domains with an app
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainAssociations service method.</param>
        /// 
        /// <returns>The response from the ListDomainAssociations service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListDomainAssociations">REST API Reference for ListDomainAssociations Operation</seealso>
        public virtual ListDomainAssociationsResponse ListDomainAssociations(ListDomainAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListDomainAssociationsResponse>(request, options);
        }


        /// <summary>
        /// List domains with an app
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomainAssociations service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListDomainAssociations">REST API Reference for ListDomainAssociations Operation</seealso>
        public virtual Task<ListDomainAssociationsResponse> ListDomainAssociationsAsync(ListDomainAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainAssociationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDomainAssociationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListJobs


        /// <summary>
        /// List Jobs for a branch, part of an Amplify App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// Exception thrown when a resource could not be created because of service limits.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public virtual ListJobsResponse ListJobs(ListJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;

            return Invoke<ListJobsResponse>(request, options);
        }


        /// <summary>
        /// List Jobs for a branch, part of an Amplify App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// Exception thrown when a resource could not be created because of service limits.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public virtual Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// List tags for resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.ResourceNotFoundException">
        /// Exception thrown when an operation fails due to non-existent resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// List tags for resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.ResourceNotFoundException">
        /// Exception thrown when an operation fails due to non-existent resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListWebhooks


        /// <summary>
        /// List webhooks with an app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebhooks service method.</param>
        /// 
        /// <returns>The response from the ListWebhooks service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// Exception thrown when a resource could not be created because of service limits.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListWebhooks">REST API Reference for ListWebhooks Operation</seealso>
        public virtual ListWebhooksResponse ListWebhooks(ListWebhooksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWebhooksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWebhooksResponseUnmarshaller.Instance;

            return Invoke<ListWebhooksResponse>(request, options);
        }


        /// <summary>
        /// List webhooks with an app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebhooks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWebhooks service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// Exception thrown when a resource could not be created because of service limits.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListWebhooks">REST API Reference for ListWebhooks Operation</seealso>
        public virtual Task<ListWebhooksResponse> ListWebhooksAsync(ListWebhooksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWebhooksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWebhooksResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListWebhooksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartDeployment


        /// <summary>
        /// Start a deployment for manual deploy apps. (Apps are not connected to repository)
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDeployment service method.</param>
        /// 
        /// <returns>The response from the StartDeployment service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// Exception thrown when a resource could not be created because of service limits.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/StartDeployment">REST API Reference for StartDeployment Operation</seealso>
        public virtual StartDeploymentResponse StartDeployment(StartDeploymentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDeploymentResponseUnmarshaller.Instance;

            return Invoke<StartDeploymentResponse>(request, options);
        }


        /// <summary>
        /// Start a deployment for manual deploy apps. (Apps are not connected to repository)
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDeployment service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// Exception thrown when a resource could not be created because of service limits.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/StartDeployment">REST API Reference for StartDeployment Operation</seealso>
        public virtual Task<StartDeploymentResponse> StartDeploymentAsync(StartDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDeploymentResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartDeploymentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartJob


        /// <summary>
        /// Starts a new job for a branch, part of an Amplify App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartJob service method.</param>
        /// 
        /// <returns>The response from the StartJob service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// Exception thrown when a resource could not be created because of service limits.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/StartJob">REST API Reference for StartJob Operation</seealso>
        public virtual StartJobResponse StartJob(StartJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartJobResponseUnmarshaller.Instance;

            return Invoke<StartJobResponse>(request, options);
        }


        /// <summary>
        /// Starts a new job for a branch, part of an Amplify App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartJob service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// Exception thrown when a resource could not be created because of service limits.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/StartJob">REST API Reference for StartJob Operation</seealso>
        public virtual Task<StartJobResponse> StartJobAsync(StartJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopJob


        /// <summary>
        /// Stop a job that is in progress, for an Amplify branch, part of Amplify App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopJob service method.</param>
        /// 
        /// <returns>The response from the StopJob service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// Exception thrown when a resource could not be created because of service limits.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/StopJob">REST API Reference for StopJob Operation</seealso>
        public virtual StopJobResponse StopJob(StopJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopJobResponseUnmarshaller.Instance;

            return Invoke<StopJobResponse>(request, options);
        }


        /// <summary>
        /// Stop a job that is in progress, for an Amplify branch, part of Amplify App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopJob service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// Exception thrown when a resource could not be created because of service limits.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/StopJob">REST API Reference for StopJob Operation</seealso>
        public virtual Task<StopJobResponse> StopJobAsync(StopJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Tag resource with tag key and value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.ResourceNotFoundException">
        /// Exception thrown when an operation fails due to non-existent resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Tag resource with tag key and value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.ResourceNotFoundException">
        /// Exception thrown when an operation fails due to non-existent resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Untag resource with resourceArn.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.ResourceNotFoundException">
        /// Exception thrown when an operation fails due to non-existent resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Untag resource with resourceArn.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.ResourceNotFoundException">
        /// Exception thrown when an operation fails due to non-existent resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateApp


        /// <summary>
        /// Updates an existing Amplify App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApp service method.</param>
        /// 
        /// <returns>The response from the UpdateApp service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/UpdateApp">REST API Reference for UpdateApp Operation</seealso>
        public virtual UpdateAppResponse UpdateApp(UpdateAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAppResponseUnmarshaller.Instance;

            return Invoke<UpdateAppResponse>(request, options);
        }


        /// <summary>
        /// Updates an existing Amplify App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApp service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/UpdateApp">REST API Reference for UpdateApp Operation</seealso>
        public virtual Task<UpdateAppResponse> UpdateAppAsync(UpdateAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAppResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateAppResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateBranch


        /// <summary>
        /// Updates a branch for an Amplify App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBranch service method.</param>
        /// 
        /// <returns>The response from the UpdateBranch service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// Exception thrown when an operation fails due to a dependent service throwing an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/UpdateBranch">REST API Reference for UpdateBranch Operation</seealso>
        public virtual UpdateBranchResponse UpdateBranch(UpdateBranchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBranchResponseUnmarshaller.Instance;

            return Invoke<UpdateBranchResponse>(request, options);
        }


        /// <summary>
        /// Updates a branch for an Amplify App.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBranch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBranch service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// Exception thrown when an operation fails due to a dependent service throwing an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/UpdateBranch">REST API Reference for UpdateBranch Operation</seealso>
        public virtual Task<UpdateBranchResponse> UpdateBranchAsync(UpdateBranchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBranchResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateBranchResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDomainAssociation


        /// <summary>
        /// Create a new DomainAssociation on an App
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainAssociation service method.</param>
        /// 
        /// <returns>The response from the UpdateDomainAssociation service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// Exception thrown when an operation fails due to a dependent service throwing an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/UpdateDomainAssociation">REST API Reference for UpdateDomainAssociation Operation</seealso>
        public virtual UpdateDomainAssociationResponse UpdateDomainAssociation(UpdateDomainAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainAssociationResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainAssociationResponse>(request, options);
        }


        /// <summary>
        /// Create a new DomainAssociation on an App
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDomainAssociation service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// Exception thrown when an operation fails due to a dependent service throwing an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/UpdateDomainAssociation">REST API Reference for UpdateDomainAssociation Operation</seealso>
        public virtual Task<UpdateDomainAssociationResponse> UpdateDomainAssociationAsync(UpdateDomainAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDomainAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainAssociationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateDomainAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateWebhook


        /// <summary>
        /// Update a webhook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWebhook service method.</param>
        /// 
        /// <returns>The response from the UpdateWebhook service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// Exception thrown when an operation fails due to a dependent service throwing an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/UpdateWebhook">REST API Reference for UpdateWebhook Operation</seealso>
        public virtual UpdateWebhookResponse UpdateWebhook(UpdateWebhookRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWebhookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWebhookResponseUnmarshaller.Instance;

            return Invoke<UpdateWebhookResponse>(request, options);
        }


        /// <summary>
        /// Update a webhook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWebhook service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWebhook service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// Exception thrown when a request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// Exception thrown when an operation fails due to a dependent service throwing an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// Exception thrown when the service fails to perform an operation due to an internal
        /// issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// Exception thrown when an entity has not been found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// Exception thrown when an operation fails due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/UpdateWebhook">REST API Reference for UpdateWebhook Operation</seealso>
        public virtual Task<UpdateWebhookResponse> UpdateWebhookAsync(UpdateWebhookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWebhookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWebhookResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateWebhookResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}