using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using StoreDemo.Models;

namespace StoreDemo.DataAccessLayer
{
    public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<StoreDbContext>
    {
        protected override void Seed(StoreDbContext context)
        {
            var departments = new List<DepartmentModel>
            {
                new DepartmentModel
                {
                    Id = 1, Name = "Elektronika",
                    Categories = new List<CategoryModel>
                    {
                        new CategoryModel
                        {
                            Name = "Laptopy",
                            Products = new List<ProductModel>
                            {
                                new ProductModel
                                {
                                    Name = "Lenovo",
                                    Description = "Sprzęt jest nowy, objęty 12mc gwarancją pisemną liczoną od dnia zakupu",
                                    Price = 2849.00m
                                },
                                new ProductModel
                                {
                                    Name = "Dell",
                                    Description = "Ostry i odwzorowany w jasnych, żywych barwach obraz na ekranie 14'' o dużej rozdzielczości rozdzielczości  (1366 x 768)",
                                    Price = 330.01m
                                },
                                new ProductModel
                                {
                                    Name = "Asus",
                                    Description = "Rozbudowany system dźwiękowy, dostrojony przez eksperów",
                                    Price = 1259.00m
                                },
                            }
                        },
                        new CategoryModel
                        {
                            Name = "Komputery",
                            Products = new List<ProductModel>
                            {
                                new ProductModel
                                {
                                    Name = "Windows 7",
                                    Description = "Windows 7 Professional KLUCZ 32/64 AUTOMAT 24H/7",
                                    Price = 14.38m
                                },
                                new ProductModel
                                {
                                    Name = "PSC",
                                    Description = "PAYSAFECARD 100 ZŁ ~ AUTOMAT 24/7 ~DYSTRYBUTOR PSC",
                                    Price = 110.39m
                                },
                                new ProductModel
                                {
                                    Name = "Norton",
                                    Description = "Norton Internet Security PL - 1 PC, 1 ROK Fvat 23%",
                                    Price = 44.99m
                                },
                            }
                        },
                        new CategoryModel
                        {
                            Name = "Konsole",
                            Products = new List<ProductModel>
                            {
                                new ProductModel
                                {
                                    Name = "XBOX LIVE",
                                    Description = "XBOX LIVE GOLD 12 MIESIĘCY ROK Xbox360 ONE w 3 min",
                                    Price = 149.00m
                                },
                                new ProductModel
                                {
                                    Name = "Adapter",
                                    Description = "ODBIORNIK ADAPTER do PADA XBOX 360 PC WINDOWS PL",
                                    Price = 39.00m
                                },
                                new ProductModel
                                {
                                    Name = "Playstation 4",
                                    Description = "Konsola PlayStation 4 Pro 1TB PS4 PRO +FAR CRY 5",
                                    Price = 1599.00m
                                },
                            }
                        },
                        new CategoryModel
                        {
                            Name = "Smartfony",
                            Products = new List<ProductModel>
                            {
                                new ProductModel
                                {
                                    Name = "Xiaomi",
                                    Description = "Outlet - Xiaomi Redmi 4X 32GB Dual Sim Czarny",
                                    Price = 539.10m
                                },
                                new ProductModel
                                {
                                    Name = "IPhone",
                                    Description = "Apple iPhone 6s 64GB Szary/Srebrny/Złoty/Różowy",
                                    Price = 1399.00m
                                },
                                new ProductModel
                                {
                                    Name = "Samsung",
                                    Description = "Samsung Galaxy J5 (2017) Dual Sim LTE 16GB Niebies",
                                    Price = 729.00m
                                },
                            }
                        },
                    }
                },
                new DepartmentModel
                {
                    Id = 2, Name = "Moda",
                    Categories = new List<CategoryModel>
                    {
                        new CategoryModel
                        {
                            Name = "Odzież męska",
                            Products = new List<ProductModel>
                            {
                                new ProductModel
                                {
                                    Name = "Spodenki",
                                    Description = "hit SPODENKI DRESOWE KRÓTKIE spodnie MĘSKIE FA M/L",
                                    Price = 27.80m
                                },
                                new ProductModel
                                {
                                    Name = "Koszulka",
                                    Description = "ZESTAW KOSZULKA MĘSKA 4F T-SHIRT KOSZULKI L18 r.XL",
                                    Price = 139.99m
                                },
                                new ProductModel
                                {
                                    Name = "Spodnie",
                                    Description = "ADIDAS SPODNIE DRESOWE DRESY MĘSKIE TIRO 17 L",
                                    Price = 129.00m
                                }
                            }
                        },
                        new CategoryModel
                        {
                            Name = "Odzież damska",
                            Products = new List<ProductModel>
                            {
                                new ProductModel
                                {
                                    Name = "Sukienka",
                                    Description = "SUKIENKA BOHO KWIATY ROZKLOSZOWANA PRINT MODA M750",
                                    Price = 39.99m
                                },
                                new ProductModel
                                {
                                    Name = "Bluzka",
                                    Description = "AWANTI floral BLUZKA koszulka haftowane kwiaty HIT",
                                    Price = 24.99m
                                },
                                new ProductModel
                                {
                                    Name = "Sweter",
                                    Description = "AWANTI modny KARDIGAN sweter na wiosnę OKAZJA kol",
                                    Price = 39.99m
                                },
                            }
                        },
                        new CategoryModel
                        {
                            Name = "Buty męskie",
                            Products = new List<ProductModel>
                            {
                                new ProductModel
                                {
                                    Name = "Nike 1",
                                    Description = "Buty męskie Nike Downshifter 7 852459-001",
                                    Price = 168.00m
                                },
                                new ProductModel
                                {
                                    Name = "Nike 2",
                                    Description = "r. 44 BUTY NIKE MD RUNNER 2 749794-010 r.40,5-49",
                                    Price = 203.00m
                                },
                                new ProductModel
                                {
                                    Name = "Solar",
                                    Description = "Buty męskie Nike SB Check Solar CNVS Różne rozm.",
                                    Price = 199.00m
                                },
                            }
                        },
                        new CategoryModel
                        {
                            Name = "Buty damskie",
                            Products = new List<ProductModel>
                            {
                                new ProductModel
                                {
                                    Name = "Nike 1",
                                    Description = "NIKE COURT BOROUGH MID SE 922846 001 BUTY WYSOKIE",
                                    Price = 188.00m
                                },
                                new ProductModel
                                {
                                    Name = "Nike 2",
                                    Description = "39 BUTY NIKE MD RUNNER 2 807316 001 CZARNE",
                                    Price = 145.00m
                                },
                                new ProductModel
                                {
                                    Name = "Trampki",
                                    Description = "BUTY Damskie NIKE Check trampki Capri r.39 czarne",
                                    Price = 169.00m
                                },
                            }
                        },
                    }
                },
                new DepartmentModel
                {
                    Id = 3, Name = "Dom i ogród",
                    Categories = new List<CategoryModel>
                    {

                        new CategoryModel
                        {
                            Name = "Budownictwo",
                            Products = new List<ProductModel>
                            {
                                new ProductModel
                                {
                                    Name = "Ogrodzenie",
                                    Description = "OGRODZENIA OGRODZENIE PANELOWE KOMPLET DRUT FI 5mm",
                                    Price = 40.00m
                                },
                                new ProductModel
                                {
                                    Name = "Drabina",
                                    Description = "DRABINA aluminiowa 3x9 HIGHER na schody 7,00m HIT!",
                                    Price = 320.00m
                                },
                                new ProductModel
                                {
                                    Name = "Czujnik",
                                    Description = "Kidde Czujnik Czadu Tlenku węgla 7DCO 10L detektor",
                                    Price = 99.00m
                                },
                            }
                        },
                        new CategoryModel
                        {
                            Name = "Ogród",
                            Products = new List<ProductModel>
                            {
                                new ProductModel
                                {
                                    Name = "Odstraszacz",
                                    Description = "BIRDCHASER ODSTRASZACZ PTAKÓW SZPAKÓW WERSJA 2018",
                                    Price = 169.97m
                                },
                                new ProductModel
                                {
                                    Name = "Parasol",
                                    Description = "Parasol ogrodowy składany z FALBANKAMI 350cm DUŻY",
                                    Price = 226.34m
                                },
                                new ProductModel
                                {
                                    Name = "Wąż ogrodowy",
                                    Description = "WĄŻ OGRODOWY X-HOSE ROZCIĄGLIWY 20m - 60m PISTOLET",
                                    Price = 31.99m
                                },
                            }
                        },
                        new CategoryModel
                        {
                            Name = "Narzędzia",
                            Products = new List<ProductModel>
                            {
                                new ProductModel
                                {
                                    Name = "Niwelator optyczny",
                                    Description = "Niwelator optyczny Xi32 + statyw + łata",
                                    Price = 563.90m
                                },
                                new ProductModel
                                {
                                    Name = "Myjka ciśnieniowa",
                                    Description = "MYJKA CIŚNIENIOWA LAVOR SPAJKI 170ewBAR PIANOWNICA",
                                    Price = 299.00m
                                },
                                new ProductModel
                                {
                                    Name = "Kompresor",
                                    Description = "SPRĘŻARKA KOMPRESOR OLEJOWY 3,8KM 24L +ZESTAW 8EL.",
                                    Price = 334.00m
                                },
                            }
                        },
                        new CategoryModel
                        {
                            Name = "Meble",
                            Products = new List<ProductModel>
                            {
                                new ProductModel
                                {
                                    Name = "Corfu",
                                    Description = "Corfu Fiesta Family Curver zestaw 'Technorattan'",
                                    Price = 1599.00m
                                },
                                new ProductModel
                                {
                                    Name = "Zestaw mebli",
                                    Description = "Zestaw Mebli Ogrodowych Stolik + 4 Krzesła Rattan",
                                    Price = 269.00m
                                },
                                new ProductModel
                                {
                                    Name = "Fotel",
                                    Description = "WYGODNY WIELOPOZYCYJNY Fotel / Leżak Wypoczynkowy",
                                    Price = 119.90m
                                },
                            }
                        },
                    }
                },
                new DepartmentModel
                {
                    Id = 4, Name = "Motoryzacja",
                    Categories = new List<CategoryModel>
                    {
                        new CategoryModel
                        {
                            Name = "Części samochodowe",
                            Products = new List<ProductModel>
                            {
                                new ProductModel
                                {
                                    Name = "Pompowtryskiwacz",
                                    Description = "Pompowtryskiwacz 038130073AR 0414720214 Gw. 12msc",
                                    Price = 395.00m
                                },
                                new ProductModel
                                {
                                    Name = "Lampki LED",
                                    Description = "LAMPKI LED PODŚWIETLENIE Audi A3 8P A4 B6 B7 A6 C6",
                                    Price = 25.88m
                                },
                                new ProductModel
                                {
                                    Name = "Nagrzewnica",
                                    Description = "NAGRZEWNICA SAMOCHODOWA GRZEJNIK FARELKA 12V 150W",
                                    Price = 22.00m
                                },
                            }
                        },
                        new CategoryModel
                        {
                            Name = "Opony",
                            Products = new List<ProductModel>
                            {
                                new ProductModel
                                {
                                    Name = "Opony 1",
                                    Description = "4x OPONY 205/55R16 91V GOODRIDE RP28 RANT 2018",
                                    Price = 555.00m
                                },
                                new ProductModel
                                {
                                    Name = "Opony 2",
                                    Description = "4 opony letnie 195/65R15 Kormoran Road 2018 !!",
                                    Price = 588.00m
                                },
                                new ProductModel
                                {
                                    Name = "Opony 3",
                                    Description = "2x OPONY LETNIE 205/55R16 91V GOODRIDE RP28 RANT",
                                    Price = 290.00m
                                },
                            }
                        },
                        new CategoryModel
                        {
                            Name = "Felgi aluminiowe",
                            Products = new List<ProductModel>
                            {
                                new ProductModel
                                {
                                    Name = "Felgi 1",
                                    Description = "FELGI 16'' 5x108 FORD FOCUS 2 3 MONDEO S-MAX C-MAX",
                                    Price = 1399.00m
                                },
                                new ProductModel
                                {
                                    Name = "Felgi 2",
                                    Description = "FELGI 15'' HYUNDAI I10 I20 DACIA KIA PICANTO RIO",
                                    Price = 1099.00m
                                },
                                new ProductModel
                                {
                                    Name = "Felgi 3",
                                    Description = "099 MS FELGI 18 5x112 AUDI A4 A5 A6 A7 A8 VOSSEN",
                                    Price = 2299.00m
                                },
                            }
                        },
                        new CategoryModel
                        {
                            Name = "Narzędzia samochodowe",
                            Products = new List<ProductModel>
                            {
                                new ProductModel
                                {
                                    Name = "Interfejs",
                                    Description = "Interfejs ELM 327 Bluetooth OBD2 + CD Program PL",
                                    Price = 29.00m
                                },
                                new ProductModel
                                {
                                    Name = "Tester szczelności",
                                    Description = "TESTER SZCZELNOŚCI USZCZELKI GŁOWICY CO2 25 TESTÓW",
                                    Price = 19.00m
                                },
                                new ProductModel
                                {
                                    Name = "Zestaw do wyciskania tłoczków hamulcowych",
                                    Description = "ZESTAW DO WYCISKANIA TŁOCZKÓW HAMULCOWYCH 21 EL.",
                                    Price = 56.00m
                                },
                            }
                        },
                    }
                },
                new DepartmentModel
                {
                    Id = 5, Name = "Dziecko",
                    Categories = new List<CategoryModel>
                    {

                        new CategoryModel
                        {
                            Name = "Dla mamy i dziecka",
                            Products = new List<ProductModel>
                            {
                                new ProductModel
                                {
                                    Name = "Termometr",
                                    Description = "BEZDOTYKOWY TERMOMETR NA PODCZERWIEŃ FI03",
                                    Price = 39.80m
                                },
                                new ProductModel
                                {
                                    Name = "Wkładki",
                                    Description = "AKUKU CHŁONNE WKŁADKI LAKTACYJNE 84 SZT. MEGAPAKA",
                                    Price = 13.60m
                                },
                                new ProductModel
                                {
                                    Name = "Poduszka",
                                    Description = "MEGA ZESTAW Poduszka ciążowa 4w1 + antywstrząsowa",
                                    Price = 90.00m
                                },
                            }
                        },
                        new CategoryModel
                        {
                            Name = "Karmienie dziecka",
                            Products = new List<ProductModel>
                            {
                                new ProductModel
                                {
                                    Name = "Butelka",
                                    Description = "Butelka do karmienia AVENT Natural 260ml 1m+",
                                    Price = 24.99m
                                },
                                new ProductModel
                                {
                                    Name = "Mleko modyfikowane",
                                    Description = "Bebiko Junior 3 mleko modyfikowane 4x800g PROMO",
                                    Price = 119.26m
                                },
                                new ProductModel
                                {
                                    Name = "Butelki",
                                    Description = "AVENT ZESTAW STARTOWY NATURAL BUTELKI + GRATISY",
                                    Price = 98.95m
                                },
                            }
                        },
                        new CategoryModel
                        {
                            Name = "Zabawki",
                            Products = new List<ProductModel>
                            {
                                new ProductModel
                                {
                                    Name = "Mata edukacyjna",
                                    Description = "Mata edukacyjna interaktywna Kinderkraft ANIMALS",
                                    Price = 129.00m
                                },
                                new ProductModel
                                {
                                    Name = "Piesek",
                                    Description = "INTERAKTYWNY PIESEK YORK REAGUJE NA DOTYK SZCZEKA",
                                    Price = 69.99m
                                },
                                new ProductModel
                                {
                                    Name = "Tablica",
                                    Description = "EDUKACYJNA DUŻA WIELOFUNKCYJNA TABLICA MAGNETYCZNA",
                                    Price = 19.50m
                                },
                            }
                        },
                        new CategoryModel
                        {
                            Name = "Wózki",
                            Products = new List<ProductModel>
                            {
                                new ProductModel
                                {
                                    Name = "Wózek 1",
                                    Description = "Wózek Spacerowy Spacerówka Parasolka Lionelo Elia",
                                    Price = 175.00m
                                },
                                new ProductModel
                                {
                                    Name = "Wózek 2",
                                    Description = "Wózek spacerowy spacerówka MOVINO Stella +dodatki",
                                    Price = 369.00m
                                },
                                new ProductModel
                                {
                                    Name = "Wózek 3",
                                    Description = "spacerówka SIROCCO duże kółka 25cm LEN, OCIEPLACZ",
                                    Price = 439.00m
                                },
                            }
                        },
                    }
                }
            };

            context.Departments.AddRange(departments);

            base.Seed(context);
        }
    }
}