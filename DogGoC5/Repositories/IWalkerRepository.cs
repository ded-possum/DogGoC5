﻿using DogGoC5.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace DogGoC5.Repositories
{
    public interface IWalkerRepository
    {
        List<Walker> GetAllWalkers();
        Walker GetWalkerById(int id);
    }
}