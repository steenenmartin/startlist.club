using System.Collections.Generic;
using FlightJournal.Web.Models;

namespace FlightJournal.Web.Migrations.FlightContext
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FlightJournal.Web.Models.FlightContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false; 
            AutomaticMigrationDataLossAllowed = false;
            MigrationsDirectory = @"Migrations\FlightContext";
        }

        protected override void Seed(FlightJournal.Web.Models.FlightContext context)
        {
            //  This method will be called after migrating to the latest version.
            
            if (!context.TrainingLessonCategories.Any()
                && !context.TrainingLessons.Any())
            {
                InitializeTrainingLessons(context);
            }

            //  Only seed if the database is empty
            if (!context.StartTypes.Any() 
                && (!context.Clubs.Any())
                && (!context.Pilots.Any())
                && (!context.Planes.Any()))
            {
                InitializeDemoFlights(context);
            }

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }

        private void InitializeTrainingLessons(Models.FlightContext context)
        {
            context.TrainingLessonCategories.AddOrUpdate(
              new TrainingLessonCategory { TrainingLessonCategoryId = 1, TrainingLessonCategoryName = "A-normer (SPL)", Enabled = true },
              new TrainingLessonCategory { TrainingLessonCategoryId = 2, TrainingLessonCategoryName = "B-normer (SPL)", Enabled = true },
              new TrainingLessonCategory { TrainingLessonCategoryId = 3, TrainingLessonCategoryName = "Typeomskoling", Enabled = true },
              new TrainingLessonCategory { TrainingLessonCategoryId = 4, TrainingLessonCategoryName = "Startmetode", Enabled = true }
            );

            int trainingLessonSortOrder = 1;
            context.TrainingLessons.AddOrUpdate(
                new TrainingLesson { TrainingLessonId = trainingLessonSortOrder++, Identifier = "A-0 (1)", Description = "Grundl�ggende kenskab til sv�veflyet", SortOrder = trainingLessonSortOrder++, Enabled = true, RequiresFlight = false, RequiresFlightInstructorApproval = true, TrainingLessonCategoryId = 1 },
                new TrainingLesson { TrainingLessonId = trainingLessonSortOrder++, Identifier = "A-0 (2)", Description = "Flyvesikkerhed", SortOrder = trainingLessonSortOrder++, Enabled = true, RequiresFlight = false, RequiresFlightInstructorApproval = true, TrainingLessonCategoryId = 1 },
                new TrainingLesson { TrainingLessonId = trainingLessonSortOrder++, Identifier = "A-0 (-)", Description = "Safety Management System - DSvU", SortOrder = trainingLessonSortOrder++, Enabled = true, RequiresFlight = false, RequiresFlightInstructorApproval = true, TrainingLessonCategoryId = 1 },
                new TrainingLesson { TrainingLessonId = trainingLessonSortOrder++, Identifier = "A-1 (3)", Description = "Tilv�nningsflyvning forberedelse", SortOrder = trainingLessonSortOrder++, Enabled = true, RequiresFlight = false, RequiresFlightInstructorApproval = true, TrainingLessonCategoryId = 1 },
                new TrainingLesson { TrainingLessonId = trainingLessonSortOrder++, Identifier = "A-1 (4)", Description = "Tilv�nningsflyvning", SortOrder = trainingLessonSortOrder++, Enabled = true, RequiresFlight = true, RequiresFlightInstructorApproval = true, TrainingLessonCategoryId = 1 },
                new TrainingLesson { TrainingLessonId = trainingLessonSortOrder++, Identifier = "A-2 (5)", Description = "Grundl�ggende kenskab til sv�veflyet", SortOrder = trainingLessonSortOrder++, Enabled = true, RequiresFlight = true, RequiresFlightInstructorApproval = true, TrainingLessonCategoryId = 1 }
                );

            int exerciseSortOrder = 1;
            context.NonFlyingExercises.AddOrUpdate(
                new NonFlyingExercise { ExerciseId = exerciseSortOrder++, Description = "Sv�veflyets karakteristika", SortOrder = exerciseSortOrder, Enabled = true, TrainingLessonId = 1 },
                new NonFlyingExercise { ExerciseId = exerciseSortOrder++, Description = "Cockpit, instrumenter og udstyr", SortOrder = exerciseSortOrder, Enabled = true, TrainingLessonId = 1 });
        }

        internal static void InitializeDemoFlights(Models.FlightContext context)
        {
            // StartType
            var start = new StartType() { Name = "Spilstart", ShortName = "S" };
            context.StartTypes.Add(start);
            context.StartTypes.Add(new StartType() { Name = "Flysl�b", ShortName = "F" });
            context.StartTypes.Add(new StartType() { Name = "Selvstart", ShortName = "M" });
            context.SaveChanges();

            // Locations
            var location = new Location { Name = "Kongsted", Country = "DK", ICAO = "EKKL" };
            context.Locations.Add(location);
            var location2 = new Location { Name = "True", Country = "DK"};
            context.Locations.Add(location2);
            var location3 = new Location { Name = "Slaglille", Country = "DK", ICAO = "EKSL" };
            context.Locations.Add(location3);
            var location4 = new Location { Name = "T�ll�se" };
            context.Locations.Add(location4);
            var location5 = new Location { Name = "Martin", Country = "SK", ICAO = "LZMA" };
            context.Locations.Add(location5);
            
            context.Locations.Add(new Location() { Name = "Arnborg", Country = "DK", ICAO = "EK51" });
            context.SaveChanges();

            // Clubs
            var club = new Club() { ClubId = 38, ShortName = "�SF", Name = "�st-Sj�llands Flyveklub", Location = location, Website = "http://flyveklubben.dk"};
            context.Clubs.Add(club);
            var club2 = new Club() { ClubId = 99, ShortName = "AASVK", Name = "�rhus Sv�veflyveklub", Location = location2, Website = "http://www.aasvk.dk" };
            context.Clubs.Add(club2);
            var club3 = new Club() { ClubId = 199, ShortName = "MSF", Name = "Midtsj�llands Sv�veflyveklub", Location = location3, Website = "http://slaglille.dk" };
            context.Clubs.Add(club3);
            var club4 = new Club() { ClubId = 210, ShortName = "T�L", Name = "T�ll�se Flyveklub", Location = location4, Website = "http://www.cumulus.dk/" };
            context.Clubs.Add(club4);
            context.SaveChanges();

            // Planes
            var pl2 = new Plane
            {
                CompetitionId = "R2",
                Registration = "OY-XKO",
                Type = "ASK21",
                Seats = 2,
                DefaultStartType = start,
                Engines = 0
            };
            context.Planes.Add(pl2);
            var pla = new Plane
            {
                CompetitionId = "RR",
                Registration = "OY-RRX",
                Class = "Open",
                Type = "Duo Discus",
                Seats = 2,
                DefaultStartType = start,
                Engines = 1
            };
            context.Planes.Add(pla);
            var pl1 = new Plane
            {
                CompetitionId = "PU",
                Registration = "OY-XPU",
                Class = "15-Meter",
                Type = "LS6",
                Model = "LS6a",
                Seats = 1,
                DefaultStartType = start,
                Engines = 0
            };
            context.Planes.Add(pl1);
            context.SaveChanges();

            // Pilots
            var pilot = new Pilot { Name = "Jan Hebnes", MemberId = "1241", Club = club, Email = "jan.hebnes@gmail.com", MobilNumber = "+4500000000" };
            context.Pilots.Add(pilot);
            var pilot1 = new Pilot { Name = "Mr Demo Manager", MemberId = "9991", Club = club, MobilNumber = "+4500000001" };
            context.Pilots.Add(pilot1);
            var pilot2 = new Pilot { Name = "Mr Demo Editor", MemberId = "9992", Club = club, MobilNumber = "+4500000002" };
            context.Pilots.Add(pilot2);
            var pilot3 = new Pilot {Name = "Mr Demo Pilot", MemberId = "9993", Club = club, MobilNumber = "+4500000003"};
            context.Pilots.Add(pilot3);
            var pilot1B = new Pilot { Name = "Mr Demo OtherClub Manager", MemberId = "9995", Club = club3, MobilNumber = "+4500000005" };
            context.Pilots.Add(pilot1B);
            var pilot2B = new Pilot { Name = "Mr Demo OtherClub Editor", MemberId = "9996", Club = club3, MobilNumber = "+4500000006" };
            context.Pilots.Add(pilot2B);
            var pilot3B = new Pilot { Name = "Mr Demo OtherClub Pilot", MemberId = "9997", Club = club3, MobilNumber = "+4500000007" };
            context.Pilots.Add(pilot3B);


            context.SaveChanges();

            GenerateFlights(pl1, pl2, location, pilot, start)
                .ForEach(b => context.Flights.Add(b));

            GenerateFlights(pl1, pl2, location, pilot2, start)
                .ForEach(b => context.Flights.Add(b));
            
            GenerateFlights(pl1, pl2, location, pilot3, start)
                .ForEach(b => context.Flights.Add(b));


            GenerateFlights(pl1, pl2, location3, pilot2B, start)
                .ForEach(b => context.Flights.Add(b));

            GenerateFlights(pl1, pl2, location3, pilot3B, start)
                .ForEach(b => context.Flights.Add(b));
            
            GenerateFlights(pl1, pl2, location5, pilot3B, start)
                .ForEach(b => context.Flights.Add(b));

            context.SaveChanges();

        }

        private static List<Flight> GenerateFlights(Plane pl1, Plane pl2, Location location, Pilot pilot, StartType start)
        {
            var s = new List<Flight>
            {
                new Flight
                {
                    Departure = DateTime.Now.AddHours(-3),
                    Landing = DateTime.Now.AddHours(-3).AddMinutes(15),
                    Plane = pl1,
                    StartedFrom = location,
                    LandedOn = location,
                    Pilot = pilot,
                    Betaler = pilot,
                    StartType = start,
                    Description = "Demo flight",
                    LastUpdatedBy = pilot.ToString()
                },
                new Flight
                {
                    Plane = pl2,
                    StartedFrom = location,
                    Pilot = pilot,
                    Betaler = pilot,
                    StartType = start,
                    Description = "Demo flight",
                    LastUpdatedBy = pilot.ToString()
                },
                new Flight
                {
                    Departure = DateTime.Now.AddHours(-2),
                    Plane = pl2,
                    StartedFrom = location,
                    Pilot = pilot,
                    Betaler = pilot,
                    StartType = start,
                    LastUpdatedBy = pilot.ToString(),
                    Description = "Demo flight"
                },
                new Flight
                {
                    Departure = DateTime.Now.AddHours(-1),
                    Plane = pl2,
                    StartedFrom = location,
                    Pilot = pilot,
                    Betaler = pilot,
                    StartType = start,
                    Description = "Demo flight",
                    LastUpdatedBy = pilot.ToString()
                },
                new Flight
                {
                    Departure = DateTime.Now.AddHours(-4),
                    Plane = pl2,
                    StartedFrom = location,
                    Pilot = pilot,
                    Betaler = pilot,
                    StartType = start,
                    LastUpdatedBy = pilot.ToString(),
                    Description = "Demo flight"
                },
                new Flight
                {
                    Departure = DateTime.Now.AddHours(-3).AddMinutes(10),
                    Plane = pl2,
                    StartedFrom = location,
                    Pilot = pilot,
                    Betaler = pilot,
                    StartType = start,
                    Description = "Demo flight",
                    LastUpdatedBy = pilot.ToString()
                }
            };
            return s;
        }
    }
}
