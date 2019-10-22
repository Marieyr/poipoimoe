import React, { Component } from 'react';
import styles from './index.scss';

export default class index extends Component {
    constructor(props:any) {
        super(props);
        
      }

      componentDidMount() {
        window.addEventListener('scroll', this.handleScroll);
      }
      componentWillUnmount() {
        window.removeEventListener('scroll', this.handleScroll);
      }
    
      handleScroll(event: Event) {
        let scrollTop = document.documentElement.scrollTop;
        if (scrollTop === 0) {
          
        } else {
        }
      }

    render() {
        return (
            <div>
                <header className={`${styles['poi-header']} noselect`}>
          <div className={styles['poi-logo']} />
          <div className={styles['poi-nav']}>
            <ul>
              <li>首页</li>
              <li>首页</li>
              <li>首页</li>
              <li>首页</li>
              <li>首页</li>
            </ul>
          </div>
          <div className={styles['poi-other']} />
        </header>
            </div>
        )
    }
}
