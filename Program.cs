using Telegram.Bot.Polling;
using Telegram.Bot.Types.InputFiles;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace tgbot
{
    internal class Program
    {
        static ITelegramBotClient bot = new TelegramBotClient("6187346167:AAExNeT8Y18t9HiNwB0lUO-a1aGeLjrwMZU");

        public static async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(update));

            String message = update.Message.Text;
            long chatId = update.Message.Chat.Id;
            Boolean isfind = false;


            if (message.Equals("/start"))
            {
                isfind = true;
                ReplyKeyboardMarkup start = new ReplyKeyboardMarkup(new[]
                {
                    new KeyboardButton[] {"Преобрести животное"},
                    new KeyboardButton[] {"Купить ветеринарные аппараты"},
                    new KeyboardButton[] {"Преобрести корм"}
                });
                await botClient.SendTextMessageAsync(chatId: chatId, text: "Здравствуйте! Добро пожаловать в наш зоомагазин.Подскажите, пожалуйста, чем я могу Вам помочь?", replyMarkup: start);
            }

            if (message.Equals("Преобрести животное"))
            {
                isfind = true;
                ReplyKeyboardMarkup start = new ReplyKeyboardMarkup(new[]
                {
                    new KeyboardButton[] {"Рыбы"},
                    new KeyboardButton[] {"Грызуны"},
                    new KeyboardButton[] {"Птицы"},
                    new KeyboardButton[] {"Кошки,собаки"}
                });

                await botClient.SendTextMessageAsync(chatId: chatId, text: "Новая вкладка открыта", replyMarkup: start);

            }

            if (message.Equals("Купить ветеринарные аппараты"))
            {
                isfind = true;
                ReplyKeyboardMarkup start = new ReplyKeyboardMarkup(new[]
                {
                    new KeyboardButton[] {"Антибактериалные препараты"},
                    new KeyboardButton[] {"Противовирусные препараты"},
                    new KeyboardButton[] {"Средства ухода за животными"},
                    new KeyboardButton[] {"Дезинфицирующие препараты"},
                    new KeyboardButton[] {"Главное меню"}
                });
                await botClient.SendTextMessageAsync(chatId: chatId, text: "Новая вкладка открыта", replyMarkup: start);
            }

            if (message.Equals("Преобрести корм"))
            {
                isfind = true;
                ReplyKeyboardMarkup start = new ReplyKeyboardMarkup(new[]
                {
                    new KeyboardButton[] {"Эконом-класс"},
                    new KeyboardButton[] {"Премиум-класс"},
                    new KeyboardButton[] {"Супер-премиум класс"},
                    new KeyboardButton[] {"Главное меню"}
                });
                await botClient.SendTextMessageAsync(chatId: chatId, text: "Новая вкладка открыта", replyMarkup: start);
            }

            if (message.Equals("Главное меню"))
            {
                isfind = true;
                ReplyKeyboardMarkup start = new ReplyKeyboardMarkup(new[]
                {
                    new KeyboardButton[] {"Преобрести животное"},
                    new KeyboardButton[] {"Купить ветеринарные аппараты"},
                    new KeyboardButton[] { "Преобрести корм" }
                });
                await botClient.SendTextMessageAsync(chatId: chatId, text: "Возврат на главное меню", replyMarkup: start);
            }

            if (message.Equals("Рыбы"))
            {

                isfind = true;
                StreamReader sr = new StreamReader("C:\\\\Users\\USER\\Desktop\\\\Рыбы.jpg");
                var photo = new InputOnlineFile(sr.BaseStream, "Рыбы.jpeg");
                await botClient.SendPhotoAsync(chatId: chatId, photo: photo, caption: "Рыбы.\n\nРыбами называют всех позвоночных, которые дышат жабрами, имеют парные конечности в виде плавников. " +
                    "По способу питания рыбы бывают хищными, растительноядными и всеядными. " +
                    "В нашем зоомагазине существует многожество видов рыб " +
                    "Золотые рыбки,монодактиловые,пецилиевые,скатофаговые,гуппи, меченосцы, моллинезии и многие другие.");
            }

            if (message.Equals("Грызуны"))
            {

                isfind = true;
                StreamReader sr = new StreamReader("C:\\\\Users\\USER\\Desktop\\\\Грызуны.jpg");
                var photo = new InputOnlineFile(sr.BaseStream, "Грызуны.jpg");
                await botClient.SendPhotoAsync(chatId: chatId, photo: photo, caption: "Грызуны\n\nГрызуны – это самый многочисленный отряд во всем классе Млекопитающие." +
                    "Грызуны обитают по всей поверхности суши, за исключением Антарктиды. В связи с огромным видовым разнообразием отряда, внешность грызунов бывает самой разнообразной. Длина тела может быть от 5 до 130 см, как у капибары. " +
                    "Но в большинстве случаев это мелкие или средние зверьки. " +
                    "Места обитания грызунов различные. Представители этого отряда живут как на открытых ландшафтах, так и в лесах. Некоторые из них обитают на деревьях. Многие виды грызунов ведут полуподземный образ жизни. Жизнь некоторых видов связана с водой." +
                    "В нашем зоомагазине начитывается около 100 видов грызунов." +
                    "Сурки, белки,хомячки,нутрии, ондатры,песчанки, суслики и многие другие.");
            }
            if (message.Equals("Птицы"))
            {

                isfind = true;
                StreamReader sr = new StreamReader("C:\\\\Users\\USER\\Desktop\\\\Попугай.jpg");
                var photo = new InputOnlineFile(sr.BaseStream, "Попугай.jpg");
                await botClient.SendPhotoAsync(chatId: chatId, photo: photo, caption: "Птицы\n\n Птицы-это группа теплокровных позвоночных, составляющих класс Aves /ˈeɪviːz/, характеризующихся перьями, беззубыми клювастыми челюстями, откладыванием яиц в твердой скорлупе, высокой скоростью метаболизма, четырехкамерным сердцем и прочным, но легким скелетом." +
                    "Крылья помогают большинству птиц летать. Это умение помогло им распространиться во всех уголках земного шара." +
                    "Тело птиц покрыто перьями. Они нужны для того, чтобы сохранить тепло, маскироваться и летать: перья придают крыльям и телу птиц обтекаемую форму, которая позволяет быстро перемещаться в воздухе. " +
                    "Многие птицы строят гнёзда, в которых откладывают яйца. Затем они согревают яйца своим теплом — насиживают. Из яиц вылупляются птенцы, которые вырастают во взрослых птиц." +
                    "В нашем зоомагазине начитывается около 90 видов птиц." +
                    "Попугаи, канарейки, какаду, амазоны и многие другие.");
            }
            if (message.Equals("Кошки,собаки"))
            {

                isfind = true;
                StreamReader sr = new StreamReader("C:\\\\Users\\USER\\Desktop\\\\Кошки.jpg");
                var photo = new InputOnlineFile(sr.BaseStream, "Кошки.jpg");
                await botClient.SendPhotoAsync(chatId: chatId, photo: photo, caption: "Кошки/собаки\n\n Кошка (Felis catus) - это домашний вид мелких плотоядных млекопитающих. Это единственный одомашненный вид семейства кошачьих, и его часто называют домашней кошкой, чтобы отличить ее от диких членов семейства. Кошка может быть домашней кошкой, фермерской кошкой или дикой кошкой; последняя свободно передвигается и избегает человеческого контакта. Домашние кошки ценятся людьми за общение и их способность охотиться на грызунов." +
                    "\n\nС зоологической точки зрения, собака — плацентарное млекопитающее отряда хищных семейства псовых. Собаки известны своими способностями к обучению, любовью к игре, социальным поведением. Выведены специальные породы собак, предназначенные для различных целей: охоты, охраны, тяги гужевого транспорта и другого, а также декоративные породы (например, болонка, пудель)." +
                    "В нашем зоомагазине большой выбор кошей и собак. ");

            }


            if (message.Equals("Антибактериалные препараты"))
            {
                isfind = true;
                StreamReader sr = new StreamReader("C:\\\\Users\\USER\\Desktop\\\\Антибактериалные препараты.jpg");
                var photo = new InputOnlineFile(sr.BaseStream, "Антибактериалные препараты.jpg");
                await botClient.SendPhotoAsync(chatId: chatId, photo: photo, caption: "Антибактериалные препараты\n\nимические вещества, обладающие способностью избирательно подавлять рост (размножение) или вызывать разрушение (лизис) микробных клеток (бактерий)." +
                    "Выбор стартового препарата должен учитывать:\r\n- микрофлору, вызвавшую инфекционный процесс;\r\n- проникновение препарата в очаг инфекции и создание терапевтической\r\nконцентрации;\r\n" +
                    "К принципам рациональной антибактериальной терапии также относится:\r\n• Раннее начало лечения.\r\n• Оценка эффективности через 48 час (по динамике клинического состояния).\r\n• Достаточная продолжительность лечения (по стандартам терапии).\r\n• Контроль побочного действия (клинический, лабораторный и др.)." +
                    "Более подробнее читайте на https://www.rzgmu.ru ." +
                    " В нашем зоомагазине Вы сможете приобрести действующие антибактериальные препараты, которые помогут адаптироваться вашим зверушкам");
            }

            if (message.Equals("Противовирусные препараты"))
            {
                isfind = true;
                StreamReader sr = new StreamReader("C:\\\\Users\\USER\\Desktop\\\\Противовирусные препараты.jpeg");
                var photo = new InputOnlineFile(sr.BaseStream, "Противовирусные препараты.jpeg");
                await botClient.SendPhotoAsync(chatId: chatId, photo: photo, caption: "Противовирусные препараты\n\n" +
                    "Класс лекарств, используемых для лечения вирусных инфекций. Большинство антивирусных препаратов нацелены на конкретные вирусы, в то время как противовирусные препараты широкого спектра действия эффективны против широкого спектра вирусов.");
            }

            if (message.Equals("Средства ухода за животными"))
            {
                isfind = true;
                StreamReader sr = new StreamReader("C:\\\\Users\\USER\\Desktop\\\\Средства ухода за животными.jpg");
                var photo = new InputOnlineFile(sr.BaseStream, "Средства ухода за животными.jpg");
                await botClient.SendPhotoAsync(chatId: chatId, photo: photo, caption: "Средства ухода за животными\n\n" +
                    "Содержание домашнего питомца в чистоте, является основным залогом его хорошего здоровья. Регулярная обработка ушей и глаз, не менее важная процедура, чем кормление.Наш интернет зоомагазин представляет качественные средства по уходу за домашними животными." +
                    "На сегодняшний день существует большой ассортимент для ухода ха животными. В состав некоторых гигиенических средств входят ионы серебра, а также учитываются особенности анатомии домашних питомцев. " +
                    "Ионы Ag+ (серебра) обладают бактерицидными свойствами, которые не вызывают аллергию и интоксикацию. А микроэлемент серебро принимает участвует в работе внутренних органов и функционировании систем организма и способствует повышению иммунитета у животных." +
                    "Используя гигиенические средства для животных вы легко и быстро сможете соблюдать все необходимые правила гигиены для Вашего домашнего питомца.");
            }

            if (message.Equals("Дезинфицирующие препараты"))
            {
                isfind = true;
                StreamReader sr = new StreamReader("C:\\\\Users\\USER\\Desktop\\\\Дезинфицирующие препараты.jpg");
                var photo = new InputOnlineFile(sr.BaseStream, "Дезинфицирующие препараты.jpg");
                await botClient.SendPhotoAsync(chatId: chatId, photo: photo, caption: "Дезинфицирующие препараты\n\n" +
                    "Современные средства дезинфекции, в зависимости от инактивирующих факторов подразделяют на несколько групп: химические, физически, биологические и комбинированные. Среди этих групп наибольшее распространение получили средства, основанные на использовании химических инактивирующих веществ – дезинфектантов.");
            }

            if (message.Equals("Эконом-класс"))
            {
                isfind = true;
                StreamReader sr = new StreamReader("C:\\\\Users\\USER\\Desktop\\\\Эконом-класс.jpeg");
                var photo = new InputOnlineFile(sr.BaseStream, "Эконом-класс.jpeg");
                await botClient.SendPhotoAsync(chatId: chatId, photo: photo, caption: "Особенности кормов эконом-класса\n\nБольшую долю в составе этих кормов занимают злаки и кукуруза. Какие именно злаки присутствуют в кормах эконом-класса, некоторые производители часто не уточняют. Пишут так: «ингредиенты растительного происхождения». " +
                    "Источник белка в эконом кормах — растительный белок: кукурузный глютен и разные экстракты растительного происхождения.Мясные ингредиенты: мука животного происхождения, в том числе и птицы, немного мяса, субпродукты присутствуют в меньшем количестве. Качество таких ингредиентов оставляет желать лучшего.");

            }
            if (message.Equals("Премиум-класс"))
            {
                isfind = true;
                StreamReader sr = new StreamReader("C:\\\\Users\\USER\\Desktop\\\\Премиум-класс.jpg");
                var photo = new InputOnlineFile(sr.BaseStream, "Премиум-класс.jpg");
                await botClient.SendPhotoAsync(chatId: chatId, photo: photo, caption: "Особенности кормов премиум-класса\n\nОсновное отличие кроется в качестве ингредиентов. Содержание мяса, рыбы или птицы в таком корме выше, но даже в лучших вариантах – не более 25 %. Среди других ингредиентов – снова злаки, растительный белок и жиры. Возможны консерванты и усилители вкуса. " +
                    "Линейки таких кормов более разнообразны – есть множество вариантов в зависимости от возраста животного и его породы, а также наличия или отсутствия стерилизации.");

            }
            if (message.Equals("Супер-премиум класс"))
            {
                isfind = true;
                StreamReader sr = new StreamReader("C:\\\\Users\\USER\\Desktop\\\\Супер-премиум класс.jpeg");
                var photo = new InputOnlineFile(sr.BaseStream, "Супер-премиум класс.jpeg");
                await botClient.SendPhotoAsync(chatId: chatId, photo: photo, caption: "Особенности кормов супер-премиум класса\n\nТакие корма содержат 25 или более процентов натурального мяса, а его источник указан совершенно четко – не абстрактные «мясо», «мясо птицы» или «рыба», а «ягнятина», «индейка» или «лосось». " +
                    "В состав корма могут входить консерванты и антиоксиданты, но натурального происхождения. Качество витаминно-минеральных добавок тоже выше, чем у кормов предыдущих двух категорий. Продается такое питание в зоомагазинах и ветеринарных клиниках.");

            }



            if (!isfind)
            {
                await botClient.SendTextMessageAsync(chatId: chatId, text: "Мне не понятно ваше сообщение");
            }
        }

        public static async Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(exception));
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Запущен бот " + bot.GetMeAsync().Result.FirstName);

            var cts = new CancellationTokenSource();
            var cancellationToken = cts.Token;
            var receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = { },
            };
            bot.StartReceiving(
                HandleUpdateAsync,
                HandleErrorAsync,
                receiverOptions,
                cancellationToken
            );
            Console.ReadLine();
        }
    }
}