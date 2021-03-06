using System;
using System.ComponentModel;

namespace Marten
{
    /// <summary>
    /// Diagnostic access to all the source code generated by Marten
    /// for a given document type
    /// </summary>
    public interface IDocumentSourceCode
    {
        string AllSourceCode();

        /// <summary>
        /// IDocumentStorage code used within QuerySession
        /// </summary>
        [Description("Storage Code for QuerySession")]
        string QueryOnlyStorageCode { get; }

        /// <summary>
        /// IDocumentStorage code used within LightweightSession
        /// </summary>
        [Description("Storage Code for LightweightSession")]
        string LightweightStorageCode { get; }

        /// <summary>
        /// IDocumentStorage code used within IdentityMapSession
        /// </summary>
        [Description("Storage Code for IdentityMapSession")]
        string IdentityMapStorageCode { get; }

        /// <summary>
        /// IDocumentStorage code used within DirtyTrackingSession
        /// </summary>
        [Description("Storage Code for DirtyTrackingSession")]
        string DirtyTrackingStorageCode { get; }

        /// <summary>
        /// Bulk loading code
        /// </summary>
        [Description("Bulk Loading Code")]
        string BulkLoaderCode { get; }

        /// <summary>
        /// Code that "upserts" a single document
        /// </summary>
        string UpsertOperationCode { get; }

        /// <summary>
        /// Code that updates a single document
        /// </summary>
        string UpdateOperationCode { get; }

        /// <summary>
        /// Code that inserts a single document
        /// </summary>
        string InsertOperationCode { get; }

        /// <summary>
        /// Code for loading the document type within QuerySession
        /// </summary>
        string QueryOnlySelectorCode { get; }

        /// <summary>
        /// Code for loading the document type within LightweightSession
        /// </summary>
        string LightweightSelectorCode { get; }

        /// <summary>
        /// Code for loading the document type within IdentityMapSession
        /// </summary>
        string IdentityMapSelectorCode { get; }

        /// <summary>
        /// Code for loading the document type within DirtyCheckingSession
        /// </summary>
        string DirtyCheckingSelectorCode { get; }
    }


}
