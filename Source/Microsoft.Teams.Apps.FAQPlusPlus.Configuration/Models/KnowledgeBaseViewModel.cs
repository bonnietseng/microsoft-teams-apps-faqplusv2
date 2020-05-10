// <copyright file="KnowledgeBaseViewModel.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
namespace Microsoft.Teams.Apps.FAQPlusPlus.Configuration.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// KnowledgeBase View Model
    /// </summary>
    public class KnowledgeBaseViewModel
    {
        /// <summary>
        /// Gets or sets knowledge base id text box to be used in View.
        /// </summary>
        [Required(ErrorMessage = "輸入知識庫ID。")]
        [MinLength(1)]
        [DataType(DataType.Text)]
        [Display(Name = "知識庫ID")]
        [RegularExpression(@"(\S)+", ErrorMessage = "輸入不應包含任何空格的知識庫ID。")]
        public string KnowledgeBaseId { get; set; }
    }
}