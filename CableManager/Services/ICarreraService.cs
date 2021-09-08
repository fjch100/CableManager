﻿using CableManager.Models;
using System.Collections.Generic;

namespace CableManager.Services
{
    public interface ICarreraService
    {
        void CreateCarrera(Carrera carrera);
        void DeleteCarrera(int carreraId);
        List<Carrera> GetAllCarreras();
        Carrera GetCarreraById(int carreraId);
        List<Carrera> GetCarrerasByCableId(int cableId);
        bool SaveChanges();
        void UpdateCarrera();
    }
}