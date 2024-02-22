using FluentValidation;

namespace Service.Features.Produit.Commands
{
    public  class ProduitCreateCmdValidator : AbstractValidator<ProduitCreateCmd>
    {
        public ProduitCreateCmdValidator()
        {
            RuleFor(a => a.Prix).NotNull().NotEmpty().WithMessage("Valeur Null ou Vide Champ Prix");
            RuleFor(a => a.Description).MinimumLength(10).WithMessage("Valeur Null ou Vide Champ description");
            RuleFor(a => a.Nom).NotEmpty().WithMessage("Valeur Null ou Vide Champ Nom");
        }
    }
}
