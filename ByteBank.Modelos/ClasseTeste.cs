using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    class ClasseTeste
    {
        public ClasseTeste()
        {
            ModificadoresTeste teste = new ModificadoresTeste();

            teste.MetodoPublico();
            teste.MetodoInterno(); 
        }
    }

    class ClasseDerivada : ModificadoresTeste
    {
        public ClasseDerivada()
        {
            MetodoProtected();
            MetodoInterno();
        }
    }


    public class ModificadoresTeste
    {
        public void MetodoPublico()
        {
            // visível fora da classe "ModificadoresTeste"
        }
        private void MetodoPrivado()
        {
            // visível apenas na classe "ModificadoresTeste"
        }
        protected void MetodoProtected()
        {
            // visível na classe "ModificadoresTeste" e nas suas classes derivadas
        }

        internal void MetodoInterno()
        {
            //visível nas classes que fazem parte do projeto ByteBank.Modelos
        }
    }
}
