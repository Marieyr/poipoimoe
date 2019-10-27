import React, { Component } from 'react';

import styles from './index.scss';

interface IProp {}

/**
 * 主体容器
 */
export class MainContainer extends Component<IProp, {}> {
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
export class ArticleBlock extends Component{
    render(){
        return(
            <article className={styles['poi-article']}>
              <header>
                <h2>标题标题标题标题</h2>
                <p>日期：2019-10-24 作者：作者 浏览量：0</p>
              </header>
              <div>
                内容内容内容内容内容内容内容内容内容
                内容内容内容内容内容内容内容内容内容
                内容内容内容内容内容内容内容内容内容
                内容内容内容内容内容内容内容内容内容
                内容内容内容内容内容内容内容内容内容
                内容内容内容内容内容内容内容内容内容
                内容内容内容内容内容内容内容内容内容
                内容内容内容内容内容内容内容内容内容
                内容内容内容内容内容内容内容内容内容
              </div>
            {this.props.children}
            </article>
        )
    }
}
/**
 * 附加模块
 */
export class SideBlock extends Component{
    render(){
        return(
            <article className={styles['poi-side']}>{this.props.children}</article>
        )
    }
}

export default MainContainer;
