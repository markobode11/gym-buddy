﻿using Contracts.Domain.Base;
using Microsoft.AspNetCore.Identity;

namespace Domain.App.Identity
{
    public class AppRole : IdentityRole<int>, IDomainEntityId
    {
    }
}