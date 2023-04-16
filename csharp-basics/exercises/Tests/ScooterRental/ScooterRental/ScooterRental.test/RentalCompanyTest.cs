using FluentAssertions;
using Moq.AutoMock;
using ScooterRental.Interfaces;
using ScooterRental.Scooter;

namespace ScooterRental.test;

public class RentalCompanyTest
{
    private AutoMocker _mocker;
    private IRentalCompany _company;
    private const string CompanyName = "test";
    private Scooter.Scooter scooter = new Scooter.Scooter("1", 0.00m);

    [SetUp]
    public void Setup()
    {
        _mocker = new AutoMocker();
        _company = new RentalCompany(CompanyName, _mocker.GetMock<IScooterService>().Object);
    }

    [Test]
    public void StartRent_ScooterIsRented_ReturnsTrue()
    {
        _mocker.GetMock<IScooterService>().Setup(b => b.GetScooterById("1")).Returns(scooter);

        _company.StartRent("1");
        scooter.IsRented.Should().BeTrue();
    }

    [Test]
    public void StartRent_ScooterRentHasEnded_ReturnsFalse()
    {
        scooter.IsRented = true;
        _mocker.GetMock<IScooterService>().Setup(b => b.GetScooterById("1")).Returns(scooter);

        _company.EndRent("1");
        scooter.IsRented.Should().BeFalse();
    }




}