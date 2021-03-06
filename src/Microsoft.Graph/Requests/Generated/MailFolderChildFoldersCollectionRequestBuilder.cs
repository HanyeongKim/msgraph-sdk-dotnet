// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type MailFolderChildFoldersCollectionRequestBuilder.
    /// </summary>
    public partial class MailFolderChildFoldersCollectionRequestBuilder : BaseRequestBuilder, IMailFolderChildFoldersCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new MailFolderChildFoldersCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public MailFolderChildFoldersCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IMailFolderChildFoldersCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IMailFolderChildFoldersCollectionRequest Request(IEnumerable<Option> options)
        {
            return new MailFolderChildFoldersCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IMailFolderRequestBuilder"/> for the specified MailFolderMailFolder.
        /// </summary>
        /// <param name="id">The ID for the MailFolderMailFolder.</param>
        /// <returns>The <see cref="IMailFolderRequestBuilder"/>.</returns>
        public IMailFolderRequestBuilder this[string id]
        {
            get
            {
                return new MailFolderRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for MailFolderDelta.
        /// </summary>
        /// <returns>The <see cref="IMailFolderDeltaRequestBuilder"/>.</returns>
        public IMailFolderDeltaRequestBuilder Delta()
        {
            return new MailFolderDeltaRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.delta"),
                this.Client);
        }
    }
}
