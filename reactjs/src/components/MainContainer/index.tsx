import React, { Component } from 'react';

import styles from './index.scss';

interface IArticleProp {
  title: string;
  createDate: string;
  author: string;
  clickVolume: number;
  content: string;
}

/**
 * 主体容器
 */
export class MainContainer extends Component {
  render() {
    return (
      <div className={styles['poi-body']}>
        <div className={styles['poi-container']}>{this.props.children}</div>
      </div>
    );
  }
}
/**
 * 文章容器
 */
export class ArticleContainer extends Component {
  render() {
    return <section className={styles['poi-articleContainer']}>{this.props.children}</section>;
  }
}

/**
 * 附加容器
 */
export class SideContainer extends Component {
  render() {
    return <section className={styles['poi-sideContainer']}>{this.props.children}</section>;
  }
}

/**
 * 文章模块
 */
export class ArticleBlock extends Component<IArticleProp, {}> {
  render() {
    return (
      <article className={styles['poi-article']}>
        <header>
          <h2>{this.props.title}</h2>
          <p>
            日期：{this.props.createDate} 作者：{this.props.author} 浏览量：{this.props.clickVolume}
          </p>
        </header>
        <div>
         {this.props.content}
        </div>
      </article>
    );
  }
}
/**
 * 附加模块
 */
export class SideBlock extends Component {
  render() {
    return <article className={styles['poi-side']}>{this.props.children}</article>;
  }
}

export default MainContainer;
