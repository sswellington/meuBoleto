using Application.Entities;

namespace Application.Interfaces.Repositories;
public interface IBoletoRepository
{
	Task<BoletoEntity> GetById(int id);
}
