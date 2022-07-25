using Microsoft.AspNetCore.Mvc;
using Medical.Models;
using Medical.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medical.Controllers
{
    public class RatingDoctorController : Controller
    {
        private readonly MedicalContext _context;
        public RatingDoctorController(MedicalContext medicalContext)
        {
            _context = medicalContext;
        }

        public IActionResult List()
        {
            
            IEnumerable<RatingDoctoeViewModel> datas = null;
            datas = _context.RatingDoctors.Select(d => new RatingDoctoeViewModel
            {
                ratingDoctor = d,
                Doctor = d.Doctor,
                RatingType = d.RatingType
            });
            return View(datas);
        }
        public IActionResult Delete(int? id)
        {
            
            RatingDoctor ratingDoctor = _context.RatingDoctors.FirstOrDefault(r => r.RatingDoctorId == id);
            if(ratingDoctor != null)
            {
                _context.RatingDoctors.Remove(ratingDoctor);
                _context.SaveChanges();
            }
            return RedirectToAction("List");
        }
        public IActionResult Edit(int? id)
        {
            RatingDoctor ratingDoctor = _context.RatingDoctors.FirstOrDefault(r => r.RatingDoctorId == id);
            if (ratingDoctor == null)
            {
                return RedirectToAction("List");
            }
            return View(ratingDoctor);
        }
        [HttpPost]
        public IActionResult Edit(RatingDoctor rd)
        {
           
            RatingDoctor ratingDoctor = _context.RatingDoctors.FirstOrDefault(r => r.RatingDoctorId == rd.RatingDoctorId);
            if (ratingDoctor != null)
            {
                ratingDoctor.DoctorId = rd.DoctorId;
                ratingDoctor.RatingTypeId = rd.RatingTypeId;
                ratingDoctor.Rating = rd.Rating;
                _context.SaveChanges();
            }
            return RedirectToAction("List");
        }
    }
}
