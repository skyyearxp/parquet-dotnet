#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * Autogenerated by Thrift Compiler (0.10.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */

namespace Parquet.Thrift
{
  /// <summary>
  /// Representation of Schemas
  /// </summary>
  public enum FieldRepetitionType
  {
    /// <summary>
    /// This field is required (can not be null) and each record has exactly 1 value.
    /// </summary>
    REQUIRED = 0,
    /// <summary>
    /// The field is optional (can be null) and each record has 0 or 1 values.
    /// </summary>
    OPTIONAL = 1,
    /// <summary>
    /// The field is repeated and can contain 0 or more values
    /// </summary>
    REPEATED = 2,
  }
}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member