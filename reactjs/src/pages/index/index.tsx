import React, { Component } from 'react';
import { connect } from 'dva';
import styles from './index.scss';

import { ArticleBlock, SideBlock } from '../../components/Block';

function index() {
  return (
    <section>

      <div className={styles['poi-carousel']}>
        <img src={require('../../assets/images/bg.jpg')} />
      </div>

      <div className={styles['poi-body']}>
        <div className={styles['poi-container']}>

          <section className={styles['poi-articleContainer']}>
            <ArticleBlock />
          </section>

          <section className={styles['poi-sideContainer']}>
            <SideBlock />
          </section>

        </div>
      </div>
    </section>
  );
}

export default index;
