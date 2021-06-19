﻿using DappAPI.Extensions.Enums;

namespace DappAPI.ViewModels
{
    public class CapitalGetRequestViewModel
    {
        public string Keyword { get; set; }
        public AssetType Asset { get; set; }
        public CapitalType Type { get; set; }
        public CapitalStatus Status { get; set; }
        public double ValueMin { get; set; }
        public double ValueMax { get; set; }
        public string CreatorPublicAddress { get; set; }
        public string ApproverPublicAddress { get; set; }
    }
}
