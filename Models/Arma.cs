using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using RpgApi.Models;
using RpgApi.Models.Enuns;

namespace RpgAPI.Models
{
    public class Arma
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public int Dano {get; set;}
        public Personagem Personagem { get; set; } = null!;
        public int PersonagemId { get; set; }
        
    }
}