using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRMTeste.Dados
{
    public class ConexaoBD
    {
        DBSRMAssetEntities db = new DBSRMAssetEntities();

        public List<Cliente> BuscarTodosCliente()
        {
            return db.Cliente.ToList();
        }

        public int CodigoClienteIncremental()
        {
            return db.Cliente.Max(x => x.Cod_Cliente) + 1;
        }

        public void AdicionarCliente(Cliente novoCliente)
        {
            db.Cliente.Add(novoCliente);
            db.SaveChanges();
        }

        public void AlterarCliente(Cliente cliente)
        {
            Cliente clienteAlterado = BuscarCliente(cliente.Cod_Cliente);
            clienteAlterado = cliente;
            db.SaveChanges();
        }

        public void ExcluirCliente(int CodigoCliente)
        {
            Cliente cliente = BuscarCliente(CodigoCliente);
            db.Cliente.Remove(cliente);
            db.SaveChanges();
        }

        public Cliente BuscarCliente(int codCliente)
        {
            return db.Cliente.First(x => x.Cod_Cliente == codCliente);
        }
    }
}
