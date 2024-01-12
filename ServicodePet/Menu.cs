namespace ServicodePet {
    public partial class Menu : Form {
        public Menu() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void buscarRaçasToolStripMenuItem_Click(object sender, EventArgs e) {
            Racas racas = new Racas();
            racas.Show();
        }

        private void meusFavoritosToolStripMenuItem_Click(object sender, EventArgs e) {
            Favoritos favoritos = new Favoritos();
            favoritos.Show();
        }
    }
}