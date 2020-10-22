import React, { Component } from 'react';

export class Editorial extends Component {
  static displayName = Editorial.name;

  constructor(props) {
    super(props);
    this.state = { editorials: [], loading: true };
  }

  componentDidMount() {
    this.getAllEditorials();
  }

  static renderEditorialsTable(editorials) {
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Name</th>
            <th>Foundation</th>
            <th>Origin</th>
            <th>Founder(s)</th>
          </tr>
        </thead>
        <tbody>
          {editorials.map(editorial =>
            <tr key={editorial.name}>
              <td>{editorial.name}</td>
              <td>{editorial.founded}</td>
              <td>{editorial.origin}</td>
              <td>{editorial.founder}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : Editorial.renderEditorialsTable(this.state.editorials);

    return (
      <div>
        <h1 id="tabelLabel" >Editorials</h1>
        {contents}
      </div>
    );
  }

  async getAllEditorials() {
    const response = await fetch('editorial/all');
    const data = await response.json();
    this.setState({ editorials: data, loading: false });
  }
}
