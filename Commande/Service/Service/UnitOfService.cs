using AutoMapper;
using Infrastructure.UnitOfWork;
using Service.Interfaces;

namespace Service.Service;

public class UnitOfService : IUnitOfService
{
    private readonly IUnitOfWork _uow;
    private readonly IMapper _map;
    public IProduitService ProduitService { get; private set; }
    


    public UnitOfService(IUnitOfWork uow, IMapper map)
    {
        _uow = uow;
        _map = map;

        ProduitService = new ProduitService(_uow, _map);
    }
}