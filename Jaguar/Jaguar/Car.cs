using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jaguar
{
    class Car
    {
        String reg_no, model, color;
        Double price;
        public Car() { }//default constructor
        public Car(String reg_no)
        {
            this.reg_no = reg_no;
            
        }
        public Car(String reg_no, String model)
        {
            this.reg_no = reg_no;
            this.model = model;
            
        }
        public Car(String reg_no, String model, String color)
        {
            this.reg_no = reg_no;
            this.model = model;
            this.color = color;
           
        }
        public Car(String reg_no,String model,String color,Double price)
        {
            this.reg_no = reg_no;
            this.model = model;
            this.color =color;
            this.price = price;
        }
        public void showcar()
        {
            Console.WriteLine("reg_no : {0} \n model : {1} \n color : {2} \n price : {3}", reg_no, model, color, price);
        }
    }

}
