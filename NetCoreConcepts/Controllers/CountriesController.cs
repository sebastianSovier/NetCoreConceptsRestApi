﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using NetCoreConcepts.Bo;
using NetCoreConcepts.Dal;
using NetCoreConcepts.Models;
using NetCoreConcepts.UtilidadesApi;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static NetCoreConcepts.Models.LoginModels;

namespace NetCoreConcepts.Controllers
{
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly IConfiguration _config;
        Dictionary<string, string> response = new Dictionary<string, string>();
        List<PaisesModel> countriesList = new List<PaisesModel>();
        UtilidadesApiss utils = new UtilidadesApiss();

        public CountriesController(IConfiguration config)
        {
            _config = config;
        }

        [Authorize()]
        [HttpPost]
        [Route("Countries/TodosLosPaises")]
        public IActionResult TodosLosPaises(UsuarioRequest request)
        {
            PaisesBo bo = new PaisesBo(_config);
            try
            {
                countriesList = bo.ObtenerPaises(request);
                return Ok(JsonConvert.SerializeObject(countriesList));

            }
            catch (Exception ex)
            {
                utils.createlogFile(ex.Message);
                response.Add("Error", "Hubo un problema.");
                return StatusCode(500, response);
            }
        }
        [HttpPost]
        [Route("Countries/TodosLosPaisesByUsuarios")]
        public IActionResult TodosLosPaisesByUsuarios()
        {
            PaisesBo bo = new PaisesBo(_config);
            try
            {
                List<PaisesModelCiudadesOut> paisesCiudadesByUsuarios = bo.ObtenerTodosPaisesByUsuarios();
                return Ok(JsonConvert.SerializeObject(paisesCiudadesByUsuarios));

            }
            catch (Exception ex)
            {
                utils.createlogFile(ex.Message);
                response.Add("Error", "Hubo un problema.");
                return StatusCode(500, response);
            }
        }
        [Authorize()]
        [HttpPost]
        [Route("Countries/ObtenerPaisesPorFechas")]
        public IActionResult ObtenerPaisesPorFechas(UsuarioRequest request)
        {
            PaisesBo bo = new PaisesBo(_config);
            try
            {
                countriesList = bo.ObtenerPaisesPorFechas(request);
                return Ok(JsonConvert.SerializeObject(countriesList));

            }
            catch (Exception ex)
            {
                utils.createlogFile(ex.Message);
                response.Add("Error", "Hubo un problema.");
                return StatusCode(500, response);
            }
        }
        [Authorize()]
        [HttpPost]
        [Route("Countries/GetExcelPaises")]
        public IActionResult GetExcelPaises(UsuarioRequest request)
        {
            PaisesBo bo = new PaisesBo(_config);
            try
            {
                countriesList = bo.ObtenerPaises(request);
                return Ok(JsonConvert.SerializeObject(countriesList));

            }
            catch (Exception ex)
            {
                utils.createlogFile(ex.Message);
                response.Add("Error", "Hubo un problema.");
                return StatusCode(500, response);
            }
        }
        [Authorize()]
        [HttpPost]
        [Route("Countries/GetDataFromExcel")]
        public IActionResult GetDataFromExcel([FromBody] ExcelDataRequest request)
        {
            PaisesBo bo = new PaisesBo(_config);
            try
            {
                countriesList = bo.ImportarExcel(request);
                return Ok(JsonConvert.SerializeObject(countriesList));

            }
            catch (Exception ex)
            {
                utils.createlogFile(ex.Message);
                response.Add("Error", "Hubo un problema.");
                return StatusCode(500, response);
            }
        }


        [Authorize()]
        [HttpPost]
        [Route("Countries/IngresarPais")]
        public IActionResult IngresarPais(PaisesModel paisRequest)
        {
            PaisesBo bo = new PaisesBo(_config);
            try
            {
                countriesList = bo.IngresarPais(paisRequest);
                return Ok(JsonConvert.SerializeObject(countriesList));

            }
            catch (Exception ex)
            {
                utils.createlogFile(ex.Message);
                response.Add("Error", "Hubo un problema.");
                return StatusCode(500, response);
            }
        }
        [Authorize()]
        [HttpPost]
        [Route("Countries/ModificarPais")]
        public IActionResult ModificarPais(PaisesModel paisRequest)
        {
            PaisesBo bo = new PaisesBo(_config);
            try
            {
                countriesList = bo.ModificarPais(paisRequest); ;
                return Ok(JsonConvert.SerializeObject(countriesList));

            }
            catch (Exception ex)
            {
                utils.createlogFile(ex.Message);
                response.Add("Error", "Hubo un problema.");
                return StatusCode(500, response);
            }
        }


        [Authorize()]
        [HttpPost]
        [Route("Countries/EliminarPais")]
        public IActionResult EliminarPais(PaisesModel request)
        {
            PaisesBo bo = new PaisesBo(_config);
            try
            {
                countriesList = bo.EliminarPais(request);
                return Ok(JsonConvert.SerializeObject(countriesList));

            }
            catch (Exception ex)
            {
                utils.createlogFile(ex.Message);
                response.Add("Error", "Hubo un problema.");
                return StatusCode(500, response);
            }
        }



    }
}
