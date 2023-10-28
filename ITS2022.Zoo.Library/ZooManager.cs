using System.Text.Json;

namespace ITS2022.Zoo.Library
{
    /// <summary>
    /// Gestore applicazione
    /// </summary>
    public class ZooManager
    {
        /// <summary>
        /// path del file per il database
        /// </summary>
        private const string DatabasePath = "database.json";
        /// <summary>
        /// oggetto database
        /// </summary>
        private Database _database = new Database();
        /// <summary>
        /// Caricamento dello stato dal database in formato json
        /// </summary>
        private void Load()
        {
            if (File.Exists(DatabasePath))
            {
                var database = File.ReadAllText(DatabasePath);
                _database = JsonSerializer.Deserialize<Database>(database);
            }
        }
        /// <summary>
        /// Start dell'applicazione.
        /// </summary>
        public void Start()
        {
            Load();
            while (true)
            {
                Summary();
                var command = GetCommand();
                if (!SetCommand(command))
                    break;
            }
        }
        /// <summary>
        /// Sommario della situazione del database
        /// </summary>
        private void Summary()
        {
            Space();
            Console.WriteLine($"Il numero di animali è: {_database.Animals.Count}");
            Console.WriteLine($"Il numero di gabbie è: {_database.Cages.Count}");
            if (_database.Cages.Any(x => x.Animals.Count > 0))
                Console.WriteLine($"La gabbia con più animali è: {_database.Cages.OrderByDescending(x => x.Animals.Count).FirstOrDefault()?.Name}");
            else
                Console.WriteLine("Non ci sono animali in gabbia");
            Console.WriteLine($"Il numero di pasti è: {_database.Meals.Count}");
            Space();
        }
        /// <summary>
        /// Lista dei comandi.
        /// </summary>
        private int GetCommand()
        {
            Console.WriteLine("Salve zoo di Wano. Cosa vuoi fare?");
            Console.WriteLine("Aggiungere un animale con 1.");
            Console.WriteLine("Cancellare un animale con 2.");
            Console.WriteLine("Aggiungere una gabbia con 3.");
            Console.WriteLine("Cancellare una gabbia con 4.");
            Console.WriteLine("Aggiungere un animale ad una gabbia con 5.");
            Console.WriteLine("Rimuovere un animale da una gabbia con 6.");
            Console.WriteLine("Dare da mangiare ad un animale con 7.");
            Console.WriteLine("Salvare la situazione con 90.");
            Console.WriteLine("Uscire con 100.");
            _ = int.TryParse(Console.ReadLine(), out var number);
            return number;
        }
        /// <summary>
        /// Spaziatura
        /// </summary>
        private void Space()
        {
            Console.WriteLine();
            Console.WriteLine();
        }
        /// <summary>
        /// Invocazione dei comandi
        /// </summary>
        /// <param name="command">comando</param>
        /// <returns>false per uscire</returns>
        private bool SetCommand(int command)
        {
            switch (command)
            {
                default:
                case 0:
                    Console.WriteLine("Comando non esistente.");
                    break;
                case 1:
                    AddAnimal();
                    break;
                case 2:
                    DeleteAnimal();
                    break;
                case 3:
                    AddCage();
                    break;
                case 4:
                    DeleteCage();
                    break;
                case 5:
                    AddAnimalToCage();
                    break;
                case 6:
                    RemoveAnimalFromCage();
                    break;
                case 7:
                    FeedAnimal();
                    break;
                case 90:
                    Save();
                    break;
                case 100:
                    return false;
            }
            return true;
        }
        /// <summary>
        /// Aggiunta animale
        /// </summary>
        private void AddAnimal()
        {
            Console.WriteLine("Il nome dell'animale è:");
            var name = Console.ReadLine();
            Console.WriteLine("Cosa mangia? 0 per onnivoro, 1 per carnivoro, e 2 per erbivoro.");
            _ = int.TryParse(Console.ReadLine(), out var foodType);
            var food = (FoodType)foodType;
            Console.WriteLine("La specie è:");
            var kind = Console.ReadLine();
            _database.Animals.Add(new Animal
            {
                Id = Guid.NewGuid().ToString(),
                Food = food,
                Kind = kind,
                Name = name
            });
        }
        /// <summary>
        /// Rimozione animale
        /// </summary>
        private void DeleteAnimal()
        {
            Console.WriteLine("Inserisci il nome dell'animale da cancellare.");
            var name = Console.ReadLine();
            var animal = _database.Animals.FirstOrDefault(x => x.Name == name);
            if (animal != null)
                _database.Animals.Remove(animal);
        }
        /// <summary>
        /// Aggiunta gabbia
        /// </summary>
        private void AddCage()
        {
            Console.WriteLine("Il nome della gabbia è:");
            var name = Console.ReadLine();
            _database.Cages.Add(new Cage
            {
                Id = Guid.NewGuid().ToString(),
                Name = name
            });
        }
        /// <summary>
        /// Rimozione gabbia
        /// </summary>
        private void DeleteCage()
        {
            Console.WriteLine("Inserisci il nome della gabbia da cancellare.");
            var name = Console.ReadLine();
            var cage = _database.Cages.FirstOrDefault(x => x.Name == name);
            if (cage != null)
                _database.Cages.Remove(cage);
        }
        /// <summary>
        /// Aggiunta animale ad una gabbia
        /// </summary>
        private void AddAnimalToCage()
        {
            Console.WriteLine("Inserisci il nome dell'animale da aggiungere.");
            var animalName = Console.ReadLine();
            Console.WriteLine("Inserisci il nome della gabbia dove aggiungerlo.");
            var cageName = Console.ReadLine();
            var animal = _database.Animals.FirstOrDefault(x => x.Name == animalName);
            var cage = _database.Cages.FirstOrDefault(x => x.Name == cageName);
            if (animal != null && cage != null)
            {
                if (!cage.Animals.Any(x => x == animal.Id))
                    cage.Animals.Add(animal.Id);
            }
        }
        /// <summary>
        /// Rimozione di un animale da una gabbia
        /// </summary>
        private void RemoveAnimalFromCage()
        {
            Console.WriteLine("Inserisci il nome dell'animale da cancellare.");
            var animalName = Console.ReadLine();
            Console.WriteLine("Inserisci il nome della gabbia da cancellare.");
            var cageName = Console.ReadLine();
            var animal = _database.Animals.FirstOrDefault(x => x.Name == animalName);
            var cage = _database.Cages.FirstOrDefault(x => x.Name == cageName);
            if (animal != null && cage != null)
            {
                cage.Animals.Remove(animal.Id);
            }
        }
        /// <summary>
        /// Sfamare un animale
        /// </summary>
        private void FeedAnimal()
        {
            Console.WriteLine("Inserisci il nome dell'animale da sfamare.");
            var animalName = Console.ReadLine();
            var animal = _database.Animals.FirstOrDefault(x => x.Name == animalName);
            if (animal != null)
            {
                Console.WriteLine($"{animal.Name} sta mangiando cibo {animal.Food}.");
                _database.Meals.Add(new FoodLog
                {
                    AnimalId = animal.Id,
                    Food = animal.Food,
                    Timestamp = DateTime.UtcNow,
                });
            }
        }
        /// <summary>
        /// Salvataggio della situazione su file in formato json
        /// </summary>
        private void Save()
        {
            File.WriteAllText(DatabasePath, JsonSerializer.Serialize(_database));
            Console.WriteLine("Salvataggio effettuato con successo.");
        }
    }
}
