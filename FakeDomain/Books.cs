using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakeDomainInterfaces;
using FakeDomainInterfaces.Models;
using FakeDomainInterfaces.Managers;

namespace FakeDomain
{
    public class Book : IBook
    {
        public int ISBN { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public class BooksManager : IBooksManager
    {
        public void DoSomethingNotDefinedByInterface()
        {

        }

        public IEnumerable<IBook> GetList()
        {
            return FakeTestData();
        }

        private IEnumerable<IBook> FakeTestData()
        {
            return new List<Book>()
            {
               new Book()
               {
                 Description = @"Here is Trump in action—how he runs his business and how he runs his life—as he meets the people he needs to meet, chats with family and friends, clashes with enemies, and changes the face of the New York City skyline. But even a maverick plays by rules, and Trump has formulated eleven guidelines for success. He isolates the common elements in his greatest deals; he shatters myths; he names names, spells out the zeros, and fully reveals the deal-maker’s art. And throughout, Trump talks—really talks—about how he does it. Trump: The Art of the Deal is an unguarded look at the mind of a brilliant entrepreneur and an unprecedented education in the practice of deal-making. It’s the most streetwise business book there is—and the ultimate read for anyone interested in achieving money and success, and knowing the man behind the spotlight.",
                 ISBN = 001,
                 Title = "The Art Of The Deal"
               },
               new Book()
               {
                 Description = @"McGrowl and Thomas are off on a wilderness adventure! But will the bionic bow-wow and his best friend be able to stop an evil duo from destroying their hometown?

Thomas's class is taking a trip to Devil's Island, and Thomas is bringing along his bionic best friend, McGrowl. Thomas and McGrowl can't wait to take part in all the fun nature activities. But the boy-and-dog dream team soon notice something fishy about the trip's leaders, Pop and Mamie Keeler. Could this pair possibly be the evil duo, back to cause more mayhem? And if so, will they use a dangerous volcano on the island to destroy Cedar Springs once and for all? It's up to Thomas and McGrowl to find out the truth about the Keelers and put a stop to their plans..before it's too late!",
                 ISBN = 002,
                 Title = "Every Dog Has His Day"
               },
               new Book()
               {
                 Description = @"Five years ago Trey Bouche found his best friend - with blood on his hands - standing over a body. Although Trey wanted to believe in his friend's innocence, he was forced to testify in court, and Jace was sent to prison for life. Trey returns determined to prove he was right. Even if it means losing the woman he still loves.

Summer Hill cannot forgive Trey, or his father, the chief of police, for the wrongs she feels they did to her family. When her brother escapes from Angola, Summer vows to keep her brother safe, no matter the cost. Falling back in love with Trey again isn't an option.

Now, five years later, the past begins to unravel. Reluctantly thrown together, Summer and Trey follow a twisted path that lead them to the truth - Jace didn't kill anyone and an entire town's ugly secret is unveiled. But more importantly, can Trey and Summer rediscover the love they lost?",
                 ISBN = 003,
                 Title = "Mississippi Blues"
               },
               new Book()
               {
                 Description = @"Moby-Dick; or, The Whale is a novel by Herman Melville, in which Ishmael narrates the monomaniacal quest of Ahab, captain of the whaler Pequod, for revenge on the albino sperm whale Moby Dick, which on a previous voyage destroyed Ahab's ship and severed his leg at the knee. Although the novel was a commercial failure and out of print at the time of the author's death in 1891, its reputation grew immensely during the twentieth century. D. H. Lawrence called it ""one of the strangest and most wonderful books in the world,"" and ""the greatest book of the sea ever written."" Moby-Dick is considered a Great American Novel and an outstanding work of the Romantic period in America and the American Renaissance. ""Call me Ishmael"" is one of world literature's most famous opening sentences. The product of a year and a half of writing, the book is dedicated to Nathaniel Hawthorne, ""in token of my admiration for his genius,"" and draws on Melville's experience at sea, on his reading in whaling literature, and on literary inspirations such as Shakespeare and the Bible. The detailed and realistic descriptions of whale hunting and of extracting whale oil, as well as life aboard ship among a culturally diverse crew, are mixed with exploration of class and social status, good and evil, and the existence of God. In addition to narrative prose, Melville uses styles and literary devices ranging from songs, poetry and catalogs to Shakespearean stage directions, soliloquies and asides. The author changed the title at the very last moment in September 1851. The work first appeared as The Whale in London in October 1851, and then under its definitive title Moby-Dick in New York in November. The whale, however, appears in both the London and New York editions as ""Moby Dick,"" with no hyphen. The British edition of five hundred copies was not reprinted during the author's life, the American of almost three thousand was reprinted three times at approximately 250 copies, the last reprinting in 1871. These figures are exaggerated because three hundred copies were destroyed in a fire at Harper's; only 3,200 copies were actually sold during the author's life.",
                 ISBN = 004,
                 Title = "Moby Dick"
               },
               new Book()
               {
                 Description = @"The only thing that astonishes Tony more than finding out that his new job is at a school for superheroes is finding out that most of the students aren't real superheroes. And when the school comes under the sights of a group of terrorist marketers, they could really use a superhero.",
                 ISBN = 005,
                 Title = "Mug Shot"
               },
               new Book()
               {
                 Description = "A book.",
                 ISBN = 006,
                 Title = "Sample Book Title"
               },
               new Book()
               {
                 Description = @"Clyde Dupee, pronounced ‘dupay’, much like men of his ilk, wanders through life in a drunken haze: drunk, sober, drunk, sober, two words repeated for a lifetime by men such as Clyde. A jailbird, an abysmal penny-ante burglar; he was certainly not someone the poised and proper Tharon McGee could ever consider appropriate. On work release from prison, Clyde takes time from his welding job to arrange studies for his GED, and Tharon, a former beauty queen, is his counselor. Twice burned and with very high standards, Tharon does not want to see any good in Clyde, but gradually comes to love him despite his flaws. Tharon is the path to sober, sober, sober. When an accident puts him in the hospital, Tharon reaches out to the family that had locked Clyde out years earlier, totally unprepared for the fireworks that ensue as the two prepare for their wedding. Marriage is not bliss for the two though, despite Clyde’s charm and Tharon’s love. As their family grows, Clyde’s demons return, drunk, sober, drunk, sober, threatening to destroy them all.",
                 ISBN = 007,
                 Title = "Show Me The Way"
               },
               new Book()
               {
                 Description = @"The Audacity of Hope is Barack Obama's call for a new kind of politics a politics that builds upon those shared understandings that pull us together as Americans. Lucid in his vision of America's place in the world, refreshingly candid about his family life and his time in the Senate, Obama here sets out his political convictions and inspires us to trust in the dogged optimism that has long defined us and that is our best hope going forward.",
                 ISBN = 008,
                 Title = "The Audacity Of Hope"
               }
            };
        }
    }

}
