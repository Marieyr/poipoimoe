import React, { Component } from 'react';
import styles from './index.scss';

export class BasicLayout extends Component<{}, {}> {
  componentDidMount() {
    window.addEventListener('scroll', this.handleScroll);
  }
  componentWillUnmount(){
    window.removeEventListener('scroll',this.handleScroll);
  }

  handleScroll(event:Event) {
    let scrollTop=document.documentElement.scrollTop;
    if(scrollTop===0){

    }else
    {
      
    }
  }

  render() {
    return (
      <div>
        <header className={`${styles['poi-header']} noselect`}>
          <div className={styles['poi-logo']}></div>
          <div className={styles['poi-nav']}>
            <ul>
              <li>首页</li>
              <li>首页</li>
              <li>首页</li>
              <li>首页</li>
              <li>首页</li>
            </ul>
          </div>
          <div className={styles['poi-other']}></div>
        </header>
        {this.props.children}
        <footer className={styles['poi-footer']}></footer>
      </div>
    );
  }
}

export default BasicLayout;
