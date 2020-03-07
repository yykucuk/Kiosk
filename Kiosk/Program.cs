using Kiosk.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kiosk
{
    class Program
    {
        private static int _kioskNo = 0;
        private static int _targetNo = 0;
        private static int _wayNo = 0;
        private static List<Classes.Kiosk> kiosks;
        private static List<Target> targets; 
        private static List<Navigation> navigations; 

        /// <summary>
        /// it sets values of list properties
        /// </summary>
        private static void SetValues()
        {
            //Adding Kiosks
            kiosks = new List<Classes.Kiosk>();
            kiosks.Add(new Classes.Kiosk
            {
                Id = 1,
                X = "F",
                Y = "1"
            });
            kiosks.Add(new Classes.Kiosk
            {
                Id = 2,
                X = "K",
                Y = "5"
            });
            kiosks.Add(new Classes.Kiosk
            {
                Id = 3,
                X = "F",
                Y = "11"
            });


            //Adding target shops
            targets = new List<Target>();
            targets.Add(new Target
            {
                Id = 1,
                X = "B",
                Y = "7",
                FloorNbr = 1,
                Name = "LCW"

            });
            targets.Add(new Target
            {
                Id = 2,
                X = "D",
                Y = "3",
                FloorNbr = 1,
                Name = "STB"

            });
            targets.Add(new Target
            {
                Id = 3,
                X = "H",
                Y = "7",
                FloorNbr = 1,
                Name = "KTN"

            });
            targets.Add(new Target
            {
                Id = 4,
                X = "C",
                Y = "6",
                FloorNbr = 2,
                Name = "BGR"

            });

            string directory = "{0}. Kiosk'tan {1} noktasına ilerlemek için; ";

            //Adding Way from kiosk 1
            navigations = new List<Navigation>();
            navigations.Add(new Navigation
            {
                Id = 1,
                Kid = 1,
                Tid = 1,
                Description = string.Format(directory, 1, targets.FindLast(s => s.Id == 1).Name) + "B1'e kadar düz ilerleyin ve B1 den sola dönüp B7'e doğru ilerleyin.."
            });
            navigations.Add(new Navigation
            {
                Id = 2,
                Kid = 1,
                Tid = 1,
                Description = string.Format(directory, 1, targets.FindLast(s => s.Id == 1).Name) + "F7'e doğru düz ilerleyin, sonra sağa dönüp B7'e doğru ilerleyin.."
            });
            navigations.Add(new Navigation
            {
                Id = 3,
                Kid = 1,
                Tid = 2,
                Description = string.Format(directory, 1, targets.FindLast(s => s.Id == 2).Name) + "D1'e doğru düz ilerleyin ve D1 den sola dönüp D3'e doğru ilerleyin.."
            });
            navigations.Add(new Navigation
            {
                Id = 4,
                Kid = 1,
                Tid = 2,
                Description = string.Format(directory, 1, targets.FindLast(s => s.Id == 2).Name) + "F3'e doğru düz ilerleyin ve F3 den sağa dönüp B7'e doğru ilerleyin.."
            });
            navigations.Add(new Navigation
            {
                Id = 5,
                Kid = 1,
                Tid = 3,
                Description = string.Format(directory, 1, targets.FindLast(s => s.Id == 3).Name) + "H1'e doğru düz ilerleyin ve H1 den sağa dönüp 7H'e doğru ilerleyin.."
            });
            navigations.Add(new Navigation
            {
                Id = 6,
                Kid = 1,
                Tid = 3,
                Description = string.Format(directory, 1, targets.FindLast(s => s.Id == 3).Name) + "F7'e doğru düz ilerleyin ve F7 den sola dönüp 7H'e doğru ilerleyin.."
            });
            navigations.Add(new Navigation
            {
                Id = 7,
                Kid = 1,
                Tid = 4,
                Description = string.Format(directory, 1, targets.FindLast(s => s.Id == 4).Name) + "F5'e doğru düz ilerleyin sağa dönüp E5 ten Asansöre binin  2. kata çıktığınızda E6'ya ilerleyin sağa dönüp C6' ya doğru ilerleyin.."
            });
            navigations.Add(new Navigation
            {
                Id = 8,
                Kid = 1,
                Tid = 4,
                Description = string.Format(directory, 1, targets.FindLast(s => s.Id == 4).Name) + "A1'e doğru düz ilerleyin sola dönüp A5'e ilerleyin ve oradaki merdivenle 2. kata çıktığınızda C5'E ilerleyin sağa dönüp C6' ya doğru ilerleyin.."
            });

            //Adding Way from kiosk 2
            navigations.Add(new Navigation
            {
                Id = 9,
                Kid = 2,
                Tid = 1,
                Description = string.Format(directory, 2, targets.FindLast(s => s.Id == 1).Name) + "B5'e doğru düz ilerleyin, sonra sola dönün ve B7'e doğru ilerleyin.."
            });
            navigations.Add(new Navigation
            {
                Id = 10,
                Kid = 2,
                Tid = 1,
                Description = string.Format(directory, 2, targets.FindLast(s => s.Id == 1).Name) + "K7'e doğru düz ilerleyin, sonra sağa dönün ve B7'e doğru ilerleyin.."
            });
            navigations.Add(new Navigation
            {
                Id = 11,
                Kid = 2,
                Tid = 2,
                Description = string.Format(directory, 2, targets.FindLast(s => s.Id == 2).Name) + "D5'e doğru düz ilerleyin, sonra sağa dönün ve D3'e doğru ilerleyin.."
            });
            navigations.Add(new Navigation
            {
                Id = 12,
                Kid = 2,
                Tid = 2,
                Description = string.Format(directory, 2, targets.FindLast(s => s.Id == 2).Name) + "K3'e doğru düz ilerleyin, sonra sola dönün D3'e doğru ilerleyin.."
            });
            navigations.Add(new Navigation
            {
                Id = 13,
                Kid = 2,
                Tid = 3,
                Description = string.Format(directory, 2, targets.FindLast(s => s.Id == 3).Name) + "H5'e doğru düz ilerleyin, sonra sola dönün H7'e doğru ilerleyin.."
            });
            navigations.Add(new Navigation
            {
                Id = 14,
                Kid = 2,
                Tid = 3,
                Description = string.Format(directory, 2, targets.FindLast(s => s.Id == 3).Name) + "K7'e doğru düz ilerleyin, sonra sağa dönün H7'e doğru ilerleyin.."
            });
            navigations.Add(new Navigation
            {
                Id = 15,
                Kid = 2,
                Tid = 4,
                Description = string.Format(directory, 2, targets.FindLast(s => s.Id == 4).Name) + "E5'e doğru düz ilerleyin, sonra asansöre binin. 2. kata çıktığınızda E6'ya ilerleyin, sağa dönüp C6' ya doğru ilerleyin.."
            });
            navigations.Add(new Navigation
            {
                Id = 16,
                Kid = 2,
                Tid = 4,
                Description = string.Format(directory, 2, targets.FindLast(s => s.Id == 4).Name) + "A5'e doğru düz ilerleyin, oradaki merdivenle 2. kata çıktığınızda C5'E ilerleyin sağa dönüp C6' ya doğru ilerleyin.."
            });

            //Adding Way from kiosk 3
            navigations.Add(new Navigation
            {
                Id = 17,
                Kid = 3,
                Tid = 1,
                Description = string.Format(directory, 3, targets.FindLast(s => s.Id == 1).Name) + "F7'e kadar düz ilerleyin, sonra sola dönün B7'e doğru ilerleyin.."
            });
            navigations.Add(new Navigation
            {
                Id = 18,
                Kid = 3,
                Tid = 1,
                Description = string.Format(directory, 3, targets.FindLast(s => s.Id == 1).Name) + "B11'e kadar düz ilerleyin, sonra sağa dönün B7'e doğru ilerleyin.."
            });
            navigations.Add(new Navigation
            {
                Id = 19,
                Kid = 3,
                Tid = 2,
                Description = string.Format(directory, 3, targets.FindLast(s => s.Id == 2).Name) + "D11'e doğru düz ilerleyin, sonra sağa dönün ve D3'e doğru ilerleyin.."
            });
            navigations.Add(new Navigation
            {
                Id = 20,
                Kid = 3,
                Tid = 2,
                Description = string.Format(directory, 3, targets.FindLast(s => s.Id == 2).Name) + "F3'e doğru düz ilerleyin, sonra sola dönün D3'e doğru ilerleyin.."
            });
            navigations.Add(new Navigation
            {
                Id = 21,
                Kid = 3,
                Tid = 3,
                Description = string.Format(directory, 3, targets.FindLast(s => s.Id == 3).Name) + "H11'e doğru düz ilerleyin, sonra sola dönün H7'e doğru ilerleyin.."
            });
            navigations.Add(new Navigation
            {
                Id = 22,
                Kid = 3,
                Tid = 3,
                Description = string.Format(directory, 3, targets.FindLast(s => s.Id == 3).Name) + "F7'e doğru düz ilerleyin, sonra sağa dönün H7'e doğru ilerleyin.."
            });
            navigations.Add(new Navigation
            {
                Id = 23,
                Kid = 3,
                Tid = 4,
                Description = string.Format(directory, 3, targets.FindLast(s => s.Id == 4).Name) + "F5'e doğru düz ilerleyin, sonra sola dönüp E5'e doğru ileryip oradan asansöre binin. 2. kata çıktığınızda E6'ya ilerleyin, sağa dönüp C6' ya doğru ilerleyin.."
            });
            navigations.Add(new Navigation
            {
                Id = 24,
                Kid = 3,
                Tid = 4,
                Description = string.Format(directory, 3, targets.FindLast(s => s.Id == 4).Name) + "f5'e doğru düz ilerleyin, sonra sola dönüp A5'e doğru ilerleyip oradaki merdivenle 2. kata çıktığınızda C5'E ilerleyin sağa dönüp C6' ya doğru ilerleyin.."
            });

        }

        /// <summary>
        /// When Customer enter on the kiosk button
        /// </summary>
        private static void EnterKiosk()
        {
            int integer = 0;
            do
            {

                Console.WriteLine("Lutfen şu an hangi Kiosk'ta bulunduğunuzu belirtiniz:");
                foreach (Classes.Kiosk item in kiosks)
                {
                    Console.WriteLine(string.Format(@"{0}. Kiosk için ""{0}"" giriniz..", item.Id));
                }
                string number = Console.ReadLine();
                try
                {
                    integer = Convert.ToInt32(number);
                    if(kiosks.Count(s=>s.Id == integer) == 0)
                    {
                        integer = Convert.ToInt32("s");
                    }
                    _kioskNo = integer;
                }
                catch (Exception ex)
                {
                    _kioskNo = 0;
                    Console.WriteLine("Hatalı giriş yaptınız!..");
                }
            } while (_kioskNo == 0);
        }

        /// <summary>
        /// When the customer enter his/her target
        /// </summary>
        private static void EnterTarget()
        {
            int integer = 0;
            do
            {

                Console.WriteLine("Lutfen şu an hangi yere gitmek istediğinizi belirtiniz:");
                foreach (Target item in targets)
                {
                    Console.WriteLine(string.Format(@"{0} dükkanı için ""{1}"" giriniz..", item.Name, item.Id));
                }
                string number = Console.ReadLine();
                try
                {
                    integer = Convert.ToInt32(number);
                    if (targets.Count(s => s.Id == integer) == 0)
                    {
                        integer = Convert.ToInt32("s");
                    }
                    _targetNo = integer;
                }
                catch (Exception ex)
                {
                    _targetNo = 0;
                    Console.WriteLine("Hatalı giriş yaptınız!..");
                }
            } while (_targetNo == 0);
        }

        /// <summary>
        /// When the customer
        /// </summary>
        private static void EnterWay()
        {
            int integer = 0;
            do
            {
                List<Navigation> ways1 = navigations.FindAll(s => s.Kid == _kioskNo & s.Tid == _targetNo);
                Console.WriteLine("Lutfen şu an hangi yönden gitmek istediğinizi belirtiniz:\n");
                foreach (Navigation item in ways1)
                {
                    Console.WriteLine(string.Format("{0} ==> {1}\n",item.Id, item.Description));
                }
                string number = Console.ReadLine();
                try
                {
                    integer = Convert.ToInt32(number);
                    if (ways1.Count(s => s.Id == integer) == 0)
                    {
                        integer = Convert.ToInt32("s");
                    }
                    _wayNo = integer;
                }
                catch (Exception ex)
                {
                    _wayNo = 0;
                    Console.WriteLine("Hatalı giriş yaptınız!..");
                }
            } while (_wayNo == 0);
        }

        /// <summary>
        /// After the customer choose the his/her way, it shows the result.
        /// </summary>
        private static void Result()
        {
            if(_wayNo > 0)
            {
                Console.WriteLine("Seçmiş olduğunuz yol/rota:");
                Console.WriteLine(navigations.Find(s=>s.Id == _wayNo).Description);
            }
        }

        static void Main(string[] args)
        {
            SetValues();
            string yesno = "";
            do
            {
                EnterKiosk();
                EnterTarget();
                EnterWay();
                Result();
                Console.WriteLine("\n Çıkmak için herhangi bir tuşa, Devam içinde \"D\"' ye basınız..\n ");
                yesno = Console.ReadLine();
            }
            while (!yesno.ToUpper().Equals("D"));
        }
    }
}
