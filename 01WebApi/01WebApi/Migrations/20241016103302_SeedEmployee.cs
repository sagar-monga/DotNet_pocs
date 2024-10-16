using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _01WebApi.Migrations
{
    public partial class SeedEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "Department", "FirstName", "HireDate", "LastName", "Position", "Salary" },
                values: new object[,]
                {
                    { 1, new DateTime(1993, 1, 24, 9, 33, 18, 0, DateTimeKind.Unspecified), "Services", "Editha", new DateTime(2022, 9, 8, 23, 4, 1, 0, DateTimeKind.Unspecified), "Tregear", "Assistant Manager", 622619 },
                    { 2, new DateTime(1986, 10, 18, 7, 26, 31, 0, DateTimeKind.Unspecified), "Marketing", "Torin", new DateTime(2022, 3, 17, 1, 42, 26, 0, DateTimeKind.Unspecified), "Bowller", "Account Executive", 121237 },
                    { 3, new DateTime(1992, 9, 9, 2, 22, 59, 0, DateTimeKind.Unspecified), "Product Management", "Roby", new DateTime(2018, 3, 31, 12, 59, 21, 0, DateTimeKind.Unspecified), "Yglesias", "Administrative Assistant IV", 307611 },
                    { 4, new DateTime(1991, 1, 16, 3, 52, 18, 0, DateTimeKind.Unspecified), "Product Management", "Mord", new DateTime(2015, 6, 29, 19, 41, 36, 0, DateTimeKind.Unspecified), "Lohan", "VP Product Management", 216914 },
                    { 5, new DateTime(1986, 4, 17, 1, 16, 25, 0, DateTimeKind.Unspecified), "Training", "Garwin", new DateTime(2022, 10, 27, 13, 30, 27, 0, DateTimeKind.Unspecified), "Westnedge", "Accountant II", 476032 },
                    { 6, new DateTime(1998, 2, 3, 7, 23, 57, 0, DateTimeKind.Unspecified), "Business Development", "Sena", new DateTime(2015, 4, 15, 15, 10, 51, 0, DateTimeKind.Unspecified), "Tonry", "Mechanical Systems Engineer", 289547 },
                    { 7, new DateTime(1987, 7, 30, 17, 38, 47, 0, DateTimeKind.Unspecified), "Sales", "Kata", new DateTime(2017, 11, 5, 16, 52, 6, 0, DateTimeKind.Unspecified), "Morena", "Librarian", 193147 },
                    { 8, new DateTime(1988, 7, 31, 9, 21, 28, 0, DateTimeKind.Unspecified), "Support", "Pyotr", new DateTime(2017, 10, 16, 18, 1, 47, 0, DateTimeKind.Unspecified), "Beeken", "VP Sales", 666275 },
                    { 9, new DateTime(1990, 2, 6, 6, 51, 34, 0, DateTimeKind.Unspecified), "Product Management", "Caralie", new DateTime(2019, 7, 17, 11, 33, 36, 0, DateTimeKind.Unspecified), "Sammons", "Data Coordinator", 241963 },
                    { 10, new DateTime(1994, 4, 2, 11, 53, 16, 0, DateTimeKind.Unspecified), "Engineering", "Lana", new DateTime(2015, 1, 31, 7, 0, 52, 0, DateTimeKind.Unspecified), "Itzhak", "Human Resources Manager", 353539 },
                    { 11, new DateTime(1989, 9, 5, 8, 25, 15, 0, DateTimeKind.Unspecified), "Support", "Giovanni", new DateTime(2018, 9, 30, 10, 38, 53, 0, DateTimeKind.Unspecified), "Purrier", "Environmental Specialist", 110940 },
                    { 12, new DateTime(1989, 5, 13, 11, 10, 10, 0, DateTimeKind.Unspecified), "Training", "Jermaine", new DateTime(2018, 6, 21, 11, 59, 21, 0, DateTimeKind.Unspecified), "Emett", "Health Coach III", 442046 },
                    { 13, new DateTime(1994, 6, 23, 2, 20, 51, 0, DateTimeKind.Unspecified), "Sales", "Lionel", new DateTime(2023, 12, 6, 13, 43, 15, 0, DateTimeKind.Unspecified), "Tyers", "VP Product Management", 595280 },
                    { 14, new DateTime(1996, 5, 12, 5, 58, 56, 0, DateTimeKind.Unspecified), "Training", "Aurea", new DateTime(2019, 9, 14, 7, 51, 7, 0, DateTimeKind.Unspecified), "Ruselin", "Project Manager", 507691 },
                    { 15, new DateTime(1990, 12, 26, 8, 8, 33, 0, DateTimeKind.Unspecified), "Sales", "Jard", new DateTime(2018, 7, 16, 3, 16, 19, 0, DateTimeKind.Unspecified), "Snowdon", "Executive Secretary", 176690 },
                    { 16, new DateTime(1998, 1, 7, 11, 12, 43, 0, DateTimeKind.Unspecified), "Sales", "Perle", new DateTime(2017, 6, 17, 6, 41, 34, 0, DateTimeKind.Unspecified), "Keech", "Mechanical Systems Engineer", 672589 },
                    { 17, new DateTime(1986, 8, 10, 19, 34, 15, 0, DateTimeKind.Unspecified), "Support", "Adriena", new DateTime(2019, 8, 13, 23, 59, 47, 0, DateTimeKind.Unspecified), "Wearne", "Business Systems Development Analyst", 401949 },
                    { 18, new DateTime(1995, 1, 19, 18, 18, 13, 0, DateTimeKind.Unspecified), "Services", "Frayda", new DateTime(2019, 1, 1, 6, 0, 27, 0, DateTimeKind.Unspecified), "Pumphreys", "Administrative Assistant II", 614505 },
                    { 19, new DateTime(1994, 6, 27, 19, 46, 36, 0, DateTimeKind.Unspecified), "Research and Development", "Genevieve", new DateTime(2022, 12, 12, 23, 59, 59, 0, DateTimeKind.Unspecified), "Glackin", "Editor", 565013 },
                    { 20, new DateTime(1989, 1, 9, 7, 29, 0, 0, DateTimeKind.Unspecified), "Research and Development", "Deanna", new DateTime(2021, 3, 22, 18, 45, 6, 0, DateTimeKind.Unspecified), "Denford", "Geological Engineer", 676940 },
                    { 21, new DateTime(2000, 5, 22, 8, 42, 53, 0, DateTimeKind.Unspecified), "Human Resources", "Cameron", new DateTime(2022, 7, 7, 21, 47, 49, 0, DateTimeKind.Unspecified), "Maplethorpe", "Assistant Professor", 721453 },
                    { 22, new DateTime(1996, 3, 13, 12, 7, 50, 0, DateTimeKind.Unspecified), "Marketing", "Hobey", new DateTime(2017, 3, 28, 15, 37, 45, 0, DateTimeKind.Unspecified), "Vedyashkin", "Computer Systems Analyst IV", 443392 },
                    { 23, new DateTime(1990, 5, 26, 17, 25, 41, 0, DateTimeKind.Unspecified), "Human Resources", "Donetta", new DateTime(2020, 1, 16, 20, 9, 40, 0, DateTimeKind.Unspecified), "Aysh", "Analog Circuit Design manager", 325659 },
                    { 24, new DateTime(1997, 2, 4, 12, 19, 40, 0, DateTimeKind.Unspecified), "Research and Development", "Jaquenette", new DateTime(2023, 10, 3, 3, 14, 58, 0, DateTimeKind.Unspecified), "Tennock", "Senior Editor", 757700 },
                    { 25, new DateTime(1991, 2, 15, 14, 47, 54, 0, DateTimeKind.Unspecified), "Services", "Barr", new DateTime(2017, 11, 1, 18, 1, 34, 0, DateTimeKind.Unspecified), "Gleed", "VP Product Management", 509951 },
                    { 26, new DateTime(1996, 5, 17, 19, 34, 56, 0, DateTimeKind.Unspecified), "Human Resources", "Leonhard", new DateTime(2016, 9, 16, 6, 42, 28, 0, DateTimeKind.Unspecified), "Hearsum", "Assistant Media Planner", 302130 },
                    { 27, new DateTime(1990, 1, 5, 19, 38, 39, 0, DateTimeKind.Unspecified), "Marketing", "Nathanial", new DateTime(2024, 7, 7, 12, 21, 5, 0, DateTimeKind.Unspecified), "Start", "Statistician IV", 674286 },
                    { 28, new DateTime(1990, 1, 18, 4, 25, 22, 0, DateTimeKind.Unspecified), "Marketing", "Dani", new DateTime(2017, 2, 12, 8, 44, 51, 0, DateTimeKind.Unspecified), "Brendish", "Structural Engineer", 339585 },
                    { 29, new DateTime(1998, 3, 11, 19, 23, 52, 0, DateTimeKind.Unspecified), "Product Management", "Tobin", new DateTime(2018, 9, 29, 13, 48, 14, 0, DateTimeKind.Unspecified), "Wolland", "Geologist II", 247974 },
                    { 30, new DateTime(1997, 2, 5, 17, 36, 20, 0, DateTimeKind.Unspecified), "Legal", "Demetre", new DateTime(2017, 5, 16, 23, 27, 4, 0, DateTimeKind.Unspecified), "Binder", "Design Engineer", 753453 },
                    { 31, new DateTime(1999, 6, 17, 5, 12, 59, 0, DateTimeKind.Unspecified), "Sales", "Hebert", new DateTime(2023, 12, 8, 20, 44, 8, 0, DateTimeKind.Unspecified), "Skoof", "Web Designer III", 604185 },
                    { 32, new DateTime(1986, 11, 18, 3, 20, 26, 0, DateTimeKind.Unspecified), "Engineering", "Inesita", new DateTime(2015, 10, 22, 10, 55, 42, 0, DateTimeKind.Unspecified), "Balm", "Chief Design Engineer", 685358 },
                    { 33, new DateTime(1997, 8, 27, 7, 27, 5, 0, DateTimeKind.Unspecified), "Training", "Arlana", new DateTime(2022, 5, 7, 7, 50, 49, 0, DateTimeKind.Unspecified), "Oakeby", "Data Coordinator", 526989 },
                    { 34, new DateTime(1991, 4, 15, 9, 29, 59, 0, DateTimeKind.Unspecified), "Accounting", "Codi", new DateTime(2018, 6, 9, 16, 57, 45, 0, DateTimeKind.Unspecified), "Nan Carrow", "Media Manager I", 593254 },
                    { 35, new DateTime(1992, 12, 21, 21, 36, 41, 0, DateTimeKind.Unspecified), "Training", "Bear", new DateTime(2020, 8, 19, 19, 33, 54, 0, DateTimeKind.Unspecified), "Lampe", "Director of Sales", 200031 },
                    { 36, new DateTime(1986, 9, 17, 10, 33, 47, 0, DateTimeKind.Unspecified), "Research and Development", "Hartley", new DateTime(2017, 7, 22, 6, 12, 51, 0, DateTimeKind.Unspecified), "Tudgay", "Physical Therapy Assistant", 241301 },
                    { 37, new DateTime(1988, 8, 15, 17, 4, 35, 0, DateTimeKind.Unspecified), "Legal", "Bette", new DateTime(2018, 7, 11, 17, 49, 57, 0, DateTimeKind.Unspecified), "Erik", "VP Sales", 646311 },
                    { 38, new DateTime(1994, 4, 8, 17, 18, 26, 0, DateTimeKind.Unspecified), "Training", "Ambrosio", new DateTime(2023, 11, 3, 18, 24, 25, 0, DateTimeKind.Unspecified), "Howitt", "Tax Accountant", 28351 },
                    { 39, new DateTime(1992, 3, 4, 17, 30, 27, 0, DateTimeKind.Unspecified), "Support", "Kane", new DateTime(2023, 5, 31, 11, 29, 28, 0, DateTimeKind.Unspecified), "Palek", "Health Coach III", 90536 },
                    { 40, new DateTime(1995, 3, 13, 22, 51, 36, 0, DateTimeKind.Unspecified), "Sales", "Megan", new DateTime(2020, 6, 3, 23, 1, 21, 0, DateTimeKind.Unspecified), "Degue", "Civil Engineer", 374488 },
                    { 41, new DateTime(1999, 11, 4, 2, 22, 16, 0, DateTimeKind.Unspecified), "Accounting", "Orsola", new DateTime(2021, 9, 16, 23, 28, 7, 0, DateTimeKind.Unspecified), "Fippe", "Nurse", 642787 },
                    { 42, new DateTime(2000, 4, 29, 2, 37, 28, 0, DateTimeKind.Unspecified), "Services", "Turner", new DateTime(2023, 12, 2, 0, 17, 20, 0, DateTimeKind.Unspecified), "Stopforth", "Human Resources Assistant I", 214610 }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "Department", "FirstName", "HireDate", "LastName", "Position", "Salary" },
                values: new object[,]
                {
                    { 43, new DateTime(1987, 6, 9, 8, 22, 9, 0, DateTimeKind.Unspecified), "Research and Development", "Pernell", new DateTime(2019, 10, 4, 15, 24, 53, 0, DateTimeKind.Unspecified), "Tunny", "VP Accounting", 665786 },
                    { 44, new DateTime(1993, 8, 3, 0, 44, 13, 0, DateTimeKind.Unspecified), "Human Resources", "Jess", new DateTime(2024, 4, 30, 9, 18, 48, 0, DateTimeKind.Unspecified), "Hatwells", "Web Designer IV", 625514 },
                    { 45, new DateTime(1997, 10, 5, 18, 21, 37, 0, DateTimeKind.Unspecified), "Services", "Nefen", new DateTime(2021, 5, 19, 21, 18, 50, 0, DateTimeKind.Unspecified), "Daughtry", "Mechanical Systems Engineer", 323671 },
                    { 46, new DateTime(1988, 2, 29, 11, 34, 59, 0, DateTimeKind.Unspecified), "Product Management", "Elinor", new DateTime(2015, 8, 18, 22, 30, 24, 0, DateTimeKind.Unspecified), "Anderer", "Staff Accountant III", 308945 },
                    { 47, new DateTime(1989, 6, 14, 4, 15, 55, 0, DateTimeKind.Unspecified), "Research and Development", "Minny", new DateTime(2024, 6, 4, 23, 31, 33, 0, DateTimeKind.Unspecified), "Coneybeare", "Research Assistant IV", 549919 },
                    { 48, new DateTime(1991, 11, 10, 18, 38, 1, 0, DateTimeKind.Unspecified), "Product Management", "Rem", new DateTime(2023, 12, 21, 17, 37, 43, 0, DateTimeKind.Unspecified), "Copner", "Chemical Engineer", 81344 },
                    { 49, new DateTime(1992, 6, 1, 0, 40, 27, 0, DateTimeKind.Unspecified), "Accounting", "Cyrill", new DateTime(2017, 6, 14, 5, 21, 26, 0, DateTimeKind.Unspecified), "Trudgion", "Senior Developer", 584535 },
                    { 50, new DateTime(1995, 5, 28, 14, 23, 49, 0, DateTimeKind.Unspecified), "Sales", "Lothaire", new DateTime(2022, 12, 27, 23, 43, 19, 0, DateTimeKind.Unspecified), "Mc Cahey", "Accounting Assistant II", 726095 },
                    { 51, new DateTime(1994, 12, 13, 10, 7, 43, 0, DateTimeKind.Unspecified), "Engineering", "Ronny", new DateTime(2016, 5, 22, 1, 39, 54, 0, DateTimeKind.Unspecified), "Albiston", "Dental Hygienist", 506550 },
                    { 52, new DateTime(1987, 4, 11, 2, 57, 54, 0, DateTimeKind.Unspecified), "Marketing", "Osbert", new DateTime(2018, 3, 18, 22, 50, 22, 0, DateTimeKind.Unspecified), "Richold", "Health Coach IV", 440155 },
                    { 53, new DateTime(1992, 3, 7, 7, 27, 20, 0, DateTimeKind.Unspecified), "Support", "Seamus", new DateTime(2020, 5, 8, 22, 16, 51, 0, DateTimeKind.Unspecified), "Wycliffe", "Health Coach II", 554473 },
                    { 54, new DateTime(1993, 6, 28, 5, 45, 20, 0, DateTimeKind.Unspecified), "Services", "Lorilee", new DateTime(2016, 7, 31, 11, 52, 51, 0, DateTimeKind.Unspecified), "Troucher", "Quality Control Specialist", 667107 },
                    { 55, new DateTime(1992, 5, 13, 18, 51, 45, 0, DateTimeKind.Unspecified), "Human Resources", "Gian", new DateTime(2023, 7, 17, 3, 12, 56, 0, DateTimeKind.Unspecified), "Gostall", "Community Outreach Specialist", 306478 },
                    { 56, new DateTime(1995, 10, 2, 23, 42, 21, 0, DateTimeKind.Unspecified), "Human Resources", "Alf", new DateTime(2017, 8, 31, 21, 58, 53, 0, DateTimeKind.Unspecified), "Saffe", "Associate Professor", 732026 },
                    { 57, new DateTime(1998, 3, 26, 20, 16, 2, 0, DateTimeKind.Unspecified), "Legal", "Torey", new DateTime(2023, 10, 5, 1, 27, 29, 0, DateTimeKind.Unspecified), "Durman", "Staff Accountant I", 266775 },
                    { 58, new DateTime(1987, 2, 24, 10, 58, 54, 0, DateTimeKind.Unspecified), "Human Resources", "Nev", new DateTime(2019, 9, 9, 21, 7, 25, 0, DateTimeKind.Unspecified), "Teasey", "Structural Engineer", 471303 },
                    { 59, new DateTime(1986, 5, 25, 22, 12, 53, 0, DateTimeKind.Unspecified), "Sales", "Becki", new DateTime(2024, 1, 9, 17, 55, 39, 0, DateTimeKind.Unspecified), "Duval", "Payment Adjustment Coordinator", 88280 },
                    { 60, new DateTime(1986, 12, 25, 9, 47, 55, 0, DateTimeKind.Unspecified), "Product Management", "Shellysheldon", new DateTime(2018, 4, 17, 9, 55, 34, 0, DateTimeKind.Unspecified), "Swannie", "Speech Pathologist", 462503 },
                    { 61, new DateTime(1990, 6, 18, 22, 34, 46, 0, DateTimeKind.Unspecified), "Product Management", "Welch", new DateTime(2024, 1, 23, 0, 35, 15, 0, DateTimeKind.Unspecified), "Horder", "Clinical Specialist", 38639 },
                    { 62, new DateTime(1990, 2, 15, 11, 31, 32, 0, DateTimeKind.Unspecified), "Sales", "Huntlee", new DateTime(2022, 2, 5, 7, 17, 58, 0, DateTimeKind.Unspecified), "Pond", "Senior Quality Engineer", 658820 },
                    { 63, new DateTime(1990, 7, 29, 23, 37, 16, 0, DateTimeKind.Unspecified), "Accounting", "Freeman", new DateTime(2017, 7, 14, 23, 14, 18, 0, DateTimeKind.Unspecified), "Crutcher", "Administrative Assistant IV", 668694 },
                    { 64, new DateTime(1997, 8, 21, 8, 38, 53, 0, DateTimeKind.Unspecified), "Marketing", "Tressa", new DateTime(2020, 1, 18, 7, 48, 45, 0, DateTimeKind.Unspecified), "Yegorev", "Librarian", 545926 },
                    { 65, new DateTime(1991, 3, 4, 16, 49, 29, 0, DateTimeKind.Unspecified), "Services", "Susannah", new DateTime(2015, 7, 19, 12, 18, 8, 0, DateTimeKind.Unspecified), "Glassman", "Desktop Support Technician", 94925 },
                    { 66, new DateTime(1999, 7, 17, 15, 47, 44, 0, DateTimeKind.Unspecified), "Accounting", "Don", new DateTime(2024, 3, 18, 21, 3, 44, 0, DateTimeKind.Unspecified), "Ibeson", "Technical Writer", 662660 },
                    { 67, new DateTime(1995, 3, 13, 23, 36, 44, 0, DateTimeKind.Unspecified), "Training", "Annice", new DateTime(2017, 8, 8, 22, 58, 21, 0, DateTimeKind.Unspecified), "Brixey", "Biostatistician I", 361616 },
                    { 68, new DateTime(1996, 5, 15, 20, 29, 4, 0, DateTimeKind.Unspecified), "Support", "Millard", new DateTime(2020, 7, 17, 22, 48, 34, 0, DateTimeKind.Unspecified), "Harold", "Automation Specialist IV", 655325 },
                    { 69, new DateTime(1989, 3, 24, 11, 28, 46, 0, DateTimeKind.Unspecified), "Training", "Chauncey", new DateTime(2021, 12, 21, 13, 19, 29, 0, DateTimeKind.Unspecified), "Stampfer", "Junior Executive", 664486 },
                    { 70, new DateTime(1993, 4, 27, 7, 53, 35, 0, DateTimeKind.Unspecified), "Engineering", "Roanna", new DateTime(2022, 3, 13, 23, 34, 16, 0, DateTimeKind.Unspecified), "Brunn", "Administrative Assistant IV", 284589 },
                    { 71, new DateTime(1991, 4, 11, 21, 38, 1, 0, DateTimeKind.Unspecified), "Support", "Joyce", new DateTime(2021, 11, 22, 11, 24, 12, 0, DateTimeKind.Unspecified), "Mahon", "Physical Therapy Assistant", 389039 },
                    { 72, new DateTime(1996, 3, 1, 6, 0, 6, 0, DateTimeKind.Unspecified), "Accounting", "North", new DateTime(2020, 12, 10, 19, 16, 55, 0, DateTimeKind.Unspecified), "Bischof", "Nurse Practicioner", 523191 },
                    { 73, new DateTime(1987, 9, 23, 12, 29, 52, 0, DateTimeKind.Unspecified), "Accounting", "Earle", new DateTime(2015, 1, 29, 5, 39, 12, 0, DateTimeKind.Unspecified), "Stanlick", "Software Engineer III", 167795 },
                    { 74, new DateTime(2000, 4, 4, 16, 53, 12, 0, DateTimeKind.Unspecified), "Legal", "Franz", new DateTime(2023, 5, 12, 8, 36, 8, 0, DateTimeKind.Unspecified), "Addicott", "Programmer II", 609441 },
                    { 75, new DateTime(1991, 5, 12, 5, 56, 41, 0, DateTimeKind.Unspecified), "Marketing", "Thekla", new DateTime(2020, 7, 11, 4, 23, 40, 0, DateTimeKind.Unspecified), "Rosenschein", "Occupational Therapist", 584453 },
                    { 76, new DateTime(1993, 2, 8, 7, 40, 17, 0, DateTimeKind.Unspecified), "Training", "Virgina", new DateTime(2020, 7, 15, 18, 32, 7, 0, DateTimeKind.Unspecified), "de Marco", "Staff Scientist", 88398 },
                    { 77, new DateTime(1991, 5, 3, 14, 49, 56, 0, DateTimeKind.Unspecified), "Support", "Rianon", new DateTime(2022, 8, 28, 0, 14, 44, 0, DateTimeKind.Unspecified), "Glazier", "Human Resources Assistant III", 45833 },
                    { 78, new DateTime(1996, 2, 24, 8, 14, 3, 0, DateTimeKind.Unspecified), "Services", "Witty", new DateTime(2016, 5, 19, 22, 49, 36, 0, DateTimeKind.Unspecified), "Puddephatt", "Actuary", 337322 },
                    { 79, new DateTime(1991, 1, 2, 11, 29, 6, 0, DateTimeKind.Unspecified), "Sales", "Tris", new DateTime(2017, 11, 4, 9, 43, 19, 0, DateTimeKind.Unspecified), "Desesquelle", "Paralegal", 109629 },
                    { 80, new DateTime(1988, 10, 16, 15, 25, 49, 0, DateTimeKind.Unspecified), "Accounting", "Constancy", new DateTime(2016, 10, 28, 13, 2, 59, 0, DateTimeKind.Unspecified), "Corneliussen", "Pharmacist", 362586 },
                    { 81, new DateTime(1988, 2, 7, 17, 1, 38, 0, DateTimeKind.Unspecified), "Support", "Analiese", new DateTime(2023, 1, 27, 22, 47, 41, 0, DateTimeKind.Unspecified), "Antognoni", "Environmental Specialist", 85934 },
                    { 82, new DateTime(1994, 7, 1, 2, 46, 5, 0, DateTimeKind.Unspecified), "Human Resources", "Elisabetta", new DateTime(2015, 3, 11, 23, 33, 21, 0, DateTimeKind.Unspecified), "McGreal", "Registered Nurse", 580690 },
                    { 83, new DateTime(1996, 3, 19, 23, 54, 15, 0, DateTimeKind.Unspecified), "Accounting", "Elvyn", new DateTime(2022, 9, 11, 20, 1, 38, 0, DateTimeKind.Unspecified), "Courtonne", "VP Accounting", 599576 },
                    { 84, new DateTime(1985, 9, 19, 23, 47, 10, 0, DateTimeKind.Unspecified), "Training", "Randy", new DateTime(2018, 6, 25, 18, 18, 48, 0, DateTimeKind.Unspecified), "Nucator", "Software Consultant", 504971 }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "Department", "FirstName", "HireDate", "LastName", "Position", "Salary" },
                values: new object[,]
                {
                    { 85, new DateTime(1997, 11, 21, 6, 34, 28, 0, DateTimeKind.Unspecified), "Engineering", "Ev", new DateTime(2019, 12, 23, 9, 4, 50, 0, DateTimeKind.Unspecified), "Goligly", "Pharmacist", 251543 },
                    { 86, new DateTime(1993, 8, 26, 0, 25, 40, 0, DateTimeKind.Unspecified), "Sales", "Jaquelyn", new DateTime(2019, 6, 6, 3, 44, 55, 0, DateTimeKind.Unspecified), "O'Nolan", "Teacher", 68513 },
                    { 87, new DateTime(1990, 3, 6, 18, 48, 2, 0, DateTimeKind.Unspecified), "Support", "Albertine", new DateTime(2016, 10, 26, 10, 56, 1, 0, DateTimeKind.Unspecified), "Fayer", "Dental Hygienist", 705512 },
                    { 88, new DateTime(1994, 2, 14, 17, 20, 40, 0, DateTimeKind.Unspecified), "Research and Development", "Horst", new DateTime(2023, 10, 4, 15, 21, 46, 0, DateTimeKind.Unspecified), "Fasey", "Information Systems Manager", 685385 },
                    { 89, new DateTime(1987, 4, 29, 18, 38, 5, 0, DateTimeKind.Unspecified), "Product Management", "Quinn", new DateTime(2017, 2, 8, 7, 8, 47, 0, DateTimeKind.Unspecified), "Sheere", "Financial Analyst", 615452 },
                    { 90, new DateTime(1993, 3, 31, 20, 0, 51, 0, DateTimeKind.Unspecified), "Product Management", "Donall", new DateTime(2021, 5, 25, 15, 30, 14, 0, DateTimeKind.Unspecified), "Beers", "Programmer I", 446388 },
                    { 91, new DateTime(1994, 11, 18, 23, 25, 53, 0, DateTimeKind.Unspecified), "Support", "Mayer", new DateTime(2021, 7, 8, 22, 35, 34, 0, DateTimeKind.Unspecified), "Yexley", "Data Coordinator", 739999 },
                    { 92, new DateTime(1990, 10, 31, 4, 29, 19, 0, DateTimeKind.Unspecified), "Marketing", "Kitti", new DateTime(2022, 11, 25, 5, 27, 30, 0, DateTimeKind.Unspecified), "Marklew", "Senior Cost Accountant", 419651 },
                    { 93, new DateTime(1988, 9, 23, 7, 48, 49, 0, DateTimeKind.Unspecified), "Product Management", "Lucila", new DateTime(2017, 3, 1, 16, 23, 24, 0, DateTimeKind.Unspecified), "Marzelli", "Database Administrator III", 448824 },
                    { 94, new DateTime(1997, 9, 23, 20, 43, 9, 0, DateTimeKind.Unspecified), "Product Management", "Lamont", new DateTime(2015, 5, 29, 16, 0, 55, 0, DateTimeKind.Unspecified), "Hordell", "Cost Accountant", 533476 },
                    { 95, new DateTime(1995, 4, 12, 20, 56, 18, 0, DateTimeKind.Unspecified), "Engineering", "Gayleen", new DateTime(2021, 3, 26, 2, 9, 4, 0, DateTimeKind.Unspecified), "Norster", "Structural Engineer", 505049 },
                    { 96, new DateTime(1989, 4, 16, 19, 24, 0, 0, DateTimeKind.Unspecified), "Marketing", "Aurlie", new DateTime(2019, 10, 23, 0, 30, 17, 0, DateTimeKind.Unspecified), "Tripett", "Executive Secretary", 320614 },
                    { 97, new DateTime(1995, 10, 8, 22, 20, 3, 0, DateTimeKind.Unspecified), "Business Development", "Egan", new DateTime(2019, 6, 5, 17, 38, 27, 0, DateTimeKind.Unspecified), "Suddell", "Marketing Manager", 601511 },
                    { 98, new DateTime(1991, 3, 6, 19, 13, 35, 0, DateTimeKind.Unspecified), "Product Management", "Juana", new DateTime(2016, 9, 6, 15, 59, 52, 0, DateTimeKind.Unspecified), "Reuven", "Payment Adjustment Coordinator", 680453 },
                    { 99, new DateTime(1994, 3, 30, 20, 54, 59, 0, DateTimeKind.Unspecified), "Marketing", "Addison", new DateTime(2016, 1, 17, 7, 3, 53, 0, DateTimeKind.Unspecified), "Schneidau", "Pharmacist", 55711 },
                    { 100, new DateTime(1995, 10, 25, 4, 9, 21, 0, DateTimeKind.Unspecified), "Business Development", "Tammy", new DateTime(2019, 9, 18, 10, 25, 3, 0, DateTimeKind.Unspecified), "Demangel", "Account Coordinator", 671083 },
                    { 101, new DateTime(1988, 10, 21, 15, 13, 29, 0, DateTimeKind.Unspecified), "Research and Development", "Gray", new DateTime(2018, 5, 27, 17, 19, 48, 0, DateTimeKind.Unspecified), "Clowes", "Structural Analysis Engineer", 293243 },
                    { 102, new DateTime(1999, 4, 12, 13, 17, 27, 0, DateTimeKind.Unspecified), "Support", "Shell", new DateTime(2020, 10, 12, 15, 50, 33, 0, DateTimeKind.Unspecified), "Heliar", "Nurse Practicioner", 171680 },
                    { 103, new DateTime(1989, 1, 17, 3, 31, 41, 0, DateTimeKind.Unspecified), "Research and Development", "Dorris", new DateTime(2016, 5, 31, 4, 8, 55, 0, DateTimeKind.Unspecified), "De Roeck", "Help Desk Technician", 740567 },
                    { 104, new DateTime(1989, 7, 30, 19, 39, 42, 0, DateTimeKind.Unspecified), "Human Resources", "Bride", new DateTime(2021, 11, 17, 12, 32, 50, 0, DateTimeKind.Unspecified), "Heinle", "Programmer Analyst II", 584510 },
                    { 105, new DateTime(1998, 10, 8, 10, 17, 42, 0, DateTimeKind.Unspecified), "Business Development", "Alleyn", new DateTime(2021, 3, 23, 6, 29, 7, 0, DateTimeKind.Unspecified), "Huske", "Pharmacist", 92201 },
                    { 106, new DateTime(1988, 4, 13, 10, 4, 37, 0, DateTimeKind.Unspecified), "Research and Development", "Neils", new DateTime(2018, 2, 9, 11, 27, 57, 0, DateTimeKind.Unspecified), "Heffernon", "Actuary", 752265 },
                    { 107, new DateTime(1996, 12, 28, 11, 20, 11, 0, DateTimeKind.Unspecified), "Engineering", "Sibylle", new DateTime(2017, 12, 6, 5, 42, 50, 0, DateTimeKind.Unspecified), "Konig", "Editor", 231625 },
                    { 108, new DateTime(1989, 11, 29, 10, 53, 50, 0, DateTimeKind.Unspecified), "Sales", "Sigmund", new DateTime(2019, 2, 21, 1, 48, 53, 0, DateTimeKind.Unspecified), "Swalwel", "Administrative Officer", 268806 },
                    { 109, new DateTime(1986, 6, 4, 14, 58, 35, 0, DateTimeKind.Unspecified), "Human Resources", "Harmon", new DateTime(2022, 4, 18, 4, 58, 24, 0, DateTimeKind.Unspecified), "Ioannou", "Software Test Engineer IV", 343983 },
                    { 110, new DateTime(1994, 12, 21, 23, 10, 54, 0, DateTimeKind.Unspecified), "Accounting", "Geoffrey", new DateTime(2018, 4, 10, 4, 40, 43, 0, DateTimeKind.Unspecified), "Tidmarsh", "Occupational Therapist", 319690 },
                    { 111, new DateTime(1988, 5, 17, 4, 59, 12, 0, DateTimeKind.Unspecified), "Support", "Engracia", new DateTime(2018, 1, 5, 12, 22, 12, 0, DateTimeKind.Unspecified), "Crockford", "Civil Engineer", 421929 },
                    { 112, new DateTime(1998, 10, 27, 17, 14, 23, 0, DateTimeKind.Unspecified), "Training", "Hilton", new DateTime(2016, 4, 5, 0, 54, 0, 0, DateTimeKind.Unspecified), "Folbig", "Associate Professor", 248231 },
                    { 113, new DateTime(1995, 5, 21, 9, 21, 2, 0, DateTimeKind.Unspecified), "Accounting", "Cirillo", new DateTime(2023, 2, 17, 22, 20, 44, 0, DateTimeKind.Unspecified), "Conroy", "VP Sales", 88823 },
                    { 114, new DateTime(1998, 9, 7, 11, 43, 53, 0, DateTimeKind.Unspecified), "Engineering", "Hobard", new DateTime(2021, 9, 30, 14, 10, 9, 0, DateTimeKind.Unspecified), "Izon", "Automation Specialist IV", 466196 },
                    { 115, new DateTime(1989, 12, 21, 11, 2, 55, 0, DateTimeKind.Unspecified), "Business Development", "Joelie", new DateTime(2020, 6, 15, 23, 19, 14, 0, DateTimeKind.Unspecified), "Berre", "Budget/Accounting Analyst I", 638990 },
                    { 116, new DateTime(1990, 7, 13, 2, 19, 36, 0, DateTimeKind.Unspecified), "Business Development", "Darrel", new DateTime(2021, 6, 5, 9, 22, 58, 0, DateTimeKind.Unspecified), "Alcido", "Sales Representative", 423425 },
                    { 117, new DateTime(1999, 1, 26, 12, 13, 39, 0, DateTimeKind.Unspecified), "Business Development", "Ramsay", new DateTime(2024, 8, 6, 9, 10, 49, 0, DateTimeKind.Unspecified), "Aspray", "Senior Sales Associate", 536566 },
                    { 118, new DateTime(1993, 6, 7, 6, 36, 37, 0, DateTimeKind.Unspecified), "Business Development", "Paolina", new DateTime(2019, 3, 7, 14, 26, 29, 0, DateTimeKind.Unspecified), "Seagrove", "Programmer IV", 306872 },
                    { 119, new DateTime(1994, 3, 29, 9, 14, 26, 0, DateTimeKind.Unspecified), "Legal", "Benny", new DateTime(2023, 2, 10, 21, 56, 8, 0, DateTimeKind.Unspecified), "Sawyers", "Senior Developer", 640395 },
                    { 120, new DateTime(1993, 5, 22, 2, 10, 35, 0, DateTimeKind.Unspecified), "Accounting", "Filippo", new DateTime(2019, 7, 21, 20, 38, 2, 0, DateTimeKind.Unspecified), "Suatt", "Project Manager", 578411 },
                    { 121, new DateTime(1996, 7, 13, 3, 59, 1, 0, DateTimeKind.Unspecified), "Accounting", "Filip", new DateTime(2016, 1, 7, 8, 19, 53, 0, DateTimeKind.Unspecified), "Blackett", "Internal Auditor", 252275 },
                    { 122, new DateTime(1999, 7, 1, 22, 9, 16, 0, DateTimeKind.Unspecified), "Marketing", "Omar", new DateTime(2018, 12, 22, 20, 17, 6, 0, DateTimeKind.Unspecified), "Soares", "VP Quality Control", 172647 },
                    { 123, new DateTime(1991, 6, 29, 16, 13, 13, 0, DateTimeKind.Unspecified), "Human Resources", "Kristen", new DateTime(2017, 3, 12, 14, 2, 30, 0, DateTimeKind.Unspecified), "Arnett", "Software Consultant", 694280 },
                    { 124, new DateTime(1986, 6, 18, 7, 42, 56, 0, DateTimeKind.Unspecified), "Accounting", "Ema", new DateTime(2021, 5, 22, 5, 34, 48, 0, DateTimeKind.Unspecified), "Boal", "Administrative Assistant I", 461501 },
                    { 125, new DateTime(1994, 1, 20, 12, 4, 9, 0, DateTimeKind.Unspecified), "Product Management", "Massimo", new DateTime(2019, 3, 15, 23, 41, 10, 0, DateTimeKind.Unspecified), "Shovell", "Accounting Assistant I", 725245 },
                    { 126, new DateTime(1993, 9, 9, 19, 43, 20, 0, DateTimeKind.Unspecified), "Support", "Urbain", new DateTime(2019, 5, 14, 21, 33, 47, 0, DateTimeKind.Unspecified), "Izard", "Information Systems Manager", 62780 }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "Department", "FirstName", "HireDate", "LastName", "Position", "Salary" },
                values: new object[,]
                {
                    { 127, new DateTime(1986, 12, 2, 13, 35, 25, 0, DateTimeKind.Unspecified), "Product Management", "Elisa", new DateTime(2018, 2, 24, 8, 21, 18, 0, DateTimeKind.Unspecified), "Rains", "Operator", 286399 },
                    { 128, new DateTime(1994, 3, 27, 10, 58, 46, 0, DateTimeKind.Unspecified), "Accounting", "Matthiew", new DateTime(2021, 9, 29, 16, 18, 22, 0, DateTimeKind.Unspecified), "Falkinder", "Executive Secretary", 462436 },
                    { 129, new DateTime(1986, 10, 10, 5, 30, 49, 0, DateTimeKind.Unspecified), "Business Development", "Waring", new DateTime(2022, 5, 6, 20, 30, 34, 0, DateTimeKind.Unspecified), "Pepperell", "Desktop Support Technician", 272342 },
                    { 130, new DateTime(1996, 11, 14, 4, 17, 57, 0, DateTimeKind.Unspecified), "Research and Development", "Faith", new DateTime(2020, 8, 4, 2, 11, 2, 0, DateTimeKind.Unspecified), "Bull", "Marketing Manager", 671479 },
                    { 131, new DateTime(1999, 8, 7, 6, 36, 49, 0, DateTimeKind.Unspecified), "Services", "Allsun", new DateTime(2021, 6, 3, 3, 15, 40, 0, DateTimeKind.Unspecified), "Strewthers", "Office Assistant II", 341281 },
                    { 132, new DateTime(1987, 6, 17, 13, 10, 45, 0, DateTimeKind.Unspecified), "Training", "Lory", new DateTime(2023, 4, 22, 18, 35, 42, 0, DateTimeKind.Unspecified), "Rosindill", "Health Coach I", 285596 },
                    { 133, new DateTime(1993, 6, 15, 10, 34, 30, 0, DateTimeKind.Unspecified), "Product Management", "Obidiah", new DateTime(2022, 2, 28, 15, 18, 24, 0, DateTimeKind.Unspecified), "Burdytt", "Quality Engineer", 395789 },
                    { 134, new DateTime(1998, 10, 19, 23, 45, 32, 0, DateTimeKind.Unspecified), "Accounting", "Des", new DateTime(2020, 3, 28, 4, 16, 33, 0, DateTimeKind.Unspecified), "Sperrett", "Help Desk Operator", 122904 },
                    { 135, new DateTime(1999, 6, 22, 18, 23, 1, 0, DateTimeKind.Unspecified), "Accounting", "Carlin", new DateTime(2015, 7, 5, 6, 5, 31, 0, DateTimeKind.Unspecified), "Leaver", "GIS Technical Architect", 448944 },
                    { 136, new DateTime(1997, 9, 11, 22, 32, 11, 0, DateTimeKind.Unspecified), "Business Development", "Omar", new DateTime(2017, 1, 22, 22, 10, 24, 0, DateTimeKind.Unspecified), "Pally", "Senior Developer", 290250 },
                    { 137, new DateTime(1992, 8, 4, 0, 46, 21, 0, DateTimeKind.Unspecified), "Human Resources", "Nettie", new DateTime(2016, 9, 16, 21, 28, 7, 0, DateTimeKind.Unspecified), "Hellwig", "Professor", 220751 },
                    { 138, new DateTime(1992, 10, 15, 2, 25, 28, 0, DateTimeKind.Unspecified), "Accounting", "Georgy", new DateTime(2023, 12, 15, 6, 13, 29, 0, DateTimeKind.Unspecified), "Sweeting", "Structural Analysis Engineer", 192064 },
                    { 139, new DateTime(1988, 3, 12, 22, 52, 50, 0, DateTimeKind.Unspecified), "Sales", "Drona", new DateTime(2018, 3, 9, 3, 29, 2, 0, DateTimeKind.Unspecified), "Vaisey", "Account Coordinator", 130422 },
                    { 140, new DateTime(1986, 2, 10, 7, 10, 7, 0, DateTimeKind.Unspecified), "Research and Development", "Artemus", new DateTime(2020, 9, 19, 11, 20, 23, 0, DateTimeKind.Unspecified), "Labon", "Administrative Assistant IV", 330850 },
                    { 141, new DateTime(1997, 2, 4, 5, 34, 22, 0, DateTimeKind.Unspecified), "Marketing", "Alina", new DateTime(2024, 5, 6, 15, 27, 32, 0, DateTimeKind.Unspecified), "Lodovichi", "Registered Nurse", 195662 },
                    { 142, new DateTime(1986, 1, 26, 17, 18, 45, 0, DateTimeKind.Unspecified), "Human Resources", "Roscoe", new DateTime(2016, 8, 31, 3, 2, 21, 0, DateTimeKind.Unspecified), "Hoopper", "Chemical Engineer", 360419 },
                    { 143, new DateTime(1986, 11, 9, 6, 40, 4, 0, DateTimeKind.Unspecified), "Sales", "Marlin", new DateTime(2018, 2, 6, 20, 8, 41, 0, DateTimeKind.Unspecified), "Hearley", "Help Desk Operator", 521430 },
                    { 144, new DateTime(1992, 3, 19, 22, 38, 53, 0, DateTimeKind.Unspecified), "Accounting", "Gayle", new DateTime(2020, 11, 2, 6, 55, 44, 0, DateTimeKind.Unspecified), "Talks", "Nuclear Power Engineer", 320160 },
                    { 145, new DateTime(1988, 3, 5, 15, 20, 27, 0, DateTimeKind.Unspecified), "Business Development", "Alica", new DateTime(2020, 5, 27, 14, 35, 46, 0, DateTimeKind.Unspecified), "Tayloe", "Physical Therapy Assistant", 230734 },
                    { 146, new DateTime(1993, 7, 25, 11, 5, 10, 0, DateTimeKind.Unspecified), "Marketing", "Sergeant", new DateTime(2016, 2, 20, 7, 40, 30, 0, DateTimeKind.Unspecified), "Vigietti", "Librarian", 266343 },
                    { 147, new DateTime(1988, 7, 15, 23, 59, 11, 0, DateTimeKind.Unspecified), "Human Resources", "Kendricks", new DateTime(2019, 8, 11, 14, 19, 51, 0, DateTimeKind.Unspecified), "Edmunds", "Executive Secretary", 650754 },
                    { 148, new DateTime(1987, 6, 11, 21, 29, 18, 0, DateTimeKind.Unspecified), "Sales", "Howie", new DateTime(2015, 2, 24, 8, 35, 30, 0, DateTimeKind.Unspecified), "Upston", "Community Outreach Specialist", 119621 },
                    { 149, new DateTime(2000, 5, 7, 16, 22, 52, 0, DateTimeKind.Unspecified), "Human Resources", "Dwight", new DateTime(2021, 12, 24, 10, 12, 57, 0, DateTimeKind.Unspecified), "Gambie", "Research Assistant II", 25106 },
                    { 150, new DateTime(1994, 5, 17, 12, 7, 33, 0, DateTimeKind.Unspecified), "Support", "Sacha", new DateTime(2019, 5, 28, 22, 4, 53, 0, DateTimeKind.Unspecified), "Elders", "Information Systems Manager", 148359 },
                    { 151, new DateTime(1986, 6, 24, 11, 51, 13, 0, DateTimeKind.Unspecified), "Marketing", "Andee", new DateTime(2024, 7, 19, 10, 44, 38, 0, DateTimeKind.Unspecified), "Gibbonson", "Recruiter", 184528 },
                    { 152, new DateTime(1989, 1, 25, 13, 33, 13, 0, DateTimeKind.Unspecified), "Human Resources", "Helena", new DateTime(2023, 5, 29, 2, 22, 41, 0, DateTimeKind.Unspecified), "Quickfall", "Accountant II", 166036 },
                    { 153, new DateTime(1988, 12, 11, 19, 36, 50, 0, DateTimeKind.Unspecified), "Business Development", "Janette", new DateTime(2016, 2, 11, 13, 36, 33, 0, DateTimeKind.Unspecified), "Sherlock", "Staff Accountant I", 397586 },
                    { 154, new DateTime(1986, 10, 11, 9, 9, 31, 0, DateTimeKind.Unspecified), "Accounting", "Sherwynd", new DateTime(2022, 8, 30, 1, 29, 33, 0, DateTimeKind.Unspecified), "Hawgood", "Recruiting Manager", 556338 },
                    { 155, new DateTime(1990, 9, 13, 13, 13, 7, 0, DateTimeKind.Unspecified), "Human Resources", "Bastien", new DateTime(2018, 1, 2, 20, 14, 7, 0, DateTimeKind.Unspecified), "Croser", "Information Systems Manager", 572273 },
                    { 156, new DateTime(1998, 5, 27, 15, 20, 37, 0, DateTimeKind.Unspecified), "Marketing", "Rutherford", new DateTime(2024, 3, 14, 9, 20, 4, 0, DateTimeKind.Unspecified), "Furtado", "Geologist II", 306731 },
                    { 157, new DateTime(1990, 9, 26, 6, 33, 13, 0, DateTimeKind.Unspecified), "Sales", "Gwendolen", new DateTime(2015, 7, 5, 17, 56, 45, 0, DateTimeKind.Unspecified), "Swatman", "Junior Executive", 589698 },
                    { 158, new DateTime(1995, 1, 7, 19, 49, 0, 0, DateTimeKind.Unspecified), "Accounting", "Camel", new DateTime(2015, 3, 11, 17, 1, 7, 0, DateTimeKind.Unspecified), "Stradling", "Human Resources Assistant II", 79370 },
                    { 159, new DateTime(1997, 5, 16, 0, 5, 11, 0, DateTimeKind.Unspecified), "Support", "Leisha", new DateTime(2022, 9, 28, 1, 7, 4, 0, DateTimeKind.Unspecified), "Janosevic", "Geologist IV", 699744 },
                    { 160, new DateTime(1990, 2, 11, 4, 51, 39, 0, DateTimeKind.Unspecified), "Accounting", "Yetta", new DateTime(2020, 11, 17, 2, 33, 59, 0, DateTimeKind.Unspecified), "Mazillius", "VP Quality Control", 365947 },
                    { 161, new DateTime(1994, 7, 20, 17, 29, 4, 0, DateTimeKind.Unspecified), "Product Management", "Cherilyn", new DateTime(2015, 7, 17, 2, 30, 36, 0, DateTimeKind.Unspecified), "Danbury", "Analyst Programmer", 226762 },
                    { 162, new DateTime(1986, 1, 19, 9, 41, 1, 0, DateTimeKind.Unspecified), "Support", "Marna", new DateTime(2016, 4, 3, 2, 44, 0, 0, DateTimeKind.Unspecified), "Roskam", "Nuclear Power Engineer", 78983 },
                    { 163, new DateTime(1990, 10, 9, 23, 54, 13, 0, DateTimeKind.Unspecified), "Marketing", "Ginni", new DateTime(2024, 3, 3, 2, 15, 31, 0, DateTimeKind.Unspecified), "Hagger", "Professor", 101348 },
                    { 164, new DateTime(1993, 11, 26, 11, 2, 48, 0, DateTimeKind.Unspecified), "Product Management", "Ashlee", new DateTime(2021, 7, 2, 16, 55, 41, 0, DateTimeKind.Unspecified), "Trowl", "Human Resources Assistant II", 646030 },
                    { 165, new DateTime(2000, 5, 22, 2, 37, 7, 0, DateTimeKind.Unspecified), "Services", "Newton", new DateTime(2015, 2, 14, 14, 9, 34, 0, DateTimeKind.Unspecified), "Keach", "Research Assistant IV", 572021 },
                    { 166, new DateTime(1993, 8, 25, 14, 20, 16, 0, DateTimeKind.Unspecified), "Business Development", "Mord", new DateTime(2022, 4, 28, 17, 20, 48, 0, DateTimeKind.Unspecified), "Thirsk", "Project Manager", 555292 },
                    { 167, new DateTime(1994, 6, 5, 6, 19, 7, 0, DateTimeKind.Unspecified), "Engineering", "Gregoire", new DateTime(2018, 10, 21, 6, 23, 30, 0, DateTimeKind.Unspecified), "Sharphurst", "Geologist III", 452455 },
                    { 168, new DateTime(1991, 9, 4, 1, 55, 29, 0, DateTimeKind.Unspecified), "Engineering", "Aguie", new DateTime(2022, 7, 24, 16, 12, 55, 0, DateTimeKind.Unspecified), "Mostin", "Librarian", 89286 }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "Department", "FirstName", "HireDate", "LastName", "Position", "Salary" },
                values: new object[,]
                {
                    { 169, new DateTime(1991, 5, 13, 18, 27, 55, 0, DateTimeKind.Unspecified), "Research and Development", "Vinnie", new DateTime(2023, 8, 16, 5, 49, 45, 0, DateTimeKind.Unspecified), "Duffil", "Staff Scientist", 640288 },
                    { 170, new DateTime(1989, 9, 18, 2, 39, 53, 0, DateTimeKind.Unspecified), "Services", "Frazer", new DateTime(2015, 11, 11, 21, 44, 39, 0, DateTimeKind.Unspecified), "Manzell", "Biostatistician I", 438374 },
                    { 171, new DateTime(1994, 3, 13, 12, 48, 5, 0, DateTimeKind.Unspecified), "Product Management", "Adora", new DateTime(2020, 10, 14, 15, 48, 18, 0, DateTimeKind.Unspecified), "Briers", "Accountant II", 332880 },
                    { 172, new DateTime(1990, 6, 26, 12, 22, 11, 0, DateTimeKind.Unspecified), "Human Resources", "Johnath", new DateTime(2015, 7, 19, 5, 37, 5, 0, DateTimeKind.Unspecified), "Ludewig", "Physical Therapy Assistant", 178759 },
                    { 173, new DateTime(1997, 8, 26, 4, 1, 25, 0, DateTimeKind.Unspecified), "Marketing", "Isa", new DateTime(2023, 1, 9, 0, 3, 1, 0, DateTimeKind.Unspecified), "Balcon", "VP Product Management", 57569 },
                    { 174, new DateTime(1990, 4, 8, 11, 25, 9, 0, DateTimeKind.Unspecified), "Human Resources", "Nalani", new DateTime(2024, 4, 24, 12, 54, 23, 0, DateTimeKind.Unspecified), "Spark", "Administrative Assistant III", 487787 },
                    { 175, new DateTime(1987, 11, 18, 11, 17, 32, 0, DateTimeKind.Unspecified), "Human Resources", "Giorgi", new DateTime(2020, 5, 5, 8, 18, 23, 0, DateTimeKind.Unspecified), "Curl", "Systems Administrator I", 146582 },
                    { 176, new DateTime(1995, 11, 15, 16, 20, 3, 0, DateTimeKind.Unspecified), "Marketing", "Keefer", new DateTime(2016, 9, 7, 3, 48, 7, 0, DateTimeKind.Unspecified), "Aitchison", "Geological Engineer", 562734 },
                    { 177, new DateTime(1993, 9, 15, 1, 24, 49, 0, DateTimeKind.Unspecified), "Engineering", "Daryle", new DateTime(2016, 8, 6, 17, 24, 35, 0, DateTimeKind.Unspecified), "Barden", "Account Coordinator", 768498 },
                    { 178, new DateTime(1992, 1, 22, 19, 3, 29, 0, DateTimeKind.Unspecified), "Accounting", "Arther", new DateTime(2017, 11, 3, 17, 39, 37, 0, DateTimeKind.Unspecified), "Grover", "Geological Engineer", 604150 },
                    { 179, new DateTime(1996, 11, 17, 15, 0, 38, 0, DateTimeKind.Unspecified), "Training", "Elayne", new DateTime(2023, 4, 26, 2, 17, 18, 0, DateTimeKind.Unspecified), "Nealon", "Financial Analyst", 27020 },
                    { 180, new DateTime(1988, 12, 2, 9, 23, 21, 0, DateTimeKind.Unspecified), "Training", "Archy", new DateTime(2024, 3, 8, 10, 56, 51, 0, DateTimeKind.Unspecified), "Cossey", "Account Coordinator", 434172 },
                    { 181, new DateTime(1993, 4, 1, 18, 30, 40, 0, DateTimeKind.Unspecified), "Research and Development", "Brendin", new DateTime(2024, 2, 29, 8, 58, 33, 0, DateTimeKind.Unspecified), "Seagar", "Assistant Manager", 232503 },
                    { 182, new DateTime(1996, 3, 13, 16, 35, 25, 0, DateTimeKind.Unspecified), "Services", "Marthe", new DateTime(2022, 9, 3, 22, 14, 40, 0, DateTimeKind.Unspecified), "McRamsey", "Financial Advisor", 197174 },
                    { 183, new DateTime(1998, 10, 11, 4, 40, 43, 0, DateTimeKind.Unspecified), "Engineering", "Ferd", new DateTime(2015, 3, 12, 13, 49, 30, 0, DateTimeKind.Unspecified), "Bryns", "Project Manager", 191713 },
                    { 184, new DateTime(1986, 11, 24, 17, 43, 26, 0, DateTimeKind.Unspecified), "Business Development", "Noble", new DateTime(2015, 12, 24, 15, 4, 8, 0, DateTimeKind.Unspecified), "Danilovitch", "Assistant Professor", 26216 },
                    { 185, new DateTime(1988, 2, 16, 7, 59, 16, 0, DateTimeKind.Unspecified), "Marketing", "Legra", new DateTime(2016, 10, 7, 0, 48, 56, 0, DateTimeKind.Unspecified), "Kidwell", "Senior Developer", 264111 },
                    { 186, new DateTime(1998, 11, 23, 20, 24, 33, 0, DateTimeKind.Unspecified), "Accounting", "Joye", new DateTime(2016, 1, 13, 18, 26, 6, 0, DateTimeKind.Unspecified), "Razzell", "Human Resources Manager", 92674 },
                    { 187, new DateTime(1999, 5, 8, 19, 57, 42, 0, DateTimeKind.Unspecified), "Training", "Lacee", new DateTime(2015, 2, 13, 21, 1, 23, 0, DateTimeKind.Unspecified), "Simmank", "Senior Developer", 301243 },
                    { 188, new DateTime(1991, 1, 21, 11, 39, 17, 0, DateTimeKind.Unspecified), "Services", "Puff", new DateTime(2022, 7, 5, 3, 20, 13, 0, DateTimeKind.Unspecified), "Nafzger", "Senior Financial Analyst", 702505 },
                    { 189, new DateTime(1996, 4, 11, 0, 31, 31, 0, DateTimeKind.Unspecified), "Marketing", "Oralla", new DateTime(2019, 4, 3, 9, 49, 5, 0, DateTimeKind.Unspecified), "Fantone", "Accounting Assistant IV", 201796 },
                    { 190, new DateTime(1990, 7, 25, 8, 59, 37, 0, DateTimeKind.Unspecified), "Marketing", "Reed", new DateTime(2017, 4, 13, 6, 19, 35, 0, DateTimeKind.Unspecified), "Cuncliffe", "Office Assistant IV", 514309 },
                    { 191, new DateTime(1987, 11, 9, 23, 25, 19, 0, DateTimeKind.Unspecified), "Legal", "Redford", new DateTime(2015, 1, 1, 2, 36, 17, 0, DateTimeKind.Unspecified), "Bicker", "Chief Design Engineer", 501691 },
                    { 192, new DateTime(1987, 10, 8, 5, 10, 50, 0, DateTimeKind.Unspecified), "Product Management", "Loria", new DateTime(2016, 10, 29, 22, 9, 4, 0, DateTimeKind.Unspecified), "McGloughlin", "Social Worker", 676168 },
                    { 193, new DateTime(1990, 1, 19, 2, 10, 53, 0, DateTimeKind.Unspecified), "Training", "Meggie", new DateTime(2019, 9, 13, 15, 3, 15, 0, DateTimeKind.Unspecified), "Tomsen", "Statistician IV", 662538 },
                    { 194, new DateTime(1997, 6, 2, 0, 4, 47, 0, DateTimeKind.Unspecified), "Services", "Brook", new DateTime(2015, 7, 8, 19, 47, 24, 0, DateTimeKind.Unspecified), "Aimer", "Sales Representative", 606254 },
                    { 195, new DateTime(1994, 7, 23, 2, 52, 57, 0, DateTimeKind.Unspecified), "Accounting", "Kyle", new DateTime(2017, 10, 20, 6, 16, 1, 0, DateTimeKind.Unspecified), "Issacoff", "Project Manager", 269274 },
                    { 196, new DateTime(1989, 9, 4, 1, 53, 7, 0, DateTimeKind.Unspecified), "Services", "Marlo", new DateTime(2017, 7, 15, 16, 49, 11, 0, DateTimeKind.Unspecified), "Henze", "Legal Assistant", 392860 },
                    { 197, new DateTime(1999, 12, 19, 6, 15, 12, 0, DateTimeKind.Unspecified), "Support", "Beatrisa", new DateTime(2017, 11, 19, 17, 55, 37, 0, DateTimeKind.Unspecified), "Kingsbury", "Nurse Practicioner", 339495 },
                    { 198, new DateTime(1995, 5, 23, 22, 56, 38, 0, DateTimeKind.Unspecified), "Training", "Lazarus", new DateTime(2021, 5, 14, 21, 14, 46, 0, DateTimeKind.Unspecified), "Daingerfield", "Account Coordinator", 435134 },
                    { 199, new DateTime(1992, 10, 9, 3, 4, 59, 0, DateTimeKind.Unspecified), "Research and Development", "Carri", new DateTime(2021, 8, 3, 11, 13, 25, 0, DateTimeKind.Unspecified), "Johnson", "Quality Control Specialist", 263605 },
                    { 200, new DateTime(1997, 1, 6, 10, 6, 58, 0, DateTimeKind.Unspecified), "Legal", "Arlena", new DateTime(2020, 10, 24, 8, 44, 37, 0, DateTimeKind.Unspecified), "Copestake", "Director of Sales", 156577 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 200);
        }
    }
}
