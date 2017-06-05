﻿using GoogleCloudPrintApi.Attributes;
using GoogleCloudPrintApi.Infrastructures;

namespace GoogleCloudPrintApi.Models.Printer
{
    public class DeleteRequest : IRequest
    {
        /// <summary>
        /// Unique printer identification (generated by Google Cloud Print). (required)
        /// </summary>
        [Form(isRequiredFor: VersionOption.All)]
        public string PrinterId { get; set; }
    }
}