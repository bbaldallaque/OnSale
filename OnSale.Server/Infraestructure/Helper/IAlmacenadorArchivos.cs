using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnSale.Server.Infraestructure.Helper
{
    public interface IAlmacenadorArchivos
    {
        Task<string> EditarArchivo(byte[] contenido, string extension, string contenedor, string ruta,
            string contentType);
        Task BorrarArchivo(string ruta, string contenedor);
        Task<string> GuardarArchivo(byte[] contenido, string extension, string contenedor, string contentType);
    }
}

//CREATE
//if (actorCreacionDTO.Foto != null)
//{
//    using (var memoryStream = new MemoryStream())
//    {
//        await actorCreacionDTO.Foto.CopyToAsync(memoryStream);
//        var contenido = memoryStream.ToArray();
//        var extension = Path.GetExtension(actorCreacionDTO.Foto.FileName);
//        entidad.Foto = await almacenadorArchivos.GuardarArchivo(contenido, extension, contenedor,
//            actorCreacionDTO.Foto.ContentType);
//    }
//}


//Update
//var actorDB = await context.Actores.FirstOrDefaultAsync(x => x.Id == id);

//if (actorDB == null) { return NotFound(); }

//actorDB = mapper.Map(actorCreacionDTO, actorDB);

//if (actorCreacionDTO.Foto != null)
//{
//    using (var memoryStream = new MemoryStream())
//    {
//        await actorCreacionDTO.Foto.CopyToAsync(memoryStream);
//        var contenido = memoryStream.ToArray();
//        var extension = Path.GetExtension(actorCreacionDTO.Foto.FileName);
//        actorDB.Foto = await almacenadorArchivos.EditarArchivo(contenido, extension, contenedor,
//            actorDB.Foto,
//            actorCreacionDTO.Foto.ContentType);
//    }
//}