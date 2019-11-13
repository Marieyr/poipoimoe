import React from 'react';
import { connect } from 'dva';
import styles from './index.scss';

import { ArticleBlock, SideBlock } from '../../components/Block';

import {GlobalState} from '@/common/type';

function index({article}:GlobalState) {
  
  console.log(article.title)
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

const mapStateToProps=(article)=>{
  return article;
}

export default connect(mapStateToProps)(index);


