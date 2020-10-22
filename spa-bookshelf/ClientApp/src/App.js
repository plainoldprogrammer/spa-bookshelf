import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Book } from './components/Book';
import { Author } from './components/Author';
import { Editorial } from './components/Editorial';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Book} />
        <Route path='/author' component={Author} />
        <Route path='/editorial' component={Editorial} />
      </Layout>
    );
  }
}
