using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaMattersv2.Models.Books
{
    public class BookRepository : IBookRepository
    {
        public Book getBookByTitle(string title)
        {
            return getBooks().FirstOrDefault(p => p.title == title);
        }

        public IEnumerable<Book> getBooks() =>
            new List<Book>
            {
                new Book{ ISBN="0-06-196955-9", lastName="Lore", firstName="Pittacus", title="I Am Number Four", edition="1st", publishedDate="August 3, 2010", image="~/lib/images/Books/IAmNumberFour.jpg", notes="The first book in the Lorien Legacies series, this book takes you into a world very much like our own but tells the story of some teenagers that happen to be from another planet, have super powers, and are being hunted to death by an alien race, all while trying to survive on a planet that isn't their home, Earth." },
                new Book{ ISBN="0-7475-4215-5", lastName="Rowling", firstName="J.K.", title="Harry Potter and The Prisoner of Azkaban", edition="1st", publishedDate="July 8, 1999", image="~/lib/images/Books/HarryPotterAndThePrisonerOfAzkaban.jpg", notes="The Harry Potter series is the reason I read as much as I do nowadays. I read them as they released growing up and they have been a part of my life more than I'd like to admit. This book just happens to be my favorite in the series." },
                new Book{ ISBN="978-1543628616", lastName="Matharu", firstName="Taran", title="The Novice", edition="1st", publishedDate="May 5th, 2015", image="~/lib/images/Books/TheNovice.jpg", notes="In a world of Elves, Dwarves and Orcs, one Human boy finds out that he's a special type of person, one that can summon monsters to fight in battle alongside him. This book series tells a D&D type story that I've used bits and pieces of myself to add into my own D&D games." },
                new Book{ ISBN="978-0765311788", lastName="Sanderson", firstName="Brandon", title="Mistborn: The Final Empire", edition="1st", publishedDate="July 17, 2006", image="~/lib/images/Books/MistbornTheFinalEmpire.jpg", notes="Being able to control metal is one thing but being able to feel emotions, or force others to feel a specific emotion is just a small amount of the power that a mistborn gets in this book series. The world has been overthrown by someone who can live forever and the story told trying to overthrow that person is just amazing." },
                new Book{ ISBN="978-1-524-76328-2", lastName="Cline", firstName="Ernest", title="Ready Player One", edition="1st", publishedDate="August 16, 2011", image="~/lib/images/Books/ReadyPlayerOne.jpg", notes="The story of a young boy who lives his life in a video game, and that life is turned upside down when he's the first to solve a riddle that has been around for years. The journey that this book goes through is an amazingly epic story that everyone should read." },
            };
    }
}
