# Library Manager

The Library Manager project is a web API built using ASP.NET Core and Entity Framework Core. It allows users to manage books and authors in a library system. Users can perform CRUD operations (Create, Read, Update, Delete) on both books and authors.

## Functionality

The API supports the following functionalities:

### Books
- Retrieve a list of all books.
- Retrieve a single book by its unique ID.
- Add a new book to the library with its title, description, and author.
- Update an existing book's title, description, or author.
- Delete a book from the library.

### Authors
- Retrieve a list of all authors.
- Retrieve a single author by their unique ID.
- Add a new author to the library with their name.
- Update an existing author's name.
- Delete an author from the library (Note: When an author is deleted, all their associated books will be deleted as well).

### Features
- Create a dictionary or list, populate it with several values, retrieve at least one value, and use it in your program
- Make your application a CRUD API
- Make your application asynchronous
- Have 2 or more tables (entities) in your application that are related and have a function return data from both entities.  In entity framework, this is equivalent to a join

## Usage

To use the Library Manager API, you can perform HTTP requests using Swagger

### Book JSON Object

```json
{
  "title": "Botany for Gardeners",
  "description": "An informative guide to the science of botany, specifically tailored for gardeners and plant enthusiasts.",
  "author": {
    "name": "Brian Capon"
  }
}

{
  "title": "The Botany of Desire",
  "description": "Explores the co-evolution of plants and humans through the lens of four popular crops: apples, tulips, marijuana, and potatoes.",
  "author": {
    "name": "Michael Pollan"
  }
}

{
  "title": "Botany in a Day",
  "description": "An easy-to-use guide that helps readers identify plants by family, based on the principle of botanical patterns.",
  "author": {
    "name": "Thomas J. Elpel"
  }
}

