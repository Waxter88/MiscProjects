using JacksonPipe_MVC_Music.Models;

namespace JacksonPipe_MVC_Music.Data
{
    public static class MusicInitializer
    {
        //Add seed/sample data to MusicContext
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            MusicContext context = applicationBuilder.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<MusicContext>();
            if (!context.Instruments.Any())
            {
                context.Instruments.AddRange(
                new Instrument { Name = "Guitar" },
                new Instrument { Name = "Bass" },
                new Instrument { Name = "Piano" }
               );
                context.SaveChanges();
            }

            if (!context.Musicians.Any())
            {
                context.Musicians.AddRange(
                new Musician
                {
                    FirstName = "John",
                    LastName = "Lennon",
                    Phone = "555-555-5555",
                    DOB = new DateTime(1940, 10, 9),
                    SIN = "647896201",
                    InstrumentID = context.Instruments.FirstOrDefault(i => i.Name == "Guitar").ID
                },
                new Musician
                {
                    FirstName = "Paul",
                    LastName = "McCartney",
                    Phone = "555-555-5555",
                    DOB = new DateTime(1942, 6, 18),
                    SIN = "627382910",
                    InstrumentID = context.Instruments.FirstOrDefault(i => i.Name == "Guitar").ID
                },
                new Musician
                {
                    FirstName = "George",
                    LastName = "Harrison",
                    Phone = "555-555-5555",
                    DOB = new DateTime(1943, 2, 25),
                    SIN = "890271625",
                    InstrumentID = context.Instruments.FirstOrDefault(i => i.Name == "Guitar").ID
                },
                new Musician
                {
                    FirstName = "Ringo",
                    LastName = "Starr",
                    Phone = "555-555-5555",
                    DOB = new DateTime(1940, 7, 7),
                    SIN = "123456789",
                    InstrumentID = context.Instruments.FirstOrDefault(i => i.Name == "Guitar").ID
                }
                );
                context.SaveChanges();
            }

            if (context.Plays.Any())
            {
                context.Plays.AddRange(
                new Play
                {
                    MusicianID = context.Musicians.FirstOrDefault(m => m.FirstName == "John").ID,
                    InstrumentID = context.Instruments.FirstOrDefault(i => i.Name == "Guitar").ID
                },
                new Play
                {
                    MusicianID = context.Musicians.FirstOrDefault(m => m.FirstName == "Paul").ID,
                    InstrumentID = context.Instruments.FirstOrDefault(i => i.Name == "Guitar").ID
                },
                new Play
                {
                    MusicianID = context.Musicians.FirstOrDefault(m => m.FirstName == "George").ID,
                    InstrumentID = context.Instruments.FirstOrDefault(i => i.Name == "Guitar").ID
                },
                new Play
                {
                    MusicianID = context.Musicians.FirstOrDefault(m => m.FirstName == "Ringo").ID,
                    InstrumentID = context.Instruments.FirstOrDefault(i => i.Name == "Guitar").ID
                }
                );
            }

        }
    }
}
