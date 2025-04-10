using MolinaM_LigaPro.Models;

namespace MolinaM_LigaPro.Interfaces
{
    public interface IEquipoRepository
    {
        List<Equipo> DevuelveListadoEquipos();
        Equipo DevuelveInfoEquipo(int Id);
        bool CrearEquipo();
        bool ActualizarEquipo();
        bool EliminarEquipo();
    }
}
