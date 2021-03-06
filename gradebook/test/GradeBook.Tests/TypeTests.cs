using System;
using Xunit;

namespace GradeBook.Tests;

public class TypeTests
{
    [Fact]
    public void ValueTypesAlsoPassByValue()
    {
        var x = GetInt();
        SetInt(ref x);


    }

    private void SetInt(ref int z)
    {
        z = 42;
    }

    private int GetInt()
    {
        return 3;
    }

    [Fact]
    public void CsharpCanPassByRef()
    {

        var book1 = GetBook("Book 1");
        GetBookSetName(out book1, "New Name");

        Assert.Equal("New Name", book1.Name);


    }

    private void GetBookSetName(out Book book, string name)
    {
        book = new Book(name);




    }
    [Fact]
    public void CsharpIsPassByValue()
    {

        var book1 = GetBook("Book 1");
        GetBookSetName(book1, "New Name");

        Assert.Equal("Book 1", book1.Name);


    }

    private void GetBookSetName(Book book, string name)
    {
        book = new Book(name);




    }

    [Fact]
    public void CanSetNameFromReference()
    {

        var book1 = GetBook("Book 1");
        setname(book1, "New Name");

        Assert.Equal("New Name", book1.Name);
        
        
    }

    private void setname(Book book, string name)
    {
        book.Name = name;

        
       
    }

    [Fact]
    public void GetBookReturnsDifferentObjects()
    {
        
        var book1 = GetBook("Book 1");
        var book2 = GetBook("Book 2");


        Assert.Equal("Book 1", book1.Name);
        Assert.Equal("Book 2", book2.Name);
        Assert.NotSame(book1, book2);
    }

    [Fact]
    public void TwoVarscanReferenceSameObject()
    {

        var book1 = GetBook("Book 1");
        var book2 = book1;


        Assert.Same(book1, book2);  
        Assert.True(object.ReferenceEquals(book1, book2));
    }

    Book GetBook(string name)
    {
        return new Book(name);
    }
}