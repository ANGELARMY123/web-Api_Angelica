using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Becas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Becas.service
{
    public class AlumnoService
    {
       static List<Alumno> Alumnos {get;}

        static int nextId = 3;
          static AlumnoService ()
        {
            Alumnos = new List <Alumno> {
                new Alumno {Id = 1, Nombres = "Angelica ", ApellPat = "Alvaro ", ApellMat = "Arcos", Matricula = "12345678 ", Carrera = "T.S.U Tecnologias de la informacion ", Correo = "Angelica@gmail.com ", Telefono = "9161637672 ", Origen = "chiapas", Estancia = "candelaria " },
                new Alumno {Id = 2, Nombres = "Paola", ApellPat = "Alvaro ", ApellMat = "Arcos", Matricula = "12345678 ", Carrera = "T.S.U Tecnologias de la informacion ", Correo = "Angelica@gmail.com ", Telefono = "9161637672 ", Origen = "chiapas", Estancia = "candelaria " },
            };
        }

        public ActionResult<List<Alumno>> GetAll()
        {
            throw new NotImplementedException();
        }

        public static List<Alumno> Get()=> Alumnos;

    public  Alumno Get(int Id) => Alumnos.FirstOrDefault(p => p.Id == Id);


    public static void Add(Alumno alumno)
    {
        alumno.Id = nextId++;
        Alumnos.Add(alumno);

    }
    public async void Delete(int Id )
    {
        var alumno = Get(Id);
        if(alumno is null)
            return;

            Alumnos.Remove(alumno);
           
    }

    public async void Update(Alumno alumno)
    {
        var index = Alumnos.FindIndex(p => p.Id == alumno.Id);
        if (index == -1)
        return;

        Alumnos[index] = alumno;
    }


    }
}