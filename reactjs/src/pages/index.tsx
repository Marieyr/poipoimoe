import React from 'react';
import styles from './index.scss';


export default function() {
  return (
    <section>
      <section className={styles['poi-carousel']}>
        <img src={require('../assets/images/bg.jpg')}/>
      </section>
      <section className={styles['poi-body']} />
    </section>
  );
}
