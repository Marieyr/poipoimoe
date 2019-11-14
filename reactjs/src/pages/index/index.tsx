import React from 'react';
import dva, { connect } from 'dva';
import styles from './index.scss';

import { ArticleBlock, SideBlock } from '../../components/Block';

import {GlobalState} from '@/common/type';

const banner=require('../../assets/images/bg.jpg');


function index({article}:GlobalState) {
  
  console.log(article.title)
  
  return (
    <section>

      <div className={styles['poi-carousel']}>
        <img src={banner} />
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


