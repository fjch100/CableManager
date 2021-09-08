using CableManager.Models;
using System.Collections.Generic;

namespace CableManager.Services
{
    public interface ICableService
    {
        void CreateCable(Cable cable);
        void DeleteCable(int cableId);
        List<Cable> GetAllCables();
        Cable GetCableById(int cableId);
        bool SaveChanges();
        void UpdateCable();
        void UpdateCableInfoAfterCarreraCreation(int cableId, Carrera carrera);
        void UpdateCableInfoAfterCarreraDeletion(int cableId, Carrera carrera);
        void UpdateCableInfoAfterCarreraUpdate(int cableId, Carrera carrera, int numCarreraAnterior);
    }
}