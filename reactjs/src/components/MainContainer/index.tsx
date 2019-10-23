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
            <article className={styles['poi-article']}>{this.props.children}</article>
        )
    }
}

export class SideBlock extends Component{
    render(){
        return(
            <article className={styles['poi-side']}>{this.props.children}</article>
        )
    }
}

export default MainContainer;
