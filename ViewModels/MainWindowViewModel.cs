namespace AvaloniaApplication1.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public string Greeting { get; } = "Bonjour [nom utilisateur] !";

        // Ajout de la propriété pour le contenu dynamique (le milieu de votre fenêtre)
        // Pour l'instant, on peut la laisser à null ou lui donner un objet par défaut
        public object? CurrentPageContent { get; set; }
    }
}