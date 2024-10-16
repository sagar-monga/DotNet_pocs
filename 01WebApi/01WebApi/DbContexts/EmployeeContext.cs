using System;
using _01WebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace _01WebApi.DbContexts;

public class EmployeeContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }

    public EmployeeContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>().HasData(
    new Employee(
        "Editha",
        "Tregear",
        622619,
        "Services",
        "Assistant Manager",
        DateTime.Parse("2022-09-08 23:04:01"),
        DateTime.Parse("1993-01-24 09:33:18")
    )
    {
        Id = 1
    },
    new Employee(
        "Torin",
        "Bowller",
        121237,
        "Marketing",
        "Account Executive",
        DateTime.Parse("2022-03-17 01:42:26"),
        DateTime.Parse("1986-10-18 07:26:31")
    )
    {
        Id = 2
    },
    new Employee(
        "Roby",
        "Yglesias",
        307611,
        "Product Management",
        "Administrative Assistant IV",
        DateTime.Parse("2018-03-31 12:59:21"),
        DateTime.Parse("1992-09-09 02:22:59")
    )
    {
        Id = 3
    },
    new Employee(
        "Mord",
        "Lohan",
        216914,
        "Product Management",
        "VP Product Management",
        DateTime.Parse("2015-06-29 19:41:36"),
        DateTime.Parse("1991-01-16 03:52:18")
    )
    {
        Id = 4
    },
    new Employee(
        "Garwin",
        "Westnedge",
        476032,
        "Training",
        "Accountant II",
        DateTime.Parse("2022-10-27 13:30:27"),
        DateTime.Parse("1986-04-17 01:16:25")
    )
    {
        Id = 5
    },
    new Employee(
        "Sena",
        "Tonry",
        289547,
        "Business Development",
        "Mechanical Systems Engineer",
        DateTime.Parse("2015-04-15 15:10:51"),
        DateTime.Parse("1998-02-03 07:23:57")
    )
    {
        Id = 6
    },
    new Employee(
        "Kata",
        "Morena",
        193147,
        "Sales",
        "Librarian",
        DateTime.Parse("2017-11-05 16:52:06"),
        DateTime.Parse("1987-07-30 17:38:47")
    )
    {
        Id = 7
    },
    new Employee(
        "Pyotr",
        "Beeken",
        666275,
        "Support",
        "VP Sales",
        DateTime.Parse("2017-10-16 18:01:47"),
        DateTime.Parse("1988-07-31 09:21:28")
    )
    {
        Id = 8
    },
    new Employee(
        "Caralie",
        "Sammons",
        241963,
        "Product Management",
        "Data Coordinator",
        DateTime.Parse("2019-07-17 11:33:36"),
        DateTime.Parse("1990-02-06 06:51:34")
    )
    {
        Id = 9
    },
    new Employee(
        "Lana",
        "Itzhak",
        353539,
        "Engineering",
        "Human Resources Manager",
        DateTime.Parse("2015-01-31 07:00:52"),
        DateTime.Parse("1994-04-02 11:53:16")
    )
    {
        Id = 10
    },
    new Employee(
        "Giovanni",
        "Purrier",
        110940,
        "Support",
        "Environmental Specialist",
        DateTime.Parse("2018-09-30 10:38:53"),
        DateTime.Parse("1989-09-05 08:25:15")
    )
    {
        Id = 11
    },
    new Employee(
        "Jermaine",
        "Emett",
        442046,
        "Training",
        "Health Coach III",
        DateTime.Parse("2018-06-21 11:59:21"),
        DateTime.Parse("1989-05-13 11:10:10")
    )
    {
        Id = 12
    },
    new Employee(
        "Lionel",
        "Tyers",
        595280,
        "Sales",
        "VP Product Management",
        DateTime.Parse("2023-12-06 13:43:15"),
        DateTime.Parse("1994-06-23 02:20:51")
    )
    {
        Id = 13
    },
    new Employee(
        "Aurea",
        "Ruselin",
        507691,
        "Training",
        "Project Manager",
        DateTime.Parse("2019-09-14 07:51:07"),
        DateTime.Parse("1996-05-12 05:58:56")
    )
    {
        Id = 14
    },
    new Employee(
        "Jard",
        "Snowdon",
        176690,
        "Sales",
        "Executive Secretary",
        DateTime.Parse("2018-07-16 03:16:19"),
        DateTime.Parse("1990-12-26 08:08:33")
    )
    {
        Id = 15
    },
    new Employee(
        "Perle",
        "Keech",
        672589,
        "Sales",
        "Mechanical Systems Engineer",
        DateTime.Parse("2017-06-17 06:41:34"),
        DateTime.Parse("1998-01-07 11:12:43")
    )
    {
        Id = 16
    },
    new Employee(
        "Adriena",
        "Wearne",
        401949,
        "Support",
        "Business Systems Development Analyst",
        DateTime.Parse("2019-08-13 23:59:47"),
        DateTime.Parse("1986-08-10 19:34:15")
    )
    {
        Id = 17
    },
    new Employee(
        "Frayda",
        "Pumphreys",
        614505,
        "Services",
        "Administrative Assistant II",
        DateTime.Parse("2019-01-01 06:00:27"),
        DateTime.Parse("1995-01-19 18:18:13")
    )
    {
        Id = 18
    },
    new Employee(
        "Genevieve",
        "Glackin",
        565013,
        "Research and Development",
        "Editor",
        DateTime.Parse("2022-12-12 23:59:59"),
        DateTime.Parse("1994-06-27 19:46:36")
    )
    {
        Id = 19
    },
    new Employee(
        "Deanna",
        "Denford",
        676940,
        "Research and Development",
        "Geological Engineer",
        DateTime.Parse("2021-03-22 18:45:06"),
        DateTime.Parse("1989-01-09 07:29:00")
    )
    {
        Id = 20
    },
    new Employee(
        "Cameron",
        "Maplethorpe",
        721453,
        "Human Resources",
        "Assistant Professor",
        DateTime.Parse("2022-07-07 21:47:49"),
        DateTime.Parse("2000-05-22 08:42:53")
    )
    {
        Id = 21
    },
    new Employee(
        "Hobey",
        "Vedyashkin",
        443392,
        "Marketing",
        "Computer Systems Analyst IV",
        DateTime.Parse("2017-03-28 15:37:45"),
        DateTime.Parse("1996-03-13 12:07:50")
    )
    {
        Id = 22
    },
    new Employee(
        "Donetta",
        "Aysh",
        325659,
        "Human Resources",
        "Analog Circuit Design manager",
        DateTime.Parse("2020-01-16 20:09:40"),
        DateTime.Parse("1990-05-26 17:25:41")
    )
    {
        Id = 23
    },
    new Employee(
        "Jaquenette",
        "Tennock",
        757700,
        "Research and Development",
        "Senior Editor",
        DateTime.Parse("2023-10-03 03:14:58"),
        DateTime.Parse("1997-02-04 12:19:40")
    )
    {
        Id = 24
    },
    new Employee(
        "Barr",
        "Gleed",
        509951,
        "Services",
        "VP Product Management",
        DateTime.Parse("2017-11-01 18:01:34"),
        DateTime.Parse("1991-02-15 14:47:54")
    )
    {
        Id = 25
    },
    new Employee(
        "Leonhard",
        "Hearsum",
        302130,
        "Human Resources",
        "Assistant Media Planner",
        DateTime.Parse("2016-09-16 06:42:28"),
        DateTime.Parse("1996-05-17 19:34:56")
    )
    {
        Id = 26
    },
    new Employee(
        "Nathanial",
        "Start",
        674286,
        "Marketing",
        "Statistician IV",
        DateTime.Parse("2024-07-07 12:21:05"),
        DateTime.Parse("1990-01-05 19:38:39")
    )
    {
        Id = 27
    },
    new Employee(
        "Dani",
        "Brendish",
        339585,
        "Marketing",
        "Structural Engineer",
        DateTime.Parse("2017-02-12 08:44:51"),
        DateTime.Parse("1990-01-18 04:25:22")
    )
    {
        Id = 28
    },
    new Employee(
        "Tobin",
        "Wolland",
        247974,
        "Product Management",
        "Geologist II",
        DateTime.Parse("2018-09-29 13:48:14"),
        DateTime.Parse("1998-03-11 19:23:52")
    )
    {
        Id = 29
    },
    new Employee(
        "Demetre",
        "Binder",
        753453,
        "Legal",
        "Design Engineer",
        DateTime.Parse("2017-05-16 23:27:04"),
        DateTime.Parse("1997-02-05 17:36:20")
    )
    {
        Id = 30
    },
    new Employee(
        "Hebert",
        "Skoof",
        604185,
        "Sales",
        "Web Designer III",
        DateTime.Parse("2023-12-08 20:44:08"),
        DateTime.Parse("1999-06-17 05:12:59")
    )
    {
        Id = 31
    },
    new Employee(
        "Inesita",
        "Balm",
        685358,
        "Engineering",
        "Chief Design Engineer",
        DateTime.Parse("2015-10-22 10:55:42"),
        DateTime.Parse("1986-11-18 03:20:26")
    )
    {
        Id = 32
    },
    new Employee(
        "Arlana",
        "Oakeby",
        526989,
        "Training",
        "Data Coordinator",
        DateTime.Parse("2022-05-07 07:50:49"),
        DateTime.Parse("1997-08-27 07:27:05")
    )
    {
        Id = 33
    },
    new Employee(
        "Codi",
        "Nan Carrow",
        593254,
        "Accounting",
        "Media Manager I",
        DateTime.Parse("2018-06-09 16:57:45"),
        DateTime.Parse("1991-04-15 09:29:59")
    )
    {
        Id = 34
    },
    new Employee(
        "Bear",
        "Lampe",
        200031,
        "Training",
        "Director of Sales",
        DateTime.Parse("2020-08-19 19:33:54"),
        DateTime.Parse("1992-12-21 21:36:41")
    )
    {
        Id = 35
    },
    new Employee(
        "Hartley",
        "Tudgay",
        241301,
        "Research and Development",
        "Physical Therapy Assistant",
        DateTime.Parse("2017-07-22 06:12:51"),
        DateTime.Parse("1986-09-17 10:33:47")
    )
    {
        Id = 36
    },
    new Employee(
        "Bette",
        "Erik",
        646311,
        "Legal",
        "VP Sales",
        DateTime.Parse("2018-07-11 17:49:57"),
        DateTime.Parse("1988-08-15 17:04:35")
    )
    {
        Id = 37
    },
    new Employee(
        "Ambrosio",
        "Howitt",
        28351,
        "Training",
        "Tax Accountant",
        DateTime.Parse("2023-11-03 18:24:25"),
        DateTime.Parse("1994-04-08 17:18:26")
    )
    {
        Id = 38
    },
    new Employee(
        "Kane",
        "Palek",
        90536,
        "Support",
        "Health Coach III",
        DateTime.Parse("2023-05-31 11:29:28"),
        DateTime.Parse("1992-03-04 17:30:27")
    )
    {
        Id = 39
    },
    new Employee(
        "Megan",
        "Degue",
        374488,
        "Sales",
        "Civil Engineer",
        DateTime.Parse("2020-06-03 23:01:21"),
        DateTime.Parse("1995-03-13 22:51:36")
    )
    {
        Id = 40
    },
    new Employee(
        "Orsola",
        "Fippe",
        642787,
        "Accounting",
        "Nurse",
        DateTime.Parse("2021-09-16 23:28:07"),
        DateTime.Parse("1999-11-04 02:22:16")
    )
    {
        Id = 41
    },
    new Employee(
        "Turner",
        "Stopforth",
        214610,
        "Services",
        "Human Resources Assistant I",
        DateTime.Parse("2023-12-02 00:17:20"),
        DateTime.Parse("2000-04-29 02:37:28")
    )
    {
        Id = 42
    },
    new Employee(
        "Pernell",
        "Tunny",
        665786,
        "Research and Development",
        "VP Accounting",
        DateTime.Parse("2019-10-04 15:24:53"),
        DateTime.Parse("1987-06-09 08:22:09")
    )
    {
        Id = 43
    },
    new Employee(
        "Jess",
        "Hatwells",
        625514,
        "Human Resources",
        "Web Designer IV",
        DateTime.Parse("2024-04-30 09:18:48"),
        DateTime.Parse("1993-08-03 00:44:13")
    )
    {
        Id = 44
    },
    new Employee(
        "Nefen",
        "Daughtry",
        323671,
        "Services",
        "Mechanical Systems Engineer",
        DateTime.Parse("2021-05-19 21:18:50"),
        DateTime.Parse("1997-10-05 18:21:37")
    )
    {
        Id = 45
    },
    new Employee(
        "Elinor",
        "Anderer",
        308945,
        "Product Management",
        "Staff Accountant III",
        DateTime.Parse("2015-08-18 22:30:24"),
        DateTime.Parse("1988-02-29 11:34:59")
    )
    {
        Id = 46
    },
    new Employee(
        "Minny",
        "Coneybeare",
        549919,
        "Research and Development",
        "Research Assistant IV",
        DateTime.Parse("2024-06-04 23:31:33"),
        DateTime.Parse("1989-06-14 04:15:55")
    )
    {
        Id = 47
    },
    new Employee(
        "Rem",
        "Copner",
        81344,
        "Product Management",
        "Chemical Engineer",
        DateTime.Parse("2023-12-21 17:37:43"),
        DateTime.Parse("1991-11-10 18:38:01")
    )
    {
        Id = 48
    },
    new Employee(
        "Cyrill",
        "Trudgion",
        584535,
        "Accounting",
        "Senior Developer",
        DateTime.Parse("2017-06-14 05:21:26"),
        DateTime.Parse("1992-06-01 00:40:27")
    )
    {
        Id = 49
    },
    new Employee(
        "Lothaire",
        "Mc Cahey",
        726095,
        "Sales",
        "Accounting Assistant II",
        DateTime.Parse("2022-12-27 23:43:19"),
        DateTime.Parse("1995-05-28 14:23:49")
    )
    {
        Id = 50
    },
    new Employee(
        "Ronny",
        "Albiston",
        506550,
        "Engineering",
        "Dental Hygienist",
        DateTime.Parse("2016-05-22 01:39:54"),
        DateTime.Parse("1994-12-13 10:07:43")
    )
    {
        Id = 51
    },
    new Employee(
        "Osbert",
        "Richold",
        440155,
        "Marketing",
        "Health Coach IV",
        DateTime.Parse("2018-03-18 22:50:22"),
        DateTime.Parse("1987-04-11 02:57:54")
    )
    {
        Id = 52
    },
    new Employee(
        "Seamus",
        "Wycliffe",
        554473,
        "Support",
        "Health Coach II",
        DateTime.Parse("2020-05-08 22:16:51"),
        DateTime.Parse("1992-03-07 07:27:20")
    )
    {
        Id = 53
    },
    new Employee(
        "Lorilee",
        "Troucher",
        667107,
        "Services",
        "Quality Control Specialist",
        DateTime.Parse("2016-07-31 11:52:51"),
        DateTime.Parse("1993-06-28 05:45:20")
    )
    {
        Id = 54
    },
    new Employee(
        "Gian",
        "Gostall",
        306478,
        "Human Resources",
        "Community Outreach Specialist",
        DateTime.Parse("2023-07-17 03:12:56"),
        DateTime.Parse("1992-05-13 18:51:45")
    )
    {
        Id = 55
    },
    new Employee(
        "Alf",
        "Saffe",
        732026,
        "Human Resources",
        "Associate Professor",
        DateTime.Parse("2017-08-31 21:58:53"),
        DateTime.Parse("1995-10-02 23:42:21")
    )
    {
        Id = 56
    },
    new Employee(
        "Torey",
        "Durman",
        266775,
        "Legal",
        "Staff Accountant I",
        DateTime.Parse("2023-10-05 01:27:29"),
        DateTime.Parse("1998-03-26 20:16:02")
    )
    {
        Id = 57
    },
    new Employee(
        "Nev",
        "Teasey",
        471303,
        "Human Resources",
        "Structural Engineer",
        DateTime.Parse("2019-09-09 21:07:25"),
        DateTime.Parse("1987-02-24 10:58:54")
    )
    {
        Id = 58
    },
    new Employee(
        "Becki",
        "Duval",
        88280,
        "Sales",
        "Payment Adjustment Coordinator",
        DateTime.Parse("2024-01-09 17:55:39"),
        DateTime.Parse("1986-05-25 22:12:53")
    )
    {
        Id = 59
    },
    new Employee(
        "Shellysheldon",
        "Swannie",
        462503,
        "Product Management",
        "Speech Pathologist",
        DateTime.Parse("2018-04-17 09:55:34"),
        DateTime.Parse("1986-12-25 09:47:55")
    )
    {
        Id = 60
    },
    new Employee(
        "Welch",
        "Horder",
        38639,
        "Product Management",
        "Clinical Specialist",
        DateTime.Parse("2024-01-23 00:35:15"),
        DateTime.Parse("1990-06-18 22:34:46")
    )
    {
        Id = 61
    },
    new Employee(
        "Huntlee",
        "Pond",
        658820,
        "Sales",
        "Senior Quality Engineer",
        DateTime.Parse("2022-02-05 07:17:58"),
        DateTime.Parse("1990-02-15 11:31:32")
    )
    {
        Id = 62
    },
    new Employee(
        "Freeman",
        "Crutcher",
        668694,
        "Accounting",
        "Administrative Assistant IV",
        DateTime.Parse("2017-07-14 23:14:18"),
        DateTime.Parse("1990-07-29 23:37:16")
    )
    {
        Id = 63
    },
    new Employee(
        "Tressa",
        "Yegorev",
        545926,
        "Marketing",
        "Librarian",
        DateTime.Parse("2020-01-18 07:48:45"),
        DateTime.Parse("1997-08-21 08:38:53")
    )
    {
        Id = 64
    },
    new Employee(
        "Susannah",
        "Glassman",
        94925,
        "Services",
        "Desktop Support Technician",
        DateTime.Parse("2015-07-19 12:18:08"),
        DateTime.Parse("1991-03-04 16:49:29")
    )
    {
        Id = 65
    },
    new Employee(
        "Don",
        "Ibeson",
        662660,
        "Accounting",
        "Technical Writer",
        DateTime.Parse("2024-03-18 21:03:44"),
        DateTime.Parse("1999-07-17 15:47:44")
    )
    {
        Id = 66
    },
    new Employee(
        "Annice",
        "Brixey",
        361616,
        "Training",
        "Biostatistician I",
        DateTime.Parse("2017-08-08 22:58:21"),
        DateTime.Parse("1995-03-13 23:36:44")
    )
    {
        Id = 67
    },
    new Employee(
        "Millard",
        "Harold",
        655325,
        "Support",
        "Automation Specialist IV",
        DateTime.Parse("2020-07-17 22:48:34"),
        DateTime.Parse("1996-05-15 20:29:04")
    )
    {
        Id = 68
    },
    new Employee(
        "Chauncey",
        "Stampfer",
        664486,
        "Training",
        "Junior Executive",
        DateTime.Parse("2021-12-21 13:19:29"),
        DateTime.Parse("1989-03-24 11:28:46")
    )
    {
        Id = 69
    },
    new Employee(
        "Roanna",
        "Brunn",
        284589,
        "Engineering",
        "Administrative Assistant IV",
        DateTime.Parse("2022-03-13 23:34:16"),
        DateTime.Parse("1993-04-27 07:53:35")
    )
    {
        Id = 70
    },
    new Employee(
        "Joyce",
        "Mahon",
        389039,
        "Support",
        "Physical Therapy Assistant",
        DateTime.Parse("2021-11-22 11:24:12"),
        DateTime.Parse("1991-04-11 21:38:01")
    )
    {
        Id = 71
    },
    new Employee(
        "North",
        "Bischof",
        523191,
        "Accounting",
        "Nurse Practicioner",
        DateTime.Parse("2020-12-10 19:16:55"),
        DateTime.Parse("1996-03-01 06:00:06")
    )
    {
        Id = 72
    },
    new Employee(
        "Earle",
        "Stanlick",
        167795,
        "Accounting",
        "Software Engineer III",
        DateTime.Parse("2015-01-29 05:39:12"),
        DateTime.Parse("1987-09-23 12:29:52")
    )
    {
        Id = 73
    },
    new Employee(
        "Franz",
        "Addicott",
        609441,
        "Legal",
        "Programmer II",
        DateTime.Parse("2023-05-12 08:36:08"),
        DateTime.Parse("2000-04-04 16:53:12")
    )
    {
        Id = 74
    },
    new Employee(
        "Thekla",
        "Rosenschein",
        584453,
        "Marketing",
        "Occupational Therapist",
        DateTime.Parse("2020-07-11 04:23:40"),
        DateTime.Parse("1991-05-12 05:56:41")
    )
    {
        Id = 75
    },
    new Employee(
        "Virgina",
        "de Marco",
        88398,
        "Training",
        "Staff Scientist",
        DateTime.Parse("2020-07-15 18:32:07"),
        DateTime.Parse("1993-02-08 07:40:17")
    )
    {
        Id = 76
    },
    new Employee(
        "Rianon",
        "Glazier",
        45833,
        "Support",
        "Human Resources Assistant III",
        DateTime.Parse("2022-08-28 00:14:44"),
        DateTime.Parse("1991-05-03 14:49:56")
    )
    {
        Id = 77
    },
    new Employee(
        "Witty",
        "Puddephatt",
        337322,
        "Services",
        "Actuary",
        DateTime.Parse("2016-05-19 22:49:36"),
        DateTime.Parse("1996-02-24 08:14:03")
    )
    {
        Id = 78
    },
    new Employee(
        "Tris",
        "Desesquelle",
        109629,
        "Sales",
        "Paralegal",
        DateTime.Parse("2017-11-04 09:43:19"),
        DateTime.Parse("1991-01-02 11:29:06")
    )
    {
        Id = 79
    },
    new Employee(
        "Constancy",
        "Corneliussen",
        362586,
        "Accounting",
        "Pharmacist",
        DateTime.Parse("2016-10-28 13:02:59"),
        DateTime.Parse("1988-10-16 15:25:49")
    )
    {
        Id = 80
    },
    new Employee(
        "Analiese",
        "Antognoni",
        85934,
        "Support",
        "Environmental Specialist",
        DateTime.Parse("2023-01-27 22:47:41"),
        DateTime.Parse("1988-02-07 17:01:38")
    )
    {
        Id = 81
    },
    new Employee(
        "Elisabetta",
        "McGreal",
        580690,
        "Human Resources",
        "Registered Nurse",
        DateTime.Parse("2015-03-11 23:33:21"),
        DateTime.Parse("1994-07-01 02:46:05")
    )
    {
        Id = 82
    },
    new Employee(
        "Elvyn",
        "Courtonne",
        599576,
        "Accounting",
        "VP Accounting",
        DateTime.Parse("2022-09-11 20:01:38"),
        DateTime.Parse("1996-03-19 23:54:15")
    )
    {
        Id = 83
    },
    new Employee(
        "Randy",
        "Nucator",
        504971,
        "Training",
        "Software Consultant",
        DateTime.Parse("2018-06-25 18:18:48"),
        DateTime.Parse("1985-09-19 23:47:10")
    )
    {
        Id = 84
    },
    new Employee(
        "Ev",
        "Goligly",
        251543,
        "Engineering",
        "Pharmacist",
        DateTime.Parse("2019-12-23 09:04:50"),
        DateTime.Parse("1997-11-21 06:34:28")
    )
    {
        Id = 85
    },
    new Employee(
        "Jaquelyn",
        "O'Nolan",
        68513,
        "Sales",
        "Teacher",
        DateTime.Parse("2019-06-06 03:44:55"),
        DateTime.Parse("1993-08-26 00:25:40")
    )
    {
        Id = 86
    },
    new Employee(
        "Albertine",
        "Fayer",
        705512,
        "Support",
        "Dental Hygienist",
        DateTime.Parse("2016-10-26 10:56:01"),
        DateTime.Parse("1990-03-06 18:48:02")
    )
    {
        Id = 87
    },
    new Employee(
        "Horst",
        "Fasey",
        685385,
        "Research and Development",
        "Information Systems Manager",
        DateTime.Parse("2023-10-04 15:21:46"),
        DateTime.Parse("1994-02-14 17:20:40")
    )
    {
        Id = 88
    },
    new Employee(
        "Quinn",
        "Sheere",
        615452,
        "Product Management",
        "Financial Analyst",
        DateTime.Parse("2017-02-08 07:08:47"),
        DateTime.Parse("1987-04-29 18:38:05")
    )
    {
        Id = 89
    },
    new Employee(
        "Donall",
        "Beers",
        446388,
        "Product Management",
        "Programmer I",
        DateTime.Parse("2021-05-25 15:30:14"),
        DateTime.Parse("1993-03-31 20:00:51")
    )
    {
        Id = 90
    },
    new Employee(
        "Mayer",
        "Yexley",
        739999,
        "Support",
        "Data Coordinator",
        DateTime.Parse("2021-07-08 22:35:34"),
        DateTime.Parse("1994-11-18 23:25:53")
    )
    {
        Id = 91
    },
    new Employee(
        "Kitti",
        "Marklew",
        419651,
        "Marketing",
        "Senior Cost Accountant",
        DateTime.Parse("2022-11-25 05:27:30"),
        DateTime.Parse("1990-10-31 04:29:19")
    )
    {
        Id = 92
    },
    new Employee(
        "Lucila",
        "Marzelli",
        448824,
        "Product Management",
        "Database Administrator III",
        DateTime.Parse("2017-03-01 16:23:24"),
        DateTime.Parse("1988-09-23 07:48:49")
    )
    {
        Id = 93
    },
    new Employee(
        "Lamont",
        "Hordell",
        533476,
        "Product Management",
        "Cost Accountant",
        DateTime.Parse("2015-05-29 16:00:55"),
        DateTime.Parse("1997-09-23 20:43:09")
    )
    {
        Id = 94
    },
    new Employee(
        "Gayleen",
        "Norster",
        505049,
        "Engineering",
        "Structural Engineer",
        DateTime.Parse("2021-03-26 02:09:04"),
        DateTime.Parse("1995-04-12 20:56:18")
    )
    {
        Id = 95
    },
    new Employee(
        "Aurlie",
        "Tripett",
        320614,
        "Marketing",
        "Executive Secretary",
        DateTime.Parse("2019-10-23 00:30:17"),
        DateTime.Parse("1989-04-16 19:24:00")
    )
    {
        Id = 96
    },
    new Employee(
        "Egan",
        "Suddell",
        601511,
        "Business Development",
        "Marketing Manager",
        DateTime.Parse("2019-06-05 17:38:27"),
        DateTime.Parse("1995-10-08 22:20:03")
    )
    {
        Id = 97
    },
    new Employee(
        "Juana",
        "Reuven",
        680453,
        "Product Management",
        "Payment Adjustment Coordinator",
        DateTime.Parse("2016-09-06 15:59:52"),
        DateTime.Parse("1991-03-06 19:13:35")
    )
    {
        Id = 98
    },
    new Employee(
        "Addison",
        "Schneidau",
        55711,
        "Marketing",
        "Pharmacist",
        DateTime.Parse("2016-01-17 07:03:53"),
        DateTime.Parse("1994-03-30 20:54:59")
    )
    {
        Id = 99
    },
    new Employee(
        "Tammy",
        "Demangel",
        671083,
        "Business Development",
        "Account Coordinator",
        DateTime.Parse("2019-09-18 10:25:03"),
        DateTime.Parse("1995-10-25 04:09:21")
    )
    {
        Id = 100
    },
    new Employee(
        "Gray",
        "Clowes",
        293243,
        "Research and Development",
        "Structural Analysis Engineer",
        DateTime.Parse("2018-05-27 17:19:48"),
        DateTime.Parse("1988-10-21 15:13:29")
    )
    {
        Id = 101
    },
    new Employee(
        "Shell",
        "Heliar",
        171680,
        "Support",
        "Nurse Practicioner",
        DateTime.Parse("2020-10-12 15:50:33"),
        DateTime.Parse("1999-04-12 13:17:27")
    )
    {
        Id = 102
    },
    new Employee(
        "Dorris",
        "De Roeck",
        740567,
        "Research and Development",
        "Help Desk Technician",
        DateTime.Parse("2016-05-31 04:08:55"),
        DateTime.Parse("1989-01-17 03:31:41")
    )
    {
        Id = 103
    },
    new Employee(
        "Bride",
        "Heinle",
        584510,
        "Human Resources",
        "Programmer Analyst II",
        DateTime.Parse("2021-11-17 12:32:50"),
        DateTime.Parse("1989-07-30 19:39:42")
    )
    {
        Id = 104
    },
    new Employee(
        "Alleyn",
        "Huske",
        92201,
        "Business Development",
        "Pharmacist",
        DateTime.Parse("2021-03-23 06:29:07"),
        DateTime.Parse("1998-10-08 10:17:42")
    )
    {
        Id = 105
    },
    new Employee(
        "Neils",
        "Heffernon",
        752265,
        "Research and Development",
        "Actuary",
        DateTime.Parse("2018-02-09 11:27:57"),
        DateTime.Parse("1988-04-13 10:04:37")
    )
    {
        Id = 106
    },
    new Employee(
        "Sibylle",
        "Konig",
        231625,
        "Engineering",
        "Editor",
        DateTime.Parse("2017-12-06 05:42:50"),
        DateTime.Parse("1996-12-28 11:20:11")
    )
    {
        Id = 107
    },
    new Employee(
        "Sigmund",
        "Swalwel",
        268806,
        "Sales",
        "Administrative Officer",
        DateTime.Parse("2019-02-21 01:48:53"),
        DateTime.Parse("1989-11-29 10:53:50")
    )
    {
        Id = 108
    },
    new Employee(
        "Harmon",
        "Ioannou",
        343983,
        "Human Resources",
        "Software Test Engineer IV",
        DateTime.Parse("2022-04-18 04:58:24"),
        DateTime.Parse("1986-06-04 14:58:35")
    )
    {
        Id = 109
    },
    new Employee(
        "Geoffrey",
        "Tidmarsh",
        319690,
        "Accounting",
        "Occupational Therapist",
        DateTime.Parse("2018-04-10 04:40:43"),
        DateTime.Parse("1994-12-21 23:10:54")
    )
    {
        Id = 110
    },
    new Employee(
        "Engracia",
        "Crockford",
        421929,
        "Support",
        "Civil Engineer",
        DateTime.Parse("2018-01-05 12:22:12"),
        DateTime.Parse("1988-05-17 04:59:12")
    )
    {
        Id = 111
    },
    new Employee(
        "Hilton",
        "Folbig",
        248231,
        "Training",
        "Associate Professor",
        DateTime.Parse("2016-04-05 00:54:00"),
        DateTime.Parse("1998-10-27 17:14:23")
    )
    {
        Id = 112
    },
    new Employee(
        "Cirillo",
        "Conroy",
        88823,
        "Accounting",
        "VP Sales",
        DateTime.Parse("2023-02-17 22:20:44"),
        DateTime.Parse("1995-05-21 09:21:02")
    )
    {
        Id = 113
    },
    new Employee(
        "Hobard",
        "Izon",
        466196,
        "Engineering",
        "Automation Specialist IV",
        DateTime.Parse("2021-09-30 14:10:09"),
        DateTime.Parse("1998-09-07 11:43:53")
    )
    {
        Id = 114
    },
    new Employee(
        "Joelie",
        "Berre",
        638990,
        "Business Development",
        "Budget/Accounting Analyst I",
        DateTime.Parse("2020-06-15 23:19:14"),
        DateTime.Parse("1989-12-21 11:02:55")
    )
    {
        Id = 115
    },
    new Employee(
        "Darrel",
        "Alcido",
        423425,
        "Business Development",
        "Sales Representative",
        DateTime.Parse("2021-06-05 09:22:58"),
        DateTime.Parse("1990-07-13 02:19:36")
    )
    {
        Id = 116
    },
    new Employee(
        "Ramsay",
        "Aspray",
        536566,
        "Business Development",
        "Senior Sales Associate",
        DateTime.Parse("2024-08-06 09:10:49"),
        DateTime.Parse("1999-01-26 12:13:39")
    )
    {
        Id = 117
    },
    new Employee(
        "Paolina",
        "Seagrove",
        306872,
        "Business Development",
        "Programmer IV",
        DateTime.Parse("2019-03-07 14:26:29"),
        DateTime.Parse("1993-06-07 06:36:37")
    )
    {
        Id = 118
    },
    new Employee(
        "Benny",
        "Sawyers",
        640395,
        "Legal",
        "Senior Developer",
        DateTime.Parse("2023-02-10 21:56:08"),
        DateTime.Parse("1994-03-29 09:14:26")
    )
    {
        Id = 119
    },
    new Employee(
        "Filippo",
        "Suatt",
        578411,
        "Accounting",
        "Project Manager",
        DateTime.Parse("2019-07-21 20:38:02"),
        DateTime.Parse("1993-05-22 02:10:35")
    )
    {
        Id = 120
    },
    new Employee(
        "Filip",
        "Blackett",
        252275,
        "Accounting",
        "Internal Auditor",
        DateTime.Parse("2016-01-07 08:19:53"),
        DateTime.Parse("1996-07-13 03:59:01")
    )
    {
        Id = 121
    },
    new Employee(
        "Omar",
        "Soares",
        172647,
        "Marketing",
        "VP Quality Control",
        DateTime.Parse("2018-12-22 20:17:06"),
        DateTime.Parse("1999-07-01 22:09:16")
    )
    {
        Id = 122
    },
    new Employee(
        "Kristen",
        "Arnett",
        694280,
        "Human Resources",
        "Software Consultant",
        DateTime.Parse("2017-03-12 14:02:30"),
        DateTime.Parse("1991-06-29 16:13:13")
    )
    {
        Id = 123
    },
    new Employee(
        "Ema",
        "Boal",
        461501,
        "Accounting",
        "Administrative Assistant I",
        DateTime.Parse("2021-05-22 05:34:48"),
        DateTime.Parse("1986-06-18 07:42:56")
    )
    {
        Id = 124
    },
    new Employee(
        "Massimo",
        "Shovell",
        725245,
        "Product Management",
        "Accounting Assistant I",
        DateTime.Parse("2019-03-15 23:41:10"),
        DateTime.Parse("1994-01-20 12:04:09")
    )
    {
        Id = 125
    },
    new Employee(
        "Urbain",
        "Izard",
        62780,
        "Support",
        "Information Systems Manager",
        DateTime.Parse("2019-05-14 21:33:47"),
        DateTime.Parse("1993-09-09 19:43:20")
    )
    {
        Id = 126
    },
    new Employee(
        "Elisa",
        "Rains",
        286399,
        "Product Management",
        "Operator",
        DateTime.Parse("2018-02-24 08:21:18"),
        DateTime.Parse("1986-12-02 13:35:25")
    )
    {
        Id = 127
    },
    new Employee(
        "Matthiew",
        "Falkinder",
        462436,
        "Accounting",
        "Executive Secretary",
        DateTime.Parse("2021-09-29 16:18:22"),
        DateTime.Parse("1994-03-27 10:58:46")
    )
    {
        Id = 128
    },
    new Employee(
        "Waring",
        "Pepperell",
        272342,
        "Business Development",
        "Desktop Support Technician",
        DateTime.Parse("2022-05-06 20:30:34"),
        DateTime.Parse("1986-10-10 05:30:49")
    )
    {
        Id = 129
    },
    new Employee(
        "Faith",
        "Bull",
        671479,
        "Research and Development",
        "Marketing Manager",
        DateTime.Parse("2020-08-04 02:11:02"),
        DateTime.Parse("1996-11-14 04:17:57")
    )
    {
        Id = 130
    },
    new Employee(
        "Allsun",
        "Strewthers",
        341281,
        "Services",
        "Office Assistant II",
        DateTime.Parse("2021-06-03 03:15:40"),
        DateTime.Parse("1999-08-07 06:36:49")
    )
    {
        Id = 131
    },
    new Employee(
        "Lory",
        "Rosindill",
        285596,
        "Training",
        "Health Coach I",
        DateTime.Parse("2023-04-22 18:35:42"),
        DateTime.Parse("1987-06-17 13:10:45")
    )
    {
        Id = 132
    },
    new Employee(
        "Obidiah",
        "Burdytt",
        395789,
        "Product Management",
        "Quality Engineer",
        DateTime.Parse("2022-02-28 15:18:24"),
        DateTime.Parse("1993-06-15 10:34:30")
    )
    {
        Id = 133
    },
    new Employee(
        "Des",
        "Sperrett",
        122904,
        "Accounting",
        "Help Desk Operator",
        DateTime.Parse("2020-03-28 04:16:33"),
        DateTime.Parse("1998-10-19 23:45:32")
    )
    {
        Id = 134
    },
    new Employee(
        "Carlin",
        "Leaver",
        448944,
        "Accounting",
        "GIS Technical Architect",
        DateTime.Parse("2015-07-05 06:05:31"),
        DateTime.Parse("1999-06-22 18:23:01")
    )
    {
        Id = 135
    },
    new Employee(
        "Omar",
        "Pally",
        290250,
        "Business Development",
        "Senior Developer",
        DateTime.Parse("2017-01-22 22:10:24"),
        DateTime.Parse("1997-09-11 22:32:11")
    )
    {
        Id = 136
    },
    new Employee(
        "Nettie",
        "Hellwig",
        220751,
        "Human Resources",
        "Professor",
        DateTime.Parse("2016-09-16 21:28:07"),
        DateTime.Parse("1992-08-04 00:46:21")
    )
    {
        Id = 137
    },
    new Employee(
        "Georgy",
        "Sweeting",
        192064,
        "Accounting",
        "Structural Analysis Engineer",
        DateTime.Parse("2023-12-15 06:13:29"),
        DateTime.Parse("1992-10-15 02:25:28")
    )
    {
        Id = 138
    },
    new Employee(
        "Drona",
        "Vaisey",
        130422,
        "Sales",
        "Account Coordinator",
        DateTime.Parse("2018-03-09 03:29:02"),
        DateTime.Parse("1988-03-12 22:52:50")
    )
    {
        Id = 139
    },
    new Employee(
        "Artemus",
        "Labon",
        330850,
        "Research and Development",
        "Administrative Assistant IV",
        DateTime.Parse("2020-09-19 11:20:23"),
        DateTime.Parse("1986-02-10 07:10:07")
    )
    {
        Id = 140
    },
    new Employee(
        "Alina",
        "Lodovichi",
        195662,
        "Marketing",
        "Registered Nurse",
        DateTime.Parse("2024-05-06 15:27:32"),
        DateTime.Parse("1997-02-04 05:34:22")
    )
    {
        Id = 141
    },
    new Employee(
        "Roscoe",
        "Hoopper",
        360419,
        "Human Resources",
        "Chemical Engineer",
        DateTime.Parse("2016-08-31 03:02:21"),
        DateTime.Parse("1986-01-26 17:18:45")
    )
    {
        Id = 142
    },
    new Employee(
        "Marlin",
        "Hearley",
        521430,
        "Sales",
        "Help Desk Operator",
        DateTime.Parse("2018-02-06 20:08:41"),
        DateTime.Parse("1986-11-09 06:40:04")
    )
    {
        Id = 143
    },
    new Employee(
        "Gayle",
        "Talks",
        320160,
        "Accounting",
        "Nuclear Power Engineer",
        DateTime.Parse("2020-11-02 06:55:44"),
        DateTime.Parse("1992-03-19 22:38:53")
    )
    {
        Id = 144
    },
    new Employee(
        "Alica",
        "Tayloe",
        230734,
        "Business Development",
        "Physical Therapy Assistant",
        DateTime.Parse("2020-05-27 14:35:46"),
        DateTime.Parse("1988-03-05 15:20:27")
    )
    {
        Id = 145
    },
    new Employee(
        "Sergeant",
        "Vigietti",
        266343,
        "Marketing",
        "Librarian",
        DateTime.Parse("2016-02-20 07:40:30"),
        DateTime.Parse("1993-07-25 11:05:10")
    )
    {
        Id = 146
    },
    new Employee(
        "Kendricks",
        "Edmunds",
        650754,
        "Human Resources",
        "Executive Secretary",
        DateTime.Parse("2019-08-11 14:19:51"),
        DateTime.Parse("1988-07-15 23:59:11")
    )
    {
        Id = 147
    },
    new Employee(
        "Howie",
        "Upston",
        119621,
        "Sales",
        "Community Outreach Specialist",
        DateTime.Parse("2015-02-24 08:35:30"),
        DateTime.Parse("1987-06-11 21:29:18")
    )
    {
        Id = 148
    },
    new Employee(
        "Dwight",
        "Gambie",
        25106,
        "Human Resources",
        "Research Assistant II",
        DateTime.Parse("2021-12-24 10:12:57"),
        DateTime.Parse("2000-05-07 16:22:52")
    )
    {
        Id = 149
    },
    new Employee(
        "Sacha",
        "Elders",
        148359,
        "Support",
        "Information Systems Manager",
        DateTime.Parse("2019-05-28 22:04:53"),
        DateTime.Parse("1994-05-17 12:07:33")
    )
    {
        Id = 150
    },
    new Employee(
        "Andee",
        "Gibbonson",
        184528,
        "Marketing",
        "Recruiter",
        DateTime.Parse("2024-07-19 10:44:38"),
        DateTime.Parse("1986-06-24 11:51:13")
    )
    {
        Id = 151
    },
    new Employee(
        "Helena",
        "Quickfall",
        166036,
        "Human Resources",
        "Accountant II",
        DateTime.Parse("2023-05-29 02:22:41"),
        DateTime.Parse("1989-01-25 13:33:13")
    )
    {
        Id = 152
    },
    new Employee(
        "Janette",
        "Sherlock",
        397586,
        "Business Development",
        "Staff Accountant I",
        DateTime.Parse("2016-02-11 13:36:33"),
        DateTime.Parse("1988-12-11 19:36:50")
    )
    {
        Id = 153
    },
    new Employee(
        "Sherwynd",
        "Hawgood",
        556338,
        "Accounting",
        "Recruiting Manager",
        DateTime.Parse("2022-08-30 01:29:33"),
        DateTime.Parse("1986-10-11 09:09:31")
    )
    {
        Id = 154
    },
    new Employee(
        "Bastien",
        "Croser",
        572273,
        "Human Resources",
        "Information Systems Manager",
        DateTime.Parse("2018-01-02 20:14:07"),
        DateTime.Parse("1990-09-13 13:13:07")
    )
    {
        Id = 155
    },
    new Employee(
        "Rutherford",
        "Furtado",
        306731,
        "Marketing",
        "Geologist II",
        DateTime.Parse("2024-03-14 09:20:04"),
        DateTime.Parse("1998-05-27 15:20:37")
    )
    {
        Id = 156
    },
    new Employee(
        "Gwendolen",
        "Swatman",
        589698,
        "Sales",
        "Junior Executive",
        DateTime.Parse("2015-07-05 17:56:45"),
        DateTime.Parse("1990-09-26 06:33:13")
    )
    {
        Id = 157
    },
    new Employee(
        "Camel",
        "Stradling",
        79370,
        "Accounting",
        "Human Resources Assistant II",
        DateTime.Parse("2015-03-11 17:01:07"),
        DateTime.Parse("1995-01-07 19:49:00")
    )
    {
        Id = 158
    },
    new Employee(
        "Leisha",
        "Janosevic",
        699744,
        "Support",
        "Geologist IV",
        DateTime.Parse("2022-09-28 01:07:04"),
        DateTime.Parse("1997-05-16 00:05:11")
    )
    {
        Id = 159
    },
    new Employee(
        "Yetta",
        "Mazillius",
        365947,
        "Accounting",
        "VP Quality Control",
        DateTime.Parse("2020-11-17 02:33:59"),
        DateTime.Parse("1990-02-11 04:51:39")
    )
    {
        Id = 160
    },
    new Employee(
        "Cherilyn",
        "Danbury",
        226762,
        "Product Management",
        "Analyst Programmer",
        DateTime.Parse("2015-07-17 02:30:36"),
        DateTime.Parse("1994-07-20 17:29:04")
    )
    {
        Id = 161
    },
    new Employee(
        "Marna",
        "Roskam",
        78983,
        "Support",
        "Nuclear Power Engineer",
        DateTime.Parse("2016-04-03 02:44:00"),
        DateTime.Parse("1986-01-19 09:41:01")
    )
    {
        Id = 162
    },
    new Employee(
        "Ginni",
        "Hagger",
        101348,
        "Marketing",
        "Professor",
        DateTime.Parse("2024-03-03 02:15:31"),
        DateTime.Parse("1990-10-09 23:54:13")
    )
    {
        Id = 163
    },
    new Employee(
        "Ashlee",
        "Trowl",
        646030,
        "Product Management",
        "Human Resources Assistant II",
        DateTime.Parse("2021-07-02 16:55:41"),
        DateTime.Parse("1993-11-26 11:02:48")
    )
    {
        Id = 164
    },
    new Employee(
        "Newton",
        "Keach",
        572021,
        "Services",
        "Research Assistant IV",
        DateTime.Parse("2015-02-14 14:09:34"),
        DateTime.Parse("2000-05-22 02:37:07")
    )
    {
        Id = 165
    },
    new Employee(
        "Mord",
        "Thirsk",
        555292,
        "Business Development",
        "Project Manager",
        DateTime.Parse("2022-04-28 17:20:48"),
        DateTime.Parse("1993-08-25 14:20:16")
    )
    {
        Id = 166
    },
    new Employee(
        "Gregoire",
        "Sharphurst",
        452455,
        "Engineering",
        "Geologist III",
        DateTime.Parse("2018-10-21 06:23:30"),
        DateTime.Parse("1994-06-05 06:19:07")
    )
    {
        Id = 167
    },
    new Employee(
        "Aguie",
        "Mostin",
        89286,
        "Engineering",
        "Librarian",
        DateTime.Parse("2022-07-24 16:12:55"),
        DateTime.Parse("1991-09-04 01:55:29")
    )
    {
        Id = 168
    },
    new Employee(
        "Vinnie",
        "Duffil",
        640288,
        "Research and Development",
        "Staff Scientist",
        DateTime.Parse("2023-08-16 05:49:45"),
        DateTime.Parse("1991-05-13 18:27:55")
    )
    {
        Id = 169
    },
    new Employee(
        "Frazer",
        "Manzell",
        438374,
        "Services",
        "Biostatistician I",
        DateTime.Parse("2015-11-11 21:44:39"),
        DateTime.Parse("1989-09-18 02:39:53")
    )
    {
        Id = 170
    },
    new Employee(
        "Adora",
        "Briers",
        332880,
        "Product Management",
        "Accountant II",
        DateTime.Parse("2020-10-14 15:48:18"),
        DateTime.Parse("1994-03-13 12:48:05")
    )
    {
        Id = 171
    },
    new Employee(
        "Johnath",
        "Ludewig",
        178759,
        "Human Resources",
        "Physical Therapy Assistant",
        DateTime.Parse("2015-07-19 05:37:05"),
        DateTime.Parse("1990-06-26 12:22:11")
    )
    {
        Id = 172
    },
    new Employee(
        "Isa",
        "Balcon",
        57569,
        "Marketing",
        "VP Product Management",
        DateTime.Parse("2023-01-09 00:03:01"),
        DateTime.Parse("1997-08-26 04:01:25")
    )
    {
        Id = 173
    },
    new Employee(
        "Nalani",
        "Spark",
        487787,
        "Human Resources",
        "Administrative Assistant III",
        DateTime.Parse("2024-04-24 12:54:23"),
        DateTime.Parse("1990-04-08 11:25:09")
    )
    {
        Id = 174
    },
    new Employee(
        "Giorgi",
        "Curl",
        146582,
        "Human Resources",
        "Systems Administrator I",
        DateTime.Parse("2020-05-05 08:18:23"),
        DateTime.Parse("1987-11-18 11:17:32")
    )
    {
        Id = 175
    },
    new Employee(
        "Keefer",
        "Aitchison",
        562734,
        "Marketing",
        "Geological Engineer",
        DateTime.Parse("2016-09-07 03:48:07"),
        DateTime.Parse("1995-11-15 16:20:03")
    )
    {
        Id = 176
    },
    new Employee(
        "Daryle",
        "Barden",
        768498,
        "Engineering",
        "Account Coordinator",
        DateTime.Parse("2016-08-06 17:24:35"),
        DateTime.Parse("1993-09-15 01:24:49")
    )
    {
        Id = 177
    },
    new Employee(
        "Arther",
        "Grover",
        604150,
        "Accounting",
        "Geological Engineer",
        DateTime.Parse("2017-11-03 17:39:37"),
        DateTime.Parse("1992-01-22 19:03:29")
    )
    {
        Id = 178
    },
    new Employee(
        "Elayne",
        "Nealon",
        27020,
        "Training",
        "Financial Analyst",
        DateTime.Parse("2023-04-26 02:17:18"),
        DateTime.Parse("1996-11-17 15:00:38")
    )
    {
        Id = 179
    },
    new Employee(
        "Archy",
        "Cossey",
        434172,
        "Training",
        "Account Coordinator",
        DateTime.Parse("2024-03-08 10:56:51"),
        DateTime.Parse("1988-12-02 09:23:21")
    )
    {
        Id = 180
    },
    new Employee(
        "Brendin",
        "Seagar",
        232503,
        "Research and Development",
        "Assistant Manager",
        DateTime.Parse("2024-02-29 08:58:33"),
        DateTime.Parse("1993-04-01 18:30:40")
    )
    {
        Id = 181
    },
    new Employee(
        "Marthe",
        "McRamsey",
        197174,
        "Services",
        "Financial Advisor",
        DateTime.Parse("2022-09-03 22:14:40"),
        DateTime.Parse("1996-03-13 16:35:25")
    )
    {
        Id = 182
    },
    new Employee(
        "Ferd",
        "Bryns",
        191713,
        "Engineering",
        "Project Manager",
        DateTime.Parse("2015-03-12 13:49:30"),
        DateTime.Parse("1998-10-11 04:40:43")
    )
    {
        Id = 183
    },
    new Employee(
        "Noble",
        "Danilovitch",
        26216,
        "Business Development",
        "Assistant Professor",
        DateTime.Parse("2015-12-24 15:04:08"),
        DateTime.Parse("1986-11-24 17:43:26")
    )
    {
        Id = 184
    },
    new Employee(
        "Legra",
        "Kidwell",
        264111,
        "Marketing",
        "Senior Developer",
        DateTime.Parse("2016-10-07 00:48:56"),
        DateTime.Parse("1988-02-16 07:59:16")
    )
    {
        Id = 185
    },
    new Employee(
        "Joye",
        "Razzell",
        92674,
        "Accounting",
        "Human Resources Manager",
        DateTime.Parse("2016-01-13 18:26:06"),
        DateTime.Parse("1998-11-23 20:24:33")
    )
    {
        Id = 186
    },
    new Employee(
        "Lacee",
        "Simmank",
        301243,
        "Training",
        "Senior Developer",
        DateTime.Parse("2015-02-13 21:01:23"),
        DateTime.Parse("1999-05-08 19:57:42")
    )
    {
        Id = 187
    },
    new Employee(
        "Puff",
        "Nafzger",
        702505,
        "Services",
        "Senior Financial Analyst",
        DateTime.Parse("2022-07-05 03:20:13"),
        DateTime.Parse("1991-01-21 11:39:17")
    )
    {
        Id = 188
    },
    new Employee(
        "Oralla",
        "Fantone",
        201796,
        "Marketing",
        "Accounting Assistant IV",
        DateTime.Parse("2019-04-03 09:49:05"),
        DateTime.Parse("1996-04-11 00:31:31")
    )
    {
        Id = 189
    },
    new Employee(
        "Reed",
        "Cuncliffe",
        514309,
        "Marketing",
        "Office Assistant IV",
        DateTime.Parse("2017-04-13 06:19:35"),
        DateTime.Parse("1990-07-25 08:59:37")
    )
    {
        Id = 190
    },
    new Employee(
        "Redford",
        "Bicker",
        501691,
        "Legal",
        "Chief Design Engineer",
        DateTime.Parse("2015-01-01 02:36:17"),
        DateTime.Parse("1987-11-09 23:25:19")
    )
    {
        Id = 191
    },
    new Employee(
        "Loria",
        "McGloughlin",
        676168,
        "Product Management",
        "Social Worker",
        DateTime.Parse("2016-10-29 22:09:04"),
        DateTime.Parse("1987-10-08 05:10:50")
    )
    {
        Id = 192
    },
    new Employee(
        "Meggie",
        "Tomsen",
        662538,
        "Training",
        "Statistician IV",
        DateTime.Parse("2019-09-13 15:03:15"),
        DateTime.Parse("1990-01-19 02:10:53")
    )
    {
        Id = 193
    },
    new Employee(
        "Brook",
        "Aimer",
        606254,
        "Services",
        "Sales Representative",
        DateTime.Parse("2015-07-08 19:47:24"),
        DateTime.Parse("1997-06-02 00:04:47")
    )
    {
        Id = 194
    },
    new Employee(
        "Kyle",
        "Issacoff",
        269274,
        "Accounting",
        "Project Manager",
        DateTime.Parse("2017-10-20 06:16:01"),
        DateTime.Parse("1994-07-23 02:52:57")
    )
    {
        Id = 195
    },
    new Employee(
        "Marlo",
        "Henze",
        392860,
        "Services",
        "Legal Assistant",
        DateTime.Parse("2017-07-15 16:49:11"),
        DateTime.Parse("1989-09-04 01:53:07")
    )
    {
        Id = 196
    },
    new Employee(
        "Beatrisa",
        "Kingsbury",
        339495,
        "Support",
        "Nurse Practicioner",
        DateTime.Parse("2017-11-19 17:55:37"),
        DateTime.Parse("1999-12-19 06:15:12")
    )
    {
        Id = 197
    },
    new Employee(
        "Lazarus",
        "Daingerfield",
        435134,
        "Training",
        "Account Coordinator",
        DateTime.Parse("2021-05-14 21:14:46"),
        DateTime.Parse("1995-05-23 22:56:38")
    )
    {
        Id = 198
    },
    new Employee(
        "Carri",
        "Johnson",
        263605,
        "Research and Development",
        "Quality Control Specialist",
        DateTime.Parse("2021-08-03 11:13:25"),
        DateTime.Parse("1992-10-09 03:04:59")
    )
    {
        Id = 199
    },
    new Employee(
        "Arlena",
        "Copestake",
        156577,
        "Legal",
        "Director of Sales",
        DateTime.Parse("2020-10-24 08:44:37"),
        DateTime.Parse("1997-01-06 10:06:58")
    )
    {
        Id = 200
    }
        );
    }


}
