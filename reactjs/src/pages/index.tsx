import React, { Component } from 'react';
import styles from './index.scss';

import {
  MainContainer,
  SideContainer,
  ArticleContainer,
  ArticleBlock,
  SideBlock,
} from '../components/MainContainer';

interface IState {
  Article:Array<IArticle>
}
interface IArticle{
  title: string;
  createDate: string;
  author: string;
  clickVolume: number;
  content: string;
}

export class index extends Component<{}, IState> {
  constructor(props: {}) {
    super(props);
  }
  componentDidMount(){
    this.setState(
      {Article:[{title:"1",createDate:"",author:"",clickVolume:1,content:""}]}
    )
  }
  render() {
    let block;
    if (this.state === null) {
      block = (
        <div>暂无数据</div>
      )
    } else {
      block = (
        this.state.Article.forEach((k,v)=>{
          <ArticleBlock {...k}/>
          console.log(k)
        })
      );
    }

    return (
      <section>
        <div className={styles['poi-carousel']}>
          <img src={require('../assets/images/bg.jpg')} />
        </div>
        <MainContainer>
          <ArticleContainer />
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
