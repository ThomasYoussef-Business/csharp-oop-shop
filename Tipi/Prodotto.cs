namespace Tipi {
    public class Prodotto {
        public string Codice { get; init; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public int PrezzoBase { get; init; }
        public int Iva { get; init; }
        public int PrezzoConIva {
            get {
                throw new NotImplementedException();
            }
        }


        public Prodotto() {
            throw new NotImplementedException();
        }

    }
}
