using System;
namespace atelier4
{
    public interface IOrbitable
    {
        // Propriété pour obtenir les satellites orbitant autour de l'objet
        Satellite[] Satellites { get; }

        // Indexeur pour accéder à un satellite spécifique
        Satellite this[int i] { get; set; }
    }
}

