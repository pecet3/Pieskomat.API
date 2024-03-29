﻿using Microsoft.AspNetCore.Identity;

namespace Pieskomat.API.Entities;

public class Pet
{
    public int Id { get; set; }

    public required string Name { get; set; }

    public int OwnerId { get; set; }

    public IdentityUser? Owner { get; set; }
}
