﻿using Medical.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Medical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Text.Json;
using Medical.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace Medical.Controllers
{
    public class AllPatientRecordController : Controller
    {


        private readonly MedicalContext _context;
        public AllPatientRecordController(MedicalContext medicalContext)
        {
            _context = medicalContext;
        }

        public IActionResult List()
        {

            //CMemberAdminViewModel vm = null;
            string logJson = "";
            logJson = HttpContext.Session.GetString(CDictionary.SK_LOGINED_USE);
            
            //vm = JsonSerializer.Deserialize<CMemberAdminViewModel>(logJson);
            var id = 2 /*vm.Member.MemberId*/;

            var doctorID = _context.Doctors.Where(m => m.MemberId == id).Select(m => m.DoctorId).FirstOrDefault();
            //var clinicDetailID = _context.ClinicDetails.Where(m => m.DoctorId == doctorID).Select(m => m.ClinicDetailId).FirstOrDefault();
            ////var reserveID = 18;
            //var reserveID = _context.Reserves.Where(m => m.ClinicDetailId == clinicDetailID).Select(m => m.ReserveId).FirstOrDefault();
            var reserveID = _context.CaseRecords.Include(x => x.TreatmentDetail).Include(x => x.Member).Include(x => x.Reserve).ThenInclude(x => x.ClinicDetail).ThenInclude(x => x.Doctor).
               Where(x => x.Reserve.ClinicDetail.DoctorId == doctorID);

            //if (string.IsNullOrEmpty(vModel.txtKeyword)){
            //    if (reserveID != null)
            //    {
            //        IEnumerable<CaseRecordViewModel> list = null;

            //        list = _context.CaseRecords.Where(m => m.ReserveId == reserveID).Select(m => new CaseRecordViewModel
            //        {
            //            caseRecord = m,
            //            Member = m.Member,
            //            Reserve = m.Reserve,
            //            TreatmentDetail = m.TreatmentDetail
            //        });
            //        return View(list);
            //    }
            //}
            //else
            //{
            //    IEnumerable<CaseRecordViewModel> list = null;

            //    list = _context.CaseRecords.Where(m => m.ReserveId == reserveID && m.Member.MemberName.Contains(vModel.txtKeyword)).Select(m => new CaseRecordViewModel
            //    {
            //        caseRecord = m,
            //        Member = m.Member,
            //        Reserve = m.Reserve,
            //        TreatmentDetail = m.TreatmentDetail
            //    });
            //    
            //}
            
            return View(reserveID.ToList());
            //return RedirectToAction("Index", "Home");


        }
    }
}
