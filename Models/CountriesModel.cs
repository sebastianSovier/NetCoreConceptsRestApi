﻿
using Models;

namespace NetCoreConcepts.Models
{
    public class CountriesModel
    {
        public string? name { get; set; }
        public string? capital { get; set; }
        public string? region { get; set; }
        public string? population { get; set; }

    }
    public class PaisesModel : IUsuarioValidation
    {
        public Int64 pais_id { get; set; }
        public string? nombre_pais { get; set; }
        public string? capital { get; set; }
        public string? region { get; set; }
        public string? poblacion { get; set; }

        public DateTime? fecha_registro { get; set; }
        public Int64 usuario_id { get; set; }
        public string? usuario { get; set; }
    }
    public class PaisesListUsuarioId
    {
        public List<List<PaisesModelCiudades>>? list { get; set; }
    }
    public class PaisesModelCiudades : IUsuarioValidation
    {
        public Int64 pais_id { get; set; }
        public string? nombre_pais { get; set; }
        public string? capital { get; set; }
        public string? region { get; set; }
        public string? poblacion { get; set; }

        public DateTime? fecha_registro { get; set; }
        public Int64 usuario_id { get; set; }
        public string? usuario { get; set; }
        public string? correo { get; set; }
        public string? nombre { get; set; }
        public List<CiudadesModel>? listCiudades { get; set; }

        public List<PaisesModelCiudades>? listPaises { get; set; }
        public string? listCiudadesSerialize { get; set; }
    }
    public class PaisesModelCiudadesOut
    {
        public Int64 usuario_id { get; set; }
        public string? correo { get; set; }
        public string? nombre { get; set; }
        public List<CiudadesModel>? listCiudades { get; set; }

        public List<PaisesModelCiudades>? listPaises { get; set; }
        public string? listPaisesSerialize { get; set; }
        public string? listCiudadesSerialize { get; set; }
    }
    public class CiudadesModel : IUsuarioValidation
    {
        public Int64 ciudad_id { get; set; }
        public Int64 pais_id { get; set; }
        public string? nombre_ciudad { get; set; }
        public string? region { get; set; }
        public string? poblacion { get; set; }
        public string? latitud { get; set; }
        public string? longitud { get; set; }
        public string? usuario { get; set; }
    }
    public class UsuarioRequest : IUsuarioValidation
    {
        public string? usuario { get; set; }
        public string? fecha_desde { get; set; }
        public string? fecha_hasta { get; set; }
        public Int64 pais_id { get; set; }
    }

    public class ExcelDataRequest : IUsuarioValidation
    {
        public string? base64string { get; set; }
        public string? usuario { get; set; }

        public long pais_id { get; set; }
    }
    public class UsuarioValidation : IUsuarioValidation
    {
        public string? usuario { get; set; }
    }
}
