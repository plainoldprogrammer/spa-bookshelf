import React, { Component } from 'react';

export class Book extends Component {
  static displayName = Book.name;

  render () {
    return (
      <div>
        <h1>Books</h1>
        <hr />
        <p>List of Books</p>
      </div>
    );
  }
}
