using Library.Api.Entities;

namespace Library.Api
{
    public class LibrarySeeder
    {
        private readonly LibraryDbContext _dbContext;

        public LibrarySeeder(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Seed()
        {
            if (_dbContext.Database.CanConnect())
            {
                if (!_dbContext.Addresses.Any()) 
                {
                    var addresses = GetAddresses();
                    _dbContext.Addresses.AddRange(addresses);
                    _dbContext.SaveChanges();
                }

                if (!_dbContext.Customers.Any())
                {
                    var customers = GetCustomers();
                    _dbContext.Customers.AddRange(customers);
                    _dbContext.SaveChanges();
                }

                if (!_dbContext.Authors.Any())
                {
                    var authors = GetAuthors();
                    _dbContext.Authors.AddRange(authors);
                    _dbContext.SaveChanges();
                }

                if (!_dbContext.PublishingHouses.Any())
                {
                    var publishingHouses = GetPublishingHouses();
                    _dbContext.PublishingHouses.AddRange(publishingHouses);
                    _dbContext.SaveChanges();
                }

                if (!_dbContext.Books.Any())
                {
                    var books = GetBooks();
                    _dbContext.Books.AddRange(books);
                    _dbContext.SaveChanges();
                }
            }
        }

        private IEnumerable<Address> GetAddresses()
        {
            var addresses = new List<Address>()
            {
                new Address()
                {
                    Country = "Polska",
                    City = "Poznań",
                    Street = "Warszawska",
                    HouseNumber = "152",
                    ApartmentNumber = "10",
                    PostalCode = "60-500",
                    ContactNumber = "504625639"                    
                },
                new Address()
                {
                    Country = "Polska",
                    City = "Poznań",
                    Street = "Myśliwska",
                    HouseNumber = "10A",
                    PostalCode = "60-123",
                    ContactNumber = "635269845"
                },
                new Address()
                {
                    Country = "Polska",
                    City = "Luboń",
                    Street = "Kwiatowa",
                    HouseNumber = "9",
                    ApartmentNumber = "14",
                    PostalCode = "62-030"
                }
            };

            return addresses;
        }

        private IEnumerable<Customer> GetCustomers()
        {
            var customers = new List<Customer>()
            {
                new Customer()
                {
                    FirstName = "Anna Magdalena",
                    LastName = "Kowalska",
                    AddressId = 1,
                },
                new Customer()
                {
                    FirstName = "Natalia",
                    LastName = "Mróz",
                    AddressId = 2,
                },
                new Customer()
                {
                    FirstName = "Tomasz",
                    LastName = "Nowak",
                    AddressId = 3,
                }
            };

            return customers;
        }

        private IEnumerable<Author> GetAuthors()
        {
            var authors = new List<Author>()
            {
                new Author()
                {
                    FirstName = "Karolina",
                    LastName = "Głowacka"
                },
                new Author()
                {
                    FirstName = "Jean-Pierre",
                    LastName = "Lasota"
                },
                new Author()
                {
                    FirstName = "Cixin",
                    LastName = "Liu"
                },
                new Author()
                {
                    FirstName = "Chad",
                    LastName = "Orzel"
                },
                new Author()
                {
                    FirstName = "Mario",
                    LastName = "Puzo"
                },
                new Author()
                {
                    FirstName = "Greg",
                    LastName = "Jenner"
                },
                new Author()
                {
                    FirstName = "Seth",
                    LastName = "Stephens-Davidowitz"
                },
                new Author()
                {
                    FirstName = "Andrzej",
                    LastName = "Sapkowski"
                },
                new Author()
                {
                    FirstName = "Edward",
                    LastName = "Falco"
                }
            };

            return authors;
        }

        private IEnumerable<PublishingHouse> GetPublishingHouses()
        {
            var publishingHouses = new List<PublishingHouse>()
            {
                new PublishingHouse()
                {
                    Name = "Supernowa"
                },
                new PublishingHouse()
                {
                    Name = "Albatros"
                },
                new PublishingHouse()
                {
                    Name = "Wydawnictwo Literackie"
                },
                new PublishingHouse()
                {
                    Name = "PWN"
                },
                new PublishingHouse()
                {
                    Name = "Rebis"
                },
                new PublishingHouse()
                {
                    Name = "Prószyński i S-ka"
                }
            };

            return publishingHouses;
        }

        private IEnumerable<Book> GetBooks()
        {
            var books = new List<Book>()
            {
                new Book()
                {
                    Title = "Czy Wielki Wybuch był głośny?",
                    Description = "Przyszłość i przeszłość Wszechświata, czarne dziury, gwiazdy neutronowe, planety słoneczne i pozasłoneczne, czerwone olbrzymy, białe karły, fale grawitacyjne... Astrofizyka jest fascynująca, ale i niełatwa. Ta książka prowadzi czytelnika krok po kroku - nie tylko daje odpowiedzi, ale i podsuwa pytania.",
                    IsBorrowed = false,
                    IsWithdrawn = false,
                    CopyNumber = "1",
                    PublishingHouseId = 6,
                    Authors = _dbContext.Authors.Where(a => a.Id == 1 || a.Id == 2).ToList()
                },
                new Book()
                {
                    Title = "Czy Wielki Wybuch był głośny?",
                    Description = "Przyszłość i przeszłość Wszechświata, czarne dziury, gwiazdy neutronowe, planety słoneczne i pozasłoneczne, czerwone olbrzymy, białe karły, fale grawitacyjne... Astrofizyka jest fascynująca, ale i niełatwa. Ta książka prowadzi czytelnika krok po kroku - nie tylko daje odpowiedzi, ale i podsuwa pytania.",
                    IsBorrowed = false,
                    IsWithdrawn = false,
                    CopyNumber = "2",
                    PublishingHouseId = 6,
                    Authors = _dbContext.Authors.Where(a => a.Id == 1 || a.Id == 2).ToList()
                },
                new Book()
                {
                    Title = "Czy Wielki Wybuch był głośny?",
                    Description = "Przyszłość i przeszłość Wszechświata, czarne dziury, gwiazdy neutronowe, planety słoneczne i pozasłoneczne, czerwone olbrzymy, białe karły, fale grawitacyjne... Astrofizyka jest fascynująca, ale i niełatwa. Ta książka prowadzi czytelnika krok po kroku - nie tylko daje odpowiedzi, ale i podsuwa pytania.",
                    IsBorrowed = false,
                    IsWithdrawn = false,
                    CopyNumber = "3",
                    PublishingHouseId = 6,
                    Authors = _dbContext.Authors.Where(a => a.Id == 1 || a.Id == 2).ToList()
                },
                new Book()
                {
                    Title = "Wszyscy kłamią",
                    Subtitle = "Big data, nowe dane i wszystko, co internet może nam powiedzieć o tym, kim naprawdę jesteśmy.",
                    Description = "Wystarczy znać pytania kierowane do Google, aktywność na Facebooku, portalach randkowych, częstotliwość wizyt na stronach dla dorosłych. Doświadczony badacz na tej podstawie udowodni nam, że nie jesteśmy ani tym, za kogo się podajemy, ani tym, kim nam się wydaje, że jesteśmy.",
                    IsBorrowed = false,
                    IsWithdrawn = false,
                    CopyNumber = "1",
                    PublishingHouseId = 3,
                    Authors = _dbContext.Authors.Where(a => a.Id == 7).ToList()
                },
                new Book()
                {
                    Title = "Wszyscy kłamią",
                    Subtitle = "Big data, nowe dane i wszystko, co internet może nam powiedzieć o tym, kim naprawdę jesteśmy.",
                    Description = "Wystarczy znać pytania kierowane do Google, aktywność na Facebooku, portalach randkowych, częstotliwość wizyt na stronach dla dorosłych. Doświadczony badacz na tej podstawie udowodni nam, że nie jesteśmy ani tym, za kogo się podajemy, ani tym, kim nam się wydaje, że jesteśmy.",
                    IsBorrowed = false,
                    IsWithdrawn = false,
                    CopyNumber = "2",
                    PublishingHouseId = 3,
                    Authors = _dbContext.Authors.Where(a => a.Id == 7).ToList()
                },
                new Book()
                {
                    Title = "Śniadanie z Einsteinem",
                    Subtitle = "Zdumiewające zjawiska kwantowe wokół nas.",
                    Description = "Działanie mechaniki kwantowej możemy obserwować w naszym otoczeniu, ponieważ cały otaczający nas świat jest przesiąknięty dziwnymi i abstrakcyjnymi zjawiskami kwantowymi. Nawet najzwyczajniejsze w świecie czynności, takie jak przygotowanie śniadania czy pisanie na komputerze, są z gruntu kwantowe!",
                    IsBorrowed = false,
                    IsWithdrawn = false,
                    CopyNumber = "1",
                    PublishingHouseId = 6,
                    Authors = _dbContext.Authors.Where(a => a.Id == 4).ToList()
                },
                new Book()
                {
                    Title = "Śniadanie z Einsteinem",
                    Subtitle = "Zdumiewające zjawiska kwantowe wokół nas.",
                    Description = "Działanie mechaniki kwantowej możemy obserwować w naszym otoczeniu, ponieważ cały otaczający nas świat jest przesiąknięty dziwnymi i abstrakcyjnymi zjawiskami kwantowymi. Nawet najzwyczajniejsze w świecie czynności, takie jak przygotowanie śniadania czy pisanie na komputerze, są z gruntu kwantowe!",
                    IsBorrowed = false,
                    IsWithdrawn = false,
                    CopyNumber = "2",
                    PublishingHouseId = 6,
                    Authors = _dbContext.Authors.Where(a => a.Id == 4).ToList()
                },
                new Book()
                {
                    Title = "Śniadanie z Einsteinem",
                    Subtitle = "Zdumiewające zjawiska kwantowe wokół nas.",
                    Description = "Działanie mechaniki kwantowej możemy obserwować w naszym otoczeniu, ponieważ cały otaczający nas świat jest przesiąknięty dziwnymi i abstrakcyjnymi zjawiskami kwantowymi. Nawet najzwyczajniejsze w świecie czynności, takie jak przygotowanie śniadania czy pisanie na komputerze, są z gruntu kwantowe!",
                    IsBorrowed = false,
                    IsWithdrawn = false,
                    CopyNumber = "3",
                    PublishingHouseId = 6,
                    Authors = _dbContext.Authors.Where(a => a.Id == 4).ToList()
                },
                new Book()
                {
                    Title = "Śniadanie z Einsteinem",
                    Subtitle = "Zdumiewające zjawiska kwantowe wokół nas.",
                    Description = "Działanie mechaniki kwantowej możemy obserwować w naszym otoczeniu, ponieważ cały otaczający nas świat jest przesiąknięty dziwnymi i abstrakcyjnymi zjawiskami kwantowymi. Nawet najzwyczajniejsze w świecie czynności, takie jak przygotowanie śniadania czy pisanie na komputerze, są z gruntu kwantowe!",
                    IsBorrowed = false,
                    IsWithdrawn = false,
                    CopyNumber = "4",
                    PublishingHouseId = 6,
                    Authors = _dbContext.Authors.Where(a => a.Id == 4).ToList()
                },
                new Book()
                {
                    Title = "Problem trzech ciał",
                    Description = "Tajny chiński projekt z czasów Mao przynosi przerażające konsekwencje kilkadziesiąt lat później. Początek XXI wieku - po serii samobójstw wybitnych fizyków śledztwo prowadzi do tajemniczej sieciowej gry \"Trzy ciała\", której celem jest uratowanie mieszkańców planety zagrożonej oddziaływaniem grawitacyjnym trzech słońc. Świat tej gry nie jest jednak fikcją...",
                    IsBorrowed = false,
                    IsWithdrawn = false,
                    CopyNumber = "1",
                    PublishingHouseId = 5,
                    Authors = _dbContext.Authors.Where(a => a.Id == 3).ToList()
                },
                new Book()
                {
                    Title = "Problem trzech ciał",
                    Description = "Tajny chiński projekt z czasów Mao przynosi przerażające konsekwencje kilkadziesiąt lat później. Początek XXI wieku - po serii samobójstw wybitnych fizyków śledztwo prowadzi do tajemniczej sieciowej gry \"Trzy ciała\", której celem jest uratowanie mieszkańców planety zagrożonej oddziaływaniem grawitacyjnym trzech słońc. Świat tej gry nie jest jednak fikcją...",
                    IsBorrowed = false,
                    IsWithdrawn = false,
                    CopyNumber = "2",
                    PublishingHouseId = 5,
                    Authors = _dbContext.Authors.Where(a => a.Id == 3).ToList()
                },
                new Book()
                {
                    Title = "Ojciec chrzestny",
                    Description = "Don Vito Corleone jest Ojcem Chrzestnym jednej z sześciu nowojorskich rodzin mafijnych. Tyran i szantażysta, a zarazem człowiek honoru, sprawuje rządy żelazną ręką. Jego decyzje mają charakter ostateczny. Wśród swoich wrogów wzbudza respekt i strach, wśród przyjaciół - zasłużony, choć nie całkiem bezinteresowny szacunek.",
                    IsBorrowed = false,
                    IsWithdrawn = false,
                    CopyNumber = "1",
                    PublishingHouseId = 2,
                    Authors = _dbContext.Authors.Where(a => a.Id == 5).ToList()
                },
                new Book()
                {
                    Title = "Sycylijczyk",
                    Description = "Sycylia, rok 1950. Dwuletnie wygnanie Michaela Corleone zbliża się ku końcowi. Na polecenie ojca ma zorganizować ucieczkę do Ameryki młodego bandyty Salvatore Guiliana. Dla Sycylijczyków Guiliano jest bohaterem, który walcząc ze skorumpowanymi władzami, przysporzył sobie wielu wrogów, i to potężnych.",
                    IsBorrowed = false,
                    IsWithdrawn = false,
                    CopyNumber = "1",
                    PublishingHouseId = 2,
                    Authors = _dbContext.Authors.Where(a => a.Id == 5).ToList()
                },
                new Book()
                {
                    Title = "Rodzina Corleone",
                    Description = "Akcja książki toczy się w latach 30-tych XX wieku. W USA kończy się era prohibicji. Rodzina Corleone, jedna z pomniejszych organizacji przestępczych operujących w Nowym Jorku, staje przed szansą zdobycia dominującej pozycji wśród miejscowych rodzin mafijnych...",
                    IsBorrowed = false,
                    IsWithdrawn = false,
                    CopyNumber = "1",
                    PublishingHouseId = 2,
                    Authors = _dbContext.Authors.Where(a => a.Id == 5 || a.Id == 9).ToList()
                },
                new Book()
                {
                    Title = "Milion lat w jeden dzień",
                    Subtitle = "Fascynująca historia życia codziennego od jaskini do globalnej wioski.",
                    Description = "Każego dnia, od chwilii, gdy zadzwoni budzik, po przykrycie się kołdrą na dobranoc, bierzemy udział w rytuałach, które trwają od milionów lat. Autor zagląda do rzymskich śmietników, egipskich mumii i wiktoriańskich ścieków, wyciągając niezwykłe, zaskakujące, a czasem wręcz niedorzeczne ciekawostki o naszej przeszłości.",
                    IsBorrowed = false,
                    IsWithdrawn = false,
                    CopyNumber = "1",
                    PublishingHouseId = 4,
                    Authors = _dbContext.Authors.Where(a => a.Id == 6).ToList()
                },
                new Book()
                {
                    Title = "Milion lat w jeden dzień",
                    Subtitle = "Fascynująca historia życia codziennego od jaskini do globalnej wioski.",
                    Description = "Każego dnia, od chwilii, gdy zadzwoni budzik, po przykrycie się kołdrą na dobranoc, bierzemy udział w rytuałach, które trwają od milionów lat. Autor zagląda do rzymskich śmietników, egipskich mumii i wiktoriańskich ścieków, wyciągając niezwykłe, zaskakujące, a czasem wręcz niedorzeczne ciekawostki o naszej przeszłości.",
                    IsBorrowed = false,
                    IsWithdrawn = false,
                    CopyNumber = "2",
                    PublishingHouseId = 4,
                    Authors = _dbContext.Authors.Where(a => a.Id == 6).ToList()
                },
                new Book()
                {
                    Title = "Milion lat w jeden dzień",
                    Subtitle = "Fascynująca historia życia codziennego od jaskini do globalnej wioski.",
                    Description = "Każego dnia, od chwilii, gdy zadzwoni budzik, po przykrycie się kołdrą na dobranoc, bierzemy udział w rytuałach, które trwają od milionów lat. Autor zagląda do rzymskich śmietników, egipskich mumii i wiktoriańskich ścieków, wyciągając niezwykłe, zaskakujące, a czasem wręcz niedorzeczne ciekawostki o naszej przeszłości.",
                    IsBorrowed = false,
                    IsWithdrawn = false,
                    CopyNumber = "3",
                    PublishingHouseId = 4,
                    Authors = _dbContext.Authors.Where(a => a.Id == 6).ToList()
                },
                new Book()
                {
                    Title = "Wiedźmin. Wierza jaskółki",
                    Description = "Jesienne Ekwinokcjum tegoż dziwnego roku przyniosło rozmaite znaki na niebie i na ziemi, które jakoweś klęski niechybnie zwiastowały. Tuż przed północą zerwała się straszliwa zawierucha, zadął potępieńczy wicher, a pędzone po iebie chmury przybrały fantastyczne kształty, wśród których najczęściej powtarzały się sylwetki galopujących koni i jednorożców.",
                    IsBorrowed = false,
                    IsWithdrawn = false,
                    CopyNumber = "1",
                    PublishingHouseId = 1,
                    Authors = _dbContext.Authors.Where(a => a.Id == 8).ToList()
                },
                new Book()
                {
                    Title = "Wiedźmin. Chrzest ognia",
                    Description = "Jaskier, trubadur w kapelusiku z piórkiem egreta. Studiował siedem sztuk wyzwolonych, słynny po wszystkich dworach i zamtuzach. \"Kłamliwa łajza\" i \"zachrypnięty bażant\" to najłagodniejsze z określeń, jakimi porzucają go odrzucone kochanki. Cahir, czarny rycerz z koszmarów Ciri. poszukiwany przez najlepszych szpiegów Cesarstwa Nilfgaardczyk, który dowodzi, że Nilfgaardczykiem wcale nie jest.",
                    IsBorrowed = false,
                    IsWithdrawn = false,
                    CopyNumber = "1",
                    PublishingHouseId = 1,
                    Authors = _dbContext.Authors.Where(a => a.Id == 8).ToList()
                },
                new Book()
                {
                    Title = "Wiedźmin. Pani jeziora",
                    Description = "Ciri wpatruje się w wypukły relief przedstawiający ogromnego łuskowatego węża. Gad, zwinąwszy się w kształt ósemki, wgryzł się zębiskami we własny ogon. To pradawny wąż Uroboros. Symbolizuje nieskończoność i sam jest nieskończonością. Jest wiecznym odchodzeniem i wiecznym powracaniem. Jest czymś, co nie ma ani początku, ani końca.",
                    IsBorrowed = false,
                    IsWithdrawn = false,
                    CopyNumber = "1",
                    PublishingHouseId = 1,
                    Authors = _dbContext.Authors.Where(a => a.Id == 8).ToList()
                }
            };

            return books;
        }
    }
}