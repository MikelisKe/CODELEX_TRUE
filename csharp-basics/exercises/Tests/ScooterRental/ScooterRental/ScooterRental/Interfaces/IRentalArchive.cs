namespace ScooterRental.Interfaces;

public interface IRentalArchive
{
    void AddRent(string id, decimal pricePerMinute, DateTime rentStart);

}
