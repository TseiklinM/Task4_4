using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  Создайте класс «Журнал». Необходимо хранить в полях класса: 
     *  название журнала, 
     *  год основания, 
     *  описание журнала, 
     *  контактный телефон, 
     *  контактный e-mail.
    Реализуйте методы класса для ввода данных, вывода данных, реализуйте доступ к отдельным полям через
методы класса.
 */

namespace Task4_4
{
    class Magazine
    {
        string magazineName;
        int foundationYear;
        string magazineDiscription;
        string phoneNumber;
        string magazineEmail;

        public Magazine() : this (  "Компьтерра", 
                                    1997, 
                                    "Легендарный журнал о современных технологиях", 
                                    "+7 (812) 313-88-32", 
                                    "https://www.computerra.ru/")
        {
        }

        public Magazine (Magazine obj) : this(  obj.magazineName, 
                                                obj.foundationYear, 
                                                obj.magazineDiscription, 
                                                obj.phoneNumber, 
                                                obj.magazineEmail)
        {
        }

        public Magazine(string magazineName, int foundationYear, string magazineDiscription, 
                                        string phoneNumber, string magazineEmail)
        {
            this.magazineName = magazineName;
            this.foundationYear = foundationYear;
            this.magazineDiscription = magazineDiscription;
            this.phoneNumber = phoneNumber;
            this.magazineEmail = magazineEmail;
        }

        public void InsertDataMagazine()
        {
            Console.Write("\n\n Введите наименование журнала: ");
            magazineName = Console.ReadLine();
            Console.Write(" Введите год основания журнала: ");
            foundationYear = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Введите описание журнала: ");
            magazineDiscription = Console.ReadLine();
            Console.Write(" Введите номер телефона редакции журнала: ");
            phoneNumber = Console.ReadLine();
            Console.Write(" Введите e-mail журнала: ");
            phoneNumber = Console.ReadLine();
        }

        public void PrintData()
        {
            Console.WriteLine($"\n\n Наименование журнала: {magazineName}\n" +
                                $" Год начала издательства журнала: {foundationYear}\n" +
                                $" Описание журнала: {magazineDiscription}\n" +
                                $" Номер телефона редакции: {phoneNumber}\n" +
                                $" E-mail журнала: {magazineEmail}");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {

            Magazine magazineNone = new Magazine();
            magazineNone.PrintData();

            Magazine magazine1 = new Magazine();
            magazine1.InsertDataMagazine();
            magazine1.PrintData();

            Magazine magazine2 = new Magazine(  "Юный техник", 
                                                1956, 
                                                "Научно-технический, популярный журнал рассказывает о последних достижениях науки и техники,\n " +
                                                "тайнах природы и мироздания, о важнейших открытиях и изобретениях.", 
                                                " +7 (495) 685-18-09", 
                                                "http://utechnik.ru/");
            magazine2.PrintData();
        }
    }
}

