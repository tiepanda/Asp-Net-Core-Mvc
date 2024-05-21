﻿using System;
using System.Collections.Generic;

namespace Bulky.Models;

public partial class AspNetUser
{
    public string Id { get; set; } = null!;

    public string? UserName { get; set; }

    public string? NormalizedUserName { get; set; }

    public string? Email { get; set; }

    public string? NormalizedEmail { get; set; }

    public bool EmailConfirmed { get; set; }

    public string? PasswordHash { get; set; }

    public string? SecurityStamp { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public string? PhoneNumber { get; set; }

    public bool PhoneNumberConfirmed { get; set; }

    public bool TwoFactorEnabled { get; set; }

    public DateTimeOffset? LockoutEnd { get; set; }

    public bool LockoutEnabled { get; set; }

    public int AccessFailedCount { get; set; }

    public string? City { get; set; }

    public string Discriminator { get; set; } = null!;

    public string? Name { get; set; }

    public string? PostalCode { get; set; }

    public string? State { get; set; }

    public string? StreetAddress { get; set; }

    public string? Country { get; set; }

    public string? LastName { get; set; }
}
