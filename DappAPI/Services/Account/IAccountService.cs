﻿using DappAPI.Models;
using DappAPI.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DappAPI.Services.Account
{
    public interface IAccountService
    {
        public long GetNonce(string publicAddress);

        public Task<long> ChangeNonce(string publicAddress);

        public Task<List<string>> GetUserRoles(string publicAddress);

        public List<UserDataViewModel> GetAllUsersInfo();

        public UserDataViewModel GetUserInfo(string publicAddress);

        public Task<UserDataViewModel> CreateUser(RegisterViewModel model);

        public Task<UserDataViewModel> UpdateUser(UpdateAccountViewModel model);

        public Task<UserDataViewModel> Promote(string userId);

        public Task<UserDataViewModel> Demote(string userId);
    }
}