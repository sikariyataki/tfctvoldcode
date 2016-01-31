﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceDesk.SmarterTicketServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://www.smartertools.com/Products/SmarterTicket/Services/svcTickets", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.smartertools.com/Products/SmarterTicket/Services/svcTickets", ConfigurationName="SmarterTicketServiceReference.svcTicketsSoap")]
    public interface svcTicketsSoap {
        
        // CODEGEN: Generating message contract since element name agentUsername from namespace http://www.smartertools.com/Products/SmarterTicket/Services/svcTickets is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.smartertools.com/Products/SmarterTicket/Services/svcTickets/AddTicketN" +
            "ote", ReplyAction="*")]
        ServiceDesk.SmarterTicketServiceReference.AddTicketNoteResponse AddTicketNote(ServiceDesk.SmarterTicketServiceReference.AddTicketNoteRequest request);
        
        // CODEGEN: Generating message contract since element name agentUsername from namespace http://www.smartertools.com/Products/SmarterTicket/Services/svcTickets is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.smartertools.com/Products/SmarterTicket/Services/svcTickets/CloseTicke" +
            "t", ReplyAction="*")]
        ServiceDesk.SmarterTicketServiceReference.CloseTicketResponse CloseTicket(ServiceDesk.SmarterTicketServiceReference.CloseTicketRequest request);
        
        // CODEGEN: Generating message contract since element name agentUsername from namespace http://www.smartertools.com/Products/SmarterTicket/Services/svcTickets is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.smartertools.com/Products/SmarterTicket/Services/svcTickets/GetTicketS" +
            "tatus", ReplyAction="*")]
        ServiceDesk.SmarterTicketServiceReference.GetTicketStatusResponse GetTicketStatus(ServiceDesk.SmarterTicketServiceReference.GetTicketStatusRequest request);
        
        // CODEGEN: Generating message contract since element name agentUsername from namespace http://www.smartertools.com/Products/SmarterTicket/Services/svcTickets is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.smartertools.com/Products/SmarterTicket/Services/svcTickets/CreateTick" +
            "et", ReplyAction="*")]
        ServiceDesk.SmarterTicketServiceReference.CreateTicketResponse CreateTicket(ServiceDesk.SmarterTicketServiceReference.CreateTicketRequest request);
        
        // CODEGEN: Generating message contract since element name agentUsername from namespace http://www.smartertools.com/Products/SmarterTicket/Services/svcTickets is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.smartertools.com/Products/SmarterTicket/Services/svcTickets/GetTicketC" +
            "ount", ReplyAction="*")]
        ServiceDesk.SmarterTicketServiceReference.GetTicketCountResponse GetTicketCount(ServiceDesk.SmarterTicketServiceReference.GetTicketCountRequest request);
        
        // CODEGEN: Generating message contract since element name agentUsername from namespace http://www.smartertools.com/Products/SmarterTicket/Services/svcTickets is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.smartertools.com/Products/SmarterTicket/Services/svcTickets/GetGroupTi" +
            "cketInfo", ReplyAction="*")]
        ServiceDesk.SmarterTicketServiceReference.GetGroupTicketInfoResponse GetGroupTicketInfo(ServiceDesk.SmarterTicketServiceReference.GetGroupTicketInfoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddTicketNoteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddTicketNote", Namespace="http://www.smartertools.com/Products/SmarterTicket/Services/svcTickets", Order=0)]
        public ServiceDesk.SmarterTicketServiceReference.AddTicketNoteRequestBody Body;
        
        public AddTicketNoteRequest() {
        }
        
        public AddTicketNoteRequest(ServiceDesk.SmarterTicketServiceReference.AddTicketNoteRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.smartertools.com/Products/SmarterTicket/Services/svcTickets")]
    public partial class AddTicketNoteRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string agentUsername;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string agentPassword;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string ticketNumber;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string notetext;
        
        public AddTicketNoteRequestBody() {
        }
        
        public AddTicketNoteRequestBody(string agentUsername, string agentPassword, string ticketNumber, string notetext) {
            this.agentUsername = agentUsername;
            this.agentPassword = agentPassword;
            this.ticketNumber = ticketNumber;
            this.notetext = notetext;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddTicketNoteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddTicketNoteResponse", Namespace="http://www.smartertools.com/Products/SmarterTicket/Services/svcTickets", Order=0)]
        public ServiceDesk.SmarterTicketServiceReference.AddTicketNoteResponseBody Body;
        
        public AddTicketNoteResponse() {
        }
        
        public AddTicketNoteResponse(ServiceDesk.SmarterTicketServiceReference.AddTicketNoteResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class AddTicketNoteResponseBody {
        
        public AddTicketNoteResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CloseTicketRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CloseTicket", Namespace="http://www.smartertools.com/Products/SmarterTicket/Services/svcTickets", Order=0)]
        public ServiceDesk.SmarterTicketServiceReference.CloseTicketRequestBody Body;
        
        public CloseTicketRequest() {
        }
        
        public CloseTicketRequest(ServiceDesk.SmarterTicketServiceReference.CloseTicketRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.smartertools.com/Products/SmarterTicket/Services/svcTickets")]
    public partial class CloseTicketRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string agentUsername;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string agentPassword;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string ticketNumber;
        
        public CloseTicketRequestBody() {
        }
        
        public CloseTicketRequestBody(string agentUsername, string agentPassword, string ticketNumber) {
            this.agentUsername = agentUsername;
            this.agentPassword = agentPassword;
            this.ticketNumber = ticketNumber;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CloseTicketResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CloseTicketResponse", Namespace="http://www.smartertools.com/Products/SmarterTicket/Services/svcTickets", Order=0)]
        public ServiceDesk.SmarterTicketServiceReference.CloseTicketResponseBody Body;
        
        public CloseTicketResponse() {
        }
        
        public CloseTicketResponse(ServiceDesk.SmarterTicketServiceReference.CloseTicketResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class CloseTicketResponseBody {
        
        public CloseTicketResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetTicketStatusRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetTicketStatus", Namespace="http://www.smartertools.com/Products/SmarterTicket/Services/svcTickets", Order=0)]
        public ServiceDesk.SmarterTicketServiceReference.GetTicketStatusRequestBody Body;
        
        public GetTicketStatusRequest() {
        }
        
        public GetTicketStatusRequest(ServiceDesk.SmarterTicketServiceReference.GetTicketStatusRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.smartertools.com/Products/SmarterTicket/Services/svcTickets")]
    public partial class GetTicketStatusRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string agentUsername;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string agentPassword;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string ticketNumber;
        
        public GetTicketStatusRequestBody() {
        }
        
        public GetTicketStatusRequestBody(string agentUsername, string agentPassword, string ticketNumber) {
            this.agentUsername = agentUsername;
            this.agentPassword = agentPassword;
            this.ticketNumber = ticketNumber;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetTicketStatusResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetTicketStatusResponse", Namespace="http://www.smartertools.com/Products/SmarterTicket/Services/svcTickets", Order=0)]
        public ServiceDesk.SmarterTicketServiceReference.GetTicketStatusResponseBody Body;
        
        public GetTicketStatusResponse() {
        }
        
        public GetTicketStatusResponse(ServiceDesk.SmarterTicketServiceReference.GetTicketStatusResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.smartertools.com/Products/SmarterTicket/Services/svcTickets")]
    public partial class GetTicketStatusResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetTicketStatusResult;
        
        public GetTicketStatusResponseBody() {
        }
        
        public GetTicketStatusResponseBody(string GetTicketStatusResult) {
            this.GetTicketStatusResult = GetTicketStatusResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateTicketRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreateTicket", Namespace="http://www.smartertools.com/Products/SmarterTicket/Services/svcTickets", Order=0)]
        public ServiceDesk.SmarterTicketServiceReference.CreateTicketRequestBody Body;
        
        public CreateTicketRequest() {
        }
        
        public CreateTicketRequest(ServiceDesk.SmarterTicketServiceReference.CreateTicketRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.smartertools.com/Products/SmarterTicket/Services/svcTickets")]
    public partial class CreateTicketRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string agentUsername;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string agentPassword;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int departmentID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string fromAddress;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string subject;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string body;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=6)]
        public bool isHtml;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=7)]
        public bool sendAutoResponder;
        
        public CreateTicketRequestBody() {
        }
        
        public CreateTicketRequestBody(string agentUsername, string agentPassword, int departmentID, string fromAddress, string subject, string body, bool isHtml, bool sendAutoResponder) {
            this.agentUsername = agentUsername;
            this.agentPassword = agentPassword;
            this.departmentID = departmentID;
            this.fromAddress = fromAddress;
            this.subject = subject;
            this.body = body;
            this.isHtml = isHtml;
            this.sendAutoResponder = sendAutoResponder;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateTicketResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreateTicketResponse", Namespace="http://www.smartertools.com/Products/SmarterTicket/Services/svcTickets", Order=0)]
        public ServiceDesk.SmarterTicketServiceReference.CreateTicketResponseBody Body;
        
        public CreateTicketResponse() {
        }
        
        public CreateTicketResponse(ServiceDesk.SmarterTicketServiceReference.CreateTicketResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.smartertools.com/Products/SmarterTicket/Services/svcTickets")]
    public partial class CreateTicketResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CreateTicketResult;
        
        public CreateTicketResponseBody() {
        }
        
        public CreateTicketResponseBody(string CreateTicketResult) {
            this.CreateTicketResult = CreateTicketResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetTicketCountRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetTicketCount", Namespace="http://www.smartertools.com/Products/SmarterTicket/Services/svcTickets", Order=0)]
        public ServiceDesk.SmarterTicketServiceReference.GetTicketCountRequestBody Body;
        
        public GetTicketCountRequest() {
        }
        
        public GetTicketCountRequest(ServiceDesk.SmarterTicketServiceReference.GetTicketCountRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.smartertools.com/Products/SmarterTicket/Services/svcTickets")]
    public partial class GetTicketCountRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string agentUsername;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string agentPassword;
        
        public GetTicketCountRequestBody() {
        }
        
        public GetTicketCountRequestBody(string agentUsername, string agentPassword) {
            this.agentUsername = agentUsername;
            this.agentPassword = agentPassword;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetTicketCountResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetTicketCountResponse", Namespace="http://www.smartertools.com/Products/SmarterTicket/Services/svcTickets", Order=0)]
        public ServiceDesk.SmarterTicketServiceReference.GetTicketCountResponseBody Body;
        
        public GetTicketCountResponse() {
        }
        
        public GetTicketCountResponse(ServiceDesk.SmarterTicketServiceReference.GetTicketCountResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.smartertools.com/Products/SmarterTicket/Services/svcTickets")]
    public partial class GetTicketCountResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int GetTicketCountResult;
        
        public GetTicketCountResponseBody() {
        }
        
        public GetTicketCountResponseBody(int GetTicketCountResult) {
            this.GetTicketCountResult = GetTicketCountResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetGroupTicketInfoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetGroupTicketInfo", Namespace="http://www.smartertools.com/Products/SmarterTicket/Services/svcTickets", Order=0)]
        public ServiceDesk.SmarterTicketServiceReference.GetGroupTicketInfoRequestBody Body;
        
        public GetGroupTicketInfoRequest() {
        }
        
        public GetGroupTicketInfoRequest(ServiceDesk.SmarterTicketServiceReference.GetGroupTicketInfoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.smartertools.com/Products/SmarterTicket/Services/svcTickets")]
    public partial class GetGroupTicketInfoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string agentUsername;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string agentPassword;
        
        public GetGroupTicketInfoRequestBody() {
        }
        
        public GetGroupTicketInfoRequestBody(string agentUsername, string agentPassword) {
            this.agentUsername = agentUsername;
            this.agentPassword = agentPassword;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetGroupTicketInfoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetGroupTicketInfoResponse", Namespace="http://www.smartertools.com/Products/SmarterTicket/Services/svcTickets", Order=0)]
        public ServiceDesk.SmarterTicketServiceReference.GetGroupTicketInfoResponseBody Body;
        
        public GetGroupTicketInfoResponse() {
        }
        
        public GetGroupTicketInfoResponse(ServiceDesk.SmarterTicketServiceReference.GetGroupTicketInfoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.smartertools.com/Products/SmarterTicket/Services/svcTickets")]
    public partial class GetGroupTicketInfoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServiceDesk.SmarterTicketServiceReference.ArrayOfString GetGroupTicketInfoResult;
        
        public GetGroupTicketInfoResponseBody() {
        }
        
        public GetGroupTicketInfoResponseBody(ServiceDesk.SmarterTicketServiceReference.ArrayOfString GetGroupTicketInfoResult) {
            this.GetGroupTicketInfoResult = GetGroupTicketInfoResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface svcTicketsSoapChannel : ServiceDesk.SmarterTicketServiceReference.svcTicketsSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class svcTicketsSoapClient : System.ServiceModel.ClientBase<ServiceDesk.SmarterTicketServiceReference.svcTicketsSoap>, ServiceDesk.SmarterTicketServiceReference.svcTicketsSoap {
        
        public svcTicketsSoapClient() {
        }
        
        public svcTicketsSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public svcTicketsSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public svcTicketsSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public svcTicketsSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiceDesk.SmarterTicketServiceReference.AddTicketNoteResponse ServiceDesk.SmarterTicketServiceReference.svcTicketsSoap.AddTicketNote(ServiceDesk.SmarterTicketServiceReference.AddTicketNoteRequest request) {
            return base.Channel.AddTicketNote(request);
        }
        
        public void AddTicketNote(string agentUsername, string agentPassword, string ticketNumber, string notetext) {
            ServiceDesk.SmarterTicketServiceReference.AddTicketNoteRequest inValue = new ServiceDesk.SmarterTicketServiceReference.AddTicketNoteRequest();
            inValue.Body = new ServiceDesk.SmarterTicketServiceReference.AddTicketNoteRequestBody();
            inValue.Body.agentUsername = agentUsername;
            inValue.Body.agentPassword = agentPassword;
            inValue.Body.ticketNumber = ticketNumber;
            inValue.Body.notetext = notetext;
            ServiceDesk.SmarterTicketServiceReference.AddTicketNoteResponse retVal = ((ServiceDesk.SmarterTicketServiceReference.svcTicketsSoap)(this)).AddTicketNote(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiceDesk.SmarterTicketServiceReference.CloseTicketResponse ServiceDesk.SmarterTicketServiceReference.svcTicketsSoap.CloseTicket(ServiceDesk.SmarterTicketServiceReference.CloseTicketRequest request) {
            return base.Channel.CloseTicket(request);
        }
        
        public void CloseTicket(string agentUsername, string agentPassword, string ticketNumber) {
            ServiceDesk.SmarterTicketServiceReference.CloseTicketRequest inValue = new ServiceDesk.SmarterTicketServiceReference.CloseTicketRequest();
            inValue.Body = new ServiceDesk.SmarterTicketServiceReference.CloseTicketRequestBody();
            inValue.Body.agentUsername = agentUsername;
            inValue.Body.agentPassword = agentPassword;
            inValue.Body.ticketNumber = ticketNumber;
            ServiceDesk.SmarterTicketServiceReference.CloseTicketResponse retVal = ((ServiceDesk.SmarterTicketServiceReference.svcTicketsSoap)(this)).CloseTicket(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiceDesk.SmarterTicketServiceReference.GetTicketStatusResponse ServiceDesk.SmarterTicketServiceReference.svcTicketsSoap.GetTicketStatus(ServiceDesk.SmarterTicketServiceReference.GetTicketStatusRequest request) {
            return base.Channel.GetTicketStatus(request);
        }
        
        public string GetTicketStatus(string agentUsername, string agentPassword, string ticketNumber) {
            ServiceDesk.SmarterTicketServiceReference.GetTicketStatusRequest inValue = new ServiceDesk.SmarterTicketServiceReference.GetTicketStatusRequest();
            inValue.Body = new ServiceDesk.SmarterTicketServiceReference.GetTicketStatusRequestBody();
            inValue.Body.agentUsername = agentUsername;
            inValue.Body.agentPassword = agentPassword;
            inValue.Body.ticketNumber = ticketNumber;
            ServiceDesk.SmarterTicketServiceReference.GetTicketStatusResponse retVal = ((ServiceDesk.SmarterTicketServiceReference.svcTicketsSoap)(this)).GetTicketStatus(inValue);
            return retVal.Body.GetTicketStatusResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiceDesk.SmarterTicketServiceReference.CreateTicketResponse ServiceDesk.SmarterTicketServiceReference.svcTicketsSoap.CreateTicket(ServiceDesk.SmarterTicketServiceReference.CreateTicketRequest request) {
            return base.Channel.CreateTicket(request);
        }
        
        public string CreateTicket(string agentUsername, string agentPassword, int departmentID, string fromAddress, string subject, string body, bool isHtml, bool sendAutoResponder) {
            ServiceDesk.SmarterTicketServiceReference.CreateTicketRequest inValue = new ServiceDesk.SmarterTicketServiceReference.CreateTicketRequest();
            inValue.Body = new ServiceDesk.SmarterTicketServiceReference.CreateTicketRequestBody();
            inValue.Body.agentUsername = agentUsername;
            inValue.Body.agentPassword = agentPassword;
            inValue.Body.departmentID = departmentID;
            inValue.Body.fromAddress = fromAddress;
            inValue.Body.subject = subject;
            inValue.Body.body = body;
            inValue.Body.isHtml = isHtml;
            inValue.Body.sendAutoResponder = sendAutoResponder;
            ServiceDesk.SmarterTicketServiceReference.CreateTicketResponse retVal = ((ServiceDesk.SmarterTicketServiceReference.svcTicketsSoap)(this)).CreateTicket(inValue);
            return retVal.Body.CreateTicketResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiceDesk.SmarterTicketServiceReference.GetTicketCountResponse ServiceDesk.SmarterTicketServiceReference.svcTicketsSoap.GetTicketCount(ServiceDesk.SmarterTicketServiceReference.GetTicketCountRequest request) {
            return base.Channel.GetTicketCount(request);
        }
        
        public int GetTicketCount(string agentUsername, string agentPassword) {
            ServiceDesk.SmarterTicketServiceReference.GetTicketCountRequest inValue = new ServiceDesk.SmarterTicketServiceReference.GetTicketCountRequest();
            inValue.Body = new ServiceDesk.SmarterTicketServiceReference.GetTicketCountRequestBody();
            inValue.Body.agentUsername = agentUsername;
            inValue.Body.agentPassword = agentPassword;
            ServiceDesk.SmarterTicketServiceReference.GetTicketCountResponse retVal = ((ServiceDesk.SmarterTicketServiceReference.svcTicketsSoap)(this)).GetTicketCount(inValue);
            return retVal.Body.GetTicketCountResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiceDesk.SmarterTicketServiceReference.GetGroupTicketInfoResponse ServiceDesk.SmarterTicketServiceReference.svcTicketsSoap.GetGroupTicketInfo(ServiceDesk.SmarterTicketServiceReference.GetGroupTicketInfoRequest request) {
            return base.Channel.GetGroupTicketInfo(request);
        }
        
        public ServiceDesk.SmarterTicketServiceReference.ArrayOfString GetGroupTicketInfo(string agentUsername, string agentPassword) {
            ServiceDesk.SmarterTicketServiceReference.GetGroupTicketInfoRequest inValue = new ServiceDesk.SmarterTicketServiceReference.GetGroupTicketInfoRequest();
            inValue.Body = new ServiceDesk.SmarterTicketServiceReference.GetGroupTicketInfoRequestBody();
            inValue.Body.agentUsername = agentUsername;
            inValue.Body.agentPassword = agentPassword;
            ServiceDesk.SmarterTicketServiceReference.GetGroupTicketInfoResponse retVal = ((ServiceDesk.SmarterTicketServiceReference.svcTicketsSoap)(this)).GetGroupTicketInfo(inValue);
            return retVal.Body.GetGroupTicketInfoResult;
        }
    }
}