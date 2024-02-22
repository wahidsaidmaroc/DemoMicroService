using Service.Dtos;

namespace Service.Interfaces;

public interface IProduitService
{
    Task<ProduitGetDTO> FindAsync(int id);
    Task<IEnumerable<ProduitGetDTO>> FindAllAsync();
    Task<ProduitGetDTO> CreateAsync(ProduitPostDTO produitPostDTO);
    Task<ProduitGetDTO> UpdateAsync(ProduitPutDTO produitPutDTO);
    Task<bool> DeleteAsync(int id);
}
