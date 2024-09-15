using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorPC.Domain.Entities.Hardware
{
    public class Fabricante
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Site { get; private set; }
    }
}