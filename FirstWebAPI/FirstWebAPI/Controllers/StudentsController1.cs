using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPI.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class StudentsController1 : ControllerBase
    {
        public static List<Students> studs = new List<Students> 
        {
            new Students{Id=001 , Name="Ammu",Marks=80,Subj="Maths"},
            new Students{Id=002 , Name="Vaji",Marks=90,Subj="Science"},
            new Students{Id=003 , Name="Chay",Marks=70,Subj="Phy"},
            new Students{Id=004 , Name="Simran",Marks=90,Subj="Chem"},
            new Students{Id=005 , Name="Apparna",Marks=80,Subj="Maths"},
            new Students{Id=006 , Name="Ashna",Marks=92,Subj="Social"},
        };


        //default get method
        [HttpGet]
        public ActionResult<IEnumerable<Students>> GetStudents()
        {
            return studs;
        }

        //Get method using get id
        [HttpGet("{id}")]
        public ActionResult<Students> GetStudents(int id)
        {
            var Student = studs.FirstOrDefault(p => p.Id == id);
            if (Student == null)
            {
                return NotFound();
            }
            return Student;
        }

        //post method
        [HttpPost]
        public ActionResult<Students> PostStudents(Students students)
        {
            studs.Add(students);
            return CreatedAtAction(nameof(GetStudents), new { id = students.Id }, students);
        }

        //put methos - updating
        [HttpPut("{id}")]
        public IActionResult PutStudents(int id, Students students)
        {
            if (id != students.Id)
            {
                return BadRequest();
            }

            var existingStudents = studs.FirstOrDefault(p => p.Id == id);
            if (existingStudents == null)
            {
                return NotFound();
            }
            existingStudents.Name = students.Name;
            existingStudents.Marks = students.Marks;
            existingStudents.Subj = students.Subj;

            // In a real application, here you would update the product in the database

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var students = studs.FirstOrDefault(p => p.Id == id);
            if (students == null)
            {
                return NotFound();
            }
            studs.Remove(students);
            // In a real application, here you would delete the product from the database
            return NoContent();
        }

    }
}
