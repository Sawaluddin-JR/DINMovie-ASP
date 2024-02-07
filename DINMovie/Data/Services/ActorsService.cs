﻿using DINMovie.Data.Base;
using DINMovie.Models;
using Microsoft.AspNetCore.Cors.Infrastructure;

namespace DINMovie.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) { }
    }
}
