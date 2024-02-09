using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService) //Constructor new yapıldığında çalışır.
        {
            _applicantService = applicantService; //classlarda fieldlar alt çizgi ile başlar
        }
        public void GiveMask(Person person) //İş sınıflarında newlemek o classa bağımlılık demektir.
        {
            if (_applicantService.CheckPerson(person)){
                Console.WriteLine(person.FirstName + " için maske verildi.");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske verilemedi");
            }
                
        }
    }
}
