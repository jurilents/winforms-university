namespace JustReflectionLab7
{
    internal class Ship
    {
        public Ship(decimal priceCoef = 1m)
        {
            _priceCoef = priceCoef;
            _certificates = new List<string>();
            Crew = ShipCrew.CreateDefault();
        }

        public Ship(string name, int width, int height, DateTime dateConstructed,
            TimeSpan expluatationTime, decimal priceCoef = 1m) : this(priceCoef)
        {
            Name = name;
            Width = width;
            Height = height;
            DateConstructed = dateConstructed;
            ExpluatationTime = expluatationTime;
        }

        private decimal _priceCoef { get; }
        private List<string> _certificates { get; }


        public string Name { get; set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public decimal Price { get; private set; }
        public IEnumerable<string> Certificates => _certificates;
        public DateTime DateConstructed { get; }
        public TimeSpan ExpluatationTime { get; }
        public ShipCrew Crew { get; }


        public void AddCertificate(string certificatePath)
        {
            if (string.IsNullOrEmpty(certificatePath))
                throw new ArgumentNullException(nameof(certificatePath));
            _certificates.Add(certificatePath);
        }

        public void RemoveCertificate(string certificatePath)
        {
            if (string.IsNullOrEmpty(certificatePath))
                throw new ArgumentNullException(nameof(certificatePath));
            _certificates.Remove(certificatePath);
        }

        public void SetSize(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public void RecalculatePrice()
        {
            Price = _priceCoef * Width * Height * Crew.RecommendedCapacity;
        }
    }

    internal class ShipCrew
    {
        public ShipCrew(int recommendedCapacity)
        {
            RecommendedCapacity = recommendedCapacity;
        }

        private ShipCrew() { }

        public static ShipCrew CreateDefault()
        {
            return new ShipCrew();
        }


        private List<CrewMember> _crewMembers { get; } = new List<CrewMember>();

        public int RecommendedCapacity { get; set; } = 10;
        public IEnumerable<CrewMember> Members { get; set; }


        public void AddMember(CrewMember member)
        {
            _crewMembers.Add(member);
        }

    }

    internal class CrewMember
    {
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public string? Biography { get; set; }
        public ushort Age { get; set; }
        public DateTime DateJined { get; set; }
        public Dictionary<string, object> Metadata { get; } = new();
    }
}
