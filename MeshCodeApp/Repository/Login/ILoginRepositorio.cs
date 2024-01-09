﻿using MeshCodeApp.Models.Request;
using MeshCodeApp.Models.Response;

namespace MeshCodeApp.Repository.Login
{
    public interface ILoginRepositorio
    {
        Task<LoginResponse> LoginAsync(LoginRequest loginRequest);
    }
}
