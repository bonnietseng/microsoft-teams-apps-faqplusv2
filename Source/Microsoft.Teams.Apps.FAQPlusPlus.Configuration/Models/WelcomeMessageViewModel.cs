// <copyright file="WelcomeMessageViewModel.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
namespace Microsoft.Teams.Apps.FAQPlusPlus.Configuration.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Represents WelcomeMessageViewModel object that hold welcome message text.
    /// </summary>
    public class WelcomeMessageViewModel
    {
        /// <summary>
        /// Gets or sets welcome message text box to be used in View.
        /// </summary>
        [Required(ErrorMessage = "輸入歡迎消息。")]
        [StringLength(maximumLength: 300, ErrorMessage = "輸入歡迎消息，該消息應少於300個字符。", MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "歡迎留言")]
        public string WelcomeMessage { get; set; }
    }
}