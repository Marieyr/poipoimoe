import React from 'react';
import dva, { connect } from 'dva';
import styles from './index.scss';
import { ArticleBlock, SideBlock } from './components/Block';
import { GlobalState } from '@/common/type';

const banner = require('../../assets/images/bg.jpg');

function index({ articleList = [] }: GlobalState) {
  

  let list = articleList.map((item, key) => {
    return <ArticleBlock {...item} key={key} />;
  });

  return (
    <section>
      <div className={styles['poi-carousel']}>
        <img />
      </div>

      <div className={styles['poi-body']}>
        <div className={styles['poi-container']}>
          <section className={styles['poi-articleContainer']}>{list}</section>

          <section className={styles['poi-sideContainer']}>
            <SideBlock />
          </section>
        </div>
      </div>
    </section>
  );
}

const mapStateToProps = state => {
  return state.articles;
};

export default connect(mapStateToProps)(index);
