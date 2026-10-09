using Prog3000Assignment1Vishva.Models;

namespace Prog3000Assignment1Vishva.Repositories;

public class EquipmentRequestRepository
{
    private static int _nextId = 1;
    private static readonly List<EquipmentRequest> Requests = [];

    public void Add(EquipmentRequest request)
    {
        request.Id = _nextId++;
        Requests.Add(request);
    }
}
