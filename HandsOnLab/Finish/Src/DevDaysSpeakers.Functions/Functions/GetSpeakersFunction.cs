using System.Collections.Generic;
using DevDaysSpeakers.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace DevDaysSpeakers.Functions
{
    public static class GetSpeakersFunction
    {
        [FunctionName(nameof(GetSpeakersFunction))]
        public static IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequest req, ILogger log)
        {
            log.LogInformation("Generating Speakers");

            var speakersList = GenerateSpeakers();

            log.LogInformation("Returning Speaker List");

            return new OkObjectResult(speakersList);
        }

        static List<Speaker> GenerateSpeakers()
        {
            return new List<Speaker>
            {
                new Speaker
                {
                    Name = "Alexander Llanes",
                    Description = "Desarrollador de software con más de 10 años de experiencia en este rol, aunque desde mucho antes me he considerado un apasionado por las nuevas tecnologías y lo que ellas pueden otorgar a la vida cotidiana de las personas. Interesado en el enfoque “Software craftsmanship” en conjunto con metodologías ágiles me he especializado en la mayor parte de mi carrera en tecnologías .NET y el desarrollo de aplicaciones móviles.",
                    Title = ".NET mobile developer",
                    Website = "https://twitter.com/allanes87",
                    Avatar = "https://ca.slack-edge.com/T0HJUAL8M-U98KEEGSZ-43729d762bda-512"
                },
                new Speaker
                {
                    Name = "Bruno Nocetti",
                    Description = "Full-stack picatecla at Nareia. Fanático de Star Wars e hincha del mas grande ;)",
                    Title = "Full-stack picatecla at Nareia",
                    Website = "",
                    Avatar = "https://i.imgur.com/ybqvbpr.jpg",
                },
                new Speaker
                {
                    Name = "Diego Bonilla",
                    Description = "Oriental, pica tecla, co-founder & CEO at Nareia. Organizer of @XamarinUY",
                    Title = "Xamarin lover",
                    Website = "https://twitter.com/dbonillanareia",
                    Avatar = "http://i.imgur.com/GG7nHU3.png",
                },
                new Speaker
                {
                    Name = "Johann Pérez",
                    Description = "CoFounder y CTO de Nareia Software. Ingeniero en computación. Desarrollador .NET desde 2008. Data Scientist en construcción.",
                    Title = "Sir",
                    Website = "http://twitter.com/ermitani0",
                    Avatar = "https://imgur.com/mrIbKO1.jpg",
                },
                new Speaker
                {
                    Name = "Julio Cabrera",
                    Description = "Inicia su carrera en el ámbito de sistemas en el 2008 trabajando en una empresa de desarrollo de sistemas de administración de distribuidoras para empresas locales e internacionales. Desde entonces hasta la actualidad se ha desempeñado en diferentes empresas y proyectos",
                    Title = "Technical Lead",
                    Website = "https://www.linkedin.com/in/juliocabrera1/",
                    Avatar = "https://i.imgur.com/558sZo0.jpg",
                },
                new Speaker
                {
                    Name = "Maria José Rabaza",
                    Description = "Ingeñeri :female-technologist::skin-tone-2:. Happy monkey dev en Nareia :monkey:🧉:flag-uy:",
                    Title = "Ingeniera/Xamarin developer",
                    Website = "https://twitter.com/majorabaza",
                    Avatar = "https://imgur.com/13a6LlT.jpg",
                },
                new Speaker
                {
                    Name = "Maximiliano Romano",
                    Description = "Development engine run on mate",
                    Title = "Developer",
                    Website = "https://wt.social/u/maximiliano-romano",
                    Avatar = "https://i.imgur.com/iXXCoPA.jpg",
                },
                new Speaker
                {
                    Name = "Micaela Perdomo",
                    Description = "",
                    Title = "Xamarin Certified Developer",
                    Website = "https://twitter.com/Micaela_Perdomo",
                    Avatar = "https://ca.slack-edge.com/T0HJUAL8M-U6Z5RB9UN-8b4b5c75d5f0-512",
                },
                new Speaker
                {
                    Name = "Nicolás Berrogorry",
                    Description = "Autodidacta en programación y Game Design.",
                    Title = "Full Stack Developer",
                    Website = "",
                    Avatar = "https://i.imgur.com/1sCT3Ao.jpg",
                },new Speaker
                {
                    Name = "Roygar Briceño",
                    Description = "Roygar es un arquitecto de software venezolano que vive en Uruguay desde el 2015 y ha estado programando con .Net desde sus inicios. Le encanta Xamarin, el desarrollo de aplicaciones móviles, la nube, y por supuesto, probar nuevas tecnologías interesantes. Cuando no esta trabajando, lo puedes encontrar hablando con colegas en una reunión, como orador en algún evento tecnológico o tal vez jugando Dark Souls. Siempre está buscando el próximo desafío y nuevas cosas que aprender.",
                    Title = "Solution Architect",
                    Website = "https://www.linkedin.com/in/roygarbriceno/",
                    Avatar = "https://i.imgur.com/3GNXQ2s.jpg",
                }
            };
        }
    }
}
