using System;

namespace GatewayPagamento.Dominio.Entidades
{
    public class Cartao
    {
        public int Id { get; set; }
        public Guid Guid { get; set; } = Guid.NewGuid(); 
        public string Numero { get; set;}
        public Decimal Limite { get; set;}
    }
}
