using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers//yolunu koyuyoruz paketleme yapıcaz
{
    public class EmployeeController : Controller //controller ekleyicezki controller sınıfından kalıtımları alsın
    {
        public String Index(){

            return "hello world";
            // burada string iafede döndürdük
        }
        public IActionResult Index1(){
            string message = $"hello world. {DateTime.Now.ToString()}";
            return View("Index1",message);// burada sayfaya buradan veri taşıyacağımız zaman böye yapılması gerekiyor


        }
        public ViewResult Index2(){// burada index2 yi arar eğer başka bir Wiew isteniyorsa return View("Index1"); gibi yapmalıyız direkt index2 yi arayacaktır

            return View("Index2");//burada hangisini rander edeceğini söylüyoruz

        }
        public IActionResult Index3 (){// burada da content olarak yani string  vs içerikler döndürecektir
            
           

            
            return View("Employee");// view olmadan dönüş sağlarız



        }
        public ViewResult Index4(){



            var names = new String[]{

                "ahmet",
                "mehmet",
                "can"
            };
            return View(names);
        }

        public IActionResult Index8(){
            var list = new List<Employee>(){

                new Employee(){Id=1 , FirstName="ahmet", LastName="can",Age=20},
                new Employee(){Id=2 , FirstName="ali", LastName="can",Age=23},
                
            };



            return View("Index8",list);
        }
        

        
    }

}