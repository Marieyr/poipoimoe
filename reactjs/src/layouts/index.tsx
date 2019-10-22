import React from 'react';

import Nav from '../components/HorizontalMenu';
import Footer from '../components/Footer';

import styles from './index.scss';

const BasicLayout: React.FC = props => {
  return (
    <div>
      <Nav />
      {props.children}
     <Footer/>
    </div>
  );
};

export default BasicLayout;
