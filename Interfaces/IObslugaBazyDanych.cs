using MVC_laby.Models;
namespace MVC_laby.Interfaces

{
    public interface IObslugaBazyDanych
    {
        string DodajZajeciaDoPlanu(string nazwa);
        void AddStudent(Student student);
        bool DeleteStudent(string index);
    }
}