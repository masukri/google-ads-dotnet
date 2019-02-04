// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/errors/keyword_plan_campaign_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/errors/keyword_plan_campaign_error.proto</summary>
  public static partial class KeywordPlanCampaignErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/errors/keyword_plan_campaign_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KeywordPlanCampaignErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkBnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lcnJvcnMva2V5d29yZF9wbGFu",
            "X2NhbXBhaWduX2Vycm9yLnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFkcy52",
            "MC5lcnJvcnMivwEKHEtleXdvcmRQbGFuQ2FtcGFpZ25FcnJvckVudW0ingEK",
            "GEtleXdvcmRQbGFuQ2FtcGFpZ25FcnJvchIPCgtVTlNQRUNJRklFRBAAEgsK",
            "B1VOS05PV04QARIQCgxJTlZBTElEX05BTUUQAhIVChFJTlZBTElEX0xBTkdV",
            "QUdFUxADEhAKDElOVkFMSURfR0VPUxAEEhIKDkRVUExJQ0FURV9OQU1FEAUS",
            "FQoRTUFYX0dFT1NfRVhDRUVERUQQBkL4AQoiY29tLmdvb2dsZS5hZHMuZ29v",
            "Z2xlYWRzLnYwLmVycm9yc0IdS2V5d29yZFBsYW5DYW1wYWlnbkVycm9yUHJv",
            "dG9QAVpEZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9h",
            "ZHMvZ29vZ2xlYWRzL3YwL2Vycm9ycztlcnJvcnOiAgNHQUGqAh5Hb29nbGUu",
            "QWRzLkdvb2dsZUFkcy5WMC5FcnJvcnPKAh5Hb29nbGVcQWRzXEdvb2dsZUFk",
            "c1xWMFxFcnJvcnPqAiJHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMDo6RXJy",
            "b3JzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Errors.KeywordPlanCampaignErrorEnum), global::Google.Ads.GoogleAds.V0.Errors.KeywordPlanCampaignErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Errors.KeywordPlanCampaignErrorEnum.Types.KeywordPlanCampaignError) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible errors from applying a keyword plan
  /// campaign.
  /// </summary>
  public sealed partial class KeywordPlanCampaignErrorEnum : pb::IMessage<KeywordPlanCampaignErrorEnum> {
    private static readonly pb::MessageParser<KeywordPlanCampaignErrorEnum> _parser = new pb::MessageParser<KeywordPlanCampaignErrorEnum>(() => new KeywordPlanCampaignErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<KeywordPlanCampaignErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Errors.KeywordPlanCampaignErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeywordPlanCampaignErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeywordPlanCampaignErrorEnum(KeywordPlanCampaignErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeywordPlanCampaignErrorEnum Clone() {
      return new KeywordPlanCampaignErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as KeywordPlanCampaignErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(KeywordPlanCampaignErrorEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(KeywordPlanCampaignErrorEnum other) {
      if (other == null) {
        return;
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
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the KeywordPlanCampaignErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible errors from applying a keyword plan campaign.
      /// </summary>
      public enum KeywordPlanCampaignError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// A keyword plan campaign name is missing, empty, longer than allowed limit
        /// or contains invalid chars.
        /// </summary>
        [pbr::OriginalName("INVALID_NAME")] InvalidName = 2,
        /// <summary>
        /// A keyword plan campaign contains one or more untargetable languages.
        /// </summary>
        [pbr::OriginalName("INVALID_LANGUAGES")] InvalidLanguages = 3,
        /// <summary>
        /// A keyword plan campaign contains one or more invalid geo targets.
        /// </summary>
        [pbr::OriginalName("INVALID_GEOS")] InvalidGeos = 4,
        /// <summary>
        /// The keyword plan campaign name is duplicate to an existing keyword plan
        /// campaign name or other keyword plan campaign name in the request.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_NAME")] DuplicateName = 5,
        /// <summary>
        /// The number of geo targets in the keyword plan campaign exceeds limits.
        /// </summary>
        [pbr::OriginalName("MAX_GEOS_EXCEEDED")] MaxGeosExceeded = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code