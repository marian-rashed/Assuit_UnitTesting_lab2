using CarAPI.Entities;
using CarFactoryAPI.Entities;
using CarFactoryAPI.Repositories_DAL;
using Moq;
using Moq.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryAPI_test
{
    public class OwnerRepositoryTests
    {
        private Mock<FactoryContext> factoryContextMock;
        private OwnerRepository ownerRepository;
        public OwnerRepositoryTests()
        {
            // Create Mock
            factoryContextMock = new Mock<FactoryContext>();


            // Use Object
            ownerRepository = new OwnerRepository(factoryContextMock.Object);
        }
        [Fact]
        [Trait("Author", "marian")]
        [Trait("Priority", "9")]

        public void GetCarById_AskForCar10_ReturnCar()
        {
            // arrange

            List<Owner> cars = new List<Owner>() { new Owner() { Id = 10 } };
            factoryContextMock.Setup(fcm => fcm.Owners).ReturnsDbSet(cars);

            // act 
            Owner owner = ownerRepository.GetOwnerById(10);

            // assert

            Assert.NotNull(owner);
        }
    }
}
