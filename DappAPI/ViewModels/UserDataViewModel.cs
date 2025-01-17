﻿using System;

namespace DappAPI.ViewModels
{
    public class UserDataViewModel
    {
        public string Id { get; set; }
        public string PublicAddress { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Role { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { set; get; }
    }
}
