import React, { Component } from 'react';
import styles from './index.scss';

import {
  MainContainer,
  SideContainer,
  ArticleContainer,
  ArticleBlock,
  SideBlock,
} from '../components/MainContainer';

interface IArticleState {
  title: string;
  createDate: string;
  author: string;
  clickVolume: number;
  content: string;
}

export class index extends Component<{}, Array<IArticleState>> {
  constructor(props: {}) {
    super(props);
  }
  componentDidMount(){
    this.setState([
      
    ])
  }
  render() {
    let block;
    if (this.state=== null) {
      block = (
        <div>暂无数据</div>
      )
    } else {
      block = (
        this.state.forEach((k,v)=>{
          <ArticleBlock {...k}/>
        })
      );
    }

    return (
      <section>
        <div className={styles['poi-carousel']}>
          <img src={require('../assets/images/bg.jpg')} />
        </div>

        <MainContainer>
          <ArticleContainer/>
          <SideContainer>
            <SideBlock />
            <SideBlock />
          </SideContainer>
        </MainContainer>
      </section>
    );
  }
}

export default index;
