using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users;
using baze;
using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;

namespace Managers
{
    public class Carros : Base
    {
        public Carros(string marca, string cor, string velocidade)
        {
            this.Marca = marca;
            this.Cor = cor;
            this.Velocidade = velocidade;
        }
        public Carros() { }
    }
}
