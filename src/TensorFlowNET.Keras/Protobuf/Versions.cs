// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: tensorflow/python/keras/protobuf/versions.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ThirdParty.Tensorflow.Python.Keras.Protobuf {

  /// <summary>Holder for reflection information generated from tensorflow/python/keras/protobuf/versions.proto</summary>
  public static partial class VersionsReflection {

    #region Descriptor
    /// <summary>File descriptor for tensorflow/python/keras/protobuf/versions.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VersionsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci90ZW5zb3JmbG93L3B5dGhvbi9rZXJhcy9wcm90b2J1Zi92ZXJzaW9ucy5w",
            "cm90bxIsdGhpcmRfcGFydHkudGVuc29yZmxvdy5weXRob24ua2VyYXMucHJv",
            "dG9idWYiSwoKVmVyc2lvbkRlZhIQCghwcm9kdWNlchgBIAEoBRIUCgxtaW5f",
            "Y29uc3VtZXIYAiABKAUSFQoNYmFkX2NvbnN1bWVycxgDIAMoBWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ThirdParty.Tensorflow.Python.Keras.Protobuf.VersionDef), global::ThirdParty.Tensorflow.Python.Keras.Protobuf.VersionDef.Parser, new[]{ "Producer", "MinConsumer", "BadConsumers" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Version information for a piece of serialized data
  ///
  /// There are different types of versions for each type of data
  /// (GraphDef, etc.), but they all have the same common shape
  /// described here.
  ///
  /// Each consumer has "consumer" and "min_producer" versions (specified
  /// elsewhere).  A consumer is allowed to consume this data if
  ///
  ///   producer >= min_producer
  ///   consumer >= min_consumer
  ///   consumer not in bad_consumers
  ///
  /// LINT.IfChange
  /// </summary>
  public sealed partial class VersionDef : pb::IMessage<VersionDef> {
    private static readonly pb::MessageParser<VersionDef> _parser = new pb::MessageParser<VersionDef>(() => new VersionDef());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<VersionDef> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ThirdParty.Tensorflow.Python.Keras.Protobuf.VersionsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VersionDef() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VersionDef(VersionDef other) : this() {
      producer_ = other.producer_;
      minConsumer_ = other.minConsumer_;
      badConsumers_ = other.badConsumers_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VersionDef Clone() {
      return new VersionDef(this);
    }

    /// <summary>Field number for the "producer" field.</summary>
    public const int ProducerFieldNumber = 1;
    private int producer_;
    /// <summary>
    /// The version of the code that produced this data.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Producer {
      get { return producer_; }
      set {
        producer_ = value;
      }
    }

    /// <summary>Field number for the "min_consumer" field.</summary>
    public const int MinConsumerFieldNumber = 2;
    private int minConsumer_;
    /// <summary>
    /// Any consumer below this version is not allowed to consume this data.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MinConsumer {
      get { return minConsumer_; }
      set {
        minConsumer_ = value;
      }
    }

    /// <summary>Field number for the "bad_consumers" field.</summary>
    public const int BadConsumersFieldNumber = 3;
    private static readonly pb::FieldCodec<int> _repeated_badConsumers_codec
        = pb::FieldCodec.ForInt32(26);
    private readonly pbc::RepeatedField<int> badConsumers_ = new pbc::RepeatedField<int>();
    /// <summary>
    /// Specific consumer versions which are disallowed (e.g. due to bugs).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> BadConsumers {
      get { return badConsumers_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as VersionDef);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(VersionDef other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Producer != other.Producer) return false;
      if (MinConsumer != other.MinConsumer) return false;
      if(!badConsumers_.Equals(other.badConsumers_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Producer != 0) hash ^= Producer.GetHashCode();
      if (MinConsumer != 0) hash ^= MinConsumer.GetHashCode();
      hash ^= badConsumers_.GetHashCode();
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
      if (Producer != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Producer);
      }
      if (MinConsumer != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(MinConsumer);
      }
      badConsumers_.WriteTo(output, _repeated_badConsumers_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Producer != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Producer);
      }
      if (MinConsumer != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MinConsumer);
      }
      size += badConsumers_.CalculateSize(_repeated_badConsumers_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(VersionDef other) {
      if (other == null) {
        return;
      }
      if (other.Producer != 0) {
        Producer = other.Producer;
      }
      if (other.MinConsumer != 0) {
        MinConsumer = other.MinConsumer;
      }
      badConsumers_.Add(other.badConsumers_);
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
          case 8: {
            Producer = input.ReadInt32();
            break;
          }
          case 16: {
            MinConsumer = input.ReadInt32();
            break;
          }
          case 26:
          case 24: {
            badConsumers_.AddEntriesFrom(input, _repeated_badConsumers_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code