using Microsoft.AspNetCore.Mvc;
using Student__System_With_Code_First.Context;
using Student__System_With_Code_First.Models;

namespace Student__System_With_Code_First.Controllers
{
    public class StudentController : Controller
    {
        Db_Context context;

        public StudentController(Db_Context _init)
        {
            context = _init;
        }
        public IActionResult Index()
        {
            Student_Model model = new Student_Model();
            return View(model);
        }

        public IActionResult Report()
        {
            var _list=(from x in context.student_tbl select x).ToList();
            return View(_list);
        }
        
        public IActionResult SaveData(Student_Model model)
        {
            try
            {
                if (model.stud_id == 0)
                {
                    context.student_tbl.Add(model);
                    context.SaveChanges();
                }
                else
                {
                    context.student_tbl.Update(model);
                    context.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
            return View("PostData");
        }

        public IActionResult Edit(int id)
        {
            var data = (from x in context.student_tbl.Where(x => x.stud_id == id) select x).FirstOrDefault();
            Student_Model model = new Student_Model()
            {
                stud_id=data.stud_id,
                stud_name=data.stud_name,
                stud_email=data.stud_email,
                stud_phone=data.stud_phone,
                stud_address=data.stud_address
            };
            return View("PostData",model);
        }

        public IActionResult Delete(int id)
        {
            var data = context.student_tbl.FirstOrDefault(x => x.stud_id == id);
            if (data == null)
            {
                NotFound();
            }
            else
            context.student_tbl.Remove(data);
            context.SaveChanges();  
            return RedirectToAction("Report");
        }

        
    }
}
