using Microsoft.AspNetCore.Mvc;

namespace API.Dtos
{
    public class CommandeDtos
    {
        [FromHeader]
        public Guid Id { get; set; }
        [FromBody]
        public DateTime DateCommande { get; set; }

        public string NomClient { get; set; } = string.Empty;
    }
}
