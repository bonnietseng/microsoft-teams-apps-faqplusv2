// <copyright file="HelpTabViewModel.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
namespace Microsoft.Teams.Apps.FAQPlusPlus.Configuration.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Represents HelpTabViewModel object that hold help tab text.
    /// </summary>
    public class HelpTabViewModel
    {
        /// <summary>
        /// Gets or sets help tab message text box to be used in View
        /// </summary>
        [Required(ErrorMessage = "輸入幫助標籤文字。")]
        [StringLength(maximumLength: 3000, ErrorMessage = "幫助標籤文字應少於3000個字符。", MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "幫助標籤文字")]
        public string HelpTabText { get; set; }
    }
}