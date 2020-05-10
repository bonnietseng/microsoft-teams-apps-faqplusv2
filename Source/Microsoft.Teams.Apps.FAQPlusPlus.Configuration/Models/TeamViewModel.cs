// <copyright file="TeamViewModel.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.Apps.FAQPlusPlus.Configuration.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Represents TeamViewModel object to store team details.
    /// </summary>
    public class TeamViewModel
    {
        /// <summary>
        /// Gets or sets team id textbox to be used in View.
        /// </summary>
        [Required(ErrorMessage = "輸入團隊ID。")]
        [MinLength(1)]
        [DataType(DataType.Text)]
        [Display(Name = "團隊編號")]
        [RegularExpression(@"(\S)+", ErrorMessage = "輸入不應包含任何空格的團隊ID。")]
        public string TeamId { get; set; }
    }
}