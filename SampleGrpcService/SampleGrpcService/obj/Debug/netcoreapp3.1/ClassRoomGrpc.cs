// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/classRoom.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace SampleGrpcService.Protos {
  public static partial class ClassRoom
  {
    static readonly string __ServiceName = "classroom.ClassRoom";

    static readonly grpc::Marshaller<global::SampleGrpcService.Protos.StudentRequest> __Marshaller_classroom_StudentRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SampleGrpcService.Protos.StudentRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SampleGrpcService.Protos.Student> __Marshaller_classroom_Student = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SampleGrpcService.Protos.Student.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SampleGrpcService.Protos.GetAllStudentsRequest> __Marshaller_classroom_GetAllStudentsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SampleGrpcService.Protos.GetAllStudentsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SampleGrpcService.Protos.AllStudents> __Marshaller_classroom_AllStudents = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SampleGrpcService.Protos.AllStudents.Parser.ParseFrom);

    static readonly grpc::Method<global::SampleGrpcService.Protos.StudentRequest, global::SampleGrpcService.Protos.Student> __Method_GetStudentInformation = new grpc::Method<global::SampleGrpcService.Protos.StudentRequest, global::SampleGrpcService.Protos.Student>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetStudentInformation",
        __Marshaller_classroom_StudentRequest,
        __Marshaller_classroom_Student);

    static readonly grpc::Method<global::SampleGrpcService.Protos.GetAllStudentsRequest, global::SampleGrpcService.Protos.AllStudents> __Method_GetAllStudents = new grpc::Method<global::SampleGrpcService.Protos.GetAllStudentsRequest, global::SampleGrpcService.Protos.AllStudents>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAllStudents",
        __Marshaller_classroom_GetAllStudentsRequest,
        __Marshaller_classroom_AllStudents);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::SampleGrpcService.Protos.ClassRoomReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ClassRoom</summary>
    [grpc::BindServiceMethod(typeof(ClassRoom), "BindService")]
    public abstract partial class ClassRoomBase
    {
      public virtual global::System.Threading.Tasks.Task<global::SampleGrpcService.Protos.Student> GetStudentInformation(global::SampleGrpcService.Protos.StudentRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::SampleGrpcService.Protos.AllStudents> GetAllStudents(global::SampleGrpcService.Protos.GetAllStudentsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ClassRoomBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetStudentInformation, serviceImpl.GetStudentInformation)
          .AddMethod(__Method_GetAllStudents, serviceImpl.GetAllStudents).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ClassRoomBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetStudentInformation, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::SampleGrpcService.Protos.StudentRequest, global::SampleGrpcService.Protos.Student>(serviceImpl.GetStudentInformation));
      serviceBinder.AddMethod(__Method_GetAllStudents, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::SampleGrpcService.Protos.GetAllStudentsRequest, global::SampleGrpcService.Protos.AllStudents>(serviceImpl.GetAllStudents));
    }

  }
}
#endregion
