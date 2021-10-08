using Books.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Books.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
{
}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                 new Author()
                 {
                     Id = 1,
                     FirstName = "George",
                     LastName = "RR Martin"
                 },
                new Author()
                {
                    Id = 2,
                    FirstName = "Stephen",
                    LastName = "Fry"
                },
                new Author()
                {
                    Id = 3,
                    FirstName = "James",
                    LastName = "Elroy"
                },
                new Author()
                {
                    Id = 4,
                    FirstName = "Douglas",
                    LastName = "Adams"
                });

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    AuthorId = 1,
                    Title = "The Winds of Winter",
                    Description = "The book that seems impossible to write."
                },
                new Book
                {
                    Id = 2,
                    AuthorId = 2,
                    Title = "A Game of Thrones",
                    Description = "A Game of Thrones is the first novel in A Song of Ice and Fire, a series of fantasy novels by American author George R. R. ... In the novel, recounting events from various points of view, Martin introduces the plot-lines of the noble houses of Westeros, the Wall, and the Targaryens."
                },
                new Book
                {
                    Id = 3,
                    AuthorId = 3,
                    Title = "Mythos",
                    Description = "The Greek myths are amongst the best stories ever told, passed down through millennia and inspiring writers and artists as varied as Shakespeare, Michelangelo, James Joyce and Walt Disney.  They are embedded deeply in the traditions, tales and cultural DNA of the West.You'll fall in love with Zeus, marvel at the birth of Athena, wince at Cronus and Gaia's revenge on Ouranos, weep with King Midas and hunt with the beautiful and ferocious Artemis. Spellbinding, informative and moving, Stephen Fry's Mythos perfectly captures these stories for the modern age - in all their rich and deeply human relevance."
                },
                new Book
                {
                    Id = 4,
                    AuthorId = 4,
                    Title = "American Tabloid",
                    Description = "American Tabloid is a 1995 novel by James Ellroy that chronicles the events surrounding three rogue American law enforcement officers from November 22, 1958 through November 22, 1963. Each becomes entangled in a web of interconnecting associations between the FBI, the CIA, and the mafia, which eventually leads to their collective involvement in the John F. Kennedy assassination."
                },
                new Book
                {
                    Id = 5,
                    AuthorId = 2,
                    Title = "The Hitchhiker's Guide to the Galaxy",
                    Description = "In The Hitchhiker's Guide to the Galaxy, the characters visit the legendary planet Magrathea, home to the now-collapsed planet-building industry, and meet Slartibartfast, a planetary coastline designer who was responsible for the fjords of Norway. Through archival recordings, he relates the story of a race of hyper-intelligent pan-dimensional beings who built a computer named Deep Thought to calculate the Answer to the Ultimate Question of Life, the Universe, and Everything."
                }
                );

            base.OnModelCreating(modelBuilder);

        }
    }
}
