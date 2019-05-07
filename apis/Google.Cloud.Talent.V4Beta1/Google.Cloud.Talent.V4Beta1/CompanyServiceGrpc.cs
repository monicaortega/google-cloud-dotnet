// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/talent/v4beta1/company_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2019 Google LLC.
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
//
//
#pragma warning disable 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Cloud.Talent.V4Beta1 {
  /// <summary>
  /// A service that handles company management, including CRUD and enumeration.
  /// </summary>
  public static partial class CompanyService
  {
    static readonly string __ServiceName = "google.cloud.talent.v4beta1.CompanyService";

    static readonly grpc::Marshaller<global::Google.Cloud.Talent.V4Beta1.CreateCompanyRequest> __Marshaller_CreateCompanyRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Talent.V4Beta1.CreateCompanyRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Talent.V4Beta1.Company> __Marshaller_Company = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Talent.V4Beta1.Company.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Talent.V4Beta1.GetCompanyRequest> __Marshaller_GetCompanyRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Talent.V4Beta1.GetCompanyRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Talent.V4Beta1.UpdateCompanyRequest> __Marshaller_UpdateCompanyRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Talent.V4Beta1.UpdateCompanyRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Talent.V4Beta1.DeleteCompanyRequest> __Marshaller_DeleteCompanyRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Talent.V4Beta1.DeleteCompanyRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Talent.V4Beta1.ListCompaniesRequest> __Marshaller_ListCompaniesRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Talent.V4Beta1.ListCompaniesRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Talent.V4Beta1.ListCompaniesResponse> __Marshaller_ListCompaniesResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Talent.V4Beta1.ListCompaniesResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Cloud.Talent.V4Beta1.CreateCompanyRequest, global::Google.Cloud.Talent.V4Beta1.Company> __Method_CreateCompany = new grpc::Method<global::Google.Cloud.Talent.V4Beta1.CreateCompanyRequest, global::Google.Cloud.Talent.V4Beta1.Company>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateCompany",
        __Marshaller_CreateCompanyRequest,
        __Marshaller_Company);

    static readonly grpc::Method<global::Google.Cloud.Talent.V4Beta1.GetCompanyRequest, global::Google.Cloud.Talent.V4Beta1.Company> __Method_GetCompany = new grpc::Method<global::Google.Cloud.Talent.V4Beta1.GetCompanyRequest, global::Google.Cloud.Talent.V4Beta1.Company>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCompany",
        __Marshaller_GetCompanyRequest,
        __Marshaller_Company);

    static readonly grpc::Method<global::Google.Cloud.Talent.V4Beta1.UpdateCompanyRequest, global::Google.Cloud.Talent.V4Beta1.Company> __Method_UpdateCompany = new grpc::Method<global::Google.Cloud.Talent.V4Beta1.UpdateCompanyRequest, global::Google.Cloud.Talent.V4Beta1.Company>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateCompany",
        __Marshaller_UpdateCompanyRequest,
        __Marshaller_Company);

    static readonly grpc::Method<global::Google.Cloud.Talent.V4Beta1.DeleteCompanyRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteCompany = new grpc::Method<global::Google.Cloud.Talent.V4Beta1.DeleteCompanyRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteCompany",
        __Marshaller_DeleteCompanyRequest,
        __Marshaller_Empty);

    static readonly grpc::Method<global::Google.Cloud.Talent.V4Beta1.ListCompaniesRequest, global::Google.Cloud.Talent.V4Beta1.ListCompaniesResponse> __Method_ListCompanies = new grpc::Method<global::Google.Cloud.Talent.V4Beta1.ListCompaniesRequest, global::Google.Cloud.Talent.V4Beta1.ListCompaniesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListCompanies",
        __Marshaller_ListCompaniesRequest,
        __Marshaller_ListCompaniesResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Talent.V4Beta1.CompanyServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CompanyService</summary>
    public abstract partial class CompanyServiceBase
    {
      /// <summary>
      /// Creates a new company entity.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Talent.V4Beta1.Company> CreateCompany(global::Google.Cloud.Talent.V4Beta1.CreateCompanyRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Retrieves specified company.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Talent.V4Beta1.Company> GetCompany(global::Google.Cloud.Talent.V4Beta1.GetCompanyRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Updates specified company.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Talent.V4Beta1.Company> UpdateCompany(global::Google.Cloud.Talent.V4Beta1.UpdateCompanyRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Deletes specified company.
      /// Prerequisite: The company has no jobs associated with it.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteCompany(global::Google.Cloud.Talent.V4Beta1.DeleteCompanyRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Lists all companies associated with the project.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Talent.V4Beta1.ListCompaniesResponse> ListCompanies(global::Google.Cloud.Talent.V4Beta1.ListCompaniesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for CompanyService</summary>
    public partial class CompanyServiceClient : grpc::ClientBase<CompanyServiceClient>
    {
      /// <summary>Creates a new client for CompanyService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public CompanyServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CompanyService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public CompanyServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected CompanyServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected CompanyServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Creates a new company entity.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Talent.V4Beta1.Company CreateCompany(global::Google.Cloud.Talent.V4Beta1.CreateCompanyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateCompany(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a new company entity.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Talent.V4Beta1.Company CreateCompany(global::Google.Cloud.Talent.V4Beta1.CreateCompanyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateCompany, null, options, request);
      }
      /// <summary>
      /// Creates a new company entity.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Talent.V4Beta1.Company> CreateCompanyAsync(global::Google.Cloud.Talent.V4Beta1.CreateCompanyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateCompanyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a new company entity.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Talent.V4Beta1.Company> CreateCompanyAsync(global::Google.Cloud.Talent.V4Beta1.CreateCompanyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateCompany, null, options, request);
      }
      /// <summary>
      /// Retrieves specified company.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Talent.V4Beta1.Company GetCompany(global::Google.Cloud.Talent.V4Beta1.GetCompanyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCompany(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves specified company.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Talent.V4Beta1.Company GetCompany(global::Google.Cloud.Talent.V4Beta1.GetCompanyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetCompany, null, options, request);
      }
      /// <summary>
      /// Retrieves specified company.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Talent.V4Beta1.Company> GetCompanyAsync(global::Google.Cloud.Talent.V4Beta1.GetCompanyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCompanyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves specified company.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Talent.V4Beta1.Company> GetCompanyAsync(global::Google.Cloud.Talent.V4Beta1.GetCompanyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetCompany, null, options, request);
      }
      /// <summary>
      /// Updates specified company.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Talent.V4Beta1.Company UpdateCompany(global::Google.Cloud.Talent.V4Beta1.UpdateCompanyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateCompany(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates specified company.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Talent.V4Beta1.Company UpdateCompany(global::Google.Cloud.Talent.V4Beta1.UpdateCompanyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateCompany, null, options, request);
      }
      /// <summary>
      /// Updates specified company.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Talent.V4Beta1.Company> UpdateCompanyAsync(global::Google.Cloud.Talent.V4Beta1.UpdateCompanyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateCompanyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates specified company.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Talent.V4Beta1.Company> UpdateCompanyAsync(global::Google.Cloud.Talent.V4Beta1.UpdateCompanyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateCompany, null, options, request);
      }
      /// <summary>
      /// Deletes specified company.
      /// Prerequisite: The company has no jobs associated with it.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteCompany(global::Google.Cloud.Talent.V4Beta1.DeleteCompanyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteCompany(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes specified company.
      /// Prerequisite: The company has no jobs associated with it.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteCompany(global::Google.Cloud.Talent.V4Beta1.DeleteCompanyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteCompany, null, options, request);
      }
      /// <summary>
      /// Deletes specified company.
      /// Prerequisite: The company has no jobs associated with it.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteCompanyAsync(global::Google.Cloud.Talent.V4Beta1.DeleteCompanyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteCompanyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes specified company.
      /// Prerequisite: The company has no jobs associated with it.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteCompanyAsync(global::Google.Cloud.Talent.V4Beta1.DeleteCompanyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteCompany, null, options, request);
      }
      /// <summary>
      /// Lists all companies associated with the project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Talent.V4Beta1.ListCompaniesResponse ListCompanies(global::Google.Cloud.Talent.V4Beta1.ListCompaniesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListCompanies(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists all companies associated with the project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Talent.V4Beta1.ListCompaniesResponse ListCompanies(global::Google.Cloud.Talent.V4Beta1.ListCompaniesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListCompanies, null, options, request);
      }
      /// <summary>
      /// Lists all companies associated with the project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Talent.V4Beta1.ListCompaniesResponse> ListCompaniesAsync(global::Google.Cloud.Talent.V4Beta1.ListCompaniesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListCompaniesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists all companies associated with the project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Talent.V4Beta1.ListCompaniesResponse> ListCompaniesAsync(global::Google.Cloud.Talent.V4Beta1.ListCompaniesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListCompanies, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override CompanyServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CompanyServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(CompanyServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreateCompany, serviceImpl.CreateCompany)
          .AddMethod(__Method_GetCompany, serviceImpl.GetCompany)
          .AddMethod(__Method_UpdateCompany, serviceImpl.UpdateCompany)
          .AddMethod(__Method_DeleteCompany, serviceImpl.DeleteCompany)
          .AddMethod(__Method_ListCompanies, serviceImpl.ListCompanies).Build();
    }

  }
}
#endregion