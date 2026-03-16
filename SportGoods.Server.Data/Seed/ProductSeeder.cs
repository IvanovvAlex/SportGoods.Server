using SportGoods.Server.Data.Entities;

namespace SportGoods.Server.Data.Seed
{
    public static class ProductSeeder
    {
        public static async Task SeedAsync(ApplicationDbContext db)
        {
            if (db.Products.Any())
            {
                return;
            }

            List<Category> categories = db.Categories.ToList();
            List<User> users = db.Users.ToList();

            
            List<Product> products =
            [
                new()
                {
                    Title = "Регулируеми дъмбели Bodyflex 2x15кг + допълнителен лост щанга",
                    Description = "<ul><li><strong>Комплект дъмбели Bodyflex 2 бр х 15кг = 30кг&nbsp;+ допълнителен трети лост-конектор. Който</strong>&nbsp;позволява да ползвате дъмбелите като щанга.</li><li>Ръкохватката при захвата е покрита с твърдо гумено покритие, за лесно захващане и за да не наранява дланите на трениращия.</li><li>Двата дъмбела са разглобяеми и <strong>комплектът&nbsp;включва:</strong><br>Дискове с отвор Ф28: 4бр.х1,25кг, 4бр.х1,5кг, 4бр.х2,0кг; 4бр.х2,5кг.<br>Ръкохватка 2бр. (25см)&nbsp;и 4 гайки.<br>Допълнителен лост-адаптор (41 см), с който може сглобите щанга.&nbsp;</li><li>Произведен е от нетоксични материали.</li><li>По дисковете може да има следи от прах в следствие на производството.</li><li>Дисковете на дъмбела са със здраво PVC винилово покритие.</li><li>Снимките са информативни и цветовете могат да варират в зависимост от дисплея, на който ги гледате.&nbsp;</li><li>Цената е за 2 броя&nbsp;дъмбели комплект + лост конектор.</li><li>Tегло на дълбелите: 2x15 = 30кг.<br><br>➤ 【<strong>РЕГУЛИРАНЕ НА ТЕГЛОТО</strong>】: Дъмбелите може да се свържат чрез лостове, за да станат щанги, които са&nbsp;твърди&nbsp;и здрави. Този комплект домашен фитнес уред има много възможности за тренировка може да отговори напълно на нуждите от упражнения за горни и долни крайници. Този комплект Ви позволява&nbsp;да тренирате по всяко време и навсякъде!<br>➤ <strong>【ПРОТИВОХЛЪЗГАЩ ДИЗАЙН】</strong>: Ръкохватките&nbsp;са&nbsp;покрити с гумено покритие, за да се осигури здраво захващане, което помага за по-добра и безопасна&nbsp;тренировка.&nbsp;Дисковете имат&nbsp;захват за пръстите за лесно преместване.<br>➤ 【<strong>ЗДРАВИ И ФИТНЕС</strong>】: Нашият фитнес комплект с тежести и&nbsp;щанга Bodyflex&nbsp;работи чудесно и дава възможости за десетки&nbsp;фитнес упражнения. Помага за трениране и укрепване на вашите прасци, гърди, глутеуси, седалище, корем, бицепс, трицепс, крака и колене у дома. С това толкова ефективното фитнес оборудване изгарянето&nbsp;на мазнини и оформянето на мускулатурата&nbsp;е съвсем&nbsp;лесно.<br>➤ 【<strong>ЛЕСНО ЗА СЪХРАНЕНИЕ И УПОТРЕБА</strong>】: &nbsp;Дъмбелите&nbsp;могат да бъдат сглобени и разглобени&nbsp;за секунди. Свързващият прът е покрит със специално покритие, за да осигури удобно захващане, дръжката на гирите е покрита с гума, за да се предотврати лесно плъзгане от ръцете. Материалът на уреда при правилна употреба не подлежи на износване. Покритието на дъмбелите предпазва пода от нараняване по време на тренировка.<br>➤ 【<strong>РАЗМЕР НА ДИСКОВЕТЕ</strong>】<strong>:</strong>&nbsp;2.50 кг&nbsp;- 21.3 x 4.0 cm; 2.00 кг&nbsp;- 19.5 x 3.7 cm; 1.50 кг&nbsp;- 18.1 x 3.2 cm; 1.25 кг&nbsp;- 17.5 x 2.9 cm<br><br><u><strong><a href=\"/dokumenti/upatvane-dambel-bodyflex-cd30-2x15kg.pdf\">УПЪТВАНЕ ЗА ЕКСПЛОАТАЦИЯ</a></strong></u><br><br>&nbsp;<div data-oembed-url=\"https://youtu.be/UDP0IP9TW7I\"><div style=\"margin-bottom:0px; margin-left:0px; margin-right:0px; margin-top:0px; max-width:320px\"><!-- You're using demo endpoint of Iframely API commercially. Max-width is limited to 320px. Please get your own API key at https://iframely.com. --><div style=\"height:0; left:0; padding-bottom:56.25%; position:relative; width:100%\"></div></div></div><p>&nbsp;</p></li></ul>",
                    MainImageUrl = "https://sportensklad.bg/image/cache/webp/catalog/FITNES_UREDI/tejesti/reguliruemi-dambeli-bodyflex-2x15kg-i-lost-adaptor----700x700.webp",
                    RegularPrice = 205m,
                    DiscountPercentage = 46,
                    DiscountedPrice = 109m,
                    Quantity = 400,
                    Rating = 5,
                    CategoryId = categories.First(c => c.Name == "Фитнес").Id,
                    SecondaryImages = new List<Image>
                    {
                        new() { Uri = "https://sportensklad.bg/image/cache/webp/catalog/FITNES_UREDI/tejesti/reguliruemi-dambeli-bodyflex-2x15kg-i-lost-stanga%20_3_-700x700.webp" },
                        new() { Uri = "https://sportensklad.bg/image/cache/webp/catalog/FITNES_UREDI/tejesti/reguliruemi-dambeli-bodyflex-2x15kg-i-lost-stanga%20_8_-700x700.webp" },
                        new() { Uri = "https://sportensklad.bg/image/cache/webp/catalog/FITNES_UREDI/tejesti/reguliruemi-dambeli-bodyflex-2x15kg-i-lost-stanga%20_5_-700x700.webp" },
                        new() { Uri = "https://sportensklad.bg/image/cache/webp/catalog/FITNES_UREDI/tejesti/reguliruemi-dambeli-bodyflex-2x15kg-i-lost-stanga%20_2_-700x700.webp" },
                        new() { Uri = "https://sportensklad.bg/image/cache/webp/catalog/FITNES_UREDI/tejesti/reguliruemi-dambeli-bodyflex-2x15kg-i-lost-stanga%20_4_-700x700.webp" },
                    },
                    Reviews = new List<Review>
                    {
                        new()
                        {
                            UserId = users.First().Id,
                            Content = "Отличен продукт!",
                            Rating = 5
                        }
                    }
                },
                new()
                {
                    Title = "Комбиниран уред MASTER Poseidon",
                    Description = "<ul><li>Гладиатор с регулируема конструкция, подходящ за доста от най-популярнитеупржнения.</li><li>Могат да се правят най-популярните упражнения за всички мускулни групи: пеперуда, лег, дърпане, упражниения за крака, гребане, бицепс, трицепс и много други.</li><li>Има стойка за кофички и регулируема лежанка прикрепени към уреда.</li><li>Регулируема скотова пейка.</li><li>Здрава стоманена конструкция.</li><li>Висококачествено покритие на металните части</li><li>Покрити, вградени тежести 65 кг.</li><li>Ролките са с лагери.</li><li>Това е силов комбиниран фитнес уред, при който чрез насочено упражнение към дадена мускулна група се получава желаният ефект за оформянето и.</li><li>&nbsp;Максимално тегло на потребителя: 120 кг</li><li>&nbsp;Максимална височина на трениращия: 190см</li><li>&nbsp;Размери: 168 х 172 х 203 см</li><li>&nbsp;Тегло: 154кг</li><li>&nbsp;Вариант: сив / червен (EAN: 8592833001153)</li><li>&nbsp;Брой кашони в опаковка: 4</li><li>&nbsp;Размери опаковка (Д x Ш x В):</li></ul><p>&nbsp;</p><ol><li style=\"margin-left: 40px;\">&nbsp;<span style=\"line-height:1.0\">28 х 165 х 55 см</span></li><li style=\"margin-left: 40px;\"><span style=\"line-height:1.0\">&nbsp;20 х 201 х 35 см</span></li><li style=\"margin-left: 40px;\"><span style=\"line-height:1.0\">&nbsp;27 х 40 х 20 см</span></li><li style=\"margin-left: 40px;\"><span style=\"line-height:1.0\">&nbsp;27 х 40 х 20 см</span></li></ol><p style=\"margin-left:40px\">&nbsp;</p><p><u><strong><a href=\"https://sportensklad.bg/dokumenti/Upatvane-gladiator_master74784.pdf\"><span style=\"color:#000000\">Упътване за експлоатация</span></a></strong></u></p>",
                    MainImageUrl = "https://sportensklad.bg/image/cache/webp/catalog/FITNES_UREDI/kombinirani-uredi/MAS-HG1104-kombiniran-ured-master-poseidon-700x700.webp",
                    RegularPrice = 1883.24m,
                    DiscountPercentage = 0,
                    DiscountedPrice = 0m,
                    Quantity = 25,
                    Rating = 5,
                    CategoryId = categories.First(c => c.Name == "Фитнес").Id,
                    SecondaryImages = new List<Image>
                    {
                        new() { Uri = "https://sportensklad.bg/image/cache/webp/catalog/mastersport/mas-hg1104MAS-HG1104_22-700x700.webp" },
                        new() { Uri = "https://sportensklad.bg/image/cache/webp/catalog/mastersport/mas-hg1104MAS-HG1104_22b-700x700.webp" },
                        new() { Uri = "https://sportensklad.bg/image/cache/webp/catalog/mastersport/mas-hg1104MAS-HG1104_22c-700x700.webp" },
                        new() { Uri = "https://sportensklad.bg/image/cache/webp/catalog/mastersport/mas-hg1104MAS-HG1104_22d-700x700.webp" },
                        new() { Uri = "https://sportensklad.bg/image/cache/webp/catalog/mastersport/mas-hg1104MAS-HG1104_22d_2-700x700.webp" },
                    },
                    Reviews = new List<Review>
                    {
                        new()
                        {
                            UserId = users.First().Id,
                            Content = "Отличен продукт!",
                            Rating = 5
                        }
                    }
                },
                new()
                {
                    Title = "Бягаща пътека Bodyflex Run 1200, електрическа",
                    Description = "<ul> <li><strong>Мотор: до 1,3&nbsp;к.с</strong> и<strong>&nbsp;</strong>Скорост 1-6 км/ч.</li> <li>Бягаща повърхност: 103 х 39 cm.<br> &nbsp;</li> <li><strong>Най-добра цена:</strong> В съотношение на характеристики и цена, гарантирано на-добрата цена на пазара.</li> <li><strong>LCD дисплей:</strong> Показва скорост, време, изминато разстояние и изгорени калории.</li> <li><strong>Дистанционно управление:</strong> Удобство и контрол върху пътеката и дисплея.</li> <li><strong>Поставка за лаптоп или телефон:</strong> Позволява мултитаскинг по време на тренировка.</li> <li><strong>Скоростни настройки:</strong> Гъвкава скорост от 1 до 6 км/ч е&nbsp;идеална както за бързо ходене, така и за лек крос.&nbsp; Електричски мотор до 1,3к.с за дълга употреба.&nbsp;</li> <li><strong>Просторна бягаща повърхност:</strong> Размери 103 х 39 см, осигуряващи достатъчно пространство за комфортна тренировка.<br> &nbsp;</li> <li><strong>Здравословен ефект:</strong> Подобрява физическата издръжливост, укрепва сърцето и белите дробове, и допринася за загубата на излишни килограми.</li> <li><strong>Сгъваема и компактна:</strong> Лесно се съхранява и премества с транспортните колела, като заема минимално пространство. Може да се съхранява под леглото.</li> <li><strong>Максимално тегло на потребителя:</strong> До 100 кг.</li> <li><strong>Сертифицирана безопасност:</strong> Отговаря на стандартите HC-EN957 и CE.<br> &nbsp;</li> <li><strong>Разгъната:</strong> (ДШВ) 122 х 58 х 106 см.</li> <li><strong>Размер на кашона:</strong> (ДШВ) 141 х 61 х 15 см.</li> <li><strong>Тегло:</strong> 25 кг.<br> <br> BODYFLEX RUN 1200 е идеалният избор за всеки, който иска да поддържа активен и здравословен начин на живот в уюта на собствения си дом. Забравете за скучните тренировки и се насладете на вълнуващите и ефективни упражнения с тази високотехнологична бягаща пътека.&nbsp;<br> Превърнете дома си в личен фитнес със съвременната и високоефективна бягаща пътека. Този продукт е създаден, за да отговори на всички вашите тренировъчни нужди, като съчетава ергономичност, функционалност и удобство.<br> <br> <span style=\"color:#000000\"></span></li> <li> <p><u><strong><a href=\"/smazvane-biagasta-pateka\"><span style=\"color:#000000\">СМАЗВАНЕ НА ПЪТЕКАТА</span></a></strong></u></p> </li> <li> <p><a href=\"/dokumenti/bodyflex/upatvane-biagasta-pateka-bodyflex-run-1200--BF-39004.pdf\"><u><strong>УПЪТВАНЕ ЗА ЕКСПЛОАТАЦИЯ</strong></u></a></p> </li> </ul>",
                    MainImageUrl = "https://sportensklad.bg/image/cache/webp/catalog/FITNES_UREDI/biagashti-pateki/biagasta-pateka-bodyflex-run-1200--BF-39004-700x700.webp",
                    RegularPrice = 790m,
                    DiscountPercentage = 39,
                    DiscountedPrice = 478m,
                    Quantity = 125,
                    Rating = 4,
                    CategoryId = categories.First(c => c.Name == "Фитнес").Id,
                    SecondaryImages = new List<Image>
                    {
                        new() { Uri = "https://sportensklad.bg/image/cache/webp/catalog/FITNES_UREDI/biagashti-pateki/biagasta-pateka-bodyflex-run-1200--BF-39004--3-700x700.webp" },
                        new() { Uri = "https://sportensklad.bg/image/cache/webp/catalog/FITNES_UREDI/biagashti-pateki/biagasta-pateka-bodyflex-run-1200--BF-39004--6-700x700.webp" },
                        new() { Uri = "https://sportensklad.bg/image/cache/webp/catalog/FITNES_UREDI/biagashti-pateki/byagashta-pateka-bodyflex-run-1200-elektricheska-13-700x700.webp" },
                        new() { Uri = "https://sportensklad.bg/image/cache/webp/catalog/FITNES_UREDI/biagashti-pateki/biagasta-pateka-bodyflex-run-1200--BF-39004-700x700.webp" },
                        new() { Uri = "https://sportensklad.bg/image/cache/webp/catalog/FITNES_UREDI/biagashti-pateki/byagashta-pateka-bodyflex-run-1200-elektricheska-9-700x700.webp" },
                    },
                    Reviews = new List<Review>
                    {
                        new()
                        {
                            UserId = users.First().Id,
                            Content = "Много добър продукт.",
                            Rating = 4
                        }
                    }
                },
                new()
                {
                    Title = "Мрежа MASTER Kombi, с регулируема височина",
                    Description = "<ul> <li><span class=\"VIiyi\"><span class=\"ChMk0b JLqJ4b\"><span>Мултифункционалната мрежа MASTER Kombi с регулируема височина е подходяща за бадминтон, волейбол или тенис.</span></span></span></li> <li>Мрежа: 300 х 73 см.</li> <li><span class=\"VIiyi\"> <span class=\"ChMk0b JLqJ4b\"><span>Размер на окото: 18 x 18 мм</span></span></span></li> <li><span class=\"VIiyi\"><span class=\"ChMk0b JLqJ4b\"><span>Метална конструкция с регулируема височина 250/150/82 см </span></span></span></li> <li><span class=\"VIiyi\"><span class=\"ChMk0b JLqJ4b\"><span>Диаметър на металните тръби: 1,8 см</span></span></span></li> <li>Тегло: 1,500 кг</li> </ul>",
                    MainImageUrl = "https://sportensklad.bg/image/cache/webp/catalog/mastersport/mas-b065MAS-B065-700x700.webp",
                    RegularPrice = 156.40m,
                    DiscountPercentage = 12,
                    DiscountedPrice = 137.63m,
                    Quantity = 15,
                    Rating = 5,
                    CategoryId = categories.First(c => c.Name == "Тенис").Id,
                    SecondaryImages = new List<Image>
                    {
                        new() { Uri = "https://sportensklad.bg/image/cache/webp/catalog/mastersport/mas-b065MAS-B065a-700x700.webp" },
                        new() { Uri = "https://sportensklad.bg/image/cache/webp/catalog/mastersport/mas-b065MAS-B065_new-700x700.webp" },
                        new() { Uri = "https://sportensklad.bg/image/cache/webp/catalog/mastersport/mas-b065MAS-B065c-700x700.webp" },
                    },
                    Reviews = new List<Review>
                    {
                        new()
                        {
                            UserId = users.First().Id,
                            Content = "Отличен продукт!",
                            Rating = 5
                        }
                    }
                },
                new()
                {
                    Title = "Тенис грип Spartan Soft 60",
                    Description = "<ul> <li><span><span></span> <span></span><span>Цвят син.</span></span></li> <li><span><span>дебелина</span> <span>0,75</span> <span>мм</span></span></li> <li><span><span></span><span>60 броя</span> <span>в</span> <span>опаковка</span></span></li> </ul>",
                    MainImageUrl = "https://sportensklad.bg/image/cache/webp/catalog/SPORTNI_STOKI/tenis-na-kort/tenis-grip-spartan-soft-60-700x700.webp",
                    RegularPrice = 111.78m,
                    DiscountPercentage = 0,
                    DiscountedPrice = 0m,
                    Quantity = 40,
                    Rating = 5,
                    CategoryId = categories.First(c => c.Name == "Тенис").Id,
                    Reviews = new List<Review>
                    {
                        new()
                        {
                            UserId = users.First().Id,
                            Content = "Отличен продукт!",
                            Rating = 5
                        }
                    }
                },
                new()
                {
                    Title = "Топки за скуош SPARTAN - двойно жълта точка",
                    Description = " <p>Топки за скуош с възможни цветове точки:</p> <ul> <li>Синя - бърза</li> <li>Червена - средна</li> <li>Бяла - бавна</li> <li>Жълта - много бавна</li> <li>Двойно жълта - много екстра бавна</li> </ul>",
                    MainImageUrl = "https://sportensklad.bg/image/cache/webp/catalog/SPORTNI_STOKI/tenis-na-kort/topki-za-skuosh-S2448-700x700.webp",
                    RegularPrice = 5.52m,
                    DiscountPercentage = 11,
                    DiscountedPrice = 4.86m,
                    Quantity = 20,
                    Rating = 5,
                    CategoryId = categories.First(c => c.Name == "Тенис").Id,
                    Reviews = new List<Review>
                    {
                        new()
                        {
                            UserId = users.First().Id,
                            Content = "Отличен продукт!",
                            Rating = 5
                        }
                    }
                },
                new()
                {
                    Title = "Футболна топка SPARTAN Club Junior 3",
                    Description = "<ul> <li>Футбол топка размер 3.</li> <li>Панели: 32</li> <li>Материал: изкуствена кожа</li> <li>Моля, разгънете топката преди да я напомпате.</li> <li>Тегло:500 г</li> </ul> <p>&nbsp;</p> <p>&nbsp;</p>",
                    MainImageUrl = "https://sportensklad.bg/image/cache/webp/catalog/SPORTNI_STOKI/futbol1/topki/futbolna-topka-spartan-s42-700x700.webp",
                    RegularPrice = 47.38m,
                    DiscountPercentage = 12,
                    DiscountedPrice = 41.69m,
                    Quantity = 20,
                    Rating = 5,
                    CategoryId = categories.First(c => c.Name == "Футбол").Id,
                    Reviews = new List<Review>
                    {
                        new()
                        {
                            UserId = users.First().Id,
                            Content = "Отличен продукт!",
                            Rating = 5
                        }
                    }
                },
                new()
                {
                    Title = "Футболна врата SPARTAN Quick Set Up 270 x 150 cm",
                    Description = "<p>Олекотена, компактна, лесна за транспортиране футболна врата SPARTAN Quick Set.</p> <p>Технически данни:</p> <ul> <li>Футболна врата в комплект с мрежа,чанта, щифтове за закрепяне към земята</li> <li>Размери: 270 х 150 см</li> <li>Предназначена за тренировка и забавления</li> <li>Подходяща за открито</li> <li>Лесно транспортиране</li> <li>Лесно съхранение</li> <li>Бързо сглобяване и разглобяване</li> <li>Посочената цена за 1 бр.</li> <li>Тегло: 2.8 кг</li> </ul>",
                    MainImageUrl = "https://sportensklad.bg/image/cache/webp/catalog/mastersport/s1137S1137_23-700x700.webp",
                    RegularPrice = 145.36m,
                    DiscountPercentage = 0,
                    DiscountedPrice = 0m,
                    Quantity = 12,
                    Rating = 0,
                    CategoryId = categories.First(c => c.Name == "Футбол").Id,
                    SecondaryImages = new List<Image>
                    {
                        new() { Uri = "https://sportensklad.bg/image/cache/webp/catalog/mastersport/s1137S1137_23a-700x700.webp" },
                    },
                    Reviews = new List<Review>
                    {
                        new()
                        {
                            UserId = users.First().Id,
                            Content = "Пълна нула!",
                            Rating = 0
                        }
                    }
                },
                new()
                {
                    Title = "Футболна врата MASTER Д: 182 x В: 122 x Ш: 61см",
                    Description = "<ul> <li>Футболна стоманена врата с мрежа.</li> <li>Размер: Д: 182 x В: 122 см х Ш: 61 см</li> <li>Щифтове с диаметър 22 мм</li> <li>Фиксиращи щифтове</li> <li>Прахово покритие</li> </ul>",
                    MainImageUrl = "https://sportensklad.bg/image/cache/webp/catalog/master-pic-upload/futbolna-vrata-MASSPSO-0006-700x700.webp",
                    RegularPrice = 79.58m,
                    DiscountPercentage = 0,
                    DiscountedPrice = 0m,
                    Quantity = 123,
                    Rating = 5,
                    CategoryId = categories.First(c => c.Name == "Футбол").Id,
                    SecondaryImages = new List<Image>
                    {
                        new() { Uri = "https://sportensklad.bg/image/cache/webp/catalog/mastersport/masspso-0006MASSPSO-0006-700x700.webp" },
                        new() { Uri = "https://sportensklad.bg/image/cache/webp/catalog/mastersport/masspso-0006MASSPSO-0006a-700x700.webp" },
                    },
                    Reviews = new List<Review>
                    {
                        new()
                        {
                            UserId = users.First().Id,
                            Content = "Отличен продукт!",
                            Rating = 5
                        }
                    }
                },
                new()
                {
                    Title = "Баскетболна топка SPALDING Silver Series,",
                    Description = "<ul> <li>Баскетболна топка размер 7 за тренировки&nbsp;на открито и&nbsp;закрито.</li> <li>Гуменият материал е много приятен на допир и в същото време достатъчно здрав, за да позволи игра на открито</li> <li>Може да с",
                    MainImageUrl = "https://sportensklad.bg/image/cache/webp/catalog/SPORTNI_STOKI/basketbol/basketbolna-topka-spalding-silver-series-razmer-7-700x700.webp",
                    RegularPrice = 82.86m,
                    DiscountPercentage = 11,
                    DiscountedPrice = 72.86m,
                    Quantity = 12,
                    Rating = 3,
                    CategoryId = categories.First(c => c.Name == "Баскетбол").Id,
                    Reviews = new List<Review>
                    {
                        new()
                        {
                            UserId = users.First().Id,
                            Content = "Добър продукт.",
                            Rating = 3
                        }
                    }
                },
                new()
                {
                    Title = "Баскетболен ринг MASTER 45 см с мрежа",
                    Description = "<ul> <li>Баскетболен ринг с мрежа.</li> <li>Диаметър на ринга 45 см ( подходящ за топка размер 7) .</li> <li>Материал: стомана 16 мм</li> <li>Размер на планката за закрепяне: <span class=\"VIiyi\" jsaction=\"mouseup:BR6jm\" jsname=\"jqKxS\" lang=\"bg\"><span class=\"JLqJ4b ChMk0b\" data-language-for-alternatives=\"bg\" data-language-to-translate-into=\"en\" data-number-of-phrases=\"23\"= data-phrase-index=\"12\" jsaction=\"agoMJf:PFBcW;usxOmf:aWLT7;jhKsnd:P7O7bd,F8DmGf;Q4AGo:Gm7gYd,qAKMYb;uFUCPb:pvnm0e,pfE8Hb,PFBcW;f56efd:dJXsye;EnoYf:KNzws,ZJsZZ,JgVSJc;zdMJQc:cCQNKb,ZJsZZ,zchEXc;Ytrrj:JJDvdc;tNR8yc:GeFvjb;oFN6Ye:hij5Wb;bmeZHc:iURhpf;Oxj3Xe:qAKMYb,yaf12d\" jscontroller=\"Zl5N8\" jsdata=\"uqLsIf;_;$25\" jsmodel=\"SsMkhd\" jsname=\"txFAF\"><span class=\"Q4iAWc\" jsaction=\"click:qtZ4nf,GFf3ac,tMZCfe; contextmenu:Nqw7Te,QP7LD; mouseout:Nqw7Te; mouseover:qtZ4nf,c2aHje\" jsname=\"W297wb\">11 х 12 см</span></span><span class=\"JLqJ4b\" data-language-for-alternatives=\"bg\" data-language-to-translate-into=\"en\" data-number-of-phrases=\"23\" data-phrase-index=\"13\" jsaction=\"agoMJf:PFBcW;usxOmf:aWLT7;jhKsnd:P7O7bd,F8DmGf;Q4AGo:Gm7gYd,qAKMYb;uFUCPb:pvnm0e,pfE8Hb,PFBcW;f56efd:dJXsye;EnoYf:KNzws,ZJsZZ,JgVSJc;zdMJQc:cCQNKb,ZJsZZ,zchEXc;Ytrrj:JJDvdc;tNR8yc:GeFvjb;oFN6Ye:hij5Wb;bmeZHc:iURhpf;Oxj3Xe:qAKMYb,yaf12d\" jscontroller=\"Zl5N8\" jsdata=\"uqLsIf;_;$26\" jsmodel=\"SsMkhd\" jsname=\"txFAF\"><span class=\"Q4iAWc\" jsaction=\"click:qtZ4nf,GFf3ac,tMZCfe; contextmenu:Nqw7Te,QP7LD; mouseout:Nqw7Te; mouseover:qtZ4nf,c2aHje\" jsname=\"W297wb\"></span></span></span></li> <li><span class=\"VIiyi\" jsaction=\"mouseup:BR6jm\" jsname=\"jqKxS\" lang=\"bg\"><span class=\"JLqJ4b ChMk0b\" data-language-for-alternatives=\"bg\" data-language-to-translate-into=\"en\" data-number-of-phrases=\"23\" data-phrase-index=\"8\" jsaction=\"agoMJf:PFBcW;usxOmf:aWLT7;jhKsnd:P7O7bd,F8DmGf;Q4AGo:Gm7gYd,qAKMYb;uFUCPb:pvnm0e,pfE8Hb,PFBcW;f56efd:dJXsye;EnoYf:KNzws,ZJsZZ,JgVSJc;zdMJQc:cCQNKb,ZJsZZ,zchEXc;Ytrrj:JJDvdc;tNR8yc:GeFvjb;oFN6Ye:hij5Wb;bmeZHc:iURhpf;Oxj3Xe:qAKMYb,yaf12d\" jscontroller=\"Zl5N8\" jsdata=\"uqLsIf;_;$21\" jsmodel=\"SsMkhd\" jsname=\"txFAF\"><span class=\"Q4iAWc\" jsaction=\"click:qtZ4nf,GFf3ac,tMZCfe; contextmenu:Nqw7Te,QP7LD; mouseout:Nqw7Te; mouseover:qtZ4nf,c2aHje\" jsname=\"W297wb\">Разстояние между отворите за закрепяне: 10 х 7 см</span></span><span class=\"JLqJ4b\" data-language-for-alternatives=\"bg\" data-language-to-translate-into=\"en\" data-number-of-phrases=\"23\" data-phrase-index=\"9\" jsaction=\"agoMJf:PFBcW;usxOmf:aWLT7;jhKsnd:P7O7bd,F8DmGf;Q4AGo:Gm7gYd,qAKMYb;uFUCPb:pvnm0e,pfE8Hb,PFBcW;f56efd:dJXsye;EnoYf:KNzws,ZJsZZ,JgVSJc;zdMJQc:cCQNKb,ZJsZZ,zchEXc;Ytrrj:JJDvdc;tNR8yc:GeFvjb;oFN6Ye:hij5Wb;bmeZHc:iURhpf;Oxj3Xe:qAKMYb,yaf12d\" jscontroller=\"Zl5N8\" jsdata=\"uqLsIf;_;$22\" jsmodel=\"SsMkhd\" jsname=\"txFAF\"><span class=\"Q4iAWc\" jsaction=\"click:qtZ4nf,GFf3ac,tMZCfe; contextmenu:Nqw7Te,QP7LD; mouseout:Nqw7Te; mouseover:qtZ4nf,c2aHje\" jsname=\"W297wb\"></span></span></span></li> <li>Диаметър на отвора: 1 см</li> <li><span class=\"VIiyi\" jsaction=\"mouseup:BR6jm\" jsname=\"jqKxS\" lang=\"bg\"><span class=\"JLqJ4b ChMk0b\" data-language-for-alternatives=\"bg\" data-language-to-translate-into=\"en\" data-number-of-phrases=\"23\" data-phrase-index=\"16\" jsaction=\"agoMJf:PFBcW;usxOmf:aWLT7;jhKsnd:P7O7bd,F8DmGf;Q4AGo:Gm7gYd,qAKMYb;uFUCPb:pvnm0e,pfE8Hb,PFBcW;f56efd:dJXsye;EnoYf:KNzws,ZJsZZ,JgVSJc;zdMJQc:cCQNKb,ZJsZZ,zchEXc;Ytrrj:JJDvdc;tNR8yc:GeFvjb;oFN6Ye:hij5Wb;bmeZHc:iURhpf;Oxj3Xe:qAKMYb,yaf12d\" jscontroller=\"Zl5N8\" jsdata=\"uqLsIf;_;$29\" jsmodel=\"SsMkhd\" jsname=\"txFAF\"><span class=\"Q4iAWc\" jsaction=\"click:qtZ4nf,GFf3ac,tMZCfe; contextmenu:Nqw7Te,QP7LD; mouseout:Nqw7Te; mouseover:qtZ4nf,c2aHje\" jsname=\"W297wb\">Включени елементи за монтаж.</span></span></span></li> <li><span class=\"VIiyi\" jsaction=\"mouseup:BR6jm\" jsname=\"jqKxS\" lang=\"bg\"><span class=\"JLqJ4b\" data-language-for-alternatives=\"bg\" data-language-to-translate-into=\"en\" data-number-of-phrases=\"23\" data-phrase-index=\"17\" jsaction=\"agoMJf:PFBcW;usxOmf:aWLT7;jhKsnd:P7O7bd,F8DmGf;Q4AGo:Gm7gYd,qAKMYb;uFUCPb:pvnm0e,pfE8Hb,PFBcW;f56efd:dJXsye;EnoYf:KNzws,ZJsZZ,JgVSJc;zdMJQc:cCQNKb,ZJsZZ,zchEXc;Ytrrj:JJDvdc;tNR8yc:GeFvjb;oFN6Ye:hij5Wb;bmeZHc:iURhpf;Oxj3Xe:qAKMYb,yaf12d\" jscontroller=\"Zl5N8\" jsdata=\"uqLsIf;_;$30\" jsmodel=\"SsMkhd\" jsname=\"txFAF\"><span class=\"Q4iAWc\" jsaction=\"click:qtZ4nf,GFf3ac,tMZCfe; contextmenu:Nqw7Te,QP7LD; mouseout:Nqw7Te; mouseover:qtZ4nf,c2aHje\" jsname=\"W297wb\"></span></span><span class=\"JLqJ4b ChMk0b\" data-language-for-alternatives=\"bg\" data-language-to-translate-into=\"en\" data-number-of-phrases=\"23\" data-phrase-index=\"18\" jsaction=\"agoMJf:PFBcW;usxOmf:aWLT7;jhKsnd:P7O7bd,F8DmGf;Q4AGo:Gm7gYd,qAKMYb;uFUCPb:pvnm0e,pfE8Hb,PFBcW;f56efd:dJXsye;EnoYf:KNzws,ZJsZZ,JgVSJc;zdMJQc:cCQNKb,ZJsZZ,zchEXc;Ytrrj:JJDvdc;tNR8yc:GeFvjb;oFN6Ye:hij5Wb;bmeZHc:iURhpf;Oxj3Xe:qAKMYb,yaf12d\" jscontroller=\"Zl5N8\" jsdata=\"uqLsIf;_;$31\" jsmodel=\"SsMkhd\" jsname=\"txFAF\"><span class=\"Q4iAWc\" jsaction=\"click:qtZ4nf,GFf3ac,tMZCfe; contextmenu:Nqw7Te,QP7LD; mouseout:Nqw7Te; mouseover:qtZ4nf,c2aHje\" jsname=\"W297wb\"> Максимално натоварване: 50 кг</span></span></span></li> <li>Тегло: 2,5 кг.</li> <li>EAN: 8592833003232</li> </ul>",
                    MainImageUrl = "https://sportensklad.bg/image/cache/webp/catalog/SPORTNI_STOKI/basketbol/MASSPSB-01-basketball-ring-16-mm-with-net-1-700x700.webp",
                    RegularPrice = 39.56m,
                    DiscountPercentage = 0,
                    DiscountedPrice = 0m,
                    Quantity = 13,
                    Rating = 4,
                    CategoryId = categories.First(c => c.Name == "Баскетбол").Id,
                    SecondaryImages = new List<Image>
                    {
                        new() { Uri = "https://sportensklad.bg/image/cache/webp/catalog/mastersport/masspsb-01MASSPSB-01-20c-700x700.webp" },
                        new() { Uri = "https://sportensklad.bg/image/cache/webp/catalog/mastersport/masspsb-01MASSPSB-01-20a-700x700.webp" },
                        new() { Uri = "https://sportensklad.bg/image/cache/webp/catalog/mastersport/masspsb-01MASSPSB-01-20b-700x700.webp" },
                        new() { Uri = "https://sportensklad.bg/image/cache/webp/catalog/mastersport/masspsb-01MASSPSB-01_newc-700x700.webp" }
                    }
                },
                new()
                {
                    Title = "Баскетболна топка SPALDING Varsity TF150",
                    Description = "<div class=\"flex flex-grow flex-col gap-3 max-w-full\"> <div class=\"min-h-[20px] flex flex-col items-start gap-3 overflow-x-auto whitespace-pre-wrap break-words\"> <div class=\"markdown prose w-full break-words dark:prose-invert light\"> <p>Баскетболната топка SPALDING Varsity TF150 размер 6 е подходяща за&nbsp; игра на открито.</p> <p>Технически данни:</p> <ul> <li>Размер: 6</li> <li>Предназначена за тренировки, развлечение и училищен спорт.</li> <li>Подходяща за игра на закрито и открито</li> <li>Материал: гума.</li> </ul> </div> </div> </div>",
                    MainImageUrl = "https://sportensklad.bg/image/cache/webp/catalog/mastersport/spg84325zSPG84325Z-700x700.webp",
                    RegularPrice = 65.32m,
                    DiscountPercentage = 0,
                    DiscountedPrice = 0m,
                    Quantity = 22,
                    Rating = 3,
                    CategoryId = categories.First(c => c.Name == "Баскетбол").Id,
                    Reviews = new List<Review>
                    {
                        new()
                        {
                            UserId = users.First().Id,
                            Content = "Добър продукт.",
                            Rating = 3
                        }
                    }
                },
                new()
                {
                    Title = "Предпазна каска MASTER Flip, S,",
                    Description = "<ul> <li>Каската е подходяща за колоездене, скейтборд, тротинетка, ролкови кънки и други спортове.</li> <li>Конструкция против мухъл.</li> <li>6 вентилационни отвора</li> <li>Велкро фиксирани вътрешни подплънки</li> <li>Цвят: жълт</li> <li>Размер: S (48-52 см)</li> <li>Тегло 204гр.</li> </ul>",
                    MainImageUrl = "https://sportensklad.bg/image/cache/webp/catalog/master-pic-upload/kaska-mas-b200-yellow-700x700.webp",
                    RegularPrice = 22.54m,
                    DiscountPercentage = 11,
                    DiscountedPrice = 19.84m,
                    Quantity = 13,
                    Rating = 2,
                    CategoryId = categories.First(c => c.Name == "Колоездене").Id,
                    SecondaryImages = new List<Image>
                    {
                        new() { Uri = "https://sportensklad.bg/image/cache/webp/catalog/mastersport/mas-b200-s-yellowMAS-B200-yellowa-700x700.webp" },
                        new() { Uri = "https://sportensklad.bg/image/cache/webp/catalog/mastersport/mas-b200-s-yellowMAS-B200-yellowb-700x700.webp" },
                        new() { Uri = "https://sportensklad.bg/image/cache/webp/catalog/mastersport/mas-b200-s-yellowMAS-B200-yellowc-700x700.webp" }
                    },
                    Reviews = new List<Review>
                    {
                        new()
                        {
                            UserId = users.First().Id,
                            Content = "Среден продукт.",
                            Rating = 2
                        }
                    }
                },
                new()
                {
                    Title = "Протектори MASTER Kinder, L, комплект",
                    Description = "<ul> <li>Детски комплект протектори за колена, длани и лакти.</li> <li>Външната обвивка е изработена от твърда пластмаса, а вътрешността от мека и гъвкава подплата.</li> </ul><div class=\"tab-content\"> <div class=\"active tab-pane\" id=\"tab-description\"> <div class=\"active tab-pane\" id=\"tab-description\"> <div class=\"active tab-pane\" id=\"tab-description\"> <ul> <li>Поставят се посредством велкро лепенки.</li> <li>Ширина на лакътя 11 см, височина 15,5 см.</li> <li>Ширина на коляното 12 см, височина 17 см.</li> <li>Дължина на дланта 14 см.</li> <li>L&nbsp; (за деца с височина) 150-165 см и/или 25-50 кг.</li> <li>Тегло: 0,350 кг.<br> &nbsp; <div data-oembed-url=\"https://youtu.be/C-r7raSbv78\"> <div style=\"margin-bottom:0px; margin-left:0px; margin-right:0px; margin-top:0px; max-width:320px\"> <div style=\"height:0; left:0; padding-bottom:56.25%; position:relative; width:100%\"></div> </div> </div> <p>&nbsp;</p> </li> </ul> </div> </div> </div> </div>",
                    MainImageUrl = "https://sportensklad.bg/image/cache/webp/catalog/mastersport/mas-b022-lMAS-B022_2017-700x700.webp",
                    RegularPrice = 17.94m,
                    DiscountPercentage = 0,
                    DiscountedPrice = 0m,
                    Quantity = 5,
                    Rating = 4,
                    CategoryId = categories.First(c => c.Name == "Колоездене").Id,
                    Reviews = new List<Review>
                    {
                        new()
                        {
                            UserId = users.First().Id,
                            Content = "Много добър продукт.",
                            Rating = 4
                        }
                    }
                },
                new()
                {
                    Title = "Велосипед Sprint Monza Team 28'', 550мм,",
                    Description = "<p>Шосеен велосипед с алуминиева рамка 550 мм, V-Brake спирачки.</p><ul> <li> <p><strong>Вилката е: </strong>JHT, 700C, RACING, CALIPER BRAKE, CARBON LEGS, INTEGRATED 56mm, ALLOY STEM 1-1/8\"-1.5\"x300mm THREADLESS</p> </li> <li> <p><strong>Чашките за вилката са: </strong>FSA, ORBIT C-40-ACB 1-1/8 ACB Top, 1.5\" ACB Btm, Standard 15mm top cover, HEIGHT 16.3mm</p> </li> <li> <p><strong>Кормилото е: </strong>ZOOM DR-AL- 210B-BT FOV(31.8) (ISO-R), RACING, 420mm</p> </li> <li> <p><strong>Колчето за кормилото е: </strong>ZOOM, TDS-RD507B-8FOV (ISO-M), EXT: 90mm.x28.6mm, BAR BORE 31.8, ALLOY, RISE:-7D, HEIGHT: 41mm</p> </li> <li> <p><strong>Спирачките са: </strong>PROMAX RC-482 FRONT AND REAR</p> </li> <li> <p><strong>Курбелът е: </strong>SHIMANO, FC-R7000, 105, FOR REAR 11-SPEED, HOLLOWTECH 2, 170MM, 50-34T W/O CG, W/O BB PARTS</p> </li> <li> <p><strong>Педалите са: </strong>VP-R77, Fiber glass body, ROAD PEDAL W/VP-ARC5 CLEAT</p> </li> <li> <p><strong>Предният дерайльор е: </strong>SHIMANO, FD-R7000-L, 105, FOR REAR 11-SPEED, DOWN-SWING, 31.8MM BAND, CS-ANGLE:61-66, FOR TOP GEAR:46-53T, CL:43.5MM</p> </li> <li> <p><strong>Задният дерайльор е: </strong>SHIMANO, RD-R7000, 105, SS 11-SPEED, TOP NORMAL SHADOW DESIGN, DIRECT ATTACHMENT</p> </li> <li> <p><strong>Зъбният блок е: </strong>SHIMANO, CASSETTE SPROCKET, CS-R7000, 105, 11-SPEED, 11-12-13-14-15-17-19-21-23-25-28T</p> </li> <li> <p><strong>Командите са: </strong>SHIMANO, SHIFT/BRAKE LEVER, ST-R7000, 105</p> </li> <li> <p><strong>Веригата е: </strong>SHIMANO, BICYCLE CHAIN, CN-HG601-11, FOR 11-SPEED</p> </li> <li> <p><strong>Шината е: </strong>SHIMANO, WHEEL, WH-RS100, F:20H/R:24H, FOR 11/10-S</p> </li> <li> <p><strong>Гумите са: </strong>SCHWALBE, LUGANO K GUARD, 700Cx25</p> </li> <li> <p><strong>Седалката е: </strong>ACTIVE DDK-517</p> </li> <li> <p><strong>Колчето за седалката е: </strong>ZOOM, SP-D297N, ALLOY 3D FORGED, 27.2x350</p> </li> <li> <p><strong>Размерът&nbsp; на колелото е: </strong>28\"</p> </li> <li> <p><strong>Тегло</strong>: 10,800 кг</p> </li> </ul>",
                    MainImageUrl = "https://sportensklad.bg/image/cache/webp/catalog/shockblaze./75a9dd3eb836018f91626eadf675b3e5-700x700.webp",
                    RegularPrice = 1752m,
                    DiscountPercentage = 0,
                    DiscountedPrice = 0m,
                    Quantity = 2,
                    Rating = 5,
                    CategoryId = categories.First(c => c.Name == "Колоездене").Id,
                    Reviews = new List<Review>
                    {
                        new()
                        {
                            UserId = users.First().Id,
                            Content = "Отличен продукт!",
                            Rating = 5
                        }
                    }
                },
                new()
                {
                    Title = "Боксов тренажор Bodyflex, 160cm, надуваем",
                    Description = "<ul> <li>Надуваем боксов тренажор с включена помпа.</li> <li>Подходящ&nbsp;за игра или тренировка.</li> <li>Материал: мек, издръжлив и подсилен PVC</li> <li>Височина: 160 см</li> <li>Диаметър: 30 см</li> <li>За оптимална стабилност и здравина на основата я напълнете с вода или пясък – колкото повече, толкова по-стабилна ще е тя. След това надуйте горната част с въздух.</li> <li>Тренажорът има обозначени таргети (мишени), които да използвате за създаване на комбинации от удари и съответно последователност в спаринга.&nbsp;</li> <li>За вътрешна употреба.&nbsp;</li> </ul><p><br> Надуваемият боксов тренажор е допълнение към традиционния боксов тренажор и е отлична опция за хора, които искат да тренират у дома или на открито. Те са лесни за сглобяване и могат да бъдат съхранявани и пренасяни лесно.</p><p>Тези тренажори обикновено са изработени от здрав PVC материал, който може да устои на удари и въздействието на въздушен поток при удари. В зависимост от модела, те могат да бъдат настроени в различни размери и форми, като много от тях имат реалистична форма на боксов меш или на човешко тяло.</p><p>Тези тренажори обикновено са изработени от здрав PVC материал, който може да устои на удари и въздействието на въздушен поток при удари. В зависимост от модела, те могат да бъдат настроени в различни размери и форми, като много от тях имат реалистична форма на боксов меш или на човешко тяло.</p><p>Надуваемите боксови тренажори са отличен начин за трениране на боксьорски техники, като удари, блокове и движения, както и за подобряване на кардио възможностите и издръжливостта. Те могат да бъдат използвани както от начинаещи, така и от напреднали боксьори.</p><p>Тези тренажори предлагат също и много гъвкавост в тренировките, тъй като могат да бъдат използвани както за индивидуални тренировки, така и за тренировки с партньор. Могат да бъдат използвани както за бокс, така и за други бойни изкуства, като кикбокс и ММА.</p><p>Една от големите предимства на надуваемия боксов тренажор е, че те са безопасни и не представляват риск от наранявания. Те са идеални за употреба от деца и начинаещи боксьори, които все още не са сигурни в своите удари.</p><p>В заключение, надуваемият боксов тренажор е добро допълнение към традиционните боксови тренажори и предлага много гъвкавост в тренировките. Те са лесни за сглобяване и съхранение, като предлагат безопасна и ефективна опция за трениране на боксьорски техники и подобряване на физическата форма</p>",
                    MainImageUrl = "https://sportensklad.bg/image/cache/webp/catalog/SPORTNI_STOKI/boks/BF-046-boksov-trenazhor-bodyflex-160cm-naduvaem-2-700x700.webp",
                    RegularPrice = 46.90m,
                    DiscountPercentage = 0,
                    DiscountedPrice = 0m,
                    Quantity = 18,
                    Rating = 5,
                    CategoryId = categories.First(c => c.Name == "Бокс").Id,
                    SecondaryImages = new List<Image>
                    {
                        new() { Uri = "https://sportensklad.bg/image/cache/webp/catalog/SPORTNI_STOKI/boks/BF-046-boksov-trenazhor-bodyflex-160cm-naduvaem--700x700.webp" },
                        new() { Uri = "https://sportensklad.bg/image/cache/webp/catalog/SPORTNI_STOKI/boks/BF-046-boksov-trenazhor-bodyflex-160cm-naduvaem-2-700x700.webp" },
                        new() { Uri = "https://sportensklad.bg/image/cache/webp/catalog/SPORTNI_STOKI/boks/BF-046-boksov-trenazhor-bodyflex-160cm-naduvaem-1-700x700.webp" },
                        new() { Uri = "https://sportensklad.bg/image/cache/webp/catalog/SPORTNI_STOKI/boks/BF-046-boksov-trenazhor-bodyflex-160cm-naduvaem-4-700x700.webp" }
                    },
                    Reviews = new List<Review>
                    {
                        new()
                        {
                            UserId = users.First().Id,
                            Content = "Отличен продукт!",
                            Rating = 5
                        }
                    }
                },
                new()
                {
                    Title = "Боксови ръкавици MASTER TG12",
                    Description = "<p>Боксови ръкавици MASTER TG12 MAS-DB012.</p><ul> <li>Материал: изкуствена кожа, PU</li> <li>Размер: 12 oz</li> <li>Velcro закопчаване</li> </ul>",
                    MainImageUrl = "https://sportensklad.bg/image/cache/webp/catalog/master-pic-upload/boksovi-rakavici-master-mas-db012-700x700.webp",
                    RegularPrice = 43.70m,
                    DiscountPercentage = 0,
                    DiscountedPrice = 0m,
                    Quantity = 17,
                    Rating = 4,
                    CategoryId = categories.First(c => c.Name == "Бокс").Id,
                    SecondaryImages = new List<Image>
                    {
                        new() { Uri = "https://sportensklad.bg/image/cache/webp/catalog/mastersport/mas-db012MAS-DB008a-700x700.webp" },
                        new() { Uri = "https://sportensklad.bg/image/cache/webp/catalog/mastersport/mas-db012MAS-DB010_new-700x700.webp" },
                        new() { Uri = "https://sportensklad.bg/image/cache/webp/catalog/mastersport/mas-db012MAS-DB010_newa-700x700.webp" },
                        new() { Uri = "https://sportensklad.bg/image/cache/webp/catalog/mastersport/mas-db012MAS-DB010_newb-700x700.webp" }
                    },
                    Reviews = new List<Review>
                    {
                        new()
                        {
                            UserId = users.First().Id,
                            Content = "Много добър продукт.",
                            Rating = 4
                        }
                    }
                },
                new()
                {
                    Title = "Боксов чувал SPARTAN 90 cм, 20 кг",
                    Description = "<ul> <li>Материал: изкуствена кожа устойчива на износване и скъсване.</li> <li>Пълнеж: кожа / текстилни изрезки.</li> <li>Еднаква твърдост по цялата повърхност и перфектна абсорбция на удари.</li> <li>Окачване: четири стоманени вериги симетрично разположени.</li> <li>Размери: 90х30 см</li> <li>Тегло: 20кг</li> </ul>",
                    MainImageUrl = "https://sportensklad.bg/image/cache/webp/catalog/mastersport/s1194S1194-700x700.webp",
                    RegularPrice = 261.28m,
                    DiscountPercentage = 0,
                    DiscountedPrice = 0m,
                    Quantity = 7,
                    Rating = 4,
                    CategoryId = categories.First(c => c.Name == "Бокс").Id,
                    SecondaryImages = new List<Image>
                    {
                        new() { Uri = "https://sportensklad.bg/image/cache/webp/catalog/SPORTNI_STOKI/boks/boksov-chuval-spartan-90-sm-20-kg-700x700.webp" }
                    },
                    Reviews = new List<Review>
                    {
                        new()
                        {
                            UserId = users.First().Id,
                            Content = "Много добър продукт.",
                            Rating = 4
                        }
                    }
                },
            ];

            db.Products.AddRange(products);
            await db.SaveChangesAsync();
        }
    }
}
