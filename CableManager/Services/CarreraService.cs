using CableManager.Models;
using CableManager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CableManager.Services
{
    public class CarreraService
    {
        private readonly CableManagerDbContext _db;

        public CarreraService(CableManagerDbContext db)
        {
            _db = db;
        }

        public List<Carrera> GetAllCarreras()
        {
            return _db.Carreras.ToList();
        }

        public List<Carrera> GetCarrerasByCableId(int cableId)
        {
            return _db.Carreras.Where(c => c.CableId == cableId).ToList();
        }

        public Carrera GetCarreraById(int carreraId)
        {
            return _db.Carreras.Find(carreraId);
        }

        public void CreateCarrera(Carrera carrera)
        {
            _db.Carreras.Add(carrera);
        }

        public void UpdateCarrera()
        {
            // No implementation required
        }

        public void DeleteCarrera(int carreraId)
        {
            var carreraToDelete = _db.Carreras.Find(carreraId);

            _db.Carreras.Remove(carreraToDelete);
        }

        public bool SaveChanges()
        {
            return _db.SaveChanges() > 0;
        }
    }
}
