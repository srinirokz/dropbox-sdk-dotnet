// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Added a file/folder to their Dropbox from a shared link.</para>
    /// </summary>
    public class SharedLinkCopyDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SharedLinkCopyDetails> Encoder = new SharedLinkCopyDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SharedLinkCopyDetails> Decoder = new SharedLinkCopyDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharedLinkCopyDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="sharedLinkOwner">Shared link owner details. Might be missing due to
        /// historical data gap.</param>
        public SharedLinkCopyDetails(UserLogInfo sharedLinkOwner = null)
        {
            this.SharedLinkOwner = sharedLinkOwner;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharedLinkCopyDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public SharedLinkCopyDetails()
        {
        }

        /// <summary>
        /// <para>Shared link owner details. Might be missing due to historical data
        /// gap.</para>
        /// </summary>
        public UserLogInfo SharedLinkOwner { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SharedLinkCopyDetails" />.</para>
        /// </summary>
        private class SharedLinkCopyDetailsEncoder : enc.StructEncoder<SharedLinkCopyDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SharedLinkCopyDetails value, enc.IJsonWriter writer)
            {
                if (value.SharedLinkOwner != null)
                {
                    WriteProperty("shared_link_owner", value.SharedLinkOwner, writer, global::Dropbox.Api.TeamLog.UserLogInfo.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SharedLinkCopyDetails" />.</para>
        /// </summary>
        private class SharedLinkCopyDetailsDecoder : enc.StructDecoder<SharedLinkCopyDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SharedLinkCopyDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SharedLinkCopyDetails Create()
            {
                return new SharedLinkCopyDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SharedLinkCopyDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "shared_link_owner":
                        value.SharedLinkOwner = global::Dropbox.Api.TeamLog.UserLogInfo.Decoder.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
