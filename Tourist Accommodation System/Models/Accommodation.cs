namespace Tourist_Accommodation_System.Models
{
    public class Accommodation : Entity
    {
        public int Id { get; set; }  // Identificador único do alojamento
        public string Name { get; set; }  // Nome do alojamento
        public string Location { get; set; }  // Localização do alojamento
        public int Capacity { get; set; }  // Capacidade máxima de pessoas
        public decimal PricePerNight { get; set; }  // Preço por noite

        // Construtor para inicializar um alojamento
        public Accommodation(int id, string name, string location, int capacity, decimal pricePerNight)
        {
            Id = id;
            Name = name;
            Location = location;
            Capacity = capacity;
            PricePerNight = pricePerNight;
        }
        public override string GetDescription()
        {
            return $"Accommodation: {Name} in {Location}, Price per Night: {PricePerNight}";
        }
    }
}
