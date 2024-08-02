using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalClub
{
    // Enum para los deportes disponibles
    public enum Deporte { Futbol5, Tenis, VoleyPlaya }

    // Clase base abstracta Persona
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string DNI { get; set; }
        public Deporte Deporte { get; set; }

        // Método para calcular la edad
        public int CalcularEdad()
        {
            var hoy = DateTime.Today;
            var edad = hoy.Year - FechaNacimiento.Year;
            if (FechaNacimiento.Date > hoy.AddYears(-edad)) edad--;
            return edad;
        }

        // Método abstracto para calcular la cuota
        public abstract decimal CalcularCuota();
    }

    // Clase Socio que hereda de Persona
    public class Socio : Persona
    {
        public Equipo Equipo { get; set; }

        // Implementación del método abstracto para calcular la cuota del socio
        public override decimal CalcularCuota()
        {
            return Deporte switch
            {
                Deporte.Futbol5 => 500,    // Cuota para Fútbol 5
                Deporte.Tenis => 800,      // Cuota para Tenis
                Deporte.VoleyPlaya => 600, // Cuota para Vóley Playa
                _ => 0
            };
        }
    }

    // Clase Entrenador que hereda de Persona
    public class Entrenador : Persona
    {
        // Implementación del método abstracto, los entrenadores no pagan cuota
        public override decimal CalcularCuota()
        {
            return 0;
        }
    }

    // Clase Equipo
    public class Equipo
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public Deporte Deporte { get; set; }
        public Entrenador Entrenador { get; set; }
        public List<Socio> Miembros { get; } = new List<Socio>();

        // Método para agregar un socio al equipo
        public void AgregarSocio(Socio socio)
        {
            int limiteMiembros = Deporte switch
            {
                Deporte.Futbol5 => 5,    // Límite para Fútbol 5
                Deporte.Tenis => 2,      // Límite para Tenis (considerando dobles)
                Deporte.VoleyPlaya => 3, // Límite para Vóley Playa
                _ => throw new ArgumentException("Deporte no válido")
            };

            if (Miembros.Count >= limiteMiembros)
                throw new InvalidOperationException("No se puede agregar más miembros a este equipo.");

            Miembros.Add(socio);
            socio.Equipo = this; // Asigna el equipo al socio
        }

        // Método para eliminar un socio del equipo
        public void EliminarSocio(Socio socio)
        {
            Miembros.Remove(socio);
            socio.Equipo = null; // Desvincula el socio del equipo
        }
    }

    // Clase Partido
    public class Partido
    {
        public Deporte Deporte { get; set; }
        public Equipo Equipo1 { get; set; }
        public Equipo Equipo2 { get; set; }
        public Equipo Ganador { get; set; } // Puede ser null en caso de empate
        public bool Empate { get; set; }

        // Método para registrar el resultado del partido
        public void RegistrarResultado(Equipo ganador, bool empate = false)
        {
            if (empate)
            {
                Empate = true;
                Ganador = null;
            }
            else
            {
                Ganador = ganador;
                Empate = false;
            }
        }
    }
}
