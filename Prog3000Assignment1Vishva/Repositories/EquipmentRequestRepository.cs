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

    public List<EquipmentRequest> GetAll()
    {
        return Requests;
    }

    public void Accept(int id)
    {
        var request = Requests.FirstOrDefault(item => item.Id == id);
        if (request != null)
        {
            request.Status = "Accepted";
        }
    }

    public void Deny(int id)
    {
        var request = Requests.FirstOrDefault(item => item.Id == id);
        if (request != null)
        {
            request.Status = "Denied";
        }
    }
}
