import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

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
