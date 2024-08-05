using _01WebApi.Models;

namespace _01WebApi;

// in memory data store, will be swapped out when using Entity Framework to connect a data source
public class EmployeeDataStore
{
    public List<EmployeeDto> Employees { get; set; }

    public static EmployeeDataStore Current { get; } = new EmployeeDataStore();

    public EmployeeDataStore()
    {
        Employees  = new List<EmployeeDto>() {
    new EmployeeDto() {
        Id = 1,
        Name = "Keiko Acevedo",
        Salary = 6385,
        Department = "Lavasoft",
        Position = "Asset Management"
    },
    new EmployeeDto() {
        Id = 2,
        Name = "Forrest Morrison",
        Salary = 411,
        Department = "Sibelius",
        Position = "Advertising"
    },
    new EmployeeDto() {
        Id = 3,
        Name = "Kareem Holloway",
        Salary = 8801,
        Department = "Cakewalk",
        Position = "Public Relations"
    },
    new EmployeeDto() {
        Id = 4,
        Name = "Alana Higgins",
        Salary = 5154,
        Department = "Microsoft",
        Position = "Legal Department"
    },
    new EmployeeDto() {
        Id = 5,
        Name = "George Kinney",
        Salary = 9606,
        Department = "Yahoo",
        Position = "Customer Relations"
    },
    new EmployeeDto() {
        Id = 6,
        Name = "Adena Dunlap",
        Salary = 6208,
        Department = "Finale",
        Position = "Advertising"
    },
    new EmployeeDto() {
        Id = 7,
        Name = "Drake Hester",
        Salary = 5129,
        Department = "Adobe",
        Position = "Customer Service"
    },
    new EmployeeDto() {
        Id = 8,
        Name = "Shay Steele",
        Salary = 9035,
        Department = "Apple",
        Position = "Customer Relations"
    },
    new EmployeeDto() {
        Id = 9,
        Name = "Alika Wilkinson",
        Salary = 7389,
        Department = "Yahoo",
        Position = "Legal Department"
    },
    new EmployeeDto() {
        Id = 10,
        Name = "Timothy Turner",
        Salary = 6975,
        Department = "Cakewalk",
        Position = "Research and Development"
    },
    new EmployeeDto() {
        Id = 11,
        Name = "Sarah Murray",
        Salary = 7766,
        Department = "Google",
        Position = "Research and Development"
    },
    new EmployeeDto() {
        Id = 12,
        Name = "Demetria Scott",
        Salary = 6359,
        Department = "Borland",
        Position = "Finances"
    },
    new EmployeeDto() {
        Id = 13,
        Name = "Len Hamilton",
        Salary = 6010,
        Department = "Finale",
        Position = "Advertising"
    },
    new EmployeeDto() {
        Id = 14,
        Name = "Chiquita Munoz",
        Salary = 7318,
        Department = "Apple",
        Position = "Research and Development"
    },
    new EmployeeDto() {
        Id = 15,
        Name = "Imani Saunders",
        Salary = 5914,
        Department = "Microsoft",
        Position = "Accounting"
    },
    new EmployeeDto() {
        Id = 16,
        Name = "Iliana Tanner",
        Salary = 6344,
        Department = "Sibelius",
        Position = "Media Relations"
    },
    new EmployeeDto() {
        Id = 17,
        Name = "Stuart Duke",
        Salary = 8706,
        Department = "Cakewalk",
        Position = "Customer Service"
    },
    new EmployeeDto() {
        Id = 18,
        Name = "Bethany Lowe",
        Salary = 5006,
        Department = "Chami",
        Position = "Research and Development"
    },
    new EmployeeDto() {
        Id = 19,
        Name = "Nasim Kaufman",
        Salary = 9961,
        Department = "Lavasoft",
        Position = "Finances"
    },
    new EmployeeDto() {
        Id = 20,
        Name = "Gabriel Mcpherson",
        Salary = 9377,
        Department = "Adobe",
        Position = "Payroll"
    },
    new EmployeeDto() {
        Id = 21,
        Name = "Joy Le",
        Salary = 7860,
        Department = "Google",
        Position = "Human Resources"
    },
    new EmployeeDto() {
        Id = 22,
        Name = "Selma Emerson",
        Salary = 8859,
        Department = "Borland",
        Position = "Quality Assurance"
    },
    new EmployeeDto() {
        Id = 23,
        Name = "Brenna Carlson",
        Salary = 6074,
        Department = "Google",
        Position = "Legal Department"
    },
    new EmployeeDto() {
        Id = 24,
        Name = "Mona Sims",
        Salary = 7136,
        Department = "Adobe",
        Position = "Research and Development"
    },
    new EmployeeDto() {
        Id = 25,
        Name = "Addison Conley",
        Salary = 6861,
        Department = "Lavasoft",
        Position = "Advertising"
    },
    new EmployeeDto() {
        Id = 26,
        Name = "Bruce Franco",
        Salary = 8956,
        Department = "Sibelius",
        Position = "Human Resources"
    },
    new EmployeeDto() {
        Id = 27,
        Name = "Madeline Riggs",
        Salary = 9605,
        Department = "Finale",
        Position = "Legal Department"
    },
    new EmployeeDto() {
        Id = 28,
        Name = "Denton Lambert",
        Salary = 7651,
        Department = "Cakewalk",
        Position = "Research and Development"
    },
    new EmployeeDto() {
        Id = 29,
        Name = "Forrest Joyce",
        Salary = 6015,
        Department = "Borland",
        Position = "Human Resources"
    },
    new EmployeeDto() {
        Id = 30,
        Name = "Ulysses Spence",
        Salary = 8048,
        Department = "Apple",
        Position = "Customer Service"
    },
    new EmployeeDto() {
        Id = 31,
        Name = "Coby Burnett",
        Salary = 7851,
        Department = "Sibelius",
        Position = "Customer Relations"
    },
    new EmployeeDto() {
        Id = 32,
        Name = "Paloma Phillips",
        Salary = 9140,
        Department = "Cakewalk",
        Position = "Legal Department"
    },
    new EmployeeDto() {
        Id = 33,
        Name = "Imelda Faulkner",
        Salary = 8199,
        Department = "Apple",
        Position = "Accounting"
    },
    new EmployeeDto() {
        Id = 34,
        Name = "Nero Hartman",
        Salary = 7590,
        Department = "Finale",
        Position = "Quality Assurance"
    },
    new EmployeeDto() {
        Id = 35,
        Name = "Karen Foster",
        Salary = 9628,
        Department = "Sibelius",
        Position = "Finances"
    },
    new EmployeeDto() {
        Id = 36,
        Name = "Jael Cardenas",
        Salary = 8247,
        Department = "Adobe",
        Position = "Asset Management"
    },
    new EmployeeDto() {
        Id = 37,
        Name = "Gemma Mcmillan",
        Salary = 7672,
        Department = "Amazon",
        Position = "Asset Management"
    },
    new EmployeeDto() {
        Id = 38,
        Name = "Malachi Schneider",
        Salary = 6455,
        Department = "Amazon",
        Position = "Payroll"
    },
    new EmployeeDto() {
        Id = 39,
        Name = "Rooney Gray",
        Salary = 9632,
        Department = "Adobe",
        Position = "Sales and Marketing"
    },
    new EmployeeDto() {
        Id = 40,
        Name = "Xenos Randolph",
        Salary = 5698,
        Department = "Google",
        Position = "Accounting"
    },
    new EmployeeDto() {
        Id = 41,
        Name = "Cally Harris",
        Salary = 8912,
        Department = "Adobe",
        Position = "Advertising"
    },
    new EmployeeDto() {
        Id = 42,
        Name = "Jameson Estes",
        Salary = 8944,
        Department = "Borland",
        Position = "Human Resources"
    },
    new EmployeeDto() {
        Id = 43,
        Name = "TaShya Bishop",
        Salary = 9560,
        Department = "Borland",
        Position = "Media Relations"
    },
    new EmployeeDto() {
        Id = 44,
        Name = "Jaquelyn Le",
        Salary = 6172,
        Department = "Sibelius",
        Position = "Payroll"
    },
    new EmployeeDto() {
        Id = 45,
        Name = "Maxwell Ewing",
        Salary = 9135,
        Department = "Microsoft",
        Position = "Finances"
    },
    new EmployeeDto() {
        Id = 46,
        Name = "Brenda Holder",
        Salary = 7465,
        Department = "Cakewalk",
        Position = "Media Relations"
    },
    new EmployeeDto() {
        Id = 47,
        Name = "Karleigh Salazar",
        Salary = 6189,
        Department = "Microsoft",
        Position = "Tech Support"
    },
    new EmployeeDto() {
        Id = 48,
        Name = "Xenos Hughes",
        Salary = 7949,
        Department = "Sibelius",
        Position = "Customer Service"
    },
    new EmployeeDto() {
        Id = 49,
        Name = "Porter Kelley",
        Salary = 5463,
        Department = "Amazon",
        Position = "Customer Relations"
    },
    new EmployeeDto() {
        Id = 50,
        Name = "Nehru Bauer",
        Salary = 6926,
        Department = "Chami",
        Position = "Quality Assurance"
    },
    new EmployeeDto() {
        Id = 51,
        Name = "Kirk Santana",
        Salary = 5190,
        Department = "Adobe",
        Position = "Legal Department"
    },
    new EmployeeDto() {
        Id = 52,
        Name = "Lucy Carrillo",
        Salary = 8476,
        Department = "Borland",
        Position = "Finances"
    },
    new EmployeeDto() {
        Id = 53,
        Name = "Vladimir Nixon",
        Salary = 6355,
        Department = "Yahoo",
        Position = "Sales and Marketing"
    },
    new EmployeeDto() {
        Id = 54,
        Name = "Burton Garrett",
        Salary = 7851,
        Department = "Sibelius",
        Position = "Advertising"
    },
    new EmployeeDto() {
        Id = 55,
        Name = "Dale Ross",
        Salary = 5076,
        Department = "Finale",
        Position = "Quality Assurance"
    },
    new EmployeeDto() {
        Id = 56,
        Name = "Wayne Summers",
        Salary = 7852,
        Department = "Sibelius",
        Position = "Accounting"
    },
    new EmployeeDto() {
        Id = 57,
        Name = "Elijah Maxwell",
        Salary = 7576,
        Department = "Finale",
        Position = "Quality Assurance"
    },
    new EmployeeDto() {
        Id = 58,
        Name = "Drew Page",
        Salary = 8617,
        Department = "Finale",
        Position = "Asset Management"
    },
    new EmployeeDto() {
        Id = 59,
        Name = "Lacy Wells",
        Salary = 9964,
        Department = "Sibelius",
        Position = "Legal Department"
    },
    new EmployeeDto() {
        Id = 60,
        Name = "Lewis Dunlap",
        Salary = 7609,
        Department = "Google",
        Position = "Human Resources"
    },
    new EmployeeDto() {
        Id = 61,
        Name = "Louis Duran",
        Salary = 8659,
        Department = "Borland",
        Position = "Tech Support"
    },
    new EmployeeDto() {
        Id = 62,
        Name = "Angela Byrd",
        Salary = 8486,
        Department = "Google",
        Position = "Customer Service"
    },
    new EmployeeDto() {
        Id = 63,
        Name = "Wesley Patterson",
        Salary = 9230,
        Department = "Chami",
        Position = "Asset Management"
    },
    new EmployeeDto() {
        Id = 64,
        Name = "Shafira Tucker",
        Salary = 9708,
        Department = "Lavasoft",
        Position = "Finances"
    },
    new EmployeeDto() {
        Id = 65,
        Name = "Alfonso Parrish",
        Salary = 7034,
        Department = "Lavasoft",
        Position = "Customer Service"
    },
    new EmployeeDto() {
        Id = 66,
        Name = "Eaton Washington",
        Salary = 7087,
        Department = "Microsoft",
        Position = "Customer Service"
    },
    new EmployeeDto() {
        Id = 67,
        Name = "Randall Rivera",
        Salary = 6352,
        Department = "Microsoft",
        Position = "Human Resources"
    },
    new EmployeeDto() {
        Id = 68,
        Name = "Fulton Blake",
        Salary = 8107,
        Department = "Microsoft",
        Position = "Human Resources"
    },
    new EmployeeDto() {
        Id = 69,
        Name = "Zane Greene",
        Salary = 9315,
        Department = "Finale",
        Position = "Human Resources"
    },
    new EmployeeDto() {
        Id = 70,
        Name = "Tate Rivas",
        Salary = 9396,
        Department = "Amazon",
        Position = "Customer Service"
    },
    new EmployeeDto() {
        Id = 71,
        Name = "Camilla Morrison",
        Salary = 8564,
        Department = "Apple",
        Position = "Quality Assurance"
    },
    new EmployeeDto() {
        Id = 72,
        Name = "Lars Pennington",
        Salary = 8073,
        Department = "Lavasoft",
        Position = "Advertising"
    },
    new EmployeeDto() {
        Id = 73,
        Name = "Chadwick Hood",
        Salary = 9236,
        Department = "Google",
        Position = "Asset Management"
    },
    new EmployeeDto() {
        Id = 74,
        Name = "Claudia Cannon",
        Salary = 5682,
        Department = "Adobe",
        Position = "Advertising"
    },
    new EmployeeDto() {
        Id = 75,
        Name = "Emery Bates",
        Salary = 8308,
        Department = "Apple",
        Position = "Human Resources"
    },
    new EmployeeDto() {
        Id = 76,
        Name = "Violet Mclean",
        Salary = 7742,
        Department = "Sibelius",
        Position = "Media Relations"
    },
    new EmployeeDto() {
        Id = 77,
        Name = "Sybil Hogan",
        Salary = 5363,
        Department = "Google",
        Position = "Payroll"
    },
    new EmployeeDto() {
        Id = 78,
        Name = "Yardley Leblanc",
        Salary = 5143,
        Department = "Cakewalk",
        Position = "Finances"
    },
    new EmployeeDto() {
        Id = 79,
        Name = "Baxter Fry",
        Salary = 5373,
        Department = "Google",
        Position = "Customer Service"
    },
    new EmployeeDto() {
        Id = 80,
        Name = "Liberty Sutton",
        Salary = 6232,
        Department = "Borland",
        Position = "Payroll"
    },
    new EmployeeDto() {
        Id = 81,
        Name = "Tad Mcintosh",
        Salary = 6084,
        Department = "Sibelius",
        Position = "Tech Support"
    },
    new EmployeeDto() {
        Id = 82,
        Name = "Ava Stein",
        Salary = 8685,
        Department = "Borland",
        Position = "Public Relations"
    },
    new EmployeeDto() {
        Id = 83,
        Name = "Kylynn Miles",
        Salary = 5356,
        Department = "Chami",
        Position = "Accounting"
    },
    new EmployeeDto() {
        Id = 84,
        Name = "Clark Burris",
        Salary = 8394,
        Department = "Google",
        Position = "Human Resources"
    },
    new EmployeeDto() {
        Id = 85,
        Name = "Jarrod Mack",
        Salary = 9652,
        Department = "Yahoo",
        Position = "Advertising"
    },
    new EmployeeDto() {
        Id = 86,
        Name = "Catherine Carson",
        Salary = 9146,
        Department = "Apple",
        Position = "Tech Support"
    },
    new EmployeeDto() {
        Id = 87,
        Name = "Yasir Simmons",
        Salary = 6928,
        Department = "Apple",
        Position = "Public Relations"
    },
    new EmployeeDto() {
        Id = 88,
        Name = "Fitzgerald Howell",
        Salary = 5252,
        Department = "Sibelius",
        Position = "Legal Department"
    },
    new EmployeeDto() {
        Id = 89,
        Name = "Nicole Kane",
        Salary = 7306,
        Department = "Adobe",
        Position = "Accounting"
    },
    new EmployeeDto() {
        Id = 90,
        Name = "Andrew Moody",
        Salary = 6842,
        Department = "Borland",
        Position = "Sales and Marketing"
    },
    new EmployeeDto() {
        Id = 91,
        Name = "Marsden Kirk",
        Salary = 5149,
        Department = "Lavasoft",
        Position = "Asset Management"
    },
    new EmployeeDto() {
        Id = 92,
        Name = "Hedley Burns",
        Salary = 8737,
        Department = "Amazon",
        Position = "Tech Support"
    },
    new EmployeeDto() {
        Id = 93,
        Name = "Reuben Mcguire",
        Salary = 5828,
        Department = "Google",
        Position = "Human Resources"
    },
    new EmployeeDto() {
        Id = 94,
        Name = "Yuri Cardenas",
        Salary = 9157,
        Department = "Chami",
        Position = "Quality Assurance"
    },
    new EmployeeDto() {
        Id = 95,
        Name = "Madeson Fox",
        Salary = 6675,
        Department = "Google",
        Position = "Research and Development"
    },
    new EmployeeDto() {
        Id = 96,
        Name = "Louis Slater",
        Salary = 7480,
        Department = "Lavasoft",
        Position = "Payroll"
    },
    new EmployeeDto() {
        Id = 97,
        Name = "Linus Roach",
        Salary = 6495,
        Department = "Google",
        Position = "Sales and Marketing"
    },
    new EmployeeDto() {
        Id = 98,
        Name = "Ria Carrillo",
        Salary = 8670,
        Department = "Lavasoft",
        Position = "Legal Department"
    },
    new EmployeeDto() {
        Id = 99,
        Name = "Harriet Charles",
        Salary = 5553,
        Department = "Chami",
        Position = "Legal Department"
    },
    new EmployeeDto() {
        Id = 100,
        Name = "Fatima Little",
        Salary = 9057,
        Department = "Cakewalk",
        Position = "Asset Management"
    },
    new EmployeeDto() {
        Id = 101,
        Name = "Ocean Rasmussen",
        Salary = 9877,
        Department = "Lavasoft",
        Position = "Sales and Marketing"
    },
    new EmployeeDto() {
        Id = 102,
        Name = "Ashton Gross",
        Salary = 7494,
        Department = "Amazon",
        Position = "Accounting"
    },
    new EmployeeDto() {
        Id = 103,
        Name = "David Nixon",
        Salary = 5307,
        Department = "Microsoft",
        Position = "Sales and Marketing"
    },
    new EmployeeDto() {
        Id = 104,
        Name = "Edward Acosta",
        Salary = 5168,
        Department = "Finale",
        Position = "Finances"
    },
    new EmployeeDto() {
        Id = 105,
        Name = "Ruth Le",
        Salary = 5872,
        Department = "Amazon",
        Position = "Asset Management"
    },
    new EmployeeDto() {
        Id = 106,
        Name = "Deborah Snider",
        Salary = 8709,
        Department = "Microsoft",
        Position = "Customer Relations"
    },
    new EmployeeDto() {
        Id = 107,
        Name = "Hilary Pittman",
        Salary = 7076,
        Department = "Apple",
        Position = "Customer Service"
    },
    new EmployeeDto() {
        Id = 108,
        Name = "Isabella Hoover",
        Salary = 5894,
        Department = "Google",
        Position = "Research and Development"
    },
    new EmployeeDto() {
        Id = 109,
        Name = "Benjamin Savage",
        Salary = 9968,
        Department = "Microsoft",
        Position = "Customer Service"
    },
    new EmployeeDto() {
        Id = 110,
        Name = "Colette Keith",
        Salary = 5457,
        Department = "Finale",
        Position = "Public Relations"
    },
    new EmployeeDto() {
        Id = 111,
        Name = "Oliver Chavez",
        Salary = 8221,
        Department = "Finale",
        Position = "Quality Assurance"
    },
    new EmployeeDto() {
        Id = 112,
        Name = "Daphne Whitfield",
        Salary = 9064,
        Department = "Yahoo",
        Position = "Customer Service"
    },
    new EmployeeDto() {
        Id = 113,
        Name = "Herrod Benjamin",
        Salary = 8158,
        Department = "Chami",
        Position = "Legal Department"
    },
    new EmployeeDto() {
        Id = 114,
        Name = "Uta Massey",
        Salary = 8339,
        Department = "Cakewalk",
        Position = "Research and Development"
    },
    new EmployeeDto() {
        Id = 115,
        Name = "Armando Boyle",
        Salary = 8758,
        Department = "Google",
        Position = "Payroll"
    },
    new EmployeeDto() {
        Id = 116,
        Name = "Preston Mann",
        Salary = 7009,
        Department = "Chami",
        Position = "Asset Management"
    },
    new EmployeeDto() {
        Id = 117,
        Name = "Marvin Nash",
        Salary = 7658,
        Department = "Finale",
        Position = "Tech Support"
    },
    new EmployeeDto() {
        Id = 118,
        Name = "Nyssa Juarez",
        Salary = 7898,
        Department = "Lavasoft",
        Position = "Payroll"
    },
    new EmployeeDto() {
        Id = 119,
        Name = "Amelia Curtis",
        Salary = 7345,
        Department = "Cakewalk",
        Position = "Human Resources"
    },
    new EmployeeDto() {
        Id = 120,
        Name = "Hedley Whitaker",
        Salary = 5207,
        Department = "Apple",
        Position = "Quality Assurance"
    },
    new EmployeeDto() {
        Id = 121,
        Name = "Jemima Thompson",
        Salary = 8441,
        Department = "Yahoo",
        Position = "Asset Management"
    },
    new EmployeeDto() {
        Id = 122,
        Name = "Flavia Reilly",
        Salary = 5348,
        Department = "Borland",
        Position = "Customer Service"
    },
    new EmployeeDto() {
        Id = 123,
        Name = "Carlos Norris",
        Salary = 6625,
        Department = "Microsoft",
        Position = "Finances"
    },
    new EmployeeDto() {
        Id = 124,
        Name = "Tatiana Fulton",
        Salary = 5651,
        Department = "Cakewalk",
        Position = "Finances"
    },
    new EmployeeDto() {
        Id = 125,
        Name = "Plato Phelps",
        Salary = 8347,
        Department = "Microsoft",
        Position = "Legal Department"
    },
    new EmployeeDto() {
        Id = 126,
        Name = "Ethan Hayes",
        Salary = 6937,
        Department = "Yahoo",
        Position = "Media Relations"
    },
    new EmployeeDto() {
        Id = 127,
        Name = "Darius Durham",
        Salary = 7284,
        Department = "Cakewalk",
        Position = "Human Resources"
    },
    new EmployeeDto() {
        Id = 128,
        Name = "Ray Stark",
        Salary = 6901,
        Department = "Cakewalk",
        Position = "Public Relations"
    },
    new EmployeeDto() {
        Id = 129,
        Name = "Dale Mays",
        Salary = 6788,
        Department = "Apple",
        Position = "Customer Relations"
    },
    new EmployeeDto() {
        Id = 130,
        Name = "Otto Hunt",
        Salary = 7588,
        Department = "Google",
        Position = "Customer Service"
    },
    new EmployeeDto() {
        Id = 131,
        Name = "Cole Meyer",
        Salary = 5233,
        Department = "Microsoft",
        Position = "Sales and Marketing"
    },
    new EmployeeDto() {
        Id = 132,
        Name = "Anne Merritt",
        Salary = 6922,
        Department = "Apple",
        Position = "Quality Assurance"
    },
    new EmployeeDto() {
        Id = 133,
        Name = "Cherokee Medina",
        Salary = 9084,
        Department = "Finale",
        Position = "Finances"
    },
    new EmployeeDto() {
        Id = 134,
        Name = "Rhea Merritt",
        Salary = 7632,
        Department = "Amazon",
        Position = "Customer Service"
    },
    new EmployeeDto() {
        Id = 135,
        Name = "Kennedy Frederick",
        Salary = 6635,
        Department = "Yahoo",
        Position = "Legal Department"
    },
    new EmployeeDto() {
        Id = 136,
        Name = "Ezra Boone",
        Salary = 8290,
        Department = "Sibelius",
        Position = "Media Relations"
    },
    new EmployeeDto() {
        Id = 137,
        Name = "Hector Perkins",
        Salary = 6162,
        Department = "Amazon",
        Position = "Research and Development"
    },
    new EmployeeDto() {
        Id = 138,
        Name = "Vera Guthrie",
        Salary = 9418,
        Department = "Finale",
        Position = "Accounting"
    },
    new EmployeeDto() {
        Id = 139,
        Name = "Miriam Vega",
        Salary = 9291,
        Department = "Yahoo",
        Position = "Human Resources"
    },
    new EmployeeDto() {
        Id = 140,
        Name = "Hermione Velasquez",
        Salary = 9916,
        Department = "Apple",
        Position = "Asset Management"
    },
    new EmployeeDto() {
        Id = 141,
        Name = "Irene Lindsay",
        Salary = 5395,
        Department = "Adobe",
        Position = "Tech Support"
    },
    new EmployeeDto() {
        Id = 142,
        Name = "Xyla Sutton",
        Salary = 5795,
        Department = "Sibelius",
        Position = "Finances"
    },
    new EmployeeDto() {
        Id = 143,
        Name = "Paula Velasquez",
        Salary = 5243,
        Department = "Amazon",
        Position = "Tech Support"
    },
    new EmployeeDto() {
        Id = 144,
        Name = "Martin Lee",
        Salary = 6513,
        Department = "Amazon",
        Position = "Legal Department"
    },
    new EmployeeDto() {
        Id = 145,
        Name = "Mannix Rojas",
        Salary = 8632,
        Department = "Sibelius",
        Position = "Public Relations"
    },
    new EmployeeDto() {
        Id = 146,
        Name = "Francis Mcmillan",
        Salary = 5373,
        Department = "Adobe",
        Position = "Legal Department"
    },
    new EmployeeDto() {
        Id = 147,
        Name = "Ezra Cantu",
        Salary = 9675,
        Department = "Adobe",
        Position = "Media Relations"
    },
    new EmployeeDto() {
        Id = 148,
        Name = "Beau Harding",
        Salary = 8176,
        Department = "Yahoo",
        Position = "Research and Development"
    },
    new EmployeeDto() {
        Id = 149,
        Name = "Deborah Sanford",
        Salary = 6715,
        Department = "Finale",
        Position = "Finances"
    },
    new EmployeeDto() {
        Id = 150,
        Name = "Lana Strong",
        Salary = 7504,
        Department = "Amazon",
        Position = "Accounting"
    },
    new EmployeeDto() {
        Id = 151,
        Name = "Baker Travis",
        Salary = 6672,
        Department = "Apple",
        Position = "Human Resources"
    },
    new EmployeeDto() {
        Id = 152,
        Name = "Cameron Gomez",
        Salary = 8960,
        Department = "Microsoft",
        Position = "Sales and Marketing"
    },
    new EmployeeDto() {
        Id = 153,
        Name = "McKenzie Bruce",
        Salary = 5568,
        Department = "Google",
        Position = "Sales and Marketing"
    },
    new EmployeeDto() {
        Id = 154,
        Name = "Lucas Hardy",
        Salary = 6261,
        Department = "Cakewalk",
        Position = "Customer Relations"
    },
    new EmployeeDto() {
        Id = 155,
        Name = "Lynn Black",
        Salary = 8952,
        Department = "Chami",
        Position = "Human Resources"
    },
    new EmployeeDto() {
        Id = 156,
        Name = "Alisa Marshall",
        Salary = 5997,
        Department = "Amazon",
        Position = "Tech Support"
    },
    new EmployeeDto() {
        Id = 157,
        Name = "McKenzie Hahn",
        Salary = 6814,
        Department = "Microsoft",
        Position = "Customer Relations"
    },
    new EmployeeDto() {
        Id = 158,
        Name = "Nolan Gallagher",
        Salary = 9353,
        Department = "Microsoft",
        Position = "Sales and Marketing"
    },
    new EmployeeDto() {
        Id = 159,
        Name = "Mannix Welch",
        Salary = 5130,
        Department = "Yahoo",
        Position = "Tech Support"
    },
    new EmployeeDto() {
        Id = 160,
        Name = "Zachery Kelly",
        Salary = 6444,
        Department = "Yahoo",
        Position = "Tech Support"
    },
    new EmployeeDto() {
        Id = 161,
        Name = "Octavia Skinner",
        Salary = 5812,
        Department = "Adobe",
        Position = "Research and Development"
    },
    new EmployeeDto() {
        Id = 162,
        Name = "Veronica Morton",
        Salary = 7982,
        Department = "Amazon",
        Position = "Tech Support"
    },
    new EmployeeDto() {
        Id = 163,
        Name = "Serina Gould",
        Salary = 7996,
        Department = "Lavasoft",
        Position = "Human Resources"
    },
    new EmployeeDto() {
        Id = 164,
        Name = "Lucas Brewer",
        Salary = 6125,
        Department = "Adobe",
        Position = "Customer Service"
    },
    new EmployeeDto() {
        Id = 165,
        Name = "Emma Orr",
        Salary = 7843,
        Department = "Lavasoft",
        Position = "Sales and Marketing"
    },
    new EmployeeDto() {
        Id = 166,
        Name = "Laith Love",
        Salary = 9707,
        Department = "Chami",
        Position = "Accounting"
    },
    new EmployeeDto() {
        Id = 167,
        Name = "Zoe England",
        Salary = 6006,
        Department = "Sibelius",
        Position = "Legal Department"
    },
    new EmployeeDto() {
        Id = 168,
        Name = "Olympia Snow",
        Salary = 7444,
        Department = "Sibelius",
        Position = "Payroll"
    },
    new EmployeeDto() {
        Id = 169,
        Name = "Jocelyn Barton",
        Salary = 9975,
        Department = "Cakewalk",
        Position = "Legal Department"
    },
    new EmployeeDto() {
        Id = 170,
        Name = "Dominic Reed",
        Salary = 6668,
        Department = "Chami",
        Position = "Customer Relations"
    },
    new EmployeeDto() {
        Id = 171,
        Name = "Sierra Lott",
        Salary = 9060,
        Department = "Lavasoft",
        Position = "Quality Assurance"
    },
    new EmployeeDto() {
        Id = 172,
        Name = "McKenzie Leon",
        Salary = 6571,
        Department = "Cakewalk",
        Position = "Legal Department"
    },
    new EmployeeDto() {
        Id = 173,
        Name = "Bruno Bradshaw",
        Salary = 8842,
        Department = "Lavasoft",
        Position = "Asset Management"
    },
    new EmployeeDto() {
        Id = 174,
        Name = "Constance Hester",
        Salary = 8186,
        Department = "Adobe",
        Position = "Accounting"
    },
    new EmployeeDto() {
        Id = 175,
        Name = "Leo Dunn",
        Salary = 8319,
        Department = "Amazon",
        Position = "Customer Service"
    },
    new EmployeeDto() {
        Id = 176,
        Name = "Elaine Ashley",
        Salary = 5271,
        Department = "Finale",
        Position = "Finances"
    },
    new EmployeeDto() {
        Id = 177,
        Name = "Isabella Buckner",
        Salary = 5089,
        Department = "Yahoo",
        Position = "Sales and Marketing"
    },
    new EmployeeDto() {
        Id = 178,
        Name = "Celeste Gutierrez",
        Salary = 6569,
        Department = "Apple",
        Position = "Public Relations"
    },
    new EmployeeDto() {
        Id = 179,
        Name = "Wade Webster",
        Salary = 5506,
        Department = "Amazon",
        Position = "Sales and Marketing"
    },
    new EmployeeDto() {
        Id = 180,
        Name = "Duncan Dixon",
        Salary = 9717,
        Department = "Amazon",
        Position = "Payroll"
    },
    new EmployeeDto() {
        Id = 181,
        Name = "Knox Buckner",
        Salary = 8172,
        Department = "Borland",
        Position = "Tech Support"
    },
    new EmployeeDto() {
        Id = 182,
        Name = "Frances Hawkins",
        Salary = 9730,
        Department = "Chami",
        Position = "Asset Management"
    },
    new EmployeeDto() {
        Id = 183,
        Name = "Cassandra Guzman",
        Salary = 8304,
        Department = "Finale",
        Position = "Accounting"
    },
    new EmployeeDto() {
        Id = 184,
        Name = "Jenette Joseph",
        Salary = 7583,
        Department = "Google",
        Position = "Tech Support"
    },
    new EmployeeDto() {
        Id = 185,
        Name = "Hayden Mcintyre",
        Salary = 9687,
        Department = "Adobe",
        Position = "Customer Relations"
    },
    new EmployeeDto() {
        Id = 186,
        Name = "Alisa Bowers",
        Salary = 6555,
        Department = "Apple",
        Position = "Tech Support"
    },
    new EmployeeDto() {
        Id = 187,
        Name = "Olivia Jennings",
        Salary = 6401,
        Department = "Sibelius",
        Position = "Asset Management"
    },
    new EmployeeDto() {
        Id = 188,
        Name = "Fleur Mathis",
        Salary = 6073,
        Department = "Adobe",
        Position = "Human Resources"
    },
    new EmployeeDto() {
        Id = 189,
        Name = "Nelle Doyle",
        Salary = 6321,
        Department = "Google",
        Position = "Legal Department"
    },
    new EmployeeDto() {
        Id = 190,
        Name = "Jamal Austin",
        Salary = 8695,
        Department = "Amazon",
        Position = "Finances"
    },
    new EmployeeDto() {
        Id = 191,
        Name = "Lynn Farmer",
        Salary = 8562,
        Department = "Finale",
        Position = "Research and Development"
    },
    new EmployeeDto() {
        Id = 192,
        Name = "Zachary Shaw",
        Salary = 6375,
        Department = "Lavasoft",
        Position = "Tech Support"
    },
    new EmployeeDto() {
        Id = 193,
        Name = "Pearl Decker",
        Salary = 7516,
        Department = "Chami",
        Position = "Asset Management"
    },
    new EmployeeDto() {
        Id = 194,
        Name = "Mariko Houston",
        Salary = 9983,
        Department = "Finale",
        Position = "Media Relations"
    },
    new EmployeeDto() {
        Id = 195,
        Name = "Nathaniel Acevedo",
        Salary = 9882,
        Department = "Borland",
        Position = "Sales and Marketing"
    },
    new EmployeeDto() {
        Id = 196,
        Name = "Sylvester Morrison",
        Salary = 7007,
        Department = "Amazon",
        Position = "Research and Development"
    },
    new EmployeeDto() {
        Id = 197,
        Name = "Merritt Richards",
        Salary = 6863,
        Department = "Apple",
        Position = "Media Relations"
    },
    new EmployeeDto() {
        Id = 198,
        Name = "Lev Suarez",
        Salary = 5686,
        Department = "Microsoft",
        Position = "Media Relations"
    },
    new EmployeeDto() {
        Id = 199,
        Name = "Ivan Lucas",
        Salary = 6291,
        Department = "Sibelius",
        Position = "Quality Assurance"
    },
    new EmployeeDto() {
        Id = 200,
        Name = "Serena Bentley",
        Salary = 6901,
        Department = "Borland",
        Position = "Quality Assurance"
    }

        };
    }
}
