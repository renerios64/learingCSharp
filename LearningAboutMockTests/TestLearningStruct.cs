﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningAboutMockTests
{
    struct Books {
        public string Title;
        public int PageCount;
        public string Author;
        public Guid BookId;
        public string Subject;
    };

    struct Books2 {
        public string Title;
        public int PageCount;
        public string Author;
        public Guid BookId;
        public string Subject;

        public string MakeSingleLine()
        {
            return "Title: " + Title + "\nPage Count: " + PageCount.ToString() + "\nAuthor: " + Author + "\nBookId: " + BookId.ToString() + "\nSubject: " + Subject;
        }
    }

    struct Books3 : IPrintable
    {
        public void PrintRene()
        {
            Console.WriteLine("Rene");
        }
    }

    interface IPrintable
    {
        void PrintRene();
    }

    class TestLearningStruct
    {
        [Test]
        public void CanCreateABook()
        {
            Books Book2;

            //Structs are value types

            Book2 = new Books();

            Assert.IsNotNull(Book2);

            Book2.Title = "Boom";
            Book2.PageCount = 200;
            Book2.Author = "Rene Rios";
            Book2.BookId = new Guid();
            Book2.Subject = "SciFi";
        }

        [Test]
        public void CanCreateABook2()
        {
            Books2 Book1;

            Book1.Title = "Boom";
            Book1.PageCount = 200;
            Book1.Author = "Rene Rios";
            Book1.BookId = new Guid();
            Book1.Subject = "SciFi";

            Assert.IsNotNull(Book1);

            StringAssert.Contains("Title: Boom\nPage Count: 200\nAuthor: Rene Rios", Book1.MakeSingleLine());

            //Structs cannot inherit 
            //Structs can have interfaces
            //Structs can only have private and public members
            //Structs only have default constructor that cannot be modified.
        }
    }
}
