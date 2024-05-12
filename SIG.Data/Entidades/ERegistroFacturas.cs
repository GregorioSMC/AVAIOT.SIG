using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIG.Data.Entidades
{
    public class ERegistroFacturas
    {
        public int Id { get; set; }
        public string UUID { get; set; } =string.Empty;
        public string Anotaciones {  get; set; } = string.Empty;
    }
}
