// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/services/payments_account_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/services/payments_account_service.proto</summary>
  public static partial class PaymentsAccountServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/services/payments_account_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PaymentsAccountServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj9nb29nbGUvYWRzL2dvb2dsZWFkcy92MC9zZXJ2aWNlcy9wYXltZW50c19h",
            "Y2NvdW50X3NlcnZpY2UucHJvdG8SIGdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYw",
            "LnNlcnZpY2VzGjhnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9yZXNvdXJjZXMv",
            "cGF5bWVudHNfYWNjb3VudC5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9u",
            "cy5wcm90byIyChtMaXN0UGF5bWVudHNBY2NvdW50c1JlcXVlc3QSEwoLY3Vz",
            "dG9tZXJfaWQYASABKAkibQocTGlzdFBheW1lbnRzQWNjb3VudHNSZXNwb25z",
            "ZRJNChFwYXltZW50c19hY2NvdW50cxgBIAMoCzIyLmdvb2dsZS5hZHMuZ29v",
            "Z2xlYWRzLnYwLnJlc291cmNlcy5QYXltZW50c0FjY291bnQy6AEKFlBheW1l",
            "bnRzQWNjb3VudFNlcnZpY2USzQEKFExpc3RQYXltZW50c0FjY291bnRzEj0u",
            "Z29vZ2xlLmFkcy5nb29nbGVhZHMudjAuc2VydmljZXMuTGlzdFBheW1lbnRz",
            "QWNjb3VudHNSZXF1ZXN0Gj4uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjAuc2Vy",
            "dmljZXMuTGlzdFBheW1lbnRzQWNjb3VudHNSZXNwb25zZSI2gtPkkwIwEi4v",
            "djAvY3VzdG9tZXJzL3tjdXN0b21lcl9pZD0qfS9wYXltZW50c0FjY291bnRz",
            "QoICCiRjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjAuc2VydmljZXNCG1Bh",
            "eW1lbnRzQWNjb3VudFNlcnZpY2VQcm90b1ABWkhnb29nbGUuZ29sYW5nLm9y",
            "Zy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjAvc2Vydmlj",
            "ZXM7c2VydmljZXOiAgNHQUGqAiBHb29nbGUuQWRzLkdvb2dsZUFkcy5WMC5T",
            "ZXJ2aWNlc8oCIEdvb2dsZVxBZHNcR29vZ2xlQWRzXFYwXFNlcnZpY2Vz6gIk",
            "R29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjA6OlNlcnZpY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V0.Resources.PaymentsAccountReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Services.ListPaymentsAccountsRequest), global::Google.Ads.GoogleAds.V0.Services.ListPaymentsAccountsRequest.Parser, new[]{ "CustomerId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Services.ListPaymentsAccountsResponse), global::Google.Ads.GoogleAds.V0.Services.ListPaymentsAccountsResponse.Parser, new[]{ "PaymentsAccounts" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for fetching all accessible Payments accounts.
  /// </summary>
  public sealed partial class ListPaymentsAccountsRequest : pb::IMessage<ListPaymentsAccountsRequest> {
    private static readonly pb::MessageParser<ListPaymentsAccountsRequest> _parser = new pb::MessageParser<ListPaymentsAccountsRequest>(() => new ListPaymentsAccountsRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ListPaymentsAccountsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Services.PaymentsAccountServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListPaymentsAccountsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListPaymentsAccountsRequest(ListPaymentsAccountsRequest other) : this() {
      customerId_ = other.customerId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListPaymentsAccountsRequest Clone() {
      return new ListPaymentsAccountsRequest(this);
    }

    /// <summary>Field number for the "customer_id" field.</summary>
    public const int CustomerIdFieldNumber = 1;
    private string customerId_ = "";
    /// <summary>
    /// The ID of the customer to apply the PaymentsAccount list operation to.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CustomerId {
      get { return customerId_; }
      set {
        customerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ListPaymentsAccountsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ListPaymentsAccountsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CustomerId != other.CustomerId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CustomerId.Length != 0) hash ^= CustomerId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (CustomerId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CustomerId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CustomerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CustomerId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ListPaymentsAccountsRequest other) {
      if (other == null) {
        return;
      }
      if (other.CustomerId.Length != 0) {
        CustomerId = other.CustomerId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            CustomerId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Response message for [PaymentsAccountService.ListPaymentsAccounts][google.ads.googleads.v0.services.PaymentsAccountService.ListPaymentsAccounts].
  /// </summary>
  public sealed partial class ListPaymentsAccountsResponse : pb::IMessage<ListPaymentsAccountsResponse> {
    private static readonly pb::MessageParser<ListPaymentsAccountsResponse> _parser = new pb::MessageParser<ListPaymentsAccountsResponse>(() => new ListPaymentsAccountsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ListPaymentsAccountsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Services.PaymentsAccountServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListPaymentsAccountsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListPaymentsAccountsResponse(ListPaymentsAccountsResponse other) : this() {
      paymentsAccounts_ = other.paymentsAccounts_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListPaymentsAccountsResponse Clone() {
      return new ListPaymentsAccountsResponse(this);
    }

    /// <summary>Field number for the "payments_accounts" field.</summary>
    public const int PaymentsAccountsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V0.Resources.PaymentsAccount> _repeated_paymentsAccounts_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Ads.GoogleAds.V0.Resources.PaymentsAccount.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V0.Resources.PaymentsAccount> paymentsAccounts_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V0.Resources.PaymentsAccount>();
    /// <summary>
    /// The list of accessible Payments accounts.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V0.Resources.PaymentsAccount> PaymentsAccounts {
      get { return paymentsAccounts_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ListPaymentsAccountsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ListPaymentsAccountsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!paymentsAccounts_.Equals(other.paymentsAccounts_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= paymentsAccounts_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      paymentsAccounts_.WriteTo(output, _repeated_paymentsAccounts_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += paymentsAccounts_.CalculateSize(_repeated_paymentsAccounts_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ListPaymentsAccountsResponse other) {
      if (other == null) {
        return;
      }
      paymentsAccounts_.Add(other.paymentsAccounts_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            paymentsAccounts_.AddEntriesFrom(input, _repeated_paymentsAccounts_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code