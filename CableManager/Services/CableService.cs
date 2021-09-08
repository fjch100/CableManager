using CableManager.Data;
using CableManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CableManager.Services
{
    public class CableService
    {
        private readonly CableManagerDbContext _db;

        public CableService(CableManagerDbContext db)
        {
            _db = db;
        }

        public List<Cable> GetAllCables()
        {
            return _db.Cables.ToList();
        }

        public Cable GetCableById(int cableId)
        {
            return _db.Cables.Find(cableId);
        }

        public void UpdateCableInfoAfterCarreraDeletion(int cableId, Carrera carrera)
        {
            var cableToUpdate = _db.Cables.Find(cableId);
            cableToUpdate.Long_actual = carrera.Long_previa;
            cableToUpdate.Carreras = cableToUpdate.Carreras - carrera.Num_carreras;
        }

        public void UpdateCableInfoAfterCarreraCreation(int cableId, Carrera carrera)
        {
            var cableToUpdate = _db.Cables.Find(cableId);

            cableToUpdate.Carreras += carrera.Num_carreras;
            cableToUpdate.Long_actual = carrera.Long_actual;
        }

        public void UpdateCableInfoAfterCarreraUpdate(int cableId, Carrera carrera, int numCarreraAnterior)
        {
            var cableToUpdate = _db.Cables.Find(cableId);
            cableToUpdate.Long_actual = carrera.Long_actual;
            cableToUpdate.Carreras += carrera.Num_carreras - numCarreraAnterior;
        }

        public void CreateCable(Cable cable)
        {
            _db.Cables.Add(cable);
        }

        public void UpdateCable() 
        {
            // No implementation required
        }

        public void DeleteCable(int cableId)
        {
            var cableToDelete = _db.Cables.Find(cableId);

            _db.Cables.Remove(cableToDelete);
        }

        public bool SaveChanges()
        {
            return _db.SaveChanges() > 0;
        }
    }
}
