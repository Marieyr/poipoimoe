import React from 'react';
import styles from './index.scss';

import {
  MainContainer,
  SideContainer,
  ArticleContainer,
  ArticleBlock,
  SideBlock,
} from '../components/MainContainer';

export default function() {
  return (
    <section>
      <div className={styles['poi-carousel']}>
        <img src={require('../assets/images/bg.jpg')} />
      </div>

      <MainContainer>
        <ArticleContainer>
          <ArticleBlock />
          <ArticleBlock />
          <ArticleBlock />
        </ArticleContainer>
        <SideContainer>
          <SideBlock />
          <SideBlock />
        </SideContainer>
      </MainContainer>
    </section>
  );
}
