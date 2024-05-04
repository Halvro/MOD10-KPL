namespace modul10_1302220098
{
    public class Mahasiswa
    {
        public string name { get; set; }
        public string nim { get; set; }
        public List<string> Course { get; set; }
        public int year { get; set; }

        public Mahasiswa(string name, string nim, List<string> Course, int year)
        {
            this.name = name;
            this.nim = nim;
            this.Course = Course;
            this.year = year;

        }
    }
}
