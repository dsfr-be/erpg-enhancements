// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Tester.Integration.EFCore6.Single_context_many_files
{
    // Issue
    public class OneEightSix_Issue
    {
        public int Id { get; set; } // Id (Primary key)
        public string Title { get; set; } // Title (length: 100)
        public string Content { get; set; } // Content
        public int? ConsentDocumentId { get; set; } // ConsentDocumentId

        // Reverse navigation

        /// <summary>
        /// Child OneEightSix_IssueUploadedFiles where [IssueUploadedFile].[IssueId] point to this entity (FK_IssueUploadedFile_Issue)
        /// </summary>
        public virtual ICollection<OneEightSix_IssueUploadedFile> OneEightSix_IssueUploadedFiles { get; set; } // IssueUploadedFile.FK_IssueUploadedFile_Issue

        // Foreign keys

        /// <summary>
        /// Parent OneEightSix_UploadedFile pointed by [Issue].([ConsentDocumentId]) (FK_Issue_UploadedFileConsentDocument)
        /// </summary>
        public virtual OneEightSix_UploadedFile OneEightSix_UploadedFile { get; set; } // FK_Issue_UploadedFileConsentDocument

        public OneEightSix_Issue()
        {
            OneEightSix_IssueUploadedFiles = new List<OneEightSix_IssueUploadedFile>();
        }
    }

}
// </auto-generated>