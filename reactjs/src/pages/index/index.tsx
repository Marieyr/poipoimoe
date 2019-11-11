import React from 'react';
import { connect } from 'dva';
import styles from './index.scss';

import { ArticleBlock, SideBlock } from '../../components/Block';

function index(props) {
  console.log(props.text)
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
function mapStateToProps(state){
  return {
    text:state.articles.text
  }
}
export default connect(mapStateToProps)(index);


