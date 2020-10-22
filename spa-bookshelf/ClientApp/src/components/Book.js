import React, { Component } from 'react';

export class Book extends Component {
  static displayName = Book.name;

  constructor(props) {
    super(props);
    this.state = { books: [], loading: true };
  }

  componentDidMount() {
    this.getAllBooks();
  }

  static renderBooksTable(books) {
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Title</th>
            <th>Author</th>
            <th>Editorial</th>
            <th>Year of Publication</th>
          </tr>
        </thead>
        <tbody>
          {books.map(book => 
            <tr key={book.Title}>
              <td>{book.title}</td>
              <td>{book.author}</td>
              <td>{book.editorial}</td>
              <td>{book.yearOfPublication}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render () {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : Book.renderBooksTable(this.state.books);

    return (
      <div>
        <h1 id="booksTable">Books</h1>
        {contents}
      </div>
    );
  }

  async getAllBooks() {
    const response = await fetch('book/all');
    const data = await response.json();
    this.setState({ books: data, loading: false});
  }
}
