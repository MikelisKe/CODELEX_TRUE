using System.Runtime.CompilerServices;
using FluentAssertions;
using ScooterRental.Exceptions;
using ScooterRental.Interfaces;

namespace ScooterRental.test
{
    public class ScooterServiceTest
    {
        private IScooterService _scooterService;
        private List<Scooter> _scooters;

        [SetUp]
        public void Setup()
        {
            _scooters = new List<Scooter>();
            _scooterService = new ScooterService(_scooters);
        }

        [Test]
        public void AddScooter_AddValidScooter_ScooterAdded()
        {
            _scooterService.AddScooter("1", 1m);
            _scooters.Count.Should().Be(1);
        }

        [Test]
        public void AddScooter_AddScooterWithoutID_ThrowsScooterIdThrowException()
        {
            Action act = () => _scooterService.AddScooter("", 1m);
            act.Should().Throw<ScooterIdThrowException>();
        }

        [Test]
        public void AddScooter_AddScooterWithoutAnyID_ThrowsScooterIdThrowException()
        {
            Action act = () => _scooterService.AddScooter(null, 1m);
            act.Should().Throw<ScooterIdThrowException>();
        }


        [Test]
        public void AddScooter_AddScooterWithNegativePrice_ThrowsinvalidPricePerMinuteException()
        {
            Action act = () => _scooterService.AddScooter("1", -14m);
            act.Should().Throw<invalidPricePerMinuteException>();
        }


        [Test]
        public void RemoveScooter_ValidInfoProvided_ScooterGetsRemoved_()
        {
            _scooters.Add(new Scooter("1",0.1m));
            
            _scooterService.RemoveScooter("1");

            _scooters.Any(x => x.Id == "1").Should().BeFalse();
        }

        [Test]
        public void RemoveScooter_NullIDProvided_ThrowScooterIdThrowException()
        {
            Action act = () => _scooterService.RemoveScooter(null);

            act.Should().Throw<ScooterIdThrowException>();
        }

        [Test]
        public void RemoveScooter_EmptyIDProvided_ThrowScooterIdThrowException()
        {
            Action act = () => _scooterService.RemoveScooter("");

            act.Should().Throw<ScooterIdThrowException>();
        }

        [Test]
        public void RemoveScooter_WrongIDProvided_ThrowScooterNotFoundException()
        {
            Action act = () => _scooterService.RemoveScooter("2");

            act.Should().Throw<ScooterNotFoundException>();
        }

        [Test]
        public void GetScooter_ReturnsAllScooters()
        {
            _scooters.Add(new Scooter("1", 0.1m));

            var scooters = _scooterService.GetScooters();
            scooters.Count.Should().Be(1);
        }

        [Test]
        public void GetScooterById_ReturnsValidScooter_ReturnsScooterSelectedById()
        {
            var scooter = new Scooter("1", 1m);

            _scooters.Add(scooter);

            _scooterService.GetScooterById(scooter.Id).Should().Be(scooter);
        }

        [Test]
        public void GetScooterById_NullIDProvided_ThrowScooterIdThrowException()
        {
            Action act = () => _scooterService.GetScooterById(null);

            act.Should().Throw<ScooterIdThrowException>();
        }

        [Test]
        public void GetScooterById_EmptyIDProvided_ThrowScooterIdThrowException()
        {
            Action act = () => _scooterService.GetScooterById("");

            act.Should().Throw<ScooterIdThrowException>();
        }

        [Test]
        public void GetScooterById_WrongIDProvided_ThrowScooterNotFoundException()
        {
            Action act = () => _scooterService.GetScooterById("2");

            act.Should().Throw<ScooterNotFoundException>();
        }





    }
}