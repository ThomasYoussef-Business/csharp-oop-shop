namespace CSharpShop {
    public class Prodotto {
        public string Codice { get; init; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public float PrezzoBase { get; init; }
        private readonly float iva;
        public float Iva {
            get => iva;
            init {
                if (value is < 0 or > 1) {
                    throw new ArgumentOutOfRangeException(nameof(value), $"{nameof(value)} deve essere tra 0 e 1");
                }
            }
        }
        public float PrezzoConIva { get => (PrezzoBase * Iva); }


        public Prodotto() {
            throw new NotImplementedException();
        }

    }
}
