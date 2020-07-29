using Enumeração_Teste.Entities.Enums;
using System;

namespace Enumeração_Teste.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id+", "+Moment+" "+Status; 
        }
    }
}
