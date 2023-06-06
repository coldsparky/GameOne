using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        static Dictionary<string, string> countriesCapitals = new Dictionary<string, string>();
        public int FillDictionary()
        {
            countriesCapitals.Add("Австралия", "Канберра");
            countriesCapitals.Add("Австрия", "Вена");
            countriesCapitals.Add("Азербайджан", "Баку");
            countriesCapitals.Add("Албания", "Тирана");
            countriesCapitals.Add("Алжир", "Алжир");
            countriesCapitals.Add("Ангола", "Луанда");
            countriesCapitals.Add("Андорра", "Андорра-ла-Велья");
            countriesCapitals.Add("Антигуа и Барбуда", "Сент-Джонс");
            countriesCapitals.Add("Аргентина", "Буэнос-Айрес");
            countriesCapitals.Add("Армения", "Ереван");
            countriesCapitals.Add("Афганистан", "Кабул");
            countriesCapitals.Add("Багамы", "Нассау");
            countriesCapitals.Add("Бангладеш", "Дакка");
            countriesCapitals.Add("Барбадос", "Бриджтаун");
            countriesCapitals.Add("Бахрейн", "Манама");
            countriesCapitals.Add("Беларусь", "Минск");
            countriesCapitals.Add("Белиз", "Бельмопан");
            countriesCapitals.Add("Бельгия", "Брюссель");
            countriesCapitals.Add("Бенин", "Порто-Ново");
            countriesCapitals.Add("Болгария", "София");
            countriesCapitals.Add("Боливия", "Сукре");
            countriesCapitals.Add("Босния и Герцеговина", "Сараево");
            countriesCapitals.Add("Ботсвана", "Габороне");
            countriesCapitals.Add("Бразилия", "Бразилиа");
            countriesCapitals.Add("Бруней", "Бандар-Сери-Багаван");
            countriesCapitals.Add("Буркина Фасо", "Уагадугу");
            countriesCapitals.Add("Бурунди", "Бужумбура");
            countriesCapitals.Add("Бутан", "Тхимпху");
            countriesCapitals.Add("Вануату", "Порт-Вила");
            countriesCapitals.Add("Ватикан", "Ватикан");
            countriesCapitals.Add("Великобритания", "Лондон");
            countriesCapitals.Add("Венесуэла", "Каракас");
            countriesCapitals.Add("Восточный Тимор", "Дили");
            countriesCapitals.Add("Вьетнам", "Ханой");
            countriesCapitals.Add("Габон", "Либревиль");
            countriesCapitals.Add("Гаити", "Порт-о-Пренс");
            countriesCapitals.Add("Гайана", "Джорджтаун");
            countriesCapitals.Add("Гамбия", "Банжул");
            countriesCapitals.Add("Гана", "Аккра");
            countriesCapitals.Add("Гватемала", "Гватемала");
            countriesCapitals.Add("Гвинея", "Конакри");
            countriesCapitals.Add("Гвинея-Бисау", "Бисау");
            countriesCapitals.Add("Германия", "Берлин");
            countriesCapitals.Add("Гондурас", "Тегусигальпа");
            countriesCapitals.Add("Гренада", "Сент-Джорджес");
            countriesCapitals.Add("Греция", "Афины");
            countriesCapitals.Add("Грузия", "Тбилиси");
            countriesCapitals.Add("Дания", "Копенгаген");
            countriesCapitals.Add("Джибути", "Джибути");
            countriesCapitals.Add("Доминика", "Розо");
            countriesCapitals.Add("Доминиканская Республика", "Санто-Доминго");
            countriesCapitals.Add("Египет", "Каир");
            countriesCapitals.Add("Замбия", "Лусака");
            countriesCapitals.Add("Зимбабве", "Хараре");
            countriesCapitals.Add("Израиль", "Иерусалим");
            countriesCapitals.Add("Индия", "Нью-Дели");
            countriesCapitals.Add("Индонезия", "Джакарта");
            countriesCapitals.Add("Иордания", "Амман");
            countriesCapitals.Add("Ирак", "Багдад");
            countriesCapitals.Add("Иран", "Тегеран");
            countriesCapitals.Add("Ирландия", "Дублин");
            countriesCapitals.Add("Исландия", "Рейкьявик");
            countriesCapitals.Add("Испания", "Мадрид");
            countriesCapitals.Add("Италия", "Рим");
            countriesCapitals.Add("Йемен", "Сана");
            countriesCapitals.Add("Кабо-Верде", "Прая");
            countriesCapitals.Add("Казахстан", "Астана");
            countriesCapitals.Add("Камбоджа", "Пномпень");
            countriesCapitals.Add("Камерун", "Яунде");
            countriesCapitals.Add("Канада", "Оттава");
            countriesCapitals.Add("Катар", "Доха");
            countriesCapitals.Add("Кения", "Найроби");
            countriesCapitals.Add("Кипр", "Никосия");
            countriesCapitals.Add("Киргизия", "Бишкек");
            countriesCapitals.Add("Кирибати", "Южная Тарава");
            countriesCapitals.Add("Китай", "Пекин");
            countriesCapitals.Add("Колумбия", "Санта-Фе-де-Богота");
            countriesCapitals.Add("Коморы", "Морони");
            countriesCapitals.Add("Конго, демократическая республика", "Киншаса");
            countriesCapitals.Add("Конго, республика", "Браззавиль");
            countriesCapitals.Add("Коста-Рика", "Сан-Хосе");
            countriesCapitals.Add("Кот-д’Ивуар", "Ямусукро");
            countriesCapitals.Add("Куба", "Гавана");
            countriesCapitals.Add("Кувейт", "Эль-Кувейт");
            countriesCapitals.Add("Лаос", "Вьентьян");
            countriesCapitals.Add("Латвия", "Рига");
            countriesCapitals.Add("Лесото", "Масеру");
            countriesCapitals.Add("Либерия", "Монровия");
            countriesCapitals.Add("Ливан", "Бейрут");
            countriesCapitals.Add("Ливия", "Триполи");
            countriesCapitals.Add("Литва", "Вильнюс");
            countriesCapitals.Add("Лихтенштейн", "Вадуц");
            countriesCapitals.Add("Люксембург", "Люксембург");
            countriesCapitals.Add("Маврикий", "Порт-Луи");
            countriesCapitals.Add("Мавритания", "Нуакшот");
            countriesCapitals.Add("Мадагаскар", "Антананариву");
            countriesCapitals.Add("Македония", "Скопье");
            countriesCapitals.Add("Малави", "Лилонгве");
            countriesCapitals.Add("Малайзия", "Куала-Лумпур");
            countriesCapitals.Add("Мали", "Бамако");
            countriesCapitals.Add("Мальдивы", "Мале");
            countriesCapitals.Add("Мальта", "Валлетта");
            countriesCapitals.Add("Марокко", "Рабат");
            countriesCapitals.Add("Маршалловы Острова", "Маджуро");
            countriesCapitals.Add("Мексика", "Мехико");
            countriesCapitals.Add("Мозамбик", "Мапуту");
            countriesCapitals.Add("Молдавия", "Кишинев");
            countriesCapitals.Add("Монако", "Монако");
            countriesCapitals.Add("Монголия", "Улан-Батор");
            countriesCapitals.Add("Мьянма", "Найпьидо");
            countriesCapitals.Add("Намибия", "Виндхук");
            countriesCapitals.Add("Непал", "Катманду");
            countriesCapitals.Add("Нигер", "Ниамей");
            countriesCapitals.Add("Нигерия", "Абуджа");
            countriesCapitals.Add("Нидерланды", "Амстердам");
            countriesCapitals.Add("Никарагуа", "Манагуа");
            countriesCapitals.Add("Новая Зеландия", "Веллингтон");
            countriesCapitals.Add("Норвегия", "Осло");
            countriesCapitals.Add("Объединенные Арабские Эмираты", "Абу-Даби");
            countriesCapitals.Add("Оман", "Маскат");
            countriesCapitals.Add("Пакистан", "Исламабад");
            countriesCapitals.Add("Палау", "Мелекеок");
            countriesCapitals.Add("Панама", "Панама");
            countriesCapitals.Add("Папуа - Новая Гвинея", "Порт-Морсби");
            countriesCapitals.Add("Парагвай", "Асунсьон");
            countriesCapitals.Add("Перу", "Лима");
            countriesCapitals.Add("Польша", "Варшава");
            countriesCapitals.Add("Португалия", "Лиссабон");
            countriesCapitals.Add("Россия", "Москва");
            countriesCapitals.Add("Руанда", "Кигали");
            countriesCapitals.Add("Румыния", "Бухарест");
            countriesCapitals.Add("Сальвадор", "Сан-Сальвадор");
            countriesCapitals.Add("Самоа", "Апиа");
            countriesCapitals.Add("Сан-Марино", "Сан-Марино");
            countriesCapitals.Add("Сан-Томе и Принсипи", "Сан-Томе");
            countriesCapitals.Add("Саудовская Аравия", "Эр-Рияд");
            countriesCapitals.Add("Свазиленд", "Мбабане");
            countriesCapitals.Add("Северная Корея", "Пхеньян");
            countriesCapitals.Add("Сейшелы", "Виктория");
            countriesCapitals.Add("Сенегал", "Дакар");
            countriesCapitals.Add("Сент-Винсент и Гренадины", "Бастер");
            countriesCapitals.Add("Сент-Люсия", "Кастри");
            countriesCapitals.Add("Сербия", "Белград");
            countriesCapitals.Add("Сингапур", "Сан-Сингапур");
            countriesCapitals.Add("Сирия", "Дамаск");
            countriesCapitals.Add("Словакия", "Братислава");
            countriesCapitals.Add("Словения", "Любляна");
            countriesCapitals.Add("Соединенные Штаты Америки", "Вашингтон");
            countriesCapitals.Add("Соломоновы Острова", "Хониара");
            countriesCapitals.Add("Сомали", "Могадишо");
            countriesCapitals.Add("Судан", "Хартум");
            countriesCapitals.Add("Суринам", "Парамарибо");
            countriesCapitals.Add("Сьерра-Леоне", "Фритаун");
            countriesCapitals.Add("Таджикистан", "Душанбе");
            countriesCapitals.Add("Таиланд", "Бангкок");
            countriesCapitals.Add("Танзания", "Додома");
            countriesCapitals.Add("Того", "Ломе");
            countriesCapitals.Add("Тонга", "Нукуалофа");
            countriesCapitals.Add("Тринидад и Тобаго", "Порт-оф-Спейн");
            countriesCapitals.Add("Тувалу", "Фунафути");
            countriesCapitals.Add("Тунис", "Тунис");
            countriesCapitals.Add("Туркмения", "Ашхабад");
            countriesCapitals.Add("Турция", "Анкара");
            countriesCapitals.Add("Уганда", "Кампала");
            countriesCapitals.Add("Узбекистан", "Ташкент");
            countriesCapitals.Add("Украина", "Киев");
            countriesCapitals.Add("Уругвай", "Монтевидео");
            countriesCapitals.Add("Федеративные штаты Микронезии", "Паликир");
            countriesCapitals.Add("Фиджи", "Сува");
            countriesCapitals.Add("Филиппины", "Манила");
            countriesCapitals.Add("Финляндия", "Хельсинки");
            countriesCapitals.Add("Франция", "Париж");
            countriesCapitals.Add("Хорватия", "Загреб");
            countriesCapitals.Add("Центрально-Африканская Республика", "Банги");
            countriesCapitals.Add("Чад", "Нджамена");
            countriesCapitals.Add("Черногория", "Подгорица");
            countriesCapitals.Add("Чехия", "Прага");
            countriesCapitals.Add("Чили", "Сантьяго");
            countriesCapitals.Add("Швейцария", "Берн");
            countriesCapitals.Add("Швеция", "Стокгольм");
            countriesCapitals.Add("Шри-Ланка", "Коломбо");
            countriesCapitals.Add("Эквадор", "Кито");
            countriesCapitals.Add("Экваториальная Гвинея", "Малабо");
            countriesCapitals.Add("Эритрея", "Асмэра");
            countriesCapitals.Add("Эстония", "Таллин");
            countriesCapitals.Add("Эфиопия", "Аддис-Абеба");
            countriesCapitals.Add("Южная Корея", "Сеул");
            countriesCapitals.Add("Южно-Африканская Республика", "Претория");
            countriesCapitals.Add("Ямайка", "Кингстон");
            countriesCapitals.Add("Япония", "Токио");
            return countriesCapitals.Count();
        }

        static void Main(string[] args)
        {
            Program program= new Program();
            program.FillDictionary();
            Console.WriteLine("Сколько раз хотите угадывать столицу?");
            int count_step = Int32.Parse(Console.ReadLine());
            int k = 0;
            int score = 0;
            while (k != count_step) {
                Console.WriteLine($"Страна номер {k + 1}");
                Console.WriteLine("Введите страну: ");
                string countries = Console.ReadLine();
                if(countriesCapitals.ContainsKey(countries))
                {
                    Console.WriteLine("Введите ответ: ");
                    string answer = Console.ReadLine();
                    if (answer == countriesCapitals[countries])
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Ответ правильный!");
                        Console.ResetColor();
                        score++;
                        k++;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ответ неверный!");
                        Console.ResetColor();
                        Console.WriteLine("Правильный ответ: " + countriesCapitals[countries]);
                        k++;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Такой страны не существует. Попробуйте снова.");
                    Console.ResetColor();
                }
            }
            Console.Write("Вы угадали ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{score}");
            Console.ResetColor();
            Console.Write($" столиц из {count_step}");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
