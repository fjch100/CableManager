using AutoFixture;
using CableManager.Business.Data;
using CableManager.Business.Models;
using CableManager.Business.Services;
using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Xunit;

namespace CableManager.Business.Test
{
    public class CableServiceTests
    {
        [Fact]
        public void UpdateCableInfoAfterCarreraDeletion_Updates_LongActual_NumCarreras_After_Carrera_Is_Deleted()
        {
            // Arrange
            var fixture = new Fixture();
            var rand = new Random();

            var carreraDeleted = new Carrera()
            {
                Long_previa = 5,
                Num_carreras = 2
            };

            var initialLong = rand.Next(10, 50);
            var initialCarreras = rand.Next(10, 50);

            var expectedLong = carreraDeleted.Long_previa;
            var expectedCarreras = initialCarreras - carreraDeleted.Num_carreras;

            var cableToUpdate = fixture.Build<Cable>()
                .With(c => c.Long_actual, initialLong)
                .With(c => c.Carreras, initialCarreras)
                .Create();

            var data = new List<Cable>
            {
                cableToUpdate
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Cable>>();
            mockSet.As<IQueryable<Cable>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Cable>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Cable>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Cable>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());
            mockSet.Setup(m => m.Find(cableToUpdate.Id)).Returns(cableToUpdate);

            var mockContext = new Mock<CableManagerDbContext>();
            mockContext.Setup(m => m.Cables).Returns(mockSet.Object);

            var sut = new CableService(mockContext.Object);

            // Act
            sut.UpdateCableInfoAfterCarreraDeletion(cableToUpdate.Id, carreraDeleted);


            // Assert
            cableToUpdate.Carreras.Should().Be(expectedCarreras);
            cableToUpdate.Long_actual.Should().Be(expectedLong);
        }

        [Fact]
        public void UpdateCableInfoAfterCarreraCreation_Updates_LongActual_NumCarreras_After_Carrera_Is_Created()
        {
            // Arrange
            var fixture = new Fixture();
            var rand = new Random();

            var newCarrera = new Carrera()
            {
                Long_actual = 100,
                Num_carreras = 2
            };

            var initialLong = rand.Next(10, 50);
            var initialCarreras = rand.Next(10, 50);

            var expectedLong = newCarrera.Long_actual;
            var expectedCarreras = initialCarreras + newCarrera.Num_carreras;

            var cableToUpdate = fixture.Build<Cable>()
                .With(c => c.Long_actual, initialLong)
                .With(c => c.Carreras, initialCarreras)
                .Create();

            var data = new List<Cable>
            {
                cableToUpdate
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Cable>>();
            mockSet.As<IQueryable<Cable>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Cable>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Cable>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Cable>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());
            mockSet.Setup(m => m.Find(cableToUpdate.Id)).Returns(cableToUpdate);

            var mockContext = new Mock<CableManagerDbContext>();
            mockContext.Setup(m => m.Cables).Returns(mockSet.Object);

            var sut = new CableService(mockContext.Object);

            // Act
            sut.UpdateCableInfoAfterCarreraCreation(cableToUpdate.Id, newCarrera);


            // Assert
            cableToUpdate.Carreras.Should().Be(expectedCarreras);
            cableToUpdate.Long_actual.Should().Be(expectedLong);
        }


        [Fact]
        public void UpdateCableInfoAfterCarreraUpdate_Updates_LongActual_NumCarreras_After_Carrera_Is_Updated()
        {
            // Arrange
            var fixture = new Fixture();
            var rand = new Random();

            var updatedCarrera = new Carrera()
            {
                Long_actual = 100,
                Num_carreras = 2
            };

            var initialLong = rand.Next(10, 50);
            var initialCarreras = rand.Next(10, 50);

            var numCarrerasAnteriores = 4;

            var expectedLong = updatedCarrera.Long_actual;
            var expectedCarreras = initialCarreras + updatedCarrera.Num_carreras - numCarrerasAnteriores;

            var cableToUpdate = fixture.Build<Cable>()
                .With(c => c.Long_actual, initialLong)
                .With(c => c.Carreras, initialCarreras)
                .Create();

            var data = new List<Cable>
            {
                cableToUpdate
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Cable>>();
            mockSet.As<IQueryable<Cable>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Cable>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Cable>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Cable>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());
            mockSet.Setup(m => m.Find(cableToUpdate.Id)).Returns(cableToUpdate);

            var mockContext = new Mock<CableManagerDbContext>();
            mockContext.Setup(m => m.Cables).Returns(mockSet.Object);

            var sut = new CableService(mockContext.Object);

            // Act
            sut.UpdateCableInfoAfterCarreraUpdate(cableToUpdate.Id, updatedCarrera, numCarrerasAnteriores);


            // Assert
            cableToUpdate.Carreras.Should().Be(expectedCarreras);
            cableToUpdate.Long_actual.Should().Be(expectedLong);
        }
    }
}
