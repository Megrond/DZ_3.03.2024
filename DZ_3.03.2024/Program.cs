using static System.Console;

/*Задание 1.
Напишите метод, который отображает квадрат из
некоторого символа. Метод принимает в качестве параметра: длину стороны квадрата, символ.*/

class Task1
{
    static void Main()
    {
        WriteLine("Введите длину стороны квадрата:");
        int sideLength = Convert.ToInt32(ReadLine());

        Write("Введите символ для отображения квадрата: ");
        char symbol = ReadKey().KeyChar;

        WriteLine("\n");
        DrawSquare(sideLength, symbol);
    }

    static void DrawSquare(int sideLength, char symbol)
    {
        for (int i = 0; i < sideLength; i++)
        {
            for (int j = 0; j < sideLength; j++)
            {
                Write(symbol + " ");
            }
            WriteLine();
        }
    }
}
/*=======================================================================================*/

/*Задание 2.
Напишите метод, который проверяет является ли
переданное число «палиндромом». Число передаётся в
качестве параметра. Если число палиндром нужно вернуть из метода true, иначе false.
Палиндром — число, которое читается одинаково как
справа налево, так и слева направо. Например:
1221 — палиндром;
3443 — палиндром;
7854 — не палиндром.*/

class Task2
{
    static void Main()
    {
        WriteLine("Введите число для проверки, является ли переданное число «палиндромом»:");
        int number = Convert.ToInt32(ReadLine());
        bool isPalindrome = CheckPalindrome(number);

        if (isPalindrome)
        {
            WriteLine($"Число {number} является палиндромом");
        }
        else
        {
            WriteLine($"Число {number} НЕ является палиндромом");
        }
    }

    static bool CheckPalindrome(int number)
    {
        int originalNumber = number;
        int reversedNumber = 0;

        while (number > 0)
        {
            int remainder = number % 10;
            reversedNumber = reversedNumber * 10 + remainder;
            number = number / 10;
        }

        return originalNumber == reversedNumber;
    }
}
/*=======================================================================================*/

/*Задание 3.
Напишите метод, фильтрующий массив на основании
переданных параметров. Метод принимает параметры:
оригинальный_массив, массив_с_данными_для_фильтрации.
1
Метод возвращает оригинальный массив без элементов, которые есть в массиве для фильтрации.
Например:
1 2 6 - 1 88 7 6 — оригинальный массив;
6 88 7 — массив для фильтрации;
1 2 - 1 — результат работы метода.*/

class Task3
{
    static int[] FilterArray(int[] originalArray, int[] filterArray)
    {
        List<int> result = new List<int>();

        foreach (int number in originalArray)
        {
            if (!filterArray.Contains(number))
            {
                result.Add(number);
            }
        }

        return result.ToArray();
    }

    static void Main(string[] args)
    {
        int[] originalArray = [1, 2, 6, -1, 88, 7, 6];
        int[] filterArray = [6, 88, 7];

        int[] filteredArray = FilterArray(originalArray, filterArray);

        WriteLine("Оригинальный массив:");
        WriteLine(string.Join(" ", originalArray));

        WriteLine("Массив для фильтрации:");
        WriteLine(string.Join(" ", filterArray));

        WriteLine("Получившийся массив после фильтрации:");
        WriteLine(string.Join(" ", filteredArray));
    }
}
/*=======================================================================================*/

/*Задание 4.
Создайте класс «Веб-сайт». Необходимо хранить в
полях класса: название сайта, путь к сайту, описание
сайта, ip адрес сайта. Реализуйте методы класса для ввода
данных, вывода данных, реализуйте доступ к отдельным
полям через методы класса. */

class Website
{
    private string siteName;
    private string siteUrl;
    private string siteDescription;
    private string siteIpAddress;

    public void SetSiteName(string name)
    {
        siteName = name;
    }

    public string GetSiteName()
    {
        return siteName;
    }

    public void SetSiteUrl(string url)
    {
        siteUrl = url;
    }

    public string GetSiteUrl()
    {
        return siteUrl;
    }

    public void SetSiteDescription(string description)
    {
        siteDescription = description;
    }

    public string GetSiteDescription()
    {
        return siteDescription;
    }

    public void SetSiteIpAddress(string ipAddress)
    {
        siteIpAddress = ipAddress;
    }

    public string GetSiteIpAddress()
    {
        return siteIpAddress;
    }

    public void InputData()
    {
        WriteLine("Введите название сайта:");
        siteName = ReadLine();

        WriteLine("Введите путь к сайту:");
        siteUrl = ReadLine();

        WriteLine("Введите описание сайта:");
        siteDescription = ReadLine();

        WriteLine("Введите IP адрес сайта:");
        siteIpAddress = ReadLine();
    }

    public void Show()
    {
        WriteLine($"Название сайта: {siteName}");
        WriteLine($"Путь к сайту:   {siteUrl}");
        WriteLine($"Описание сайта: {siteDescription}");
        WriteLine($"IP адрес сайта: {siteIpAddress}");
    }
}

partial class Task4
{
    static void Main()
    {
        Website myWebsite = new Website();

        myWebsite.InputData();
        WriteLine("\nВведённые данные:");
        myWebsite.Show();
    }
}

/*=======================================================================================*/

/*Задание 5.
Создайте класс «Журнал». Необходимо хранить в
полях класса: название журнала, год основания, описание журнала, контактный телефон, контактный e-mail.
Реализуйте методы класса для ввода данных, вывода
данных, реализуйте доступ к отдельным полям через
методы класса.*/

class Journal
{
    private string journalName;
    private int foundationYear;
    private string description;
    private string contactPhone;
    private string contactEmail;

    public void SetJournalName(string name)
    {
        journalName = name;
    }

    public string GetJournalName()
    {
        return journalName;
    }

    public void SetFoundationYear(int year)
    {
        foundationYear = year;
    }

    public int GetFoundationYear()
    {
        return foundationYear;
    }

    public void SetDescription(string desc)
    {
        description = desc;
    }

    public string GetDescription()
    {
        return description;
    }

    public void SetContactPhone(string phone)
    {
        contactPhone = phone;
    }

    public string GetContactPhone()
    {
        return contactPhone;
    }

    public void SetContactEmail(string email)
    {
        contactEmail = email;
    }

    public string GetContactEmail()
    {
        return contactEmail;
    }

    public void InputData()
    {
        WriteLine("Введите название журнала:");
        journalName = ReadLine();

        WriteLine("Введите год создания:");
        foundationYear = Convert.ToInt32(ReadLine());

        WriteLine("Введите описание журнала:");
        description = ReadLine();

        WriteLine("Введите контактный телефон:");
        contactPhone = ReadLine();

        WriteLine("Введите Email:");
        contactEmail = ReadLine();
    }

    public void DisplayData()
    {
        WriteLine($"Название журнала:    {journalName}");
        WriteLine($"Год создания:        {foundationYear}");
        WriteLine($"Описание журнала:    {description}");
        WriteLine($"Контактный телефон:  {contactPhone}");
        WriteLine($"Email:               {contactEmail}");
    }
}

class Task5
{
    static void Main()
    {
        Journal myJournal = new Journal();
        myJournal.InputData();
        WriteLine("\nОписание журнала:");
        myJournal.DisplayData();
    }
}

/*=======================================================================================*/

/*Задание 6.
Создайте класс «Магазин». Необходимо хранить в
полях класса: название магазина, адрес, описание профиля магазина, контактный телефон, контактный e-mail.
Реализуйте методы класса для ввода данных, вывода
данных, реализуйте доступ к отдельным полям через
методы класса.*/

class Store
{
    private string name;
    private string address;
    private string description;
    private string phoneNumber;
    private string email;

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }

    public void SetAddress(string address)
    {
        this.address = address;
    }

    public string GetAddress()
    {
        return address;
    }

    public void SetDescription(string description)
    {
        this.description = description;
    }

    public string GetDescription()
    {
        return description;
    }

    public void SetPhoneNumber(string phoneNumber)
    {
        this.phoneNumber = phoneNumber;
    }

    public string GetPhoneNumber()
    {
        return phoneNumber;
    }

    public void SetEmail(string email)
    {
        this.email = email;
    }

    public string GetEmail()
    {
        return email;
    }

    public void InputData()
    {
        WriteLine("Введите сведения о магазине:");
        Write("Название магазина: ");
        name = ReadLine();

        Write("Адрес магазина: ");
        address = ReadLine();

        Write("Описание профиля магазина: ");
        description = ReadLine();

        Write("Контактный телефон: ");
        phoneNumber = ReadLine();

        Write("Email: ");
        email = ReadLine();
    }

    public void Show()
    {
        WriteLine($"Название магазина: {name}");
        WriteLine($"Адрес магазина:    {address}");
        WriteLine($"Описание магазина:  {description}");
        WriteLine($"Номер телефона:     {phoneNumber}");
        WriteLine($"Email:              {email}");
    }
}

class Task6
{
    static void Main()
    {
        Store store = new Store();
        store.InputData();
        WriteLine("\nО Магазине:");
        store.Show();
    }
}