﻿using AutoMapper;
using Pattern.Application.Services.Base;
using Pattern.Persistence.UnitOfWork;

namespace Pattern.Application.Services.Roles
{
    public class RoleService : BaseService
    {
        public RoleService(IUnitOfWork unitOfWork, IMapper objectMapper) : base(unitOfWork, objectMapper)
        {
        }
    }
}
