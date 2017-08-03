﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using PW.Ncels.Database.Constants;
using PW.Ncels.Database.DataModel;
using PW.Ncels.Database.Helpers;
using PW.Ncels.Database.Models;
using PW.Ncels.Database.Repository.Contract;
using PW.Ncels.Database.Repository.OBK;
using PW.Ncels.Database.Repository.Common;
using PW.Ncels.Helpers;

namespace PW.Ncels.Controllers
{
    public class SafetyAssessmentController : Controller
    {

        // GET: SafetyAssessment
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// подача заявления
        /// </summary>
        /// <returns></returns>
        public ActionResult Create(string type)
        {

            var model = new OBK_AssessmentDeclaration
            {
                Id = Guid.NewGuid(),
                OwnerId = UserHelper.GetCurrentEmployee().Id,
                StatusId = CodeConstManager.STATUS_DRAFT_ID,
                ObkContracts = new List<OBK_Contract>(),
                ObkRsProductses = new List<OBK_RS_Products>()
            };

            

            model.CertificateDate = null;
            model.CreatedDate = DateTime.Now;

            //продукты
            if (model.ObkRsProductses.Count == 0) {
                model.ObkRsProductses = new List<OBK_RS_Products>() { new OBK_RS_Products()
                {
                    Obk_Products_Series = new List<OBK_Procunts_Series>() { new OBK_Procunts_Series()}
                }};
            }

            //договора
            if (model.ObkContracts.Count == 0) {
                model.ObkContracts.Add(new OBK_Contract());
            }

            var safetyRepository = new SafetyAssessmentRepository(false);

            if (type == CodeConstManager.OBK_SA_SERIAL) {
                ViewData["TypeList"] = new SelectList(safetyRepository.GetObkRefTypes(), "Id", "NameRu", model.Type_Id = Int32.Parse(CodeConstManager.OBK_SA_SERIAL));
            }
            if (type == CodeConstManager.OBK_SA_PARTY) {
                ViewData["TypeList"] = new SelectList(safetyRepository.GetObkRefTypes(), "Id", "NameRu", model.Type_Id = Int32.Parse(CodeConstManager.OBK_SA_PARTY));
            }
            if (type == CodeConstManager.OBK_SA_DECLARATION) {
                ViewData["TypeList"] = new SelectList(safetyRepository.GetObkRefTypes(), "Id", "NameRu", model.Type_Id = Int32.Parse(CodeConstManager.OBK_SA_DECLARATION));
            }

            ViewData["ContractList"] =
                new SelectList(safetyRepository.GetActiveContractListWithInfo(model.OwnerId), "Id",
                    "ContractInfo", model.Contract_Id);

            var repository = new ReadOnlyDictionaryRepository();
            //Наличие сертификата GMP
            var booleans = repository.GetCertificateGMPCheck();
            ViewData["IsGMPList"] = new SelectList(booleans, "CertificateGMPCheck", "NameRu", model.CertificateGMPCheck);

            //справочник стран
            var countries = safetyRepository.GetCounties();
            ViewData["Counties"] = new SelectList(countries, "Id", "Name");

            //Валюта
            var currency = safetyRepository.GetObkCurrencies();
            ViewData["Courrency"] = new SelectList(currency, "Id", "Name");
            
            return View(model);
        }

        public ActionResult Delete(string id)
        {
            new SafetyAssessmentRepository().DeleteReport(id, UserHelper.GetCurrentEmployee().Id);
            return RedirectToAction("RegisterSafetyAssessmentList");
        }


        public ActionResult RegisterSafetyAssessmentList()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ShowDetails(string id)
        {
          var model = GetSaDeclarationById(id);
          return View(model);
        }

        public OBK_AssessmentDeclaration GetSaDeclarationById(string id)
        {
          var repository = new SafetyAssessmentRepository();
          var model = repository.GetById(id);
            //model.IsExist = true;
          FillDeclarationControl(model);
          return model;
        }

        private void FillDeclarationControl(OBK_AssessmentDeclaration model)
        {
            var safetyRepository = new SafetyAssessmentRepository();
            ViewData["ContractList"] =
                new SelectList(safetyRepository.GetActiveContractListWithInfo(model.OwnerId), "Id",
                    "ContractInfo", model.Contract_Id);

            if (model.Contract_Id != null)
            {
                var contract = safetyRepository.GetContractById(model.Contract_Id);
                var organization = safetyRepository.GetOrganizationById(contract.OrganizationId);

                //справочник стран
                var countries = safetyRepository.GetCounties();
                ViewData["Counties"] = new SelectList(countries, "Id", "Name",
                    model.CountryId = organization.CountryId);

                //Валюта
                var currency = safetyRepository.GetObkCurrencies();
                ViewData["Courrency"] = new SelectList(currency, "Id", "Name",
                    model.CurrencyId = organization.CurrencyId);

                var repository = new ReadOnlyDictionaryRepository();
                //Наличие сертификата GMP
                var booleans = repository.GetCertificateGMPCheck();
                ViewData["IsGMPList"] = new SelectList(booleans, "CertificateGMPCheck", "NameRu",
                    model.CertificateGMPCheck);
            }
            else
            {
                var countries = safetyRepository.GetCounties();
                ViewData["Counties"] = new SelectList(countries, "Id", "Name");

                //Валюта
                var currency = safetyRepository.GetObkCurrencies();
                ViewData["Courrency"] = new SelectList(currency, "Id", "Name");

                var repository = new ReadOnlyDictionaryRepository();
                //Наличие сертификата GMP
                var booleans = repository.GetCertificateGMPCheck();
                ViewData["IsGMPList"] = new SelectList(booleans, "CertificateGMPCheck", "NameRu",
                    model.CertificateGMPCheck);
            }
        }

        /// <summary>
        /// получение списка заявлений
        /// </summary>
        /// <param name="request"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<JsonResult> ReadSafetyAssessmentDeclaration(ModelRequest request, int? type)
        {
            return Json(await new SafetyAssessmentRepository().GetSafetyAssessmentDeclarationList(request, true, type), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelId"></param>
        /// <returns></returns>
        public ActionResult GetRSProducts(string modelId)
        {
            var products = new SafetyAssessmentRepository().GetRsProducts(modelId);
            return Json(new {Success = true});
        }

        /// <summary>
        /// сохранение продукции
        /// </summary>
        /// <returns></returns>
        public JsonResult SaveProducts(string modelId, string nameRu, string nameKz, string producerNameRu, string producerNameKz, string countryNameRu, string countryNameKz,
            string tnvedCode, string kpvedCode, string price, string currency, string[] products)
        {
            return Json(new SafetyAssessmentRepository().GetSaveObkRsProducts(modelId, nameRu, nameKz, producerNameRu,
                producerNameKz, countryNameRu, countryNameKz,
                tnvedCode, kpvedCode, price, currency));
        }
        [HttpGet]
        public JsonResult AddToTable(string modelId)
        {
            var result = new SafetyAssessmentRepository().GetAddToTable(modelId).ToArray();
            return Json(result.Select(c=> new { c.Id, c.NameRu, c.ProducerNameRu, c.CountryNameRu, c.TnvedCode, c.KpvedCode}), JsonRequestBehavior.AllowGet);
        }



        /// <summary>
        /// поиск в госреестре
        /// </summary>
        /// <param name="regNumber">Рег. номер</param>
        /// <param name="tradeName">Торговое название</param>
        /// <param name="manufacturer">Производитель</param>
        /// <param name="mnn">МНН</param>
        /// <returns></returns>
        public ActionResult GetSearchReestr(string regNumber, string tradeName, string manufacturer, string mnn)
        {
            var reestr = new SafetyAssessmentRepository().GetSearchReestr(regNumber, tradeName, manufacturer, mnn);

            if (reestr == null)
                return Json(new { Success = false });

            return Json(new
            {
                Success = true,
                reestr.name,
                reestr.producer_name,
                reestr.country_name,
                reestr.tnved_code,
                reestr.kpved_code,
                reestr.cost,
                reestr.currency_name
            });
        }

        [HttpPost]
        public virtual ActionResult UpdateModel(string code, int typeId, string modelId, string userId, long? recordId, string fieldName, string fieldValue, string fieldDisplay)
            {
            var filter = new SafetyAssessmentRepository().UpdateModel(code, typeId, modelId, userId, recordId, fieldName, fieldValue, fieldDisplay);
            return Json(new { Success = true, modelId = filter.ModelId, recordId = filter.RecordId, controlId = filter.ControlId });
        }

        /// <summary>
        /// Выбор договора
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public virtual ActionResult GetContract(Guid id)
        {
            var contract = new SafetyAssessmentRepository().GetContractById(id);

            if (contract == null)
            {
                return Json(new
                {
                    isSuccess = false
                });
            }

            var organization = new SafetyAssessmentRepository().GetOrganizationById(contract.OrganizationId);

            return Json(new
            {
                startDate = String.Format("{0:dd/MM/yyyy}", contract.StartDate),
                endDate = String.Format("{0:dd/MM/yyyy}", contract.EndDate),

                daclarant = organization?.Declarant ?? "нет данных",
                orgForm = organization?.OrgForm ?? "нет данных",
                nameKz = organization?.NameKz ?? "нет данных",
                nameRu = organization?.NameRu ?? "нет данных",
                nameEn = organization?.NameEn ?? "нет данных",
                regNumber = organization?.RegCertificateNumber ?? "нет данных",
                chiefLastName = organization?.СhiefLastName ?? "нет данных",
                chiefFirstName = organization?.СhiefFirstName ?? "нет данных",
                chiefMiddleName = organization?.СhiefMiddleName ?? "нет данных",
                chiefPosition = organization?.СhiefPosition ?? "нет данных",
                addressFact = organization?.AddressFact ?? "нет данных",
                addressLegal = organization?.AddressLegal ?? "нет данных",
                phone = organization?.Phone ?? "нет данных",
                email = organization?.Email ?? "нет данных",
                bankBik = organization?.BankBik ?? "нет данных",
                bankSwift = organization?.BankSwift ?? "нет данных",
                bankAccount = organization?.BankAccount ?? "нет данных",
                bankName = organization?.BankName ?? "нет данных",
                country = organization?.CountryId ?? null,
                currency = organization?.CurrencyId ?? null,
                isSuccess = true
            });
        }
    }
}