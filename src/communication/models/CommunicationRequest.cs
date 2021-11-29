using System;

namespace paws.communication
{
    public class CommunicationRequest
    {

        // Personne cible de la communication
        public string TargetAddress { get; set; }

        // Personne cible de la communication
        public string TargetName { get; set; }

        // Contact qui envoie la communication
        public string FromAddress { get; set; }

        // Contact qui envoie la communication
        public string FromName { get; set; }

        // Sujet de la communication
        public string Subject { get; set; }

        // Contenu Raw de la communication
        public string Content { get; set; }

        // Contenu HTML de la communication
        public string HtmlContent { get; set; }

    }
}