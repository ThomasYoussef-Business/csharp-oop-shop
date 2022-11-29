namespace CSharpShop {
    public class Prodotto {
        public string Codice { get; init; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        private readonly float prezzoBase;
        public float PrezzoBase {
            get => prezzoBase;
            init {
                if (value is < 0) {
                    throw new ArgumentOutOfRangeException(nameof(value), $"{nameof(value)} non può essere meno di zero");
                }
                prezzoBase = value;
            }
        }
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
