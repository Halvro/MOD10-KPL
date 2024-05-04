using Microsoft.AspNetCore.Mvc;
using modul10_1302220098;

namespace modul10_1302220098.Controllers
{
    [Route("api / [controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> listMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa(" Haikal Alfaro","1302220098", new List<string> { "KPL", "PBO", "BD" },2022),
            new Mahasiswa(" Naufal Ajhar","1302223132", new List<string> { "KPL", "PBO", "BD" }, 2022),
            new Mahasiswa(" Muhammad Galang","1302224321", new List<string> { "KPL", "PBO", "BD" },2022),
            new Mahasiswa(" Najwa Aulia","1302228765", new List<string> { "KPL", "PBO", "BD" }, 2022),
        };
        
        
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return listMahasiswa;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return listMahasiswa[id];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa mahasiswa)
        {
            listMahasiswa.Add(mahasiswa);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            listMahasiswa.RemoveAt(id);
        }
    }
}
