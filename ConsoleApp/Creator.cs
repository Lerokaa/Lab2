using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ClassLibrary;

namespace ConsoleApp
{
    internal static class Creator
    {
        public static Lesson CreateLesson()
        {
            // Все ссылки для создания вашего класса должны быть получены
            // при помощи чужих методов (заглушек или реализованых методов)
            Discipline discipline = CreateDiscipline();
            Employee employee = CreateEmployee();
            Classroom classroom = CreateClassroom();
            Pair pair = CreatePair();
            ClassLibrary.Group group = CreateGroup();
            TypeOfActivity typeOfActivity = CreateTypeOfActivity();


            //Вы должны оганизовать получение ключевых данных от пользователя
            // для поиска существующей сущности в БД
            Console.WriteLine("Введите начало пары (в формате чч:мм):");
            string pairStart = Console.ReadLine();

            while (!ValidateTimeFormat(pairStart))
            {
                Console.WriteLine("Введенное время не соответствует формату чч:мм. Повторите ввод:");
                pairStart = Console.ReadLine();
            }

            Console.WriteLine("Введите конец пары (в формате чч:мм):");
            string pairEnd = Console.ReadLine();

            while (!ValidateTimeFormat(pairEnd))
            {
                Console.WriteLine("Введенное время не соответствует формату чч:мм. Повторите ввод:");
                pairEnd = Console.ReadLine();
            }

            // После сбора ключевых данных вы обращаетесь в БД ища существующий обект
            Lesson lesson = DB.lessons.FirstOrDefault(l => discipline == l.Discipline && employee == l.Employee && classroom == l.Classroom && pair == l.Pair && group == l.Group && typeOfActivity == l.TypeOfActivity);

            // Если этого обекта нет в БД, вы должны его создать
            if (lesson == null)
            {
                Console.WriteLine("Введите дату:");
                string date = Console.ReadLine();
                lesson = new Lesson(DateTime.Parse(date), discipline, employee, classroom, group, pair, typeOfActivity);
                DB.lessons.Add(lesson);
                Console.WriteLine("Занятие успешно создано.");
            }

            return lesson;
        }

        private static TypeOfActivity CreateTypeOfActivity()
        {
            return null;
        }

        private static ClassLibrary.Group CreateGroup()
        {
            return null;
        }

        public static Pair CreatePair()
        {
            TimeSpan pairstart;
            Console.Write("Введите время начала пары: ");
            while (!TimeSpan.TryParse(Console.ReadLine(), out pairstart))
            {
                Console.Write("Неправильный формат! Введите время начала пары: ");
            }

            TimeSpan pairend;
            Console.Write("Введите время конца пары: ");
            while (!TimeSpan.TryParse(Console.ReadLine(), out pairend))
            {
                Console.Write("Неправильный формат! Введите время конца пары: ");
            }

            TimeSpan reststart;
            Console.Write("Введите время начала перерыва: ");
            while (!TimeSpan.TryParse(Console.ReadLine(), out reststart) || reststart < pairstart || reststart > pairend)
            {
                Console.Write("Неправильно! Введите время начала перерыва: ");
            }

            TimeSpan restend;
            Console.Write("Введите время конца перерыва: ");
            while (!TimeSpan.TryParse(Console.ReadLine(), out restend) || restend < reststart || restend > pairend)
            {
                Console.Write("Неправильно! Введите время конца перерыва: ");
            }

            Console.WriteLine("Введите смену: ");
            WorkShift shift = CreateWorkShift();

            Pair pair = new Pair(pairstart, pairend, reststart, restend, shift);

            DB.pairs.Add(pair);

            return pair;
        }


        public static Classroom CreateClassroom()
        {
            Console.WriteLine("Введите название аудитории: ");
            string name = Console.ReadLine();

            Classroom classroom = DB.Classrooms.FirstOrDefault(cl => cl.Name == name);
            if (classroom == null)
            {
                Console.WriteLine("Введите количество мест?");
                int seatingCapacity;
                while (!int.TryParse(Console.ReadLine(), out seatingCapacity) || seatingCapacity < 0)
                    Console.WriteLine("Нужно ввести целое число =>0");
                Console.WriteLine("Введите количество окон?");
                int windowCount;
                while (!int.TryParse(Console.ReadLine(), out windowCount) || windowCount < 0)
                    Console.WriteLine("Нужно ввести целое число =>0");
                Console.WriteLine("Введите количество оборудования:");
                int equipmentCount;
                while (!int.TryParse(Console.ReadLine(), out equipmentCount) || equipmentCount < 0)
                    Console.WriteLine("Нужно ввести целое число =>0");
                List<Equipment> equipmentList = new List<Equipment>();
                for (int i = 0; i < equipmentCount; i++)
                {
                    Console.WriteLine("Создайте оборудование:");
                    equipmentList.Add(CreateEquipment());
                }
                Console.WriteLine("Введите ответственного сотрудника: ");
                Employee employee = CreateEmployee();

                classroom = new Classroom(name, employee, seatingCapacity, windowCount);
                foreach (Equipment equipment in equipmentList)
                {
                    classroom.Equipments.Add(equipment);
                }
                DB.Classrooms.Add(classroom);

            }
            return classroom;

        }

        public static Equipment CreateEquipment()
        {
            return null;
        }
        public static Employee CreateEmployee()
        {
            Console.WriteLine("Введите фамилию сотрудника:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Введите имя сотрудника:");
            string firstName = Console.ReadLine();



            Console.WriteLine("Введите отчество сотрудника:");

            string patronypicName = Console.ReadLine();

            return new Employee(lastName, firstName, patronypicName, CreateSpeciality());
        }

        public static WorkShift CreateWorkShift()
        {
            return null;
        }



        public static Discipline CreateDiscipline()
        {
            Console.WriteLine("Введите название дисциплины");
            string name = Console.ReadLine();
            Discipline discipline = DB.disciplines.FirstOrDefault(d => d.Name == name);
            if (discipline == null)
            {
                Console.WriteLine("Введите сокращение: ");
                string shortname = Console.ReadLine();

                discipline = new Discipline(name, shortname);
                DB.disciplines.Add(discipline);
            }
            return discipline;
        }
        public static WorkShift CreateWorkShift()
        {
            // Получение ключевых данных от пользователя
            Console.WriteLine("Введите название смены:");
            string name = Console.ReadLine();

            // Проверка ввода пользователя
            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Название смены не может быть пустым. Повторите ввод:");
                name = Console.ReadLine();
            }

            // Создание нового объекта WorkShift
            WorkShift workShift = new WorkShift(name);

            Console.WriteLine("Смена успешно создана.");

            return workShift;
        }

        private static bool ValidateTimeFormat(string time)
        {
            string pattern = @"^(2[0-3]|[01][0-9]):[0-5][0-9]$";
            return Regex.IsMatch(time, pattern);
        }

        public static Division CreateDivision()
        {
            Employee head = CreateEmployee();
            Organization organization = CreateOrganization();

            

            Division division = DB.Division.FirstOrDefault(l => head == l.Head && organization == l.Organization);

            if (division == null)
            {
                Console.WriteLine("Введите название организации:");
                string name = Console.ReadLine();
                division = new Division(name, head, organization);
                DB.Division.Add(division);
                Console.WriteLine("Подразделение успешно создано.");
            }

            return division;
        }

        private static Organization CreateOrganization()
        {
            return null;
        }

        public static Speciality CreateSpeciality()
        {

            Console.WriteLine("Введите полное название специальности:");
            string SpecialityName = Console.ReadLine();

            Speciality speciality = DB.speciality.FirstOrDefault(s => SpecialityName == s.SpecialityName);
            if (speciality == null)
            {
                Console.WriteLine("Введите сокращение названия специальности:");
                string ReductionName = Console.ReadLine();
                speciality = new Speciality(SpecialityName, ReductionName);
                DB.speciality.Add(speciality);
                Console.WriteLine("Специальность успешно создана.");
            }
            return speciality;
        }

        public static Position CreatePosition()
        {
            Console.WriteLine("Введите название должности:");
            string title = Console.ReadLine();

            Position position = DB.Position.FirstOrDefault(l => title == l.Title);

            if (position == null)
            {
                Console.WriteLine("Введите оклад:");
                decimal salary = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Введите название подразделения:");
                Division division = CreateDivision();


                position = new Position(title, salary, division);
                DB.Position.Add(position);
                Console.WriteLine("Должность создана");
            }
            return position;
        }
    }
}
