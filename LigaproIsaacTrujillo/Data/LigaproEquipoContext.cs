using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LigaproIsaacTrujillo.Models;

    public class LigaproEquipoContext : DbContext
    {
        public LigaproEquipoContext (DbContextOptions<LigaproEquipoContext> options)
            : base(options)
        {
        }

        public DbSet<LigaproIsaacTrujillo.Models.Equipo> Equipo { get; set; } = default!;

public DbSet<LigaproIsaacTrujillo.Models.Estadio> Estadio { get; set; } = default!;

public DbSet<LigaproIsaacTrujillo.Models.Jugador> Jugador { get; set; } = default!;
    }
