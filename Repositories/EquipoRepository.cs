using MolinaM_LigaPro.Interfaces;
using MolinaM_LigaPro.Models;

namespace MolinaM_LigaPro.Repositories
{
    public class EquipoRepository : IEquipoRepository
    {
        public bool ActualizarEquipo()
        {
            throw new NotImplementedException();
        }

        public bool CrearEquipo()
        {
            throw new NotImplementedException();
        }

        public Equipo DevuelveInfoEquipo(int Id)
        {
            var equipos = DevuelveListadoEquipos();
            var equipo = equipos.Where(item => item.Id == Id).First();
            return equipo;
        }

        public List<Equipo> DevuelveListadoEquipos()
        {
            List<Equipo> equipos = new List<Equipo>();
            Equipo aucas = new Equipo
            {
                Id = 1,
                Nombre = "Aucas",
                PartidosJugados = 10,
                PartidosGanados = 7,
                PartidosEmpatados = 2,
                PartidosPerdidos = 1,
            };
            equipos.Add(aucas);


            Equipo liga = new Equipo
            {
                Id = 1,
                Nombre = "Liga",
                PartidosJugados = 10,
                PartidosGanados = 5,
                PartidosEmpatados = 2,
                PartidosPerdidos = 3,
            };
            equipos.Add(liga);
            return equipos;
        }

        public bool EliminarEquipo()
        {
            throw new NotImplementedException();
        }
    }
}
