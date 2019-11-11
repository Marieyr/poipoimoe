import React from 'react';
import { connect } from 'dva';
import styles from './index.scss';

import { ArticleBlock, SideBlock } from '../../components/Block';

export default function() {
  return (
    <section>

      <div className={styles['poi-carousel']}>
        <img src={require('../../assets/images/bg.jpg')} />
      </div>

      <div className={styles['poi-body']}>
        <div className={styles['poi-container']}>

          <section className={styles['poi-articleContainer']}>
            <ArticleBlock />
            <ArticleBlock />
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


