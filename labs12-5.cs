public class VehicleComparer : IComparer<TransportVehicle>
{
    public int Compare(TransportVehicle x, TransportVehicle y)
    {
        return x.Name.CompareTo(y.Name); // Сравниваем по имени
    }
}
