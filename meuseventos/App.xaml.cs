using meuseventos.Modelss;

namespace meuseventos
{
    public partial class App : Application
    {
        public List<Eventoo> lista_eventoos = new List<Eventoo>
        {
            new Eventoo()
            {
                Descricao = "Mega",
                ValorHomem = 200.0,
                ValorMulher = 175.0
            },
            new Eventoo()
            {
                Descricao = "Super",
                ValorHomem = 175.0,
                ValorMulher = 150.0
            },
            new Eventoo()
            {
                Descricao = "Inter",
                ValorHomem = 150.0,
                ValorMulher = 125.0
            },
            new Eventoo()
            {
                Descricao = "Simples",
                ValorHomem = 125.0,
                ValorMulher = 100.0
            }

    };
        
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Viewss.Cadastrodoevento());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {

            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }

    }

}
