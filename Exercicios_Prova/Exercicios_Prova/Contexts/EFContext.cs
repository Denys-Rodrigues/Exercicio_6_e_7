using Exercicios_Prova.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Exercicios_Prova.Contexts
{
    public class EFContext : DbContext
    {
        public EFContext() : base("Loja") { }

        public DbSet<Cliente> Clientes { get; set; }
    }
}