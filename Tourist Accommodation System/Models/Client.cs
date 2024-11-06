namespace Tourist_Accommodation_System.Models
{
    public class Client : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string TIN { get; set; } //nif
        public DateTime BirthDate { get; set; }
        public List<Reservation> Reservations { get; set; }

        // Construtor dos objetos do cliente
        public Client(int id, string name, string email, string phone, string tin, DateTime birthDate)
        {
            Id = id;
            Name = name;
            Email = email;
            Phone = phone;
            TIN = tin;
            BirthDate = birthDate;
            Reservations = new List<Reservation>();
        }

        public override string GetDescription()
        {
            return $"Client: {Name}, Email: {Email}";
        }

        //metodo para adicionar reserva
        public void AddReservation(Reservation reservation)
        {
            Reservations.Add(reservation);
        }

        // Método para verificar se o cliente é maior de idade
        public bool IsAdult()
        {
            int age = DateTime.Now.Year - BirthDate.Year;

            // Verifica se o aniversário já passou neste ano
            if (BirthDate > DateTime.Now.AddYears(-age))
            {
                age--;
            }

            else

            {
                Console.WriteLine("You need to be +18 to do a reservation");
            }

            return age >= 18;
        }
    }
}
